$(document).ready(function(){
	$(".tab").each(function(i){
		if (navi_tab - 1 == i) {
			$(this).attr("class","selected");
		}
	});
});