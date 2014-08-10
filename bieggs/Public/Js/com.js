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
	// var regNum=/^[1-9]\d{5,}/; //暂时只支持邮箱登陆
	// if(!regNum.test(name)){
	// }
	return checkEmail(name);
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

function checkEmail(email){
	var reg=/^([a-zA-Z0-9]+[_|\-|\.]?)*[a-zA-Z0-9]+@([a-zA-Z0-9]+[_|\-|\.]?)*[a-zA-Z0-9]+\.(com)$/gi;
	if(!reg.test(email)){
		alert("邮件地址不合法！");
		return false;
	}
	return true;
}

function checkEmailNoTip(email){
	var reg=/^([a-zA-Z0-9]+[_|\-|\.]?)*[a-zA-Z0-9]+@([a-zA-Z0-9]+[_|\-|\.]?)*[a-zA-Z0-9]+\.(com)$/gi;
	if(!reg.test(email)){
		return false;
	}
	return true;
}

function showFloatWindow(isShow,from,isf_pwd){
	/**********************************************/
	/*
	from注释：
	{SNUMBER:0 ,IPLIMIT:1 ,SMESSAGE:2, SBANKKEY:3, SMSLOGIN:4, NICKNAME:5,NICK:6 ,DESC:7, S_ADDR:8}; 
	*/
	/**********************************************/
	window.frames["iframe_cont"].document.getElementById("dlg_from").value=from;
	if (isf_pwd) {
		document.getElementById("dlg_title").textContent="安全验证";
		window.frames["iframe_cont"].document.getElementById("second_key").placeholder="如果没有设置请不要填写";
	}else{
		document.getElementById("dlg_title").textContent="资料修改";
		window.frames["iframe_cont"].document.getElementById("second_key").type="text";
	}
	if (from == 6) { //modify nick
		window.frames["iframe_cont"].document.getElementById("second_key_text").textContent="新昵称";
	}else if(from == 7){  //modify s_addr
		window.frames["iframe_cont"].document.getElementById("second_key_text").textContent="详细地址（奖品邮寄地址）";
	}else if(from == 8){  //modyfy desc
		window.frames["iframe_cont"].document.getElementById("second_key_text").textContent="个性签名（少于75个汉字）";
	}
	if (isShow) {
		document.getElementById("PCShowWindowBg").style.display='';
		document.getElementById("pc_showloginparent").style.display='';
	}else{
		document.getElementById("PCShowWindowBg").style.display='none';
		document.getElementById("pc_showloginparent").style.display='none';
	}
}
