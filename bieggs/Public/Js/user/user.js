var SAFE_TYPE = {SNUMBER:0 ,IPLIMIT:1 ,SMESSAGE:2, SBANKKEY:3, SMSLOGIN:4}; 
$(document).ready(function(){
    $('.BasicInfoPart2').find('li').hover(
        function () {
            $(this).css('background', '#fff');
        },
        function () {
            $(this).css('background', 'none');
        }
    );
}
);
var growrange=new Array("初出茅庐","草民","县丞","县令","都尉","校尉","常侍","中郎将","太守","刺史","将军","太尉","大将军","皇帝");

function setExpRange(exp){
	var range = Math.floor(exp / 100);
	if (range >= 1) {
		for (var i = 1; i <= range; i++) {
			var doc = '<span><img src="' + image_path + '/user/star.png" title="等级:' + range + '级"></span>';
			document.write(doc);
		};
	} else{
		var doc = '<span><img src="' + image_path + '/user/star_0.png" title="等级:0级"></span>';
		document.write(doc);
	};
}

function setJifenRange(jifen){
	var range = Math.floor(jifen / 1000);
	var doc = '<span class="lvrange_0 lv">LV0</span>';
	if (range >= 1) {
		var doc = '<span class="lvrange lv">LV' + range + '</span>';
	}
	document.write(doc);
}

function setVipRange(vip){
	var range = Math.floor(vip / 1000);
	var doc = '<span><img src="' + image_path + '/user/vip/lv0.png" title="等级:0级"></span>';
	if (range >= 1) {
		var doc = '<span><img src="' + image_path + '/user/vip/lv' + range + '.png" title="等级:' + range + '级"></span>';
	}
	document.write(doc);
}


function setGrowRange(grow){
	var range = Math.floor(grow / 1000);
	var doc = '<a href="#" class="lv">' + growrange[range] + '</a>';
	document.write(doc);
}

function setMsgShow(title,msg,bntmsg,isimg_yes,linkid){
	var imgdoc = '<img src="'+ image_path + '/user/no_1.gif" class="ico">';
	if(isimg_yes){
		imgdoc = '<img src="'+ image_path + '/user/yes_1.gif" class="ico">';
		
	}
	document.write(imgdoc);
	var h5doc = '<h5>' + title + '</h5>';
	document.write(h5doc);

	var doc = '<div class="msg">' + msg + '</div>';
	document.write(doc);
	if ("" != bntmsg) {
		var bntdoc = '<a href="javascript:safeSetting(' + linkid + ')" class="btn">' + bntmsg + '</a>';
		if (SAFE_TYPE.SNUMBER == linkid) {
			bntdoc = '<a href="' + url_path + '/secure" class="btn">' + bntmsg + '</a>';
		}
		document.write(bntdoc);
	};
}

function setSafeTip(title,isimg_yes){
	var imgdoc = '<img src="'+ image_path + '/user/no_1.gif" class="ico">';
	if(isimg_yes){
		imgdoc = '<img src="'+ image_path + '/user/yes_1.gif" class="ico">';
		
	}
	document.write(imgdoc);
	var h5doc = '<h5><font color="#FF6633">' + title + '<font></h5>';
	document.write(h5doc);
}

function setSnameMsg(is_set){
	var title = "身份认证方式";
	if(1 == is_set){
		var doc = "身份认证已通过";
		setMsgShow(title,doc,"",true);
	}else{
		var doc = "身份认证未通过";
		setMsgShow(title,doc,"设置",false,SAFE_TYPE.SNUMBER);
	}
}

function setAreaMsg(is_set){
	var title = "登陆地区限制";
	if(1 == is_set){
		var doc = "登陆安全地区限制已设置";
		setMsgShow(title,doc,"",true);
	}else{
		var doc = "您还未设置登陆地区限制";
		setMsgShow(title,doc,"设置登录地区限制",false,SAFE_TYPE.IPLIMIT);
	}
}

function setMessageMsg(is_set){
	var title = "兑奖短信安全验证";
	if(1 == is_set){
		var doc = "您已设置兑奖短信验证";
		setMsgShow(title,doc,"关闭短信验证",true,SAFE_TYPE.SMESSAGE);
	}else{
		var doc = "您还未设置兑奖短信验证";
		setMsgShow(title,doc,"开启短信验证",false,SAFE_TYPE.SMESSAGE);
	}
}
function setBankMsg(is_set){
	var title = "设置银行密码";
	if(1 == is_set){
		var doc = "您已经设置银行密码";
		setMsgShow(title,doc,"",true);
	}else{
		var doc = "您还没有设置银行密码";
		setMsgShow(title,doc,"立即设置",false,SAFE_TYPE.SBANKKEY);
	}
}
function setLoginMsg(is_set){
	var title = "登陆手机短信验证";
	if(1 == is_set){
		var doc = "您已设置登录手机短信验证";
		setMsgShow(title,doc,"关闭短信验证",true,SAFE_TYPE.SMSLOGIN);
	}else{
		var doc = "您还未设置登录手机短信验证";
		setMsgShow(title,doc,"开启短信验证",false,SAFE_TYPE.SMSLOGIN);
	}
}
function setSafeTipMsg(cnt){
	var rate = cnt / 5 * 100;
	if(3 <= cnt){
		var title = "您的账号处于安全保护状态(安全设置：" + rate + "%)";
		setSafeTip(title,true);
	}else{
		var title = "您的账号处于危险状态(安全设置：" + rate + "%)，请尽快安全设置";
		setSafeTip(title);
	}
}

function safeSetting(id){
	$('.umode' + id).css("color", "#ff0000");
	$.ajax({
	    type:"get",
	    url:url_path + "/ssetting?id="+id,
		error:function(){
			alert("操作错误");
		},
	    success:function(data, textStatus){ 
	    	var setting = parseInt(data);
	    	location.reload(true); 
	    }
	});
}


