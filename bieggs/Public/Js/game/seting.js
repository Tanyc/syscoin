//控制声音
var imgSound    = '';
var pg28sound   = ''
var player      = document.getElementById("player");
if(pg28sound==2){
   imgSound   = '<img id="imgclose" src="/bidan/bieggs/Public/Images/game/S_Close.gif" onclick="setSound(1)" align="absmiddle" style="cursor:pointer" title="打开开奖声音">&nbsp;';
}else{
   imgSound   = '<img id="imgopen" src="/bidan/bieggs/Public/Images/game/S_Open.gif" onclick="setSound(2)" align="absmiddle" style="cursor:pointer" title="关闭开奖声音">&nbsp;';
}
document.getElementById("LSound").innerHTML = imgSound;
//控制刷新
var imgReload    = '';
var pg28Reload   = ''
if(pg28Reload==2){
   imgReload   = '<img id="reloadopen" src="/bidan/bieggs/Public/Images/game/sx_c.gif" onclick="setReLoad(1)" align="absmiddle" style="cursor:pointer" title="关闭自动刷新">&nbsp;';
}else{
   imgReload   = '<img id="reloadclose" src="/bidan/bieggs/Public/Images/game/sx_h.gif" onclick="setReLoad(2)" align="absmiddle" style="cursor:pointer" title="打开自动刷新">&nbsp;';
}
document.getElementById("LReload").innerHTML = imgReload;

function setSound(issound){
  // if(true){
  //   setTimeout("GetRTime("+10+")",1000);
  //   return;
  // }
    var url = "Pg28SoundDo.aspx?issound="+issound;
    var XmlHttp;
    var request = new SigmaRequest();
    request.open("post",url,true);
    request.send();
    document.getElementById("soundshow").value=issound
    if(issound==2){
       imgSound   = '<img id="imgclose" src="/bidan/bieggs/Public/Images/game/S_Close.gif" onclick="setSound(1)" align="absmiddle" style="cursor:pointer" title="打开开奖声音">&nbsp;';
       document.getElementById("LSound").innerHTML = imgSound;
    }else{
       imgSound   = '<img id="imgopen" src="/bidan/bieggs/Public/Images/game/S_Open.gif" onclick="setSound(2)" align="absmiddle" style="cursor:pointer" title="关闭开奖声音">&nbsp;';
       document.getElementById("LSound").innerHTML = imgSound;
    }
}

function setReLoad(isreload){
    var url = "Pg28ReLoadDo.aspx?isreload="+isreload;
    var XmlHttp;

    var request = new SigmaRequest();
    request.open("post",url,true);
    request.send();
    document.getElementById("reloadshow").value=isreload
    if(isreload==2){
       imgReload   = '<img id="reloadopen" src="/bidan/bieggs/Public/Images/game/sx_c.gif" onclick="setReLoad(1)" align="absmiddle" style="cursor:pointer" title="关闭自动刷新">&nbsp;';
       document.getElementById("LReload").innerHTML = imgReload;      
    }else{
       imgReload   = '<img id="reloadclose" src="/bidan/bieggs/Public/Images/game/sx_h.gif" onclick="setReLoad(2)" align="absmiddle" style="cursor:pointer" title="打开自动刷新">&nbsp;';
       document.getElementById("LReload").innerHTML = imgReload;
    }
}

var stopSencond=80;
function GetRTime(ctime){
    var nS=ctime;  
    if(nS>0){
      //alert(document.getElementById('check_reload').checked);
      //alert(nS);
      nS = nS-1;
      stopSencond=stopSencond-1;
      if(stopSencond<0){
       document.getElementById("RemainS").innerHTML="已经停止竞猜，还有<strong style='color:#ff0000;'>"+nS+"</strong>秒开奖 ";
      }else{
            document.getElementById("RemainS").innerHTML="还有<strong style='color:#ff0000;'>"+stopSencond+"</strong>秒停止竞猜，<strong style='color:#ff0000;'>"+nS+"</strong>秒开奖 "; 
      }   
      document.getElementById("RemainTitle").innerHTML="第<strong>633133</strong>期"; 
      // if(0==0){
      // document.getElementById("RemainTitle").innerHTML="<span class='form_game'>距离第633133期开奖还有</span>";  
      // document.getElementById("RemainS").innerHTML="<span class='form_game'>"+nS+"</span><span class='form_game'>秒</span>";   
      // } 
    }else{
       document.getElementById("RemainTitle").innerHTML="<strong>第633133期</strong>";  
       if (isReload == 2){
           document.getElementById("RemainS").innerHTML= "正在开奖中请等待！";
       }else{
           document.getElementById("RemainS").innerHTML= "已开奖 <a href='pc28.aspx' style='color:red; font-size:12px;'>请刷新</a>";
       }
       nS = nS-1;
       var isReload = document.getElementById('reloadshow').value;
       if (isReload == 2){
           if(nS == -10 || nS == -15 || nS == -20 || nS == -25){
               window.location.href='pc28.aspx';
           }         
       }
          
       var isopen =document.getElementById("soundshow").value
       if(isopen!="2"){ //是否打开声音 2 ：声音关闭   其它：打开
           if(nS<=-2){
               try{
               player.controls.stop(); 
               }catch(e){}
            }else{
               try{
               player.controls.play();
               }catch(e){}
            }
       }
       //alert(nS);
    }
    setTimeout("GetRTime("+nS+")",1000);
}   
GetRTime(300);