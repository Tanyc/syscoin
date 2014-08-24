function shortDesc(content){
	var con = content.substr(0,50) + "......";
	document.write(con);
}

function showShortImgs(imgs,id){
	var imgsArray = imgs.split(":");
	for (var i = 0; i < imgsArray.length; i++) {
		if (imgsArray[i] != "") {
			var img = '<li><a href="http://www.test.com"><img src="' + upimg_path + '/' + imgsArray[i] + '" width="76px" height="60px"></a></li>';
			document.write(img);
		}
	}
}