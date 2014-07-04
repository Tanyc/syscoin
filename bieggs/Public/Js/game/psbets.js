//载入开奖时间
function initpsBets(){
	genNumItem();
	$(".open_num").attr("src",img_path + '/game/nums/number_' + open_num + '.gif');
	$(".time").text(time);
	$(".LID").text(LID);
	$(".mydown").text(("" == SMONEYSUM)? 0 : ver(SMONEYSUM));
	$(".gmoney").text(("" == GMONEYSUM)? 0 : ver(GMONEYSUM));
	$(".egggen").text(ver(GMONEYSUM - SMONEYSUM));
}

function genNumItem(){
	var leftHtml = "";
	var tou = "-";
	var kai = "-";
	for (var i = 0; i <= 13; i++) {
		tou = ("" != self_in && "" != self_in[i])? ver(self_in[i]) : "-";
		kai = (i == open_num)? ver(GMONEYSUM) : "-";
		leftHtml += '<tr align="center" bgcolor="#FFFFFF" height="27"><td><img src="' + img_path + '/game/nums/number_' + i + '.gif" width="25" height="25" style="cursor: pointer;"></td><td>' + cis[i] + '</td><td>' + tou + '</td><td>' + kai + '</td></tr>';
	};
	$(".left_table").append(leftHtml);

	var rightHtml = "";
	for (var i = 27; i >= 14; i--) {
		tou = ("" != self_in && "" != self_in[i])? ver(self_in[i]) : "-";
		kai = (i == open_num)? ver(GMONEYSUM) : "-";
		rightHtml += '<tr align="center" bgcolor="#FFFFFF" height="27"><td><img src="' + img_path + '/game/nums/number_' + i + '.gif" width="25" height="25" style="cursor: pointer;"></td><td>' + cis[i] + '</td><td>' + tou + '</td><td>' + kai + '</td></tr>';
	};
	$(".right_table").append(rightHtml);
}

//数字加千分符号
function ver(n){
	n = n + ""; //确保为字符串
	re=/(\d{1,3})(?=(\d{3})+(?:$|\.))/g    
	return n.replace(re,"$1,")    
}