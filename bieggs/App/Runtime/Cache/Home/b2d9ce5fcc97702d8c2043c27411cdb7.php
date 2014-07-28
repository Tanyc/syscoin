<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title>用户中心-专业的广告游戏平台</title>
	<link rel="stylesheet" type="text/css" href="__CSS__/usercom.css" />
	<link rel="stylesheet" type="text/css" href="__CSS__/account.css" />
	<script type="text/javascript" src="__JS__/Jquery/jquery-1.6.2.min.js"></script>
	<script type="text/javascript" src="__JS__/user/usercom.js"></script>
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
	<script type="text/javascript"></script>
	<div id="body_content">
		<div class="wal">
			<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="__CSS__/usernavi.css" />
    <script type="text/javascript" src="__JS__/Jquery/jquery-1.6.2.min.js"></script>
    <script type="text/javascript" src="__JS__/usernavi.js"></script>
</head>
<script type="text/javascript">
  var navi_i = <?php echo ($PAGE_NAVII); ?>;
</script>
<div class="helpNav">
  <div class="title">
    会员中心 <i>Member Center</i>
  </div>
  <h5>
    <a href="">会员信息</a>
  </h5>
  <div class="list">
    <ul>
      <li>
        <a href="<?php echo U('user/index');?>">基本信息</a>
      </li>
      <li>
        <a href="<?php echo U('user/account');?>">账号明细</a>
      </li>
      <li>
        <a href="<?php echo U('user/myprize');?>">我的兑奖</a>
      </li>
      <li>
        <a href="<?php echo U('user/edit');?>">修改资料</a>
      </li>
      <li>
        <a href="<?php echo U('user/secure');?>">身份认证/绑定手机</a>
      </li>
      <li>
        <a href="<?php echo U('user/userpwd');?>">修改密码/密保</a>
      </li>
    </ul>
  </div>

  <h5>
    <a href="">广告管理</a>
  </h5>
  <div class="list">
    <ul>
      <li>
        <a href="<?php echo U('user/putad');?>">投放广告</a>
      </li>
      <li>
        <a href="<?php echo U('user/myad');?>">我的广告</a>
      </li>
      <li>
        <a href="<?php echo U('user/desad');?>">广告介绍</a>
      </li>
    </ul>
  </div>
  <h5>
    <a href="">道具/奖励</a>
  </h5>
  <div class="list">
    <ul>
      <li>
        <a href="<?php echo U('user/tooluse');?>">道具使用</a>
      </li>
      <li>
        <a href="<?php echo U('user/vipget');?>">VIP每日奖励领取</a>
      </li>
      <li>
        <a href="<?php echo U('user/salary');?>">工资领取</a>
      </li>
      <li>
        <a href="<?php echo U('user/myfriend');?>">我的好友</a>
      </li>
      <li>
        <a href="<?php echo U('user/invite');?>">推广收益</a>
      </li>
    </ul>
  </div>
</div>
<script>
$(document).ready(function(){
    $(".list ul li a").each(function(i){
    if (navi_i == i) {
      $(this).attr("class", "aNow");
      $(this).attr("href", "");
    }
  });
});
</script>
			<div class="content_r">
				<div class="H_top"> <b>我的账户</b>
				</div>
				<div class="H_l_top">
					<span>
						<a href="javascript:setData(1);" id="tab1">我的帐户</a>
					</span>
					<span>
						<a href="javascript:setData(2);" id="tab2">游戏明细</a>
					</span>
					<span>
						<a href="javascript:setData(3);" id="tab3">获取明细</a>
					</span>
					<span>
						<a href="javascript:setData(4);" id="tab4">消费明细</a>
					</span>
					<span>
						<a href="javascript:setData(5);" id="tab5">其他记录</a>
					</span>
					<span>
						<a href="javascript:setData(6);" id="tab6">其他经验</a>
					</span>
					<span>
						<a href="javascript:setData(7);" id="tab7">有效股票</a>
					</span>

				</div>
				<table width="770" border="1" cellpadding="0" cellspacing="0" class="datatableK center mt10" bordercolor="#f1cb95">
					<tbody>
						<tr align="center" height="33px">
							<td width="25%" align="center" class="tdstyle">金蛋获取/消费</td>
							<td width="20%" align="center" class="tdstyle">金蛋数量</td>
							<td width="20%" align="center" class="tdstyle">账户余额</td>
							<td width="15%" align="center" class="tdstyle">时间</td>
						</tr>

						<tr class="font_bgrave" height="30">
							<td height="20" align="center" bgcolor="#FFFFFF">签到获得吧币!送2积分</td>
							<td align="center" bgcolor="#FFFFFF">
								<span class="c1 b1">10</span>
								&nbsp;
								<img src="../static/style/guobi.gif"></td>
							<td align="center" bgcolor="#FFFFFF">
								<span class="c1 b1">50</span>
								&nbsp;
								<img src="../static/style/guobi.gif"></td>
							<td align="center" bgcolor="#FFFFFF">2014-7-14 12:55:48</td>
						</tr>

					</tbody>
				</table>
				<div id="spage" style="width:98%">
					<span>总记录数:1条</span>
					<a href="/user/account.asp?m=&amp;page=1" id="spage_hv">1</a>
				</div>
			</div>
		</div>
	</div>
<script>
$(document).ready(function(){
	var sub_tab = <?php echo ($SUB_TAB); ?>;
    $(".H_l_top span a").each(function(i){
    if (sub_tab == i) {
      $(this).attr("class", "a_bg1");
      $(this).attr("href", "");
    }
  });
});
</script>
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