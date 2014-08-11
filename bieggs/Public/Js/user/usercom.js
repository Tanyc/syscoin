var SAFE_TYPE = {SNUMBER:0 ,IPLIMIT:1 ,SMESSAGE:2, SBANKKEY:3, SMSLOGIN:4, NICKNAME:5,NICK:6 ,DESC:7, S_ADDR:8}; 
function setData(n) {
    for (var i = 1; i <= 7; i++){
        if (i == n) {
            $("#tab" + i).addClass("a_bg1");
            $("#imfo_edit" + i).css("display", "");
        } else {
            $("#tab" + i).removeClass("a_bg1");
            $("#imfo_edit" + i).css("display", "none");
        }
    }
}

function safeSetting(id){
	if (SAFE_TYPE.SMESSAGE == id || SAFE_TYPE.SMSLOGIN == id) {  //显示安全验证
		showFloatWindow(true,id,true);  //first row show password patten
	}else{
		showFloatWindow(true,id,false); //first row not show password patten
	}
}
function pwdch(){
    var oldp = $("#OLDPASSWORD").val();
    var newp = $("#NEWPASWWORD").val();
    var renewp = $("#NEWPASWWORD2").val();
    if (!checkIfPwdRight(oldp)) {
        alert("输入错误！");
        return false;
    };
    if (!checkIfPwdRight(newp) || newp != renewp) {
        alert("输入密码错误！");
        return false;
    };
    return true;
}

function checkIfPwdRight(pwd){
    if (pwd.length < 6 || pwd.length > 18 || isNil(pwd)) {
        return false;
    };
    return true;
}