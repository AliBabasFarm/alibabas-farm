<?php
include('session.php');
?>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
  <title>Edit Order</title>
  
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

    
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
                text-align: left;
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
                                       
  
    <img class="irc_mi" src="https://i1.imgiz.com/rshots/7994/ali-babanin-bir-ciftligi-var-sarkisi_7994254-1870_1280x720.jpg" style="margin-top:10px; margin-left:150px; width:350px; height=250px;">
           
           <form action="edit.php" method="post">
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
                                
                                 $sql = "SELECT ORDER_DETAIL.id,USER.full_name,PRODUCT.name,ORDER_DETAIL.amount,ORDERS.status,ORDERS.create_date FROM ORDER_DETAIL INNER JOIN ORDERS ON ORDER_DETAIL.order_id=ORDERS.id INNER JOIN PRODUCT ON ORDER_DETAIL.product_id = PRODUCT.id INNER JOIN USER ON ORDERS.distributor_id = USER.id WHERE ORDERS.status='waiting' AND USER.user_name = '$login_session'";
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
                    <div style="margin-left:230px; margin-right:30px; width:210px;" class="input-group">
                      <span class="input-group-btn">
                          <button type="button" class="btn btn-danger btn-number"  data-type="minus" data-field="milk">
                            <span class="glyphicon glyphicon-minus"></span>
                          </button>
                      </span>
                      <input style="text-align:center; color:blue; margin-top: 12px;" type="text" name="milk" class="form-control input-number" value="0" min="0" max="300">
                      <span class="input-group-btn">
                          <button type="button" class="btn btn-success btn-number" data-type="plus" data-field="milk">
                              <span class="glyphicon glyphicon-plus"></span>
                          </button>
                      </span>
                      
    
                      <div style="margin-left: 10px;">
                      <h3 style="text-align:center; color:red;">Milk</h3>
                      </div>
                  </div>
                  
                      
                  
                  <div style="margin-left:230px; margin-right:30px; width:250px;" class="input-group">
                      <span class="input-group-btn">
                          <button type="button" class="btn btn-danger btn-number"  data-type="minus" data-field="cheese">
                            <span class="glyphicon glyphicon-minus"></span>
                          </button>
                      </span>
                      <input style="text-align:center; color:blue; margin-top: 12px;" type="text" name="cheese" class="form-control input-number" value="0" min="0" max="300">
                      <span class="input-group-btn">
                          <button type="button" class="btn btn-success btn-number" data-type="plus" data-field="cheese">
                              <span class="glyphicon glyphicon-plus"></span>
                          </button>
                      </span>
                      <div style="margin-left: 10px;">
                      <h3 style="text-align:center; color:red;">Cheese</h3>
                      </div>
                  </div>
                  
                  
                  
                  <div style="margin-left:230px; margin-right:30px; width:250px;" class="input-group">
                      <span class="input-group-btn">
                          <button type="button" class="btn btn-danger btn-number"  data-type="minus" data-field="yoghurt">
                            <span class="glyphicon glyphicon-minus"></span>
                          </button>
                      </span>
                      <input style="text-align:center; color:blue; margin-top: 12px;" type="text" name="yoghurt" class="form-control input-number" value="0" min="0" max="300">
                      <span class="input-group-btn">
                          <button type="button" class="btn btn-success btn-number" data-type="plus" data-field="yoghurt">
                              <span class="glyphicon glyphicon-plus"></span>
                          </button>
                      </span>
                       <div style="margin-left: 10px;">
                       <h3 style="text-align:center; color:red;">Yoghurt</h3>
                       </div>
                  </div>
           
            </div>
             
            <br>
              
            <div  style="margin-left:235px; width:150px;" class="form-group">
                    <button name="submit" type="submit" value=" Login " class="log-btn"  onclick="updater(milk,cheese,yoghurt)">Update Order</button>
                    <div style="text-align:center;">
                        <span><?php echo $error; ?></span>
                     </div>
                
                </form>
            </div>
    </div>
<script>
<!------------------------------------------------->
$('.btn-number').click(function(e){
    e.preventDefault();
    
    fieldName = $(this).attr('data-field');
    type      = $(this).attr('data-type');
    var input = $("input[name='"+fieldName+"']");
    var currentVal = parseInt(input.val());
    if (!isNaN(currentVal)) {
        if(type == 'minus') {
            
            if(currentVal > input.attr('min')) {
                input.val(currentVal - 1).change();
            } 
            if(parseInt(input.val()) == input.attr('min')) {
                $(this).attr('disabled', true);
            }

        } else if(type == 'plus') {

            if(currentVal < input.attr('max')) {
                input.val(currentVal + 1).change();
            }
            if(parseInt(input.val()) == input.attr('max')) {
                $(this).attr('disabled', true);
            }

        }
    } else {
        input.val(0);
    }
});
$('.input-number').focusin(function(){
   $(this).data('oldValue', $(this).val());
});
$('.input-number').change(function() {
    
    minValue =  parseInt($(this).attr('min'));
    maxValue =  parseInt($(this).attr('max'));
    valueCurrent = parseInt($(this).val());
    
    name = $(this).attr('name');
    if(valueCurrent >= minValue) {
        $(".btn-number[data-type='minus'][data-field='"+name+"']").removeAttr('disabled')
    } else {
        alert('Sorry, the minimum value was reached');
        $(this).val($(this).data('oldValue'));
    }
    if(valueCurrent <= maxValue) {
        $(".btn-number[data-type='plus'][data-field='"+name+"']").removeAttr('disabled')
    } else {
        alert('Sorry, the maximum value was reached');
        $(this).val($(this).data('oldValue'));
    }
    
    
});
$(".input-number").keydown(function (e) {
        // Allow: backspace, delete, tab, escape, enter and .
        if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 190]) !== -1 ||
             // Allow: Ctrl+A
            (e.keyCode == 65 && e.ctrlKey === true) || 
             // Allow: home, end, left, right
            (e.keyCode >= 35 && e.keyCode <= 39)) {
                 // let it happen, don't do anything
                 return;
        }
        // Ensure that it is a number and stop the keypress
        if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
            e.preventDefault();
        }
    });
 </script>
    
</body>


</html>