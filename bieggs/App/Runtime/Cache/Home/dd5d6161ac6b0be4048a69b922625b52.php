<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>团购-专业的广告游戏平台</title>
    <link rel="stylesheet" type="text/css" href="__CSS__/bbs.css" />
    <link rel="stylesheet" type="text/css" href="__CSS__/TOP.css" />

    <style type="text/css">
    #topNav {
    width: 47px;
    z-index: 100;                                                     /*设置浮动层次*/
    overflow: visible;
    position: fixed;
    bottom: 210px;
    /*bottom: 330px;*/
    margin-left:980px;                                                        /* 其他浏览器下定位，在这里可设置坐标*/
    _position: absolute;                                       /*IE6 用absolute模拟fixed*/
    _top: expression(documentElement.scrollTop + documentElement.clientHeight-230 + "px"); /*IE6 动态设置top位置*/
    /* documentElement.scrollTop 设置浮动元素始终在浏览器最顶，可以加一个数值达到排版效果 */
    height: 63px;
    }
</style>

    <script language="javascript" type="text/javascript">
    function TabInfo(id) {
        if (id == '1') {
            document.getElementById('duo1').className = 'on _toggle_nav';
            document.getElementById('duo2').className = '_toggle_nav';
            document.getElementById('duo3').className = '_toggle_nav';
            document.getElementById('d_explain').style.display = '';
            document.getElementById('d_record').style.display = 'none';
            document.getElementById('d_rule').style.display = 'none';
        }
        if (id == '2') {
            document.getElementById('duo1').className = '_toggle_nav';
            document.getElementById('duo2').className = 'on _toggle_nav';
            document.getElementById('duo3').className = '_toggle_nav';
            document.getElementById('d_record').style.display = '';
            document.getElementById('d_explain').style.display = 'none';
            document.getElementById('d_rule').style.display = 'none';
        }
        if (id == '3') {
            document.getElementById('duo1').className = '_toggle_nav';
            document.getElementById('duo2').className = '_toggle_nav';
            document.getElementById('duo3').className = 'on _toggle_nav';
            document.getElementById('d_rule').style.display = '';
            document.getElementById('d_explain').style.display = 'none';
            document.getElementById('d_record').style.display = 'none';
            rm('div_ad');
        }
    }
    $(function () {
        $('#dialog0').dialog({
            autoOpen: false,
            modal: true,
            height: 160,
            width: 360
        });
        $('#dialog1').dialog({
            autoOpen: false,
            modal: true,
            height: 160,
            width: 360
        });
    });
    function colsedialog(d) {
        $("#" + d).dialog("close");
    }
    function opendialog(id) {
        $("#dialog" + id).dialog("open");
    }
</script>
    <!-- InstanceEndEditable -->
<!-- InstanceBeginEditable name="head" -->
    <!-- InstanceEndEditable -->
</head>

<body>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="__CSS__/naviation.css" />
    <link rel="stylesheet" type="text/css" href="__CSS__/com.css" />
</head>

<div id="header">
    <div id="navi_top">
        <div id="navi_topl">
            <ul>
                <li>
                    <a href="/iphone/iphoneindex.aspx" class="navi_top_img_phone">手机版</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a href="http://www.yy365.com/" target="_black" onclick="doSomething(event);">同玩社区</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a class="sheader_red" href="/vip/vip_index.aspx" onclick="doSomething(event);">VIP会员</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a href="/activity/Activity.aspx" target="_parent" onclick="doSomething(event);">蛋友活动</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a href="/Serving/help_servicemain.aspx" target="_parent" onclick="doSomething(event);">客服中心</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a href="#" onclick="addfavorite()">收藏</a>
                </li>
            </ul>
        </div>
        <div id="navi_topr">
            <ul>
                <li>
                    <a href="/newone/PgQCoinReg.aspx" onclick="doSomething(event);">注册</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a  id="fc_loginHead" style="cursor:pointer"  onclick="doSomething(event);">登录</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>您好，欢迎你的光临！</li>
            </ul>
        </div>
    </div>
    <!--logo guanggaobg-->    
    <div id="navi_mid"  >
        <a href="#">
            <div id="navi_midl"></div>
        </a>
        <a href="#">
            <div id="navi_midm"></div>
        </a>
        <a href="#">
            <div id="navi_midr"></div>
        </a>
    </div>
    <!--daohang-->    
    <div id="navi_bottom">
        <div id="navi_bottom_content">
            <ul id="main_nav">
                <li>
                    <a class="navibar_1" href="<?php echo U('/index');?>" target="_parent" onclick="doSomething(event);">首&nbsp&nbsp页</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a class="navibar_2" href="<?php echo U('/ad');?>" target="_parent" onclick="doSomething(event);">广告体验</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a class="navibar_3" href="<?php echo U('/buy');?>" target="_parent" onclick="doSomething(event);">蛋蛋团购</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a class="navibar_4" href="<?php echo U('/game');?>" target="_parent" onclick="doSomething(event);">游戏竞猜</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a class="navibar_5" href="<?php echo U('/activity');?>" target="_parent" onclick="doSomething(event);">活动中心</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a class="navibar_6" href="<?php echo U('/prize');?>" target="_parent" onclick="doSomething(event);">兑换中心</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a class="navibar_7" href="<?php echo U('/user');?>" target="_parent" onclick="doSomething(event);">个人中心</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a class="navibar_8" href="<?php echo U('/glory');?>" onclick="addfavorite()">晒奖</a>
                </li>
            </ul>
            <ul class="main_navr">
                <li>
                    <a class="navibar_11" href="<?php echo U('/help');?>" target="_parent" onclick="doSomething(event);">帮助</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a class="navibar_10" href="<?php echo U('/invest');?>" target="_parent" onclick="doSomething(event);">推广有奖</a>
                </li>
                <li class="sheader_line">&nbsp;</li>
                <li>
                    <a class="navibar_9" href="<?php echo U('/bbs');?>" target="_parent" onclick="doSomething(event);">讨论区</a>
                </li>
            </ul>
        </div>
    </div>
</div>
<style type="text/css">
  .navibar_<?php echo ($PAGE_CURID); ?>{color: #ff0000; font-weight:bold;}
</style>
<div id="body_content">
        <head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="__CSS__/runtext.css" />
</head>

<div class=dynamic_msg>
  <div class=dynamic_msg_l>【公告】这里是公告信息</div>
  <div class=dynamic_msg_r style="float:right;overflow:hidden">
    <div id="demo">
      <div id="indemo">
        <div id="demo1"></div>
        <div id="demo2"></div>
      </div>
    </div>
  </div>
</div>
<script type="text/javascript">
    var FeedData = {title:'蛋友<a href="/FriendInfor/FriendPrize.aspx?userid=8764495">__USERID__</a>兑换了<a href="/prize/prizeDetail.aspx?ISSUE=ZC0266">__P_NAME__</a>',datatype:'奖品',time:'__TIME__'};
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
    <?php if(is_array($db_dj_slider)): $i = 0; $__LIST__ = $db_dj_slider;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i;?>var user_id = "<?php echo ($vo["user_id"]); ?>"; 
        var p_name = "<?php echo ($vo["p_name"]); ?>"; 
        var time = "<?php echo ($vo["time"]); ?>"; 
        msg += "<span>【" + FeedData.datatype + "】</span>" + FeedData.title.replace("__USERID__",user_id).replace("__P_NAME__",p_name) +" " + FeedData.time.replace("__TIME__",time) + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";<?php endforeach; endif; else: echo "" ;endif; ?> 
    tab1.innerHTML = msg;
    tab2.innerHTML = msg;
    MyMar=setInterval(Marquee,speed);
</script>

        <div class="doc" style="font:400 12px/1.5 Simsun,Arial;color:#333;">
            <form name="pagination" method="post" action="http://www.pceggs.com/nbbs/bbsMain.aspx" id="pagination">
                <div>
                    <input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE" value="/wEPDwUKMTIzMDkyMTg4M2RkgyOGpzT+k3SeTW1VDPQZIooUnqU="></div>

                <div class="tab_bbs_tl">
                    <ul>
                        <li style="margin-left:16px;*margin-left:8px;">
                            <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=0">00#综合版</a>
                        </li>
                        <li>
                            <img class="topmargin" src="__IMAGES__/bbs/sline_h.png"></li>
                        <li>
                            <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=1">01#游戏试玩</a>
                        </li>
                        <li>
                            <img class="topmargin" src="__IMAGES__/bbs/sline_h.png"></li>
                        <li class="selected" style="margin-left:6px;*margin-left:3px;">
                            <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3">02#购物分享</a>
                        </li>
                        <li>
                            <img class="topmargin" src="__IMAGES__/bbs/sline_h.png"></li>
                        <li>
                            <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=10">03#夺宝</a>
                        </li>
                        <li>
                            <img class="topmargin" src="__IMAGES__/bbs/sline_h.png"></li>
                        <li>
                            <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=4">04#竞猜</a>
                        </li>
                        <li>
                            <img class="topmargin" src="__IMAGES__/bbs/sline_h.png"></li>
                        <li>
                            <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=2">05#体验</a>
                        </li>
                        <li>
                            <img class="topmargin" src="__IMAGES__/bbs/sline_h.png"></li>
                        <li>
                            <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=9">06#随便聊聊</a>
                        </li>
                        <li>
                            <img class="topmargin" src="__IMAGES__/bbs/sline_h.png"></li>
                        <li>
                            <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=5">07#兑奖</a>
                        </li>
                        <li>
                            <img class="topmargin" src="__IMAGES__/bbs/sline_h.png"></li>
                    </ul>

                </div>
                <div class="layout_wz">
                    <div class="discuss_ggw">
                        <a id="tbhref" href="http://adtaste.pceggs.com/2013TY/Gameinfo.aspx?id=116542" target="_blank">
                            <img src="__IMAGES__/bbs/ct_bbs.jpg"></a>

                        <!-- <iframe id="baiduSpFrame" border="0" vspace="0" hspace="0" marginwidth="0" marginheight="0" framespacing="0" frameborder="0" scrolling="no" width="946px" height="60px" src="http://pk.pceggs.com/Pg28pkad.aspx"></iframe>
                    -->
                </div>
                <div class="discuss_ft">
                    <div class="discuss_ftl">
                        <a href="http://www.pceggs.com/nbbs/bbsAdd.aspx?topicid=3">
                            <img src="__IMAGES__/bbs/fbtz_an.jpg" border="0"></a>
                        <!--&nbsp;&nbsp;&nbsp;&nbsp;<img src="images/fbtz_an.jpg" />
                        -->
                    </div>
                    <div class="discuss_ftr">
                        <script language="javascript" type="text/javascript">
    function onsubmit(CurrentPageIndex)
    {
        //document.getElementById("CurrentPageIndex").value = CurrentPageIndex ;
        //document.getElementById("pagination").action=window.location;
        //document.getElementById("pagination").submit();
        var CurrentURL = document.URL;
        var right = GetQueryString("CurrentPageIndex")
        if(right == "")
        {
            if(CurrentURL.indexOf("?") > -1){
                CurrentURL = CurrentURL + "&CurrentPageIndex="+CurrentPageIndex;
            }else{
                CurrentURL = CurrentURL + "?CurrentPageIndex="+CurrentPageIndex;
            }
        }else{
            CurrentURL = CurrentURL.replace("CurrentPageIndex="+right,"CurrentPageIndex="+CurrentPageIndex);
        }
        document.location.href=CurrentURL;
    }
    
    function GetQueryString(name) {

       var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)","i");

       var r = window.location.search.substr(1).match(reg);

       if (r!=null) return unescape(r[2]); return "";

    }


</script>
                        <style type="text/css">
<!--
/*page*/
.pageb {float:right;padding:8px 0px 10px 0px;*padding:8px 0px 12px 0px;font:12px/1.5 'lucida grande',tahoma,arial,'bitstream vera sans',helvetica,sans-serif;font-size:12px;}
.pageb a{padding:2px 5px 2px 5px;margin-left:2px;color:#333;border:#ccc 1px solid;text-decoration:none;}
.pageb a:hover{padding:2px 5px 2px 5px;margin-left:2px;border:#9A9A9A 1px solid;background:#E6E7E9;text-decoration:none;color:#333;}
.pageb a:active {padding:2px 5px 2px 5px;margin-left:2px;border:#333 1px solid;}
.pageb .current {padding:2px 5px 2px 5px;margin-left:2px;border:#9A9A9A 1px solid; background:#DaDaDa;font-weight:bold;}
-->
</style>

                        <div class="pageb">
                            <a href="javascript:onsubmit(1);">&lt;&lt;</a>
                            <a href="javascript:onsubmit(1);">&lt;</a>
                            <a class="current">1</a>
                            <a href="javascript:onsubmit(2);" target="_top">2</a>
                            <a href="javascript:onsubmit(3);" target="_top">3</a>
                            <a href="javascript:onsubmit(4);" target="_top">4</a>
                            <a href="javascript:onsubmit(5);" target="_top">5</a>
                            <a href="javascript:onsubmit(6);" target="_top">6</a>
                            <a href="javascript:onsubmit(7);" target="_top">7</a>
                            <a href="javascript:onsubmit(8);" target="_top">8</a>
                            <a href="javascript:onsubmit(9);" target="_top">9</a>
                            <a href="javascript:onsubmit(10);" target="_top">10</a>
                            <a href="javascript:onsubmit(2);">&gt;</a>
                            <a href="javascript:onsubmit(123);">&gt;&gt;</a>
                        </div>
                    </div>
                </div>

            </div>

            <div id="topNav">
                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;CurrentPageIndex=1#totop" style="float:right;">
                    <img src="__IMAGES__/bbs/tlq_beta3_totopimg.gif" width="47"></a>
            </div>

            <div class="layout_wz bbs_layout_dbg clearall">
                <div id="main-wrap">
                    <div class="list-tab">
                        <div class="list-tab-hd">

                            <ul class="link1" id="tabbar">
                                <li class="current"> <strong>帖子</strong>
                                </li>
                                <li>
                                    <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;goodtype=1&amp;z=1">精华</a>
                                </li>
                                <li>
                                    <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;userid=1873372&amp;z=2">我发表的帖子</a>
                                </li>
                            </ul>

                        </div>
                        <script type="text/javascript">

                var url = document.location.href;
                if (url.indexOf("userid") > 0) {
                    $("#tabbar").html('<li><a  href="/nbbs/bbsMain.aspx?topicid=3">帖子</a></li><li><a  href="/nbbs/bbsMain.aspx?topicid=3&goodtype=1&z=1">精华</a></li><li class="current"><strong>我发表的帖子</strong></li>');
                }
                if (url.indexOf("goodtype") > 0) {
                    $("#tabbar").html('<li><a  href="/nbbs/bbsMain.aspx?topicid=3">帖子</a></li><li class="current"><strong>精华</strong></li><li><a  href="/nbbs/bbsMain.aspx?topicid=3&userid=1873372&z=2">我发表的帖子</a></li>');
                }


        
    
        
        </script>
                        <div class="list-tab-bd">

                            <div class="list-sort link1"> <i class="color9">主题标签：</i>
                                <div class="list-sort-items" style="padding-bottom:5px;"> <em><a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3">全部</a></em> 
                                    <h2>
                                        <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">淘宝返利</a>
                                        <span class="color6">(6410)</span>
                                    </h2>
                                    <h2>
                                        <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=26">其他</a>
                                        <span class="color6">(563)</span>
                                    </h2>
                                </div>

                            </div>

                            <input type="hidden" name="fid" value="9">

                            <table class="list-data">
                                <thead>
                                    <tr>

                                        <th colspan="2" class="data-orderby">标题</th>
                                        <th width="86" class="author">作者</th>
                                        <th width="38" class="num">回复</th>
                                        <th width="68" class="lastpost">最后发表</th>
                                    </tr>
                                </thead>

                                <tbody>
                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/stick_2.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor3">【</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=7&amp;lid=39">
                                                    <span class="titlecolor3">公告</span>
                                                </a>
                                                <span class="titlecolor3">】</span>
                                                <a title="2014年首波游戏试玩冲冲冲圆满结束，请尽快领取奖励！" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874665&amp;topicid=7&amp;ret=1">
                                                    <span class="titlecolor3">2014年首波游戏试玩冲冲冲圆满结束，请尽快领取奖励！</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=1002" title="客服1002">客服1002</a>
                                            <br>
                                            <span class="color9">2014/5/28</span>
                                        </td>
                                        <td class="num numeral"> <em>&nbsp;</em>
                                            <span>13</span>
                                        </td>
                                        <td class="lastpost">
                                            <em><a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17155890" title="清澈涧抵">清澈涧抵</a></em> 
                                            <span class="numeral">06-04 15:04</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/stick_2.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor3">【</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=7&amp;lid=39">
                                                    <span class="titlecolor3">公告</span>
                                                </a>
                                                <span class="titlecolor3">】</span>
                                                <a title="淘宝返利金蛋满就送活动圆满结束，请尽快领奖！" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874671&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor3">淘宝返利金蛋满就送活动圆满结束，请尽快领奖！</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=1003" title="客服1003">客服1003</a>
                                            <br>
                                            <span class="color9">2014/5/28</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>4</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17721389" title=" 大王">大王</a>
                                            </em>
                                            <span class="numeral">05-30 12:49</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/stick_2.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">【</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=7&amp;lid=39">
                                                    <span class="titlecolor0">公告</span>
                                                </a>
                                                <span class="titlecolor0">】</span>
                                                <a title="PC蛋蛋讨论区总版规" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=132043&amp;topicid=7&amp;ret=1">
                                                    <span class="titlecolor0">PC蛋蛋讨论区总版规</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=1001" title=""></a>
                                            <br>
                                            <span class="color9">2008/11/5</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>798</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16747432" title="小天" _我的一片天"="">小天"_我的</a>
                                            </em>
                                            <span class="numeral">05-29 13:45</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/stick_1.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">【</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">】</span>
                                                <a title="金金的淘蛋生活，教你玩转淘宝返利" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=240731&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">金金的淘蛋生活，教你玩转淘宝返利</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=1005" title="客服1005">客服1005</a>
                                            <br>
                                            <span class="color9">2010/1/6</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>59</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16883987" title="你懂个蛋">你懂个蛋</a>
                                            </em>
                                            <span class="numeral">05-17 15:42</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/stick_1.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor1">【</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor1">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor1">】</span>
                                                <a title="狗粮的返利到了 晒狗狗 O(∩_∩)O 晒幸福  萌死你~" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3846388&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor1">狗粮的返利到了 晒狗狗 O(∩_∩)O 晒幸福  萌死你~</span>
                                                </a>
                                                <img src="__IMAGES__/bbs/pink_2.gif" width="21" height="20"></div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16535622" title="指尖">指尖</a>
                                            <br>
                                            <span class="color9">2013/6/21</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>7</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=12802828" title="日日随缘过">日日随缘过</a>
                                            </em>
                                            <span class="numeral">05-15 15:11</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/stick_1.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">【</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">】</span>
                                                <a title="购物返蛋蛋给力，增加了我玩蛋蛋的信心！有本玩28喽！" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3843066&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">购物返蛋蛋给力，增加了我玩蛋蛋的信心！有本玩28喽！</span>
                                                </a>
                                                <img src="__IMAGES__/bbs/pink_1.gif" width="21" height="20"></div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=7802088" title="100度">100度</a>
                                            <br>
                                            <span class="color9">2013/5/20</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>10</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16719543" title="小儿多动症">小儿多动症</a>
                                            </em>
                                            <span class="numeral">03-21 12:51</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/stick_1.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">【</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">】</span>
                                                <a title="“购物返利专区”版规" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=263612&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">“购物返利专区”版规</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=1005" title="客服1005">客服1005</a>
                                            <br>
                                            <span class="color9">2010/5/17</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>45</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=8411828" title="梅子">梅子</a>
                                            </em>
                                            <span class="numeral">05-17 12:35</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/stick_1.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">【</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">】</span>
                                                <a title="购物返利常见问题汇总" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=262090&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">购物返利常见问题汇总</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=1005" title="客服1005">客服1005</a>
                                            <br>
                                            <span class="color9">2010/5/7</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>6</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=6280583" title="我是风">我是风</a>
                                            </em>
                                            <span class="numeral">01-11 12:17</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/stick_1.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">【</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=7&amp;lid=39">
                                                    <span class="titlecolor0">公告</span>
                                                </a>
                                                <span class="titlecolor0">】</span>
                                                <a title="关于“淘宝返利”使用流程的调整说明，购物的亲必看！" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3861910&amp;topicid=7&amp;ret=1">
                                                    <span class="titlecolor0">关于“淘宝返利”使用流程的调整说明，购物的亲必看！</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=1008" title="客服1008">客服1008</a>
                                            <br>
                                            <span class="color9">2013/12/4</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>24</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17552841" title="异地">异地</a>
                                            </em>
                                            <span class="numeral">01-17 11:27</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/stick_1.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">【</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=7&amp;lid=39">
                                                    <span class="titlecolor0">公告</span>
                                                </a>
                                                <span class="titlecolor0">】</span>
                                                <a title="关于“淘宝返利”使用调整的相关说明" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3860412&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">关于“淘宝返利”使用调整的相关说明</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=1008" title="客服1008">客服1008</a>
                                            <br>
                                            <span class="color9">2013/11/15</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>22</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=1357646" title="靓仔哥哥">靓仔哥哥</a>
                                            </em>
                                            <span class="numeral">12-12 17:26</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/stick_1.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">【</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=7&amp;lid=39">
                                                    <span class="titlecolor0">公告</span>
                                                </a>
                                                <span class="titlecolor0">】</span>
                                                <a title="“淘宝返利”部分浏览器搜索结果为空白的解决办法" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3861393&amp;topicid=7&amp;ret=1">
                                                    <span class="titlecolor0">“淘宝返利”部分浏览器搜索结果为空白的解决办法</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=1008" title="客服1008">客服1008</a>
                                            <br>
                                            <span class="color9">2013/11/28</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=1008" title="客服1008">客服1008</a>
                                            </em>
                                            <span class="numeral">11-28 17:08</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="厚积薄发，储存金蛋兑换IPHONE5S" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3875025&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">厚积薄发，储存金蛋兑换IPHONE5S</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17804256" title=" 361335846">36133584</a>
                                            <br>
                                            <span class="color9">2014/6/4</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>8</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17324952" title="kengg">kengg</a>
                                            </em>
                                            <span class="numeral">06-05 09:46</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="给妈妈的夏天沙发凉垫---蛋蛋返利哦" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3875053&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">给妈妈的夏天沙发凉垫---蛋蛋返利哦</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            <br>
                                            <span class="color9">2014/6/4</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            </em>
                                            <span class="numeral">06-04 20:00</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="淘宝小裤来到--蛋蛋淘宝返利" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3875049&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">淘宝小裤来到--蛋蛋淘宝返利</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            <br>
                                            <span class="color9">2014/6/4</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            </em>
                                            <span class="numeral">06-04 19:23</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="怎么我最近淘宝老是掉单啊！！" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3875014&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">怎么我最近淘宝老是掉单啊！！</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=15850053" title="转角的幸福">转角的幸福</a>
                                            <br>
                                            <span class="color9">2014/6/4</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>1</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=15850053" title="转角的幸福">转角的幸福</a>
                                            </em>
                                            <span class="numeral">06-04 17:40</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="　　最爽的一次购物返利，返利1050万蛋蛋" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874915&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">最爽的一次购物返利，返利1050万蛋蛋</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=9053943" title=""></a>
                                            <br>
                                            <span class="color9">2014/6/2</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>3</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=9053943" title=""></a>
                                            </em>
                                            <span class="numeral">06-03 22:08</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="买了个 吹风筒，风力不错哦！" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874941&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">买了个 吹风筒，风力不错哦！</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16310997" title="shyson231">shyson231</a>
                                            <br>
                                            <span class="color9">2014/6/3</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16310997" title="shyson231">shyson231</a>
                                            </em>
                                            <span class="numeral">06-03 08:19</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <a title="我的返利单子又丢了" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874938&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">我的返利单子又丢了</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=15988946" title="还我的蛋蛋">还我的蛋蛋</a>
                                            <br>
                                            <span class="color9">2014/6/3</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=15988946" title="还我的蛋蛋">还我的蛋蛋</a>
                                            </em>
                                            <span class="numeral">06-03 02:33</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="改版后能不能加入购物车了？" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874928&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">改版后能不能加入购物车了？</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=9015462" title=""></a>
                                            <br>
                                            <span class="color9">2014/6/2</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=9015462" title=""></a>
                                            </em>
                                            <span class="numeral">06-02 19:11</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="哈哈  返这么多" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874875&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">哈哈  返这么多</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=7202580" title="我要5亿~-~">我要5亿~-</a>
                                            <br>
                                            <span class="color9">2014/6/1</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>1</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=14196496" title="改个名字试下">改个名字试</a>
                                            </em>
                                            <span class="numeral">06-02 11:18</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="哈，哈，" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874882&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">哈，哈，</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=6161865" title="绿色幽灵">绿色幽灵</a>
                                            <br>
                                            <span class="color9">2014/6/1</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=6161865" title="绿色幽灵">绿色幽灵</a>
                                            </em>
                                            <span class="numeral">06-01 19:26</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="最近发现购物比游戏充值划算" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874880&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">最近发现购物比游戏充值划算</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=13503339" title="过年">过年</a>
                                            <br>
                                            <span class="color9">2014/6/1</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>1</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=13503339" title="过年">过年</a>
                                            </em>
                                            <span class="numeral">06-01 18:22</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="是不是掉单了？" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874847&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">是不是掉单了？</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17136243" title="秋叶半黄">秋叶半黄</a>
                                            <br>
                                            <span class="color9">2014/5/31</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17136243" title="秋叶半黄">秋叶半黄</a>
                                            </em>
                                            <span class="numeral">05-31 20:25</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="淘宝返利爽啊，我还会再来的" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874808&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">淘宝返利爽啊，我还会再来的</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16596456" title="蛋蛋">蛋蛋</a>
                                            <br>
                                            <span class="color9">2014/5/30</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16596456" title="蛋蛋">蛋蛋</a>
                                            </em>
                                            <span class="numeral">05-30 19:48</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="掉单了  帮忙看看" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874764&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">掉单了  帮忙看看</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=14371960" title="一月不碰这号">一月不碰这</a>
                                            <br>
                                            <span class="color9">2014/5/30</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=14371960" title="一月不碰这号">一月不碰这</a>
                                            </em>
                                            <span class="numeral">05-30 11:45</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="淘宝返利  手机订单有返利拿吗？" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874724&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">淘宝返利  手机订单有返利拿吗？</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=9243598" title="、天王盖地虎">、天王盖地</a>
                                            <br>
                                            <span class="color9">2014/5/29</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=9243598" title="、天王盖地虎">、天王盖地</a>
                                            </em>
                                            <span class="numeral">05-29 16:10</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="帮忙查查" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874718&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">帮忙查查</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=4877681" title=""></a>
                                            <br>
                                            <span class="color9">2014/5/29</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=4877681" title=""></a>
                                            </em>
                                            <span class="numeral">05-29 14:25</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="整张牛的牛皮凉席--蛋蛋活动加成" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874708&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">整张牛的牛皮凉席--蛋蛋活动加成</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            <br>
                                            <span class="color9">2014/5/29</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            </em>
                                            <span class="numeral">05-29 11:17</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="零食来也--蛋蛋活动加成哦" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874705&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">零食来也--蛋蛋活动加成哦</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            <br>
                                            <span class="color9">2014/5/29</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            </em>
                                            <span class="numeral">05-29 10:58</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="大家伙来了蛋蛋活动加成哦（有找店家要红包的诀窍哦）" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874703&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">大家伙来了蛋蛋活动加成哦（有找店家要红包的诀窍哦）</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            <br>
                                            <span class="color9">2014/5/29</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            </em>
                                            <span class="numeral">05-29 10:51</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="关于淘宝返利满就送的疑问？" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874641&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">关于淘宝返利满就送的疑问？</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=5335487" title="lylyc">lylyc</a>
                                            <br>
                                            <span class="color9">2014/5/28</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=5335487" title="lylyc">lylyc</a>
                                            </em>
                                            <span class="numeral">05-28 09:18</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="淘宝购物的新一代市场。" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874625&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">淘宝购物的新一代市场。</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17471283" title=" 妙妙">妙妙</a>
                                            <br>
                                            <span class="color9">2014/5/27</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17471283" title=" 妙妙">妙妙</a>
                                            </em>
                                            <span class="numeral">05-27 20:39</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="碗碟架到了" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874622&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">碗碟架到了</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=15009574" title="夏天">夏天</a>
                                            <br>
                                            <span class="color9">2014/5/27</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=15009574" title="夏天">夏天</a>
                                            </em>
                                            <span class="numeral">05-27 19:50</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="淘宝返利真好" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874619&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">淘宝返利真好</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=8877366" title="lytckd">lytckd</a>
                                            <br>
                                            <span class="color9">2014/5/27</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=8877366" title="lytckd">lytckd</a>
                                            </em>
                                            <span class="numeral">05-27 19:39</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="愉快购物分享之西域美农大枣" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874570&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">愉快购物分享之西域美农大枣</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16522648" title="寂寞的小怪兽">寂寞的小怪</a>
                                            <br>
                                            <span class="color9">2014/5/27</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16522648" title="寂寞的小怪兽">寂寞的小怪</a>
                                            </em>
                                            <span class="numeral">05-27 11:47</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="糖果色小衬衣到货--蛋蛋的返利活动！" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874569&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">糖果色小衬衣到货--蛋蛋的返利活动！</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            <br>
                                            <span class="color9">2014/5/27</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            </em>
                                            <span class="numeral">05-27 11:31</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="七分袖碎花衬衣--蛋蛋返利活动" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874568&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">七分袖碎花衬衣--蛋蛋返利活动</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            <br>
                                            <span class="color9">2014/5/27</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            </em>
                                            <span class="numeral">05-27 11:20</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="鞋子到货--蛋蛋的给力+返利活动" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874566&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">鞋子到货--蛋蛋的给力+返利活动</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            <br>
                                            <span class="color9">2014/5/27</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16750861" title="dagei">dagei</a>
                                            </em>
                                            <span class="numeral">05-27 11:08</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="还没收到返利。客服进请查看看" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874545&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">还没收到返利。客服进请查看看</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17361357" title=" 阿剑">阿剑</a>
                                            <br>
                                            <span class="color9">2014/5/26</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17361357" title=" 阿剑">阿剑</a>
                                            </em>
                                            <span class="numeral">05-26 18:23</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="买了部手机，还没有收到返利客服请进" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874505&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">买了部手机，还没有收到返利客服请进</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17361357" title=" 阿剑">阿剑</a>
                                            <br>
                                            <span class="color9">2014/5/25</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>1</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17361357" title=" 阿剑">阿剑</a>
                                            </em>
                                            <span class="numeral">05-26 18:12</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="返利 给力啊！！" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874531&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">返利 给力啊！！</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17484089" title="娃哈哈丨">娃哈哈丨</a>
                                            <br>
                                            <span class="color9">2014/5/26</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>2</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=13487647" title="上亿不是梦">上亿不是梦</a>
                                            </em>
                                            <span class="numeral">05-26 17:24</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="没有返利！！！" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874521&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">没有返利！！！</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=12183724" title="12183724">12183724</a>
                                            <br>
                                            <span class="color9">2014/5/26</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>1</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=12183724" title="12183724">12183724</a>
                                            </em>
                                            <span class="numeral">05-26 16:12</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <a title="真够给力的，还里可以做，淘宝返利比试玩来得更猛" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874534&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">真够给力的，还里可以做，淘宝返利比试玩来得更猛</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16874514" title=" ゞ悠悠ゞ\/fw">ゞ悠悠ゞ\/</a>
                                            <br>
                                            <span class="color9">2014/5/26</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16874514" title=" ゞ悠悠ゞ\/fw">ゞ悠悠ゞ\/</a>
                                            </em>
                                            <span class="numeral">05-26 13:59</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="咋办呢？" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874508&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">咋办呢？</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=4877681" title=""></a>
                                            <br>
                                            <span class="color9">2014/5/25</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=4877681" title=""></a>
                                            </em>
                                            <span class="numeral">05-25 21:32</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="没有返利" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874469&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">没有返利</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17229544" title="康桥">康桥</a>
                                            <br>
                                            <span class="color9">2014/5/24</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17229544" title="康桥">康桥</a>
                                            </em>
                                            <span class="numeral">05-24 22:36</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="返利800000" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874376&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">返利800000</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=12116550" title="一半是人">一半是人</a>
                                            <br>
                                            <span class="color9">2014/5/23</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=12116550" title="一半是人">一半是人</a>
                                            </em>
                                            <span class="numeral">05-23 10:20</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/tzyhf.gif" title="客服有回复"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="第一次淘宝返利，77元得百万金蛋和额外奖励！" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874371&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">第一次淘宝返利，77元得百万金蛋和额外奖励！</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=6211629" title="黑羽">黑羽</a>
                                            <br>
                                            <span class="color9">2014/5/23</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=6211629" title="黑羽">黑羽</a>
                                            </em>
                                            <span class="numeral">05-23 09:06</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="返利了，篮球" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874353&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">返利了，篮球</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17261015" title="明名">明名</a>
                                            <br>
                                            <span class="color9">2014/5/22</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>0</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17261015" title="明名">明名</a>
                                            </em>
                                            <span class="numeral">05-22 20:32</span>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="购物返利真给力" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874314&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">购物返利真给力</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16624084" title="惊雷">惊雷</a>
                                            <br>
                                            <span class="color9">2014/5/22</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>1</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16624084" title="惊雷">惊雷</a>
                                            </em>
                                            <span class="numeral">05-22 08:40</span>
                                        </td>
                                    </tr>

                                    <tr class="gray">
                                        <td width="32" class="icon">

                                            <div>
                                                <img src="__IMAGES__/bbs/pttz.gif"></div>
                                        </td>
                                        <th width="492" class="title">
                                            <div class="subject">
                                                <span class="titlecolor0">[</span>
                                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;lid=21">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                                <span class="titlecolor0">]</span>
                                                <a title="淘宝返利" href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=3874264&amp;topicid=3&amp;ret=1">
                                                    <span class="titlecolor0">淘宝返利</span>
                                                </a>
                                            </div>
                                        </th>
                                        <td class="author">
                                            <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16886322" title="ying">ying</a>
                                            <br>
                                            <span class="color9">2014/5/21</span>
                                        </td>
                                        <td class="num numeral">
                                            <em>&nbsp;</em>
                                            <span>1</span>
                                        </td>
                                        <td class="lastpost">
                                            <em>
                                                <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17787440" title="nywzyll">nywzyll</a>
                                            </em>
                                            <span class="numeral">05-22 00:17</span>
                                        </td>
                                    </tr>

                                </tbody>
                            </table>

                        </div>
                    </div>

                    <div class="discuss_ft" style="width:740px;">
                        <div class="discuss_ftl fbtz_s">发布帖子</div>
                        <div class="discuss_ftr">
                            <script language="javascript" type="text/javascript">
    function onsubmit(CurrentPageIndex)
    {
        //document.getElementById("CurrentPageIndex").value = CurrentPageIndex ;
        //document.getElementById("pagination").action=window.location;
        //document.getElementById("pagination").submit();
        var CurrentURL = document.URL;
        var right = GetQueryString("CurrentPageIndex")
        if(right == "")
        {
            if(CurrentURL.indexOf("?") > -1){
                CurrentURL = CurrentURL + "&CurrentPageIndex="+CurrentPageIndex;
            }else{
                CurrentURL = CurrentURL + "?CurrentPageIndex="+CurrentPageIndex;
            }
        }else{
            CurrentURL = CurrentURL.replace("CurrentPageIndex="+right,"CurrentPageIndex="+CurrentPageIndex);
        }
        document.location.href=CurrentURL;
    }
    
    function GetQueryString(name) {

       var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)","i");

       var r = window.location.search.substr(1).match(reg);

       if (r!=null) return unescape(r[2]); return "";

    }


</script>
                            <style type="text/css">
<!--
/*page*/
.pageb {float:right;padding:8px 0px 10px 0px;*padding:8px 0px 12px 0px;font:12px/1.5 'lucida grande',tahoma,arial,'bitstream vera sans',helvetica,sans-serif;font-size:12px;}
.pageb a{padding:2px 5px 2px 5px;margin-left:2px;color:#333;border:#ccc 1px solid;text-decoration:none;}
.pageb a:hover{padding:2px 5px 2px 5px;margin-left:2px;border:#9A9A9A 1px solid;background:#E6E7E9;text-decoration:none;color:#333;}
.pageb a:active {padding:2px 5px 2px 5px;margin-left:2px;border:#333 1px solid;}
.pageb .current {padding:2px 5px 2px 5px;margin-left:2px;border:#9A9A9A 1px solid; background:#DaDaDa;font-weight:bold;}
-->
</style>

                            <div class="pageb">
                                <a href="javascript:onsubmit(1);">&lt;&lt;</a>
                                <a href="javascript:onsubmit(1);">&lt;</a>
                                <a class="current">1</a>
                                <a href="javascript:onsubmit(2);" target="_top">2</a>
                                <a href="javascript:onsubmit(3);" target="_top">3</a>
                                <a href="javascript:onsubmit(4);" target="_top">4</a>
                                <a href="javascript:onsubmit(5);" target="_top">5</a>
                                <a href="javascript:onsubmit(6);" target="_top">6</a>
                                <a href="javascript:onsubmit(7);" target="_top">7</a>
                                <a href="javascript:onsubmit(8);" target="_top">8</a>
                                <a href="javascript:onsubmit(9);" target="_top">9</a>
                                <a href="javascript:onsubmit(10);" target="_top">10</a>
                                <a href="javascript:onsubmit(2);">&gt;</a>
                                <a href="javascript:onsubmit(123);">&gt;&gt;</a>
                            </div>
                        </div>
                    </div>

                    <div class="post-mod" style="position:relative;top:0px;">

                        <ul class="post-bd">
                            <li class="post-to">
                                <!--=S post-to-mod -->
                                <div class="post-to-mod">
                                    <span class="post-label">发&nbsp;帖&nbsp;到：</span>
                                    <select name="hitpid" id="hitpid" onchange="bigcategary(this)" style="height:22px; line-height:22px; width:100px;text-align:center;">
                                        <option value="">请选择</option>
                                        <option value="1">01#游戏试玩</option>
                                        <option value="3">02#购物分享</option>
                                        <option value="10">03#夺宝</option>
                                        <option value="4">04#竞猜</option>
                                        <option value="2">05#体验</option>
                                        <option value="9">06#随便聊聊</option>
                                        <option value="5">07#兑奖</option>
                                        <option value="7">09#公告</option>
                                        <option value="8">10#客户服务</option>
                                    </select>
                                </div>

                                <script type="text/javascript" language="javascript">
            var pidv = "3";
            //设置选中项
            $("#hitpid").val(pidv);
            bigcategary(pidv);
      </script>
                                <!--=E post-to-mod --> </li>
                            <li class="post-tag">
                                <div class="post-tag_ztbq">
                                    <label for="title">主题标签：</label>
                                </div>
                                <div class="post-tag_ztbqnr">
                                    <span id="radiolist">
                                        <label>
                                            <input type="radio" name="radiolable" value="21" id="lib21">淘宝返利</label>
                                        <label>
                                            <input type="radio" name="radiolable" value="26" id="lib26">其他</label>
                                    </span>
                                </div>
                            </li>

                            <li class="post-title">
                                <label for="title">标&nbsp;&nbsp;&nbsp;&nbsp;题：</label>
                                <input type="text" name="subject" class="txt" value="" id="subject"></li>

                            <li class="ue-editor">
                                <div class="post_wby" id="text_an">
                                    <div class="post_fbtb_an" id="an1">
                                        <img src="__IMAGES__/bbs/bq_tb.gif" border="0" style="cursor:pointer;"></div>
                                    <div class="post_fbtb_an" id="an2">
                                        <img src="__IMAGES__/bbs/img_tb.gif" border="0" style="cursor:pointer;"></div>
                                    <div class="post_fbtb_an" id="an3">
                                        <img src="__IMAGES__/bbs/clj_tb.gif" border="0" style="cursor:pointer;"></div>
                                </div>
                                <!--表情层-->
                                <div class="dis_bq_l" style=" display:none;" id="big_biaoqing"></div>
                                <div class="dis_fc_bq" style=" display:none;left:26px" id="biaoqing">
                                    <div style="width:316px; margin:0 auto;">
                                        <div class="dis_fc_tbkj">
                                            <div class="dis_fc_tab-hd clearall">
                                                <p class="fc_tab-item">
                                                    <a class="selected">
                                                        <span>蛋&nbsp;蛋</span>
                                                    </a>
                                                </p>
                                            </div>
                                        </div>
                                        <div class="dis_fc_table">
                                            <table cellspacing="0" id="smarll_biaoqing">
                                                <tbody>
                                                    <tr>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_0.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_1.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_2.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_3.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_4.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_5.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_6.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_7.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_8.gif" style="cursor:pointer;"></td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_9.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_10.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_11.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_12.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_13.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_14.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_15.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_16.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_17.gif" style="cursor:pointer;"></td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_18.gif" style="cursor:pointer;"></td>
                                                        <td>
                                                            <img src="__IMAGES__/bbs/pceggs_19.gif" style="cursor:pointer;"></td>
                                                        <td>&nbsp;</td>
                                                        <td>&nbsp;</td>
                                                        <td>&nbsp;</td>
                                                        <td>&nbsp;</td>
                                                        <td>&nbsp;</td>
                                                        <td>&nbsp;</td>
                                                        <td>&nbsp;</td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                                <!--上传图片层-->
                                <div class="dis_fc_bq fc_img" id="uploadimg" style="display:none;height:230px;left:56px;">
                                    <div class="dis_fcgban" style="padding-left:372px;*padding-left:364px;">
                                        <img src="__IMAGES__/bbs/dis_fc_gban.gif" border="0" style="cursor:pointer;" onclick="closec()"></div>
                                    <div style="width:376px; margin:0 auto;*margin-left:8px;">
                                        <div class="dis_fc_tbkj" style=" margin-top: 14px;*margin-top:0px;">
                                            <div class="dis_fc_tab-hd clearall">
                                                <p class="fc_tab-item">
                                                    <a class="selected" id="up1" onclick="up(1)">
                                                        <span>本地上传</span>
                                                    </a>
                                                    <a id="up2" onclick="up(2)">
                                                        <span>网络上传</span>
                                                    </a>
                                                </p>
                                            </div>
                                        </div>
                                        <div class="dis_fc_table_p">
                                            <div style="padding-left:10px; float:left; padding-top:5px;width:100%;line-height:25px;">注：每张照片大小不能超过5M，支持 .jpeg .jpg .gif .png 格式</div>
                                            <div style="height:140px;line-height:36px;margin-top:10px;display:none;text-align:center;" id="addimgs1">
                                                <div style="height:36px;line-height:36px;">
                                                    网址1&nbsp;&nbsp;
                                                    <input name="upimg" type="text" id="upimg1" size="40" value="http://"></div>
                                                <div style="height:36px;line-height:36px;">
                                                    网址2&nbsp;&nbsp;
                                                    <input name="upimg" type="text" id="upimg2" size="40" value="http://"></div>
                                                <div style="height:36px;line-height:36px;">
                                                    网址3&nbsp;&nbsp;
                                                    <input name="upimg" type="text" id="upimg3" size="40" value="http://"></div>
                                                <div style="width:100px;">
                                                    <a class="red_enter" onclick="addaddress()">
                                                        <span>上传图片</span>
                                                    </a>
                                                </div>
                                            </div>

                                            <iframe frameborder="0" scrolling="no" hspace="0" src="__IMAGES__/bbs/FileLoad.htm" height="152" width="316" id="addimgs2"></iframe>
                                        </div>
                                    </div>
                                </div>
                                <!--添加链接层-->

                                <div class="dis_fc_bq fc_img" style="height:70px;left:86px;display:none;" id="addlink">
                                    <div class="dis_fcgban" style="padding-left:372px;*padding-left:364px;">
                                        <img src="__IMAGES__/bbs/dis_fc_gban.gif" border="0" style="cursor:pointer;" onclick="closel()"></div>
                                    <div style="width:376px; margin:0 auto;">
                                        <div class="dis_fc_table_p">
                                            <p style="padding-left:10px;  margin-top: 14px;*margin-top:7px;">请输入链接地址</p>
                                            <table width="356" border="0" align="center">
                                                <tbody>
                                                    <tr>
                                                        <td height="30">
                                                            <input name="link" type="text" id="link" size="38" value="http://"></td>
                                                        <td>
                                                            <div>
                                                                <a class="red_enter">
                                                                    <span id="linkid">确&nbsp;定</span>
                                                                </a>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>

                                <!--表情层结束-->
                                <textarea id="content" name="content" style="width:650px; border:1px solid #dddddd; padding:15px; padding-top:10px; line-height:24px;"></textarea>
                            </li>
                            <li>
                                精华帖的奖励：
                                <img src="__IMAGES__/bbs/pink_red-j.gif" width="21" height="20">
                                ：奖
                                <span class="color4">500,000</span>
                                金蛋&nbsp;
                                <img src="__IMAGES__/bbs/pink_green-j.gif">
                                ：奖
                                <span class="color4">300,000</span>
                                金蛋&nbsp;
                                <img src="__IMAGES__/bbs/pink_blue-j.gif">
                                ：奖
                                <span class="color4">100,000</span>
                                金蛋&nbsp;
                                <a href="http://www.pceggs.com/nbbs/bbsPost.aspx?PostID=242289" class="linkgray_a1">详细说明</a>
                            </li>
                        </ul>
                        <p class="post-ft">

                            <a class="red_enter" onclick="submitvaluet()">
                                <span>写好了，发布</span>
                            </a>

                        </p>

                    </div>

                </div>

                <div id="side-wrap">
                    <div class="list-board">
                        <h1 style="text-align:center; cursor:pointer;" onclick="document.location.href='/nbbs/bbsMain.aspx?topicid=3'">02#购物分享</h1>
                        <div class="board-img">
                            <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3">
                                <img src="__IMAGES__/bbs/gwfx.jpg"></a>
                        </div>
                        <dl class="board-info">
                            <dt class="color6">版主：</dt>
                            <dd>
                                <p>
                                    <a target="_blank" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=1003">客服1003</a>
                                </p>
                                <p>
                                    <a target="_blank" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=1005">客服1005</a>
                                </p>
                                <p>
                                    <a target="_blank" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=1006">客服1006</a>
                                </p>
                            </dd>
                            <dt class="color6">主题：</dt>
                            <dd>购物赚蛋交流，团购宝贝展示，购物分享</dd>
                        </dl>

                    </div>

                    <div class="list-side">

                        <h3 class="list-side-hd">购物返利低价特卖</h3>
                        <div class="tb_bbs_zs" style="padding-top:6px;">

                            <div class="tb_bbs_zs tb_bbs_zsss">

                                <div class="tb_bbs_img">
                                    <div class="jyg_lj">
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=36495534244&amp;uk=5851765423&amp;np=88" target="_blank">三星note3手机壳硅胶视窗n9</a>
                                    </div>
                                    <div>
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=36495534244&amp;uk=5851765423&amp;np=88" target="_blank">
                                            <img src="__IMAGES__/bbs/T1y5IXFbNeXXXXXXXX_!!0-item_pic.jpg_m.jpg" width="160"></a>
                                    </div>
                                    <div class="jyg_xx">
                                        <div class="jyg_xx_jg">
                                            ¥ <strong>12</strong>
                                            <small>.90</small>
                                        </div>

                                        <div class="jyg_xx_jgsc">
                                            <div class="jyg_xx_jgsc_top">1.5折</div>
                                            <div class="jyg_xx_jgsc_bt">88.00</div>
                                        </div>

                                        <div class="jyg_xx_an" style="padding-top:6px;*padding-top:4px;">
                                            <span style="width:44px; height:18px;line-height:18px; background-color:#68b93a; padding:3px 4px;color:White;  margin-top:10px; _margin-top:12px;  font-size:12px; vertical-align:bottom;">有返利</span>
                                        </div>

                                    </div>
                                </div>

                            </div>

                            <div class="tb_bbs_zs tb_bbs_zsss">

                                <div class="tb_bbs_img">
                                    <div class="jyg_lj">
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=14340414823&amp;uk=8772023202&amp;np=4.90" target="_blank">侨丰11丝加厚真空袋压缩袋满</a>
                                    </div>
                                    <div>
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=14340414823&amp;uk=8772023202&amp;np=4.90" target="_blank">
                                            <img src="__IMAGES__/bbs/T1Q1pnXwXgXXXXXXXX_!!0-item_pic.jpg_m.jpg" width="160"></a>
                                    </div>
                                    <div class="jyg_xx">
                                        <div class="jyg_xx_jg">
                                            ¥
                                            <strong>2</strong>
                                            <small>.70</small>
                                        </div>

                                        <div class="jyg_xx_jgsc">
                                            <div class="jyg_xx_jgsc_top">5.5折</div>
                                            <div class="jyg_xx_jgsc_bt">4.90</div>
                                        </div>

                                        <div class="jyg_xx_an" style="padding-top:6px;*padding-top:4px;">
                                            <span style="width:44px; height:18px;line-height:18px; background-color:#68b93a; padding:3px 4px;color:White;  margin-top:10px; _margin-top:12px;  font-size:12px; vertical-align:bottom;">有返利</span>
                                        </div>

                                    </div>
                                </div>

                            </div>

                            <div class="tb_bbs_zs tb_bbs_zsss">

                                <div class="tb_bbs_img">
                                    <div class="jyg_lj">
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=37889984147&amp;uk=3685737455&amp;np=50" target="_blank">包臀长裙女半身裙包臀裙长裙</a>
                                    </div>
                                    <div>
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=37889984147&amp;uk=3685737455&amp;np=50" target="_blank">
                                            <img src="__IMAGES__/bbs/T18mB3Fy0gXXXXXXXX_!!0-item_pic.jpg_m.jpg" width="160"></a>
                                    </div>
                                    <div class="jyg_xx">
                                        <div class="jyg_xx_jg">
                                            ¥
                                            <strong>9</strong>
                                            <small>.90</small>
                                        </div>

                                        <div class="jyg_xx_jgsc">
                                            <div class="jyg_xx_jgsc_top">2折</div>
                                            <div class="jyg_xx_jgsc_bt">50.00</div>
                                        </div>

                                        <div class="jyg_xx_an" style="padding-top:6px;*padding-top:4px;">
                                            <span style="width:44px; height:18px;line-height:18px; background-color:#68b93a; padding:3px 4px;color:White;  margin-top:10px; _margin-top:12px;  font-size:12px; vertical-align:bottom;">有返利</span>
                                        </div>

                                    </div>
                                </div>

                            </div>

                            <div class="tb_bbs_zs tb_bbs_zsss">

                                <div class="tb_bbs_img">
                                    <div class="jyg_lj">
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=38224897018&amp;uk=6138403710&amp;np=328" target="_blank">米菲大号女双肩包糖果色小清</a>
                                    </div>
                                    <div>
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=38224897018&amp;uk=6138403710&amp;np=328" target="_blank">
                                            <img src="__IMAGES__/bbs/T1Ma7LFPVXXXXXXXXX_!!0-item_pic.jpg_m.jpg" width="160"></a>
                                    </div>
                                    <div class="jyg_xx">
                                        <div class="jyg_xx_jg">
                                            ¥
                                            <strong>39</strong>
                                            <small>.00</small>
                                        </div>

                                        <div class="jyg_xx_jgsc">
                                            <div class="jyg_xx_jgsc_top">1.2折</div>
                                            <div class="jyg_xx_jgsc_bt">328.00</div>
                                        </div>

                                        <div class="jyg_xx_an" style="padding-top:6px;*padding-top:4px;">
                                            <span style="width:44px; height:18px;line-height:18px; background-color:#68b93a; padding:3px 4px;color:White;  margin-top:10px; _margin-top:12px;  font-size:12px; vertical-align:bottom;">有返利</span>
                                        </div>

                                    </div>
                                </div>

                            </div>

                            <div class="tb_bbs_zs tb_bbs_zsss">

                                <div class="tb_bbs_img">
                                    <div class="jyg_lj">
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=37096587605&amp;uk=8740336291&amp;np=19.80" target="_blank">赛恋春夏款防走光安全裤莫代</a>
                                    </div>
                                    <div>
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=37096587605&amp;uk=8740336291&amp;np=19.80" target="_blank">
                                            <img src="__IMAGES__/bbs/T1neBRFulcXXXXXXXX_!!0-item_pic.jpg_m.jpg" width="160"></a>
                                    </div>
                                    <div class="jyg_xx">
                                        <div class="jyg_xx_jg">
                                            ¥
                                            <strong>6</strong>
                                            <small>.80</small>
                                        </div>

                                        <div class="jyg_xx_jgsc">
                                            <div class="jyg_xx_jgsc_top">3.4折</div>
                                            <div class="jyg_xx_jgsc_bt">19.80</div>
                                        </div>

                                        <div class="jyg_xx_an" style="padding-top:6px;*padding-top:4px;">
                                            <span style="width:44px; height:18px;line-height:18px; background-color:#68b93a; padding:3px 4px;color:White;  margin-top:10px; _margin-top:12px;  font-size:12px; vertical-align:bottom;">有返利</span>
                                        </div>

                                    </div>
                                </div>

                            </div>

                            <div class="tb_bbs_zs tb_bbs_zsss">

                                <div class="tb_bbs_img">
                                    <div class="jyg_lj">
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=9943425508&amp;uk=7449453968&amp;np=12.80" target="_blank">洗衣机罩防水防晒洗衣机套</a>
                                    </div>
                                    <div>
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=9943425508&amp;uk=7449453968&amp;np=12.80" target="_blank">
                                            <img src="__IMAGES__/bbs/T1g0y3XwBhXXXXXXXX_!!0-item_pic.jpg_m.jpg" width="160"></a>
                                    </div>
                                    <div class="jyg_xx">
                                        <div class="jyg_xx_jg">
                                            ¥
                                            <strong>12</strong>
                                            <small>.80</small>
                                        </div>

                                        <div class="jyg_xx_an" style="padding-top:6px;*padding-top:4px;">
                                            <span style="width:44px; height:18px;line-height:18px; background-color:#68b93a; padding:3px 4px;color:White;  margin-top:10px; _margin-top:12px;  font-size:12px; vertical-align:bottom;">有返利</span>
                                        </div>

                                    </div>
                                </div>

                            </div>

                            <div class="tb_bbs_zs tb_bbs_zsss">

                                <div class="tb_bbs_img">
                                    <div class="jyg_lj">
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=17675535737&amp;uk=7597476571&amp;np=88" target="_blank">清仓冬季正品派克魔术贴保暖</a>
                                    </div>
                                    <div>
                                        <a href="http://www.pceggs.com/newtb/NewTBWhatBuy.aspx?u=3S1873372&amp;id=17675535737&amp;uk=7597476571&amp;np=88" target="_blank">
                                            <img src="__IMAGES__/bbs/T1oxPVXflmXXbaP2Ta_090826.jpg_m.jpg" width="160"></a>
                                    </div>
                                    <div class="jyg_xx">
                                        <div class="jyg_xx_jg">
                                            ¥
                                            <strong>28</strong>
                                            <small>.80</small>
                                        </div>

                                        <div class="jyg_xx_jgsc">
                                            <div class="jyg_xx_jgsc_top">3.3折</div>
                                            <div class="jyg_xx_jgsc_bt">88.00</div>
                                        </div>

                                        <div class="jyg_xx_an" style="padding-top:6px;*padding-top:4px;">
                                            <span style="width:44px; height:18px;line-height:18px; background-color:#68b93a; padding:3px 4px;color:White;  margin-top:10px; _margin-top:12px;  font-size:12px; vertical-align:bottom;">有返利</span>
                                        </div>

                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>

                    <div class="list-side" style="display:none">
                        <h3 class="list-side-hd">管理员推荐</h3>
                        <div class="glytj_img">
                            <img src="__IMAGES__/bbs/iphone.jpg"></div>
                        <div class="glytj_word_m">
                            <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;CurrentPageIndex=1#" style=" color:#0657b2">新新兑换的 Iphone4S</a>
                        </div>
                        <div class="glytj_word_l">
                            <p>
                                <span class="dot_tb">&nbsp;</span>
                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;CurrentPageIndex=1#" class="linkblack_a1">第一次团购 我的小P和小C</a>
                            </p>
                            <p>
                                <span class="dot_tb">&nbsp;</span>
                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;CurrentPageIndex=1#" class="linkblack_a1">第一次团购 我的小P和小C</a>
                            </p>
                            <p>
                                <span class="dot_tb">&nbsp;</span>
                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;CurrentPageIndex=1#" class="linkblack_a1">第一次团购 我的小P和小C</a>
                            </p>
                            <p>
                                <span class="dot_tb">&nbsp;</span>
                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;CurrentPageIndex=1#" class="linkblack_a1">第一次团购 我的小P和小C</a>
                            </p>
                            <p>
                                <span class="dot_tb">&nbsp;</span>
                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;CurrentPageIndex=1#" class="linkblack_a1">第一次团购 我的小P和小C</a>
                            </p>
                            <p>
                                <span class="dot_tb">&nbsp;</span>
                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;CurrentPageIndex=1#" class="linkblack_a1">第一次团购 我的小P和小C</a>
                            </p>
                            <p>
                                <span class="dot_tb">&nbsp;</span>
                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;CurrentPageIndex=1#" class="linkblack_a1">第一次团购 我的小P和小C</a>
                            </p>
                            <p>
                                <span class="dot_tb">&nbsp;</span>
                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;CurrentPageIndex=1#" class="linkblack_a1">第一次团购 我的小P和小C</a>
                            </p>
                            <p>
                                <span class="dot_tb">&nbsp;</span>
                                <a href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=3&amp;CurrentPageIndex=1#" class="linkblack_a1">第一次团购 我的小P和小C</a>
                            </p>
                        </div>

                    </div>

                </div>
            </div>
        </form>
    </div>
    <!-- InstanceEndEditable -->
</div>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="__CSS__/footer.css" />
</head>

<div class="footer">
<p>关于比蛋 | 服务条款 | 客服中心 | 新手帮助</p>
<p>
Copyright © 2009 - 2012 dingdong.com dingdong.net 深ICP备12055565号 ICP:深B2-20120226
</p>
<p>比蛋-深圳网络有限公司</p>
</div>
</body>
<!-- InstanceEnd --></html>