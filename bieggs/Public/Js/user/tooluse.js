$(document).ready(function(){
    $('.cardimg').click(function(i){
    	$('.cardimgbox').attr("checked",false);
    	$('.cardimg').css('border', 'none');
        $(this).css('border', '2px solid #ff0000');

        var srcimg = $(this).attr("src");
        $('.dcardimg').attr("src",srcimg);
        $('.dcard').show();
        $('.B_bor').hide();

    });
    $('.vipcard').click(function(i){
    	$('.vipcard').css('border', 'none');
        $(this).css('border', '2px solid #ff0000');

        var srcimg = $(this).attr("src");
        $('.dvipcardimg').attr("src",srcimg);
        $('.dvipcard').show();

    });
    $('.dcard').hide();
    $('.dvipcard').hide();
});