var len;
var sum;
var maxnum = 100000000;//最大投注金额
var myMoney = 20000000;//我有的金额
var issue  ='12322'
var ishave ='0'
var everEgg =1000;

function ver(n){
	n = n + "";
	re=/(\d{1,3})(?=(\d{3})+(?:$|\.))/g    
	return n.replace(re,"$1,")    
}

function showMy310Get(i){
    var result = new Array(0,3,1);
    if (game_result == result[i]) {
      document.write(ver(GMONEYSUM));
    }
}

function setRate(re){
	var sum = result0 + result1 + result2;
	var rate = 0;
	switch(re){
	case 0:
		result0 = (0 == result0)? 1:result0;
	  	rate = sum / result0;
	  	break;
	case 1:
	  	result1 = (0 == result1)? 1:result1;
	  	rate = sum / result1;
	  	break;
	case 2:
	    result2 = (0 == result2)? 1:result2;
	  	rate = sum / result2;
	  	break;
	default:
	  	break;
	}
	document.write(rate.toFixed(2));
}

function chclick(idval){
    if(issue=='3131'){
       if (document.getElementById("CI"+idval).checked == true){
            document.getElementById(idval).value = 1;
        }else{
            document.getElementById(idval).value = 0;
        }
    }else{
        if (document.getElementById("CI"+idval).checked == true){
            document.getElementById(idval).value = ver(everEgg);
        }else{
            document.getElementById(idval).value = 0;
        }
    }
    setNums();
}

function setNums(id){
    var regex=/^[1-9]\d{0,}$/;
    var val;
    len = document.getElementsByName("SMONEY").length;
    sum = 0;
    for (i=0;i<parseInt(len);i++){
        var sMoney = document.getElementsByName("SMONEY")[i];
        val = sMoney.value.replace(/,/gi,"");
        if(regex.test(val)&&(document.getElementsByName("checkboxd")[i].disabled==false)){
            document.getElementsByName("checkboxd")[i].checked = true;
            sum = parseInt(sum)+parseInt(val);
        }else if (document.getElementsByName("checkboxd")[i].disabled==false){
            document.getElementsByName("checkboxd")[i].checked = false;
            document.getElementsByName("SMONEY")[i].value = "";
        }
    }
    if (sum>myMoney){
        alert("您的余额不足！");
        // if (id) {
        //     document.getElementsByName("SMONEY")[id].value = "";
        // };
        return false;
    }
    if(sum>maxnum){
       alert("对不起，总投注金额不能超过投注上限！");
        // if (id) {
        //     document.getElementsByName("SMONEY")[id].value = "";
        // };
       return false;
    }
    for (i=0;i<parseInt(len);i++){
        var sMoney = document.getElementsByName("SMONEY")[i];
        val = sMoney.value.replace(/,/gi,"");
        sMoney.value=ver(val);
    }
    document.getElementById("SMONEYSUM").value = ver(sum);
    return true;
}

function chgsubmit(){
    var t =0;
    var regex=/^[1-9]\d{0,}$/;
    len = document.getElementsByName("SMONEY").length;
    sum = 0;
    var sms = "" ;
    var cis = "";
    for(i=0;i<len;i++){
        if (document.getElementsByName("checkboxd")[i].checked==true){
            t = t+1
            smval = document.getElementsByName("SMONEY")[i].value.replace(/,/gi,"");                                        
            if(!regex.test(smval)){
                alert("请确认您的投注金额！");
                return false;
            }
        }else{
            smval = 0;
        }
        sum = parseInt(sum)+parseInt(smval);
    }
    if(sum>maxnum){
      alert("对不起，总投注金额不能超过投注上限！");
      return false;
    }
    if(issue=='3131'&&t>1){
       alert("只能选择单或双中的一种！");
       return false;
    }
    if(issue=='3131'&&ishave=="1"){
       alert("对不起，该期为平安夜特殊期，你已经投注过，不允许再进行投注！");
       return false;
    }
    if(issue=='3131'&&sum>1){
       alert("该期为平安夜特殊期，只需投1个金蛋！");
       return false;
    }
    document.getElementById("SMONEYSUM").value = ver(sum);
    if (parseInt(sum)>parseInt(myMoney)){
        alert("您的余额不足！");
        return false;            
    }
    else if (parseInt(sum)==0){
        alert("请先投注！");
        return false;
    }else if (window.confirm("确认您投注？将扣除您"+ver(sum)+"个金蛋！")){
        var result = "";
        for (loop = 0 ; loop < len ; loop++){
            var checki = document.getElementsByName("checkboxd")[loop];
            if(checki.disabled){
                result += loop + ":" + 0 + ",";
            }else{
                var smoney = document.getElementsByName("SMONEY")[loop].value.replace(/,/gi,"");
                smoney = ("" == smoney)? 0:smoney;
                result += loop + ":" + smoney + ",";
            }
        }
        result += "3:" + sum;  //总数
        document.getElementById("ALLSMONEY").value=result;
        var form =document.getElementById("sub_form");
        form.submit();
        return true;
    }else{
        return false;
    }
}

$(document).ready(
	function (){
		$("input[name='checkboxd']")
		.each(function(i){
			$(this).click(function(){
			if($(this).attr("checked")){
				$(this).parent().next("td").children("input").val(ver(everEgg));
			}else{
				$(this).parent().next("td").children("input").val("");}
			})
		});

		$("input[name='Add']")
		.each(function(i){
			$(this).click(function(){
				var peilv=$(this).val();
				var txt=$(this).parent().prev("td").children("input");
				if(!txt.attr("readonly")){
	                var  txt_value=txt.val().replace(/,/gi,"");
					if(!txt_value){return;}
					var new_value=Math.floor(txt_value*peilv);
                    txt.val(ver(new_value+""));
                    if (!setNums()) {
                        txt.val(ver(txt_value+""));
                    }
			    }
			})
		});
	}
);




