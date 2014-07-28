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

    <div class="content_middle" style="height:auto">
      <!-- 今日  -->
      <div style=" width:304px; border:1px solid #FFB91F; margin-left:8px;*margin-left:8px;  float:left; margin-top:8px;">
        <table width="304" border="0" cellpadding="0" cellspacing="0" bgcolor="#FFB91F" align="center" style="color:Black;">
          <tbody>
            <tr align="center">
              <td colspan="3" background="__IMAGES__/game/mybets/jr28.gif" style="height: 57px">&nbsp;</td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td width="12%" height="28" bgcolor="#F8F8F8">
                <span style="height: 28px"> <strong>排名</strong>
                </span>
              </td>
              <td width="35%" height="28" bgcolor="#FFFFFF"> <strong>蛋蛋ID</strong>
              </td>
              <td width="53%" height="28" bgcolor="#F8F8F8">
                <span style="height: 28px">
                  <strong>赢蛋总数</strong>
                </span>
              </td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="__IMAGES__/game/mybets/n1.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=17121809" target="_blank" class="a0">
                  17121809
                  <img src="__IMAGES__/game/mybets/nb1.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                116,937,347
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n2.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=6691795" target="_blank" class="a0">
                  6691795
                  <img src="__IMAGES__/game/mybets/nb2.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                113,892,380
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n3.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=17252737" target="_blank" class="a0">
                  17252737
                  <img src="/img/pub/nb3.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                103,930,405
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">4</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17914856" target="_blank" class="a0">17914856</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                84,964,745
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">5</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16597748" target="_blank" class="a0">16597748</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                76,699,600
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">6</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=6432668" target="_blank" class="a0">6432668</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                76,529,018
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">7</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16086152" target="_blank" class="a0">16086152</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                75,745,560
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">8</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=14200966" target="_blank" class="a0">14200966</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                67,574,640
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">9</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=8850531" target="_blank" class="a0">8850531</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                57,737,820
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">10</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12691201" target="_blank" class="a0">12691201</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                49,590,640
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">11</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12923390" target="_blank" class="a0">12923390</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                45,969,398
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">12</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17173006" target="_blank" class="a0">17173006</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                36,972,093
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">13</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=14859919" target="_blank" class="a0">14859919</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                31,355,300
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">14</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16599291" target="_blank" class="a0">16599291</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                29,767,497
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">15</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=3443300" target="_blank" class="a0">3443300</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                27,638,403
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">16</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12836968" target="_blank" class="a0">12836968</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                27,576,804
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">17</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=6889828" target="_blank" class="a0">6889828</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                26,633,481
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">18</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17883275" target="_blank" class="a0">17883275</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                23,645,517
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">19</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16984861" target="_blank" class="a0">16984861</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                22,991,347
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">20</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=4821368" target="_blank" class="a0">4821368</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                21,803,975
                <img src="/img/pub/egg.gif"></td>
            </tr>

          </tbody>
        </table>
      </div>
      <!-- 昨日  -->
      <div style=" width:304px; border:1px solid #FFB91F; margin-left:8px; float:left; margin-top:8px;">
        <table width="304" border="0" cellpadding="0" cellspacing="0" bgcolor="#FFB91F" align="center" style="color:Black;">
          <tbody>
            <tr align="center">
              <td colspan="3" background="__IMAGES__/game/mybets/zr28.gif" style="height: 57px">&nbsp;</td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td width="12%" height="28" bgcolor="#F8F8F8">
                <span style="height: 28px">
                  <strong>排名</strong>
                </span>
              </td>
              <td width="35%" height="28" bgcolor="#FFFFFF">
                <strong>蛋蛋ID</strong>
              </td>
              <td width="53%" height="28" bgcolor="#F8F8F8">
                <span style="height: 28px">
                  <strong>赢蛋总数</strong>
                </span>
              </td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="__IMAGES__/game/mybets/n1.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=16086152" target="_blank" class="a0">
                  16086152
                  <img src="__IMAGES__/game/mybets/nb1.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                659,654,593
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n2.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=12836968" target="_blank" class="a0">
                  12836968
                  <img src="/img/pub/nb2.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                607,840,766
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n3.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=12691201" target="_blank" class="a0">
                  12691201
                  <img src="/img/pub/nb3.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                541,326,984
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">4</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16597748" target="_blank" class="a0">16597748</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                483,713,400
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">5</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12428178" target="_blank" class="a0">12428178</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                404,608,630
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">6</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=13013215" target="_blank" class="a0">13013215</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                399,801,672
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">7</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17252737" target="_blank" class="a0">17252737</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                293,547,630
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">8</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=9113882" target="_blank" class="a0">9113882</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                265,224,000
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">9</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=14200966" target="_blank" class="a0">14200966</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                254,534,119
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">10</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17299171" target="_blank" class="a0">17299171</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                219,680,200
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">11</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16984861" target="_blank" class="a0">16984861</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                210,458,710
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">12</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12249703" target="_blank" class="a0">12249703</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                202,717,200
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">13</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12923390" target="_blank" class="a0">12923390</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                180,869,466
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">14</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=8658564" target="_blank" class="a0">8658564</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                179,441,578
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">15</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16603292" target="_blank" class="a0">16603292</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                177,243,563
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">16</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=7308055" target="_blank" class="a0">7308055</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                173,405,241
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">17</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17356275" target="_blank" class="a0">17356275</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                160,049,004
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">18</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=14923641" target="_blank" class="a0">14923641</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                149,534,646
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">19</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=11748367" target="_blank" class="a0">11748367</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                145,056,050
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">20</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17085775" target="_blank" class="a0">17085775</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                143,795,573
                <img src="/img/pub/egg.gif"></td>
            </tr>

          </tbody>
        </table>
      </div>
      <!-- 本周  -->
      <div style=" width:304px; border:1px solid #FFB91F; margin-left:8px; float:left; margin-top:8px;">
        <table width="304" border="0" cellpadding="0" cellspacing="0" bgcolor="#FFB91F" align="center" style="color:Black;">
          <tbody>
            <tr align="center">
              <td colspan="3" background="__IMAGES__/game/mybets/bz28.gif" style="height:57px">&nbsp;</td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td width="12%" height="28" bgcolor="#F8F8F8">
                <span style="height: 28px">
                  <strong>排名</strong>
                </span>
              </td>
              <td width="35%" height="28" bgcolor="#FFFFFF">
                <strong>蛋蛋ID</strong>
              </td>
              <td width="53%" height="28" bgcolor="#F8F8F8">
                <span style="height: 28px">
                  <strong>赢蛋总数</strong>
                </span>
              </td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="__IMAGES__/game/mybets/n1.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=17121809" target="_blank" class="a0">
                  17121809
                  <img src="/img/pub/nb1.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                116,937,347
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n2.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=6691795" target="_blank" class="a0">
                  6691795
                  <img src="/img/pub/nb2.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                113,892,380
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n3.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=17252737" target="_blank" class="a0">
                  17252737
                  <img src="/img/pub/nb3.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                103,930,405
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">4</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17914856" target="_blank" class="a0">17914856</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                84,964,745
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">5</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16597748" target="_blank" class="a0">16597748</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                76,699,600
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">6</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=6432668" target="_blank" class="a0">6432668</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                76,529,018
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">7</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16086152" target="_blank" class="a0">16086152</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                75,745,560
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">8</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=14200966" target="_blank" class="a0">14200966</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                67,574,640
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">9</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=8850531" target="_blank" class="a0">8850531</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                57,737,820
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">10</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12691201" target="_blank" class="a0">12691201</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                49,590,640
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">11</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12923390" target="_blank" class="a0">12923390</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                45,969,398
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">12</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17173006" target="_blank" class="a0">17173006</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                36,972,093
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">13</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=14859919" target="_blank" class="a0">14859919</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                31,355,300
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">14</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16599291" target="_blank" class="a0">16599291</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                29,767,497
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">15</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=3443300" target="_blank" class="a0">3443300</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                27,638,403
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">16</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12836968" target="_blank" class="a0">12836968</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                27,576,804
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">17</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=6889828" target="_blank" class="a0">6889828</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                26,633,481
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">18</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17883275" target="_blank" class="a0">17883275</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                23,645,517
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">19</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16984861" target="_blank" class="a0">16984861</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                22,991,347
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">20</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=4821368" target="_blank" class="a0">4821368</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                21,803,975
                <img src="/img/pub/egg.gif"></td>
            </tr>

          </tbody>
        </table>
      </div>
      <!-- 上周  -->
      <div style=" width:304px; border:1px solid #FFB91F; margin-left:8px;*margin-left:8px;   float:left; margin-top:8px;">
        <table width="304" border="0" cellpadding="0" cellspacing="0" bgcolor="#FFB91F" align="center" style="color:Black;">
          <tbody>
            <tr align="center">
              <td colspan="3" background="__IMAGES__/game/mybets/sz28.gif" style="height:57px">&nbsp;</td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td width="12%" height="28" bgcolor="#F8F8F8">
                <span style="height: 28px">
                  <strong>排名</strong>
                </span>
              </td>
              <td width="35%" height="28" bgcolor="#FFFFFF">
                <strong>蛋蛋ID</strong>
              </td>
              <td width="53%" height="28" bgcolor="#F8F8F8">
                <span style="height: 28px">
                  <strong>赢蛋总数</strong>
                </span>
              </td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n1.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=17914856" target="_blank" class="a0">
                  17914856
                  <img src="/img/pub/nb1.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                1,221,277,220
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n2.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=16086152" target="_blank" class="a0">
                  16086152
                  <img src="/img/pub/nb2.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                1,085,624,750
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n3.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=12428178" target="_blank" class="a0">
                  12428178
                  <img src="/img/pub/nb3.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                923,805,190
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">4</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16597748" target="_blank" class="a0">16597748</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                843,129,200
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">5</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12836968" target="_blank" class="a0">12836968</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                777,976,631
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">6</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16599291" target="_blank" class="a0">16599291</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                661,320,534
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">7</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12691201" target="_blank" class="a0">12691201</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                609,795,692
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">8</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17818159" target="_blank" class="a0">17818159</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                608,078,511
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">9</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17348827" target="_blank" class="a0">17348827</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                496,653,706
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">10</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16984861" target="_blank" class="a0">16984861</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                474,433,527
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">11</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=13013215" target="_blank" class="a0">13013215</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                437,626,444
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">12</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=6889828" target="_blank" class="a0">6889828</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                412,128,677
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">13</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=6939307" target="_blank" class="a0">6939307</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                403,242,393
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">14</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17925664" target="_blank" class="a0">17925664</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                384,482,287
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">15</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12249703" target="_blank" class="a0">12249703</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                352,592,700
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">16</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17173006" target="_blank" class="a0">17173006</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                347,692,292
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">17</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17252737" target="_blank" class="a0">17252737</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                321,213,651
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">18</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12222264" target="_blank" class="a0">12222264</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                312,471,456
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">19</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=14200966" target="_blank" class="a0">14200966</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                304,329,386
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">20</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12923390" target="_blank" class="a0">12923390</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                295,266,286
                <img src="/img/pub/egg.gif"></td>
            </tr>

          </tbody>
        </table>
      </div>
      <!-- 上月  -->
      <div style=" width:304px; border:1px solid #FFB91F; margin-left:8px; float:left; margin-top:8px;">
        <table width="304" border="0" cellpadding="0" cellspacing="0" bgcolor="#FFB91F" align="center" style="color:Black;">
          <tbody>
            <tr align="center">
              <td colspan="3" background="__IMAGES__/game/mybets/by28.gif" style="height:57px">&nbsp;</td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td width="12%" height="28" bgcolor="#F8F8F8">
                <span style="height: 28px">
                  <strong>排名</strong>
                </span>
              </td>
              <td width="35%" height="28" bgcolor="#FFFFFF">
                <strong>蛋蛋ID</strong>
              </td>
              <td width="53%" height="28" bgcolor="#F8F8F8">
                <span style="height: 28px">
                  <strong>赢蛋总数</strong>
                </span>
              </td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n1.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=16752666" target="_blank" class="a0">
                  16752666
                  <img src="/img/pub/nb1.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                4,284,638,770
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n2.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=3567756" target="_blank" class="a0">
                  3567756
                  <img src="/img/pub/nb2.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                3,477,626,969
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n3.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=17348827" target="_blank" class="a0">
                  17348827
                  <img src="/img/pub/nb3.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                2,397,346,346
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">4</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16596609" target="_blank" class="a0">16596609</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                2,213,121,527
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">5</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=14200966" target="_blank" class="a0">14200966</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                2,180,364,006
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">6</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12428178" target="_blank" class="a0">12428178</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                1,966,708,300
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">7</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17818159" target="_blank" class="a0">17818159</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                1,636,096,226
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">8</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12836968" target="_blank" class="a0">12836968</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                1,348,025,371
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">9</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12249703" target="_blank" class="a0">12249703</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                1,323,590,700
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">10</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16597748" target="_blank" class="a0">16597748</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                1,314,967,675
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">11</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12158855" target="_blank" class="a0">12158855</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                1,286,344,601
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">12</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17783920" target="_blank" class="a0">17783920</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                1,192,558,192
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">13</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=225226" target="_blank" class="a0">225226</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                1,151,427,300
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">14</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16086152" target="_blank" class="a0">16086152</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                1,111,767,342
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">15</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12691201" target="_blank" class="a0">12691201</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                1,103,310,142
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">16</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=15145079" target="_blank" class="a0">15145079</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                1,013,684,347
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">17</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16869262" target="_blank" class="a0">16869262</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                930,797,726
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">18</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17173006" target="_blank" class="a0">17173006</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                899,774,207
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">19</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16785947" target="_blank" class="a0">16785947</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                872,994,587
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">20</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17516534" target="_blank" class="a0">17516534</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                864,766,877
                <img src="/img/pub/egg.gif"></td>
            </tr>

          </tbody>
        </table>
      </div>
      <!-- 本年  -->
      <div style=" width:304px; border:1px solid #FFB91F; margin-left:8px; float:left; margin-top:8px;">
        <table width="304" border="0" cellpadding="0" cellspacing="0" bgcolor="#FFB91F" align="center" style="color:Black;">
          <tbody>
            <tr align="center">
              <td colspan="3" background="__IMAGES__/game/mybets/bn28.gif" style="height:57px">&nbsp;</td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td width="12%" height="28" bgcolor="#F8F8F8">
                <span style="height: 28px">
                  <strong>排名</strong>
                </span>
              </td>
              <td width="35%" height="28" bgcolor="#FFFFFF">
                <strong>蛋蛋ID</strong>
              </td>
              <td width="53%" height="28" bgcolor="#F8F8F8">
                <span style="height: 28px">
                  <strong>赢蛋总数</strong>
                </span>
              </td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n1.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=16597748" target="_blank" class="a0">
                  16597748
                  <img src="/img/pub/nb1.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                9,861,810,550
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n2.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=17252737" target="_blank" class="a0">
                  17252737
                  <img src="/img/pub/nb2.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                8,210,992,223
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="34" bgcolor="#FFFaC7">
                <img src="/img/pub/n3.gif"></td>
              <td height="32">
                <a href="/pgComUserInfo.aspx?USERID=16752666" target="_blank" class="a0">
                  16752666
                  <img src="/img/pub/nb3.gif" width="18" height="18" align="absmiddle"></a>
              </td>
              <td height="32" bgcolor="#FFFaC7">
                6,447,591,285
                <img src="/img/pub/egg.gif"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF">
              <td height="1" colspan="3" bgcolor="#FFB91F" style="line-height:0px;"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">4</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12691201" target="_blank" class="a0">12691201</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                6,447,388,206
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">5</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12428178" target="_blank" class="a0">12428178</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                6,398,753,983
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">6</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17121809" target="_blank" class="a0">17121809</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                6,353,217,212
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">7</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17173006" target="_blank" class="a0">17173006</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                5,979,352,112
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">8</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=14200966" target="_blank" class="a0">14200966</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                5,564,547,670
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">9</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12836968" target="_blank" class="a0">12836968</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                5,165,733,374
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">10</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16086152" target="_blank" class="a0">16086152</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                4,734,104,893
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">11</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=8658564" target="_blank" class="a0">8658564</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                4,296,673,893
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">12</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17299171" target="_blank" class="a0">17299171</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                4,008,829,393
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">13</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=12249703" target="_blank" class="a0">12249703</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                3,670,602,280
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">14</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17348827" target="_blank" class="a0">17348827</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                3,552,678,474
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">15</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=4868093" target="_blank" class="a0">4868093</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                3,267,776,955
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">16</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=15375714" target="_blank" class="a0">15375714</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                3,186,807,255
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">17</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=11746649" target="_blank" class="a0">11746649</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                3,163,796,049
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">18</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=17051746" target="_blank" class="a0">17051746</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                2,903,872,640
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">19</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=14923641" target="_blank" class="a0">14923641</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                2,529,435,974
                <img src="/img/pub/egg.gif"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="25" bgcolor="#F8F8F8">20</td>
              <td height="24" bgcolor="#FFFFFF">
                <a href="/pgComUserInfo.aspx?USERID=16884815" target="_blank" class="a0">16884815</a>
              </td>
              <td height="24" bgcolor="#F8F8F8">
                2,274,884,200
                <img src="/img/pub/egg.gif"></td>
            </tr>

          </tbody>
        </table>
      </div>

      <table width="936" border="0" cellspacing="0" cellpadding="0">
        <tbody>
          <tr>
            <td height="5"></td>
          </tr>
          <tr>
            <td></td>
          </tr>
        </tbody>
      </table>
    </div>

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