
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">

  <title>Order History</title>
  
      <link rel="stylesheet" href="css/bootstrap.css">
    
    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    
    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

     <link rel="stylesheet" href="css/style.css">
      
     <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    <script  src="js/index.js"></script>
      
      <style>
            #customers {
                
                font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
                border-collapse: collapse;
                width: 100%;
            }
            
            #customers td, #customers th {
                text-align:center;
                border: 1px solid #ddd;
                padding: 8px;
            }
            
            #customers tr:nth-child(even){background-color: #f2f2f2;}
            
            #customers tr:hover {background-color: #ddd;}
            
            #customers th {
                padding-top: 12px;
                padding-bottom: 12px;
                text-align: center;
                background-color: #4CAF50;
                color: white;
            }
        </style>
<?php include 'php/connection.php';?>
</head>
<body>
    
    <div style="width:700px;"class="login-form" id="main">
            <div  style="margin-left:0px; width:100px;">
                <div  style="margin-left:0px; width:100px">
                    <button style="background: #AAC986; margin-left:0px;"><a href="profile.php">Back</a></button>
                </div>
                
                <div  style="margin-left:550px; width:100px">
                    <button style="background: #AAC986;"><a href="logout.php">Log Out</a></button>
                </div>
             </div>
                                       
     
    <img class="irc_mi" src="https://i1.imgiz.com/rshots/7994/ali-babanin-bir-ciftligi-var-sarkisi_7994254-1870_1280x720.jpg" style="margin-top:10px; margin-left:120px; width:400px; height=250px;">
        
          
           <h1>Ali BaBa's Farm</h1>
                     <br>       
                     <div>
                            <?php
                                ob_start();  
                                @session_start();
                                $currentusername = $_SESSION['login_user'];
                                ob_end_flush(); 
                                $servername = "localhost";
                                $username = "alibabas_conn";
                                $password = "40654065aktas";
                                $dbname = "alibabas_1773";
                                 
                                // Create connection
                                $conn = new mysqli($servername, $username, $password, $dbname);
                                // Check connection
                                if ($conn->connect_error) {
                                    die("Connection failed: " . $conn->connect_error);
                                } 
                                //$sql = "SELECT * FROM showOrderHistory";
                                $sql = "SELECT ORDER_DETAIL.id,USER.full_name,PRODUCT.name,ORDER_DETAIL.amount,ORDERS.status,ORDERS.create_date FROM ORDER_DETAIL INNER JOIN ORDERS ON ORDER_DETAIL.order_id=ORDERS.id INNER JOIN PRODUCT ON ORDER_DETAIL.product_id = PRODUCT.id INNER JOIN USER ON ORDERS.distributor_id = USER.id WHERE USER.user_name = '$currentusername'";
                                //SELECT ORDER_DETAIL.id,USER.full_name,PRODUCT.name,ORDER_DETAIL.amount,ORDERS.status,ORDERS.create_date 
                                //FROM ORDER_DETAIL
                                //INNER JOIN ORDERS ON ORDER_DETAIL.order_id=ORDERS.id
                                //INNER JOIN PRODUCT ON ORDER_DETAIL.product_id = PRODUCT.id
                                //INNER JOIN USER ON ORDERS.distributor_id = USER.id
                                //WHERE USER.full_name = "< O ANDA GİRİŞ YAPAN KULLANICI İSMİ> "
                                $result = $conn->query($sql);
                               
                                if ($result->num_rows > 0) {
                                    echo "<table id='customers'><tr><th>ORDER ID</th><th>USER NAME</th><th>PRODUCT NAME</th><th>AMOUNT</th><th>STATUS</th><th>ORDER DATE</th></tr>";
                                    // output data of each row
                                    while($row = $result->fetch_assoc()) {
                                        echo "<tr>
                                        <td>".$row["id"]."</td>
                                        <td>".$row["full_name"]."</td>
                                        <td>".$row["name"]."</td>
                                        <td>".$row["amount"]."</td>
                                        <td>".$row["status"]."</td>
                                        <td>".$row["create_date"]."</td></tr>";
                                    }
                                    echo "</table>";
                                } else {
                                    echo "0 results";
                                }
                                echo $table;
                                $conn->close();
                                
                            ?>
                     </div>
              <div>
                    
                  
                      
                  
                  
           
            </div>
        
    </div>

    
</body>


</html>