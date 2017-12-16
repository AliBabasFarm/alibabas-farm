<?php ob_start(); session_start();
include('login.php'); // Includes Login Script

if(isset($_SESSION['login_user'])){
header("location: profile.php");
}
ob_end_flush(); 
?>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
  <title>Login Page</title>
  
  
  <link rel='stylesheet prefetch' href='http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css'>

      <link rel="stylesheet" href="css/style.css">
<?php include 'php/connection.php';?>
</head>
<body>
    <div class="login-form" id="main">
    <img class="irc_mi" src="https://i1.imgiz.com/rshots/7994/ali-babanin-bir-ciftligi-var-sarkisi_7994254-1870_1280x720.jpg" width="300" height="200" style="margin-left:70px;">
           <h1>Ali BaBa's Farm</h1>
            <div class="form-group">
                    <div class="form-group ">
                            <form action="" method="post">
                                <input id="name" class="form-control" name="username" placeholder="Username or E-mail" type="text">
                             <i class="fa fa-user"></i>
                     </div>
                     
                    <div class="form-group log-status">
                            <input id="password" class="form-control" name="password" placeholder="Password" type="password">
                            <i class="fa fa-lock"></i>
                     </div >
                    <button name="submit" type="submit" value=" Login " class="log-btn" >Sign in</button>
                    <div style="text-align:center;">
                        <span><?php echo $error; ?></span>
                     </div>
                
                </form>
            </div>
    </div>
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    <script  src="js/index.js"></script>
</body>
</html>