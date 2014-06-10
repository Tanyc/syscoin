<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><!-- InstanceBegin template="/Templates/navi_temp.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<!-- InstanceBeginEditable name="doctitle" -->
    <title>广告体验-专业的广告游戏平台</title>
    <link rel="stylesheet" type="text/css" href="__CSS__/naviation.css" />
    <link rel="stylesheet" type="text/css" href="__CSS__/ad.css" />
    <link rel="stylesheet" type="text/css" href="__CSS__/footer.css" />

    <script type="text/javascript" src="__JS__/jquery.js"></script>
    <script type="text/javascript" src="__JS__/jquery.featureList-1.0.0.js"></script>
    <script language="javascript">
    $(document).ready(function() {
        $.featureList(
            $("#tabs li a"),
            $("#output li"), {
                start_item  :   1
            }
        );
    });
</script>
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
        <div id="body_content_l">
            <div id="feature_list">
                <ul id="tabs">
                    <li>
                        <a href="http://www.aoyene.cc/profit.php#" class="">
                            <img src="__IMAGES__/ad/services.png">
                            <h3>test1</h3>
                            <span>test111</span>
                        </a>
                    </li>
                    <li>
                        <a href="http://www.aoyene.cc/profit.php#" class="">
                            <img src="__IMAGES__/ad/programming.png">
                            <h3>test2</h3>
                            <span>test22222</span>
                        </a>
                    </li>

                    <li>
                        <a href="http://www.aoyene.cc/profit.php#" class="current">
                            <img src="__IMAGES__/ad/applications.png">
                            <h3>test3</h3>
                            <span>test333333</span>
                        </a>
                    </li>
                </ul>
                <ul id="output">
                    <li style="display: none;">
                        <a href="http://www.aoyene.cc/adtask.php?adid=13">
                            <img src="__IMAGES__/ad/20120714122159-Vr4DEHVi3w.png"></a>
                    </li>
                    <li style="display: none;">
                        <a href="http://www.aoyene.cc/profit.php?type=an">
                            <img src="__IMAGES__/ad/20120714122325-P1N1rzY4Xf.png"></a>
                    </li>

                    <li style="display: list-item;">
                        <a href="http://www.aoyene.cc/adtask.php?adid=19">
                            <img src="__IMAGES__/ad/20120714122459-N1xlGmAfgG.png"></a>
                    </li>
                </div>
                <div id="body_content_ld">
                    <div class="body_content_ld_tab">
                        <ul class="ad_tit">
                            <li>
                                <a href="/profit.php">体验赚星</a>
                            </li>
                            <li>
                                <a href="/profit.php?type=an">试玩赚星</a>
                            </li>
                            <li class="current">
                                <a href="/profit.php?type=try">调查赚星</a>
                            </li>
                        </ul>
                    </div>
                    <div class="body_content_id_list">
                        <ul class="list_ad_index" id="eui_tab">
                        <li>
                            <a title="棋牌试玩-江湖游" href="adtask.php?adid=48" target="_blank">
                                <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-11-01/20121101110842-HM4cCEawuy.jpg" width="152" height="67">
                                <span>
                                    棋牌试玩-江湖游
                                    <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-09-21/20120921164145-759HeLP1iq.jpg" alt="新活动，待体验"></span>
                                <span>
                                    奖 星星：16,600
                                    <img src="images/star.png" width="14" height="14"></span>
                            </a>
                        </li>
                        <li>
                            <a title="棋牌试玩-江湖游" href="adtask.php?adid=48" target="_blank">
                                <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-11-01/20121101110842-HM4cCEawuy.jpg" width="152" height="67">
                                <span>
                                    棋牌试玩-江湖游
                                    <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-09-21/20120921164145-759HeLP1iq.jpg" alt="新活动，待体验"></span>
                                <span>
                                    奖 星星：16,600
                                    <img src="images/star.png" width="14" height="14"></span>
                            </a>
                        </li>
                        <li>
                            <a title="棋牌试玩-江湖游" href="adtask.php?adid=48" target="_blank">
                                <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-11-01/20121101110842-HM4cCEawuy.jpg" width="152" height="67">
                                <span>
                                    棋牌试玩-江湖游
                                    <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-09-21/20120921164145-759HeLP1iq.jpg" alt="新活动，待体验"></span>
                                <span>
                                    奖 星星：16,600
                                    <img src="images/star.png" width="14" height="14"></span>
                            </a>
                        </li>
                        <li>
                            <a title="棋牌试玩-江湖游" href="adtask.php?adid=48" target="_blank">
                                <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-11-01/20121101110842-HM4cCEawuy.jpg" width="152" height="67">
                                <span>
                                    棋牌试玩-江湖游
                                    <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-09-21/20120921164145-759HeLP1iq.jpg" alt="新活动，待体验"></span>
                                <span>
                                    奖 星星：16,600
                                    <img src="images/star.png" width="14" height="14"></span>
                            </a>
                        </li>
                        <li>
                            <a title="棋牌试玩-江湖游" href="adtask.php?adid=48" target="_blank">
                                <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-11-01/20121101110842-HM4cCEawuy.jpg" width="152" height="67">
                                <span>
                                    棋牌试玩-江湖游
                                    <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-09-21/20120921164145-759HeLP1iq.jpg" alt="新活动，待体验"></span>
                                <span>
                                    奖 星星：16,600
                                    <img src="images/star.png" width="14" height="14"></span>
                            </a>
                        </li>
                        <li>
                            <a title="棋牌试玩-江湖游" href="adtask.php?adid=48" target="_blank">
                                <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-11-01/20121101110842-HM4cCEawuy.jpg" width="152" height="67">
                                <span>
                                    棋牌试玩-江湖游
                                    <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-09-21/20120921164145-759HeLP1iq.jpg" alt="新活动，待体验"></span>
                                <span>
                                    奖 星星：16,600
                                    <img src="images/star.png" width="14" height="14"></span>
                            </a>
                        </li>
                        <li>
                            <a title="棋牌试玩-江湖游" href="adtask.php?adid=48" target="_blank">
                                <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-11-01/20121101110842-HM4cCEawuy.jpg" width="152" height="67">
                                <span>
                                    棋牌试玩-江湖游
                                    <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-09-21/20120921164145-759HeLP1iq.jpg" alt="新活动，待体验"></span>
                                <span>
                                    奖 星星：16,600
                                    <img src="images/star.png" width="14" height="14"></span>
                            </a>
                        </li>
                        <li>
                            <a title="棋牌试玩-江湖游" href="adtask.php?adid=48" target="_blank">
                                <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-11-01/20121101110842-HM4cCEawuy.jpg" width="152" height="67">
                                <span>
                                    棋牌试玩-江湖游
                                    <img src="http://cache.adm.cnzz.net/ad_images/2012/2012-09-21/20120921164145-759HeLP1iq.jpg" alt="新活动，待体验"></span>
                                <span>
                                    奖 星星：16,600
                                    <img src="images/star.png" width="14" height="14"></span>
                            </a>
                        </li>
                    </ul>
                    </div>
                </div>
            </div>

            <div class="body_content_r">
                <div class="body_content_rt">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tbody>
                            <tr>
                                <td height="100" colspan="2" align="center" valign="middle">
                                    <div class="login">
                                        <div class="login_ok">
                                            <table width="100%">
                                                <tbody>
                                                    <tr>
                                                        <td>
                                                            <a href="useraccount.php">
                                                                <img width="48" height="48" src="__IMAGES__/public/head_l.jpg"></a>
                                                        </td>
                                                        <td align="left">
                                                            <a href="useraccount.php" class="a"> <b>dingyong4223</b>
                                                            </a>
                                                            &nbsp;
                                                            <img src="__IMAGES__/public/vip_0.gif" align="absmiddle" border="0">                    
                                                            &nbsp;
                                                            <br>                    
                                                            星星：0
                                                            <img src="/images/star.png"></td>
                                                    </tr>
                                                    <tr>
                                                        
                                                    </tr>
                                                </tbody>
                                            </table>
                                            <p>
                                                <a href="useraccount.php" class="person_center">&nbsp</a>
                                                <a href="prizes.php" class="prize_center">兑换奖品</a>
                                            </p>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class="body_content_rm">
                        <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1" class="top8">
                            <tbody>
                                <tr>
                                    <td width="100%" height="40" align="right" background="__IMAGES__/Ad/ad_prac.gif">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="140">
                                        <div class="n_g" style="height: 200px;overflow: hidden;" id="ntaskmq">
                                            <ul class="slider">
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=23" target="_blank">试玩神仙道</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=23" target="_blank">试玩神仙道</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=23" target="_blank">试玩神仙道</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=13" target="_blank">酷播电影</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=18" target="_blank">快乐之都</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/userrecom.php" target="_blank">邀请好友</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=23" target="_blank">试玩神仙道</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=18" target="_blank">快乐之都</a>
                                                    </span>
                                                </li>
                                            </ul>

                                            <ul class="slider">
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=23" target="_blank">试玩神仙道</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=23" target="_blank">试玩神仙道</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=23" target="_blank">试玩神仙道</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=13" target="_blank">酷播电影</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=18" target="_blank">快乐之都</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/userrecom.php" target="_blank">邀请好友</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=23" target="_blank">试玩神仙道</a>
                                                    </span>
                                                </li>
                                                <li>
                                                    <span class="red">
                                                        <a href="/user_detail.php?uid=" target="_blank"></a>
                                                        ：
                                                    </span>
                                                    体验了
                                                    <span class="blue">
                                                        <a href="/adtask.php?adid=18" target="_blank">快乐之都</a>
                                                    </span>
                                                </li>
                                            </ul>
                                        </div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                </div>
        <script>
            var ntask = document.getElementById("ntaskmq"); //滚动对象
            var iLineHeight = 33; //单行高度，像素
            var iLineCount = 10; //实际行数
            var iScrollAmount = 1; //每次滚动高度，像素
            function runntask() {
                ntask.scrollTop += iScrollAmount;
            if ( ntask.scrollTop == iLineCount * iLineHeight )
                ntask.scrollTop = 0;
            if ( ntask.scrollTop % iLineHeight == 0 ) {
                window.setTimeout( "runntask()", 2000 );
            } else {
                window.setTimeout( "runntask()", 10 );}
            }
            ntask.innerHTML += ntask.innerHTML;
            window.setTimeout( "runntask()", 2000 );
        </script>
                <div class="body_content_rb">
                    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1" class="top8">
                        <tbody>
                            <tr>
                                <td width="100%" height="40" align="center" valign="bottom" background="__IMAGES__/ad/niu_person.png">

                                    <script language="javascript" type="text/javascript">
//<![CDATA[
function tabit(tabName,btnId,tabNumber)
{
for(i=0;i<tabNumber;i++)
{
document.getElementById(tabName+"_div"+i).style.display = "none";
document.getElementById(tabName+"_btn"+i).className = tabName+"_taboff";
}
document.getElementById(tabName+"_div"+btnId).style.display = "block";
document.getElementById(tabName+"_btn"+btnId).className = tabName+"_tabon";
}
//]]></script>

                                    <table width="175" border="0" cellspacing="0" cellpadding="0" style="margin-bottom:1px">
                                        <tbody>
                                            <tr>
                                                <td width="75">&nbsp;</td>
                                                <td width="50" height="23" class="tsnews_tabon" id="tsnews_btn0" onmouseover="tabit('tsnews',0,2)" align="center" valign="middle">今日</td>
                                                <td width="50" class="tsnews_taboff" id="tsnews_btn1" onmouseover="tabit('tsnews',1,2)" align="center" valign="middle">本周</td>
                                            </tr>
                                        </tbody>
                                    </table>

                                </td>
                            </tr>
                            <tr>
                                <td height="157">
                                    <div id="tsnews_div0">
                                        <div class="n_r">
                                            <ul id="con_niu_1" class="niu_list">
                                                <li>
                                                    <span>
                                                        18,637,650
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1082313" target="_blank">
                                                        老板来碗面，多葱多辣
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        11,715,682
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1098270" target="_blank">
                                                        支持家家代理
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        11,243,412
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1100817" target="_blank">
                                                        68leo
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        10,965,495
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1088624" target="_blank">
                                                        呵呵  ^你好
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        10,288,476
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1088361" target="_blank">
                                                        天王虽老风采依旧
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        7,277,770
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1082310" target="_blank">
                                                        dwightznvjjiud
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        6,923,722
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1082321" target="_blank">
                                                        收购2手车qq78977668
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        6,445,375
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1082283" target="_blank">
                                                        赚一点是一点
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div id="tsnews_div1" style="border-top:none;display:none;">
                                        <div class="n_r">
                                            <ul id="con_niu_1" class="niu_list">
                                                <li>
                                                    <span>
                                                        31,159,962
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1104616" target="_blank">
                                                        wyf168
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        16,976,388
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1103130" target="_blank">
                                                        hgkjhkjh
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        13,558,231
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1088361" target="_blank">
                                                        天王虽老风采依旧
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        12,612,013
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1082313" target="_blank">
                                                        老板来碗面，多葱多辣
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        12,539,106
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1088624" target="_blank">
                                                        呵呵  ^你好
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        10,194,648
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1089463" target="_blank">
                                                        A769984464
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        9,875,722
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1104312" target="_blank">
                                                        没有原则的失败者
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                                <li>
                                                    <span>
                                                        9,719,912
                                                        <img src="/images/icons/icon7.jpg"></span>
                                                    <a href="/user_detail.php?uid=1100817" target="_blank">
                                                        68leo
                                                        <img src="/images/vip_6.gif" align="absmiddle" border="0"></a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
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