<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>310竞猜-专业的广告游戏平台</title>
  <script type="text/javascript" src="__JS__/Jquery/jquery-1.6.2.min.js"></script>
  <script type="text/javascript" src="__JS__/game/bets310.js"></script>
  <link rel="stylesheet" type="text/css" href="__CSS__/bets.css" />
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
<style type="text/css">.navibar_<?php echo ($PAGE_CURID); ?>{color: #ff0000; font-weight:bold;}
.center_table {background: url("__IMAGES__/public/titlebg_g.gif") repeat;}
.center_table td {text-align: center; height: 28px;}
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

    <style type="text/css">
    .dynamic_msg {border: 1px solid #248300;}
    .dynamic_msg_r a {color: #248300;}
    #body_content {border: 1px solid #248300;}
    </style>
    <div class=game_content>
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
</head>
<table width="968" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="00cf00">
  <tbody>
    <tr>
      <td width="50%" height="24" align="left" valign="middle" style="padding-left:10px"> <b><a href="pg310.aspx?typeid=1" class="abt12_1">310竞技比赛</a></b> 
        <span class="wh12">|</span>
        <a href="Pg310Europe5match.aspx" class="abt12_1">
          <img src="__IMAGES__/game/new28.gif">五大联赛专题</a>
        <span class="wh12">|</span>
        <a href="Pg310WorldCup.aspx" class="abt12_1">2010世界杯专题</a>
      </td>
      <td width="50%" align="right" valign="middle" style="padding-right:10px">
        &nbsp;
        <a href="pgMy310.aspx" target="_parent" class="abt12_1">我的投注</a>
        <span class="wh12">|</span>
        <a href="pg310Help.aspx" target="_blank" class="abt12_1">310竞猜帮助</a>
        <span class="wh12">|</span>
        <a href="javascript:ShowMsgo.show('/adcomate/pggetgoldeggsnew.aspx',503,546)" target="_parent" class="abt12_1">领取救济金</a>
      </td>
    </tr>
  </tbody>
</table>
      <div class="bar_m">
        <div class="bar_m_l">当前：巴西世界杯淘汰赛（巴西 vs 哥伦比亚）</div>
        <div class="bar_m_r">投注截止时间:2014-07-05 03:00</div>
      </div>
      <div class="bar_b">
        <div class="bar_b_t">
          <?php echo ($db_pc310_LID[0]['guest']); ?> VS <?php echo ($db_pc310_LID[0]['main']); ?>
        </div>
        <div class="bar_b_ti">赛事描述：</div>
        <div>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<?php echo ($db_pc310_LID[0]['game_desc']); ?>
        </div>
        <a href="http://sports.sina.com.cn/index1.shtml" style="margin-left:860px;">更多详细赛事>></a>
      </div>
      <table width="968" border="0" cellpadding="0" cellspacing="1" bgcolor="#248301" align="center" style="margin:0 auto 5px auto;">
        <tbody>
          <tr background="__IMAGES__/public/titlebg_g.gif" align="center">
            <td width="8%" height="26" align="center">预测结果</td>
            <td width="23%" align="center">竞猜结果</td>
            <td width="15%" align="center">当前赔率</td>
            <td width="15%" align="center">请选择</td>
            <td width="22%" align="center">投注</td>
            <td width="17%" align="center">倍数</td>
          </tr>
          <script type="text/javascript">
            var result0=<?php echo ($db_pc310_LID[0]['result_0']); ?>;
            var result1=<?php echo ($db_pc310_LID[0]['result_1']); ?>;
            var result2=<?php echo ($db_pc310_LID[0]['result_2']); ?>;
          </script>
          <!-- 1 == 3  /  2 == 0  /  1 == 0 -->
          <?php $__FOR_START_7344__=0;$__FOR_END_7344__=$db_pc310_LID[0]["result_mode"];for($i=$__FOR_START_7344__;$i < $__FOR_END_7344__;$i+=1){ ?><tr height="30" bgcolor="#FFFFFF" align="center">
              <?php if($i == 0): ?><td>0</td>
                <td>客队（<?php echo ($db_pc310_LID[0]['guest']); ?>）输</td>
              <?php elseif($i == 1): ?>
                <td>3</td>
                <td>客队（<?php echo ($db_pc310_LID[0]['guest']); ?>）赢</td>
              <?php else: ?>
                <td>1</td>
                <td>客队（<?php echo ($db_pc310_LID[0]['guest']); ?>）平</td><?php endif; ?>
              <td>
                <script type="text/javascript">
                  setRate(<?php echo ($i); ?>);
                </script>
              </td>
              <td>
                <input name="checkboxd" id="CI<?php echo ($i); ?>" type="checkbox" value="3" onclick="chclick('<?php echo ($i); ?>');"></td>
              <td>
                <input id="<?php echo ($i); ?>" name="SMONEY" type="text" class="input310" size="25" value="" onkeyup="if(event.keyCode !=37 &amp;&amp; event.keyCode != 39) value=value.replace(/D/g,'');setNums('<?php echo ($i); ?>');" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/D/g,''))"></td>
                <td>
                  <input class="input3" name="Add" value=".5" type="button">
                  <input class="input3" name="Add" value="2" type="button">
                  <input class="input3" name="Add" value="10" type="button">
                </td>
            </tr><?php } ?>

          <tr>
            <td height="30" colspan="6" align="center" bgcolor="#D3ECD3">
            <span class="STYLE1">我的总投注额：</span>
            <input id="SMONEYSUM" name="SMONEYSUM" class="input310" type="text" readonly="readonly" value="0"></td>
          </tr>
          <tr>
            <td height="30" colspan="6" align="center" bgcolor="#D3ECD3">
            <input type="submit" onclick="javascript:chgsubmit()"name="Submit10" value="确认投注"></td>
          </tr>
        </tbody>
      </table>
      <form id="sub_form" method="post" action="../../pc310bets" enctype="application/x-www-form-urlencoded">
        <input id="LID" name="LID" type="hidden" value=""/>
        <input id="ALLSMONEY" name="ALLSMONEY" type="hidden" value=""/>
      </form>
      <script type="text/javascript">
        var LID=<?php echo ($LID); ?>;
        document.getElementById("LID").value=LID;
      </script>
      <div class="bets_tip">
      <p>特别提醒：</p>
      <p>1、当您在游戏中存在投注时，不能领取救济补足。</p>
      <p>2、所有赛事如无特别说明，竞猜数据以最终赛事结果为依据，其中包括比赛的附加时间（如伤停补时等）。</p>
      <p>3、游戏数据均采自第三方比赛结果，比赛结束后两小时内工具结果。</p>
      <p>4、本游戏仅供娱乐，严禁以本游戏结果开设外围赌局，本网站对竞猜结果保留最终解释权。</p>
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