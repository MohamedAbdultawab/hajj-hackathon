<?php
/**
 * Created by Muhammad ALrashidi.
 * User: Hackthon
 */



// STEP 1. Declare variables to store user information
// array will store all informaiton
if ( empty($_REQUEST["demail"]) || empty($_REQUEST["password"])) {

    $returnArray["status"] = "400";
    $returnArray["message"] = "Missing required information";
    return;

}

// Secure parsing of username and password variables
$email = htmlentities($_REQUEST["demail"]);
$password = htmlentities($_REQUEST["password"]);



// STEP 2. Build Connection
// Secure way to store Connection Infromation
//$file = parse_ini_file("../../mshwark.ini");   // accessing the file with connection infromation

// retrieve data from file
$host = "localhost";
$user = "mshwark_hack";
$pass = "050050";
$name = "mshwark_hackathon";

// include MySQLDAO.php for connection and interacting with db
require("secure/access_hackathon.php");

// running MySQLDAO Class with constructed variables
$access = new access($host, $user, $pass, $name);
$access->connect();   // launch opend connection function



// STEP 3. Get user
$user = $access->getDriver($email);

if (empty($user)) {

    $returnArray["status"] = "403";
    $returnArray["message"] = "User is not found";
    echo json_encode($returnArray);
    return;

}



// STEP 4. Check validity of entered user information and information from database
// 4.1 Get password and salt from database
$secure_password = $user["password"];
//$salt = $user["salt"];
//$emailConfirmed = $user["emailConfirmed"]; // to make sure Driver is activited


// 4.2 Check if entered passwords match with password from database
//if ($secure_password == sha1($password . $salt)) {
if ($secure_password == $password ) {

    $returnArray["status"] = "200";
    $returnArray["message"] = "Logged in successfully";
    $returnArray["did"] = $user["did"];
    $returnArray["demail"] = $user["demail"];
    $returnArray["dfullname"] = $user["fullname"];
    $returnArray["groupcount"] = $user["groupcount"];
    $returnArray["level_user"] = $user["level_user"];
    $returnArray["success"] = true;



    echo json_encode($returnArray);
    return;

} else {

    $returnArray["status"] = "403";
    $returnArray["message"] = "Password do not match Or your account is not active";
    echo json_encode($returnArray);
    return;

}


// STEP 5. Close connection after registration
$access->disconnect();



// STEP 6. JSON data
echo json_encode($returnArray);




?>
