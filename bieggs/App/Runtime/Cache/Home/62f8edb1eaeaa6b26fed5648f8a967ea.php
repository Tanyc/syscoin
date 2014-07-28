<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <!-- InstanceBegin template="/Templates/navi_temp.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <!-- InstanceBeginEditable name="doctitle" -->
    <title>广告体验-专业的广告游戏平台</title>
    <link rel="stylesheet" type="text/css" href="__CSS__/ad.css" />

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
    <!--------------------------------------------------->
    <div id="body_content">
        <!-- InstanceBeginEditable name="content" -->
        <head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="__CSS__/runtext.css" />
</head>

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
</div>
<script type="text/javascript">
    var FeedData = {title:'蛋友<a href="/FriendInfor/FriendPrize.aspx?userid=8764495">__USERID__</a>兑换了<a href="/prize/prizeDetail.aspx?ISSUE=ZC0266">__P_NAME__</a>',datatype:'奖品',time:'__TIME__'};
    var msg = "";
    var speed=40; //数字越大速度越慢 20
    var tab=document.getElementById("demo"); 
    var tab1=document.getElementById("demo1"); 
    var tab2=document.getElementById("demo2"); 
    var MyMar = null;
    function Marquee(){ 
        if(tab2.offsetWidth-tab.scrollLeft<=0) {
            tab.scrollLeft -= tab1.offsetWidth;
        }else{ 
            tab.scrollLeft++; 
        } 
    }
    tab.onmouseover=function() {clearInterval(MyMar)}; 
    tab.onmouseout=function() {MyMar=setInterval(Marquee,speed)}; 
    <?php if(is_array($db_dj_slider)): $i = 0; $__LIST__ = $db_dj_slider;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i;?>var user_id = "<?php echo ($vo["user_id"]); ?>"; 
        var p_name = "<?php echo ($vo["p_name"]); ?>"; 
        var time = "<?php echo ($vo["time"]); ?>"; 
        msg += "<span>【" + FeedData.datatype + "】</span>" + FeedData.title.replace("__USERID__",user_id).replace("__P_NAME__",p_name) +" " + FeedData.time.replace("__TIME__",time) + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";<?php endforeach; endif; else: echo "" ;endif; ?> 
    tab1.innerHTML = msg;
    tab2.innerHTML = msg;
    MyMar=setInterval(Marquee,speed);
</script>

        <div id="body_content_l">
            <div id="feature_list">
                <ul id="tabs">
                    <?php if(is_array($db_slider)): $i = 0; $__LIST__ = $db_slider;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i;?><li>
                            <a href="http://www.aoyene.cc/profit.php#" class="">
                                <img src="__IMAGES__/ad/new_l.gif">
                                <h3><?php echo ($vo["name"]); ?></h3>
                                <span>
                                    奖励：<?php echo ($vo["give_eggs"]); ?>
                                    <span style="float:right;margin-right:10px">详细介绍</span>
                                </span>
                            </a>
                        </li><?php endforeach; endif; else: echo "" ;endif; ?>
                </ul>
                <ul id="output">
                    <?php if(is_array($db_slider)): $i = 0; $__LIST__ = $db_slider;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i;?><li style="display: none;">
                            <a href="http://www.aoyene.cc/adtask.php?adid=13">
                                <img src="__IMAGES__/ad/<?php echo ($vo["pic"]); ?>"></a>
                        </li><?php endforeach; endif; else: echo "" ;endif; ?>
                </ul>
            </div>
            <div id="body_content_ld">
                <div class="body_content_ld_tab">
                    <ul class="ad_tit">
                        <li <?php if(!$m_tab) echo'class="current"'; ?>
                        >
                        <a href="<?php echo U('Home/ad');?>">体验赚蛋</a>
                    </li>
                    <li <?php if(($m_tab) == "2"): ?>class="current"<?php endif; ?>
                    >
                    <a href="<?php echo U('Home/ad/play');?>">试玩赚蛋</a>
                </li>
                <li <?php if(($m_tab) == "3"): ?>class="current"<?php endif; ?>
                >
                <a href="<?php echo U('Home/ad/check');?>">调查赚蛋</a>
            </li>
        </ul>
    </div>
    <div class="body_content_id_list">
        <ul class="list_ad_index" id="eui_tab">
            <?php if(is_array($db_tiyan)): $i = 0; $__LIST__ = $db_tiyan;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i;?><li>
                    <a title="<?php echo ($vo["name"]); ?>" href="adtask.php?adid=48" target="_blank">
                        <img src="__IMAGES__/ad/tiyan/<?php echo ($vo["pic"]); ?>" width="152" height="67">
                        <span>
                            <?php echo ($vo["name"]); ?>
                            <img src="__IMAGES__/ad/new.jpg"></span>
                        <span>
                            奖
                            <br>
                            金蛋：<?php echo ($vo["give_eggs"]); ?>
                            <img src="__IMAGES__/public/egg.gif" width="14" height="14"></span>
                    </a>
                </li><?php endforeach; endif; else: echo "" ;endif; ?>
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
                                        <td align="left";>
                                            <a href="useraccount.php" class="a"> <b>dingyong4223</b>
                                            </a>
                                            &nbsp;
                                            <img src="__IMAGES__/public/vip_0.gif" align="absmiddle" border="0">
                                            &nbsp;
                                            <br>
                                            <span style="font-size: 14px;color: #c30000;font-weight: bold;">金蛋：254,356,484</span>
                                            <img src="__IMAGES__/public/egg.gif"></td>
                                    </tr>
                                    <tr></tr>
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
                        <ul id="slider"></ul>
                        <ul id="slider"></ul>
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<script>
    var animData ={title:'<span class="red"><a href="/user_detail.php?uid=" target="_blank">__USERID__：</a></span>',acttype:'<span class="blue"><a href="/adtask.php?adid=18" target="_blank">__ACTNAME__</a></span>'};
    var slider = document.getElementById("slider"); //滚动对象
    var msg = "";
    <?php if(is_array($db_tylast)): $i = 0; $__LIST__ = $db_tylast;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i;?>var user_id = <?php echo ($vo["user_id"]); ?>;      //数字类型
        var act_name = "<?php echo ($vo["act_name"]); ?>";  //字符串类型
        msg += "<li>" + animData.title.replace("__USERID__",user_id) + "体验了 " + animData.acttype.replace("__ACTNAME__",act_name) + "</li>";<?php endforeach; endif; else: echo "" ;endif; ?>
    slider.innerHTML = msg;
    var ntask = document.getElementById("ntaskmq"); //滚动对象
    var iLineHeight = 33; //单行高度，像素
    var iLineCount = 10; //实际行数
    var iScrollAmount = 1; //每次滚动高度，像素
    function runntask() {
        ntask.scrollTop += iScrollAmount;
    if ( ntask.scrollTop == iLineCount * iLineHeight )
        ntask.scrollTop = 0;
    if ( ntask.scrollTop % iLineHeight == 0 ) {
        window.setTimeout( "runntask()", 3000 );
    } else {
        window.setTimeout( "runntask()", 20 );}
    }
    ntask.innerHTML += ntask.innerHTML;
    window.setTimeout( "runntask()", 2000 );
</script>
<div class="body_content_rb">
    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1" class="top8">
        <tbody>
            <tr>
                <td width="100%" height="40" align="center" valign="bottom" background="__IMAGES__/ad/niu_person.png">
                    <table width="175" border="0" cellspacing="0" cellpadding="0" style="margin-bottom:1px">
                        <tbody>
                            <tr>
                                <td width="75">&nbsp;</td>
                                <td width="50" height="23" class="tsnews_tabon" id="tsnews_btn0" onmouseover="tabit('tsnews',0,2)" align="center" valign="middle">今日</td>
                                <td width="50" class="tsnews_taboff" id="tsnews_btn1" onmouseover="tabit('tsnews',1,2)" align="center" valign="middle">昨日</td>
                            </tr>
                        </tbody>
                    </table>

                </td>
            </tr>
            <tr>
                <td>
                    <div id="tsnews_div0">
                        <div class="n_r">
                            <ul id="con_niu_1" class="niu_list">
                                <?php if(is_array($db_niu)): $i = 0; $__LIST__ = $db_niu;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i; if($vo["data_id"] == 1 ): ?><li>
                                            <span>
                                                <img src="__IMAGES__/person/niu.jpg"><?php echo ($vo["user_id"]); ?></span>
                                            <a href="/user_detail.php?uid=1104616" target="_blank" style="color: #c30000;font-weight: bold; margin-left:60px">
                                                <?php echo ($vo["egg_win_all"]); ?>
                                                <img src="__IMAGES__/public/egg.gif"></a>
                                        </li><?php endif; endforeach; endif; else: echo "" ;endif; ?>
                            </ul>
                        </div>
                    </div>
                    <div id="tsnews_div1" style="border-top:none;display:none;">
                        <div class="n_r">
                            <ul id="con_niu_1" class="niu_list">
                                <?php if(is_array($db_niu)): $i = 0; $__LIST__ = $db_niu;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i; if($vo["data_id"] == 2 ): ?><li>
                                            <span>
                                                <img src="__IMAGES__/person/niu.jpg"><?php echo ($vo["user_id"]); ?></span>
                                            <a href="/user_detail.php?uid=1104616" target="_blank" style="color: #c30000;font-weight: bold; margin-left:60px">
                                                <?php echo ($vo["egg_win_all"]); ?>
                                                <img src="__IMAGES__/public/egg.gif"></a>
                                        </li><?php endif; endforeach; endif; else: echo "" ;endif; ?>
                            </ul>
                        </div>
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
</div>
</div>
<script language="javascript" type="text/javascript">
    function tabit(tabName,btnId,tabNumber){
        for(i=0;i<tabNumber;i++){
            document.getElementById(tabName+"_div"+i).style.display = "none";
            var etab = document.getElementById(tabName+"_btn"+i);
            etab.style.fontWeight = "";
            etab.style.color = "";
        }
        document.getElementById(tabName+"_div"+btnId).style.display = "block";
        document.getElementById(tabName+"_btn"+btnId).className = tabName+"_tabon";

        var tab = document.getElementById(tabName+"_btn"+btnId);
        tab.style.fontWeight = "bold";
        tab.style.color = "#ff0000";
    }
</script>
<style type="text/css">/*  #tsnews_btn1{color: #ff0000; font-weight:bold;}*/</style>
<!-- InstanceEndEditable -->
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
<!-- #EndLibraryItem -->
<!-- InstanceEndEditable -->
</body>
<!-- InstanceEnd -->
</html>