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