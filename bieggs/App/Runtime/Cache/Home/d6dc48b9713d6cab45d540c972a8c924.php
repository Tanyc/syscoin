<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>幸运28-专业的广告游戏平台</title>
  <link rel="stylesheet" type="text/css" href="__CSS__/mybets.css" />
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

    <div class="content_middle " style="height:2550px ">
      <div class="xy28js jsbg_1">
        <div class="xy28js_kj">
          幸运28是PC蛋蛋首创的竞猜游戏。28个号码，押中即可获得奖励。每天从早上
          <span class="a9_1">9:05</span>
          ～
          <span class="a9_1">23:55</span>
          ；每
          <span class="a9_1">5</span>
          分钟一期。
          <br>
          虽然游戏本身规则很简单，但由于每期都有几万人一起投注，而且投注的号码和金蛋各不相同.所以每个号码会有不同赔率。游戏会有很多变化，
    其乐无穷，慢慢体会吧！
        </div>
      </div>

      <div class="xy28js jsbg_120131227">
        <div class="xy28js_kj">
          幸运28开奖结果来源于国家福利彩票北京
          <span class="a9_1">快乐8</span>
          (
          <a href="http://www.bjfcdt.gov.cn/happy8/v1/affiche.aspx" target="_blank" style="text-decoration:underline;">官网</a>
          )开奖号码，从早上
          <span class="a9_1">9:05</span>
          至
          <span class="a9_1">23:55</span>
          ，每
          <span class="a9_1">5</span>
          分钟一期不停开奖。
          <br>
          北京快乐8每期开奖共开出
          <span class="a9_1">20</span>
          个数字，幸运28将这20个开奖号码按照
          <span class="a9_1">由小到大的顺序依次排列</span>
          ；取其1-6位开奖号码相加，和值的末位数作为幸运
28开奖第一个数值； 取其7-12位开奖号码相加，和值的末位数作为幸运28开奖第二个数值，取其13-18位开奖号码相加，和值的末位数作为幸运
28开奖第三个数值；三个数值相加即为幸运28最终的开奖结果。
        </div>

        <div class="xy28js_kj_line131227"></div>
        <div class="xy28js_kj120131227">
          <p>
            以北京福彩快乐8第
            <span class="a9_1">607473</span>
            期开奖为例：
          </p>
          <div style="margin:0 auto;">
            <img src="__IMAGES__/game/mybets/kl8_bg.gif"></div>
        </div>
      </div>

      <div class="xy28js jsbg_2">
        <div class="xy28js_kj">
          <div style="float:left; width:283; height:101px; margin-right:18px;">
            <img src="__IMAGES__/game/mybets/xy28_jsbg2_1.gif" border="0" usemap="#Map9">
            <map name="Map9" id="Map9">
              <area shape="rect" coords="206,44,270,66" href="http://www.pceggs.com/prize/PrizeMain.aspx" usemap="#Map9"></map>
          </div>
          <div style="float:left; width:283; height:101px;">
            <img src="__IMAGES__/game/mybets/xy28_jsbg2_2.gif"></div>
          <div style="float:right; width:283; height:101px;">
            <img src="__IMAGES__/game/mybets/xy28_jsbg2_3.gif" border="0" usemap="#Map2">
            <map name="Map2" id="Map2">
              <area shape="rect" coords="81,63,153,89" href="http://www.pceggs.com/play/pc28.aspx"></map>
          </div>

        </div>
      </div>
      <div class="xy28js jsbg_3">
        <div class="xy28js_line line1"></div>
        <div class="xy28js_kj xy28js_kj2">
          幸运28是三个0～9的随机数之和，因此竞猜的范围：
          <span class="a9_1">０～２７</span>
          。为了方便理解，我们对０～２７进行归类，整理出很多
          <span class="a9_1">投注模式</span>
          如下：
        </div>
        <div class="xy28js_kj xy28js_kjimg">
          <img src="__IMAGES__/game/mybets/js_img1.gif"></div>
        <div class="xy28js_line line2"></div>
        <div class="xy28js_kj xy28js_kj2"> <strong>下面我们以
            <img src="__IMAGES__/game/mybets/qbimg.gif" width="51" height="23" align="absmiddle">为例介绍整个投注流程：</strong>
          <br>
          <span class="a9_1">全包</span>
          就是０～２７个号码全部都投注，因此一定会猜中，但由于几万蛋友的投注方法和金蛋各不相同，所以全包可能亏，也可能赚。盈亏不大，
适合刚入门的蛋友。
          <br> <strong>首先，</strong>
          先进入到幸运28游戏页面开始游戏：
        </div>
        <div class="xy28js_kj xy28js_kjimg">
          <img src="__IMAGES__/game/mybets/js_img2.gif"></div>
        <div class="xy28js_kj xy28js_kj3">
          <strong>然后，</strong>
          进入到幸运28投注页面按步骤投注：
        </div>
        <div class="xy28js_kj xy28js_kjimg">
          <img src="__IMAGES__/game/mybets/js_img3.gif"></div>
      </div>

      <div class="xy28js jsbg_4">
        <div class="xy28js_line line1"></div>
        <div class="xy28js_kj xy28js_kj2">
          <strong>第一种方式：通过ＰＣ蛋蛋以下频道赚金蛋</strong>
        </div>
        <div class="xy28js_kj xy28js_kjword">
          <table width="614" border="0" cellspacing="0" cellpadding="0">
            <tbody>
              <tr>
                <td width="82" height="30">
                  <img src="__IMAGES__/game/mybets/yxsw_top.gif"></td>
                <td width="447" height="30">游戏商家在蛋蛋平台上投放的游戏，试玩即可获得金蛋奖励。</td>
                <td width="85">
                  <a href="http://www.pceggs.com/Gain/GnGameAll.aspx" class="a0">我要试玩&gt;&gt;</a>
                </td>
              </tr>
              <tr>
                <td height="30">
                  <img src="__IMAGES__/game/mybets/ggty_top.gif"></td>
                <td height="30">广告商家在蛋蛋平台上投放的广告，体验即可获得金蛋奖励。</td>
                <td height="30">
                  <a href="http://www.pceggs.com/Gain/Gnmain.aspx" class="a0">我要体验&gt;&gt;</a>
                </td>
              </tr>

              <tr>
                <td height="30">
                  <img src="__IMAGES__/game/mybets/gwfl_top.gif"></td>
                <td height="30">和淘宝；凡客；京东商城等几十家合作；一样购物，不一样的返利。</td>
                <td height="30">
                  <a href="/newtb/NewTBIndex.aspx" class="a0">我要购物&gt;&gt;</a>
                </td>
              </tr>
            </tbody>
          </table>
        </div>
        <div class="xy28js_kj xy28js_kj2">
          <strong>第二种方式： 每天免费领取１０次救济</strong>
        </div>
        <div class="xy28js_kj xy28js_kjword">
          当您的金蛋少于
          <span class="a9_1">5000</span>
          ，即可领取救济。（每天
          <span class="a9_1">10</span>
          次）帐号绑定YY365，即可领取YY365等级对应的金蛋。
          <br>
          <img src="__IMAGES__/game/mybets/yyjs_img.gif"></div>
      </div>
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