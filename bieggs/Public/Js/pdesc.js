
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
    if (n == 2 || n == 3) {
        var tid = "#ChargeUserList";
        var turl = "http://www.baidu.com";
        if (n == 3) {
            tid = "#Tradebbs";
            turl = "http://www.baidu.com";
        }
        var fsrc = $(tid).attr("src");
        if (fsrc != "" || fsrc.length > 0) {
            return;
        }
        $("#data" + n).css("display", "none");
        document.getElementById("info_div").style.display = "";
        $(tid).attr("src", turl);
    }
    $(".leader_tab").css("border","#ff0000");
}
