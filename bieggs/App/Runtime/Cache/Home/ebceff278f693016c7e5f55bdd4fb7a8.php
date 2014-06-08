<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><!-- InstanceBegin template="/Templates/navi_temp.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<!-- InstanceBeginEditable name="doctitle" -->
    <title>团购-专业的广告游戏平台</title>
    <link rel="stylesheet" type="text/css" href="__CSS__/naviation.css" />
    <link rel="stylesheet" type="text/css" href="__CSS__/com.css" />
    <link rel="stylesheet" type="text/css" href="__CSS__/glory.css" />
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
        <div class="doc">
            <div class="layout_wz">
                <img src="__IMAGES__/glory/sj_topt.jpg"></div>
            <div class="layout_nav">
                <div class="layout_nav_l">
                    <ul>
                        <li class="on">
                            <a href="__IMAGES__/glory/晒奖_PC蛋蛋.htm">全部晒奖</a>
                        </li>
                        <li class="line">|</li>
                        <li class="">
                            <a href="http://www.pceggs.com/ShowPrize/ShowList.aspx?topicid=2">精华晒奖</a>
                        </li>
                        <li class="line">|</li>
                        <li class="">
                            <a href="http://www.pceggs.com/ShowPrize/ShowList.aspx?topicid=4">七周年，我和我的宝贝</a>
                        </li>
                        <li class="line">|</li>
                        <li class="">
                            <a href="http://www.pceggs.com/ShowPrize/ShowList.aspx?topicid=3">我的晒奖</a>
                        </li>

                    </ul>
                </div>
                <div class="layout_nav_r">
                    <a href="http://www.pceggs.com/ShowPrize/ShowAdd.aspx">
                        <img src="__IMAGES__/glory/sj_an.gif"></a>
                    &nbsp;&nbsp;
                    <a href="http://www.pceggs.com/ShowPrize/showrule.aspx">
                        <img src="__IMAGES__/glory/gz_an.gif"></a>
                </div>
            </div>

            <div class="layout_gg">
                <span>热点推荐</span>
                <span class="dot">&nbsp;</span>
                <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8001507">溜冰鞋不错的礼物哦</a>
                &nbsp;&nbsp;&nbsp;
                <span class="dot">&nbsp;</span>
                <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8001506">兑换的礼物很满意，谢谢蛋蛋</a>
                &nbsp;&nbsp;&nbsp;
                <span class="dot">&nbsp;</span>
                <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8001503">期待已久的iPad Mini</a>
                &nbsp;&nbsp;&nbsp;
                <span class="dot">&nbsp;</span>
                <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8001500">感谢蛋蛋为小家置办“装备”</a>
                &nbsp;&nbsp;&nbsp;
                <span class="dot">&nbsp;</span>
                <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8001485">来自蛋蛋的情人节礼物</a>
            </div>

            <div class="bbs_layout_dbg clearall">

                <div id="PanelList">

                    <div class="list-tab">

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=15337153">
                                        <img src="__IMAGES__/glory/b_mt_01.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=15337153">雷诺越</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002200">感谢来自蛋蛋的礼物</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf"></div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：06-05 17:14</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002200">
                                            玩蛋蛋也N久了，游戏也玩了，28也猜了，虽然总是归零状态中，但是也兑奖换了一些话费玩具等东东，&nbsp;一直是随意的玩玩。
                                            <br>
                                            参加夺宝也好久了，但一次都没中过，那天我同事说，有金蛋来夺宝，我还说运气从来不到我家，后来就随意投注了。没想到，......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002200">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002200">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-06-05/201406051713090838622.jpg;http://fs.pceggs.com/pic/2014-06-05/201406051713407760228.jpg;http://fs.pceggs.com/pic/2014-06-05/201406051713535920783.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002200").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002200"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002200").append('<li ><a href="ShowInfo.aspx?tid=8002200"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002200">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-05/201406051713090838622.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002200">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-05/201406051713407760228.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002200">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-05/201406051713535920783.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002200">
                                                        <img src="__IMAGES__/glory/201406051713090838622.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002200">
                                                        <img src="__IMAGES__/glory/201406051713407760228.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002200">
                                                        <img src="__IMAGES__/glory/201406051713535920783.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002200" href="javascript:AddPraise('8002200','1')">
                                                <span>赞(1)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002200#fatie">
                                                <span>评论(0)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=6158830">
                                        <img src="__IMAGES__/glory/b_mt_16.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=6158830">╰_╯雪狼汨</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002191">我的奖品</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf"></div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：06-05 12:26</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002191">感谢PC蛋蛋，祝PC蛋蛋人气越来越高......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002191">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002191">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-06-05/201406051226005320121.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002191").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002191"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002191").append('<li ><a href="ShowInfo.aspx?tid=8002191"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002191">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-05/201406051226005320121.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002191">
                                                        <img src="__IMAGES__/glory/201406051226005320121.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002191" href="javascript:AddPraise('8002191','0')">
                                                <span>赞(0)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002191#fatie">
                                                <span>评论(0)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=16211586">
                                        <img src="__IMAGES__/glory/b_mt_13.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=16211586">懒从</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002190">第二次兑奖，灰鼠 20寸6档变速单车</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：06-04 19:34</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002190">&nbsp;真是神速，一通过审核，两天就到了，端午那天到的，很漂亮的自行车，......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002190">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002190">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-06-04/201406041934390712311.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002190").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002190"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002190").append('<li ><a href="ShowInfo.aspx?tid=8002190"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002190">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-04/201406041934390712311.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002190">
                                                        <img src="__IMAGES__/glory/201406041934390712311.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002190" href="javascript:AddPraise('8002190','2')">
                                                <span>赞(2)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002190#fatie">
                                                <span>评论(0)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17273321">
                                        <img src="__IMAGES__/glory/b_mt_62.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17273321">f</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002189">第一实物兑奖</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：06-04 19:25</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002189">
                                            不好意思，确认晚了，东西收到了&nbsp;，女儿很喜欢，感谢蛋蛋，我会继续努力的，兑换到女儿更多喜欢的礼物哈，蛋蛋是个不错的平台哦，
                                            <br>今天我把在pc蛋蛋上的第一次实物兑奖-可折叠可升降亲子户外踏板车（粉色）送给女儿,祝她健康成长.再次谢谢......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002189">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002189">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-06-04/201406041924533027271.jpg;http://fs.pceggs.com/pic/2014-06-04/201406041925054864239.jpg;http://fs.pceggs.com/pic/2014-06-04/201406041925154889960.jpg;http://fs.pceggs.com/pic/2014-06-04/201406041925241604920.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002189").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002189"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002189").append('<li ><a href="ShowInfo.aspx?tid=8002189"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002189">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-04/201406041924533027271.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002189">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-04/201406041925054864239.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002189">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-04/201406041925154889960.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002189">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-04/201406041925241604920.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002189">
                                                        <img src="__IMAGES__/glory/201406041924533027271.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002189">
                                                        <img src="__IMAGES__/glory/201406041925054864239.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002189">
                                                        <img src="__IMAGES__/glory/201406041925154889960.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002189">
                                                        <img src="__IMAGES__/glory/201406041925241604920.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002189" href="javascript:AddPraise('8002189','0')">
                                                <span>赞(0)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002189#fatie">
                                                <span>评论(1)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=14395433">
                                        <img src="__IMAGES__/glory/b_mt_57.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=14395433">loo</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002188">粉红猪壁灯照耀我家丫头</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：06-04 16:58</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002188">
                                            &nbsp;&nbsp;我家丫头今年读小学一年级，我让丫头一个人睡觉，丫头怕黑，一直不敢睡。我在PC蛋蛋\(^o^)/兑了一个创意3D墙纸壁灯（粉红猪）给丫头，让“粉红猪”陪着丫头，这样丫头就不会害怕了。
                                            <br>
                                            &nbsp;&nbsp;礼物送到了，丫头很开心哦。
                                            <br>
                                            <br></a>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002188">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002188">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-06-04/201406041652293007201.jpg;http://fs.pceggs.com/pic/2014-06-04/201406041653413928435.jpg;http://fs.pceggs.com/pic/2014-06-04/201406041653566447159.jpg;http://fs.pceggs.com/pic/2014-06-04/201406041657411115546.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002188").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002188"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002188").append('<li ><a href="ShowInfo.aspx?tid=8002188"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002188">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-04/201406041652293007201.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002188">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-04/201406041653413928435.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002188">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-04/201406041653566447159.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002188">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-04/201406041657411115546.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002188">
                                                        <img src="__IMAGES__/glory/201406041652293007201.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002188">
                                                        <img src="__IMAGES__/glory/201406041653413928435.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002188">
                                                        <img src="__IMAGES__/glory/201406041653566447159.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002188">
                                                        <img src="__IMAGES__/glory/201406041657411115546.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002188" href="javascript:AddPraise('8002188','1')">
                                                <span>赞(1)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002188#fatie">
                                                <span>评论(2)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=16696656">
                                        <img src="__IMAGES__/glory/b_mt_70.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=16696656">恺妈</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002187">六一节送给儿子的扭扭车， 感谢蛋蛋</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">

                                                <span class="lvjword">+300,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_2.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：06-03 11:32</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002187">
                                            不好意思，确认晚了，东西收到了&nbsp;，儿子很喜欢，感谢蛋蛋，我会继续努力的，兑换到儿子更多喜欢的礼物哈，蛋蛋是个不错的平台哦，大家一起加油吧，希望他们越办越好。
                                            <br>&nbsp;&nbsp;感谢外公，帮宝宝装好好了。。西西&nbsp;&nbsp;这是第二次兑......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002187">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002187">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-06-03/201406031124325175787.jpg;http://fs.pceggs.com/pic/2014-06-03/201406031129118205540.jpg;http://fs.pceggs.com/pic/2014-06-03/201406031131208789357.jpg;http://fs.pceggs.com/pic/2014-06-03/201406031131261232356.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002187").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002187"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002187").append('<li ><a href="ShowInfo.aspx?tid=8002187"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002187">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-03/201406031124325175787.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002187">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-03/201406031129118205540.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002187">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-03/201406031131208789357.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002187">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-03/201406031131261232356.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002187">
                                                        <img src="__IMAGES__/glory/201406031124325175787.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002187">
                                                        <img src="__IMAGES__/glory/201406031129118205540.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002187">
                                                        <img src="__IMAGES__/glory/201406031131208789357.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002187">
                                                        <img src="__IMAGES__/glory/201406031131261232356.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002187" href="javascript:AddPraise('8002187','9')">
                                                <span>赞(9)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002187#fatie">
                                                <span>评论(2)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=8543276">
                                        <img src="__IMAGES__/glory/b_mt_19.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=8543276">虹儿笑了</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002186">送宝宝的扭扭车</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">

                                                <span class="lvjword">+300,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_2.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：06-03 10:14</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002186">
                                            自2008年开始玩蛋蛋，期间断断续续的，一直也没怎么坚持下来。去年生完小宝宝在家看孩子想到了蛋蛋，看到了电瓶车宝马，心里特别喜欢心想兑一辆送宝宝，可以随着蛋蛋挣的多了，车却下架了，当时一下子就没了动力，又有半个月没玩，那天看到了扭扭车......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002186">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002186">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-06-03/201406031011540469661.jpg;http://fs.pceggs.com/pic/2014-06-03/201406031012430987717.jpg;http://fs.pceggs.com/pic/2014-06-03/201406031013182027795.jpg;http://fs.pceggs.com/pic/2014-06-03/201406031013459183647.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002186").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002186"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002186").append('<li ><a href="ShowInfo.aspx?tid=8002186"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002186">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-03/201406031011540469661.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002186">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-03/201406031012430987717.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002186">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-03/201406031013182027795.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002186">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-03/201406031013459183647.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002186">
                                                        <img src="__IMAGES__/glory/201406031011540469661.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002186">
                                                        <img src="__IMAGES__/glory/201406031012430987717.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002186">
                                                        <img src="__IMAGES__/glory/201406031013182027795.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002186">
                                                        <img src="__IMAGES__/glory/201406031013459183647.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002186" href="javascript:AddPraise('8002186','3')">
                                                <span>赞(3)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002186#fatie">
                                                <span>评论(5)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17564699">
                                        <img src="__IMAGES__/glory/b_mt_20.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17564699">想要靠近</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002185">第一次晒奖咯！！</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：06-02 14:42</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002185">
                                            从2014年1月份开始玩pc蛋蛋到现在有6个月了，换了两次话费，玩的比较多就是购物返利，玩游戏慢慢累计金蛋换到一个&nbsp;开水煲电热水壶1.7L的，这也是第一次兑换实物。5月28号申请的，今天早上刚到，这是要送给妹妹大学礼物，也希望她能考上好大......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002185">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002185">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-06-02/201406021438568286194.jpg;http://fs.pceggs.com/pic/2014-06-02/201406021440105788377.jpg;http://fs.pceggs.com/pic/2014-06-02/201406021441083021393.jpg;http://fs.pceggs.com/pic/2014-06-02/201406021442041263322.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002185").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002185"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002185").append('<li ><a href="ShowInfo.aspx?tid=8002185"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002185">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-02/201406021438568286194.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002185">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-02/201406021440105788377.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002185">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-02/201406021441083021393.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002185">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-02/201406021442041263322.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002185">
                                                        <img src="__IMAGES__/glory/201406021438568286194.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002185">
                                                        <img src="__IMAGES__/glory/201406021440105788377.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002185">
                                                        <img src="__IMAGES__/glory/201406021441083021393.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002185">
                                                        <img src="__IMAGES__/glory/201406021442041263322.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002185" href="javascript:AddPraise('8002185','4')">
                                                <span>赞(4)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002185#fatie">
                                                <span>评论(0)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17177254">
                                        <img src="__IMAGES__/glory/b_mt_71.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17177254">我爱赚钱</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002184">土豪金5S到碗里，感谢蛋蛋送的六一礼物呦~~~</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">

                                                <span class="lvjword">+300,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_2.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：06-01 20:55</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002184">
                                            学生党，玩蛋蛋快一年了，个人感觉男生要比女生玩的好，俺一小女子，就淘宝购物和手机试玩，换了好几百话费，原先的目标是换个苹果电脑，可是。。可是。。。。太尼玛多了啊，攒到3000万的时候就花了=&nbsp;=。夺宝也是，陆陆续续多了好多次，都没中，从俺从......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002184">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002184">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-06-01/201406012052439100925.jpg;http://fs.pceggs.com/pic/2014-06-01/201406012053010650737.jpg;http://fs.pceggs.com/pic/2014-06-01/201406012053241273928.jpg;http://fs.pceggs.com/pic/2014-06-01/201406012054555876240.png;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002184").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002184"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002184").append('<li ><a href="ShowInfo.aspx?tid=8002184"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002184">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-01/201406012052439100925.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002184">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-01/201406012053010650737.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002184">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-01/201406012053241273928.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002184">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-01/201406012054555876240.png_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002184">
                                                        <img src="__IMAGES__/glory/201406012052439100925.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002184">
                                                        <img src="__IMAGES__/glory/201406012053010650737.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002184">
                                                        <img src="__IMAGES__/glory/201406012053241273928.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002184">
                                                        <img src="__IMAGES__/glory/201406012054555876240.png_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002184" href="javascript:AddPraise('8002184','4')">
                                                <span>赞(4)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002184#fatie">
                                                <span>评论(18)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17371788">
                                        <img src="__IMAGES__/glory/b_mt_17.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17371788">凤飞</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002183">蛋蛋最给力，又一次兑换</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：06-01 16:31</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002183">蛋蛋真的很给力，一如既往的快速传递快乐幸福。东东又好又实在。快速递速度没话说真快......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002183">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002183">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-06-01/201406011630053318907.jpg;http://fs.pceggs.com/pic/2014-06-01/201406011630222968610.jpg;http://fs.pceggs.com/pic/2014-06-01/201406011630371907129.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002183").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002183"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002183").append('<li ><a href="ShowInfo.aspx?tid=8002183"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002183">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-01/201406011630053318907.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002183">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-01/201406011630222968610.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002183">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-01/201406011630371907129.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002183">
                                                        <img src="__IMAGES__/glory/201406011630053318907.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002183">
                                                        <img src="__IMAGES__/glory/201406011630222968610.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002183">
                                                        <img src="__IMAGES__/glory/201406011630371907129.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002183" href="javascript:AddPraise('8002183','2')">
                                                <span>赞(2)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002183#fatie">
                                                <span>评论(0)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=16055794">
                                        <img src="__IMAGES__/glory/b_mt_19.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=16055794">.~顺7.z繎|-</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002182">九阳榨汁机</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：06-01 11:24</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002182">期盼N年的榨汁机，就是懒的去买，现在不用买，直接蛋蛋兑换到了！哈哈！太开心了！......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002182">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002182">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-06-01/201406011122529614821.jpg;http://fs.pceggs.com/pic/2014-06-01/201406011123140876904.jpg;http://fs.pceggs.com/pic/2014-06-01/201406011123282905028.jpg;http://fs.pceggs.com/pic/2014-06-01/201406011123459115106.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002182").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002182"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002182").append('<li ><a href="ShowInfo.aspx?tid=8002182"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002182">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-01/201406011122529614821.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002182">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-01/201406011123140876904.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002182">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-01/201406011123282905028.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002182">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-01/201406011123459115106.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002182">
                                                        <img src="__IMAGES__/glory/201406011122529614821.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002182">
                                                        <img src="__IMAGES__/glory/201406011123140876904.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002182">
                                                        <img src="__IMAGES__/glory/201406011123282905028.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002182">
                                                        <img src="__IMAGES__/glory/201406011123459115106.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002182" href="javascript:AddPraise('8002182','2')">
                                                <span>赞(2)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002182#fatie">
                                                <span>评论(0)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=8850531">
                                        <img src="__IMAGES__/glory/b_mt_02.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=8850531">笨师傅</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002181">送给女儿的六一礼物</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：06-01 10:54</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002181">
                                            时光荏苒,转眼女儿已经三岁半了.几乎没给女儿买过礼物,作为父亲我内心怀有一丝愧疚.今天我把在pc蛋蛋上的第一次实物兑奖-蛙式滑板车送给女儿,祝她健康成长.也祝全国的小朋友六一节快乐.再次谢谢pc蛋蛋网.......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002181">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002181">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-06-01/201406011053349090000.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002181").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002181"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002181").append('<li ><a href="ShowInfo.aspx?tid=8002181"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002181">
                                                        <img src="http://fs.pceggs.com/pic/2014-06-01/201406011053349090000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002181">
                                                        <img src="__IMAGES__/glory/201406011053349090000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002181" href="javascript:AddPraise('8002181','3')">
                                                <span>赞(3)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002181#fatie">
                                                <span>评论(0)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17041299">
                                        <img src="__IMAGES__/glory/b_mt_12.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17041299">猫猫</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002180">第一交兑奖,很激动</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-31 17:50</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002180">
                                            玩PC蛋蛋也有点时间了,一直想着给儿子换滑板车,但是蛋蛋数量一直不够,好不容易够数了,立马给儿子换了,今天想到礼物儿子很开心哦,刚好六一儿童节了,哈..省了去买礼物钱钱咯.特别感谢PC蛋蛋这平台.......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002180">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002180">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-05-31/201405311749120104505.jpg;http://fs.pceggs.com/pic/2014-05-31/201405311749334596773.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002180").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002180"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002180").append('<li ><a href="ShowInfo.aspx?tid=8002180"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002180">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-31/201405311749120104505.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002180">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-31/201405311749334596773.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002180">
                                                        <img src="__IMAGES__/glory/201405311749120104505.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002180">
                                                        <img src="__IMAGES__/glory/201405311749334596773.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002180" href="javascript:AddPraise('8002180','2')">
                                                <span>赞(2)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002180#fatie">
                                                <span>评论(5)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=9337894">
                                        <img src="__IMAGES__/glory/b_mt_66.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=9337894">123</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002167">玩了6年头一次兑奖哦</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf"></div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-31 08:22</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002167">
                                            我兑的奖品是曼伯斯斜挎帆布包，官方直接快递来的，质量没的说，还赠了个卡包。6年的付出终于有了回报，我会一直玩下去的，期待下一次的兑奖。......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002167">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002167">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-05-31/201405310820330120000.jpg;http://fs.pceggs.com/pic/2014-05-31/201405310821461040000.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002167").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002167"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002167").append('<li ><a href="ShowInfo.aspx?tid=8002167"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002167">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-31/201405310820330120000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002167">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-31/201405310821461040000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002167">
                                                        <img src="__IMAGES__/glory/201405310820330120000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002167">
                                                        <img src="__IMAGES__/glory/201405310821461040000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002167" href="javascript:AddPraise('8002167','1')">
                                                <span>赞(1)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002167#fatie">
                                                <span>评论(1)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=10063482">
                                        <img src="__IMAGES__/glory/b_mt_18.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=10063482">10063482</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002166">帮儿子换的滑板车</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf"></div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-30 13:18</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002166">玩了很长时间的PC蛋蛋，第一次兑换了一辆滑板车给儿子，儿子收到礼物非常喜欢......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002166">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002166">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-05-30/201405301313192390262.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002166").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002166"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002166").append('<li ><a href="ShowInfo.aspx?tid=8002166"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002166">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-30/201405301313192390262.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002166">
                                                        <img src="__IMAGES__/glory/201405301313192390262.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002166" href="javascript:AddPraise('8002166','0')">
                                                <span>赞(0)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002166#fatie">
                                                <span>评论(0)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17004992">
                                        <img src="__IMAGES__/glory/b_mt_02.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17004992">StupidBoy</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002165">我来晒奖啦！哈哈</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-29 17:57</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002165">
                                            每一次换东西都激动死了。。。而且这次换的杯子遇到了一些小麻烦，手机充电没留意有人打电话来，搞得快递叔叔把快递寄回去了，555、、、&nbsp;前几天，客服打电话来，才知道这件事，我以后都会注意有快递的时候多留意手机了。&nbsp;&nbsp;感谢那位很有......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002165">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002165">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-05-29/201405291753238235543.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002165").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002165"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002165").append('<li ><a href="ShowInfo.aspx?tid=8002165"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002165">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-29/201405291753238235543.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002165">
                                                        <img src="__IMAGES__/glory/201405291753238235543.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002165" href="javascript:AddPraise('8002165','7')">
                                                <span>赞(7)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002165#fatie">
                                                <span>评论(0)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17230904">
                                        <img src="__IMAGES__/glory/b_mt_62.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17230904">莪自是年少＂韶华倾负▓</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002164">晒晒:游戏必备的黑爵</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf"></div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-29 12:17</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002164">第一次换的实物...物流也很快....果断上周天申请今天周四就到了-&nbsp;-.下次再弄个键盘哈哈......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002164">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002164">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-05-29/201405291212391340000.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002164").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002164"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002164").append('<li ><a href="ShowInfo.aspx?tid=8002164"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002164">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-29/201405291212391340000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002164">
                                                        <img src="__IMAGES__/glory/201405291212391340000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002164" href="javascript:AddPraise('8002164','0')">
                                                <span>赞(0)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002164#fatie">
                                                <span>评论(1)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=7165936">
                                        <img src="__IMAGES__/glory/b_mt_09.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=7165936">快乐的小猪</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002163">时隔4年，第二次兑换无线路由器</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-29 09:55</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002163">
                                            2010年的时候就给自己兑了一个无线路由，红色的很漂亮，服役到现在好好的。今年想给家里人再兑一个用，于是马上行动起来，经过漫长的6天等待路由器终于到手了，黑色的看着也很靓，但厂家怎么变小气了，网线竟然都没有，以前可是有的，想兑换的蛋友......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002163">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002163">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-05-29/201405290953298636340.png;http://fs.pceggs.com/pic/2014-05-29/201405290953459215525.png;http://fs.pceggs.com/pic/2014-05-29/201405290954030115299.png;http://fs.pceggs.com/pic/2014-05-29/201405290954387455738.png;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002163").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002163"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002163").append('<li ><a href="ShowInfo.aspx?tid=8002163"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002163">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-29/201405290953298636340.png_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002163">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-29/201405290953459215525.png_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002163">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-29/201405290954030115299.png_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002163">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-29/201405290954387455738.png_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002163">
                                                        <img src="__IMAGES__/glory/201405290953298636340.png_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002163">
                                                        <img src="__IMAGES__/glory/201405290953459215525.png_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002163">
                                                        <img src="__IMAGES__/glory/201405290954030115299.png_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002163">
                                                        <img src="__IMAGES__/glory/201405290954387455738.png_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002163" href="javascript:AddPraise('8002163','2')">
                                                <span>赞(2)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002163#fatie">
                                                <span>评论(1)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=15634469">
                                        <img src="__IMAGES__/glory/b_mt_20.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=15634469">shinky</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002162">第一次兑换礼品，好激动^_^！！！</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-28 15:59</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002162">
                                            玩了好几年的PC蛋蛋，早期被清零好几次，也放弃过好几次。去年12月又捡回来了，好在捡回来，才有现在的奖励。哈哈！值了！半年的时间一床四件套，想想还是挺厉害的！（自我感觉良好中~）
                                            <br>说说物品吧，真是和照片一模一样，连色差都没有，很美，质量也......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002162">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002162">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-05-28/201405281544584327383.jpg;http://fs.pceggs.com/pic/2014-05-28/201405281546082007288.jpg;http://fs.pceggs.com/pic/2014-05-28/201405281548313179146.jpg;http://fs.pceggs.com/pic/2014-05-28/201405281550474347000.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002162").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002162"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002162").append('<li ><a href="ShowInfo.aspx?tid=8002162"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002162">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-28/201405281544584327383.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002162">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-28/201405281546082007288.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002162">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-28/201405281548313179146.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002162">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-28/201405281550474347000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002162">
                                                        <img src="__IMAGES__/glory/201405281544584327383.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002162">
                                                        <img src="__IMAGES__/glory/201405281546082007288.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002162">
                                                        <img src="__IMAGES__/glory/201405281548313179146.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002162">
                                                        <img src="__IMAGES__/glory/201405281550474347000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002162" href="javascript:AddPraise('8002162','4')">
                                                <span>赞(4)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002162#fatie">
                                                <span>评论(5)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17787972">
                                        <img src="__IMAGES__/glory/b_mt_64.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17787972">大赢家010</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002161">我的100元话费得到手咯。</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf"></div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-28 09:19</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002161">亲爱的蛋友们，努力终有回报的！大家加油！我一直都是蛋蛋的粉丝！......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002161">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002161">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-05-28/201405280919030004606.png;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002161").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002161"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002161").append('<li ><a href="ShowInfo.aspx?tid=8002161"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002161">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-28/201405280919030004606.png_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002161">
                                                        <img src="__IMAGES__/glory/201405280919030004606.png_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002161" href="javascript:AddPraise('8002161','0')">
                                                <span>赞(0)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002161#fatie">
                                                <span>评论(2)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=15009574">
                                        <img src="__IMAGES__/glory/b_mt_02.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=15009574">夏天</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002160">衣橱到了</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf"></div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-27 19:59</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002160">我玩了好久pc蛋蛋，蛋蛋？......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002160">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002160">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-05-27/201405271953238924845.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002160").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002160"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002160").append('<li ><a href="ShowInfo.aspx?tid=8002160"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002160">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-27/201405271953238924845.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002160">
                                                        <img src="__IMAGES__/glory/201405271953238924845.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002160" href="javascript:AddPraise('8002160','0')">
                                                <span>赞(0)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002160#fatie">
                                                <span>评论(0)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=15278603">
                                        <img src="__IMAGES__/glory/b_mt_16.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=15278603">坚持战胜一切</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002150">晒奖！！！博洋家纺 全棉四件套-粉香时代。</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-27 11:58</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002150">
                                            玩蛋蛋快三年了，第二次兑换实物奖品，第一次没来的急晒奖。本人以玩游戏为主，28也玩，不过不能太贪，(你们懂的)会输光的呵呵。本来这个四件套要换给老婆大人的，老婆大人要我兑换个1.5m的，可是我尺寸弄错了弄成了1.8m的。以后要加倍努力给老婆大......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002150">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002150">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-05-27/201405271157478840000.jpg;http://fs.pceggs.com/pic/2014-05-27/201405271157539160000.jpg;http://fs.pceggs.com/pic/2014-05-27/201405271158010570000.jpg;http://fs.pceggs.com/pic/2014-05-27/201405271158081350000.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002150").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002150"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002150").append('<li ><a href="ShowInfo.aspx?tid=8002150"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002150">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-27/201405271157478840000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002150">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-27/201405271157539160000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002150">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-27/201405271158010570000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002150">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-27/201405271158081350000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002150">
                                                        <img src="__IMAGES__/glory/201405271157478840000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002150">
                                                        <img src="__IMAGES__/glory/201405271157539160000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002150">
                                                        <img src="__IMAGES__/glory/201405271158010570000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002150">
                                                        <img src="__IMAGES__/glory/201405271158081350000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002150" href="javascript:AddPraise('8002150','0')">
                                                <span>赞(0)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002150#fatie">
                                                <span>评论(2)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=10556260">
                                        <img src="__IMAGES__/glory/b_mt_21.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=10556260">细水ing</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002149">我也来晒晒我的ipad Air等奖品</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">

                                                <span class="lvjword">+300,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_2.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-25 14:52</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002149">
                                            虽然换了东西之后冲动归零了，我还会回来的，在这祝大家玩的开心，祝PC蛋蛋越办越好。顺便吐槽下，照相照出来的都是小于150K的照片，只有只样拼图了......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002149">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002149">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-05-25/201405251432542990000.jpg;http://fs.pceggs.com/pic/2014-05-25/201405251433559260000.jpg;http://fs.pceggs.com/pic/2014-05-25/201405251443235300000.jpg;http://fs.pceggs.com/pic/2014-05-25/201405251447365780000.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002149").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002149"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002149").append('<li ><a href="ShowInfo.aspx?tid=8002149"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002149">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-25/201405251432542990000.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002149">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-25/201405251433559260000.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002149">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-25/201405251443235300000.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002149">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-25/201405251447365780000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002149">
                                                        <img src="__IMAGES__/glory/201405251432542990000.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002149">
                                                        <img src="__IMAGES__/glory/201405251433559260000.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002149">
                                                        <img src="__IMAGES__/glory/201405251443235300000.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002149">
                                                        <img src="__IMAGES__/glory/201405251447365780000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002149" href="javascript:AddPraise('8002149','6')">
                                                <span>赞(6)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002149#fatie">
                                                <span>评论(9)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=6511293">
                                        <img src="__IMAGES__/glory/b_201405221053513255912.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=6511293">舞王又回来了</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002148">额。。。笔记本也到了。。晒一下</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf"></div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-25 12:16</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002148">苦逼学校。。停电3天。。有手机电脑也没有。。祝大家也能换电脑哈！！......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002148">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002148">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-05-25/201405251215119556199.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002148").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002148"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002148").append('<li ><a href="ShowInfo.aspx?tid=8002148"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002148">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-25/201405251215119556199.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002148">
                                                        <img src="__IMAGES__/glory/201405251215119556199.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002148" href="javascript:AddPraise('8002148','0')">
                                                <span>赞(0)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002148#fatie">
                                                <span>评论(2)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=6511293">
                                        <img src="__IMAGES__/glory/b_201405221053513255912.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=6511293">舞王又回来了</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002147">牛一来晒奖了。。</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-25 09:17</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002147">
                                            &nbsp;&nbsp;&nbsp;我玩蛋蛋有6年了，其实我接触pc有8年了。06年的时候，二哥就玩pc蛋蛋，那时候我们家只有一台联想电脑（显卡是mx440的）。二哥就让我把电脑让给他玩pc蛋蛋，说换了电脑就让我玩新的电脑。那时候换一台手提只要500万，他那时已经有......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002147">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002147">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-05-25/201405250906165103861.jpg;http://fs.pceggs.com/pic/2014-05-25/201405250912487737056.jpg;http://fs.pceggs.com/pic/2014-05-25/201405250916008536920.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002147").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002147"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002147").append('<li ><a href="ShowInfo.aspx?tid=8002147"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002147">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-25/201405250906165103861.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002147">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-25/201405250912487737056.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002147">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-25/201405250916008536920.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002147">
                                                        <img src="__IMAGES__/glory/201405250906165103861.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002147">
                                                        <img src="__IMAGES__/glory/201405250912487737056.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002147">
                                                        <img src="__IMAGES__/glory/201405250916008536920.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002147" href="javascript:AddPraise('8002147','5')">
                                                <span>赞(5)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002147#fatie">
                                                <span>评论(7)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=10886061">
                                        <img src="__IMAGES__/glory/b_mt_11.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=10886061">快乐有你</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002146">东芝移动硬盘500G到手</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-24 21:37</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002146">一直想要一个移动硬盘，昨天终于收到了，非常好。兑奖到收货一星期就收到了。......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002146">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002146">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-05-24/201405242135358050000.jpg;http://fs.pceggs.com/pic/2014-05-24/201405242135579860000.jpg;http://fs.pceggs.com/pic/2014-05-24/201405242136140480000.jpg;http://fs.pceggs.com/pic/2014-05-24/201405242136291870000.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002146").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002146"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002146").append('<li ><a href="ShowInfo.aspx?tid=8002146"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002146">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405242135358050000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002146">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405242135579860000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002146">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405242136140480000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002146">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405242136291870000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002146">
                                                        <img src="__IMAGES__/glory/201405242135358050000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002146">
                                                        <img src="__IMAGES__/glory/201405242135579860000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002146">
                                                        <img src="__IMAGES__/glory/201405242136140480000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002146">
                                                        <img src="__IMAGES__/glory/201405242136291870000.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002146" href="javascript:AddPraise('8002146','2')">
                                                <span>赞(2)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002146#fatie">
                                                <span>评论(0)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=9691452">
                                        <img src="__IMAGES__/glory/b_mt_19.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=9691452">酷雪心飞</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002145">一直盼望的笔记本电脑桌，来了！！！</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-24 21:23</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002145">
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;从去年就开始下定决心要兑换笔记本电脑桌，但是我平时也玩的少，但是为了得到它，试玩游戏，每日的广告体验也是必须的，还会通过淘宝返利去获得。
                                            <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;虽然通过这些途径可以获得......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002145">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002145">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-05-24/201405242122028580182.jpg;http://fs.pceggs.com/pic/2014-05-24/201405242122261913528.jpg;http://fs.pceggs.com/pic/2014-05-24/201405242122465405167.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002145").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002145"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002145").append('<li ><a href="ShowInfo.aspx?tid=8002145"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002145">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405242122028580182.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002145">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405242122261913528.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002145">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405242122465405167.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002145">
                                                        <img src="__IMAGES__/glory/201405242122028580182.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002145">
                                                        <img src="__IMAGES__/glory/201405242122261913528.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002145">
                                                        <img src="__IMAGES__/glory/201405242122465405167.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002145" href="javascript:AddPraise('8002145','2')">
                                                <span>赞(2)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002145#fatie">
                                                <span>评论(0)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=16653287">
                                        <img src="__IMAGES__/glory/b_mt_79.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=16653287">sophiacc</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002144">博洋家纺神速到家，太棒了</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">

                                                <span class="lvjword">+300,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_2.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-24 13:50</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002144">
                                            去年28输了以后，老老实实攒金蛋。玩游戏、购物返利、广告体验，各个能赚蛋的都参与。
                                            <br>
                                            好不容易发展了一个徒弟，可惜这家伙坚持了没几天啊。
                                            <br>
                                            没关系，再去发展看看。
                                            <br>
                                            攒了好多个月啊，终于攒够了一套博洋家纺四件套。
                                            <br>上次的多喜爱自......</a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002144">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002144">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-05-24/201405241345401714154.jpg;http://fs.pceggs.com/pic/2014-05-24/201405241345520510949.jpg;http://fs.pceggs.com/pic/2014-05-24/201405241346039497754.jpg;http://fs.pceggs.com/pic/2014-05-24/201405241346145343808.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002144").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002144"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002144").append('<li ><a href="ShowInfo.aspx?tid=8002144"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002144">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405241345401714154.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002144">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405241345520510949.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002144">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405241346039497754.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002144">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405241346145343808.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002144">
                                                        <img src="__IMAGES__/glory/201405241345401714154.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002144">
                                                        <img src="__IMAGES__/glory/201405241345520510949.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002144">
                                                        <img src="__IMAGES__/glory/201405241346039497754.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002144">
                                                        <img src="__IMAGES__/glory/201405241346145343808.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002144" href="javascript:AddPraise('8002144','1')">
                                                <span>赞(1)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002144#fatie">
                                                <span>评论(2)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_w">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=13417879">
                                        <img src="__IMAGES__/glory/b_mt_06.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=13417879">呼风唤雨</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002143">有电脑，没摄像头，那叫一个鸡肋啊！</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf">
                                                <span class="lanjword">+100,000</span>
                                                <span class="eggs">&nbsp;&nbsp;&nbsp;</span>

                                            </div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg">
                                                <img src="__IMAGES__/glory/pink_1.gif" width="21" height="20"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-24 09:55</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002143">
                                            我的电脑一直没有买摄像头，开语音开视频那叫一个鸡肋啊，只能用手机开，后来想到蛋蛋上有摄像头（其实我就要个麦就行，蛋蛋没有，既然内置麦克，也就无所谓了），还是罗技的，那叫一个欢喜啊，抓紧攒蛋兑换，于是就在某一天的晚上下手了，支持蛋蛋两......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002143">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002143">
                                                <script type="text/javascript">
             var imgs = "http://fs.pceggs.com/pic/2014-05-24/201405240953506942415.jpg;http://fs.pceggs.com/pic/2014-05-24/201405240954029669435.jpg;http://fs.pceggs.com/pic/2014-05-24/201405240954156896712.jpg;http://fs.pceggs.com/pic/2014-05-24/201405240954410771233.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002143").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002143"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002143").append('<li ><a href="ShowInfo.aspx?tid=8002143"><img src="' + img_doms[i] + '_s.jpg" width="76px" height="60px" /></a></li>');

                          }
                      }
                  </script>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002143">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405240953506942415.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002143">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405240954029669435.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="ShowInfo.aspx?tid=8002143">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405240954156896712.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002143">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-24/201405240954410771233.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002143">
                                                        <img src="__IMAGES__/glory/201405240953506942415.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002143">
                                                        <img src="__IMAGES__/glory/201405240954029669435.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li>
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002143">
                                                        <img src="__IMAGES__/glory/201405240954156896712.jpg_s.jpg" width="76px" height="60px"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002143">
                                                        <img src="__IMAGES__/glory/201405240954410771233.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002143" href="javascript:AddPraise('8002143','1')">
                                                <span>赞(1)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002143#fatie">
                                                <span>评论(4)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tlq_beta3_sj_box_g">
                            <div class="tlq_beta3_sj_box_w_l">
                                <div class="tlq_beta3_sj_box_w_l_img">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17532553">
                                        <img src="__IMAGES__/glory/b_mt_45.jpg"></a>
                                </div>
                                <div class="tlq_beta3_sj_box_w_l_name">
                                    <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17532553">名字不用太长像我这样就好</a>
                                </div>
                            </div>
                            <div class="tlq_beta3_sj_box_w_r">
                                <div class="tlq_beta3_sj_box_w_r_top">
                                    <div class="tlq_beta3_sj_box_w_r_top_l">
                                        <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002142">雷蛇鼠标终于到手了！</a>
                                        </div>

                                        <div class="tlq_beta3_sj_box_w_r_top_l_r">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpf"></div>
                                            <div class="tlq_beta3_sj_box_w_r_top_l_rpfimg"></div>

                                        </div>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：05-23 14:23</div>
                                </div>
                                <div class="tlq_beta3_sj_xuxian"></div>
                                <div class="tlq_beta3_sj_box_w_r_bottom">
                                    <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                        <a style="color:black" class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002142">
                                            大家好！我是一名大学生，在朋友的介绍下认识了pc蛋蛋这个网站，期间蛋蛋无数次的归零好几次想要放弃但是还是坚持下来了，在这里感谢pc蛋蛋工作人员的支持和付出，感谢pc蛋蛋这个网站，下面开始砸图。......
                                        </a>
                                        <br>
                                        <a class="linkblue_a1" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002142">[详细]</a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                            <ul id="ul_8002142">
                                                <script type="text/javascript">
                      var imgs = "http://fs.pceggs.com/pic/2014-05-23/201405231422544822966.jpg;";
                      img_doms = imgs.split(";");

                      for (var i = 0; i < img_doms.length-1; i++) {

                          if (i + 1 == img_doms.length-1) {
                              $("#ul_8002142").append('<li style="margin-left:0px;"><a href="ShowInfo.aspx?tid=8002142"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');
                          } else {
                              $("#ul_8002142").append('<li ><a href="ShowInfo.aspx?tid=8002142"><img src="' + img_doms[i] + '_s.jpg" width="76" height="60" /></a></li>');

                          }
                      }
                  </script>
                                                <li style="margin-left:0px;">
                                                    <a href="ShowInfo.aspx?tid=8002142">
                                                        <img src="http://fs.pceggs.com/pic/2014-05-23/201405231422544822966.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                                <li style="margin-left:0px;">
                                                    <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002142">
                                                        <img src="__IMAGES__/glory/201405231422544822966.jpg_s.jpg" width="76" height="60"></a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r_b ">
                                            <a class="z_an" id="z_an8002142" href="javascript:AddPraise('8002142','0')">
                                                <span>赞(0)</span>
                                            </a>
                                            &nbsp;&nbsp;&nbsp;
                                            <a class="pl_an" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002142#fatie">
                                                <span>评论(1)</span>
                                            </a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="discuss_ft" style="width:950px; height:60px; margin:0 auto; ">
                        <div class="discuss_ftr" style="width:600px; height:60px;  margin:0 auto; text-align:center;margin-top:20px;">

                            <script language="javascript" type="text/javascript">
    function onsubmit(CurrentPageIndex)
    {
        //document.getElementById("CurrentPageIndex").value = CurrentPageIndex ;
        //document.getElementById("pagination").action=window.location;
        //document.getElementById("pagination").submit();
        var CurrentURL = document.URL;
        var right = GetQueryString("CurrentPageIndex")
        if(right == "")
        {
            if(CurrentURL.indexOf("?") > -1){
                CurrentURL = CurrentURL + "&CurrentPageIndex="+CurrentPageIndex;
            }else{
                CurrentURL = CurrentURL + "?CurrentPageIndex="+CurrentPageIndex;
            }
        }else{
            CurrentURL = CurrentURL.replace("CurrentPageIndex="+right,"CurrentPageIndex="+CurrentPageIndex);
        }
        document.location.href=CurrentURL;
    }
    
    function GetQueryString(name) {
       var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)","i");
       var r = window.location.search.substr(1).match(reg);
       if (r!=null) return unescape(r[2]); return "";
    }
</script>
                            <style type="text/css">
<!--
/*page*/
.pageb {float:right;padding:8px 0px 10px 0px;*padding:8px 0px 12px 0px;font:12px/1.5 'lucida grande',tahoma,arial,'bitstream vera sans',helvetica,sans-serif;font-size:12px;}
.pageb a{padding:2px 5px 2px 5px;margin-left:2px;color:#333;border:#ccc 1px solid;text-decoration:none;}
.pageb a:hover{padding:2px 5px 2px 5px;margin-left:2px;border:#9A9A9A 1px solid;background:#E6E7E9;text-decoration:none;color:#333;}
.pageb a:active {padding:2px 5px 2px 5px;margin-left:2px;border:#333 1px solid;}
.pageb .current {padding:2px 5px 2px 5px;margin-left:2px;border:#9A9A9A 1px solid; background:#DaDaDa;font-weight:bold;}
-->
</style>

                            <div class="pageb">
                                <a href="javascript:onsubmit(1);">&lt;&lt;</a>
                                <a href="javascript:onsubmit(1);">&lt;</a>
                                <a class="current">1</a>
                                <a href="javascript:onsubmit(2);" target="_top">2</a>
                                <a href="javascript:onsubmit(3);" target="_top">3</a>
                                <a href="javascript:onsubmit(4);" target="_top">4</a>
                                <a href="javascript:onsubmit(5);" target="_top">5</a>
                                <a href="javascript:onsubmit(6);" target="_top">6</a>
                                <a href="javascript:onsubmit(7);" target="_top">7</a>
                                <a href="javascript:onsubmit(8);" target="_top">8</a>
                                <a href="javascript:onsubmit(9);" target="_top">9</a>
                                <a href="javascript:onsubmit(10);" target="_top">10</a>
                                <a href="javascript:onsubmit(2);">&gt;</a>
                                <a href="javascript:onsubmit(32);">&gt;&gt;</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="topNav" style="display: none;">
                    <a href="http://www.pceggs.com/ShowPrize/ShowList.aspx?topicid=1#totop" style="float:right;">
                        <img src="__IMAGES__/glory/tlq_beta3_totopimg.gif" width="47"></a>
                </div>
                <div class="footer_redline"></div>
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