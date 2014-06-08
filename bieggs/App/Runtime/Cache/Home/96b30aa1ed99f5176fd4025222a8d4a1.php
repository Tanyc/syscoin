<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><!-- InstanceBegin template="/Templates/navi_temp.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<!-- InstanceBeginEditable name="doctitle" -->
    <title>团购-专业的广告游戏平台</title>
    <link rel="stylesheet" type="text/css" href="__CSS__/naviation.css" />
    <link rel="stylesheet" type="text/css" href="__CSS__/com.css" />
    <link rel="stylesheet" type="text/css" href="__CSS__/footer.css" />
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
            <script type="text/javascript" src="__JS__/game/textrun.js"></script>
        </div>
        <div id="help_body">
            <table width="950" border="0" align="center" cellpadding="0" cellspacing="0">
                <tbody>
                    <tr>
                        <td width="160" valign="top" class="border1">
                            <table width="100%" border="0" align="center" bgcolor="#F1F1F1" style="color: #999999">
                                <tbody>
                                    <tr>
                                        <td align="right">
                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/wlm.png"></td>
                                        <td align="left">
                                            <span class="font16">&nbsp;admin</span>
                                        </td>
                                    </tr>
                                    <tr align="center" height="140px">
                                        <td colspan="2">
                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/noavatar_middle.gif" style="border-style: dotted;"></td>
                                    </tr>
                                    <tr align="center">
                                        <td colspan="2">
                                            <br>admin：当前离线</td>
                                    </tr>
                                    <tr align="center">
                                        <td colspan="2">注册时间：2012-05-17</td>
                                    </tr>
                                    <tr align="center">
                                        <td colspan="2">最后登陆：2014-06-05</td>
                                    </tr>
                                </tbody>
                            </table>
                        </td>
                        <td>
                            <table>
                                <tbody>
                                    <tr>
                                        <td> <b style="font-size: 20px">[帮助] 遨夜网新手帮助</b> <font style="font-size: 12px; color: #999999"><br>
                                                <br>&nbsp;&nbsp;发表时间：2014-06-01</font>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding: 30px; font-size: 15px">
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px"> <font color="#009900" size="4"><strong>遨夜网新手帮助：</strong></font> 
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#009900"> <strong>兑奖条件：</strong>
                                                    经验值大于50可以兑奖</font> 
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); PADDING-BOTTOM: 0px; PADDING-TOP: 0px; FONT: 12px Arial, Helvetica, sans-serif; PADDING-LEFT: 0px; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#009900">
                                                    <strong>兑换比例：</strong>
                                                    1000:1
                                                </font>
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); PADDING-BOTTOM: 0px; PADDING-TOP: 0px; FONT: 12px Arial, Helvetica, sans-serif; PADDING-LEFT: 0px; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#009900"></font>
                                                &nbsp;
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); PADDING-BOTTOM: 0px; PADDING-TOP: 0px; FONT: 12px Arial, Helvetica, sans-serif; PADDING-LEFT: 0px; MARGIN: 0px; LETTER-SPACING: normal; PADDING-RIGHT: 0px; BACKGROUND-COLOR: rgb(255,255,255); TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#009900">
                                                    <strong>兑换时间：</strong>
                                                    凌晨0点30分-9点暂停兑奖
                                                </font>
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#009900">
                                                    <strong>可以有几个账号：</strong>
                                                    每人最多1个账号，不允许操作多个帐号对刷排行榜。
                                                </font>
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#009900">
                                                    <strong>单期游戏投注上限：10</strong>
                                                    00万星星
                                                </font>
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#009900">
                                                    <strong>如何升级vip：</strong>
                                                </font>
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#009900">1.使用36u返利：每2000星星获取1个经验值。 （只有使用代理卡密才有经验，自己兑奖自己充值无经验）。</font>
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#009900">2.每期盈利超过10000星星获取1个经验，超过50000星星获取2经验，超过100000星星获取3经验。</font>
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                充值升级到vip5后，不再增加经验值，
                                                <br>不能直接充值升级龍帐号，升级龍号需要提交id给客服审核。</p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#009900">
                                                    <strong>Vip会员福利：</strong>
                                                </font>
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px"></p>
                                            <table style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px Arial, Helvetica, sans-serif; MARGIN: 10px 0px; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px" cellspacing="1" cellpadding="0" width="100%" bgcolor="#dfe2e7">
                                                <tbody>
                                                    <tr align="center" bgcolor="#f3f3f3">
                                                        <th style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)" height="40">等级</th>
                                                        <th style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">经验值</th>
                                                        <th style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">每日抢红包数</th>
                                                        <th style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">救济</th>
                                                        <th style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">兑奖</th>
                                                    </tr>
                                                    <tr align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)" height="30">
                                                            <img style="FONT-SIZE: 12px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px" src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_0.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">0经验</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">0个</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">30*3次</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">1.040</td>
                                                    </tr>
                                                    <tr align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)" height="30">
                                                            <img style="FONT-SIZE: 12px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px" src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_1.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">200经验</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">1个</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">30*3次</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">1.040</td>
                                                    </tr>
                                                    <tr align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)" height="30">
                                                            <img style="FONT-SIZE: 12px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px" src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_2.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">1000经验</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">1个</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">30*3次</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">1.040</td>
                                                    </tr>
                                                    <tr align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)" height="30">
                                                            <img style="FONT-SIZE: 12px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px" src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_3.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">3000经验</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">2个</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">100*3次</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">1.040</td>
                                                    </tr>
                                                    <tr align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)" height="30">
                                                            <img style="FONT-SIZE: 12px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px" src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_4.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">8000经验</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">4个</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">100*3次</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">1.040</td>
                                                    </tr>
                                                    <tr align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)" height="30">
                                                            <img style="FONT-SIZE: 12px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px" src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_5.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">20000经验</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">5个</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">100*3次</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">1.040</td>
                                                    </tr>
                                                    <tr align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)" height="30">
                                                            <img style="FONT-SIZE: 12px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; MARGIN: 0px; PADDING-RIGHT: 0px" src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_6.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">50000经验</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">6个</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">100*3次</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">1.000</td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                            <p></p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <br>
                                                <font color="#339900">
                                                    <strong>奖励规则：
                                                        <br></strong>
                                                    推荐下线有充值2%奖励+额外508万星星额外升级奖励
                                                </font>
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px"></p>
                                            <table style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0); MARGIN-TOP: 10px" cellspacing="1" cellpadding="0" width="100%" bgcolor="#f1cb95" border="0">
                                                <tbody>
                                                    <tr height="34" align="left" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)" colspan="4"> <b>推广奖励说明:</b>
                                                            <font color="red">（ 成功推荐一位好友可获得2%的充值奖励,您还将获得最多580,000星星的好友升级奖励。 ）</font>
                                                        </td>
                                                    </tr>
                                                    <tr height="34" align="center">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)" background="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/lefttitlebg.gif">等级</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)" background="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/lefttitlebg.gif">经验值</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)" background="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/lefttitlebg.gif">升级奖励</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)" background="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/lefttitlebg.gif">充值奖励</td>
                                                    </tr>
                                                    <tr height="30" align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_0.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">0</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            0&nbsp;
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/star.png"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">2%</td>
                                                    </tr>
                                                    <tr height="30" align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_1.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">200-999</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            10,000&nbsp;
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/star.png"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">2%</td>
                                                    </tr>
                                                    <tr height="30" align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_2.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">1000-2999</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            30,000&nbsp;
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/star.png"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">2%</td>
                                                    </tr>
                                                    <tr height="30" align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_3.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">3000-7999</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            80,000&nbsp;
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/star.png"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">2%</td>
                                                    </tr>
                                                    <tr height="30" align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_4.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">8000-19999</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            160,000&nbsp;
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/star.png"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">2%</td>
                                                    </tr>
                                                    <tr height="30" align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_5.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">20000-49999</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            300,000&nbsp;
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/star.png"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">2%</td>
                                                    </tr>
                                                    <tr height="30" align="center" bgcolor="#ffffff">
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/vip_6.gif"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">50000以上</td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">
                                                            0&nbsp;
                                                            <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/star.png"></td>
                                                        <td style="FONT-SIZE: 9pt; FONT-FAMILY: 宋体,Verdana,Arial; COLOR: rgb(0,0,0)">日盈利0.5%</td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                            <p></p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#339900">
                                                    及时反馈bug核实后按bug严重程度给予1-50万星星奖励
                                                    <br>
                                                    及时检举骗子，发送广告信息，损害网站信誉的人员账号，按严重程度给予1-50万奖励
                                                    <br>
                                                    在qq群积极活跃发游戏截图，帮助其他玩家，每天qq群发放红包奖励
                                                    <br>及时检举代理合作商家，借卡，打折卖卡，买卡返点，不诚信行为的，按严重程度给予1-50万奖励</font>
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#339900">
                                                    <strong></strong>
                                                </font>
                                                &nbsp;
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#339900">
                                                    <strong>封号规则：
                                                        <br></strong>
                                                    利用兑奖比例低，下线推广收益高，恶意冲卡刷星星，发现封号
                                                </font>
                                                <font color="#339900">
                                                    <br>
                                                    利用三方开奖时间延迟，不及时报告，恶意刷星星，发现封号
                                                    <br>
                                                    利用黑客攻击，利用网站bug恶意刷星星，发现封号
                                                    <br>
                                                    欺骗其他玩家，代理卡密，财物，发现封号
                                                    <br>
                                                    利用软件自动统计分析，自动投注，发现封号
                                                    <br>
                                                    利用争霸赛活动，多个网站恶意对刷，发现封号
                                                    <br>
                                                    长期利用多个账号刷救济，吊极品，发现封号
                                                    <br>
                                                    和客服沟通过程中，恶意中伤，无理追讨红包，发现封号
                                                    <br>
                                                    在官方qq群聊天过程中，发其他站广告，讨论和遨夜网无关话题，中伤，起哄网站，语言不文明，发现封号，踢出qq群
                                                    <br>向其他玩家发送广告，或者发送诽谤有损网站信誉内容，被举报，发现封号</font>
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#339900"></font>
                                                &nbsp;
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">&nbsp;</p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#339900" size="4">
                                                    <strong>急速游戏的md5校验使用流程：</strong>
                                                </font>
                                            </p>
                                            <p style="WHITE-SPACE: normal; WORD-SPACING: 0px; TEXT-TRANSFORM: none; COLOR: rgb(0,0,0); FONT: 12px 宋体,Verdana,Arial; LETTER-SPACING: normal; TEXT-INDENT: 0px; -webkit-text-stroke-width: 0px">
                                                <font color="#339900">
                                                    <font color="#006600" size="4">第一步开奖前复制保存这个md5校验值</font>
                                                    <strong></strong>
                                                </font>
                                            </p>
                                            <font color="#339900">
                                                <div>
                                                    <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/0bed81b6eeb44a2df6bc5570cbe66.jpg"></div>
                                                <div>&nbsp;</div>
                                                <div>&nbsp;</div>
                                                <div>
                                                    <font color="#006600">
                                                        <font size="4">第二步，开奖后，把公开的奖号串拷贝出来，去百度生成md5码</font>
                                                    </font>
                                                </div>
                                                <div>
                                                    <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/84bfed28d09fbc1e6cf4f200e00c1.jpg"></div>
                                                <div>&nbsp;</div>
                                                <div>&nbsp;</div>
                                                <div>
                                                    <font color="#006600" size="4">第三步，比较前面保存的和自己百度生成码一致，就可以保证奖号是竞猜前开出的，</font>
                                                </div>
                                                <div>
                                                    <font color="#006600" size="4">
                                                        在竞猜过程中网站不能修改奖号。
                                                        <br></font>
                                                </div>
                                                <div>
                                                    <img src="./公告详情-遨夜网 - 玩游戏 赚星星, 换奖品就在熬夜网_files/01190395f15c280bbf28762cbe662.jpg"></div>
                                                <div>&nbsp;</div>
                                            </font>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                            <br></td>
                    </tr>
                </tbody>
            </table>
        </div>
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