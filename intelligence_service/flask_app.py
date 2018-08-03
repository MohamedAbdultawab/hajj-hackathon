from flask import Flask, Response, jsonify
import json
from flask_restplus import Api, Resource, fields, reqparse
from flask_cors import CORS, cross_origin
import os
# load the algo
# from .routing import *
from routing import api_end_point as algo

# the app
app = Flask("python_project")
CORS(app)
api = Api(app, version='1.0', title='APIs for Python Functions', validate=False)
ns = api.namespace('routing', 'Returns a list of routing recommendations for hajj campaigns')


# model the input data
model_input = api.model('Enter JSON String:',
                        {"json_string": fields.String()})

# On Bluemix, get the port number from the environment variable PORT # When running this app on the local machine, default to 8080

port = int(os.getenv('PORT', 9999))

# The ENDPOINT


@ns.route('/')
# the endpoint
class HAJJICM(Resource):
    @api.response(200, "Success", model_input)
    @api.expect(model_input)
    def post(self):
        parser = reqparse.RequestParser()
        parser.add_argument('json_string', type=str)
        args = parser.parse_args()
        inp = str(args["json_string"])
        result = algo(inp)
        return json.dumps(result)


# run
if __name__ == '__main__':
    app.run(host='0.0.0.0', port=port, debug=False)  # deploy with debug=False
