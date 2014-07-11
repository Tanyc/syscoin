function changeimg(n){
    if(n==1){
        document.getElementById("area1").style.display="none";
        document.getElementById("area2").style.display="";
    }
    if(n==2){
        document.getElementById("area1").style.display="";
        document.getElementById("area2").style.display="none";
    }
    for (var i = 1; i <= 2; i++) {
        if (i == n) {
            $("#setdata" + i).addClass("on");
            $("#dyp" + i).css("display", "");
        } else {
            $("#setdata" + i).removeClass("on");
            $("#dyp" + i).css("display", "none");
        }
    }
}