function copyToClipBoard() {
    var clipBoardContent = '';
    clipBoardContent += "http://www.pceggs.cn/pgComDefault.aspx?ID=0"; 
    window.clipboardData.setData("Text", clipBoardContent);
    alert("地址已经复制到粘贴板!");
}

function chkResult28(nums,__IMAGES__) {
  if("" == nums || null == nums){
    document.write("-");
  }else{
    nums = nums.toString();
    var f_num = parseInt(nums.charAt(0));
    var s_num = parseInt(nums.charAt(1));
    var t_num = parseInt(nums.charAt(2));
    var strR = f_num + " + " + s_num + " + " + t_num + " = ";
    document.write(strR + "<img src=" +  __IMAGES__ + "/game/nums/number_" + (f_num + s_num + t_num) + ".gif />");
  }
}

function chkResult310(nums,__IMAGES__) {
  if("" == nums || null == nums){
    document.write("-");
  }else{
    // nums = nums.toString();
    document.write("<img src=" +  __IMAGES__ + "/game/nums/310_" + nums + ".gif />");
  }
}

function chkStatus(status, lid, ISLOTTERY) {
    //状态：0投注中，1暂停投注等待开奖，2已开奖            
    switch (status) {
        case '0':{
                if (ISLOTTERY == "1") {
                    document.write("<a class='a0' href='/play/pg28Insert.aspx?LID=" + lid + "' target='_top'>已投注</a>")
                } else {
                    document.write("<a class='a0' href='/play/pg28Insert.aspx?LID=" + lid + "' target='_top'>投注</a>")

                }
                break;
            }
        case '1':{
                document.write("<a href='/play/pgMy28Detail.aspx?LID=" + lid + "' target='_top'>开奖中</a>")
                break;
            }
        case '2':{
                document.write("<a href='/play/pgMy28Detail.aspx?LID=" + lid + "' target='_top'>已开奖</a>")
                break;
            }
    }
}
function chkwin(val, lid) {
    if (val != '0') {
        document.write("<a class='a0' href='/play/pg28Result.aspx?LID=" + lid + "' target='_top' title='查看中奖人名单'>" + val + " </a>");
    }else {
        document.write("0");
    }
}

    function transStr(str) {
        str = str.toString()
        var begin = "";
        var after = "";
        var l;
        var str2 = "";
        if (str.indexOf(".") > 0) {
            begin = str.substring(0, str.indexOf("."));
            after = str.substring(str.indexOf("."), str.length);
        }else {
            begin = str;
        }
        l = begin.length / 3;
        if (l > 1) {
            for (var i = 0; i < l; ) {
                str2 = "," + begin.substring(begin.length - 3, begin.length) + str2;
                begin = begin.substring(0, begin.length - 3);
                l = begin.length / 3;
            }
            if (after.length < 3) {
                str2 = begin + str2 + after;
            } else {
                str2 = begin + str2 + after
            }
            return str2.substring(1);
        }else {
            if (after.length < 3) {
                return str;
            } else {
                return str;
            }
        }
    }

    function SGMoney(Sm, Gm) {
        if (Sm == null || Sm == 0) {
            document.write("-");
        }else {
            var val = Gm - Sm;
            if (val >= 0) {
                val = transStr(val);
                document.write("<span style='color:red'>" + val + "</span><img src='/img/pub/egg.gif'/>");
            }else {
                val = transStr(Math.abs(val));
                document.write("<span style='color:#1B5E00'>-" + val + "</span><img src='/img/pub/egg.gif'/>");
            }
        }
    }