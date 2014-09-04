$(document).ready(function(){
    $('#jubaodlg').dialog({
        autoOpen: false,
        modal: true,
        width: 360,
        height: 200
    });
});

function isShowBg(isshow){
    if (isshow) {
        $('#ui-widget-overlay').css("height",document.body.clientHeight + 40);
        $('#ui-widget-overlay').css("width",document.body.clientWidth); 
    }else{
        $('#ui-widget-overlay').css("height",0);
        $('#ui-widget-overlay').css("width",0); 
    }
}

function jubao(rid, s_type,BUID) {
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
        var para = "action=jubao&content=" + replycontent + "&rid=" + rid + "&s_type=" + s_type + "&type=" + pid + "&BUID=" + BUID;
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
    });

    $('#jubaodlg').find(".closeimg").click(function(){
        $('#jubaodlg').dialog("close");
        isShowBg(false);
    });
}