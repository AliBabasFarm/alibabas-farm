<?php ob_start(); session_start();  // Starting Session
$error=''; // Variable To Store Error Message
if (isset($_POST['submit'])) {
if (empty($_POST['username']) || empty($_POST['password'])) {
$error = "<h5 style='color:red'>Please Enter Your Information..!</h5>";
}
else
{
// Define $username and $password
$username=$_POST['username'];
$password=$_POST['password'];
// Establishing Connection with Server by passing server_name, user_id and password as a parameter
$connection = mysqli_connect("localhost", "alibabas_conn", "40654065aktas","alibabas_1773") or die(mysqli_connect_error());

if ($connection->connect_error) {
      trigger_error('Database connection failed: '  . $connection->connect_error, E_USER_ERROR);
    }

// To protect MySQL injection for Security purpose
/*
$username = stripslashes($username);
$password = stripslashes($password);

$username = mysqli_real_escape_string($connection,$username);
$password = mysqli_real_escape_string($connection,$password);
*/
// Selecting Database

// SQL query to fetch information of registerd users and finds user match.

$query = "select * from USER where password='$password' AND user_name='$username'";
$result = mysqli_query($connection,$query) or die(mysqli_error($connection));

$count  = mysqli_num_rows($result);
echo $count;

if ($count == 1) {
$_SESSION['login_user']=$username; // Initializing Session
header("location: profile.php"); // Redirecting To Other Page
} else {
$error = "<h5 style='color:red'>Username or Password is invalid</h5>";
}
$connection->close(); // Closing Connection
}
}
ob_end_flush(); 
?>