<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>幸运28-专业的广告游戏平台</title>
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
  <style type="text/css">.navibar_<?php echo ($PAGE_CURID); ?>{color: #ff0000; font-weight:bold;}</style>
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

    <style type="text/css">.dynamic_msg_r a {color: #F5A300;}</style>
    <head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <style type="text/css">
      .game_tab{width: 100%; height: 22px; margin: 5px;}
      .title_game {font-size: 14px;text-align: left;padding-top: 0px;padding-left: 3px;padding-right: 5px;width: 950px;height: 27px;font-weight: bold;overflow: hidden;}
      .line{width: 100%;height: 8px;margin-bottom: 5px;}
    </style>
</head>
<div class="game_tab">
  <div style="width:970px">
    <div class="title_game" style="float:left; width:610px;">
      <a href="<?php echo U('/game');?>">
        <img src="/bidan/bieggs/Public/Images/game/pub/ico_6.gif" width="98" height="27" border="0"></a>
      <a href="<?php echo U('/game/pg310');?>">
        <img src="/bidan/bieggs/Public/Images/game/pub/ico_26.gif" width="98" height="27" border="0"></a>
      <a href="<?php echo U('/game/pgstar');?>">
        <img src="/bidan/bieggs/Public/Images/game/pub/ico_29.gif" width="98" height="27" border="0"></a>
    </div>
    <div style=" float:right; width:330px; height:25px;vertical-align:middle; line-height:25px;text-align:right">
      <a href="/nbbs/bbsPost.aspx?PostID=3864534&amp;topicid=4&amp;ret=1" target="_blank" style="color:#3f3f3f;">幸运28启用北京快乐8第三方开奖数据&gt;&gt;&gt;</a>
    </div>
  </div>
</div>
<!--two ways show tab-->
<!-- <div class="line"
  <?php if($GAME_TAB == 1): ?>style='background:url("__IMAGES__/game/orange-line.gif"); x-repeat;'
  <?php elseif($GAME_TAB == 2): ?>
    style='background:url("__IMAGES__/game/green-line.gif"); x-repeat;'
  <?php else: ?>
    style='background:url("__IMAGES__/game/red-line.gif"); x-repeat;'<?php endif; ?>
></div> -->
<?php  if (3 == $GAME_TAB) { $tab_item = "red-line.gif"; } elseif (2 == $GAME_TAB) { $tab_item = "green-line.gif"; } else{ $tab_item = "orange-line.gif"; } ?>
<div class="line" style='background:url("__IMAGES__/game/<?php echo ($tab_item); ?>"); x-repeat;'></div>
    <head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<script type="text/javascript" src="__JS__/Jquery/jquery-1.6.2.min.js"></script>
<script type="text/javascript" src="__JS__/game/showMsg.js"></script>
</head>
<div id="msgdiv" style="position:absolute;display:none;"></div>
<div id="overdiv" style="position:absolute;display:none;"></div>
<table width="968" border="0" align="center" cellpadding="0" cellspacing="0" style="background-color:#FCF8DA;clear:both;">
    <input type="hidden" id="soundshow" name="soundshow" value="2">
    <input type="hidden" id="reloadshow" name="reloadshow" value="">
    <tbody>
        <tr>
            <td width="50%" height="24" align="left" valign="middle">
                <a href="<?php echo U('/mybets/my28');?>" target="_parent" class="abt12_1">我的投注</a>
                <span class="wh12">|</span>
                <a href="<?php echo U('/mybets/trend28');?>" target="_parent" class="abt12_2">幸运28走势图</a>
                <span class="wh12">
                    <span class="wh12">|</span>
                </span>
                <a href="<?php echo U('/mybets/intr28');?>" class="abt12_3">幸运28介绍</a>
                <span class="wh12">
                    <span class="wh12">|</span>
                </span>
                <a href="<?php echo U('/mybets/nrb28');?>" class="abt12_4"><img src="/bidan/bieggs/Public/Images/game/new28.gif" alt="">&nbsp牛人榜</a>
            </td>
            <td width="50%" align="right" valign="middle">
                <a href="javascript:ShowMsgo.show('<?php echo U('/mybets/geteggs.html');?>',515,546)" class="abt12_5">领取救济金</a>
                <span class="wh12">|</span>
                <a href="<?php echo U('/mybets/m28edit');?>" target="_parent" class="abt12_6">投注模式编辑</a>
                <span class="wh12">|</span>
                <a href="<?php echo U('/mybets/auto28');?>" target="_parent" class="abt12_7">自动投注</a>
            </td>
        </tr>
    </tbody>
</table>
<script type="text/javascript">
    //去除IE6背景缓存
    document.execCommand("BackgroundImageCache", false, true);
    function addfavorite(a, b) {
        if (document.all) {
            window.external.addFavorite('http://www.pceggs.com' + "", "PC蛋蛋-专业体验营销平台");
        } else if (window.sidebar) {
            window.sidebar.addPanel("PC蛋蛋-专业体验营销平台", 'http://www.pceggs.com' + "", "");
        }
    }
    function doSomething(evt) {
        var e = (evt) ? evt : window.event; //判断浏览器的类型，在基于ie内核的浏览器中的使用cancelBubble
        if (window.event) {
            e.cancelBubble = true;
        } else {
            //e.preventDefault(); //在基于firefox内核的浏览器中支持做法stopPropagation
            e.stopPropagation();
        }
    }
    function answerqenstion() {
        ShowMsgo.show("/activity/201209/dt/dtfc/fuceng/answer.aspx", 740, 610);
    }
    function closedd() {

        ShowMsgo.ok();
    }
    function closelinqu() {
        ShowMsgo.cancel();
        window.location.reload(true);
    }
    function aaddgame() {
        ShowMsgo.show("/Gain/new_guide_game.aspx", 658, 390);
    }
    function aaddgg() {
        ShowMsgo.show("/Gain/new_guide_gg.aspx", 658, 390);
    }
    var isgain = "0";
    var autoopen = "0";
    var registdays = "2675";
    var userid = "1873372";
 var  tohref=window.location.href;
 if(tohref.indexOf("bbsPost.aspx")>-1||tohref.indexOf("bbsMain.aspx")>-1||tohref.indexOf("ShowList.aspx")>-1||tohref.indexOf("ShowInfo.aspx")>-1||tohref.indexOf("duobao_index.aspx")>-1||tohref.indexOf("duobao_next.aspx")>-1||tohref.indexOf("duobao_historylist.aspx")>-1||tohref.indexOf("bbsPostShow.aspx")>-1 ){
     $(window).bind("scroll", function () {
         var top_top = $(document).scrollTop(); //卷上去的高度
         if (top_top > 0) {
             $("#topNav1").css("display", "");
         } else {
             $("#topNav1").css("display", "none");
         }
     })
 }
</script>

<style>
.abt12_<?php echo ($MENU_TAB); ?>{color: #ff0000; font-weight: bold;}
</style>
    <div style="margin:2px auto 10px auto; width:968px; height:30px; line-height :25px">
      <div style="width:20%; float:left; line-height:30px; height:30px; padding-left:5px;">
        第
        <span class="llid" style="color:#ff0000;"></span>
        期开奖结果:
        <img src="" width="25" height="25"></div>
    </div>

    <table width="968" border="0" cellpadding="0" cellspacing="1" bgcolor="#FFB91F" align="center" style="color: black; margin-top:5px;">
      <tbody>
        <tr align="center" class="sz_top">
          <td width="90" height="26" bgcolor="#FFFDF8" class="qihao">统计数据</td>
          <td height="26" colspan="6" bgcolor="#FFFDF8" class="qihao">
            总期数：
            <span>200</span>
          </td>
          <td height="26" colspan="33" bgcolor="#FFFDF8" style="text-align: right; padding-right: 5px">
            近&nbsp;
            <input name="IssueValue" type="text" id="IssueValue" style="color: black;  width:50px" bgcolor="#FFFFFF" value="200" size="3" onkeyup="if(event.keyCode !=37 &amp;&amp; event.keyCode != 39) value=value.replace(/\D/g,'');Inchange();">
            &nbsp;期
                &nbsp;
            <input type="submit" name="ChangeIssue" value="搜索" id="ChangeIssue"></td>
        </tr>
        <tr align="center" class="sz_top">
          <td width="90" height="26" bgcolor="#FFFDF8" class="qihao">标准间隔</td>

          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>1000</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>333</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>166</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>100</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>66</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>48</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">36</td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>28</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>22</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>18</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>16</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>15</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>14</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>13</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>13</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>14</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>15</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>16</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>18</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>22</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>28</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>36</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">48</td>
          <td width="28" height="26" bgcolor="#FFFDF8">66</td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>100</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>166</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>333</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>1000</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">1</td>
          <td width="20" height="26" bgcolor="#FFFDF8">1</td>
          <td width="20" height="26" bgcolor="#FFFDF8">1</td>
          <td width="20" height="26" bgcolor="#FFFDF8">1</td>
          <td width="20" height="26" bgcolor="#FFFDF8">1</td>
          <td width="20" bgcolor="#FFFDF8">1</td>
          <td width="20" height="26" bgcolor="#FFFDF8">&nbsp;</td>
          <td width="20" bgcolor="#FFFDF8">&nbsp;</td>
          <td width="20" height="26" bgcolor="#FFFDF8"></td>
          <td width="20" height="26" bgcolor="#FFFDF8"></td>
          <td width="20" height="26" bgcolor="#FFFDF8"></td>
        </tr>

        <tr align="center" class="sz_top">
          <td width="90" height="26" bgcolor="#FFFDF8" class="qihao">当前间隔</td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>225</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>1000</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>486</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>47</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>89</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>26</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>30</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>3</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>10</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>18</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>1</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>7</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>28</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>2</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>4</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>8</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>11</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>0</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>20</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>6</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>54</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>62</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>81</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>5</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>116</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>252</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>79</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>1000</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>0</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>1</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>0</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>3</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>0</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>1</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">&nbsp;</td>
          <td width="20" height="26" bgcolor="#FFFDF8">&nbsp;</td>
          <td width="20" height="26" bgcolor="#FFFDF8"></td>
          <td width="20" height="26" bgcolor="#FFFDF8"></td>
          <td width="20" height="26" bgcolor="#FFFDF8"></td>

        </tr>

        <tr align="center" class="sz_top">
          <td width="90" height="26" bgcolor="#FFFDF8" class="qihao">标准次数</td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>0</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>1</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>1</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>2</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>3</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>4</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>6</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>7</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>9</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>11</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>13</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>13</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>14</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>15</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>15</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>14</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>13</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>13</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>11</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>9</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>7</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>6</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>4</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>3</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>2</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>1</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>1</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>0</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>100</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>100</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>112</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>88</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>100</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>100</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">&nbsp;</td>
          <td width="20" height="26" bgcolor="#FFFDF8">&nbsp;</td>
          <td width="20" height="26" bgcolor="#FFFDF8"></td>
          <td width="20" height="26" bgcolor="#FFFDF8"></td>
          <td width="20" height="26" bgcolor="#FFFDF8"></td>
        </tr>

        <tr align="center" class="sz_top">
          <td width="90" height="26" bgcolor="#FFFDF8" class="qihao">实际次数</td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>0</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>0</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>0</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>1</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>4</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>3</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>3</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>4</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>13</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>17</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>16</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>19</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>13</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>10</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>20</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>11</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>12</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>13</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>13</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>7</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>4</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>4</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>4</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>5</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>2</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>0</span>
          </td>
          <td width="28" height="26" bgcolor="#FFFDF8">
            <span>2</span>
          </td>
          <td width="28" height="26" bgcolor="#FFCCCC">
            <span>0</span>
          </td>
          <td width="20" height="26" bgcolor="#FFCCCC">
            <span>94</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>106</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>114</span>
          </td>
          <td width="20" height="26" bgcolor="#FFCCCC">
            <span>86</span>
          </td>
          <td width="20" height="26" bgcolor="#FFCCCC">
            <span>97</span>
          </td>
          <td width="20" height="26" bgcolor="#FFFDF8">
            <span>103</span>
          </td>

          <td height="26" colspan="2" bgcolor="#FFFDF8">尾数</td>
          <td height="26" colspan="3" bgcolor="#FFFDF8">余数</td>
        </tr>

        <tr align="center" background="/img/pub/xy28_bg.gif">
          <td height="26" class="qihao" background="/img/pub/xy28_bg.gif">期&nbsp;&nbsp;号</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">0</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">1</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">2</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">3</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">4</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">5</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">6</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">7</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">8</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">9</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">10</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">11</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">12</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">13</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">14</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">15</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">16</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">17</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">18</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">19</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">20</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">21</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">22</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">23</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">24</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">25</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">26</td>
          <td width="28" height="26" background="/img/pub/xy28_bg.gif">27</td>
          <td width="20" height="26" background="/img/pub/xy28_bg.gif" class="qihao">单</td>
          <td width="20" height="26" background="/img/pub/xy28_bg.gif" class="qihao">双</td>
          <td width="20" height="26" background="/img/pub/xy28_bg.gif" class="qihao">中</td>
          <td width="20" height="26" background="/img/pub/xy28_bg.gif" class="qihao">边</td>
          <td width="20" height="26" background="/img/pub/xy28_bg.gif" class="qihao">大</td>
          <td width="20" height="26" background="/img/pub/xy28_bg.gif" class="qihao">小</td>
          <td width="20" height="26" background="/img/pub/xy28_bg.gif" class="qihao">小</td>
          <td width="20" height="26" background="/img/pub/xy28_bg.gif" class="qihao">大</td>
          <td width="20" height="26" background="/img/pub/xy28_bg.gif">/3</td>
          <td width="20" height="26" background="/img/pub/xy28_bg.gif">/4</td>
          <td width="20" height="26" background="/img/pub/xy28_bg.gif">/5</td>
        </tr>

        <tr align="center">
          <td height="18" bgcolor="#FFDF9C" class="qihao">640397</td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFFFF"></td>
          <td width="28" height="18" bgcolor="#FFFFFF"></td>
          <td width="28" height="18" bgcolor="#FFFFFF"></td>
          <td width="28" height="18" bgcolor="#FFFFFF"></td>
          <td width="28" height="18" bgcolor="#FFFFFF"></td>
          <td width="28" height="18" bgcolor="#FFFFFF"></td>
          <td width="28" height="18" bgcolor="#FFFFFF"></td>
          <td width="28" height="18" bgcolor="#FFFFFF" class="zhong">17</td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="28" height="18" bgcolor="#FFFAC7"></td>
          <td width="20" height="18" bgcolor="#FFFFFF" class="dan">单</td>
          <td width="20" height="18" bgcolor="#FFFFFF"></td>
          <td width="20" height="18" bgcolor="#FFFFFF" class="zhong">中</td>
          <td width="20" height="18" bgcolor="#FFFFFF"></td>
          <td width="20" height="18" bgcolor="#FFFFFF" class="da">大</td>
          <td width="20" height="18" bgcolor="#FFFFFF"></td>
          <td width="20" height="18" bgcolor="#FFFFFF"></td>
          <td width="20" height="18" bgcolor="#FFFFFF" class="dz">7</td>
          <td width="20" height="18" bgcolor="#FFFFFF">2</td>
          <td width="20" height="18" bgcolor="#FFFFFF">1</td>
          <td width="20" height="18" bgcolor="#FFFFFF">2</td>
        </tr>
        <tr class="sz_top">
          <td height="42" colspan="40" bgcolor="#FFFFFF" class="qihao">
            <span style="padding-left:50px">注：</span>
            标准次数是指根据概率应该出现的次数，实际次数中的红色表示实际上开奖的次数比标准次数小，也就是少开了，白色表示比标准次数大，也就是多开了。
            <br>
            <span style="padding-left:78px; font-size:12px; color:Black ">期号开奖明细最多显示最近200期，次数统计可显示最近2000期数据。</span>
          </td>
        </tr>

      </tbody>
    </table>

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
</html>