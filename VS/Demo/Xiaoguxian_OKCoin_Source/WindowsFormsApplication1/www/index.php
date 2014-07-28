<html>

<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<title></title>

<script type="text/javascript" src="jquery-1.7.2.min.js"></script>



</head>

<body>

<script language="javascript">
$.ajax({
   type: "POST",
   url: "text.html",
   data: "name=John&location=Boston",
   success: function(msg){
     alert( "Data Saved: " + msg );
   }
 });

</script>

<?php
echo $_POST['T1'];

?>
<br>
<?php
echo $_POST['T2'];

?>
<form method="POST" action="?">
<input type="text" name="T1" size="20">
<input type="text" name="T2" size="20">
<input type="submit" value="提交" name="B1"><input type="reset" value="重置" name="B2"></p>
</form>

</body>

</html>