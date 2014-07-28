<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title>兑奖中心-专业的广告游戏平台</title>
	<link rel="stylesheet" type="text/css" href="__CSS__/prize.css" />
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


		<div class="pcdjzx_con">
			<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<link rel="stylesheet" type="text/css" href="__CSS__/market_left.css" />
</head>
<div class="pcdjzx_con_left">
	<div class="jpfl">
		<div class="djright_t">
			<div class="l" style="background: url(__IMAGES__/prize/prize_c.png) left no-repeat;"></div>
		</div>
		<div class="jpfl_bg">
			<div class="jpfl_xx">
				<a href="<?php echo U('prize/plist?id=1');?>"> <strong>虚拟奖品</strong>
				</a>
				<span>&nbsp;&nbsp;</span>
				<a href="<?php echo U('prize/plist?id=1&cid=1');?>" class="black_a1">手机充值</a>
				&nbsp;&nbsp;
				<a href="<?php echo U('prize/plist?id=1&cid=2');?>" class="black_a1">游戏点卡</a>
				&nbsp;&nbsp;
				<a href="<?php echo U('prize/plist?id=1&cid=3');?>" class="black_a1">QQ充值</a>
				&nbsp;&nbsp;
			</div>
			<div class="jpfl_xx">
				<a href="<?php echo U('prize/plist?id=2');?>"> <strong>数码产品</strong>
				</a>
				<span>&nbsp;&nbsp;</span>
				<a href="<?php echo U('prize/plist?id=2&cid=1');?>" class="black_a1">手机</a>
				&nbsp;&nbsp;
				<a href="<?php echo U('prize/plist?id=2&cid=2');?>" class="black_a1">笔记本</a>
				&nbsp;&nbsp;
				<a href="<?php echo U('prize/plist?id=2&cid=3');?>" class="black_a1">相机、摄像机</a>
				&nbsp;&nbsp;
				<a href="<?php echo U('prize/plist?id=2&cid=4');?>" class="black_a1">随身视听</a>
				&nbsp;&nbsp;
				<a href="<?php echo U('prize/plist?id=2&cid=5');?>" class="black_a1">数码配件</a>
				&nbsp;&nbsp;
			</div>
			<div class="jpfl_xx">
				<a href="<?php echo U('prize/plist?id=3');?>">
					<strong>居家生活</strong>
				</a>
				<span>&nbsp;&nbsp;</span>
				<a href="<?php echo U('prize/plist?id=3&cid=1');?>" class="black_a1">生活日用</a>
				&nbsp;&nbsp;
				<a href="<?php echo U('prize/plist?id=3&cid=2');?>" class="black_a1">床上用品</a>
				&nbsp;&nbsp;
				<a href="<?php echo U('prize/plist?id=3&cid=3');?>" class="black_a1">厨房用品</a>
				&nbsp;&nbsp;
				<a href="<?php echo U('prize/plist?id=3&cid=4');?>" class="black_a1">汽车用品</a>
				&nbsp;&nbsp;
			</div>
			<div class="jpfl_xx">
				<a href="<?php echo U('prize/plist?id=4');?>">
					<strong>美妆时尚</strong>
				</a>
				<span>&nbsp;&nbsp;</span>
				<a href="<?php echo U('prize/plist?id=4&cid=1');?>" class="black_a1">护理保健</a>
				&nbsp;&nbsp;
				<a href="<?php echo U('prize/plist?id=4&cid=2');?>" class="black_a1">饰品钟表</a>
				&nbsp;&nbsp;
			</div>
			<div class="jpfl_xx">
				<a href="<?php echo U('prize/plist?id=5');?>">
					<strong>文体用品</strong>
				</a>
				<span>&nbsp;&nbsp;</span>
				<a href="<?php echo U('prize/plist?id=5&cid=1');?>" class="black_a1">体育娱乐</a>
				&nbsp;&nbsp;
				<a href="<?php echo U('prize/plist?id=5&cid=2');?>" class="black_a1">户外装备</a>
				&nbsp;&nbsp;
			</div>
			<div class="jpfl_xx">
				<a href="<?php echo U('prize/plist?id=6');?>">
					<strong>玩具礼品</strong>
				</a>
				<span>&nbsp;&nbsp;</span>
				<a href="<?php echo U('prize/plist?id=6&cid=1');?>" class="black_a1">玩具公仔</a>
				&nbsp;&nbsp;
				<a href="<?php echo U('prize/plist?id=6&cid=2');?>" class="black_a1">箱包礼品</a>
				&nbsp;&nbsp;
			</div>
			<div class="jpfl_xx">
				<a href="<?php echo U('prize/plist?id=7');?>">
					<strong>母婴用品</strong>
				</a>
				<span>&nbsp;&nbsp;</span>
				<a href="<?php echo U('prize/plist?id=7&cid=1');?>" class="black_a1">母婴日用</a>
				&nbsp;&nbsp;
				<a href="<?php echo U('prize/plist?id=7&cid=2');?>" class="black_a1">婴幼童车</a>
				&nbsp;&nbsp;
			</div>
			<div id="jpfl_xx" style="height:5px;line-height:5px;font-size:0px;overflow:hidden;margin-top:-1px; background-color:#fff">&nbsp;</div>
		</div>
	</div>
	<div class="djright_k">
		<div class="djright_t">
			<div class="l" style="background: url(__IMAGES__/prize/prize_h.png) left no-repeat;"></div>
			<div class="r">
				<a href="/serving/help_serviceTrade.aspx" target="_blank" class="a0">更多&gt;&gt;</a>
			</div>
		</div>
		<div class="djright_m">
			<span></span>
			<a href="/Serving/help_serviceTrade.aspx" target="_blank">如何兑换奖品？</a>
			<br>
			<span></span>
			<a href="/Serving/help_serviceTrade.aspx" target="_blank">奖品如何发放？</a>
			<br>
			<span></span>
			<a href="/Serving/help_serviceTrade.aspx" target="_blank">兑换奖品需要付快递费吗？</a>
			<br>
			<span></span>
			<a href="/Serving/help_serviceTrade.aspx" target="_blank">奖品什么时候能收到？</a>
			<br>
			<span></span>
			<a href="/Serving/help_serviceTrade.aspx" target="_blank">兑奖取消了金蛋会还我吗？</a>
		</div>
		<div class="djright_m" style="background:url(__IMAGES__/prize/dj_zx.gif) -8px top no-repeat;">
			<div class="line_dj">&nbsp;</div>
			<div class="djzx">
				<a href="http://www.pceggs.com/nbbs/bbsMain.aspx">
					<img src="__IMAGES__/prize/zx_an.gif" width="87" height="26" border="0"></a>
			</div>
		</div>
		<div class="djright_e"></div>
	</div>

	<div class="djright_k">
		<div class="djright_t">
			<div class="l" style="background: url(__IMAGES__/prize/prize_n.png) left no-repeat;"></div>
			<div class="r"></div>
		</div>
		<div class="djright_m">
			<div class="djright_m1">
				<div class="l">
					<span>&nbsp;</span>
					<a href="/pgComUserInfo.aspx?USERID=16054491" class="a2">16054491</a>
					兑换
					<a href="/prize/PrizeDetail.aspx?ISSUE=ZC0269" class="a2" title="联通话费100元直充         ">联通话费10</a>
				</div>
				<div class="r">3分钟前</div>
			</div>
			<div class="djright_m1">
				<div class="l">
					<span>&nbsp;</span>
					<a href="/pgComUserInfo.aspx?USERID=11154352" class="a2">11154352</a>
					兑换
					<a href="/prize/PrizeDetail.aspx?ISSUE=ZC0266" class="a2" title="移动话费100元直充         ">移动话费10</a>
				</div>
				<div class="r">3分钟前</div>
			</div>
			<div class="djright_m1">
				<div class="l">
					<span>&nbsp;</span>
					<a href="" class="a2">8402404</a>
					兑换
					<a href="" class="a2" title="小熊 电热锅多功能电蒸锅（DRG-C1021）         ">小熊 电热锅</a>
				</div>
				<div class="r">4分钟前</div>
			</div>
			<div class="djright_m1">
				<div class="l">
					<span>&nbsp;</span>
					<a href="/pgComUserInfo.aspx?USERID=8402404" class="a2">8402404</a>
					兑换
					<a href="/prize/PrizeDetail.aspx?ISSUE=SM1608" class="a2" title="爱国者移动电源K112(11200mAh)         ">爱国者移动电</a>
				</div>
				<div class="r">9分钟前</div>
			</div>
			<div class="djright_m1">
				<div class="l">
					<span>&nbsp;</span>
					<a href="/pgComUserInfo.aspx?USERID=16501642" class="a2">16501642</a>
					兑换
					<a href="/prize/PrizeDetail.aspx?ISSUE=ZC0269" class="a2" title="联通话费100元直充         ">联通话费10</a>
				</div>
				<div class="r">18分钟前</div>
			</div>
		</div>
		<div class="djright_e"></div>
	</div>
	<div class="djright_k">
		<div class="djright_t">
			<div class="l" style="background: url(__IMAGES__/prize/prize_f.png) left no-repeat;"></div>
			<div class="r">
				<a href="http://www.pceggs.com/ShowPrize/ShowList.aspx?topicid=2" class="a0">更多&gt;&gt;</a>
			</div>
		</div>
		<div class="djright_m" style="padding-bottom:0px;">
			<div style="width:205px; height:164px; border:1px solid #e5e7e6; margin:0 auto;">
				<a href="" target="_blank" class="a2">
					<img src="__IMAGES__/prize/dziPad4.jpg" width="205" height="164" border="0"></a>
			</div>
			<div style="text-align:center; line-height:36px; background:url(__IMAGES__/prize/dash.gif) repeat-x bottom; ">
				<a href="" target="_blank" class="a2">送老公的礼物，捷安特自行车！</a>
			</div>
		</div>
		<div class="djright_m">
			<span></span>
			<a href="" target="_blank">我的炊大皇，也是你的炊大皇！</a>
			<br>
			<span></span>
			<a href="" target="_blank">美的遥控电风扇，感谢蛋蛋！</a>
			<br>
			<span></span>
			<a href="" target="_blank">玩了几年蛋蛋，收获到了！</a>
			<br>
			<span></span>
			<a href="" target="_blank">我的永久26寸山地自行车！</a>
			<br>
			<span></span>
			<a href="" target="_blank">我也来嗮奖啦，感谢PC蛋蛋！</a>
			<br>
			<span></span>
			<a href="" target="_blank">看了蛋友兑换的毛毛虫，心也痒了！</a>
			<br>
			<span></span>
			<a href="" target="_blank">我的爱国者移动电源！</a>
		</div>
		<div class="djright_e"></div>
	</div>
</div>
			<div class="pcdjzx_con_right">
				<div class="djlc_h" id="area1" style="margin-top: 6px;">
	<img src="__IMAGES__/prize/djlc_bg_sw.png" border="0" usemap="#Map11">
	<map name="Map11" id="Map11">
		<area shape="rect" coords="126,5,225,25" href="javascript:changeimg(1)">
		<area shape="rect" coords="16,5,116,26" href="javascript:changeimg(2)"></map>
</div>
<div class="djlc_h" style="margin-top: 6px; display: none;" id="area2">
	<img src="__IMAGES__/prize/djlc_bg_xn.png" border="0" usemap="#Map12">
	<map name="Map12" id="Map12">
		<area shape="rect" coords="126,5,225,25" href="javascript:changeimg(1)">
		<area shape="rect" coords="16,5,116,26" href="javascript:changeimg(2)"></map>
</div>
<script>
	function changeimg(i){
		if(i==1){
			document.getElementById("area1").style.display="none";
			document.getElementById("area2").style.display="";
		}
		if(i==2){
			document.getElementById("area1").style.display="";
			document.getElementById("area2").style.display="none";
		}
	}
</script>
				<div class="xpsj">
					<div class="bt_xpsj">
						<div class="bt_xpsj_right">
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<a href="/prize/Prizelist.aspx?pid=-1" class="a0">更多&gt;&gt;</a>
						</div>
					</div>
					<div class="xpsj_con">
						<div class="xpsj_con_con">
							<ul style="position:relative;width:700px;">
								<li style="width:171px; float:left;margin-right:3px;">
									<div class="xpsj_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1623">
											<img src="__IMAGES__/prize/sSM1623.jpg" width="164" height="131" border="0" align="absmiddle"></a>
									</div>
									<div class="xpsj_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1623">戴尔灵越 14 5439</a>
										<br>
										<span style="color:#bd0000">567,000,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
								<li style="width:171px; float:left;margin-right:3px;">
									<div class="xpsj_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1609">
											<img src="__IMAGES__/prize/sSM1609.jpg" width="164" height="131" border="0" align="absmiddle"></a>
									</div>
									<div class="xpsj_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1609">三星 Galaxy S5 4G版</a>
										<br>
										<span style="color:#bd0000">638,375,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
								<li style="width:171px; float:left;margin-right:3px;">
									<div class="xpsj_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0665">
											<img src="__IMAGES__/prize/stfx-h0665.jpg" width="164" height="131" border="0" align="absmiddle"></a>
									</div>
									<div class="xpsj_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0665">格力机械冷风扇</a>
										<br>
										<span style="color:#bd0000">51,875,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
								<li style="width:171px; float:left;margin-right:3px;">
									<div class="xpsj_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0623">
											<img src="__IMAGES__/prize/stfx-h0623.jpg" width="164" height="131" border="0" align="absmiddle"></a>
									</div>
									<div class="xpsj_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0623">康贝斯玛特双向婴儿推车</a>
										<br>
										<span style="color:#bd0000">115,625,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
							</ul>
						</div>
					</div>
				</div>
				<div class="xpsj">
					<div class="bt_xpsj">
						<div class="bt_xpsj_right">
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<a href="/prize/Prizelist.aspx?pid=-1" class="a0">更多&gt;&gt;</a>
						</div>
					</div>
					<div class="xpsj_con">
						<div class="xpsj_con_con">
							<ul style="position:relative;width:700px;">

								<li style="width:171px; float:left;margin-right:3px;">
									<div class="xpsj_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1623">
											<img src="__IMAGES__/prize/sSM1623.jpg" width="164" height="131" border="0" align="absmiddle"></a>
									</div>
									<div class="xpsj_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1623">戴尔灵越 14 5439</a>
										<br>
										<span style="color:#bd0000">567,000,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
								<li style="width:171px; float:left;margin-right:3px;">
									<div class="xpsj_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1609">
											<img src="__IMAGES__/prize/sSM1609.jpg" width="164" height="131" border="0" align="absmiddle"></a>
									</div>
									<div class="xpsj_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1609">三星 Galaxy S5 4G版</a>
										<br>
										<span style="color:#bd0000">638,375,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
								<li style="width:171px; float:left;margin-right:3px;">
									<div class="xpsj_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0665">
											<img src="__IMAGES__/prize/stfx-h0665.jpg" width="164" height="131" border="0" align="absmiddle"></a>
									</div>
									<div class="xpsj_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0665">格力机械冷风扇</a>
										<br>
										<span style="color:#bd0000">51,875,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
								<li style="width:171px; float:left;margin-right:3px;">
									<div class="xpsj_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0623">
											<img src="__IMAGES__/prize/stfx-h0623.jpg" width="164" height="131" border="0" align="absmiddle"></a>
									</div>
									<div class="xpsj_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0623">康贝斯玛特双向婴儿推车</a>
										<br>
										<span style="color:#bd0000">115,625,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
							</ul>
						</div>
					</div>
				</div>
				<div class="jjsh">
					<div class="bt_jjsh">
						<div class="bt_xpsj_right">
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<a href="http://www.pceggs.com/prize/Prizelist.aspx?pid=3" class="a0">更多&gt;&gt;</a>
						</div>
					</div>
					<div class="jjsh_con">
						<div class="jjsh_con_con">
							<ul>
								<li>
									<div class="jjsh_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0671">
											<img src="__IMAGES__/prize/stfx-h0671.jpg" width="147" height="118" border="0" align="absmiddle"></a>
									</div>
									<div class="jjsh_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0671">梦之怡落地折叠蚊帐</a>
										<br>
										<span style="color:#bd0000">19,825,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
								<li>
									<div class="jjsh_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0666">
											<img src="__IMAGES__/prize/stfx-h0666.jpg" width="147" height="118" border="0" align="absmiddle"></a>
									</div>
									<div class="jjsh_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0666">格力遥控落地扇</a>
										<br>
										<span style="color:#bd0000">28,000,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
								<li>
									<div class="jjsh_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0658">
											<img src="__IMAGES__/prize/stfx-h0658.jpg" width="147" height="118" border="0" align="absmiddle"></a>
									</div>
									<div class="jjsh_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0658">苏泊尔炫彩不粘煎锅</a>
										<br>
										<span style="color:#bd0000">14,375,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
								<li class="jjsh_lw" style="border:0px;">
									<div class="jjsh_lwword" style="margin-bottom:15px;">
										<span class="dot">&nbsp;</span>
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0637">速腾水果冰淇淋机</a>
										&nbsp;&nbsp;
										<span style="color:#bd0000;">25,500,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
										<br>
										<span class="dot">&nbsp;</span>
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0655">美固P-24车载冰箱</a>
										&nbsp;&nbsp;
										<span style="color:#bd0000;">56,750,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
									<div class="jjsh_lwimg">
										<div class="jjsh_lwimg_l">
											<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0490">
												<img src="__IMAGES__/prize/stfx-h0490.jpg" width="65" height="52" border="0" align="absmiddle"></a>
										</div>
										<div class="jjsh_lwimg_r">
											<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0490">贝尔莱德蒸汽挂式机</a>
											<br>
											<span style="color:#bd0000;">44,125,000</span>
											<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
										</div>
									</div>
									<div class="jjsh_lwimg">
										<div class="jjsh_lwimg_l">
											<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0308">
												<img src="__IMAGES__/prize/stfx-h0308.jpg" width="65" height="52" border="0" align="absmiddle"></a>
										</div>
										<div class="jjsh_lwimg_r">
											<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=tfx-h0308">乐扣乐扣格拉斯便当盒</a>
											<br>
											<span style="color:#bd0000;">13,875,000</span>
											<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
										</div>
									</div>
								</li>
							</ul>
						</div>
					</div>
				</div>

				<div class="jjsh">
					<div class="bt_sjsm">
						<div class="bt_xpsj_right">
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<a href="http://www.pceggs.com/prize/Prizelist.aspx?pid=2" class="a0">更多&gt;&gt;</a>
						</div>
					</div>
					<div class="sjsm_con">
						<div class="jjsh_con_con">
							<ul>
								<li class="jjsh_lw" style="border:0px; width:210px; margin-left:0px;">
									<div class="jjsh_lwword">
										<span class="dot">&nbsp;</span>
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1399">AKG头戴耳机</a>
										&nbsp;&nbsp;
										<span style="color:#bd0000;">122,125,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
										<br>
										<span class="dot">&nbsp;</span>
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1579">索尼录音棒8G</a>
										&nbsp;&nbsp;
										<span style="color:#bd0000;">193,625,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
										<br>
										<span class="dot">&nbsp;</span>
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1371">ipod shuffle7</a>
										&nbsp;&nbsp;
										<span style="color:#bd0000;">50,000,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
									<div class="jjsh_lwimg">
										<div class="jjsh_lwimg_ll">
											<a href="http://www.pceggs.com/IndexMainStatic/shop/Pgshoplist.aspx?cid=4"></a>
											<img src="__IMAGES__/prize/sm.gif" width="202" height="100"></div>

									</div>
								</li>
								<li>
									<div class="jjsh_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1624">
											<img src="__IMAGES__/prize/sSM1624.jpg" width="147" height="118" border="0" align="absmiddle"></a>
									</div>
									<div class="jjsh_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1624">惠普Pavilion</a>
										<br>
										<span style="color:#bd0000">498,250,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
								<li>
									<div class="jjsh_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1602">
											<img src="__IMAGES__/prize/msM1602.jpg" width="147" height="118" border="0" align="absmiddle"></a>
									</div>
									<div class="jjsh_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1602">ipad mini2 32G</a>
										<br>
										<span style="color:#bd0000">478,000,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
								<li>
									<div class="jjsh_con_con_img">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1599">
											<img src="__IMAGES__/prize/mSM1599.jpg" width="147" height="118" border="0" align="absmiddle"></a>
									</div>
									<div class="jjsh_con_con_word">
										<a href="http://www.pceggs.com/prize/PrizeDetail.aspx?ISSUE=SM1599">佳能700D（18-55mm）</a>
										<br>
										<span style="color:#bd0000">590,500,000</span>
										<span class="eggs">&nbsp;&nbsp;&nbsp;&nbsp;</span>
									</div>
								</li>
							</ul>
						</div>
					</div>
				</div>
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