<?php ob_start();
include('session.php');
    $host="localhost"; // Host name.
    $db_user="alibabas_conn"; // MySQL username.
    $db_password="40654065aktas"; // MySQL password.
    $db_name="alibabas_1773";
    
    $link = mysqli_connect($host,$db_user,$db_password,$db_name) or die(mysqli_connect_error());

    if ($link->connect_error) {
          trigger_error('Database connection failed: '  . $link->connect_error, E_USER_ERROR);
        }
        
     $id = $_POST['id'];
     $currentpassword = $_POST['currentpassword'];
     $newpassword = $_POST['newpassword'];
    
     $query1 = "select password from USER where password='$currentpassword'";
     $result1 = mysqli_query($connection,$query1) or die(mysqli_error($connection));
     $count  = mysqli_num_rows($result1);
    
    
    if ($count == 1) {
        $query2 = "UPDATE USER SET password='$newpassword' WHERE user_name='$login_session'";
        $result2 = mysqli_query($link,$query2) or die(mysqli_error($link));
        $error = "<h5 style='color:red'>Done..!</h5>";
        header("location: user_account.php");
    } else {
    $error2 = "<h5 style='color:red'>Please enter your current password correctly..!</h5>";
    header("location: user_account.php");
    }

     $link->close();
ob_end_flush();      
?>
