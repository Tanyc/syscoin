﻿$(document).ready(function (){
//点击投注模式
$(".img_bt1").click(function(){
					var i=$(this).attr("attr");
					clear();
					clearUmode();
					$(this).css("background-image","url(../../../Public/Images/public/img_bt_o.gif)");
					setValue(i);
					getAllpceggs();
							 }).hover(
  function () {
    $(this).css("color","#FF6600");
  },
  function () {
     $(this).css("color","#515151");//鼠标移过后样式
  }
); 
//点击每个栏目倍数
$("#panel").find("input[name='Add']").click(function(){
                                   var peilv=$(this).val();
								   var txt=$(this).parent().prev("td").children("input");
								   if(!txt.attr("readonly")){
			                        var  txt_value=txt.val().replace(/,/gi,"");
									if(!txt_value){return;}
									var new_value=Math.floor(txt_value*peilv);
									txt.val(ver(new_value+""));
									getAllpceggs();
								   }
								   })

//点击checkbox,反向选择
$("input[name='checkboxd']").each(function(i){
										  $(this).click(function(){
											if($(this).attr("checked")){
												$(this).parent().next("td").children("input").val(nub1[i]);
											}else{
												$(this).parent().next("td").children("input").val("");}
												getAllpceggs()
											})
										   })
//点击号码
$("#panel td img").each(function(i){
								 $(this).click(function(){
						  var dom=$(this).parent().next("td").next("td").next("td").children("input");
						  if(!dom.attr("disabled")){
							if(!dom.attr("checked")){
											dom.parent().next("td").children("input").val(nub1[i]);//改了
											dom.attr("checked",true);
											}else{
                                                 dom.parent().next("td").children("input").val("");
											dom.attr("checked",false);
											}
											getAllpceggs()						
						         }
						      })
						  }).css("cursor","pointer");

//点击反选按钮
$(".touzhu2").eq(0).click(function(){ ani_select();})
//点击清除按钮
$(".touzhu2").eq(1).click(function(){ clear();})
//刷新赔率
$(".touzhu1").eq(0).click(function(){ refreshd(Periods);})
//上期投注
$(".touzhu1").eq(1).click(function(){ personmode(BeforePeriods);})
//点击整体的倍数
$("#border_out1_l").find("span").click(function(){
												var peilv=$(this).text().replace("倍","");
												setAllvalue(peilv);
												getAllpceggs();
												}).hover(
  function () {
    $(this).css("color","#FF6600");
  },
  function () {
     $(this).css("color","#8d5000");//鼠标移过后样式
  }
);

//输入投注数据
$("#panel").find("input[name='SMONEY']").keyup(function(){
	 var regex=/^[1-9]\d{0,}$/;
	 var val=$(this).val();
	 if(!regex.test(val)){	 
	  val=val.replace(/\D/g,'');
	   $(this).val(val);
	 }
	 if(!regex.test(val)){
		$(this).val(val.substring(1));
			getAllpceggs(); 
		 }else{
			 $(this).parent().prev("td").children("input").attr("checked",true);
			 getAllpceggs(); 
			 }
	}).blur(function(){
		$(this).val(ver($(this).val()));
		}).focus(function(){
			if($(this).val().indexOf(",")>-1){
			domvalue=$(this).val().replace(/,/gi,"");
			$(this).val(domvalue);
			}
			try{
			var obj = event.srcElement;    
            var txt =obj.createTextRange();    
                txt.moveStart('character',obj.value.length);    
                txt.collapse(true);    
                txt.select(); 
			}catch(e){
				}
			});
});






















//标准投注模式设定方法
function setValue(num){
	for(var i=0;i<mode[num].length;i++){
		var id_num=mode[num][i];
		var id_name="#txt"+mode[num][i];
		if(!$(id_name).attr("readonly")){
		$(id_name).val(nub[id_num]);
		$(id_name).parent().prev("td").children("input").attr("checked",true);
		}
		}
	}
//清除方法
function clear(){
$(".img_bt1").css("background-image","url(../../../public/images/public/img_bt_y.gif)");
	$("#panel").find("input[name='SMONEY']").each(function(){
														if(!$(this).attr("readonly")){
															$(this).val("");
															}});
	$("#panel").find("input[name='checkboxd']").attr("checked",false);
	$("#totalvalue").text("0");
}

//数字加千分符号
function ver(n){
	re=/(\d{1,3})(?=(\d{3})+(?:$|\.))/g    
	return n.replace(re,"$1,")    
}
	
//设置所有赔率
function setAllvalue(peilv){
     $("#panel").find("input[name='SMONEY']").each(function(){
										if(!$(this).attr("readonly")){
										 var  txt_value=$.trim($(this).val()).replace(/,/gi,"");
									          if(txt_value&&!isNaN(txt_value)){
									             var new_value=Math.floor(txt_value*peilv);
												 $(this).val(ver(new_value+"")); }}});
	      }
//反选		  
function ani_select(){
	$("input[name='checkboxd']").each(function(i){ 
								if(!$(this).attr("disabled")){			   
								if(!$(this).attr("checked")){
												$(this).parent().next("td").children("input").val(nub1[i]);
											$(this).attr("checked",true);
											}else{
													$(this).parent().next("td").children("input").val("");
												$(this).attr("checked",false);
											}
											}
											   }
									  )
	getAllpceggs();
			  }

function clearUmode(id){  //总共有15种用户模式
	for (var i = 0; i <= 15; i++) {
		$('.umode' + i).css("color", "#ff8c00");
	};
}  
//自定义模式 
function personmode(id){
	clearUmode();
	$('.umode' + id).css("color", "#ff0000");
	$.ajax({
	    type:"get",
	    url:"../../../bets/userMode?id="+id,
		error:function(){
			alert("操作错误");
		},
	    success:function(data, textStatus){
	    	var test = data.split(",");
			UserMode(data.split(","));
	    }
	});
}

//刷新赔率 
function refreshd(id){
	  $.ajax({
    type:"get",
    url:"pg28mode.aspx?refresh="+id,
	error:function(){
//	alert("操作错误");
  //showmessage("10","操作错误！",LastIssue);
	},
    success:function(data, textStatus){
   setpeilv("",data.split(","));//当前赔率
    }
  });
	}

//载入开奖时间
function initParams(){
	showvalue(arr1,1);
	$(".ardown").text(ver(aldown));
	$(".open_time").text(open_time);
	$(".llid").siblings("img").attr("src",img_path + "/game/nums/number_" + getLastNum(LLNUM) + ".gif");
	addUserMode();
}

function addUserMode(){
	var html = "";
	for (var i = 0; i <= umode.length - 1; i++) {
		html += '<a class=umode' + i + ' style="color:#ff8c00;font-weight:bold;" href="javascript:personmode(' + i + ')">' + umode[i] + '</a> ';
	};
	$(".user_mode").html(html);
}

function getLastNum(LLNUM){
  if("" == LLNUM || null == LLNUM){
    return "-";
  }else{
    nums = LLNUM.toString();
    var f_num = parseInt(nums.charAt(0));
    var s_num = parseInt(nums.charAt(1));
    var t_num = parseInt(nums.charAt(2));
    return f_num + s_num + t_num;
  }
}

function showvalue(arr,flag){
    if(StrTimeOut=="-1"){
      showmessage("3","该期已经截止投注！",LastIssue);
     return false;
    }else if(IsGetEggs=="1"){
         showmessage("8","目前您的账户上金蛋少于5000，是否需要免费获取金蛋？",LastIssue);

     }
	$.each(arr, function(i){
            if(this!=""){
			    if($("#txt"+i).attr("readonly")){
		            return;
		        }
		        if(flag){
		            $("#txt"+i).parent().prev("td").children("input").attr("disabled",true);
		            $("#txt"+i).attr("readonly",true).attr("disabled",true).css("color", "#ff8c00");
		        }else{
		            $("#txt"+i).parent().prev("td").children("input").attr("checked",true);
			    }
			    $("#txt"+i).val(ver(this));
		    }
        }
); 
	getAllpceggs();
}

//自定义投注模式
function UserMode(arr,flag){
if(StrTimeOut=="-1")
{
  showmessage("3","该期已经截止投注！",LastIssue);
  return false;
 // $("#div_ad").css("display","");
return;
}
	 clear();
	$.each(arr, function(i){
    if(this!=""){
		if($("#txt"+i).attr("readonly")){
		return;
		}
		if(flag){
			$("#txt"+i).parent().prev("td").children("input").attr("disabled",true);
		$("#txt"+i).attr("readonly",true).attr("disabled",true);
		}else{
		    $("#txt"+i).parent().prev("td").children("input").attr("checked",true);
			}
			$("#txt"+i).val(ver(this));
		}
}); 
	getAllpceggs();
	}


var first=0;
//取总的投注金蛋
function getAllpceggs(){
	var total=0;
	$("#panel").find("input[name='SMONEY']").each(function(){
		if(!$(this).attr("readonly")){
			var txt_value=$.trim($(this).val()).replace(/,/gi,"");	
			if(txt_value&&!isNaN(txt_value)){
				total+=parseInt(txt_value);
			}
		}
	})

$("#totalvalue").text(ver(total+""));



if(readcookie("handflag")=="1"){
if($("#totalvalue").text()!=0&&first==0){
first=1;
 $("#help_show1").css("display",""); 
 $("#help_show").css("display","none"); 
}
}
//if(total>maxnum){
//alert("对不起，总投注金额不能超过投注上限！");}
// if(total>mypceggs){
//alert("您的余额不足！");}
	}
function setpeilv(a_cis,a_cis1){
if(a_cis!=""){
	$.each(a_cis,function(i){
			var v=this+"";
//		$("#txt"+i).parent().prev("td").prev("td").text(v);	//上期赔率
        $("#txt"+i).parent().prev("td").prev("td").prev("td").text(v);	//上期赔率
						})
}
if(a_cis1!=""){
	$.each(a_cis1,function(i){
			var v=this+"";
//		$("#txt"+i).parent().prev("td").prev("td").prev("td").text(v);	//当前赔率
        $("#txt"+i).parent().prev("td").prev("td").text(v);	//当前赔率
						})

	}
}
//确认投注	
function comform(){
	t=$("#totalvalue").text().replace(/,/gi,"");
	t=parseInt(t);
	var str=[];
	if(t>maxnum){
		showmessage("11","对不起，总投注金额不能超过投注上限！",LastIssue);
		return false;
	}else if(t==0){
		showmessage("13","您还没有投注！",LastIssue);
		return false;
	}else if(t>mypceggs){
		showmessage("12","您的金蛋不足！",LastIssue);
		return false;
	} else { 
		var str=[];
		for(var i=0;i<28;i++){
			var  txt_value=$.trim($("#txt"+i).val()).replace(/,/gi,"");	
			     str.push(txt_value);	
			}
		$("#ALLSMONEY").val(str.join(","));
		showmessage("9","本次投注将扣除您<span id='postgoldeggs' style='color :Red;font-weight:bold'></span>个金蛋！<br/><input type='hidden' name='isdb' id='isdb' value='1'  style='margin-right:2px' />",LastIssue);
		t=ver(String(t));//将数字转字符串后千分位 
		$("#postgoldeggs").html(t);
		$("#SMONEYSUM").val(t);
	}
}	

//倒计时

function GetRTime(ctime,Isue){    
    var nS=ctime;  
    var LID=Isue;
    if(nS>0){
      nS = nS-1	  
      document.getElementById("RemainTitle").innerHTML="<span  style='color: #FF6C00;font-size: 14px;'>距离第<span style='font-size:18px; color:#f00'>"+LID+"</span>期开奖还有<span style='font-size:18px; color:#f00'>"+nS+"</span>秒</span>";  
    }else{
       document.getElementById("RemainTitle").innerHTML="<span class='form_game'>第<span style='font-size:12px'>"+LID+"</span>期正在开奖中！</span>";  
       
    }
    setTimeout("GetRTime("+nS+","+LID+")",1000);  
}  

//是否按现模式自动投注
function ischecked(){
 var isdb   = document.getElementById("isdb")//子层
 var isdb_p ="";//父层
 if(isdb.checked==true){
      document.getElementById("isdb_p").value ="1";
 }else{
       document.getElementById("isdb_p").value ="0";
 }
}

 //取消投注
function rm(){
  // document.getElementById("isdb_p").value ="0";
  document.getElementById("div_ad").style.display = 'none';
  document.getElementById("div_full").style.display = 'none';
}

//确认投注
function datapost(){
	$("input[name='SMONEY']").attr("disabled",true);
	var form1 =document.getElementById("form1");//父层
	form1.submit();
}

function showDialog(isShow){
	if (isShow) {
		$(".div_full").css("display","");
		$("#div_ad").css("display","");
	}else{
		$(".div_full").css("display","none");
		$("#div_ad").css("display","none");
	}
}


//投注后信息返回
function showmessage(flag,msg,NLid){
	showDialog(true);
	sc1();
	switch(flag){
		case "0":
			if(readcookie("handflag")=="1"){
				setcookie("handflag","2");
			}
			window.location.href="pc28.aspx"; 
			break;
		case "1"://投注失败
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">投注失败</span><a href="pc28.aspx" class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="text-align:center;"><a href="pc28.aspx" style="width:72px;height:22px;background:url(/img/pg28/popup_btn3.png) no-repeat;display:block;cursor:pointer; margin:0 auto"> </a></div>');
			break;
		case "2"://投注金蛋少于现有金蛋
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">投注失败</span><a href="pc28.aspx"  class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="text-align:center;"><a onclick="return rm();" style="width:72px;height:22px;background:url(./Public/Images/game/popup_ok.png) no-repeat;display:block;cursor:pointer; margin:0 auto"> </a></div>');
			break;
		case "3"://已截至投注
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">投注失败</span><a href="pc28.aspx"  class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="float:left; "><a href="pg28Insert.aspx?LID='+NLid+'" style="width:90px;height:22px; background:url(/img/pg28/popup_btn1.png) no-repeat;display:block;cursor:pointer;"> </a></div> <div style="float:right;"><a href="pc28.aspx" style="width:72px;height:22px;background:url(/img/pg28/popup_btn3.png) no-repeat;display:block;cursor:pointer;"> </a></div> ');
			break;
		case "4"://重复投注
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">投注失败</span><a href="pc28.aspx"  class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="text-align:center;"><a href="pc28.aspx" style="width:72px;height:22px;background:url(/img/pg28/popup_btn3.png) no-repeat;display:block;cursor:pointer; margin:0 auto"> </a></div>');
			break;
		case "5"://总投注金额超过上限
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">投注失败</span><a onclick="return rm();" class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="text-align:center;"><a onclick="return rm();" style="width:72px;height:22px;background:url(./Public/Images/game/popup_ok.png) no-repeat;display:block;cursor:pointer; margin:0 auto"> </a></div>');
			break;
		case "6"://系统异常（数据库返回）
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">投注失败</span><a href="pc28.aspx"  class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="text-align:center;"><a href="pc28.aspx" style="width:72px;height:22px;background:url(/img/pg28/popup_btn3.png) no-repeat;display:block;cursor:pointer; margin:0 auto"> </a></div>');
			break;
		case "7"://系统异常（程序）
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">投注失败</span><a href="pc28.aspx"  class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="text-align:center;"><a href="pc28.aspx" style="width:72px;height:22px;background:url(/img/pg28/popup_btn3.png) no-repeat;display:block;cursor:pointer; margin:0 auto"> </a></div>');
			break;
		case "8"://金蛋少于5000
			$("#help_show").css("display","none");
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">金蛋少于5000</span><a onclick="return showDialog(false);"  class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="float:left; "><a href="javascript:getgoldeggs()" style="width:72px;height:22px;background:url(/img/pg28/popup_btn4.png) no-repeat;display:block;cursor:pointer;"> </a></div> <div style="float:right;"><a onclick="return rm();"  style="width:72px;height:22px;background:url(/img/pg28/popup_btn2.png) no-repeat;display:block;cursor:pointer;"> </a></div> ');
			break;
		case "9"://确认投注
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">确认投注</span><a onclick="showDialog(false);" class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="float:left; "><a onclick="return datapost()"  style="width:72px;height:22px; background:url(../../../Public/Images/game/popup_ok.png) no-repeat;display:block;cursor:pointer;"></a></div> <div style="float:right;"><a onclick="showDialog(false);"  style="width:72px;height:22px; background:url(../../../Public/Images/game/popup_cancel.png) no-repeat;display:block;cursor:pointer;"></a></div> ');
			break;
		case "10"://系统异常（投注模式pg28mode.aspx）
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">投注失败</span><a href="pc28.aspx"  class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="text-align:center;"><a href="pc28.aspx" style="width:72px;height:22px;background:url(/img/pg28/popup_btn3.png) no-repeat;display:block;cursor:pointer; margin:0 auto"> </a></div>');
			break;
		case "11"://投注金额超过上限
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">投注金额超过上限</span><a onclick="showDialog(false);" class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="text-align:center;"><a onclick="showDialog(false);" style="width:72px;height:22px;background:url(../../../Public/Images/game/popup_ok.png) no-repeat;display:block;cursor:pointer; margin:0 auto"> </a></div>');
			break;
		case "12"://金蛋投余额不足
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">您的金蛋不足！</span><a onclick="showDialog(false);" class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="text-align:center;"><a onclick="showDialog(false);" style="width:72px;height:22px;background:url(../../../Public/Images/game/popup_ok.png) no-repeat;display:block;cursor:pointer; margin:0 auto"> </a></div>');
			break;
		case "13"://没有投注
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">请先投注！</span><a onclick="showDialog(false);" class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="text-align:center;"><a onclick="showDialog(false);" style="width:72px;height:22px;background:url(../../../Public/Images/game/popup_ok.png) no-repeat;display:block;cursor:pointer; margin:0 auto"> </a></div>');
			break;
		case "14"://投注邀请分享浮层
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">投注成功</span><a onclick="return rm();" class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="text-align:center;"><ul><li><a href="javascript:void(0)" onclick="postToXL()"><img src="img/fc_img/fxdxl.gif" border="0"></a></li><li><a href="javascript:void(0)" onclick="postToWb()"><img src="img/fc_img/fxdtx.gif" border="0"></a></li><li><a href="javascript:void(0)" onclick="return rm();"><img src="img/fc_img/zbfx.gif" border="0"></a></li></ul></div>');
			break;
		case "15"://暂停投注
			rm();
			$("#stopsubtip").html(msg);
			$("#stoptip").css("display","");
			$("#savetip").css("display","none");
			return;
			break;
		case "16"://验证码错误
			$(".content1").html(msg);
			$(".titleclose").html('<span class="title">提示</span><a onclick="return rm();" class="close"><span>X</span></a>');
			$(".btnpane").html('<div style="text-align:center;"><a onclick="return rm();" style="width:72px;height:22px;background:url(../../../Public/Images/game/popup_ok.png) no-repeat;display:block;cursor:pointer; margin:0 auto"> </a></div>');
			return;
			break;
	}
}  

//投注后信息返回
function showmessage1(issue){
rm();
////弹出浮层
 $("#div_ad1").css("display","");
sc11();

$(".content2").html('<div class="content_zc">第<span  style="color :Red;">'+issue+'</span>期投注成功！<br>&nbsp;&nbsp;&nbsp;&nbsp;举手之劳，分享幸运28到微博，<a href="/new_invite/inviteindex.aspx" class="a3" style="color:#515151;">获<span  style="color :Red;">百万</span>邀请奖励和<span  style="color :Red;">50%</span>高额提成</a>。</div>');
$(".titleclose").html('<span class="title">投注成功</span><a onclick="return rm1();" class="close"><span>X</span></a>');
$(".btnpane_fx").html('<ul><li><a href="javascript:void(0)" onclick="postToXL();return rm1();"><img src="/img/fxdxl.gif" border="0"></a></li><li><a href="javascript:void(0)" onclick="postToWb();return rm1();"><img src="/img/fxdtx.gif" border="0"></a></li><li><a href="javascript:void(0)" onclick="return rm1();"><img src="/img/zbfx.gif" border="0"></a></li></ul>');



 //弹出笼罩层
 var bodyheight = document.getElementById('ad_body').clientHeight;
 var parent_div = document.getElementById("parent_div");
 parent_div.style.display = 'block'; 
 parent_div.style.height = parseInt(bodyheight) + 'px';  

}

function sc11(){    
	document.getElementById("div_ad1").style.top=(document.documentElement.scrollTop+document.body.scrollTop+(document.documentElement.clientHeight-document.getElementById("div_ad1").offsetHeight)/2)+"px";    
	document.getElementById("div_ad1").style.left=(document.documentElement.scrollLeft+(document.documentElement.clientWidth-document.getElementById("div_ad1").offsetWidth)/2)+"px";    
} 
function sc1(){
	document.getElementById("div_ad").style.top=(document.documentElement.scrollTop+document.body.scrollTop+(document.documentElement.clientHeight-document.getElementById("div_ad").offsetHeight)/2)+"px";    
	document.getElementById("div_ad").style.left=(document.documentElement.scrollLeft+(document.documentElement.clientWidth-document.getElementById("div_ad").offsetWidth)/2)+"px";    
} 
 //取消投注
function rm1()
{
  document.getElementById("isdb_p").value ="0";
  document.getElementById("div_ad1").style.display = 'none';
  document.getElementById("parent_div").style.display = 'none';
  window.location.href="pc28.aspx"; 
}

function getgoldeggs(){
$("#help_show").css("display","none");
ShowMsgo.show("/adcomate/pggetgoldeggsnew.aspx",503,518);
  document.getElementById("div_ad").style.display = 'none';
  document.getElementById("parent_div").style.display = 'none';


}   
function  closelinqu(){
ShowMsgo.cancel();
 window.location.reload(true); 
}