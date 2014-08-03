function ver(n){
	n = n + "";
	re=/(\d{1,3})(?=(\d{3})+(?:$|\.))/g    
	return n.replace(re,"$1,")    
}

function loginsb(){
	var name = $("#txt_UserName").attr("value");
	if(!verifyName(name)) return false;

	var key = $("#txt_PWD").attr("value");
	if(!verifyKey(key)) return false;

	var verify = $("#txt_VerifyCode").attr("value");
	if(!verifyCode(verify)) return false;

}

function verifyName(name){
	if(isNil(name)){
		alert("请输入用户名！")
		return false;
	}
	return true;
}

function verifyKey(key){
	if(isNil(key)){
		alert("请输入密码！")
		return false;
	}else if(key.length < 6 || key.length > 18){
		alert("密码长度不在范围内，请核实！")
		return false;
	}
	return true;
}

function verifyCode(code){
	if(isNil(code)){
		alert("请输入验证码！")
		return false;
	}else if(code.length != 4){
		alert("验证码长度不合法，请核实！")
		return false;
	}
	return true;
}

function isNil(str){
	if(null == str || "" == str) return true;
	return false;
}

function setVipRange(vip){
	var range = Math.floor(vip / 1000);
	var doc = '<span><img src="' + image_path + '/user/vip/lv0.png" title="等级:0级"></span>';
	if (range >= 1) {
		var doc = '<span><img src="' + image_path + '/user/vip/lv' + range + '.png" title="等级:' + range + '级"></span>';
	}
	document.write(doc);
}