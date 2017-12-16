<?php

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
     
     $query1 = "UPDATE ORDER_DETAIL INNER JOIN ORDERS ON ORDER_DETAIL.order_id=ORDERS.id INNER JOIN PRODUCT ON ORDER_DETAIL.product_id = PRODUCT.id INNER JOIN USER ON ORDERS.distributor_id = USER.id set amount= $milk WHERE (USER.user_name='$login_session' AND ORDERS.status='waiting' and PRODUCT.id=3)";
     $query2 = "UPDATE ORDER_DETAIL INNER JOIN ORDERS ON ORDER_DETAIL.order_id=ORDERS.id INNER JOIN PRODUCT ON ORDER_DETAIL.product_id = PRODUCT.id INNER JOIN USER ON ORDERS.distributor_id = USER.id set amount= $cheese WHERE (USER.user_name='$login_session' AND ORDERS.status='waiting' and PRODUCT.id=2)";
     $query3 = "UPDATE ORDER_DETAIL INNER JOIN ORDERS ON ORDER_DETAIL.order_id=ORDERS.id INNER JOIN PRODUCT ON ORDER_DETAIL.product_id = PRODUCT.id INNER JOIN USER ON ORDERS.distributor_id = USER.id set amount= $yoghurt WHERE (USER.user_name='$login_session' AND ORDERS.status='waiting' and PRODUCT.id=1)";
    
     $result1 = mysqli_query($link,$query1) or die(mysqli_error($link));
     $result2 = mysqli_query($link,$query2) or die(mysqli_error($link));
     $result3 = mysqli_query($link,$query3) or die(mysqli_error($link));
   
     
     header("location: edit_order.php");
      $link->close();
     
?>