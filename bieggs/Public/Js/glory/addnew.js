function submitvaluet() {
    var host = document.domain;
    var bname = $("#subject").val();
    var Regx = /^[A-Za-z0-9]*$/;
    if (Regx.test($.trim(bname))) {
        alert("标题不能纯数字、字母");
        return;
    }
    if (bname.replace(/\s+/g, "").replace(/[^\x00-\xff]/g, "rr").length < 8) {
        alert("帖子标题不能少于4个字");
        return;
    }
    if (bname.replace(/\s+/g, "").replace(/[^\x00-\xff]/g, "rr").length > 40) {
        alert("帖子标题不能大于20个字");
        return;
    }
    var replycontent = $("#content").val();
    if ($.trim(replycontent).length == 0) {
        alert("请填写内容");
        return;
    }
    if (replycontent.replace(/\s+/g, "").replace(/[^\x00-\xff]/g, "rr").length < 20) {
        alert("帖子内容不能少于10个字");
        return;
    }
    if (replycontent.replace(/\s+/g, "").replace(/[^\x00-\xff]/g, "rr").length > 600) {
        alert("帖子内容不能大于300个字");
        return;
    }
    var imgs = [];
    $("#tx_face_cur").find("img").filter(".upimg").each(function (i) {
        imgs[i] = $(this).attr("src");
        imgs[i] = imgs[i].replace("_b.jpg", "");
        var hl = parseInt(host.length);
        if (host.length > 5) {
            imgs[i] = imgs[i].replace(host, "fs.pceggs.com");
        } else {
            imgs[i] = "http://fs.pceggs.com" + imgs[i];
        }
        if (imgs[i].indexOf("http://") < 0) {
            imgs[i] = "http://fs.pceggs.com" + imgs[i];
        }
    });
    if (imgs.length == 0 || imgs.length > 4) {
        alert("必须上传1-4张图片！");
        return;
    }
    $.ajax({
        dataType: "json",
        type: "POST",
        data: {'action': 'submitcontent', 'imgs': encodeURIComponent(imgs.join(";")), 'bname': encodeURIComponent(bname), 'replycontent': encodeURIComponent(replycontent) },
        url: "show_ajax.aspx",
        dataType: "json",
        error: function () {
            alert("发帖失败");
        },
        success: function (data, textStatus) {
            if (data.result == 0) {
                window.location.href = "/ShowPrize/ShowInfo.aspx?tid=" + data.tid;
            } else {
                alert(data.msg);
            }
        }
    });
}

$(document).ready(function () {
    //未登录状态，不能写
    if ("1873372" == "") {
        $("#content").attr("readonly", "true");

    }
});