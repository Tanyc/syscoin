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