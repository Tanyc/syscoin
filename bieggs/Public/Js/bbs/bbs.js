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