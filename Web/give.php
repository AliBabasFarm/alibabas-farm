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
   
    $milk = $_POST['milk'];
    $cheese = $_POST['cheese'];
    $yoghurt = $_POST['yoghurt'];
    $date=date('Y-m-d');
    $idquery="SELECT USER.id FROM USER WHERE USER.user_name='$login_session'";
    $currentuserid = mysqli_query($link,$idquery) or die(mysqli_error($link));
   // $row = mysql_fetch_assoc($currentuserid);
   
        while ($row = mysqli_fetch_array($currentuserid))
        {
        
        $userid = $row['id'];
         
        }
    
    
    
    
    
    $query1 = "insert into ORDERS (distributor_id,create_date,status) values ('$userid','$date','waiting')";
    $query2 = "SET @orderid := @@IDENTITY";
    $query3 ="insert into ORDER_DETAIL(order_id,product_id,amount) values (@orderid,3,$milk)";
    $query4 ="insert into ORDER_DETAIL(order_id,product_id,amount) values (@orderid,2,$cheese)";
    $query5 = "insert into ORDER_DETAIL(order_id,product_id,amount) values (@orderid,1,$yoghurt)";
    
    $result1 = mysqli_query($link,$query1) or die(mysqli_error($link));
    $result2 = mysqli_query($link,$query2) or die(mysqli_error($link));
    $result3 = mysqli_query($link,$query3) or die(mysqli_error($link));
    $result4 = mysqli_query($link,$query4) or die(mysqli_error($link));
    $result5 = mysqli_query($link,$query5) or die(mysqli_error($link));
    header("location: give_order.php");
   
     $link->close();
    ob_end_flush(); 
?>