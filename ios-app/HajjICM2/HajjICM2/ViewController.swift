//
//  ViewController.swift
//  HajjICM2
//
//  Created by Muhammad on 01/08/2018.
//  Copyright © 2018 Muhammad. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    
    
    //var idCharger =  ""
    //var newnameCharger = nameCharger
    
    
    
    @IBOutlet weak var emailText: UITextField!
    @IBOutlet weak var passwordText: UITextField!
    @IBOutlet weak var activityIndicator: UIActivityIndicatorView!
    
    

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
    }
    
    
    
    @IBAction func loginTapped(_ sender: Any) {
        
        
        
        if emailText.text!.isEmpty || passwordText.text!.isEmpty {
            
            
            let alertController = UIAlertController(title: "login Failed!", message: "Please fill in all fields",preferredStyle: .alert)
            let OKAction = UIAlertAction(title: "OK", style: .default) { (action) in }; alertController.addAction(OKAction)
            self.present(alertController, animated: true) { }
            
            
        }
            
        else {
            
            
            //self.performSegue(withIdentifier: "loginOK", sender: self)
            //self.performSegue(withIdentifier: <#T##String#>, sender: <#T##Any?#>)
            
            
            
            // contact with database to login
            
            activityIndicator.startAnimating()
            
            
            
            // remove keyboard
            // self.view.endEditing(true)
            
            // shortcuts
            let email = emailText.text!
            let password = passwordText.text!
  
            
            //created NSURL
            let requestURL = NSURL(string: "https://www.mshwark.com/hackathon/login.php")
            
            //creating NSMutableURLRequest
            let request = NSMutableURLRequest(url: requestURL! as URL)
            
            //setting the method to post
            request.httpMethod = "POST"
           
            
            //creating the post parameter by concatenating the keys and values from text field
            let postParameters = "demail="+email+"&password="+password;
            
            //adding the parameters to request body
            request.httpBody = postParameters.data(using: String.Encoding.utf8)
            
            
            //creating a task to send the post request
            let task = URLSession.shared.dataTask(with: request as URLRequest){
                data, response, error in
                
                if error != nil{
                    print("error is \(error)")
                    return;
                }
                
                //parsing the response
                do {
                    //converting resonse to NSDictionary
                    let myJSON =  try JSONSerialization.jsonObject(with: data!, options: .mutableContainers) as? NSDictionary
                    
                    
                    
                    let did = myJSON!["did"] as? String
                    let fullname = myJSON!["dfullname"] as? String
                    let groupnumber = myJSON!["groupcount"] as? String
                    
                    // successfully logged in
                    if did != nil {
                        
                        // save user information we received from our host
                        //UserDefaults.standard.set(myJSON, forKey: "myJSON")
                        //let user = UserDefaults.standard.value(forKey: "myJSON") as? NSDictionary?
                        
                        
                        // print ("you'r login in")
                        print (myJSON!)
                        print (did!)
                        print (fullname!)
                        idCharger = did!
                        nameCharger = fullname!
                        groupcount = groupnumber!
                      
                        // Logged in successfully
                        DispatchQueue.main.async {
                            self.performSegue(withIdentifier: "loginOK", sender: self)
                            // appDelegate.login()
                        }
                        
                        
                        
                        // error
                    } else {
                        
                        
                        DispatchQueue.main.async {
                            let alertController = UIAlertController(title: "لا يمكن الدخول", message: "تأكد من كلمة المرور أو أن الحساب غير مفعل بعد", preferredStyle: .alert)
                            let OKAction = UIAlertAction(title: "OK", style: .default) { (action) in }
                            alertController.addAction(OKAction)
                            self.present(alertController, animated: true) { }
                        }
            
                        
                    }
                    
                    
                    //parsing the json
                    /*if let parseJSON = myJSON {
                        
                        //creating a string
                        var msg : String!
                        
                        //getting the json response
                        msg = parseJSON["message"] as! String?
                        
                        //printing the response
                        print(msg)
                        
                        // Logged in successfully
                        DispatchQueue.main.async {
                            self.performSegue(withIdentifier: "loginOK", sender: self)
                            // appDelegate.login()
                        }
                        
                    }*/
                } catch {
                    print(error)
                }
                
            }
            //executing the task
            task.resume()
            
        
            
        }
        
        
    }
    

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }


}

