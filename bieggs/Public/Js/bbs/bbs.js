$(document).ready(function(){
	$(".post_fbtb_an").click(function(){
	    $(".dis_fc_bq").slideToggle("slow");
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

function contentCheck(min,max) {
    var host = document.domain;
    var replycontent = $("#content").val();
    if ($.trim(replycontent).length == 0) {
        alert("请填写内容");
        return false;
    }
    if (replycontent.replace(/\s+/g, "").replace(/[^\x00-\xff]/g, "rr").length < 2 * min) {
        alert("内容不能少于" + min + "个字");
        return false;
    }
    if (replycontent.replace(/\s+/g, "").replace(/[^\x00-\xff]/g, "rr").length > 2 * max) {
        alert("内容不能大于" + max + "个字");
        return false;
    }
    return true;
}

function submitCheck(){
    //博客内容限制为300字
    if (selCheck() && titleCheck() && contentCheck(20,300)) {
        return true;
    };
    return false;
}