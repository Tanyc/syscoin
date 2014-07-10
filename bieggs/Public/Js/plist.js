function genPHref(pid){
	document.getElementById("pid").value = pid;
    document.getElementById("pdesc").submit();
}

function showLogImg(name){
	var img = '<img src="' + img_path + '/prize/plog/' + name + '.png" width="164" height="131" border="0" align="absmiddle">';
	document.write(img);
}