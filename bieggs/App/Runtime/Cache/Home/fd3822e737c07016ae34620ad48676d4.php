<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><!-- InstanceBegin template="/Templates/navi_temp.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<!-- InstanceBeginEditable name="doctitle" -->
  <title>比蛋-专业的广告游戏平台</title>
  <link rel="stylesheet" type="text/css" href="__CSS__/main.css" />
  <link rel="stylesheet" type="text/css" href="__CSS__/naviation.css" />
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
    <div class="p01">
      <div class="guild">
        <div class="user_login_title">
          <h2>客服QQ</h2>
        </div>
        <ul class="service">
          <li>
            企业QQ&nbsp;&nbsp;&nbsp;：
            <a href="tencent://message/?uin=394276418&Site=www.qq.com&Menu=yes" target="_blank">394276418</a>
          </li>
          <li>
            广告合作&nbsp;&nbsp;：
            <a href="tencent://message/?uin=394276418&Site=www.qq.com&Menu=yes" target="_blank">394276418</a>
          </li>
          <li>
            客服主管&nbsp;&nbsp;：
            <a href="tencent://message/?uin=394276418&Site=www.qq.com&Menu=yes" target="_blank">394276418</a>
          </li>
        </ul>
      </div>
      <DIV id="div_slider">
        <SCRIPT language="javascript" type="text/javascript" src="__JS__/jquery-1.7.1.min.js"></SCRIPT>
        <SCRIPT type="text/javascript" src="__JS__/jquery.Slides.js"></SCRIPT>
        <SCRIPT type="text/javascript">
        $(function () {
            $("#div_slider").KinSlideshow();
        })
    </SCRIPT>
        <A href="#" target="_blank">
          <IMG alt="test1" src="__IMAGES__/body_1/pic201401251058101.jpg" width="515" height="275"></A>
        <A href="#" target="_blank">
          <IMG alt="test2" src="__IMAGES__/body_1/pic201402130312181.jpg" width="515" height="275"></A>
      </DIV>

      <div class="login">
        <div class="user_login_title">
          <h2>会员登录</h2>
        </div>
          <form name="form" method="post" action="login.php?act=login">
          <table border="0" cellpadding="0" cellspacing="0">
            <tbody>
              <tr>
                <td width="66">邮&nbsp;&nbsp;&nbsp;箱:</td>
                <td width="152">
                  <input class="bg" name="tbUserAccount" type="text" id="tbUserAccount"></td>
              </tr>
              <tr>
                <td>密&nbsp;&nbsp;&nbsp;码:</td>
                <td>
                  <input class="bg" name="tbUserPwd" type="password" id="tbUserPwd"></td>
              </tr>
              <tr class="checkcode">
                <td height="0">验证码:</td>
                <td>
                  <input class="bg" type="text" name="tbSafeCode" id="tbSafeCode" style="width:65px;">
                  <img id="vdimgck" src="inc/code.php" alt="看不清？点击更换" width="60" height="27" style="cursor:pointer" onclick="this.src=this.src+'?'"></td>
              </tr>
              <tr>
                <td height="85"></td>
                <td class="checkbox">
                  <input name="tbKeep" type="checkbox" value="1">
                  <span>
                    下次自动登录
                    <a href="resetpassword.php" target="_blank">忘记密码</a>
                  </span>
                </td>
              </tr>
              <tr>
                <td></td>
                <td>
                  <input name="登陆" type="submit" class="loginbtn" value=""></td>
              </tr>
            </tbody>
          </table>
        </form>
        <a href="reg.php">
          <p class="regbtn"></p>
        </a>
      </div>
    </div>
    <div class="step">
      <a href="">
        <img src="__PUBLIC__/images/body_1/step.jpg" alt=""></a>
    </div>
        <div class="div_content">
      <div class="activity">
        <div class="msg_prize_title">
          <h2>热门活动</h2>
          <a href="#" class="more_notice">更多&gt;&gt;</a>
        </div>
        <div class="notice_list">
          <ul >
            <?php if(is_array($notice)): $i = 0; $__LIST__ = $notice;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i;?><li>
                <a href="<?php echo U("/App/Modules/Home/Tpl/notice/".$vo['con_link']);?>"><?php echo ($vo["title"]); ?></a>
              </li><?php endforeach; endif; else: echo "" ;endif; ?>
          </ul>
        </div>
      </div>
      <div class="practice">
        <div class="msg_prize_title">
          <h2>立即体验</h2>
          <a href="#" class="more_notice">更多&gt;&gt;</a>
        </div>
        <div class="prizes_list">
          <ul>
            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/pic201402130148581.jpg" alt="" style="height:70px; width:160px;"></a>
              </div>
              <div class="num">
                奖励：
                <span class="orange">
                  <b>530,000</b>
                </span>
              </div>
            </li>

            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/pic201402130148581.jpg" alt="" style="height:70px; width:160px;"></a>
              </div>
              <div class="num">
                奖励：
                <span class="orange">
                  <b>530,000</b>
                </span>
              </div>
            </li>
            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/pic201402130148581.jpg" alt="" style="height:70px; width:160px;"></a>
              </div>
              <div class="num">
                奖励：
                <span class="orange">
                  <b>530,000</b>
                </span>
              </div>
            </li>

            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/pic201402130148581.jpg" alt="" style="height:70px; width:160px;"></a>
              </div>
              <div class="num">
                奖励：
                <span class="orange">
                  <b>530,000</b>
                </span>
              </div>
            </li>
            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/pic201402130148581.jpg" alt="" style="height:70px; width:160px;"></a>
              </div>
              <div class="num">
                奖励：
                <span class="orange">
                  <b>530,000</b>
                </span>
              </div>
            </li>

            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/pic201402130148581.jpg" alt="" style="height:70px; width:160px;"></a>
              </div>
              <div class="num">
                奖励：
                <span class="orange">
                  <b>530,000</b>
                </span>
              </div>
            </li>
            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/pic201402130148581.jpg" alt="" style="height:70px; width:160px;"></a>
              </div>
              <div class="num">
                奖励：
                <span class="orange">
                  <b>530,000</b>
                </span>
              </div>
            </li>

            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES____PUBLIC__/images/prize/pic201402130148581.jpg" alt="" style="height:70px; width:160px;"></a>
              </div>
              <div class="num">
                奖励：
                <span class="orange">
                  <b>530,000</b>
                </span>
              </div>
            </li>
            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/pic201402130148581.jpg" alt="" style="height:70px; width:160px;"></a>
              </div>
              <div class="num">
                奖励：
                <span class="orange">
                  <b>530,000</b>
                </span>
              </div>
            </li>

            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/pic201402130148581.jpg" alt="" style="height:70px; width:160px;"></a>
              </div>
              <div class="num">
                奖励：
                <span class="orange">
                  <b>530,000</b>
                </span>
              </div>
            </li>
            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/pic201402130148581.jpg" alt="" style="height:70px; width:160px;"></a>
              </div>
              <div class="num">
                奖励：
                <span class="orange">
                  <b>530,000</b>
                </span>
              </div>
            </li>

            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/pic201402130148581.jpg" alt="" style="height:70px; width:160px;"></a>
              </div>
              <div class="num">
                奖励：
                <span class="orange">
                  <b>530,000</b>
                </span>
              </div>
            </li>
          </ul>
        </div>
      </div>
    </div>
    <div class="div_content">
      <div class="webmessage">
        <div class="msg_prize_title">
          <h2>网站公告</h2>
          <a href="#" class="more_notice">更多&gt;&gt;</a>
        </div>
        <div class="notice_list">
          <ul >
            <?php if(is_array($notice)): $i = 0; $__LIST__ = $notice;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i;?><li>
                <a href="<?php echo U("__HOME__/Tpl/notice/".$vo['con_link']);?>"><?php echo ($vo["title"]); ?></a>
              </li><?php endforeach; endif; else: echo "" ;endif; ?>
          </ul>
        </div>
      </div>
      <div class="prizes">
        <div class="msg_prize_title">
          <h2>热门奖品</h2>
          <a href="#" class="more_notice">更多&gt;&gt;</a>
        </div>
        <div class="prizes_list">
          <ul>
            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/201402131149381ba601.jpg" alt="" style="height:132px; width:160px;"></a>
              </div>
              <div class="name">
                <a href="">iPod shuffle</a>
              </div>
              <div class="num">
                兑换：
                <span class="orange"> <b>530,000</b>
                </span>
              </div>
            </li>

            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/20140213114834047bfe.jpg" alt="" style="height:132px; width:160px;"></a>
              </div>
              <div class="name">
                <a href="">苹果 MacBook</a>
              </div>
              <div class="num">
                兑换：
                <span class="orange"> <b>8,460,000</b>
                </span>
              </div>
            </li>

            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/20140213114707336208.jpg" alt="" style="height:132px; width:160px;"></a>
              </div>
              <div class="name">
                <a href="">Bose SoundLink Bluetooth</a>
              </div>
              <div class="num">
                兑换：
                <span class="orange">
                  <b>2,800,000</b>
                </span>
              </div>
            </li>

            <li>
              <div class="imgDiv">
                <a href="">
                  <img src="__IMAGES__/prize/20140213115614e3bce7.jpg" alt="" style="height:132px; width:160px;"></a>
              </div>
              <div class="name">
                <a href="">佳能 600D 18-55</a>
              </div>
              <div class="num">
                兑换：
                <span class="orange">
                  <b>5,250,000</b>
                </span>
              </div>
            </li>
          </ul>
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