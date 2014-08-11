$(document).ready(function (){
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