import googlemaps
from geopy.distance import geodesic
from datetime import datetime
import json
from copy import deepcopy


def get_routes(start, end, mode=None, alternatives=False, lang=None):
    gmaps = googlemaps.Client(key='AIzaSyD5amgPOrrJtX2gJWb1NSFTvWmNrRs5vC0')

    if mode.lower() == 'transit':
        # Request directions via public transit
        now = datetime.now()
        routes = gmaps.directions(start,
                                  end,
                                  mode="transit",
                                  transit_mode="bus",
                                  alternatives=alternatives,
                                  language=lang,
                                  departure_time=now)
        if not len(routes):
            now = datetime.now()
            routes = gmaps.directions(start,
                                      end,
                                      mode="driving",
                                      departure_time=now)
    else:
        now = datetime.now()
        routes = gmaps.directions(start,
                                  end,
                                  mode="walking",
                                  departure_time=now)
    new_routes = []
    for route in routes:
        new_routes.append(clean_route(route))
    return new_routes


def clean_route(route):
    new_route = {}

    end_location = dict(route['legs'][0]['end_location'].items())
    end_location['latitude'] = deepcopy(end_location['lat'])
    end_location['longitude'] = deepcopy(end_location['lng'])
    del end_location['lat'], end_location['lng']
    start_location = dict(route['legs'][0]['start_location'].items())
    start_location['latitude'] = deepcopy(start_location['lat'])
    start_location['longitude'] = deepcopy(start_location['lng'])
    del start_location['lat'], start_location['lng']

    new_route['end_location'] = Coordinate(**end_location)
    new_route['start_location'] = Coordinate(**start_location)
    new_route['steps'] = [new_route['start_location']]

    for _step in route['legs'][0]['steps']:
        try:
            for step in _step['steps']:
                step['end_location']['latitude'] = deepcopy(step['end_location']['lat'])
                step['end_location']['longitude'] = deepcopy(step['end_location']['lng'])
                del step['end_location']['lat'], step['end_location']['lng']
                new_route['steps'].append(Coordinate(**step['end_location']))
        except KeyError:

            _step['end_location']['latitude'] = deepcopy(_step['end_location']['lat'])
            _step['end_location']['longitude'] = deepcopy(_step['end_location']['lng'])
            del _step['end_location']['lat'], _step['end_location']['lng']
            new_route['steps'].append(Coordinate(**_step['end_location']))

    return Route(new_route['steps'])


class Coordinate():
    def __init__(self, latitude, longitude):
        self.latitude = latitude
        self.longitude = longitude

    def __eq__(self, other):
        return self.distance(other) < 0.5

    def get_lat(self):
        return self.latitude

    def get_lng(self):
        return self.longitude

    def get_coordinates(self):
        return (self.get_lat(), self.get_lng())

    def cord_2_dict(self):
        return {'latitude': self.latitude, 'longitude': self.longitude}

    def distance(self, other):
        return geodesic(self.get_coordinates(),
                        other.get_coordinates()).miles


class Campaign():

    def __init__(self,
                 Id,
                 number_of_people,
                 nav_type,
                 current_loc,
                 target_loc):
        self.Id = Id
        self.count = number_of_people
        self.nav = nav_type
        self.current_loc = current_loc
        self.target_loc = target_loc

    def get_id(self):
        return self.Id

    def get_people_num(self):
        return self.count

    def get_nav_type(self):
        return self.nav

    def get_current_loc(self):
        return self.current_loc.get_coordinates()

    def get_target_loc(self):
        return self.target_loc.get_coordinates()

    # def __repr__(self):
    #     return str(self.Id) + str(self.count) + str(self.nav) + str(self.current_loc) + str(self.target_loc)


# I will get a list of campaign objects

class Route():
    """docstring for route"""

    def __init__(self, coordinates, width=None, length=None):
        self.coordinates = [Coordinate(*coordinate.get_coordinates()) for coordinate in coordinates]
        self.width = width
        self.length = geodesic(coordinates[0].get_coordinates(),
                               coordinates[-1].get_coordinates()).miles

    def route_2_dict(self):
        return [coordinate.cord_2_dict() for coordinate in self.coordinates]


# harm_1 = Coordinate(21.423323, 39.826399)
# harm_2 = Coordinate(21.423315, 39.826380)
# harm_3 = Coordinate(21.423300, 39.826360)
# # arfa = Coordinate(**dict({'lat': 21.354885, 'lng': 39.984116}.items()))
# mina = Coordinate(**dict({'latitude': 21.414605, 'longitude': 39.894564}.items()))

# x1 = get_routes(mina.get_coordinates(),
#                 harm_1.get_coordinates(),
#                 "walking", alternatives=True)
# x2 = get_routes(mina.get_coordinates(),
#                 harm_2.get_coordinates(),
#                 "walking", alternatives=True)
# x3 = get_routes(mina.get_coordinates(),
#                 harm_3.get_coordinates(),
#                 "walking", alternatives=True)
# y1 = json.dumps(x1[0].route_2_dict())
# y2 = json.dumps(x2[0].route_2_dict())
# y3 = json.dumps(x3[0].route_2_dict())

type_dict = {1: 'walking', 2: 'transit'}


def load_json(json_string):

    if json_string[-1] != ']':
        json_string = "[" + json_string + "]"
    obj = json.loads(json_string)
    campaigns = []
    for camp in obj:
        current_loc = Coordinate(**camp['currentCoordinate'])
        target_loc = Coordinate(**camp['targetCoordinate'])
        campaigns.append(Campaign(camp['id'],
                                  camp['actualNumberOfPeople'],
                                  type_dict[camp['type']],
                                  current_loc,
                                  target_loc))
    return campaigns


def api_end_point(json_string):

    campaigns = load_json(json_string)
    routes = {}
    for camp in campaigns:
        routes[camp.get_id()] = get_routes(camp.get_current_loc(),
                                           camp.get_target_loc(),
                                           mode='walking',
                                           alternatives=True)

    print(routes)
    new_routes = []
    for tup in routes.items():
        if tup[1]:
            tup = tup[0], tup[1][0].route_2_dict()
            new_routes.append(tup)

    new_routes = json.dumps(new_routes)
    return new_routes
