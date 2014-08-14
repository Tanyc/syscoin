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

function showPState(stat){
    if (-1 == stat) {
        document.write('<span style="color:#ff0000">未发货<span>');
    }else if (0 == stat) {
        document.write('<span style="color:#0000ff">发货中<span>');
    }else{
        document.write('<span style="color:#00aa00">已发货<span>');
    }
}

function hAddrEdit(cnt){
    if (cnt >= 3) {
        $("#addrEdit").css("display","none");
    };
}

function checkAddr(){ //myprize页验证表单
    if (isNil($("#NAME").val())) {
        alert("请输入姓名！");
        return false;
    }else if (isNil($("#PROVINCE").val())) {
        alert("请选择省份！");
        return false;
    }else if (isNil($("#CITY").val())) {
        alert("请选择城市！");
        return false;
    }else if (isNil($("#ADDRESS").val())) {
        alert("请填写详细地址！");
        return false;
    }else if (isNil($("#PCODE").val()) || $("#PCODE").val().length != 6) {
        alert("邮编填写错误！");
        return false;
    }else if (isNil($("#TEL").val()) || $("#TEL").val().length < 11) {
        alert("电话号码输入错误！");
        return false;
    }else if (!isCode) {
        alert("验证码错误！");
        return false;
    };
    return true;
}