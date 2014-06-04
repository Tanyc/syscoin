
function changeSafeCode(){
	document.getElementById('regSafeCode').src='inc/code.php?'+Math.random();
}

function changeSafeCode1(){
	document.getElementById('regSafeCode1').src='inc/code.php?'+Math.random();
}

function addToFavorite(){
	var a="http://www.aoyene.cc/";var b="遨夜网专业的体验娱乐平台";
	if(document.all){
		window.external.AddFavorite(a,b);
	}else if(window.sidebar){
		window.sidebar.addPanel(b,a,"");
	}else{
		alert("请按ctrl+d收藏遨夜网");
	}
}

function setTab(name,cursel,n){
	for(i=1;i<=n;i++){
		var menu=document.getElementById(name+i);
		var con=document.getElementById("con_"+name+"_"+i);
		menu.className=i==cursel?"current":"";
		con.style.display=i==cursel?"block":"none";
	}
}

function mdcopy(copydata)
{
	window.clipboardData.setData("Text",copydata);
    alert("ok!");
}

String.prototype.trim = function() 
{ 
return this.replace(/(^\s*)|(\s*$)/g, ""); 
}; 
String.prototype.ltrim = function() 
{ 
return this.replace(/(^\s*)/g, ""); 
}; 
String.prototype.rtrim = function() 
{ 
return this.replace(/(\s*$)/g, ""); 
}; 
function copyline(obj) {
    var str = "" + $(obj).parent().parent().find("td:eq(1)").text();
    window.clipboardData.setData("Text", str.trim());
    alert("已成功复制");
}

function latershow(t) {
	if(t>0){
		var lmsg=document.getElementById("loading_msg");
		lmsg.style.display="";
		var content=document.getElementById("content");
		content.style.display="none";
		setTimeout("showcontent();",t);
	}
}

function showcontent() {
	var lmsg=document.getElementById("loading_msg");
	lmsg.style.display="none";
	var content=document.getElementById("content");
	content.style.display="block";
}

function trueCheckAll( checkAllId , checkId , num ){
	if(num){
		for(i=1;i<num;i++){
			document.getElementById(checkId+''+i).checked=document.getElementById(checkAllId).checked;
		}
	}else{
		if(document.getElementById(checkId).checked){
			document.getElementById(checkAllId).checked=document.getElementById(checkId).checked
		}
	}
	
}
