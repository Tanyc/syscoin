<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title>用户中心-专业的广告游戏平台</title>
	<link rel="stylesheet" type="text/css" href="__CSS__/usercom.css" />
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
	<script type="text/javascript">var img_path = '__IMAGES__';</script>
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
				<div class="H_top"> <b>投放广告</b>
				</div>
				<div class="H_l_top">
					<span>
						<a href="javascript:setData(1);" id="tab1" class="a_bg1">广告编辑</a>
					</span>
					<span>
						<a href="javascript:setData(2);" id="tab2">已投放广告列表</a>
					</span>
				</div>
				<div id="imfo_edit1" style="padding-top: 10px;">
					<table width="770px" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#CCCCCC">
							<tbody>
								<tr>
									<td width="200" height="36px" align="right" bgcolor="#f4f4f4">姓名：</td>
									<td align="left" bgcolor="#FFFFFF" style="width: 529px; padding-left:10px">丁雍</td>
								</tr>
								<tr>
									<td width="200" height="36px" align="right" bgcolor="#f4f4f4">所在城市：</td>
									<td align="left" bgcolor="#FFFFFF" style="width: 529px">
										&nbsp;&nbsp;
										<script language="JavaScript" src="/js/myaccount/Area.js" type="text/javascript"></script>
										<select name="PROVINCE" id="PROVINCE" onchange="ChangeCity(this.options[this.selectedIndex].value,'')">
											<option value="">=请选择=</option>
											<option value="北京">北京</option>
											<option value="上海">上海</option>
											<option value="天津">天津</option>
											<option value="重庆">重庆</option>
											<option value="河北">河北</option>
											<option value="山西">山西</option>
											<option value="辽宁">辽宁</option>
											<option value="吉林">吉林</option>
											<option value="黑龙江">黑龙江</option>
											<option value="江苏">江苏</option>
											<option value="浙江">浙江</option>
											<option value="安徽">安徽</option>
											<option value="福建">福建</option>
											<option value="江西">江西</option>
											<option value="山东">山东</option>
											<option value="河南">河南</option>
											<option value="湖北">湖北</option>
											<option value="湖南">湖南</option>
											<option value="广东">广东</option>
											<option value="甘肃">甘肃</option>
											<option value="陕西">陕西</option>
											<option value="内蒙古">内蒙古</option>
											<option value="广西">广西</option>
											<option value="四川">四川</option>
											<option value="贵州">贵州</option>
											<option value="云南">云南</option>
											<option value="西藏">西藏</option>
											<option value="海南">海南</option>
											<option value="宁夏">宁夏</option>
											<option value="青海">青海</option>
											<option value="新疆">新疆</option>
											<option value="香港">香港</option>
											<option value="澳门">澳门</option>
											<option value="台湾">台湾</option>
											<option value="海外">海外</option>
										</select>
										<select style="width:80px;" name="CITY" id="CITY">
											<option>=城市=</option>
										</select>
										市
										<span style="color: Red">*</span>
									</td>
								</tr>
								<tr>
									<td width="200" height="60px" align="right" bgcolor="#f4f4f4">街道地址：</td>
									<td align="left" bgcolor="#FFFFFF" style="width: 529px">
										<textarea name="ADDRESS" id="ADDRESS" class="input_text" style="width: 300px;height:50px;"></textarea>
										<span style="color: Red">*</span>
										不需要重复填写省/市
									</td>
								</tr>
								<tr>
									<td width="200" height="36px" align="right" bgcolor="#f4f4f4">邮政编码：</td>
									<td align="left" bgcolor="#FFFFFF" style="width: 529px">

										<input name="PCODE" type="text" id="PCODE" maxlength="6" class="input_text" value="" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" onkeyup="testnum('PCODE')">
										<span style="color: Red">*</span>
										大陆以外可不填写
									</td>
								</tr>
								<tr valign="middle">
									<td width="200" height="36px" align="right" bgcolor="#f4f4f4">联系方式：</td>
									<td align="left" bgcolor="#FFFFFF" style="width: 529px" valign="center">
										<div style="width:80px;float:left;">
											&nbsp;
											<input value="radio_tel1" name="radio_tel" type="radio" id="radio_tel1" checked="checked" onclick="radioclick(1)">
											&nbsp;手机号码
                                           &nbsp;
											<input value="radio_tel2" name="radio_tel" type="radio" id="radio_tel2" onclick="radioclick(2)">&nbsp;电话号码</div>
										<div style="width:400px;float:left;padding-top:10px;">
											<span id="span_tel1">
												<input name="TEL" type="text" id="TEL" maxlength="11" class="input_text" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" onkeyup="testnum('TEL')">输入手机号码</span>
											<span id="span_tel2" style="display:none;">
												<input name="tel1" type="text" id="tel1" maxlength="5" class="input_text" style="width:50px;" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" onkeyup="testnum('tel1')">
												－
												<input name="tel2" type="text" id="tel2" maxlength="10" class="input_text" style="width:80px;margin-left:0px;" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" onkeyup="testnum('tel2')">
												－
												<input name="tel3" type="text" id="tel3" maxlength="6" class="input_text" style="width:50px;margin-left:0px;" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))" onkeyup="testnum('tel3')">区号-电话号码-分机</span>

										</div>

									</td>
								</tr>
								<tr>
									<td width="200" height="36px" align="right" bgcolor="#f4f4f4">你的认证手机号码为：</td>
									<td align="left" bgcolor="#FFFFFF" style="width: 529px; padding-left :10px;">
										159*********
										<span id="GetMCode_Mail">
											<a class="black_enter">
												<span onclick="sendcode('GetMCode_Mail',17)">发送验证码</span>
											</a>
										</span>
										&nbsp;&nbsp;&nbsp;
										<a href="/myaccount/changemymobile.aspx">
											<span style="color:Blue;">修改认证手机</span>
										</a>
									</td>
								</tr>
								<tr>
									<td width="200" height="36px" align="right" bgcolor="#f4f4f4">手机验证码：</td>
									<td align="left" bgcolor="#FFFFFF" style="width: 529px">
										<input name="IDCARD" type="text" id="IDCARD" maxlength="10" style=" width:80px;" class="input_text" value="">&nbsp;</td>
								</tr>
							</tbody>
						</table>
						<table width="770px" border="0" align="center" cellpadding="0" cellspacing="0">
							<tbody>
								<tr>
									<td width="170" height="50" align="right">设为默认：</td>
									<td width="111" height="50" align="left">
										<input name="ISDEFAULT" type="checkbox" id="ISDEFAULT">&nbsp;&nbsp;</td>
									<td width="405" height="50" align="left">
										&nbsp;&nbsp;
										<input type="image" name="ImageButton1" id="ImageButton1" src="/bidan/bieggs/Public/Images/public/bnt_save.gif" onclick="return sub();" style="border-width:0px;"></td>

								</tr>

							</tbody>
						</table>
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