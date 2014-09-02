<?php  
$mysqli=mysqli_connect("127.0.0.1","root","","test1","3306");  
class runtime  
{  
    var $StartTime = 0;  
    var $StopTime = 0;  
 
    function get_microtime()  
    {  
        list($usec, $sec) = explode(' ', microtime());  
        return ((float)$usec + (float)$sec);  
    }  
 
    function start()  
    {  
        $this->StartTime = $this->get_microtime();  
    }  
 
    function stop()  
    {  
        $this->StopTime = $this->get_microtime();  
    }  
 
    function spent()  
    {  
        return round(($this->StopTime - $this->StartTime) * 1000, 1);  
    }  
 
}  
$runtime= new runtime;  
$runtime->start();  
 
for($i=1;$i<100000;$i++){  
$ins = "insert into `test_order` values (NULL,$i)";  
mysqli_query($mysqli,$ins);  
}  
$runtime->stop();  
echo "insert sucess! 页面执行时间: ".$runtime->spent()." 毫秒\n";  
mysqli_close($mysqli);  
?> 