<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><!-- InstanceBegin template="/Templates/navi_temp.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<!-- InstanceBeginEditable name="doctitle" -->
<title>用户中心-专业的广告游戏平台</title>
<link rel="stylesheet" type="text/css" href="__CSS__/naviation.css" />
<link rel="stylesheet" type="text/css" href="__CSS__/user.css" />
<link rel="stylesheet" type="text/css" href="__CSS__/footer.css" />

<script type="text/javascript" src="__JS__/main.js"></script>
<!-- InstanceEndEditable -->
<!-- InstanceBeginEditable name="head" -->
<!-- InstanceEndEditable -->
</head>

<body>
<div id="header">
    <div id="navi_top">
        <div id="navi_topl">
            <ul>
                <li><a href="/iphone/iphoneindex.aspx" class="navi_top_img_phone">手机版</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a href="http://www.yy365.com/" target="_black" onclick="doSomething(event);">同玩社区</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a class="sheader_red" href="/vip/vip_index.aspx" onclick="doSomething(event);">VIP会员</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a href="/activity/Activity.aspx" target="_parent" onclick="doSomething(event);">蛋友活动</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a href="/Serving/help_servicemain.aspx" target="_parent" onclick="doSomething(event);">客服中心</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a href="#" onclick="addfavorite()">收藏</a></li>
            </ul>
        </div>
        <div id="navi_topr">
            <ul>
                <li><a href="/newone/PgQCoinReg.aspx" onclick="doSomething(event);">注册</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a  id="fc_loginHead" style="cursor:pointer"  onclick="doSomething(event);">登录</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li>您好，欢迎你的光临！</li>
            </ul>
        </div>
    </div>
    <!--logo guanggaobg-->
    <div id="navi_mid"  >
        <a href="#"><div id="navi_midl"></div></a>
        <a href="#"><div id="navi_midm"></div></a>
        <a href="#"><div id="navi_midr"></div></a>
    </div>
    <!--daohang-->
    <div id="navi_bottom">
    	<div id="navi_bottom_content">
            <ul id="main_nav">
                <li><a class="navibar_1" href="<?php echo U('/index');?>" target="_parent" onclick="doSomething(event);">首&nbsp&nbsp页</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a class="navibar_2" href="<?php echo U('/ad');?>" target="_parent" onclick="doSomething(event);">广告体验</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a class="navibar_3" href="<?php echo U('/buy');?>" target="_parent" onclick="doSomething(event);">蛋蛋团购</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a class="navibar_4" href="<?php echo U('/game');?>" target="_parent" onclick="doSomething(event);">游戏竞猜</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a class="navibar_5" href="<?php echo U('/activity');?>" target="_parent" onclick="doSomething(event);">活动中心</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a class="navibar_6" href="<?php echo U('/prize');?>" target="_parent" onclick="doSomething(event);">兑换中心</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a class="navibar_7" href="<?php echo U('/user');?>" target="_parent" onclick="doSomething(event);">个人中心</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a class="navibar_8" href="<?php echo U('/glory');?>" onclick="addfavorite()">晒奖</a></li>
            </ul>
            <ul class="main_navr">
                <li><a class="navibar_11" href="<?php echo U('/help');?>" target="_parent" onclick="doSomething(event);">帮助</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a class="navibar_10" href="<?php echo U('/invest');?>" target="_parent" onclick="doSomething(event);">推广有奖</a></li>
                <li class="sheader_line">&nbsp;</li>
                <li><a class="navibar_9" href="<?php echo U('/bbs');?>" target="_parent" onclick="doSomething(event);">讨论区</a></li>
            </ul>
    	</div>
    </div>
</div>
<style type="text/css">
  .navibar_<?php echo ($curID); ?>{color: #ff0000; font-weight:bold;}
</style>
<!--------------------------------------------------->
<div id="body_content">
<!-- InstanceBeginEditable name="content" -->
    <table width="950" border="0" align="center" cellpadding="0" cellspacing="0">
        <tbody>
            <tr>
                <td width="224" valign="top" class="border1">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tbody>
                            <tr>
                                <td width="33%" height="40" align="right">
                                    <img src="__IMAGES__/user/wlm.png"></td>
                                <td width="67%" align="left">
                                    <span class="font16">&nbsp;用户中心</span>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <div class="navuser">
                        <ul>
                            <li class="nav_tuan">我的账户</li>
                            <li>
                                <a href="#" class="currents">账户概况</a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/usermoney.php">收支明细</a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/usercoffers.php">我的银行</a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/userprizes.php">兑奖记录</a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/action_reward.php">争霸赛领奖</a>
                            </li>
                        </ul>
                    </div>
                    <div class="navuser">
                        <ul>
                            <li class="nav_tuan">我的赚星</li>
                            <li>
                                <a href="http://www.aoyene.cc/go666.php">
                                    <font color="green"><b>充值返利</b></font> 
                                </a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/userfriends.php">下线收益</a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/gongzi.php">我的工资</a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/redbag.php">抢红包</a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/all_bag.php">超级全包</a>
                            </li>
                        </ul>
                    </div>

                    <div class="navuser">
                        <ul>
                            <li class="nav_tuan">个人信息安全</li>
                            <li>
                                <a href="http://www.aoyene.cc/userauth.php?k=3">手机认证</a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/userauth.php?k=2">登陆密码修改</a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/edit_sec_pwd.php">
                                    <font color="red"><b>二级密码修改</b></font> 
                                </a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/mibao_protect.php">
                                    <font color="red">
                                        <b>密保设置</b>
                                    </font>
                                </a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/edit_dj_protect.php">
                                    <font color="red">
                                        <b>兑奖验证方式</b>
                                    </font>
                                </a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/free_pwd_protect.php">
                                    <font color="red">
                                        <b>动态密码保护</b>
                                    </font>
                                </a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/login_local_protect.php">
                                    <font color="red">
                                        <b>登陆地区保护</b>
                                    </font>
                                </a>
                            </li>
                            <li>
                                <a href="http://www.aoyene.cc/userauth.php?k=1">修改资料</a>
                            </li>
                        </ul>
                    </div>
                </td>
                <td width="10"></td>
                <td width="714" valign="top">
                    <div class="colgroup leading">
                        <div class="column width3 first">
                            <h3>
                                尊敬的&nbsp;&nbsp;
                                <font class="orangeFont">dingyong4223</font>
                                &nbsp;&nbsp;&nbsp;欢迎您来到遨夜网
                            </h3>
                            <p>
                                流动星星：
                                <span class="red14">0</span>
                                <img src="__IMAGES__/user/star.png" width="14" height="14">
                                &nbsp;&nbsp;&nbsp;
                            银行星星：
                                <span class="red14">0</span>
                                <img src="__IMAGES__/user/star.png" width="14" height="14"></p>

                        </div>
                        <div class="column width3">
                            <h3>
                                最后登陆时间&nbsp;
                                <span class="red">2014-06-03 21:37:02</span>
                            </h3>

                            <p>
                                经验值：
                                <span class="red14">0(累积0)</span>
                                &nbsp;
                                <img src="__IMAGES__/user/vip_0.gif" align="absmiddle" border="0">
                                &nbsp;
                                <span class="rightcss">
                                    <a href="http://www.aoyene.cc/gongzi.php">领取今日工资</a>
                                </span>
                            </p>
                        </div>

                    </div>

                    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" class="border1">
                        <tbody>
                            <tr>
                                <td height="37" valign="middle" background="__IMAGES__/user/lefttitlebghui.gif" style="padding-right: 10px;">
                                    <div class="ad_fanli">
                                        <ul class="ad_tit">
                                            <li class="current">
                                                <a href="http://www.aoyene.cc/useraccount.php#">站内公告</a>
                                            </li>
                                        </ul>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <div class="admin">
                                        <ul class="ann_list">
                                            <li class="title">
                                                <span>发布时间</span>
                                                标题
                                            </li>
                                            <li>
                                                <a href="http://www.aoyene.cc/newsDetailed.php?id=75" title="[端午狂欢]遨夜网，登录有奖，上榜有奖，推广有奖，玩手机有奖，送龙号" target="_blank">
                                                    <span>2014-05-28</span>
                                                    [端午狂欢]遨夜网，登录有奖，上榜有奖，推广有奖，玩手机有奖，送龙号
                                                </a>
                                            </li>
                                            <li>
                                                <a href="http://www.aoyene.cc/newsDetailed.php?id=74" title="[通知]新增36u充值返利功能" target="_blank">
                                                    <span>2014-05-26</span>
                                                    [通知]新增36u充值返利功能
                                                </a>
                                            </li>
                                            <li>
                                                <a href="http://www.aoyene.cc/newsDetailed.php?id=73" title="[争霸]遨夜天下无双争霸赛第十三届明天开始" target="_blank">
                                                    <span>2014-05-25</span>
                                                    [争霸]遨夜天下无双争霸赛第十三届明天开始
                                                </a>
                                            </li>
                                        </ul>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <br>
                    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" class="border1">
                        <tbody>
                            <tr>
                                <td height="32" valign="top" background="__IMAGES__/user/lefttitlebg.gif">
                                    <div class="ad_fanli">
                                        <ul class="ad_tit">
                                            <li>
                                                <span class="font16">&nbsp;收支明细</span>
                                            </li>
                                        </ul>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#DFE2E7" class="table_user">
                        <tbody>
                            <tr align="center">
                                <th width="20%">时间</th>
                                <th width="30%">操作</th>
                                <th width="10%">影响星星</th>
                                <th width="10%">影响经验</th>
                                <th width="20%">星星总额</th>
                                <th width="10%">经验总额</th>
                            </tr>
                        </tbody>
                    </table>
                    <br>
                    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" class="border1">
                        <tbody>
                            <tr>
                                <td height="32" valign="top" background="__IMAGES__/user/lefttitlebg.gif">
                                    <div class="ad_fanli">
                                        <ul class="ad_tit">
                                            <li>
                                                <span class="font16">&nbsp;奖品兑换</span>
                                            </li>
                                        </ul>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#DFE2E7" class="table_user">
                        <tbody>

                            <tr align="center">
                                <th width="40%">奖品名称</th>
                                <th width="15%">兑奖数量</th>
                                <th width="15%">兑奖时间</th>
                                <th width="15%">状态</th>
                                <th width="15%">操作</th>
                            </tr>

                        </tbody>
                    </table>
                    <br>
                    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" class="border1">
                        <tbody>
                            <tr>
                                <td height="32" valign="top" background="__IMAGES__/user/lefttitlebg.gif">
                                    <div class="ad_fanli">
                                        <ul class="ad_tit">
                                            <li>
                                                <span class="font16">&nbsp;登陆日志</span>
                                            </li>
                                        </ul>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#DFE2E7" class="table_user">
                        <tbody>

                            <tr align="center">
                                <th width="30%">登陆地区</th>
                                <th width="40%">ip</th>
                                <th width="30%">时间</th>
                            </tr>
                            <tr align="center">
                                <td class="red">广东省深圳市 联通</td>
                                <td class="#F9FAFC">112.95.25.50</td>
                                <td class="green">2014-06-04 12:57:08</td>
                            </tr>
                            <tr align="center">
                                <td class="red">广东省深圳市 电信</td>
                                <td class="#F9FAFC">183.62.196.12</td>
                                <td class="green">2014-06-03 16:39:12</td>
                            </tr>
                            <tr align="center">
                                <td class="red">广东省深圳市 联通</td>
                                <td class="#F9FAFC">58.251.249.33</td>
                                <td class="green">2014-05-27 22:43:53</td>
                            </tr>
                            <tr align="center">
                                <td class="red">广东省深圳市 电信</td>
                                <td class="#F9FAFC">183.62.196.12</td>
                                <td class="green">2014-05-27 12:41:28</td>
                            </tr>
                            <tr align="center">
                                <td class="red">广东省深圳市 电信</td>
                                <td class="#F9FAFC">183.62.196.12</td>
                                <td class="green">2014-05-26 14:14:27</td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
<!-- InstanceEndEditable -->
</div>
    
<!-- InstanceBeginEditable name="footer" -->
      <!-- #BeginLibraryItem "/Library/footer_1.lbi" -->      
      <div class="footer">
          <p>关于比蛋 | 服务条款 | 客服中心 | 新手帮助</p>
          <p>
              Copyright © 2009 - 2012 dingdong.com dingdong.net 深ICP备12055565号 ICP:深B2-20120226
          </p>
          <p>比蛋-深圳网络有限公司</p>
      </div>
      <!-- #EndLibraryItem -->
<!-- InstanceEndEditable -->
</body>
<!-- InstanceEnd --></html>