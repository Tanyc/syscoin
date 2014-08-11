function setHeadImg(){
	var imgtab = '';
	for (var i = 0; i <= 25; i++){
		imgtab = '<label onclick="checkhd(' + i + ')"><img class="headimg" src="' + img_path + '/user/head/' + i + '.gif"></label>';
		document.write(imgtab);
	};
}

function checkhd(i){
	var img_ch = document.getElementById("choice_headimg");
	img_ch.src = img_path + '/user/head/' + i + '.gif';
	document.getElementById("headimg").value=i;
}

function hideHalf(str){
	if (str.length > 4) {
		var halfStr = str.substring(0,str.length - 4) + "***";
		document.write(halfStr);
	}else{
		document.write("未设置");
	}
}

function editSb(){
	var qq = document.getElementById("qq");
	if (qq) {
		var reg=/^[1-9]\d{5,}$/;
		if(!reg.test(qq.value)){
			alert("qq不合法！");
			return false;
		}
	};
	var phone = document.getElementById("phone");
	if (phone) {
		var reg= /^(13[0-9]|15[0|3|6|7|8|9]|18[8|9])\d{8}$/;
		if(!reg.test(phone.value)){
			alert("手机号码不合法！");
			return false;
		}
	};
	return true;
}

function editHI(){
	if (document.getElementById("headimg").value == "") {
		alert("请先选择头像");
		return false;
	};
	return true;
}
