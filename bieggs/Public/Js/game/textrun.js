var FeedData = new Array(
    {title:'蛋友<a href="/FriendInfor/FriendPrize.aspx?userid=8764495">8764495</a>兑换了<a href="/prize/prizeDetail.aspx?ISSUE=ZC0266">"移动话费100元直充"</a>',userid:'8764495',datatype:'奖品',time:'34分钟前',url:''},
    {title:'蛋友<a href="/FriendInfor/FriendPrize.aspx?userid=2814481">2814481</a>兑换了<a href="/prize/prizeDetail.aspx?ISSUE=ZC0104">"全国移动话费卡100元"</a>',userid:'2814481',datatype:'奖品',time:'1小时前',url:''},
    {title:'蛋友<a href="/FriendInfor/FriendPrize.aspx?userid=16578367">16578367</a>兑换了<a href="/prize/prizeDetail.aspx?ISSUE=ZC0266">"移动话费100元直充"</a>',userid:'16578367',datatype:'奖品',time:'1小时前',url:''},
    {title:'蛋友<a href="/FriendInfor/FriendPrize.aspx?userid=16650542">16650542</a>兑换了<a href="/prize/prizeDetail.aspx?ISSUE=ZC0269">"联通话费100元直充"</a>',userid:'16650542',datatype:'奖品',time:'48分钟前',url:''}
    );
var msg = "";
var speed=40; //数字越大速度越慢 20
var tab=document.getElementById("demo"); 
var tab1=document.getElementById("demo1"); 
var tab2=document.getElementById("demo2"); 
var MyMar = null;
function Marquee(){ 
    if(tab2.offsetWidth-tab.scrollLeft<=0) {
        tab.scrollLeft -= tab1.offsetWidth;
    }else{ 
        tab.scrollLeft++; 
    } 
}
tab.onmouseover=function() {clearInterval(MyMar)}; 
tab.onmouseout=function() {MyMar=setInterval(Marquee,speed)}; 
if(FeedData != null && FeedData.length > 0) {
    for(var i = 0; i < FeedData.length; i ++) {
               msg += "<span>【" + FeedData[i].datatype + "】</span>" +FeedData[i].title+" " +FeedData[i].time + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
    }
}
tab1.innerHTML = msg;
tab2.innerHTML = msg;
MyMar=setInterval(Marquee,speed);