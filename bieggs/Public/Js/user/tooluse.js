$(document).ready(function(){
    $('.cardimg').click(function(i){
    	$('.cardimgbox').attr("checked",false);
    	$('.cardimg').css('border', 'none');
        $(this).css('border', '2px solid #ff0000');

        var srcimg = $(this).attr("src");
        $('.dcardimg').attr("src",srcimg);
        $('.dcardimg').show();
        showTipI($(this).attr("opt"));
        
        $('.B_bor').hide();
    });
    $('.vipcard').click(function(i){
    	$('.vipcard').css('border', 'none');
        $(this).css('border', '2px solid #ff0000');

        var srcimg = $(this).attr("src");
        $('.dvipcardimg').attr("src",srcimg).show();
        $('.dcardimg').attr("src",srcimg).show();

        showTipI($(this).attr("opt"));
    });
    $('.dcard').hide();
    $('.dvipcard').hide();
});

function showTipI(k){
    for (var i = 1; i <= 4; i++) {
        $('.dvipcard' + i).hide();
    };
    $('.dvipcard' + k).show();

    for (var i = 1; i <= 4; i++) {
        $('.dcard' + i).hide();
    };
    $('.dcard' + k).show();
    $('.tip').show();
}