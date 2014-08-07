$(document).ready(function (){
	$("#txt_VerifyCode").keyup(function(){
		var varCode = $(this).attr("value");
		if(varCode.length == 4){
			checkIfCodeRight(varCode);
		}else{
			$("#code_tip").css("display","none");
		}
	});
	$("#txt_UserName").keyup(function(){
		var email = $(this).attr("value");
		$("#email_tip").css("display","none");
		if(email.length >= 5){
			if(checkEmailNoTip(email)){
				$("#email_tip").css("display","");
			}
		}
	});
	$("#txt_UserName").change(function(){
		var email = $(this).attr("value");
		$("#email_tip").css("display","none");
		if(email.length >= 5){
			if(checkEmailNoTip(email)){
				$("#email_tip").css("display","");
			}
		}
	});
});

function checkIfCodeRight(varCode){
	$.ajax({
	    type:"get",
	    url:"./checkCode?code=" + varCode,
		error:function(){
		},
	    success:function(data, textStatus){
	    	if("ok" == data){
	    		$("#code_tip").css("display","");
	    	}else{
	    		$("#code_tip").css("display","none");
	    	}
	    }
	});
}
