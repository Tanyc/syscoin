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
}