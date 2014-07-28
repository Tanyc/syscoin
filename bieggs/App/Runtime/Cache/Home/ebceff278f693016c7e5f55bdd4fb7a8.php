<?php if (!defined('THINK_PATH')) exit();?><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>晒奖-专业的广告游戏平台</title>
    <link rel="stylesheet" type="text/css" href="__CSS__/glory.css" />
    <script type="text/javascript" src="__JS__/glory.js"></script>
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
    <script type="text/javascript">
        img_path = '__IMAGES__';
    </script>
    <div id="body_content">
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

        <div class="doc">
            <div class="layout_wz">
                <img src="__IMAGES__/glory/sj_topt.jpg"></div>
            <div class="layout_nav">
                <div class="layout_nav_l">
                    <ul>
                        <li class="glory_tab_0">
                            <a href="<?php echo U('');?>">玩家晒奖</a>
                        </li>
                        <li class="line">|</li>
                        <li class="glory_tab_1">
                            <a href="<?php echo U('?extra1=1');?>">我的晒奖</a>
                        </li>
                    </ul>
                </div>
                <style type="text/css">.glory_tab_<?php echo ($m_tab); ?>{background:url(__IMAGES__/glory/sj_nav_xzbg.png) center bottom no-repeat; height:51px;font-weight:bold;}</style>
                <div class="layout_nav_r">
                    <a href="http://www.pceggs.com/ShowPrize/ShowAdd.aspx">
                        <img src="__IMAGES__/glory/sj_an.gif"></a>
                    &nbsp;&nbsp;
                    <a href="http://www.pceggs.com/ShowPrize/showrule.aspx">
                        <img src="__IMAGES__/glory/gz_an.gif"></a>
                </div>
            </div>
            <div class="bbs_layout_dbg clearall">
                <div id="PanelList">
                    <div class="list-tab">
                        <?php if(is_array($db_glorylist)): $i = 0; $__LIST__ = $db_glorylist;if( count($__LIST__)==0 ) : echo "" ;else: foreach($__LIST__ as $key=>$vo): $mod = ($i % 2 );++$i;?><div class="tlq_beta3_sj_box_w">
                                <div class="tlq_beta3_sj_box_w_l">
                                    <div class="tlq_beta3_sj_box_w_l_img">
                                        <a href="http://www.pceggs.com/pgComUserInfo.aspx?userid=15337153">
                                            <img src="/bidan/bieggs/Public/Images/glory/b_mt_01.jpg"></a>
                                    </div>
                                    <div class="tlq_beta3_sj_box_w_l_name">
                                        <a class="linkblue_a1" href="http://www.pceggs.com/pgComUserInfo.aspx?userid=15337153">雷诺越</a>
                                    </div>
                                </div>
                                <div class="tlq_beta3_sj_box_w_r">
                                    <div class="tlq_beta3_sj_box_w_r_top">
                                        <div class="tlq_beta3_sj_box_w_r_top_l">
                                            <div class="tlq_beta3_sj_box_w_r_top_l_l">
                                                <span><?php echo ($vo["title"]); ?></span>
                                            </div>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_top_r">发表时间：<span><?php echo ($vo["CTIME"]); ?></span></div>
                                    </div>
                                    <div class="tlq_beta3_sj_xuxian"></div>
                                    <div class="tlq_beta3_sj_box_w_r_bottom">
                                        <div class="tlq_beta3_sj_box_w_r_bottom_l">
                                            <span style="color:black">
                                                <script type="text/javascript">
                                                    shortDesc('<?php echo ($vo["content"]); ?>');
                                                </script>
                                            </span>
                                            <br>
                                            <a href="<?php echo U('detail');?>?id=<?php echo ($vo["id"]); ?>">[详细]</a>
                                        </div>
                                        <div class="tlq_beta3_sj_box_w_r_bottom_r">
                                            <div class="tlq_beta3_sj_box_w_r_bottom_r_t">
                                                <ul>
                                                    <script type="text/javascript">
                                                        showShortImgs('<?php echo ($vo["imgs"]); ?>','<?php echo ($vo["id"]); ?>');
                                                    </script>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div><?php endforeach; endif; else: echo "" ;endif; ?>
                    </div>
                </div>
            </div>
            <head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link rel="stylesheet" type="text/css" href="__CSS__/pagebot.css" />
</head>
<form name="pgindex" method="post" action="__URL__" id="pgindex">
  <input id="pg" name="pg" type="hidden" value="">
  <input id="extra1" name="extra1" type="hidden" value="">
  <input id="extra2" name="extra2" type="hidden" value="">
</form>
<script language="javascript" type="text/javascript">
  var itemPerPage = <?php echo ($items); ?>;

    function calcAllPg(items,is_ret){
        var pages = Math.ceil(items / itemPerPage);
        if (is_ret) {
          return pages;
        };
        document.write(pages);
    }
    var allpage = calcAllPg(<?php echo ($db_data_cnt); ?>,true);
    function onsubmit(cur_pg){
        document.getElementById("pg").value = cur_pg;
        document.getElementById("pgindex").submit();
    }

    function calcPage(fora,index,cur_pg){
      if ("f" == fora) {
        if(1 == index){ //首页
          return (0 > cur_pg - 80)? 1 : cur_pg - 80;
        }else if(2 == index){ //前十页
          return (0 > cur_pg - 8)? 1 : cur_pg - 8;
        }
      }else{
        if(1 == index){ //后一页
          return (cur_pg + 8 > allpage)? allpage : cur_pg + 8;
        }else if(2 == index){  //后十页
          return (cur_pg + 80 > allpage)? allpage : cur_pg + 80;
        }
      }
    }

    function geItem(fora,index,title,cur_pg){
      var page = calcPage(fora,index,cur_pg);
      if ("f" == fora) {
          var fuhao = (1 == index)? "&lt;&lt;" : "&lt;";
          var item = '<a href="javascript:onsubmit(' + page + ');" target="_top">' + fuhao + '</a>';
      } else{
          var fuhao = (2 == index)? "&gt;&gt;" : "&gt;";
          var item = '<a href="javascript:onsubmit(' + page + ');" target="_top">' + fuhao + '</a>';
      };

      return item;
    }
</script>
<table cellspacing="2" cellpadding="2" style="font-family:Tahoma; font-size:12px; text-align:center; border:0; width:100%;" class="phoenix">
  <tbody>
    <tr valign="middle">
      <td align="left">
        <span title="记录总数" style="cursor:pointer;">
          <span>&nbsp;&nbsp;记录总数：</span>
          <span class="fontc"><?php echo ($db_data_cnt); ?></span>
        </span>
        <span title="总页数" style="cursor:pointer;">
          <span>&nbsp;&nbsp;总页数：</span>
          <span class="fontc">
            <script type="text/javascript">calcAllPg(<?php echo ($db_data_cnt); ?>);</script>
          </span>
        </span>
        &nbsp;&nbsp;
        <span title="当前页" style="cursor:pointer;">
          <span>&nbsp; &nbsp;当前页：</span>
          <span class="fontc"><?php echo ($cur_pg); ?></span>
        </span>
      </td>
      <td align="center">
        <div class="pageb">

          <block id="f_pg"></block>
          <block id="pgblock"></block>
          <block id="a_pg"></block>
        </div>
      </td>
      <td align="right">
        <span title="当前记录数" style="cursor:pointer;">
          <span>&nbsp;&nbsp;当页记录数：</span>
          <span class="fontc"><?php echo ($items); ?></span>
        </span>
      </td>
    </tr>
  </tbody>
</table>
<script type="text/javascript">
var sh = {f:1,a:1};
  var content = "";
  if (allpage <= 8 || <?php echo ($cur_pg); ?> <= 8) {
    var loop = (allpage <= 8)? allpage : 8;
    for (var i = 1; i <= loop; i++) {
      var item = "";
      if (<?php echo ($cur_pg); ?> == i) {
        item += '<span class="current">' + i +'</span>';
      }else{
        item = '<a href="javascript:onsubmit(' + i +');"' + 'target="_top">' + i + '</a>';
      }
      content += item + "&nbsp;";
    };
    var sh_pg = Math.ceil(allpage / 8);
    if (sh_pg <= 1) {
      sh = {f:0,a:0}
    }else{
      var cur_pg = Math.ceil((<?php echo ($cur_pg); ?> - 1) / 8);
      if (cur_pg <= 1) {
        sh.f = 0;
      }else if(cur_pg == sh_pg){
        sh.a = 0;
      }
    }
  }else{
    var curpg = <?php echo ($cur_pg); ?>;
    if(curpg > allpage){
      curpg = allpage - 1;
    }
    var st_index = Math.floor((curpg - 1) / 8);

    var topnum = (st_index + 1) * 8 ;
    if (topnum > allpage) {
      topnum = allpage;
    };

    for (var i = st_index * 8 + 1; i <= topnum; i++) {
      var item = "";
      if (<?php echo ($cur_pg); ?> == i) {
        item += '<span class="fontc">' + i +'</span>';
      }else{
        item = '<a href="javascript:onsubmit(' + i +');"' + 'target="_top">' + i + '</a>';
      }
      content += item + "&nbsp;";
    };
    var sh_pg = Math.ceil(allpage / 8);
    var c_pg = Math.ceil(curpg / 8);
  if (c_pg >= sh_pg) {
    sh.a = 0;
  }
  }
  var pgblock = document.getElementById("pgblock");
  pgblock.innerHTML=content;
    /***********f_pg***************/
    var f_pg = document.getElementById("f_pg");
  var item1 = geItem("f",1,"首页",<?php echo ($cur_pg); ?>) + "&nbsp;";
  var item2 = geItem("f",2,"前十页",<?php echo ($cur_pg); ?>) + "&nbsp;";
  f_pg.innerHTML=item1 + item2;
  /************a_pg***************/
  var a_pg = document.getElementById("a_pg");
  var item1 = geItem("a",1,"后一页",<?php echo ($cur_pg); ?>) + "&nbsp;";
  var item2 = geItem("a",2,"后十页",<?php echo ($cur_pg); ?>) + "&nbsp;";
  a_pg.innerHTML=item1 + item2;
</script>
        </div>
    </div>
    <script type="text/javascript">
        document.getElementById("extra1").value=<?php echo ($m_tab); ?>;
    </script>
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
</body>
</html>