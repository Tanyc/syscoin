
$("#main").load(function(){
    var mainheight = $(this).contents().find("#box").height()+100;
    $(this).height(mainheight);
    //alert( $("#main").offset().top)
    var  nn=0;
    var   mainlocation= $("#main").attr("src");
    if(nn!==0&&mainlocation.indexOf("?q=")>-1){
        $(document).scrollTop(300+45*(nn+1));
    }
}); 
$("#dom_ul").find("li").each(function (i, dom) {
    $(dom).click(function () {
            $("#dom_ul").find("li").attr("class", "");
            $("#dom_ul").find("a").attr("class", "");
            $(this).attr("class", "on");
            $(this).find("a").attr("class", "info");
            $("#main").attr("src","./help/help"+i+".html");
            // $(document).scrollTop(0);
    })
});