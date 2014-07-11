
function showImgLog (name) {
    var img = '<img src="' + img_path + '/prize/plog/' + name + '.png" width="100%" height="100%" border="0">';
    document.write(img);
}

function showImgCont (name) {
    var img = '<img src="' + img_path + '/prize/pdesc/' + name + '.png" width="100%" height="100%" border="0">';
    document.write(img);
}

function setData(n) {
    for (var i = 1; i < 5; i++) {
        if (i == n) {
            $("#setdata" + i).addClass("on");
            $("#data" + i).css("display", "");
        } else {
            $("#setdata" + i).removeClass("on");
            $("#data" + i).css("display", "none");
        }
    }
}
