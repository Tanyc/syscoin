//载入开奖时间
function initpsBets(){
	// $(".tzbanner_fk").hide();  //测试jquery是否可用
	genNumItem();
}

function genNumItem(){
	var num = 15;
	var huode = '158542154';

	var leftHtml = "";
	var tou = "-";
	var kai = "-";
	for (var i = 0; i <= 13; i++) {
		tou = ("" == self_in[i])? "-" : ver(self_in[i]);
		kai = (i == num && "" != self_in[i])? ver(huode) : "-";
		leftHtml += '<tr align="center" bgcolor="#FFFFFF" height="27"><td><img src="' + img_path + '/game/nums/number_' + i + '.gif" width="25" height="25" style="cursor: pointer;"></td><td>' + cis[i] + '</td><td>' + tou + '</td><td>' + kai + '</td></tr>';
	};
	$(".left_table").append(leftHtml);

	var rightHtml = "";
	for (var i = 27; i >= 14; i--) {
		tou = ("" == self_in[i])? "-" : ver(self_in[i]);
		kai = (i == num && "" != self_in[i])? ver(huode) : "-";
		rightHtml += '<tr align="center" bgcolor="#FFFFFF" height="27"><td><img src="' + img_path + '/game/nums/number_' + i + '.gif" width="25" height="25" style="cursor: pointer;"></td><td>' + cis[i] + '</td><td>' + tou + '</td><td>' + kai + '</td></tr>';
	};
	$(".right_table").append(rightHtml);
}

//数字加千分符号
function ver(n){
	re=/(\d{1,3})(?=(\d{3})+(?:$|\.))/g    
	return n.replace(re,"$1,")    
}