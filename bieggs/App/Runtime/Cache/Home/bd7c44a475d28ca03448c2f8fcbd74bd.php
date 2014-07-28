<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
  <!-- InstanceBegin template="/Templates/navi_temp.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <!-- InstanceBeginEditable name="doctitle" -->
  <title>幸运28-专业的广告游戏平台</title>
  <link rel="stylesheet" type="text/css" href="__CSS__/game.css" />
  <script type="text/javascript" src="__JS__/game/AJax.js"></script>
  <script type="text/javascript" src="__JS__/game/game.js"></script>

  <script language="javascript" type="text/javascript">
    function genLidUrl(obj,LID){
      obj.href = 'bets/index/LID/' + LID;
    }
  </script>
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
  <!--------------------------------------------------->
  <div id="body_content">
    <!-- InstanceBeginEditable name="content" -->
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
      .dynamic_msg_r a {color: #F5A300;}
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
      <table width="968" border="0" cellspacing="0" cellpadding="0" align="center">
        <tbody>
          <tr valign="top">
            <td align="center" height="30" width="968" valign="middle">
              <div class="xy2820131227" style=" height:90px;  margin-top:8px; margin-bottom:8px;">
                <div class="xy2820131227_l" style=" height:90px;  width:623px">
                  <div style="  text-align:center; height:50px;line-height:60px;">
                    <span id="LReload" class="form_game">
                      <img id="reloadclose" src="__IMAGES__/game/sx_h.gif" onclick="setReLoad(2)" align="absmiddle" style="cursor:pointer" title="打开自动刷新">&nbsp;</span>
                    <object classid="clsid:6BF52A52-394A-11D3-B153-00C04F79FAA6" id="player" width="0" height="0">
                      <param name="url" value="__IMAGES__/game/xy28open.mp3">
                      <param name="uiMode" value="mini">
                      <param name="rate" value="1">
                      <param name="balance" value="0">
                      <param name="currentPosition" value="0">
                      <param name="playCount" value="1">
                      <param name="autoStart" value="0">
                      <param name="currentMarker" value="0">
                      <param name="invokeURLs" value="-1">
                      <param name="stretchToFit" value="-1">
                      <param name="windowlessVideo" value="0">
                      <param name="enabled" value="-1">
                      <param name="enableContextMenu" value="0">
                      <param name="fullScreen" value="0">
                      <param name="enableErrorDialogs" value="0"></object>
                    <span id="LSound" class="form_game">
                      <img id="imgopen" src="__IMAGES__/game/S_Open.gif" onclick="setSound(2)" align="absmiddle" style="cursor:pointer" title="关闭开奖声音">&nbsp;</span>
                    <span id="Sound"></span>
                    <span id="RemainTitle"> <strong>第633133期</strong>
                    </span>
                    <span id="RemainS">
                      已开奖
                      <a href="pc28.aspx" style="color:red; font-size:12px;">请刷新</a>
                    </span>
                    &nbsp;&nbsp;&nbsp;
                  </div>
                  <div style="  text-align:center; height:40px; line-height:30px;  ">
                    幸运28第 <strong style="color:#FF9C00;">633132</strong>
                    期开奖结果：7 + 6 + 5 =
                    <img src="__IMAGES__/game/nums/number_18.png" width="25" height="25" align="absmiddle">
                    &nbsp;&nbsp;&nbsp;[
                    <a href="http://www.bwlc.net/bulletin/index.jsp?id=3" target="_blank">官方查询</a>
                    ]&nbsp;&nbsp;[
                    <a href="/play/Introduce_Lucky28.aspx" target="_blank">游戏帮助</a>
                    ]
                  </div>
                </div>
                <div class="xy2820131227_r">
                  <a href="/play/Introduce_Lucky28.aspx" target="_blank">
                    <img src="__IMAGES__/game/xy28_rightwzb.gif" width="342px" height="90px"></a>
                </div>
              </div>
            </td>
          </tr>
        </tbody>
        <script type="text/javascript" src="__JS__/game/seting.js"></script>
      </table>
      <table width="968" border="0" cellpadding="0" cellspacing="1" bgcolor="#ffc00" align="center" style="color:Black; margin-bottom:5px" id="panel" >
        <tbody>
          <tr class="center_table">
            <td width="12%">期号</td>
            <td width="16%">开奖时间</td>
            <td width="23%">开奖结果</td>
            <td width="10%">已投注数</td>
            <td width="18%">奖池累计</td>
            <td width="11%">中奖人数</td>
            <td width="10%">参与</td>
          </tr>
          <?php if(is_array($db_pc28)): $i = 0; $__LIST__ = $db_pc28;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i;?><tr align="center" height="28px" bgcolor="#ffffff" <?php if(($vo["id"] % 2) == "0"): ?>style="background:#f2f2f2"<?php endif; ?>
            >
            <td class="panel_td1"><?php echo ($vo["id"]); ?></td>
            <td class="panel_td2"><?php echo ($vo["open_time"]); ?></td>
            <td class="panel_td3">
              <script language="javascript" type="text/javascript">
                  chkResult28('<?php echo ($vo["open_num"]); php?>', '__IMAGES__');</script>
            </td>
            <td class="panel_td4">
              <script language="javascript" type="text/javascript">document.write(transStr(<?php echo ($vo["all_down"]); ?>));</script>
            </td>
            <td class="panel_td5">
              <script language="javascript" type="text/javascript">document.write(transStr(<?php echo ($vo["all_eggs"]); ?>));</script>
              <img src="__IMAGES__/public/egg.png"></td>
            <td class="panel_td6">
              <?php if($vo["open_people"] == 0): ?><span style="color:#000000">-</span>
              <?php else: ?>
                <a href="<?php echo U('result/index?LID='.$vo['id']);?>" style="color:#cc6600"><?php echo ($vo["open_people"]); ?></a><?php endif; ?>
            </td>
            <td class="panel_td7">
              <?php if($vo["open_num"] == ""): ?><!-- onmouseover="genLidUrl(this,<?php echo ($vo["id"]); ?>)" 另一种实现方式-->
                <a href="<?php echo U('bets/bets28?LID='.$vo['id']);?>" >投注</a>
                <?php else: ?>
                <a href="<?php echo U('bets/bets28?LID='.$vo['id']);?>" style="color:#cc6600">已开奖</a><?php endif; ?>
            </td>
          </tr><?php endforeach; endif; else: echo "" ;endif; ?>
        <tr align="center" bgcolor="#FFFFFF">
          <td height="28" colspan="7" bgcolor="#FFFFFF">
            <form name="pgindex" method="post" action="game" id="pgindex">
              <input id="pg" name="pg" type="hidden" value="">
            </form>
            <head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>

<script language="javascript" type="text/javascript">
  var itemPerPage = <?php echo ($items); ?>; 

    function onsubmit(cur_pg){
        document.getElementById("pg").value = cur_pg;
        document.getElementById("pgindex").submit();
    }

    function calcPage(fora,index,cur_pg){
    	if ("f" == fora) {
    		if(1 == index){ //首页
    			return 1;
    		}else if(2 == index){ //前十页
    			return cur_pg - 80;
    		}else if(3 == index){  //前一页
    			return cur_pg - 8;
    		}
    	}else{
    		if(1 == index){ //后一页
    			return cur_pg + 8;
    		}else if(2 == index){  //后十页
    			return cur_pg + 80;
    		}else if(3 == index){  //尾页
    			return cur_pg + 800; //默认是80页，一般不会超过此值
    		}
    	}
    }

    function calcAllPg(items,is_ret){
        var pages = Math.ceil(items / itemPerPage);
        if (is_ret) {
          return pages;
        };
        document.write(pages);
    }
    function geItem(fora,index,en,title,fix,cur_pg){
    	var item;
    	if (en) {
    		var page = calcPage(fora,index,cur_pg);
    		item = '<a href="javascript:onsubmit(' + page + ');" target="_top"><span title=' + title +'><img src="__IMAGES__/public/'+ fora + '_' + index + fix + '.png" border="0"></span></a>';
    	}else{
    		item = '<span title=' + title +'>' + '<img src="__IMAGES__/public/'+ fora + '_' + index + fix + '.png" border="0">' +'</span>';
    	}
        return item;
    }
</script>
<table cellspacing="2" cellpadding="2" style="font-family:Tahoma; font-size:12px; text-align:center; border:0; width:100%;" class="phoenix">
	<tbody>
		<tr valign="middle">
			<td align="left">
				<span title="记录总数" style="cursor:pointer;">
					<span>&nbsp;&nbsp;记录总数：</span>
					<span class="fontc"><?php echo ($db_data_cnt); ?></span>
				</span>
				<span title="总页数" style="cursor:pointer;">
					<span>&nbsp;&nbsp;总页数：</span>
					<span class="fontc">
						<script type="text/javascript">calcAllPg(<?php echo ($db_data_cnt); ?>);</script>
					</span>
				</span>
				&nbsp;&nbsp;
				<span title="当前页" style="cursor:pointer;">
					<span>&nbsp; &nbsp;当前页：</span>
					<span class="fontc"><?php echo ($cur_pg); ?></span>
				</span>
			</td>
			<td align="center">
				<span class="point14">|</span>
				<block id="f_pg"></block>
				<block id="pgblock"></block>
				<block id="a_pg"></block>
				<span class="point14">|</span>
			</td>
			<td align="right">
				<span title="当前记录数" style="cursor:pointer;">
					<span>&nbsp;&nbsp;当页记录数：</span>
          <span class="fontc">
            <?php echo ($items); ?>
          </span>
				</span>
			</td>
		</tr>
	</tbody>
</table>
<script type="text/javascript">
var sh = sh = {f:1,a:1};
  var content = "";
  var all_pg = calcAllPg(<?php echo ($db_data_cnt); ?>,true);
  if (all_pg <= 8 || <?php echo ($cur_pg); ?> <= 8) {
    var loop = (all_pg <= 8)? all_pg : 8;
    for (var i = 1; i <= loop; i++) {
      var item = "";
      if (<?php echo ($cur_pg); ?> == i) {
        item += '<span class="fontc">' + i +'</span>';
      }else{
        item = '<a href="javascript:onsubmit(' + i +');"' + 'target="_top">' + i + '</a>';
      }
      content += item + "&nbsp;";
    };
    var sh_pg = Math.ceil(all_pg / 8);
    if (sh_pg <= 1) {
    	sh = {f:0,a:0}
    }else{
    	var cur_pg = Math.ceil((<?php echo ($cur_pg); ?> - 1) / 8);
    	if (cur_pg <= 1) {
    		sh.f = 0;
    	}else if(cur_pg == sh_pg){
    		sh.a = 0;
    	}
    }
  }else{
  	var curpg = <?php echo ($cur_pg); ?>;
  	if(curpg > all_pg){
  		curpg = all_pg - 1;
  	}
    var st_index = Math.floor((curpg - 1) / 8);

    var topnum = (st_index + 1) * 8 ;
    if (topnum > all_pg) {
    	topnum = all_pg;
    };

    for (var i = st_index * 8 + 1; i <= topnum; i++) {
      var item = "";
      if (<?php echo ($cur_pg); ?> == i) {
        item += '<span class="fontc">' + i +'</span>';
      }else{
        item = '<a href="javascript:onsubmit(' + i +');"' + 'target="_top">' + i + '</a>';
      }
      content += item + "&nbsp;";
    };
    var sh_pg = Math.ceil(all_pg / 8);
    var c_pg = Math.ceil(curpg / 8);
	if (c_pg >= sh_pg) {
		sh.a = 0;
	}
  }
  var pgblock = document.getElementById("pgblock");
  pgblock.innerHTML=content;
    /***********f_pg***************/
    var f_pg = document.getElementById("f_pg");
	var item1 = geItem("f",1,(1 == sh.f)? true:false,"首页",sh.f,<?php echo ($cur_pg); ?>) + "&nbsp;";
	var item2 = geItem("f",2,(1 == sh.f)? true:false,"前十页",sh.f,<?php echo ($cur_pg); ?>) + "&nbsp;";
	var item3 = geItem("f",3,(1 == sh.f)? true:false,"前一页",sh.f,<?php echo ($cur_pg); ?>) + "&nbsp;";
	f_pg.innerHTML=item1 + item2 + item3;
	/************a_pg***************/
	var a_pg = document.getElementById("a_pg");
	var item1 = geItem("a",1,(1 == sh.a)? true:false,"后一页",sh.a,<?php echo ($cur_pg); ?>) + "&nbsp;";
	var item2 = geItem("a",2,(1 == sh.a)? true:false,"后十页",sh.a,<?php echo ($cur_pg); ?>) + "&nbsp;";
	var item3 = geItem("a",3,(1 == sh.a)? true:false,"尾页",sh.a,<?php echo ($cur_pg); ?>) + "&nbsp;";
	a_pg.innerHTML=item1 + item2 + item3;
</script>
            <style type="text/css">
              .fontc{color:#ff8000;font-weight:bold;}
            </style>
          </td>
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