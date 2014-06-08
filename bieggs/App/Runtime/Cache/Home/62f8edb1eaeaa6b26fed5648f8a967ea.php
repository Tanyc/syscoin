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
                
                </div>
                <div class="body_content_rm">
                
                </div>
                <div class="body_content_rb">
                
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