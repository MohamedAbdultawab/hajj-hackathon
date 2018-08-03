<?php
/**
 * Created by Muhammad ALrashidi.
 * User: Hackthon
 */


// Declare classe to access this php file
class access {

    // connection global variables
    var $host = null;
    var $user = null;
    var $pass = null;
    var $name = null;
    var $conn = null;
    var $result = null;


    // constructing class
    function __construct($dbhost, $dbuser, $dbpass, $dbname) {

        $this->host = $dbhost;
        $this->user = $dbuser;
        $this->pass = $dbpass;
        $this->name = $dbname;

    }


    // connection function
    public function connect() {

        // establish connection and store it in $conn
        $this->conn = new mysqli($this->host, $this->user, $this->pass, $this->name);

        // if error
        if (mysqli_connect_errno()) {
            echo 'Could not connect to database';
        }

        // support all languages
        $this->conn->set_charset("utf8");

    }


    // disconnection function
    public function disconnect() {

        if ($this->conn != null) {
            $this->conn->close();
        }

    }
    
    
    
    
        // Get full Driver information ///////////////////////////////////////
    public function getDriver($email) {

        // declare array to store all information we got
        $returnArray = array();

        // sql statement
        $sql = "SELECT * FROM driver WHERE demail='".$email."'";

        // execute / query $sql
        $result = $this->conn->query($sql);

        // if we got some result
        if ($result != null && (mysqli_num_rows($result) >= 1)) {

            // assign result to $row as assoc array
            $row = $result->fetch_array(MYSQLI_ASSOC);

            // if assigned to $row. Assign everything $returnArray
            if (!empty($row)) {
                $returnArray = $row;
            }
        }

        return $returnArray;

    }
    
    
    
    
    



}


?>
