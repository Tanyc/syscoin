var isCode = false;
$(document).ready(function (){
	$("#txt_VerifyCode").keyup(function(){
		var varCode = $(this).attr("value");
		if(varCode.length == 4){
			checkIfCodeRight(varCode);
		}else{
			$("#code_tip").css("display","none");
			isCode = false;
		}
	});
});

function test(chr){
alert(a.toFixed(2));
	document.write(formatFloat(chr,2));
}

function docMoney(chr,num){
	if (isNil(num)) {
		num = 2;
	};
	document.write("￥" + chr.toFixed(num));
}

function checkIfCodeRight(varCode){
	$.ajax({
	    type:"get",
	    url:root_path + "/pubtpl/checkCode?code=" + varCode,
		error:function(){
		},
	    success:function(data, textStatus){
	    	if("ok" == data){
	    		$("#code_tip").attr("src",img_path + "/public/i_yes.png");
	    		$("#code_tip").css("display","");
	    		isCode = true;
	    	}else{
	    		$("#code_tip").attr("src",img_path + "/public/i_no.png");
	    		$("#code_tip").css("display","");
	    	}
	    }
	});
}
function ver(n){
	n = n + "";
	re=/(\d{1,3})(?=(\d{3})+(?:$|\.))/g    
	return n.replace(re,"$1,");
}

function verdoc(n){
	document.write(ver(n));
}

function dever(str){ 
	return str.replace(/,/g,"");
}

function loginsb(){
	if (!isCode) {
		alert("验证码错误");
		return false;
	};
	var name = $("#txt_UserName").attr("value");
	if(!verifyName(name)) return false;

	var key = $("#txt_PWD").attr("value");
	if(!verifyKey(key)) return false;
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

function isNil(str){
	if(null == str || "" == str) return true;
	return false;
}

function setVipRange(vip){
	var doc = '<span><img src="' + img_path + '/user/vip/lv' + vip + '.png" title="等级:' + vip + '级"></span>';
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

function checkIfPlusNum(str){
	var reg=/^[1-9]\d*$/gi;
	if(reg.test(str)){
		return true;
	}
	return false;
}

function showImageList(imgs,subpath){
	var imgsArray = imgs.split(":");
	for (var i = 0; i < imgsArray.length; i++) {
		if (imgsArray[i] != "") {
			var imgtab = '<div class="tlq_beta3_sj_bgimg"><img src="' + upimg_path + '/' + subpath + '/' + imgsArray[i] + '" width="650px"></div>';
			document.write(imgtab);
		};
	}
}