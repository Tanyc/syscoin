$(document).ready(function(){
	$(".post_fbtb_an").click(function(){
	    $(".dis_fc_bq").slideToggle("slow");
	  });

    $('#jubaodlg').dialog({
        autoOpen: false,
        modal: true,
        width: 360,
        height: 200
    });
});

function closec(){
	if ("none" != $(".dis_fc_bq").css("display")) {
		$(".dis_fc_bq").slideToggle("slow");
	};
}

function selCheck() {
    var type = $("#seltype").val();
    if("" == type){
        alert("请选择帖类型，方便他人关注！");
        return false;
    }
    return true;
}

function titleCheck() {
    var replycontent = $("#subject").val();
    if ($.trim(replycontent).length == 0) {
        alert("请填写标题");
        return false;
    }
    if (replycontent.replace(/\s+/g, "").replace(/[^\x00-\xff]/g, "rr").length < 4) {
        alert("标题不能少于2个字");
        return false;
    }
    if (replycontent.replace(/\s+/g, "").replace(/[^\x00-\xff]/g, "rr").length > 40) {
        alert("标题不能大于20个字");
        return false;
    }
    return true;
}

function contentCheck() {
    var host = document.domain;
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
    return true;
}

function submitCheck(){
    if (selCheck() && titleCheck() && contentCheck()) {
        return true;
    };
    return false;
}

function isShowBg(isshow){
    if (isshow) {
        $('#ui-widget-overlay').css("height",document.body.clientHeight + 40);
        $('#ui-widget-overlay').css("width",document.body.clientWidth); 
    }else{
        $('#ui-widget-overlay').css("height",0);
        $('#ui-widget-overlay').css("width",0); 
    }
}

function jubao(rid, s_type) {
    isShowBg(true);
    $('#jubaodlg').dialog("open");
    var str = "<img class=\"closeimg\" src=" + img_path + "/public/close.png style=\"float:right\">"
    str += "<p  style=\"line-height:30px;\"><span class=\"post-label\">举报理由：</span><select name=\"type\"  id=\"jubaotype\"  style=\"height:22px; line-height:22px; width:130px;text-align:left;\"><option value=\"0\">请选择</option><option value=\"1\">发广告</option>";
    str += "<option value=\"2\">含负面言论（黄、赌，毒）</option><option value=\"3\">刷屏</option><option value=\"4\">其它</option></select>"
    str += "<textarea name=\"textarea2\"  id=\"report" + rid + "\" style=\"width:320px;height:72px;\"></textarea></p><div class=\"annu_auto\" > <a class=\"red_enter\" ><span  style=\"color:White\">确 定</span></a></div>"
    $("#jubaodlg").html(str);

    $('#jubaodlg').find("a").click(function () {
        var replycontent = $("#report" + rid).val();
        var pid = $("#jubaotype").val();
        if (pid == 0) {
            alert("请选择举报理由！");
            return;
        }
        if ($.trim(replycontent).length == 0) {
            alert("请简要描述举报理由！");
            return;
        };
        $('#jubaodlg').dialog("close");
        isShowBg(false);
        var para = "action=jubao&content=" + replycontent + "&rid=" + rid + "&s_type=" + s_type + "&type=" + pid;
        $.ajax({
            dataType: "json",
            type: "POST",
            data: para,
            url: "./jubao",
            error: function () {
                alert("网络异常,请稍后再试");
            },
            success: function (data, textStatus) {
                alert(data);
            }
        });



    //     $.ajax({
    //     type:"get",
    //     url:"../../../bets/userMode?id="+id,
    //     error:function(){
    //         alert("操作错误");
    //     },
    //     success:function(data, textStatus){
    //         var test = data.split(",");
    //         UserMode(data.split(","));
    //     }
    // });





    });

    $('#jubaodlg').find(".closeimg").click(function(){
        $('#jubaodlg').dialog("close");
        isShowBg(false);
    });
}