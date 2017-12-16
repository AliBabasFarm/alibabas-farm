<?php
include('session.php');
?>
<!DOCTYPE html>
<html>
<head>
<title>Menu</title>

  <link rel='stylesheet prefetch' href='http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css'>

      <link rel="stylesheet" href="css/style.css">
</head>
<body>
    
    
    
    <div class="login-form" id="profile">
       <h1 id="test">W e l c o m e  : <i><?php echo $login_session; ?></i></h1>
       
       <div style="text-align:right;">
            <button style="background: #AAC986;"><a href="logout.php">Log Out</a></button>
        </div>
        
        <img class="irc_mi" src="https://i1.imgiz.com/rshots/7994/ali-babanin-bir-ciftligi-var-sarkisi_7994254-1870_1280x720.jpg" width="300" height="200" style="margin-left:70px;">
           <h1>Ali BaBa's Farm</h1>
            <div class="form-group">
                    <div class="form-group ">
                            <form method="post" action="" role="login">
                                
                                <button name="submit" type="submit" value=" Login " class="log-btn"><a href="give_order.php">Give Order</a></button>
                                <br>
                                <br>
                                <button name="submit" type="submit" value=" Login " class="log-btn" ><a href="edit_order.php">Edit Order</a></button>
                                <br>
                                <br>
                                <button name="submit" type="submit" value=" Login " class="log-btn" ><a href="order_history.php">Order History</a></button>
                                <br>
                                <br>
                                <button name="submit" type="submit" value=" Login " class="log-btn" ><a href="user_account.php">User Account</a></button>
                                
                             </form>
                    </div>
            </div>
         
    </div>
</body>
</html>