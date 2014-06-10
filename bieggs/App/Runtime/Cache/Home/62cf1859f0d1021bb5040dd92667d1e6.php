<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><!-- InstanceBegin template="/Templates/navi_temp.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<!-- InstanceBeginEditable name="doctitle" -->
    <title>团购-专业的广告游戏平台</title>
    <link rel="stylesheet" type="text/css" href="__CSS__/naviation.css" />
    <link rel="stylesheet" type="text/css" href="__CSS__/com.css" />
    <link rel="stylesheet" type="text/css" href="__CSS__/activity.css" />
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
        <div class="likebody">
            <script type="text/javascript">
    function showjj(id) {
        $("#hdjjdiv" + id).toggle();
    }
</script>
            <div class="wal">
                <div class="pageBox activityList">
                    <div class="tab">
                        <ul>
                            <li class="liNow" onclick="location.href='index.aspx'">正在进行的活动</li>
                            <li onclick="location.href='index.aspx?js=1'">已经结束的活动</li>
                        </ul>
                    </div>
                    <div class="tabContentDiv">
                        <div class="tabContent" style="display: block;">
                            <ul style="margin-bottom: 10px;">

                                <li>
                                    <div class="imgDiv">
                                        <a href="">
                                            <img src="__IMAGES__/activity/pic2014042912113024.jpg" alt=""></a>
                                    </div>
                                    <h2>

                                        <a href="http://www.81dou.com/hd/action.aspx?hdid=10" target="_blank">81豆争霸赛（第二期）</a>

                                    </h2>
                                    <div class="content">
                                        活动时间：
                                        <span>2014-04-29至2014-05-12</span>
                                        <br>
                                        参加对象：
                                        <span>所有认证会员</span>
                                        <br>
                                        活动简介：
                                        <span style="cursor:pointer; color:#067AE5;" onclick="showjj(10)">点击查看活动详情 &gt;&gt;</span>
                                    </div>
                                    <a href="http://www.81dou.com/hd/index.aspx?cjid=10" class="btn">
                                        <img src="__IMAGES__/activity/btn1.gif" alt=""></a>
                                    <div style="display: none;margin-bottom: 20px;" id="hdjjdiv10"> <strong><span style="font-size:14px;">点击右边的立即参加即可→</span></strong> 
                                    </div>
                                </li>

                                <li>
                                    <div class="imgDiv">
                                        <a href="">
                                            <img src="__IMAGES__/activity/pic2014041506413824.jpg" alt=""></a>
                                    </div>
                                    <h2>

                                        <a href="">兑兑碰周榜(第一期)</a>

                                    </h2>
                                    <div class="content">
                                        活动时间：
                                        <span>2014-04-21至2015-04-21</span>
                                        <br>
                                        参加对象：
                                        <span>LV1以上用户</span>
                                        <br>
                                        活动简介：
                                        <span style="cursor:pointer; color:#067AE5;" onclick="showjj(9)">点击查看活动详情 &gt;&gt;</span>
                                    </div>
                                    <a href="http://www.81dou.com/hd/index.aspx?cjid=9" class="btn">
                                        <img src="__IMAGES__/activity/btn1.gif" alt=""></a>
                                    <div style="display: none;margin-bottom: 20px;" id="hdjjdiv9"> <strong><span style="font-size:14px;">应广大玩家要求，我们再次对兑兑碰游戏活动升级，特推出兑兑碰周榜活动，欢迎大家积极参与！</span>
                                            <span style="color:#E56600;font-size:14px;">如您游戏过程中遇到什么问题请联系右上方的在线客服，谢谢您的配合！</span></strong> 
                                        <p style="text-align:left;">
                                            <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                <strong>
                                                    <br></strong>
                                            </span>
                                        </p>
                                        <p style="text-align:left;">
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                <strong>活动规则：兑兑碰上周冠军榜</strong>
                                            </span>
                                        </p>
                                        <p>
                                            <br></p>
                                        <p>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                    <strong>
                                                        <span style="font-size:14px;">奖励人数：</span>
                                                        <span style="color:#E53333;font-size:14px;">前10名，所有用户均可参加！</span>
                                                    </strong>
                                                </span>
                                            </span>
                                        </p>
                                        <p>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                    <br></span>
                                            </span>
                                        </p>
                                        <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                            第
                                            <span style="color:#003399;">
                                                <strong>一</strong>
                                            </span>
                                            名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </span>
                                        <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                                        <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;奖励：
                                            <strong>3,00</strong>
                                            <strong>0,000&nbsp;</strong>
                                            &nbsp;&nbsp;&nbsp;豆 +
                                        </span>
                                        <span style="color:#99BB00;line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                            <strong>绿钻会员 3个月&nbsp;</strong>
                                        </span>
                                        <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                            <br>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                第
                                                <strong>
                                                    <span style="color:#003399;">二</span>
                                                </strong>
                                                名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            </span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;奖励：
                                                <strong>2,0</strong>
                                            </span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                <strong>00</strong>
                                            </span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                <strong>,000&nbsp;&nbsp;&nbsp; &nbsp;</strong>
                                                豆 +
                                                <span style="color:#99BB00;">
                                                    <strong>绿钻会员 2个月</strong>
                                                </span>
                                            </span>
                                            <br>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                第
                                                <span style="color:#003399;">三</span>
                                                名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            </span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;奖励：
                                                <strong>1,00</strong>
                                                <strong>0,000</strong>
                                                &nbsp;&nbsp;&nbsp; 豆 +&nbsp;
                                                <strong>
                                                    <span style="color:#99BB00;">绿钻会员 1个月</span>
                                                </strong>
                                            </span>
                                            <br>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                第
                                                <span style="color:#003399;">四</span>
                                                名至第
                                                <span style="color:#003399;">十</span>
                                                名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;奖
                                            </span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                励：
                                                <strong>
                                                    <span style="color:#99BB00;">绿钻会员1个月</span>
                                                </strong>
                                            </span>
                                            <br></span>
                                        <p>
                                            <br></p>
                                        <span>
                                            <div style="text-align:left;">
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;"></span>
                                            </div>
                                            <span style="font-size:14px;">
                                                <div style="text-align:left;">
                                                    <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;"></span>
                                                </div>
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                    <div style="text-align:left;"></div>
                                                </span>
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                    <div style="text-align:left;"></div>
                                                </span>
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                    <div style="text-align:left;"></div>
                                                </span>
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                    <div style="text-align:left;"></div>
                                                </span>
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                    <div style="text-align:left;"></div>
                                                </span>
                                            </span>
                                        </span>
                                        <p>
                                            <span style="font-size:14px;">
                                                <strong>
                                                    <br></strong>
                                            </span>
                                            <span style="color:#006600;font-size:14px;">
                                                <strong>奖励在每周一发放。</strong>
                                            </span>
                                        </p>
                                        <p>
                                            <span></span>
                                            <strong>
                                                <span style="font-size:14px;">&nbsp;</span>
                                            </strong>
                                        </p>
                                        <p>
                                            <span style="font-size:14px;">
                                                <strong>兑兑碰游戏是81豆推出的一个数字游戏，每天可以免费领取500万虚拟豆进行游戏！</strong>
                                            </span>
                                        </p>
                                    </div>
                                </li>

                                <li>
                                    <div class="imgDiv">
                                        <a href="">
                                            <img src="__IMAGES__/activity/pic201402130341111.jpg" alt=""></a>
                                    </div>
                                    <h2>

                                        <a href="">兑兑碰日榜(第一期)</a>

                                    </h2>
                                    <div class="content">
                                        活动时间：
                                        <span>2014-04-10至2015-04-10</span>
                                        <br>
                                        参加对象：
                                        <span>LV1以上用户</span>
                                        <br>
                                        活动简介：
                                        <span style="cursor:pointer; color:#067AE5;" onclick="showjj(5)">点击查看活动详情 &gt;&gt;</span>
                                    </div>
                                    <a href="http://www.81dou.com/hd/index.aspx?cjid=5" class="btn">
                                        <img src="__IMAGES__/activity/btn1.gif" alt=""></a>
                                    <div style="display: none;margin-bottom: 20px;" id="hdjjdiv5">
                                        <p style="text-align:left;">
                                            <strong>
                                                <span>
                                                    <span style="font-size:14px;">为了感谢各位玩家的支持，81豆新活动</span>
                                                    <span>
                                                        <span style="font-size:14px;background-color:#FFFFFF;">兑兑碰天天</span>
                                                        <span>
                                                            <span style="font-size:14px;">送</span>
                                                            <span style="font-size:14px;">第一期开始啦！</span>
                                                        </span>
                                                    </span>
                                                </span>
                                            </strong>
                                        </p>
                                        <p style="text-align:left;">
                                            <br></p>
                                        <p style="text-align:left;">
                                            <span style="font-size:14px;">
                                                <strong>活动规则：兑兑碰今日排行榜</strong>
                                            </span>
                                        </p>
                                        <p style="text-align:left;">
                                            <br></p>
                                        <p style="text-align:left;">
                                            <span style="font-size:14px;">
                                                <strong>
                                                    奖励人数：
                                                    <span style="color:#003399;">前30名，所有用户均可参加！</span>
                                                </strong>
                                            </span>
                                        </p>
                                        <p style="text-align:left;">
                                            <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                    <br>&nbsp;</span>
                                            </span>
                                        </p>
                                        <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                            第
                                            <span style="color:#003399;">
                                                <strong>一</strong>
                                            </span>
                                            名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </span>
                                        <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                                        <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;奖励：
                                            <strong>30</strong>
                                            <strong>0,000&nbsp;</strong>
                                            &nbsp;&nbsp;&nbsp;豆 +
                                        </span>
                                        <span style="color:#99BB00;line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                            <strong>绿钻会员 1个月&nbsp;</strong>
                                        </span>
                                        <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                            <br>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                第
                                                <strong>
                                                    <span style="color:#003399;">二</span>
                                                </strong>
                                                名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            </span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;奖励：
                                                <strong>3</strong>
                                            </span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                <strong>00</strong>
                                            </span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                <strong>,000&nbsp;&nbsp;&nbsp; &nbsp;</strong>
                                                豆
                                            </span>
                                            <br>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                第
                                                <span style="color:#003399;">三</span>
                                                名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            </span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;奖励：
                                                <strong>20</strong>
                                                <strong>0,000</strong>
                                                &nbsp;&nbsp;&nbsp; 豆
                                            </span>
                                            <br>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                第
                                                <span style="color:#003399;">四</span>
                                                名至第
                                                <span style="color:#003399;">十</span>
                                                名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;奖
                                            </span>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                励：
                                                <strong>100,000&nbsp;</strong>
                                                &nbsp;&nbsp; 豆
                                            </span>
                                            <br>
                                            <span style="line-height:normal;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
                                                第
                                                <span style="color:#003399;">十一</span>
                                                名至第
                                                <span style="color:#4C33E5;">三</span>
                                                <span style="color:#003399;">十</span>
                                                名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;奖励：
                                                <strong>50</strong>
                                                <strong>,000</strong>
                                                &nbsp;&nbsp;&nbsp;&nbsp; 豆
                                            </span>
                                        </span>
                                        <p>
                                            <br></p>
                                        <span>
                                            <div style="text-align:left;">
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;"></span>
                                            </div>
                                            <span style="font-size:14px;">
                                                <div style="text-align:left;">
                                                    <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;"></span>
                                                </div>
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                    <div style="text-align:left;"></div>
                                                </span>
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                    <div style="text-align:left;"></div>
                                                </span>
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                    <div style="text-align:left;"></div>
                                                </span>
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                    <div style="text-align:left;"></div>
                                                </span>
                                                <span style="line-height:normal;font-family:sans-serif;font-size:small;background-color:#FFFFFF;">
                                                    <div style="text-align:left;"></div>
                                                </span>
                                            </span>
                                        </span>
                                        <p>
                                            <span style="font-size:14px;">
                                                <strong>
                                                    <br></strong>
                                            </span>
                                            <span style="color:#006600;font-size:14px;">
                                                <strong>奖励在第二天发放。</strong>
                                            </span>
                                        </p>
                                        <p>
                                            <span></span>
                                            <strong>
                                                <span style="font-size:14px;">&nbsp;</span>
                                            </strong>
                                        </p>
                                        <p>
                                            <span style="font-size:14px;">
                                                <strong>兑兑碰游戏是81豆推出的一个数字游戏，每天可以免费领取500万虚拟豆进行游戏！</strong>
                                            </span>
                                        </p>
                                        <p>
                                            <br></p>
                                        <span></span>
                                        <p>
                                            <span>
                                                <span>
                                                    <span style="color:#4C33E5;">
                                                        <a href="http://www.81dou.com/game/ddp/index.aspx" target="_blank">
                                                            <span style="color:#4C33E5;font-size:14px;">
                                                                <strong>参加游戏</strong>
                                                            </span>
                                                        </a>
                                                        <span style="color:#4C33E5;font-size:14px;">
                                                            <strong>&nbsp;</strong>
                                                        </span>
                                                        <span style="color:#4C33E5;font-size:14px;">
                                                            <strong>
                                                                <a href="http://www.81dou.com/ph/index.aspx" target="_blank">
                                                                    <span style="color:#4C33E5;background-color:#FFFFFF;">查看排名</span>
                                                                </a>
                                                            </strong>
                                                        </span>
                                                    </span>
                                                </span>
                                            </span>
                                        </p>
                                    </div>
                                </li>

                                <li>
                                    <div class="imgDiv">
                                        <a href="">
                                            <img src="__IMAGES__/activity/pic201402130334501.jpg" alt=""></a>
                                    </div>
                                    <h2>

                                        <a href="">天天乐(第一期)</a>

                                    </h2>
                                    <div class="content">
                                        活动时间：
                                        <span>2014-04-10至2015-04-10</span>
                                        <br>
                                        参加对象：
                                        <span>所有认证会员</span>
                                        <br>
                                        活动简介：
                                        <span style="cursor:pointer; color:#067AE5;" onclick="showjj(4)">点击查看活动详情 &gt;&gt;</span>
                                    </div>
                                    <a href="http://www.81dou.com/hd/index.aspx?cjid=4" class="btn">
                                        <img src="__IMAGES__/activity/btn1.gif" alt=""></a>
                                    <div style="display: none;margin-bottom: 20px;" id="hdjjdiv4">
                                        <p>
                                            <span style="font-size:14px;">
                                                <strong>为了感谢各位豆友的支持,81豆会拿出最大的诚意，最多的利益回馈给广大豆友。</strong>
                                            </span>
                                        </p>
                                        <p>
                                            <br></p>
                                        <p>
                                            <span style="font-size:14px;">
                                                <strong>
                                                    游戏规则：
                                                    <span style="color:#E53333;background-color:#FFFFFF;">登上“</span>
                                                    <span style="color:#E53333;background-color:#FFFFFF;">今日盈利排行</span>
                                                    <span style="color:#E53333;background-color:#FFFFFF;">”榜</span>
                                                </strong>
                                            </span>
                                        </p>
                                        <p>
                                            <span style="font-size:14px;">
                                                <strong>
                                                    <span style="color:#E53333;background-color:#FFFFFF;">
                                                        <br></span>
                                                </strong>
                                            </span>
                                        </p>
                                        <p>
                                            <span style="font-size:14px;">
                                                <strong>
                                                    <span style="color:#E53333;background-color:#FFFFFF;">
                                                        <br>&nbsp;</span>
                                                </strong>
                                            </span>
                                            <span style="font-size:14px;">
                                                <strong>
                                                    <br>
                                                    奖励人数：前10名
                                                    <br>&nbsp;</strong>
                                            </span>
                                            <strong>
                                                <br></strong>
                                        </p>
                                        <p>
                                            <span style="font-size:14px;">
                                                <strong>当天排行榜第一名：奖励纯盈利10% （不设上限）+50w超级幸运奖</strong>
                                            </span>
                                            <br>
                                            <span style="font-size:14px;">
                                                <strong>
                                                    当天排行榜第二名：奖励纯盈利9%&nbsp;&nbsp; （不设上限）+
                                                    <span style="color:#FF9900;">绿钻会员一个月</span>
                                                </strong>
                                            </span>
                                            <br>
                                            <span style="font-size:14px;">
                                                <strong>当天排行榜第三名：奖励纯盈利8%&nbsp;&nbsp; （不设上限）</strong>
                                            </span>
                                            <br>
                                            <span style="font-size:14px;">
                                                <strong>当天排行榜第四名：奖励纯盈利7%&nbsp;&nbsp; （不设上限）</strong>
                                            </span>
                                            <br>
                                            <span style="font-size:14px;">
                                                <strong>当天排行榜第五名：奖励纯盈利6%&nbsp;&nbsp; （不设上限）</strong>
                                            </span>
                                            <br>
                                            <span style="font-size:14px;">
                                                <strong>当天排行榜第六名：奖励纯盈利5%&nbsp;&nbsp; （不设上限）</strong>
                                            </span>
                                            <br>
                                            <span style="font-size:14px;">
                                                <strong>当天排行榜第七名：奖励纯盈利4%&nbsp;&nbsp; （不设上限）</strong>
                                            </span>
                                            <br>
                                            <span style="font-size:14px;">
                                                <strong>当天排行榜第八名：奖励纯盈利3%&nbsp;&nbsp; （不设上限）</strong>
                                            </span>
                                            <br>
                                            <span style="font-size:14px;">
                                                <strong>当天排行榜第九名：奖励纯盈利2%&nbsp; &nbsp;（不设上限）</strong>
                                            </span>
                                            <br>
                                            <span style="font-size:14px;">
                                                <strong>当天排行榜第十名：奖励纯盈利1%&nbsp;&nbsp; （不设上限）</strong>
                                            </span>
                                        </p>
                                        <p>
                                            <span style="font-size:14px;">
                                                <strong>幸运奖励：价值300元的绿钻会员卡一张</strong>
                                            </span>
                                        </p>
                                        <p>
                                            <strong>
                                                <span style="font-size:14px;">超级幸运奖：500,000 吧豆</span>
                                            </strong>
                                        </p>
                                        <p>
                                            <span style="font-size:14px;">
                                                <br></span>
                                        </p>
                                        <p>
                                            <span style="font-size:14px;">
                                                幸运奖励说明：
                                                <span style="color:#E56600;">
                                                    PK10 每天23点57分我们取前三位作为获得幸运奖励的玩家，如开奖号码前三位为8、4、2，也即当日排行榜的第8、4、2名多获得一张绿钻会员卡的幸运奖励！
                                                </span>
                                            </span>
                                        </p>
                                        <p>
                                            <br></p>
                                        <p>
                                            <span style="font-size:14px;">
                                                <span style="color:#E56600;">
                                                    <span style="color:#000000;">超级幸运奖说明</span>
                                                    ：PK22 每天23点57分我们取最后一期的开奖结果加3和减3，共计3名作为获得超级幸运奖的玩家，如开奖结果为27，也即当日排行榜的第24、27、30名获得超级幸运奖！
                                                </span>
                                            </span>
                                        </p>
                                        <p>
                                            <span style="color:#4C33E5;font-size:14px;">
                                                <span style="color:#4C33E5;">
                                                    <strong>
                                                        <br></strong>
                                                </span>
                                            </span>
                                        </p>
                                        <p>
                                            <span style="color:#4C33E5;font-size:14px;">
                                                <span style="color:#4C33E5;">
                                                    <strong>注：以上奖励均可叠加获得！</strong>
                                                </span>
                                            </span>
                                        </p>
                                        <p>
                                            <br></p>
                                        <p>
                                            <strong>
                                                <span style="color:#006600;font-size:14px;">
                                                    <span style="color:#006600;font-size:14px;">奖励在第二天发放.</span>
                                                </span>
                                            </strong>
                                        </p>
                                        <p>
                                            <br></p>
                                        <p>
                                            <strong>
                                                <span>
                                                    <span style="color:#E56600;font-size:14px;">注：</span>
                                                    <span style="color:#E56600;font-size:14px;">郑重警告，刷排名一经查出账号清零、冻结，永不解冻。</span>
                                                </span>
                                            </strong>
                                        </p>
                                    </div>
                                </li>

                            </ul>
                            <div class="pager">
                                第 1/1 页&nbsp;共 4 条&nbsp;每页显示 10 条&nbsp;&nbsp;
                                <span class="disabled">&lt;</span>
                                <span class="current">1</span>
                                <a class="disabled">&gt;</a>
                            </div>
                        </div>
                    </div>
                </div>
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