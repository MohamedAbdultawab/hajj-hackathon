//
//  MapVC.swift
//  HajjICM2
//
//  Created by Muhammad on 01/08/2018.
//  Copyright © 2018 Muhammad. All rights reserved.
//

import UIKit
import MapKit

class MapVC: UIViewController, CLLocationManagerDelegate, MKMapViewDelegate {
    
    
    @IBOutlet weak var MKMapView: MKMapView!
    
     var locationManager:CLLocationManager!
    // to store user's location
    //var latitude: CLLocationDegrees = 0
    //var longitude: CLLocationDegrees = 0
    
    @IBOutlet weak var nameLbl: UILabel!
    
    @IBOutlet weak var groupnumberText: UITextField!
    
    @IBOutlet weak var switchGroup: UISwitch!
    
    @IBOutlet weak var groupnumberLbl: UILabel!
    override func viewDidLoad() {
        super.viewDidLoad()
        
        locationManager = CLLocationManager()
        locationManager.delegate = self
        locationManager.desiredAccuracy = kCLLocationAccuracyBest
        locationManager.requestWhenInUseAuthorization()
        locationManager.startUpdatingLocation()
        
        
      
        
        
        nameLbl.text = nameCharger
        groupnumberLbl.text = groupcount
        
        //activityIndicator.startAnimating()

        // Do any additional setup after loading the view.
    }
    
    
    
    
    @IBAction func submitTapped(_ sender: Any) {
        
        
    }
    
    func locationManager(_ manager: CLLocationManager, didUpdateLocations locations: [CLLocation]) {
        
        
        
        // ************************************************************************
        // Show user's Location on mapView
        // ************************************************************************
        
        // to identify user's current location
        let location:CLLocationCoordinate2D = manager.location!.coordinate
        latitude = location.latitude
        longitude = location.longitude
        print(latitude)
        print(longitude)
       
        //print("locations = \(location.latitude) \(location.longitude)")
        
        let center = CLLocationCoordinate2D(latitude: location.latitude, longitude: location.longitude)
        let region = MKCoordinateRegion(center: center, span: MKCoordinateSpan(latitudeDelta: 0.04, longitudeDelta: 0.04))
        self.MKMapView.setRegion(region, animated: true)
        self.MKMapView.removeAnnotations(MKMapView.annotations)
        
  
        // the user's location is Here
        let pinLocation : CLLocationCoordinate2D = CLLocationCoordinate2DMake(location.latitude, location.longitude)
        let objectAnnotation = MKPointAnnotation()
        objectAnnotation.coordinate = pinLocation
        objectAnnotation.title = "موقعك الحالي"
        objectAnnotation.subtitle = groupcount
        self.MKMapView.addAnnotation(objectAnnotation)
        
        //Destination -Mena
        let destinationLocation : CLLocationCoordinate2D = CLLocationCoordinate2DMake(21.415663, 39.894431)
        let destinationPin = MKPointAnnotation()
        destinationPin.coordinate = destinationLocation
        destinationPin.title = "منى"
        destinationPin.subtitle = "Here"
        self.MKMapView.addAnnotation(destinationPin)
        
        //Jmarat
        let jamarat : CLLocationCoordinate2D = CLLocationCoordinate2DMake(21.415663, 39.894431)
        let jamaratPin = MKPointAnnotation()
        jamaratPin.coordinate = jamarat
        jamaratPin.title = "الجمرات"
        jamaratPin.subtitle = "Here"
        self.MKMapView.addAnnotation(jamaratPin)
        
        //Arfat
        let Arfat : CLLocationCoordinate2D = CLLocationCoordinate2DMake(21.356243, 39.984073)
        let arfatPin = MKPointAnnotation()
        arfatPin.coordinate = Arfat
        arfatPin.title = "عرفات"
        arfatPin.subtitle = "Here"
        self.MKMapView.addAnnotation(arfatPin)
        
        
        //Mozdallefa
        let Mozdallefa : CLLocationCoordinate2D = CLLocationCoordinate2DMake(21.399174, 39.902515)
        let MozdallefaPin = MKPointAnnotation()
        MozdallefaPin.coordinate = Mozdallefa
        MozdallefaPin.title = "مزدلفة"
        MozdallefaPin.subtitle = "Here"
        self.MKMapView.addAnnotation(MozdallefaPin)
        
        
        
        let sourcePlaceMark = MKPlacemark(coordinate: pinLocation)
        let destinationPlaceMark = MKPlacemark(coordinate: destinationLocation)
        
        let directionRequest = MKDirectionsRequest()
        directionRequest.destination = MKMapItem(placemark: destinationPlaceMark)
        directionRequest.transportType = .automobile
        
        let directions = MKDirections(request: directionRequest)
        directions.calculate { (response, error) in
            guard let directionResonse = response else {
                if let error = error {
                    print("we have error getting directions==\(error.localizedDescription)")
                }
                return
            }
            
            let route = directionResonse.routes[0]
            self.MKMapView.add(route.polyline, level: .aboveRoads)
            
            let rect = route.polyline.boundingMapRect
            self.MKMapView.setRegion(MKCoordinateRegionForMapRect(rect), animated: true)
            
        
        }
        
        self.MKMapView.delegate = self
        
        
        
        
        
        
        
        
        
        // to convert the user's current location to show on Label and store to database
        let userLocation:CLLocation = locations[0]
        
        // to show address on addressLable
        
        CLGeocoder().reverseGeocodeLocation(userLocation, completionHandler: { (placemarks, error) -> Void in
            
            if (error != nil) {
                
                //print(error)
                
            } else {
                
                if let p = placemarks?[0] {
                    
                    // print(p)
                    
                    var subThoroughfare:String = ""
                    var p1:String = ""
                    var p2:String = ""
                    var p3:String = ""
                    var p4:String = ""
                    
                    // number of street
                    if (p.subThoroughfare != nil) {
                        
                        subThoroughfare = p.subThoroughfare!
                        
                        
                    }
                    
                    // street
                    if (p.thoroughfare != nil)
                    {
                        
                        p1 = p.thoroughfare!
                        
                    }
                    
                    // city
                    if (p.locality != nil)
                    {
                        
                        p2 = p.locality!
                        
                    }
                    
                    // city
                    if (p.administrativeArea != nil)
                    {
                        
                        p3 = p.administrativeArea!
                        
                    }
                    
                    // country
                    if (p.country != nil)
                    {
                        
                        p4 = p.country!
                        
                    }
      
                    
                    /*self.addressLbl.text = "\(subThoroughfare) \(p.thoroughfare) \(p.subLocality) \(p.subAdministrativeArea) \(p.postalCode) \(p.country)"*/
                    
                    /*self.addressLbl.text = "\(subThoroughfare) \(p.thoroughfare), \(p.subLocality) , \(p.subAdministrativeArea) , \(p.country)"*/
                    
                   // addresslabel = "\(subThoroughfare) \(p1) \(p2),\(p3), \(p4)"
                    //self.addressLbl.text = addresslabel
                   // self.activityIndicator.stopAnimating()
                    
                    
                    
                }
                
                
            }
            
        })
        

        
        //   print("latitude = \(userLocation.coordinate.latitude)")
        
        //  print("longitude = \(userLocation.coordinate.longitude)")
        
        
        
        
        
    }
    
    
    func mapView(_ mapView: MKMapView, rendererFor overlay: MKOverlay) -> MKOverlayRenderer {
        let renderer = MKPolylineRenderer(overlay: overlay)
        renderer.strokeColor = UIColor.blue
        renderer.lineWidth = 4.0
        return renderer
    }
    
    

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }
    

 

}
