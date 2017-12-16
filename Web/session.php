<?php 
ob_start();
// Establishing Connection with Server by passing server_name, user_id and password as a parameter
$connection = mysqli_connect("localhost", "alibabas_conn", "40654065aktas","alibabas_1773") or die(mysqli_connect_error());

if ($connection->connect_error) {
      trigger_error('Database connection failed: '  . $connection->connect_error, E_USER_ERROR);
    }

// Selecting Database
session_start();
 // Starting Session
// Storing Session
$user_check=$_SESSION['login_user'];
// SQL Query To Fetch Complete Information Of User
$ses_sql="select user_name from USER where user_name='$user_check'";
$result = mysqli_query($connection,$ses_sql) or die(mysqli_error($connection));
$row = $result->fetch_assoc();

$login_session =$row['user_name'];
if(!isset($login_session)){
$connection->close(); // Closing Connection
header('Location: index.php'); // Redirecting To Home Page
}
 ob_end_flush(); 
?>