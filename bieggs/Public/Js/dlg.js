function check(){
	var sss = window.a;
	var key1 = $("#first_key").attr("value");
	var key2 = $("#second_key").attr("value");
	if(!verifyKey(key1) || isNil(key2)) return false;

	if (!isCode) {
		alert("验证码错误");
		return false;
	};
}

function verifyKey(key){
	if(isNil(key) || key.length < 6 || key.length > 18){
		alert("密码输入不合法")
		return false;
	}
	return true;
}