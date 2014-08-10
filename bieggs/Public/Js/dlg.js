$(document).ready(function (){
	$("#txt_VerifyCode").keyup(function(){
		var varCode = $(this).attr("value");
		if(varCode.length == 4){
			checkIfCodeRight(varCode);
		}else{
			$("#code_tip").css("display","none");
		}
	});
});
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
	    	}else{
	    		$("#code_tip").attr("src",img_path + "/public/i_no.png");
	    		$("#code_tip").css("display","");
	    	}
	    }
	});
}

function check(){
	var sss = window.a;
	var key1 = $("#first_key").attr("value");
	var key2 = $("#second_key").attr("value");
	if(!verifyKey(key1) || isNil(key2)) return false;

	var verify = $("#txt_VerifyCode").attr("value");
	if(!verifyCode(verify)) return false;
}

function verifyKey(key){
	if(isNil(key) || key.length < 6 || key.length > 18){
		alert("密码输入不合法")
		return false;
	}
	return true;
}

function verifyCode(code){
	if(isNil(code) || code.length != 4){
		alert("验证码错误！")
		return false;
	}
	return true;
}