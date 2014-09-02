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

function submitCheck() {
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