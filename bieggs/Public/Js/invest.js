$(document).ready(function(){
    $(".xingqu ul").find("li").click(
        function(){
            $(this).siblings().attr("class","");
            $(this).attr("class","current");
        });
});

function share(_atitle,_webid){
    document.write('<a class="jiathis_button_'+_webid+'" title=' + _atitle + ' href="javascript:void();" onclick="javascript:window.location.href=\'http://www.jiathis.com/send/?webid='+_webid+'&url=http://www.aoyene.cc/recom.php?userID=1104444&title='+document.getElementById('con_py_x').innerHTML+'&uid=0\';"><span class="jiathis_txt jtico jtico_'+_webid+'"></span></a>');
}

function setTab(i){
    var nolog = '你还未登录Lucky蛋蛋， 请登录后就复制链接推广。';
    if (isNil(JS_UID)) {
        document.getElementById('con_py_x').innerHTML=nolog;
        return;
    };
    var con = new Array(
        ["幸运28，体育310竞猜，三方游戏众多，奖池稳定超大，三方开奖公平公正，投资竞猜娱乐最佳选择！http:/__ROOT__/game?userID=1104444"],
        ["体验试玩游戏，试用软件，送q币，话费，iphone4s，你的意见将改变世界！http://www.aoyene.cc/recom.php?userID=1104444"],
        ["在家兼职试用软件，试玩游戏，日赚500，如果网络只会让你花钱不能让你赚钱真是互联网的悲哀！http://www.aoyene.cc/recom.php?userID=1104444"],
        ["淘宝购物返利,反正是要在淘宝买的东西，来这里登记一下换积分，就有能再多赚q币，话费，iphone4s！http://www.aoyene.cc/recom.php?userID=1104444"]);
    document.getElementById('con_py_x').innerHTML=con[i - 1];
}


function writeOneSliderItem(UID,nick,last_score){
    document.write('<li><a href="http://www.aoyene.cc/user_detail.php?uid=' + UID + '" target="_blank">' + nick + '</a>&nbsp;&nbsp;获得<span class="gold" style="float:right">' + ver(last_score) + '积分</span></li>');
}

function writeOneTopItem(index,UID,nick,score){
    document.write('<div class="tgv3_r_zxtx_ev"><ul><li class="tgv3nub' + index + '">&nbsp;</li><li class="tgv3yhm"><a href="/pgComUserInfo.aspx?userid=' + UID + '" target="_blank">' + nick + '</a></li><li class="tgv3sj"><span>' + ver(score) + '</span>积分</li></ul></div>');
}

function runText(){
    var yqjl = document.getElementById("yqjlmq"); //滚动对象
    var iLineHeight = 30; //单行高度，像素
    var iLineCount = 10; 
    var iScrollAmount = 1; //每次滚动高度，像素
    yqjl.innerHTML += yqjl.innerHTML;
}

function runyqjl() {
    var yqjl = document.getElementById("yqjlmq"); //滚动对象
    var iLineHeight = 30; 
    var iLineCount = 10; 
    var iScrollAmount = 1; 
    yqjl.innerHTML += yqjl.innerHTML;
    textRun = function(){
        yqjl.scrollTop += iScrollAmount;
        if ( yqjl.scrollTop == iLineCount * iLineHeight )
            yqjl.scrollTop = 0;
        if ( yqjl.scrollTop % iLineHeight == 0 ) {
        window.setTimeout( "textRun()", 2000 );} else {
        window.setTimeout( "textRun()", 2 );}
    }
    textRun();
}

function copyurl(){
var share_url = $("#con_py_x").html();
if(window.clipboardData){
    window.clipboardData.setData("Text",share_url);
        alert("推荐代码已经复制到粘贴板，快分享给你的好友吧!");
    }else{
        alert("该浏览器不支持快捷复制，请选中左边框中文字后使用CTR+C手动复制内容!");
    }
}