<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>幸运28-专业的广告游戏平台</title>
  <link rel="stylesheet" type="text/css" href="__CSS__/bets.css" />
  <script type="text/javascript" src="__JS__/Jquery/jquery-1.6.2.min.js"></script>
  <script type="text/javascript" src="__JS__/game/bets.js"></script>
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
        <span class="llid" style="color:#ff0000;">637809</span>
        期开奖结果:
        <img src="" width="25" height="25"></div>
      <div style="width:60%; text-align:center; border:1px; float :left; line-height:30px; height:30px; " id="RemainTitle"></div>
    </div>
    <div class="border_out" style="height:auto; margin-top:8px;">
      <div class="border_out_r">
        <div class="border_out_title">
          <span style="float:left;width:auto;">本期投注详情</span>
          <span style="float:right;width:auto;"></span>
        </div>
        <div style="padding:2px 5px; background-color:#FEFEF9; border:1px solid #E6C48F; line-height:24px;">
          <div style="display: inline; ">
            开奖时间:
            <span class="open_time" style="font-size:14px; font-weight: bold; color:#ff6c00"></span>
          </div>
          <div style="display: inline; margin-left:350px;">
            已投注:
            <span class="ardown" style="font-size:14px; font-weight: bold; color:#ff6c00"></span>
            <img src="__IMAGES__/public/egg.png"/>
          </div>
        </div>
      </div>
    </div>
    <div class="border_out" style="margin-top:8px">
      <div class="border_out_l">
        <div class="border_out_title">
          <span style="float:left;width:auto;">标准投注模式</span>
          <span style="float:right;width:auto;">
            <a href="http://www.pceggs.com/play/Introduce_Lucky28.aspx">标准模式说明</a>
          </span>
        </div>
        <table border="0" width="960" align="center">
          <tbody>
            <tr>
              <td height="23" class="img_bt1" width="51" attr="0" style="color: rgb(81, 81, 81);">全包</td>
              <td class="img_bt1" width="46" attr="1" style="color: rgb(81, 81, 81);">单</td>
              <td class="img_bt1" width="46" attr="2" style="color: rgb(81, 81, 81);">双</td>
              <td class="img_bt1" width="46" attr="3" style="color: rgb(81, 81, 81);">大</td>
              <td class="img_bt1" width="46" attr="4" style="color: rgb(81, 81, 81);">小</td>
              <td class="img_bt1" width="46" attr="5" style="color: rgb(81, 81, 81);">中</td>
              <td class="img_bt1" width="46" attr="6" style="color: rgb(81, 81, 81);">边</td>
              <td class="img_bt1" width="46" attr="7" style="color: rgb(81, 81, 81);">大单</td>
              <td class="img_bt1" width="46" attr="8" style="color: rgb(81, 81, 81);">小单</td>
              <td class="img_bt1" width="46" attr="9" style="color: rgb(81, 81, 81);">大双</td>
              <td class="img_bt1" width="46" attr="10" style="color: rgb(81, 81, 81);">小双</td>
              <td class="img_bt1" width="46" attr="11" style="color: rgb(81, 81, 81);">大边</td>
              <td class="img_bt1" width="46" attr="12">小边</td>
              <td class="img_bt1" width="46" attr="13" style="color: rgb(81, 81, 81);">单边</td>
              <td class="img_bt1" width="46" attr="14">双边</td>
            </tr>
            <tr>
              <td height="23" class="img_bt1" width="46" attr="15">小尾</td>
              <td class="img_bt1" width="46" attr="16">大尾</td>
              <td class="img_bt1" width="46" attr="17" style="color: rgb(81, 81, 81);">3余0</td>
              <td class="img_bt1" width="46" attr="18" style="color: rgb(81, 81, 81);">3余1</td>
              <td class="img_bt1" width="46" attr="19" style="color: rgb(81, 81, 81);">3余2</td>
              <td class="img_bt1" width="46" attr="20">4余0</td>
              <td class="img_bt1" width="46" attr="21">4余1</td>
              <td class="img_bt1" width="46" attr="22">4余2</td>
              <td class="img_bt1" width="46" attr="23">4余3</td>
              <td class="img_bt1" width="46" attr="24">5余0</td>
              <td class="img_bt1" width="46" attr="25">5余1</td>
              <td class="img_bt1" width="46" attr="26">5余2</td>
              <td class="img_bt1" width="46" attr="27">5余3</td>
              <td class="img_bt1" width="46" attr="28">5余4</td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>

    <div class="border_out" style="height:auto; margin-top:8px;">
      <div class="border_out_r">
        <div class="border_out_title">
          <span style="float:left;width:auto;">自定义模式</span>
          <span style="float:right;width:auto;">
            <a href="http://www.pceggs.com/play/pg28ModesEdit.aspx">管理</a>
          </span>
        </div>

        <div class="user_mode" style="padding:2px 5px; background-color:#FEFEF9; border:1px solid #E6C48F; line-height:24px;"></div>
      </div>
    </div>
    <div class="border_out1">
      <div class="border_out1_l" id="border_out1_l">
        <span style="color: rgb(141, 80, 0);">0.1倍</span>
        <span style="color: rgb(141, 80, 0);">0.5倍</span>
        <span style="color: rgb(141, 80, 0);">0.8倍</span>
        <span>1.2倍</span>
        <span style="color: rgb(141, 80, 0);">1.5倍</span>
        <span style="color: rgb(141, 80, 0);">2倍</span>
        <span style="color: rgb(141, 80, 0);">10倍</span>
        <span>50倍</span>
        <span>100倍</span>
      </div>
      <div class="border_out1_c">
        <div style="float:left;width:76px;padding-left:16px;">总投注金蛋：</div>
        <div style="color:#ff6c00; font-weight:bold;width:90px;float:left; overflow:hidden" id="totalvalue">0</div>
        <div class="conform_btn" onclick="comform()" id="conform_btn">确认投注</div>
      </div>
      <div class="border_out1_r">
        <div class="touzhu">上期投注</div>
        <div class="touzhu">反选</div>
        <div class="touzhu">清除</div>
      </div>
    </div>

    <form id="form1" method="post" action="./bets/pc28bets" enctype="application/x-www-form-urlencoded">
      <input id="input_timeout" value="您已过投注截止期！" style="display:none;">
      <input id="LID" name="LID" type="hidden" value="559440">
      <input id="CTIME" name="CTIME" type="hidden" value="2014-06-28 16:40">
      <input class="input1" name="Cheat" type="hidden" value="CAE" style="width:20px">
      <input type="hidden" id="isdb_p" name="isdb_p" value="0">
      <input class="input1" name="ALLSMONEY" id="ALLSMONEY" type="hidden" value="0">
      <input id="SMONEYSUM" class="input1" name="SMONEYSUM" type="hidden" value="0" ;="">
      <input type="hidden" id="lastgain" name="lastgain" value="">
      <input type="hidden" id="_issue" name="_issue" value="638866">
      <iframe style="display:none; width: 248px; height: 9px;" name="hidefrm" id="hidefrm" src=""></iframe>
      <div class="content_middle" style="width:968px;margin:auto;" id="panel">
<script language="javascript" type="text/javascript">  
  var cis="941.62,338.43,169.20,103.96,67.96,48.27,35.57,27.44,22.17,18.11,15.84,14.02,13.67,13.21,13.30,13.70,14.46,15.81,18.07,22.21,27.43,35.84,48.71,67.61,102.25,178.81,333.39,589.64";//上期赔率
  var a_cis=cis.split(",");
  var cis1="425.53,1124.23,4233.02,7231.36,5232.2352,3453.83,2458.41,1348.92,14449.75,16573.56,1569.01,156564.74,1658.13,1563.29,1569.50,1655.49894,1897.87,1126.51,1129.9339,1228.6110,2337.3446,2557.2651,45653.7762,56761.77,1608.69,16736.1678,3717.49,502.14";//本期赔率
  var a_cis1=cis1.split(",");
  var BeforePeriods="*"+"637810";//上期投注号
  var Periods="558378"//本期ID
  var TSeconds="100";//倒计时
  var mypceggs="16504";//我的金蛋数
  var IsGetEggs="0";//是否可以清理获取
  var StrTimeOut="0"
  var LastIssue="";


  var img_path = '__IMAGES__';
  var umode = new Array();
  <?php if(is_array($db_umode)): $i = 0; $__LIST__ = $db_umode;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i;?>umode.push('<?php echo ($vo["name"]); ?>');<?php endforeach; endif; else: echo "" ;endif; ?>

  var LLID="<?php echo ($db_pc28_last[0]['id']); ?>";//上期期号
  var LLNUM="<?php echo ($db_pc28_last[0]['open_num']); ?>";//上期开奖号
  var LID="<?php echo ($db_user_bets[0]['LID']); ?>";//当期期号
  var aldown = "<?php echo ($db_user_bets[0]['SMONEYSUM']); ?>";
  var arr1="<?php echo ($db_user_bets[0]['ALLSMONEY']); ?>".split(",");
  //开奖时间
  var open_time = "<?php echo (date('Y-m-d H:i:s',$db_user_bets[0]['CTIME'])); ?>";
</script>
        <input class="input2" name="SMONEYY" type="hidden" value="ALD">
        <table width="484" border="0" cellpadding="0" cellspacing="1" bgcolor="#FFB91F" align="left" style="color:Black;">
          <tbody>
            <tr align="center" height="20">
              <td width="50" background="">号码</td>
              <td width="71" background="">上期赔率</td>
              <td width="71" background="">当前赔率</td>
              <td width="53" background="">请选择</td>
              <td width="130" background="">投注</td>
              <td width="80" background="">倍数</td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_0.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>941.62</td>
              <td>31.08</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt0" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_1.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>338.43</td>
              <td>26.96</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt1" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_2.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>169.20</td>
              <td>86.44</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt2" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_3.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>103.96</td>
              <td>114.73</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt3" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_4.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>67.96</td>
              <td>90.09</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt4" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_5.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>48.27</td>
              <td>44.91</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt5" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_6.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>35.57</td>
              <td>49.91</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt6" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_7.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>27.44</td>
              <td>40.52</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt7" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_8.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>22.17</td>
              <td>16.25</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt8" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_9.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>18.11</td>
              <td>31.55</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt9" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_10.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>15.84</td>
              <td>27.55</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt10" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_11.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>14.02</td>
              <td>10.59</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt11" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_12.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>13.67</td>
              <td>23.77</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt12" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_13.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>13.21</td>
              <td>23.14</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt13" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td>
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
          </tbody>
        </table>
        <table width="484" border="0" cellpadding="0" cellspacing="1" bgcolor="#FFB91F" align="right" style="color:Black;">
          <tbody>
            <tr align="center" height="20">
              <td width="50" background="">号码</td>
              <td background="">上期赔率</td>
              <td background="">当前赔率</td>
              <td background="">请选择</td>
              <td width="130" background="">投注</td>
              <td background="" style="width: 80px">倍数</td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_27.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>589.64</td>
              <td>15.64</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt27" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_26.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>333.39</td>
              <td>25.19</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt26" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_25.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>178.81</td>
              <td>300.47</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt25" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_24.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>102.25</td>
              <td>180.28</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt24" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_23.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>67.61</td>
              <td>49.49</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt23" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_22.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>48.71</td>
              <td>85.85</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt22" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_21.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>35.84</td>
              <td>63.40</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt21" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_20.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>27.43</td>
              <td>19.21</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt20" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_19.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>22.21</td>
              <td>123.28</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt19" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_18.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>18.07</td>
              <td>100.97</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt18" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_17.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>15.81</td>
              <td>10.96</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt17" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_16.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>14.46</td>
              <td>22.11</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt16" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_15.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>13.70</td>
              <td>20.90</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt15" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" maxlength="9"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>
            <tr align="center" bgcolor="#FFFFFF" height="27">
              <td>
                <img src="__IMAGES__/game/nums/number_14.png" width="25" height="25" style="cursor: pointer;"></td>
              <td>13.30</td>
              <td>9.21</td>
              <td>
                <input type="checkbox" name="checkboxd" value="checkbox"></td>
              <td>
                <input type="text" class="input2" name="SMONEY" style="width:110px;ime-mode:disabled" id="txt14" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))"></td>
              <td style="width: 80px">
                <input class="input3" name="Add" value=".5" type="button">
                <input class="input3" name="Add" value="2" type="button">
                <input class="input3" name="Add" value="10" type="button"></td>
            </tr>

          </tbody>
        </table>
      </div>

<style type="text/css">
.div_ad{z-index:102;position:absolute;}
.input3
{
    border: solid 1px #aaa;
    background: #fff;
    color: #000;
    height: 20px;
     width:22px;
cursor:pointer
}
.popup{width:340px;height:auto;background:#fff;border:1px solid #C40000;}
.popup .titleclose {padding:1px 0 0 10px;height:44px; background:url(__IMAGES__/game/cm_28_bg.gif) no-repeat; }
.popup .title {font-size:12px;font-weight:bold;color:#FFF;line-height:23px;border:0px;}
.popup .close {position:absolute;right:4px;top:1px;width:55px;height:23px;cursor:pointer}
.popup .close span {display:none;}
.popup .content1 {padding:20px; padding-top:10px;min-height:26px;_height:26px;text-align:center;line-height:26px; font-size:12px;}
.popup .btnpane { margin:0 auto;width:168px;margin-bottom:15px;height:22px; margin-left:100px;}
.popup .content2 {padding-left:15px; padding-right:0px;padding-bottom:8px;padding-top:0px;min-height:26px;_height:26px;text-align:center;line-height:26px; font-size:12px;}
.popup .btnpane_fx {margin:0 auto;width:340px;padding-bottom:8px;height:22px; font-size:12px;height:32px;}
.popup .btnpane_fx ul li{ list-style:none; float:left; width:98px;}
.popup .btnpane_zcwz {margin:0 auto;width:226px;padding-bottom:10px;height:22px; margin-left:120px; font-size:12px;height:32px;}
.help_show{ position:absolute;top:500px;left:900px;}
.show_kj{border:4px #FB0301 solid;}
.kjauto1{ width:100px; height:50px;}

.hand{
  position:relative;
  width:59px;
  height:54px;
  background: url(../img/fc_hand/hand.gif) no-repeat;
  cursor:pointer;
  top:-10px;
  left:30px;
}

.show_tips{position:absolute;border:1px solid #EBA100;background: url(../img/fc_hand/help_fc_bg.gif) no-repeat left top;width:437px; font-size:12px;z-index:9999;}
.show_tips .t_zone{padding:10px;line-height:21px;}
.tips1{left:70px;top:50px;width:120px;}

.blue_load_l:link {
  color:#3B5888;
  text-decoration:underline;
}
.blue_load_l:visited {
  text-decoration:underline;
  color:#3B5888;
}
.blue_load_l:hover {
  text-decoration:underline;
  color:#3B5888;
}
.blue_load_l:active {
  text-decoration:underline;
  color:#3B5888;
}
.tips2{left:65px;top:75px;*left:70px;*top:80px;width:300px;}
.gb_an{float:right; margin-top:3px; margin-right:2px;}
</style>
      <div class="div_full" id="parent_div" style="position:absolute; background-color: #C8C8C8; width: 100%; height: 1077px; opacity: 0.4; filter: alpha(opacity=20); MozOpacity: 0.2;-moz-opacity: 0.2; z-index:100; left: 0px;top: 0px; display:none;"></div>
      <div id="div_ad" style="position: absolute; z-index: 101; width: 360px; height: auto; display:none;" class="popup">
        <div class="container">
          <div class="titleclose"></div>
          <div class="content1"></div>
          <div class="btnpane"></div>
        </div>
      </div>
<script language="javascript" type="text/javascript">  
  setpeilv(a_cis,"");
  initParams();
  GetRTime(TSeconds,LID);
</script>

    </form>
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