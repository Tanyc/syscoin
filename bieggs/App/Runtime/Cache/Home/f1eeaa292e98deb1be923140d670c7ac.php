<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title>兑奖中心-专业的广告游戏平台</title>
	<link rel="stylesheet" type="text/css" href="__CSS__/plist.css" />
	<script type="text/javascript" src="__JS__/com.js"></script>
	<script type="text/javascript" src="__JS__/plist.js"></script>
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
	<script type="text/javascript">
		var img_path = '__IMAGES__';
	</script>
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
				<div class="djlc_ssk">
					类目&nbsp;
					<select name="pidlist" id="pidlist" style="width:75px" onchange="setpid(this.value)">
						<option value="">全部</option>
						<option value="-1">新品上架</option>
						<option selected="selected" value="1">虚拟奖品</option>
						<option value="2">数码产品</option>
						<option value="3">居家生活</option>
						<option value="5">美妆时尚</option>
						<option value="4">文体用品</option>
						<option value="6">玩具礼品</option>
						<option value="30">母婴用品</option>
					</select>
					-
					<select name="cid" id="cid" style="width:75px">
						<option value="">全部</option>
						<option value="191">游戏充值</option>
						<option value="58">QQ业务</option>
						<option value="11">QQ充值</option>
						<option value="12">游戏点卡</option>
						<option value="10" selected="">手机充值</option>
					</select>
					&nbsp;&nbsp;&nbsp;金蛋&nbsp;
					<input name="LowGoldeggs" type="text" id="LowGoldeggs" size="8">
					&nbsp;-&nbsp;
					<input name="HighGoldeggs" type="text" id="HighGoldeggs" size="8">
					&nbsp;&nbsp;&nbsp;奖品名称&nbsp;
					<input name="tradename" type="text" id="tradename" size="8">
					&nbsp;&nbsp;&nbsp;
					<a class="black_enter" href="javascript:TradeSearch(0);">
						<span>马上搜索</span>
					</a>
				</div>

				<div class="djpx">
					<div style="float:left;">
						<ul class="sorting-btns">
							<li>
								<a href="javascript:TradeSearch(1)" class="sx_j crt">
									<span>兑奖人数</span>
								</a>
							</li>
							<li>
								<a href="javascript:TradeSearch(2)" class="sx_z">
									<span>金蛋</span>
								</a>
							</li>
							<li>
								<a href="javascript:TradeSearch(3)" class="sx_z">
									<span>上架时间</span>
								</a>
							</li>
						</ul>
					</div>
				</div>

				<div class="jplb">
					<div class="jplb_con_con">
						<ul>
							<?php if(is_array($db_prize)): $i = 0; $__LIST__ = $db_prize;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i;?><li>
									<div class="jplb_con_con_img">
										<a href="javascript:genPHref(<?php echo ($vo["id"]); ?>)" title=<?php echo ($vo["name"]); ?>>
<script type="text/javascript">
	showLogImg('<?php echo ($vo["des_img"]); ?>');</script>
										</a>
									</div>
									<div class="jplb_con_con_word">
										<a href="javascript:genPHref(<?php echo ($vo["id"]); ?>)" title=<?php echo ($vo["name"]); ?>>
											<?php echo ($vo["name"]); ?>
										</a>
										<br>
										<span style="color:#bd0000">
										<script type="text/javascript">
										document.write(ver(<?php echo ($vo["cost_eggs"]); ?>));
										</script>
										</span>
										<img src="__IMAGES__/public/egg.png"/>
									</div>
								</li><?php endforeach; endif; else: echo "" ;endif; ?>
						</ul>
					</div>
					<form name="pgindex" method="post" action="__URL__/plist" id="pgindex">
						<input id="id" name="id" type="hidden" value="">
						<input id="cid" name="cid" type="hidden" value="">
						<input id="pg" name="pg" type="hidden" value=""></form>
					<form name="pdesc" method="post" action="__URL__/pdesc" id="pdesc">
						<input id="pid" name="pid" type="hidden" value=""></form>
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