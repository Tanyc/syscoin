<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><!-- InstanceBegin template="/Templates/navi_temp.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<!-- InstanceBeginEditable name="doctitle" -->
  <title>幸运星-专业的广告游戏平台</title>
  <link rel="stylesheet" type="text/css" href="__CSS__/naviation.css" />
  <link rel="stylesheet" type="text/css" href="__CSS__/com.css" />
  <link rel="stylesheet" type="text/css" href="__CSS__/pgstar.css" />
  <link rel="stylesheet" type="text/css" href="__CSS__/footer.css" />

  <script language="javascript" type="text/javascript">
    function copyToClipBoard() {
        var clipBoardContent = '';
        clipBoardContent += "http://www.pceggs.cn/pgComDefault.aspx?ID=0"; 
        window.clipboardData.setData("Text", clipBoardContent);
        alert("地址已经复制到粘贴板!");
    }
</script>

  <script language="javascript" type="text/javascript">
    function chkResult(v, val) {
        if (val != "-1") {
            val = val - 10;
            document.write(v + "<img src='/img/xnbc/number_" + val + ".gif' />");
        }
        else {
            document.write("-");
        }
    }

    function chkStatus(status, lid, ISLOTTERY) {
        //状态：0投注中，1暂停投注等待开奖，2已开奖            
        switch (status) {
            case '0':{
                    if (ISLOTTERY == "1") {
                        document.write("<a class='a0' href='/play/pg28Insert.aspx?LID=" + lid + "' target='_top'>已投注</a>")
                    }else {
                        document.write("<a class='a0' href='/play/pg28Insert.aspx?LID=" + lid + "' target='_top'>投注</a>")
                    }
                    break;
                }
            case '1':{
                    document.write("<a href='/play/pgMy28Detail.aspx?LID=" + lid + "' target='_top'>开奖中</a>")
                    break;
                }
            case '2':{
                    document.write("<a href='/play/pgMy28Detail.aspx?LID=" + lid + "' target='_top'>已开奖</a>")
                    break;
                }
        }
    }
    function chkwin(val, lid) {
        if (val != '0') {
            document.write("<a class='a0' href='/play/pg28Result.aspx?LID=" + lid + "' target='_top' title='查看中奖人名单'>" + val + " </a>");
        }else {
            document.write("0");
        }
    }
</script>
  <script language="javascript" type="text/javascript">

    function transStr(str) {
        str = str.toString()
        var begin = "";
        var after = "";
        var l;
        var str2 = "";
        if (str.indexOf(".") > 0) {
            begin = str.substring(0, str.indexOf("."));
            after = str.substring(str.indexOf("."), str.length);
        }else {
            begin = str;
        }
        l = begin.length / 3;
        if (l > 1) {
            for (var i = 0; i < l; ) {
                str2 = "," + begin.substring(begin.length - 3, begin.length) + str2;
                begin = begin.substring(0, begin.length - 3);
                l = begin.length / 3;
            }
            if (after.length < 3) {
                str2 = begin + str2 + after;
            } else {
                str2 = begin + str2 + after
            }
            return str2.substring(1);
        }else {
            if (after.length < 3) {
                return str;
            } else {
                return str;
            }
        }
    }

    function SGMoney(Sm, Gm) {
        if (Sm == null || Sm == 0) {
            document.write("-");
        }else {
            var val = Gm - Sm;
            if (val >= 0) {
                val = transStr(val);
                document.write("<span style='color:red'>" + val + "</span><img src='__IMAGES__/game/egg.gif'/>");
            }else {
                val = transStr(Math.abs(val));
                document.write("<span style='color:#1B5E00'>-" + val + "</span><img src='__IMAGES__/game/egg.gif'/>");
            }
        }
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
    <div class=game_content>
      <div class=game_tab>
        <div style="width:970px">
          <div class="title_game" style="float:left; width:610px;">
            <a href="<?php echo U('Home/game');?>">
              <img src="__IMAGES__/game/pub/ico_6.gif" width="98" height="27" border="0"></a>
            <a href="<?php echo U('Home/game/pg310');?>">
              <img src="__IMAGES__/game/pub/ico_26.gif" width="98" height="27" border="0"></a>
            <a href="<?php echo U('Home/game/pgstar');?>">
              <img src="__IMAGES__/game/pub/ico_29.gif" width="98" height="27" border="0"></a>
          </div>
          <div style=" float:right; width:330px; height:25px;vertical-align:middle; line-height:25px;text-align:right">
            <a href="/nbbs/bbsPost.aspx?PostID=3864534&amp;topicid=4&amp;ret=1" target="_blank" style="color:#3f3f3f;">幸运星启用浙江体彩6+1实时开奖数据&gt;&gt;&gt;</a>
            &nbsp;&nbsp;
          </div>
        </div>
      </div>
        <div class="line">
        </div>

        <table width="978" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#f07b72" style="clear:both;">
          <tbody>
            <tr>
              <td width="50%" height="24" align="left" valign="middle" style="padding-left: 10px">
                <a href="/play/pgMyStar6.aspx" target="_parent" class="abt12_1">我的投注</a>
                <span class="wh12">|</span>
                <a href="/play/PgStar6Help.aspx" target="_blank" class="abt12_1">幸运星帮助</a>
              </td>
              <td width="50%" align="right" valign="middle" style="padding-right: 10px">
                &nbsp;
                <a href="javascript:ShowMsgo.show('/adcomate/pggetgoldeggsnew.aspx',503,546)" class="abt12_1">领取救济金</a>
              </td>
            </tr>
          </tbody>
        </table>

        <table width="978" border="0" cellpadding="0" cellspacing="1" bgcolor="#ef5310" align="center" style="color:Black;">
          <tbody>
            <tr align="center">
              <td class="white" width="10%" height="28" background="/img/pub/xy28_bg.gif">期号</td>
              <td class="white" background="/img/pub/xy28_bg.gif" style="width: 17%">开奖时间</td>
              <td class="white" background="/img/pub/xy28_bg.gif" style="width: 26%">开奖结果</td>
              <td class="white" background="/img/pub/xy28_bg.gif" style="width: 15%">已投注数</td>
              <td class="white" height="28" background="/img/pub/xy28_bg.gif" style="width: 10%">特等奖</td>
              <td class="white" background="/img/pub/xy28_bg.gif" style="width: 10%">鼓励奖</td>
              <td class="white" width="8%" background="/img/pub/xy28_bg.gif">参与</td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="32" bgcolor="#FFFaC7">14064</td>
              <td height="28" bgcolor="#FFFFFF">06-06 20:00</td>
              <td bgcolor="#FFFFFF">

                <script language="javascript" type="text/javascript">chkResult("");</script>
                -
              </td>
              <td bgcolor="#FFFFFF">4,922</td>
              <td height="28" bgcolor="#FFFFFF">

                <script language="javascript" type="text/javascript">chkwin('0','14064','1');</script>
                0
              </td>
              <td height="28" bgcolor="#FFFFFF">

                <script language="javascript" type="text/javascript">chkwin('0','14064','2');</script>
                0
              </td>
              <td bgcolor="#FFFFFF">

                <script language="javascript" type="text/javascript">chkStatus('0','8497');</script>
                <a class="a0" href="/play/pgstar6Insert.aspx?LID=8497" target="_top">投注</a>

              </td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="32" bgcolor="#FFFaC7">14063</td>
              <td height="28" bgcolor="#f8f8f8">06-03 20:00</td>
              <td bgcolor="#f8f8f8">

                <script language="javascript" type="text/javascript">chkResult('');</script>
                -
              </td>
              <td bgcolor="#f8f8f8">25,125</td>
              <td height="28" bgcolor="#FFFFFF">

                <script language="javascript" type="text/javascript">chkwin('0','14063','1');</script>
                0
              </td>
              <td height="28" bgcolor="#f8f8f8">

                <script language="javascript" type="text/javascript">chkwin('0','14063','2');</script>
                0
              </td>
              <td bgcolor="#f8f8f8">

                <script language="javascript" type="text/javascript">chkStatus('0','8477');</script>
                <a class="a0" href="/play/pgstar6Insert.aspx?LID=8477" target="_top">投注</a>

              </td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="32" bgcolor="#FFFaC7">14062</td>
              <td height="28" bgcolor="#FFFFFF">06-01 20:00</td>
              <td bgcolor="#FFFFFF">

                <script language="javascript" type="text/javascript">chkResult("327229");</script>
                <img src="__IMAGES__/game/pgstar/3.gif">        
                <img src="__IMAGES__/game/pgstar/2.gif">        
                <img src="__IMAGES__/game/pgstar/7.gif">        
                <img src="__IMAGES__/game/pgstar/2.gif">        
                <img src="__IMAGES__/game/pgstar/2.gif">        
                <img src="__IMAGES__/game/pgstar/9.gif"></td>
              <td bgcolor="#FFFFFF">31,041</td>
              <td height="28" bgcolor="#FFFFFF">

                <script language="javascript" type="text/javascript">chkwin('0','14062','1');</script>
                0
              </td>
              <td height="28" bgcolor="#FFFFFF">

                <script language="javascript" type="text/javascript">chkwin('0','14062','2');</script>
                0
              </td>
              <td bgcolor="#FFFFFF">

                <script language="javascript" type="text/javascript">chkStatus('2','8458');</script>
                已开奖
              </td>
            </tr>

            <tr align="center" bgcolor="#FFFFFF">
              <td height="28" colspan="7" bgcolor="#FFFFFF">

                <script language="javascript" type="text/javascript">
    function onsubmit(CurrentPageIndex)
    {
        document.getElementById("CurrentPageIndex").value = CurrentPageIndex ;
        //document.getElementById("Condition").value = Condition ;
        document.getElementById("pagination").submit();
    }
</script>
                <style type="text/css">
<!--
.phoenix a:hover { color: #003366; text-decoration: none ; }
.phoenix a:link { color: #3366cc; text-decoration: none; }
.phoenix a:visited { color: #3366cc; text-decoration: none; }
.phoenix .point14{ font-family:webdings; font-size:14px; }
.phoenix .common{ font-family:Tahoma; font-size:12px; }
-->
</style>
                <table cellspacing="2" cellpadding="2" style="font-family:Tahoma; font-size:12px; text-align:center; border:0; width:100%;" class="phoenix">
                  <!--<form id="pagination" method="post" action="/play/pgstar6.aspx">        
                  -->
                  <input id="CurrentPageIndex" name="CurrentPageIndex" type="hidden">        
                  <tbody>
                    <tr valign="middle">
                      <td align="left">
                        <span title="记录总数" style="cursor:pointer;">
                          <span class="common">&nbsp;&nbsp;记录总数：</span>
                          <span style="color:#000066; font-weight:bold;">1058</span>
                        </span>
                        <span title="总页数" style="cursor:pointer;">
                          <span class="common">&nbsp;&nbsp;总页数：</span>
                          <span style="color:#000066;font-weight:bold;">106</span>
                        </span>
                        &nbsp;&nbsp;
                        <span title="当前页" style="cursor:pointer;">
                          <span class="common">&nbsp; &nbsp;当前页：</span>
                          <span style="color:#CC0000;font-weight:bold;">1</span>
                        </span>
                      </td>
                      <td align="center">
                        <span class="point14">|</span>
                        <span class="point14" title="首页">
                          <img src="__IMAGES__/public/pgblue-1.png" border="0"></span>
                        <span class="point14" title="前十页">
                          <img src="__IMAGES__/public/pgblue-2.png" border="0"></span>
                        <span class="point14" title="前一页">
                          <img src="__IMAGES__/public/pgblue-3.png" border="0"></span>
                        <span style="color:#CC0000; font-weight:bold;">1</span>
                        <a href="javascript:onsubmit(2);" target="_top">2</a>
                        <a href="javascript:onsubmit(3);" target="_top">3</a>
                        <a href="javascript:onsubmit(4);" target="_top">4</a>
                        <a href="javascript:onsubmit(5);" target="_top">5</a>
                        <a href="javascript:onsubmit(6);" target="_top">6</a>
                        <a href="javascript:onsubmit(7);" target="_top">7</a>
                        <a href="javascript:onsubmit(8);" target="_top">8</a>
                        <a href="javascript:onsubmit(9);" target="_top">9</a>
                        <a href="javascript:onsubmit(10);" target="_top">10</a>
                        <a href="javascript:onsubmit(2);" target="_top">
                          <span class="point14" title="后一页">
                            <img src="__IMAGES__/public/pgblue-4.png" border="0"></span>
                        </a>
                        <a href="javascript:onsubmit(11);" target="_top">
                          <span class="point14" title="后十页">
                            <img src="__IMAGES__/public/pgblue-5.png" border="0"></span>
                        </a>
                        <a href="javascript:onsubmit(106);" target="_top">
                          <span class="point14" title="尾页">
                            <img src="__IMAGES__/public/pgblue-6.png" border="0"></span>
                        </a>
                        <span class="point14">|</span>
                      </td>
                      <td align="right">
                        <span title="当前记录数" style="cursor:pointer;">
                          <span class="common">&nbsp;&nbsp;当页记录数：</span>
                          <span style="color:#CC0000;font-weight:bold;">10</span>
                        </span>
                      </td>
                    </tr>
                    <!--</form>--></tbody>
                </table>

              </td>
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