<?
    $host="localhost"; // Host name.
    $db_user="alibabas_conn"; // MySQL username.
    $db_password="40654065aktas"; // MySQL password.
    $link = new mysqli($host,$db_user,$db_password);
    
    if ($link->connect_error) {
      trigger_error('Database connection failed: '  . $link->connect_error, E_USER_ERROR);
    }
    
    $link->close();
?>