function securesb(){
	if (!isCode) {
		alert("验证码错误");
		return false;
	};
	var s_name = $("#s_name").val();
	if (!checkName(s_name)) {
		alert("姓名输入错误");
		return false;
	};
	var s_num = $("#s_num").val();
	if (!checkSCard(s_num)) {
		alert("身份证号码输入错误");
		return false;
	};
	return true;
}

function checkName(name){
	if (isNil(name)) {
		return false;
	};
	var reg=/[\w\d]/;
	if(reg.test(name)){
		return false;
	}
	return true;
}

function checkSCard(num){
	if (num.length != 15 && num.length != 18 || isNil(num) {
		return false;
	};
	return true;
}