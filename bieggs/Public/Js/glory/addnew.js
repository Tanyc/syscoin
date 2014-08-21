function submitvaluet() {
    var host = document.domain;
    var bname = $("#subject").val();
    var Regx = /^[A-Za-z0-9]*$/;
    if (Regx.test($.trim(bname))) {
        alert("标题不能纯数字、字母");
        return false;
    }
    if (bname.replace(/\s+/g, "").replace(/[^\x00-\xff]/g, "rr").length < 8) {
        alert("帖子标题不能少于4个字");
        return false;
    }
    if (bname.replace(/\s+/g, "").replace(/[^\x00-\xff]/g, "rr").length > 40) {
        alert("帖子标题不能大于20个字");
        return false;
    }
    var replycontent = $("#content").val();
    if ($.trim(replycontent).length == 0) {
        alert("请填写内容");
        return false;
    }
    if (replycontent.replace(/\s+/g, "").replace(/[^\x00-\xff]/g, "rr").length < 20) {
        alert("帖子内容不能少于10个字");
        return false;
    }
    if (replycontent.replace(/\s+/g, "").replace(/[^\x00-\xff]/g, "rr").length > 600) {
        alert("帖子内容不能大于300个字");
        return false;
    }
    if (getImgs() == 0 || getImgs() > 6) {
        alert("必须上传1-6张图片！");
        return false;
    }
    return true;
    // $.ajax({
    //     dataType: "json",
    //     type: "POST",
    //     data: {'action': 'submitcontent', 'imgs': encodeURIComponent(imgs.join(";")), 'bname': encodeURIComponent(bname), 'replycontent': encodeURIComponent(replycontent) },
    //     url: "show_ajax.aspx",
    //     dataType: "json",
    //     error: function () {
    //         alert("发帖失败");
    //     },
    //     success: function (data, textStatus) {
    //         if (data.result == 0) {
    //             window.location.href = "/ShowPrize/ShowInfo.aspx?tid=" + data.tid;
    //         } else {
    //             alert(data.msg);
    //         }
    //     }
    // });
}

$(document).ready(function () {
    //未登录状态，不能写
    if ("1873372" == "") {
        $("#content").attr("readonly", "true");

    }
});

var isup = false;
function validate(theform){
    if(Form1.photofile.value== "") {
        alert("请选择上传文件。");
        return false;
    }
    return checkImg(document.getElementById("photofile"));
    return true;
}

function checkImg(obj){
    $("#num_pic").html(getImgs());
    if(obj.value=="") return false;
    if(obj.value.search(/\.jpg|\.jpeg|\.bmp|\.gif|\.emf|\.wmf|\.xbm|\.png$/i) == -1){
        alert("文件格式不正确");
        return false;
    }
    isup = true;

    $("#num_pic").html(getImgs());

    return true;
}

function getImgs(){
    var j = 0;
    for (var i = 1; i < 6; i++) {
        var vali =  $("#upfile" + i).val();
        if (typeof(vali) != "undefined" && vali != "") {
            j++;
        };
    };
    return j;
}

function checkup(){
    parent.testimg();
    if(isup){
        document.getElementById("uptx_msg").innerHTML = "";
    }
}