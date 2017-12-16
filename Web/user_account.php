<?php
include('session.php');
?>

<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>User Account</title>
  
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
                text-align:center;
                padding-top: 12px;
                padding-bottom: 12px;
                text-align: center;
                background-color: #4CAF50;
                color: white;
            }
        </style>
        

</head>
<body>
    
    <div style="width:750px;"class="login-form" id="main">
            <div  style="margin-left:0px; width:100px;">
                <div  style="margin-left:0px; width:100px">
                    <button style="background: #AAC986; margin-left:0px;"><a href="profile.php">Back</a></button>
                </div>
                
                <div  style="margin-left:600px; width:100px">
                    <button style="background: #AAC986;"><a href="logout.php">Log Out</a></button>
                </div>
             </div>
                                       
  
    <img class="irc_mi" src="https://i1.imgiz.com/rshots/7994/ali-babanin-bir-ciftligi-var-sarkisi_7994254-1870_1280x720.jpg" style="margin-top:10px; margin-left:150px; width:400px; height=300px;">
           
           <form action="account.php" method="post">
           <h1>Ali BaBa's Farm</h1>
                     <br>       
                     <div>
                         
                         <?php 
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
                                
                                
                                $sql = "SELECT * FROM USER where user_name='$login_session'";
                                $result = $conn->query($sql);
                               
                              
                                if ($result->num_rows > 0) {
                                    echo "<table id='customers'><tr><th>ID</th><th>USERNAME</th><th>FULL NAME</th><th>ADDRESS</th><th>E-MAIL</th><th>USER TYPE</th></tr>";
                                    // output data of each row
                                    while($row = $result->fetch_assoc()) {
                                        echo "<tr>
                                        <td>".$row["id"]."</td>
                                        <td>".$row["user_name"]."</td>
                                        <td>".$row["full_name"]."</td>
                                        <td>".$row["address"]."</td>
                                        <td>".$row["email"]."</td>
                                        <td>".$row["user_type"]."</td></tr>";
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
                    <div style="margin-left:200px; margin-right:30px; width:210px;" class="input-group">
                      <input style="width:300px; text-align:center; color:blue; margin-top: 12px;" type="text" name="currentpassword" class="form-control" placeholder="please enter your current password">
                    </div>
                  
                    <div style="margin-left:200px; margin-right:30px; width:210px;" class="input-group">
                      <input style="width:300px; text-align:center; color:blue;" type="text" name="newpassword" class="form-control" placeholder="please enter your new password">
                    </div>
                   
               <br>
            <br>
           
            </div>
             
            
            <div  style="margin-left:280px; width:150px;" class="form-group">
                    <button name="submit" type="submit" value=" Login " class="log-btn" >Update Account</button>
                    <div style="text-align:center;">
                        <span><?php echo $error; ?></span>
                     </div>
                
                </form>
            </div>
    </div>

</body>


</html>