<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><!-- InstanceBegin template="/Templates/navi_temp.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<!-- InstanceBeginEditable name="doctitle" -->
    <title>团购-专业的广告游戏平台</title>
    <link rel="stylesheet" type="text/css" href="__CSS__/naviation.css" />
    <link rel="stylesheet" type="text/css" href="__CSS__/com.css" />
    <link rel="stylesheet" type="text/css" href="__CSS__/buy.css" />
    <link rel="stylesheet" type="text/css" href="__CSS__/footer.css" />

<style type="text/css">
    #topNav {
    width: 47px;
    z-index: 100;                                                     /*设置浮动层次*/
    overflow: visible;
    position: fixed;
    bottom: 210px;
    /*bottom: 330px;*/
    margin-left:980px;                                                        /* 其他浏览器下定位，在这里可设置坐标*/
    _position: absolute;                                       /*IE6 用absolute模拟fixed*/
    _top: expression(documentElement.scrollTop + documentElement.clientHeight-230 + "px"); /*IE6 动态设置top位置*/
    /* documentElement.scrollTop 设置浮动元素始终在浏览器最顶，可以加一个数值达到排版效果 */
    height: 63px;
    }
</style>

<script language="javascript" type="text/javascript">
    function TabInfo(id) {
        if (id == '1') {
            document.getElementById('duo1').className = 'on _toggle_nav';
            document.getElementById('duo2').className = '_toggle_nav';
            document.getElementById('duo3').className = '_toggle_nav';
            document.getElementById('d_explain').style.display = '';
            document.getElementById('d_record').style.display = 'none';
            document.getElementById('d_rule').style.display = 'none';
        }
        if (id == '2') {
            document.getElementById('duo1').className = '_toggle_nav';
            document.getElementById('duo2').className = 'on _toggle_nav';
            document.getElementById('duo3').className = '_toggle_nav';
            document.getElementById('d_record').style.display = '';
            document.getElementById('d_explain').style.display = 'none';
            document.getElementById('d_rule').style.display = 'none';
        }
        if (id == '3') {
            document.getElementById('duo1').className = '_toggle_nav';
            document.getElementById('duo2').className = '_toggle_nav';
            document.getElementById('duo3').className = 'on _toggle_nav';
            document.getElementById('d_rule').style.display = '';
            document.getElementById('d_explain').style.display = 'none';
            document.getElementById('d_record').style.display = 'none';
            rm('div_ad');
        }
    }
    $(function () {
        $('#dialog0').dialog({
            autoOpen: false,
            modal: true,
            height: 160,
            width: 360
        });
        $('#dialog1').dialog({
            autoOpen: false,
            modal: true,
            height: 160,
            width: 360
        });
    });
    function colsedialog(d) {
        $("#" + d).dialog("close");
    }
    function opendialog(id) {
        $("#dialog" + id).dialog("open");
    }
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
            <div id="topNav" style="">
                <a href="http://www.pceggs.com/duobao/duobao_index.aspx#totop" style="float:right;">
                    <img src="__IMAGES__/tuan/tlq_beta3_totopimg.gif" width="47"></a>
            </div>
            <div class="pc_step" style="padding-top: 0px">
                <a href="http://www.pceggs.com/duobao/dbstep.aspx">
                    <img src="__IMAGES__/tuan/db_step.gif" width="950" height="56"></a>
            </div>
            <div class="pc_line">
                <div class="pc_left">
                    <div class="pc_le" style="margin-bottom: -6px;">
                        <div style="position:absolute; margin-left:625px; margin-top:10px;_margin-top:12px;   font-size:14px; ">
                            <img src="__IMAGES__/tuan/wddb_tb.jpg" align="absmiddle">
                            &nbsp;
                            <a href="http://www.pceggs.com/myaccount/myduobao.aspx" style="color:#F8E0E9; text-decoration:none;">我的夺宝</a>
                        </div>
                        <div class="header_2">
                            <ul class="nav_main">
                                <li class="nav_basic">
                                    <a class="current" title="当前夺宝" href="__IMAGES__/tuan/蛋蛋夺宝_PC蛋蛋_夺宝.htm"> <strong id="test">当前夺宝</strong>
                                    </a> <sup class="ico_current">当前</sup>
                                </li>
                                <li class="nav_basic">
                                    <a title="下期夺宝" href="http://www.pceggs.com/duobao/duobao_next.aspx"> <strong>下期夺宝</strong>
                                    </a>
                                </li>
                                <li class="nav_basic">
                                    <a title="往期夺宝" href="http://www.pceggs.com/duobao/duobao_historylist.aspx">
                                        <strong>往期夺宝</strong>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="pc_le">
                        <!--正在开始中-->
                        <!--未开始-->
                        <div class="basic_buy_group" style="width:694px;height:auto;">
                            <div class="number_bt">1</div>
                            <div class="hd">
                                <table width="660" height="139" border="0" cellpadding="0" cellspacing="0">
                                    <tbody>
                                        <tr>
                                            <td valign="middle">
                                                <h3>
                                                    【2014060402期】仅需10000 抢夺TP-LINK TL-WR720N 150M迷你型3G无线路由器。PC蛋蛋全新游戏，人人都有机会中奖， <font color="bule">采用第三方数据开奖，绝对公正公平公开</font>
                                                    ！
                                                </h3>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>

                            <div class="attribute">

                                <span id="d_content">
                                    <!--正在开始中-->

                                    <div style="height:105px; width:208px;">
                                        <div class="fheggs">
                                            <div class="fjd">需要：</div>
                                            <div class="fjd c_tx5">2,030万</div>
                                            <div class="fjdl">
                                                <a style="text-decoration:none;color:#515151;" title="金蛋是PC蛋蛋的虚拟币。金蛋可以兑换实物奖品，可以通过试玩游戏等获得金蛋奖励。">&nbsp;金蛋</a>
                                            </div>
                                        </div>
                                        <div class="fhjdt">
                                            <div class="fjd_jdtwz">进度：</div>
                                            <div class="fjd_jdt">
                                                <div class="fjd_jdt_act" style="width:55.62%; "></div>
                                            </div>
                                            <div class="fjd_jdsz">55.62%</div>
                                        </div>
                                        <div class="current_dbjd" style="margin-top:1px; text-align:center;width:208px;">
                                            <span style="color:#E10000;">10000</span>
                                            <a style="text-decoration:none; color:#515151;" title="金蛋是PC蛋蛋的虚拟币。金蛋可以兑换实物奖品，可以通过试玩游戏等获得金蛋奖励。">金蛋</a>
                                            拍
                                            <span style="color:#E10000;">1</span>
                                            组,
                                            <span style="color:#E10000;">集齐即开奖</span>
                                            ！
                                        </div>
                                    </div>
                                    <div class="price_attr">
                                        <p class="current_price">
                                            <button type="button" id="Button1" style="border:0px;" onclick="FCShow(&#39;div_ad&#39;);">购买</button>
                                        </p>
                                    </div>

                                    <div class="current_dbjd" id="lastone">
                                        <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=17596263">17596263</a>
                                        刚扔了
                                        <span class="c_tx6" style="font-weight:normal;">20000</span>
                                        <a style="text-decoration:none;color:#515151;" title="金蛋是PC蛋蛋的虚拟币。金蛋可以兑换实物奖品，可以通过试玩游戏等获得金蛋奖励。">金蛋</a>
                                    </div>

                                    <script>

    function changelastuser() {
        var id = "10002989";
        var price = "10000";
        $.ajax({
            type: "POST",
            data: { 'action': 'dbdt', 'id': id, 'price': price },
            url: "doubaoajax.aspx",
            dataType: "json",
            error: function () {

            },
            success: function (data, textStatus) {
                if (data.msg != "") {
                    $("#lastone").css("display", "");
                    $("#lastone").html(data.msg);
                }
            }
        });
        setTimeout("changelastuser()", 10000);

    }
    changelastuser();





</script>

                                    <div class="current_dbjd" style="margin-top:5px;">
                                        <a onclick="TabInfo(3)" style="text-decoration:underline;cursor:pointer;" href="http://www.pceggs.com/duobao/duobao_index.aspx#d4">如何免费获得金蛋</a>
                                    </div>
                                    <div class="current_dbjd" style="font-size:12px;margin-top:5px; color:#9C9C9C;">
                                        本期夺宝为期：
                                        <span style="color:#000000; font-weight:bold;">2天</span>
                                    </div>

                                </span>

                                <div style="border-bottom:1px dotted #B1B1B1; height:10px; font-size:0px; line-height:0px;"></div>

                                <div style="margin-left:10px; font-size:12px; margin-bottom:10px;">
                                    <div class="jddb_sm">
                                        <ul>
                                            <li style="padding-top:4px;">
                                                <img src="__IMAGES__/tuan/jddb_tb1.gif"></li>
                                            <li style="padding-left:3px;">
                                                中奖依据
                                                <a href="http://kaijiang.500wan.com/ssc.shtml" target="_blank" style="text-decoration:underline;">重庆时时彩</a>
                                                ,
                                                <a onclick="TabInfo(3)" style="text-decoration:underline;cursor:pointer;" href="http://www.pceggs.com/duobao/duobao_index.aspx#d3">查看规则</a>
                                            </li>
                                        </ul>
                                    </div>
                                    <div class="jddb_sm">
                                        <ul>
                                            <li style="padding-top:4px;">
                                                <img src="__IMAGES__/tuan/jddb_tb2.gif"></li>
                                            <li style="padding-left:3px;">
                                                开奖
                                                <span style="color:#FF0000">100%</span>
                                                有人中奖且只
                                                <span style="color:#FF0000">1</span>
                                                人中奖
                                            </li>
                                        </ul>
                                    </div>
                                    <div class="jddb_sm">
                                        <ul>
                                            <li style="padding-top:4px;">
                                                <img src="__IMAGES__/tuan/jddb_tb3.gif"></li>
                                            <li style="padding-left:3px;">领奖不收取任何费用</li>
                                        </ul>
                                    </div>
                                </div>

                            </div>

                            <div class="photo">
                                <img src="__IMAGES__/tuan/2014052603_l.jpg" border="0"></div>
                        </div>

                        <!--已开奖结束--> </div>
                    <div class="pc_le">
                        <div class="site_push">
                            <div class="push_nav">
                                <div class="nav_title">
                                    <div style="float: left" class="title_left">
                                        <span>
                                            <a onclick="TabInfo(&#39;1&#39;)" class="on _toggle_nav" id="duo1" style="text-align: center;">夺宝详情</a>
                                        </span>
                                        <span>
                                            <a onclick="TabInfo(&#39;2&#39;)" class="_toggle_nav" id="duo2" style="text-align: center;">参与记录</a>
                                        </span>
                                        <span>
                                            <a onclick="TabInfo(&#39;3&#39;)" class="_toggle_nav" id="duo3" style="text-align:center;">夺宝规则</a>
                                        </span>
                                    </div>
                                </div>
                                <!--夺宝详情-->
                                <div class="nav_explain" id="d_explain">
                                    <div class="con">
                                        <div class="tbtx">
                                            <p>
                                                <span class="c_tx6" style="font-size:12px">特别提醒：</span>
                                            </p>
                                            <p>
                                                <strong>1.&nbsp;</strong>
                                                奖品由PC蛋蛋采购寄送，寄送前我们会电话联系核实，需夺宝人亲自签收有效；
                                                <br>
                                                <strong>2.&nbsp;</strong>
                                                快递物流费用由PC蛋蛋承担，夺宝人无需支付任何费用；
                                                <br>
                                                <strong>3.&nbsp;</strong>
                                                快递一般采用普通快递方式，偏远地区则会采用邮政EMS寄送奖品。
                                                <br>
                                                <strong>4.&nbsp;</strong>
                                                如遇奖品缺货或者停产，客服会联系夺宝人协商处理，可以换取同等价值奖品。
                                            </p>
                                        </div>
                                        <div class="hdwz">宝贝展示</div>
                                        <div class="spjttp">
                                            <img src="__IMAGES__/tuan/2014052603_1.jpg"></div>
                                        <div class="spjttp">
                                            <img src="__IMAGES__/tuan/2014052603_2.jpg"></div>
                                        <div class="spjttp">
                                            <img src="__IMAGES__/tuan/2014052603_3.jpg"></div>
                                    </div>
                                </div>
                                <!--夺宝记录-->
                                <div class="nav_explain" id="d_record" style="display: none;">
                                    <div class="con_jl">
                                        <div class="dph">
                                            <div class="dph_left">
                                                已购买&nbsp;
                                                <span>
                                                    <strong id="isbuy">1129</strong>
                                                </span>
                                                &nbsp;组蛋拍号，还有&nbsp;
                                                <span>
                                                    <strong id="leavebuy">901</strong>
                                                </span>
                                                &nbsp;组即可集满。
                                            </div>
                                            <div class="dph_right">
                                                <div class="dph_right_message">
                                                    <strong>蛋拍号</strong>
                                                </div>
                                                <div class="dph_right_kuang">
                                                    <input class="input_dph" type="text" size="11" name="LowGoldeggs" value="" id="number"></div>
                                                <div class="dph_right_btn">
                                                    <a href="javascript:quickdw();">
                                                        <img src="__IMAGES__/tuan/btn_ks.jpg"></a>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="dph_list">
                                            <table cellpadding="0" cellspacing="0" width="100%" style="text-align:center; border:#E6E6E6 solid 1px;" id="orderlist">
                                                <tbody>
                                                    <tr style=" background-color:#F3F3F3;">
                                                        <td width="12%" height="30px;">
                                                            <strong>序号</strong>
                                                        </td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td width="20%">
                                                            <strong>蛋拍号</strong>
                                                        </td>
                                                        <td width="31%">
                                                            <strong>夺宝人</strong>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td width="22%">
                                                            <strong>购买时间</strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">121</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>1900843</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17498288">17498288</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:32</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">122</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>1937332</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17498288">17498288</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:32</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">123</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>1957434</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17059455">17059455</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:57</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">124</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>1958024</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=12784820">12784820</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:56</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">125</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2038743</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=12784820">12784820</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:56</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">126</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2048104</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16686889">16686889</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:33</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">127</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2056021</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17301053">17301053</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:25</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">128</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2071673</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=15531852">15531852</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:33</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">129</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2072112</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17818294">17818294</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:01</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">130</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2095233</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=5963420">5963420</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:08</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">131</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2098462</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17879514">17879514</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:02</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">132</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2110153</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17804392">17804392</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:03</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">133</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2126262</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=15789554">15789554</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:44</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">134</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2180332</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=4626725">4626725</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:35</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">135</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2185183</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=10975895">10975895</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:14</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">136</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2193891</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=4626725">4626725</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:35</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">137</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2194133</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=11721972">11721972</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:10</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">138</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2226760</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17869305">17869305</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:30</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">139</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2258743</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=11721972">11721972</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:10</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">140</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2286541</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=15615084">15615084</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:21</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">141</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2300164</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17856796">17856796</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:50</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">142</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2303073</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17077540">17077540</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:38</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">143</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2303191</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17217778">17217778</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:39</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">144</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2342732</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=8582912">8582912</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:32</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">145</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2349240</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17870781">17870781</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:30</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">146</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2411963</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=8181710">8181710</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:43</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">147</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2426884</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=8582912">8582912</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:32</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">148</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2427700</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=4626725">4626725</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 16:35</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">149</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2439561</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=470092">470092</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:51</td>
                                                    </tr>
                                                    <tr>
                                                        <td height="30px;">150</td>
                                                        <td width="5%">&nbsp;</td>
                                                        <td>2469842</td>
                                                        <td>
                                                            <a class="linkblueb_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17059455">17059455</a>
                                                        </td>
                                                        <td width="10%">&nbsp;</td>
                                                        <td>2014-06-04 15:57</td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                            <div class="pageb_fy " id="div_page">
                                                <a href="javascript:onsubmit(1);">首页</a>
                                                <a href="javascript:onsubmit(4);">上一页</a>
                                                <a class="current">5</a>
                                                <a href="javascript:onsubmit(6);" target="_top">6</a>
                                                <a href="javascript:onsubmit(7);" target="_top">7</a>
                                                <a href="javascript:onsubmit(8);" target="_top">8</a>
                                                <a href="javascript:onsubmit(9);" target="_top">9</a>
                                                <a href="javascript:onsubmit(6);">下一页</a>
                                                <a href="javascript:onsubmit(38);">尾页</a>
                                            </div>
                                            <div style="clear:both; width:100%; height:0px; line-height:0px; font-size:0px;"></div>
                                        </div>
                                    </div>
                                </div>
                                <!--夺宝规则-->
                                <div class="nav_explain" id="d_rule" style="display: none;">
                                    <div class="con">
                                        <div style=" clear:both;"></div>
                                        <div class="gz_title">
                                            <span class="gz_title_o">
                                                <a name="d1"></a>
                                                01.
                                            </span>
                                            <span class="gz_title_g">什么是蛋蛋夺宝</span>
                                        </div>
                                        <div class="gz_message">
                                            蛋友可以用自己手中的金蛋参与蛋蛋夺宝活动，每10000个金蛋购买一组蛋拍号，当集满夺宝所需金蛋后（即所有蛋拍号买完后），网站将依据【
                                            <a href="http://kaijiang.500wan.com/ssc.shtml" target="_blank" style="text-decoration:underline;">重庆时时彩</a>
                                            】开奖数字，得出与开奖号码相差最少的蛋拍号，该蛋拍号持有者即可获得宝贝。
                                        </div>
                                        <div class="gz_title">
                                            <span class="gz_title_o">02.</span>
                                            <span class="gz_title_g">蛋蛋夺宝购买蛋拍号细则</span>
                                        </div>
                                        <div class="gz_message">
                                            1、成就对应的最多可购买每期蛋拍码的组数。
                                            <br>

                                            <img src="__IMAGES__/tuan/cjgms.jpg">
                                            <br>
                                            2、为了让更多蛋友参与，每人每期最多可购买
                                            <span class="dbxzsm_red">1%</span>
                                            组蛋拍号。
                                            <br>
                                            <span style="padding-top:18px;">
                                                3、未完成
                                                <a style="color:#D80000; text-decoration:none;" href="http://www.pceggs.com/myaccount/mymobileindex.aspx">
                                                    <strong>手机认证</strong>
                                                </a>
                                                ，不能参加夺宝。
                                            </span>
                                            <br>
                                            4、当天
                                            <span class="dbxzsm_red">领取救济</span>
                                            后，不能参加夺宝。
                                            <br>
                                            5、夺宝中奖后，
                                            <span class="dbxzsm_red">7天内</span>
                                            只能领取
                                            <span class="dbxzsm_red">5000</span>
                                            金蛋救济
                                            <br>
                                            6、
                                            <span class="dbxzsm_red">作弊行为</span>
                                            一经发现将冻结账号并取消夺宝资格，购买的蛋拍号全部作废。
                                        </div>
                                        <div class="gz_title">
                                            <span class="gz_title_o">
                                                <a name="d2"></a>
                                                03.
                                            </span>
                                            <span class="gz_title_g">蛋蛋夺宝流程</span>
                                        </div>
                                        <div class="gz_message">
                                            <img src="__IMAGES__/tuan/gz_lc1.jpg"></div>
                                        <div class="gz_title">
                                            <span class="gz_title_o">
                                                <a name="d3"></a>
                                                04.
                                            </span>
                                            <span class="gz_title_g">夺宝开奖规则</span>
                                        </div>
                                        <div class="gz_message">
                                            用户在每次购买时都会获得一组7位数的蛋拍号（蛋拍号是唯一的），以金蛋集齐那一刻的时间为准，跳过一期，取接下来的连续两期“
                                            <a href="http://kaijiang.500wan.com/ssc.shtml" target="_blank" style="text-decoration:underline;">重庆时时彩</a>
                                            开奖号码”合成一组7位数开奖号码（前一期的后3位数字+后一期的前4位数字），系统将这个开奖号码与当期所有蛋拍号进行比对，取一个与开奖号码相差最少且最小的蛋拍号，持有这个蛋拍号的用户获得奖品。
                                        </div>
                                        <div class="gz_message">
                                            <img src="__IMAGES__/tuan/gz_lc2.jpg"></div>
                                        <div class="gz_message">
                                            【重要说明】蛋蛋夺宝的中奖号码是取宝贝金蛋集齐时刻的下下两期
                                            <a href="http://kaijiang.500wan.com/ssc.shtml" target="_blank" style="text-decoration:underline;">重庆时时彩</a>
                                            开奖号码组合后的7位数字，同时“
                                            <a href="http://kaijiang.500wan.com/ssc.shtml" target="_blank" style="text-decoration:underline;">重庆时时彩</a>
                                            ”白天每10分钟开奖一次，晚上22：00开始每5分钟开奖一次。例如某次抽奖，宝贝金蛋集齐的时间是22时32分，那么该次抽奖需要参考的
                                            <a href="http://kaijiang.500wan.com/ssc.shtml" target="_blank" style="text-decoration:underline;">重庆时时彩</a>
                                            开奖号码应该是22时40分和22时45分这两期，而不是，22时35分和22时40分这两期。同时蛋友可以随时在“参与记录”中查看所有本次参与抽奖蛋友的id和对应蛋拍号，所以蛋蛋夺宝不可能在开奖后插入系统号冒充中奖者。
                                        </div>
                                        <div class="gz_title">
                                            <span class="gz_title_o">05.</span>
                                            <span class="gz_title_g">蛋蛋夺宝什么时候开奖？</span>
                                        </div>
                                        <div class="gz_message">
                                            当期夺宝的金蛋集满后，系统会显示开奖中。蛋蛋客服会根据开奖规则人工开奖，
                                            <span style=" color:#D80000;">开奖时间为工作日的9:00-18:00（双休日和节假日不开奖）</span>
                                            。
开奖时，客服会审核夺宝人是否存在作弊行为，如果作弊将取消其中奖资格，作废其购买的所有蛋拍号，再根据夺宝规则继续将中奖资格延续给拥有与开奖号码相差最少且最小蛋拍号的用户。
                                            <br>在未开奖前，下下两期的重庆时时彩如果已开奖，蛋友可以根据开奖规则来计算开奖号码并看看幸运的夺宝人是谁。</div>
                                        <div class="gz_title">
                                            <span class="gz_title_o">
                                                <a name="d5"></a>
                                                06.
                                            </span>
                                            <span class="gz_title_g">金蛋夺宝为什么不能作弊?</span>
                                        </div>
                                        <div class="gz_message">
                                            因为PC蛋蛋引用国家法定彩票——“
                                            <a href="http://kaijiang.500wan.com/ssc.shtml" target="_blank" style="text-decoration:underline;">重庆时时彩</a>
                                            ”开奖号码作为参照，在
                                            <a href="http://kaijiang.500wan.com/ssc.shtml" target="_blank" style="text-decoration:underline;">重庆时时彩</a>
                                            开奖前任何人无法预测开奖号码！所以蛋蛋夺宝根本没有办法作弊！
      营造一个公平、公正、透明的夺宝环境是我们坚持到底宗旨！欢迎广大蛋友对开奖过程进行监督！
                                        </div>
                                        <div class="gz_title">
                                            <span class="gz_title_o">
                                                <a name="d4"></a>
                                                07.
                                            </span>
                                            <span class="gz_title_g">如何获得金蛋?</span>
                                        </div>
                                        <div class="gz_message">
                                            <strong>在PC蛋蛋，你可以通过以下几种方式获得金蛋：</strong>
                                            <br>
                                            1、在“游戏试玩中心”，选择“招募中”的游戏，按游戏的要求，试玩即可拿到金蛋奖励；
                                            <br>
                                            <a href="http://www.pceggs.com/Gain/GnGameAll.aspx">
                                                <img src="__IMAGES__/tuan/btn_yxswzjd.jpg"></a>
                                            <br>
                                            2、在“广告体验”，按广告页面的要求完成体验，即可拿到金蛋奖励；
                                            <br>
                                            <a href="http://www.pceggs.com/Gain/Gnmain.aspx">
                                                <img src="__IMAGES__/tuan/btn_ggtyzjd.jpg"></a>
                                            <br>
                                            3、参与“商家问答”，答对问题，即可拿到金蛋奖励。
                                            <br>
                                            <a href="http://www.pceggs.com/Gain/MerQA.aspx">
                                                <img src="__IMAGES__/tuan/btn_sjwdzjd.jpg"></a>
                                            <br>通过以上途径获得的金蛋除了可以参与“夺宝”，还可以在“兑奖中心”兑换奖品。</div>
                                        <div class="gz_title">
                                            <span class="gz_title_o">08.</span>
                                            <span class="gz_title_g">常见问题</span>
                                        </div>
                                        <div class="gz_message">
                                            <strong>Q: 什么是蛋拍号，如何获得蛋拍号？</strong>
                                            <br>
                                            <strong>A:</strong>
                                            用户在每次购买时都会获得一组7位数的蛋拍号（蛋拍号是唯一的），在所需金蛋集齐时，以集齐那一刻的时间为准，取接下来的连续两期"
                                            <a href="http://kaijiang.500wan.com/ssc.shtml" target="_blank" style="text-decoration:underline;">重庆时时彩</a>
                                            开奖号码"合成一组7位数中奖号码（前一期的后3位数字+后一期的前4位数字），系统将这个中奖号码与当期所有蛋拍号进行比对，取一个与开奖号码相差最少且最小的蛋拍号，持有这个蛋拍号的用户获得奖品。
                                            <br>
                                            <strong>Q: 怎样查看我参与的夺宝获得的蛋拍号？</strong>
                                            <br>
                                            <strong>A:</strong>
                                            进入 “我的账号” - “
                                            <a class="blue_load" href="http://www.pceggs.com/myaccount/myduobao.aspx">我的夺宝</a>
                                            ” 选择当前参与的活动点击查看蛋拍号。
                                            <br>
                                            <strong>Q: 我获得了奖品，我还需要支付其他费用吗？</strong>
                                            <br>
                                            <strong>A:</strong>
                                            不需要支付其他任何费用。
                                            <br>
                                            <strong>Q: 当我获得奖品以后我该做什么？</strong>
                                            <br>
                                            <strong>A:</strong>
                                            在您获得奖品后您会收到站内信、客服电话的通知。在这之后，您必须在“我的账号”-“
                                            <a class="blue_load" href="http://www.pceggs.com/myaccount/MyMailChange.aspx">修改资料</a>
                                            ”中正确填写、真实的收货地址并提交手机认证。我们会在您获得奖品后3个工作日内通过电话方式与您取得联系。
                                            <br>
                                            <strong>Q: 如何晒单分享？</strong>
                                            <br>
                                            <strong>A:</strong>
                                            在您收到奖品后，登录PC蛋蛋，进入"
                                            <a class="blue_load" href="http://www.pceggs.com/nbbs/bbsMain.aspx?topicid=10&lid=180">讨论区</a>
                                            "，发布晒单信息，通过审核后，您还可获得金蛋的奖励。在您成功晒奖后，您的晒奖会出现在网站“晒奖”区，与大家分享喜悦。
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!--返积分比率--> </div>
                    </div>
                </div>
                <div class="pc_right">
                    <div class="tbdp">
                        <div class="tbdp_top"></div>
                    </div>
                    <a href="http://www.pceggs.com/duobao/duobao_index.aspx#d3" onclick="TabInfo(3)" style="text-decoration:none;cursor:pointer; overflow:hidden;" id="explay">
                        <div class="tgcjwt" style="height:326px;">
                            <div class="wtwx">
                                &nbsp;
                                <div class="wt_xx">
                                    每个参与夺宝的用户都会随机分配到一组7位数的蛋拍号（不重复）。夺宝的开奖数据来自重庆时时彩。金蛋集齐后，跳过一期时时彩，在开奖时，用后一期时时彩后
                                    <span class="c_tx6" style="font-size:12px;">3位</span>
                                    数字加再往后一期时时彩的前
                                    <span class="c_tx6" style="font-size:12px;">4位</span>
                                    数字，形成一个新的
                                    <span class="c_tx6" style="font-size:12px;">7位</span>
                                    数字。与此7位数字
                                    <span class="c_tx6" style="font-size:12px;">相差最少</span>
                                    的
                                    <span class="c_tx6" style="font-size:12px;">最小</span>
                                    蛋拍号即为开奖号码，拥有此蛋拍号的用户即为中奖人。
                                    <span class="blue_load" style=" color:Blue;">查看详细规则</span>
                                </div>
                            </div>
                        </div>
                    </a>

                    <!--show prize begin-->
                    <div class="db_pcright_wjsj">
                        <div class="db_pcright_wjsjtop">
                            <div class="db_right_l">玩家晒奖</div>
                            <div class="db_right_r">
                                <a href="http://www.pceggs.com/ShowPrize/ShowList.aspx" class="blue_load">更多&gt;&gt;</a>
                            </div>
                        </div>
                        <div class="db_right_con db_right_wjsj_big" style="padding-top:10px;">
                            <div class="db_right_wjsj_big_mes">夺宝中的5S土豪金到手啦！</div>
                            <div class="db_right_wjsj_big_img">
                                <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8002184" target="_blank">
                                    <img src="__IMAGES__/tuan/shaijiang_01.jpg" width="206" height="106"></a>
                            </div>
                            <div class="db_right_wjsj_little">
                                <ul>
                                    <li>
                                        <div class="db_right_wjsj_little_img">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8001501" target="_blank">
                                                <img src="__IMAGES__/tuan/shaijiang_02.jpg" width="50" height="46"></a>
                                        </div>
                                        <div class="db_right_wjsj_little_mes">
                                            <p>
                                                <a class="index_3beta_link_blue12" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8001501" target="_blank">送儿子的米奇运动表！</a>
                                            </p>
                                            <p>蛋蛋少说也玩了几年了...</p>
                                        </div>
                                    </li>
                                    <li class="xuxian"></li>
                                    <li>
                                        <div class="db_right_wjsj_little_img">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8001481" target="_blank">
                                                <img src="__IMAGES__/tuan/shaijiang_03.jpg" width="50" height="46"></a>
                                        </div>
                                        <div class="db_right_wjsj_little_mes">
                                            <p>
                                                <a class="index_3beta_link_blue12" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8001481" target="_blank">给妈妈一个温暖的熊抱！</a>
                                            </p>
                                            <p>借蛋蛋送妈妈一份礼物...</p>
                                        </div>
                                    </li>
                                    <li class="xuxian"></li>

                                    <li>
                                        <div class="db_right_wjsj_little_img">
                                            <a href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8001281" target="_blank">
                                                <img src="__IMAGES__/tuan/shaijiang_04.jpg" width="50" height="46"></a>
                                        </div>
                                        <div class="db_right_wjsj_little_mes">
                                            <p>
                                                <a class="index_3beta_link_blue12" href="http://www.pceggs.com/ShowPrize/ShowInfo.aspx?tid=8001281" target="_blank">夺中苹果ipad Air！</a>
                                            </p>
                                            <p>加入蛋蛋2千多天...</p>
                                        </div>
                                    </li>

                                </ul>

                            </div>
                        </div>
                        <div class="db_pcright_kjbottom"></div>
                    </div>
                    <!--show prize end-->

                    <div class="db_pcright_kj" id="helpid">
                        <div class="db_pcright_kjtop">
                            <div class="db_right_l">常见问题</div>
                            <div class="db_right_r"></div>
                        </div>
                        <div class="db_right_con" style="padding-top:10px;">
                            <span>&nbsp;</span>
                            <a href="http://www.pceggs.com/duobao/duobao_index.aspx#d1" onclick="TabInfo(3)" id="explay1">什么是蛋蛋夺宝？</a>
                            <br>
                            <span>&nbsp;</span>
                            <a href="http://www.pceggs.com/duobao/duobao_index.aspx#d2" onclick="TabInfo(3)" id="explay2">蛋蛋夺宝的流程。</a>
                            <br>
                            <span>&nbsp;</span>
                            <a href="http://www.pceggs.com/duobao/duobao_index.aspx#d3" onclick="TabInfo(3)" id="explay3">蛋蛋夺宝的规则。</a>
                            <br>
                            <span>&nbsp;</span>
                            <a href="http://www.pceggs.com/duobao/duobao_index.aspx#d4" onclick="TabInfo(3)" id="explay4">如何获取金蛋？</a>
                            <br>
                            <span>&nbsp;</span>
                            <a href="http://www.pceggs.com/duobao/duobao_index.aspx#d5" onclick="TabInfo(3)" id="explay5">开奖为什么不能作弊？</a>
                            <br></div>
                        <div class="db_pcright_kjbottom"></div>
                    </div>

                    <div class="db_pcright_kj">
                        <div class="db_pcright_kjtop">
                            <div class="db_right_l">最新中奖记录</div>
                            <div class="db_right_r">
                                <a href="http://www.pceggs.com/duobao/duobao_historylist.aspx" class="blue_load">全部&gt;&gt;</a>
                            </div>
                        </div>
                        <div class="db_right_con" style="height:auto;">

                            <div class="db_right_concon">
                                <div class="db_right_conl">
                                    <a href="http://www.pceggs.com/duobao/duobao_history.aspx?id=10002988" class="blue_load">
                                        <img src="__IMAGES__/tuan/2014052701_s.jpg" width="78" height="70"></a>
                                </div>
                                <div class="db_right_conr">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=12166232" class="blue_load">12166232</a>
                                    <br>
                                    扔了：
                                    <span class="font_red">270,000</span>
                                    <img src="__IMAGES__/tuan/eggs.gif" width="16" height="16" align="absmiddle">
                                    <br>
                                    <a href="http://www.pceggs.com/duobao/duobao_history.aspx?id=10002988" class="blue_load">第2014060401期</a>
                                </div>
                            </div>
                            <div class="db_right_concon">
                                <div class="db_right_conl">
                                    <a href="http://www.pceggs.com/duobao/duobao_history.aspx?id=10002987" class="blue_load">
                                        <img src="__IMAGES__/tuan/2014053001_s.jpg" width="78" height="70"></a>
                                </div>
                                <div class="db_right_conr">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=15295275" class="blue_load">15295275</a>
                                    <br>
                                    扔了：
                                    <span class="font_red">280,000</span>
                                    <img src="__IMAGES__/tuan/eggs.gif" width="16" height="16" align="absmiddle">
                                    <br>
                                    <a href="http://www.pceggs.com/duobao/duobao_history.aspx?id=10002987" class="blue_load">第2014060303期</a>
                                </div>
                            </div>
                            <div class="db_right_concon">
                                <div class="db_right_conl">
                                    <a href="http://www.pceggs.com/duobao/duobao_history.aspx?id=10002986" class="blue_load">
                                        <img src="__IMAGES__/tuan/2013041204_s.jpg" width="78" height="70"></a>
                                </div>
                                <div class="db_right_conr">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=17639488" class="blue_load">17639488</a>
                                    <br>
                                    扔了：
                                    <span class="font_red">200,000</span>
                                    <img src="__IMAGES__/tuan/eggs.gif" width="16" height="16" align="absmiddle">
                                    <br>
                                    <a href="http://www.pceggs.com/duobao/duobao_history.aspx?id=10002986" class="blue_load">第2014060302期</a>
                                </div>
                            </div>
                            <div class="db_right_concon">
                                <div class="db_right_conl">
                                    <a href="http://www.pceggs.com/duobao/duobao_history.aspx?id=10002985" class="blue_load">
                                        <img src="__IMAGES__/tuan/2013051501_s.jpg" width="78" height="70"></a>
                                </div>
                                <div class="db_right_conr">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=15337153" class="blue_load">15337153</a>
                                    <br>
                                    扔了：
                                    <span class="font_red">410,000</span>
                                    <img src="__IMAGES__/tuan/eggs.gif" width="16" height="16" align="absmiddle">
                                    <br>
                                    <a href="http://www.pceggs.com/duobao/duobao_history.aspx?id=10002985" class="blue_load">第2014060301期</a>
                                </div>
                            </div>
                            <div class="db_right_concon">
                                <div class="db_right_conl">
                                    <a href="http://www.pceggs.com/duobao/duobao_history.aspx?id=10002983" class="blue_load">
                                        <img src="__IMAGES__/tuan/2013012101_s.jpg" width="78" height="70"></a>
                                </div>
                                <div class="db_right_conr">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=16518041" class="blue_load">16518041</a>
                                    <br>
                                    扔了：
                                    <span class="font_red">390,000</span>
                                    <img src="__IMAGES__/tuan/eggs.gif" width="16" height="16" align="absmiddle">
                                    <br>
                                    <a href="http://www.pceggs.com/duobao/duobao_history.aspx?id=10002983" class="blue_load">第2014060202期</a>
                                </div>
                            </div>
                            <div class="db_right_concon" style="border:0px;">
                                <div class="db_right_conl">
                                    <a href="http://www.pceggs.com/duobao/duobao_history.aspx?id=10002982" class="blue_load">
                                        <img src="__IMAGES__/tuan/2014060201_s.jpg" width="78" height="70"></a>
                                </div>
                                <div class="db_right_conr">
                                    <a href="http://www.pceggs.com/pgComUserInfo.aspx?USERID=11177355" class="blue_load">11177355</a>
                                    <br>
                                    扔了：
                                    <span class="font_red">50,000</span>
                                    <img src="__IMAGES__/tuan/eggs.gif" width="16" height="16" align="absmiddle">
                                    <br>
                                    <a href="http://www.pceggs.com/duobao/duobao_history.aspx?id=10002982" class="blue_load">第2014060201期</a>
                                </div>
                            </div>

                        </div>
                        <div class="db_pcright_kjbottom"></div>
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