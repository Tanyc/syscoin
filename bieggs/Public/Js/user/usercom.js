function setData(n) {
    for (var i = 1; i <= 7; i++){
        if (i == n) {
            $("#tab" + i).addClass("a_bg1");
            $("#imfo_edit" + i).css("display", "");
        } else {
            $("#tab" + i).removeClass("a_bg1");
            $("#imfo_edit" + i).css("display", "none");
        }
    }
}