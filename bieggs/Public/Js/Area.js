/*
调用：
<script language="javascript" type="text/javascript" src="/jscript/area.js"></script>
<script language="javascript" type="text/javascript">Init('<%=PROVINCE %>','<%=CITY %>');</script>
*/

CITYS=new Array();
CITYS[0]=new Array("北京","北京");
CITYS[1]=new Array("上海","上海");
CITYS[2]=new Array("天津","天津");
CITYS[3]=new Array("重庆","重庆");
CITYS[4]=new Array("河北","石家庄|邯郸|邢台|保定|张家口|承德|廊坊|唐山|秦皇岛|沧州|衡水");
CITYS[5]=new Array("山西","太原|大同|阳泉|长治|晋城|朔州|吕梁|忻州|晋中|临汾|运城");
CITYS[6]=new Array("辽宁","沈阳|大连|鞍山|抚顺|本溪|丹东|锦州|营口|阜新|辽阳|盘锦|铁岭|朝阳|葫芦岛");
CITYS[7]=new Array("吉林","长春|吉林|四平|辽源|通化|白山|松原|白城|延边");
CITYS[8]=new Array("黑龙江","哈尔滨|齐齐哈尔|牡丹江|佳木斯|大庆|绥化|鹤岗|鸡西|黑河|双鸭山|伊春|七台河|大兴安岭");
CITYS[9]=new Array("江苏","南京|镇江|苏州|南通|扬州|盐城|徐州|连云港|常州|无锡|宿迁|泰州|淮安");
CITYS[10]=new Array("浙江","杭州|宁波|温州|嘉兴|湖州|绍兴|金华|衢州|舟山|台州|丽水");
CITYS[11]=new Array("安徽","合肥|芜湖|蚌埠|马鞍山|淮北|铜陵|安庆|黄山|滁州|宿州|池州|淮南|巢湖|阜阳|六安|宣城|亳州");
CITYS[12]=new Array("福建","福州|厦门|莆田|三明|泉州|漳州|南平|龙岩|宁德");
CITYS[13]=new Array("江西","南昌|景德镇|九江|鹰潭|萍乡|新余|赣州|吉安|宜春|抚州|上饶");
CITYS[14]=new Array("山东","济南|青岛|淄博|枣庄|东营|烟台|潍坊|济宁|泰安|威海|日照|莱芜|临沂|德州|聊城|滨州|菏泽");
CITYS[15]=new Array("河南","郑州|开封|洛阳|平顶山|安阳|鹤壁|新乡|焦作|濮阳|许昌|漯河|三门峡|南阳|商丘|信阳|周口|驻马店|济源");
CITYS[16]=new Array("湖北","武汉|宜昌|荆州|襄阳|黄石|荆门|黄冈|十堰|恩施|潜江|天门|仙桃|随州|咸宁|孝感|鄂州");
CITYS[17]=new Array("湖南","长沙|常德|株洲|湘潭|衡阳|岳阳|邵阳|益阳|娄底|怀化|郴州|永州|湘西|张家界");
CITYS[18]=new Array("广东","广州|深圳|珠海|汕头|东莞|中山|佛山|韶关|江门|湛江|茂名|肇庆|惠州|梅州|汕尾|河源|阳江|清远|潮州|揭阳|云浮");
CITYS[19]=new Array("甘肃","兰州|嘉峪关|金昌|白银|天水|酒泉|张掖|武威|定西|陇南|平凉|庆阳|临夏|甘南");
CITYS[20]=new Array("陕西","西安|宝鸡|咸阳|铜川|渭南|延安|榆林|汉中|安康|商洛");
CITYS[21]=new Array("内蒙古","呼和浩特|包头|乌海|集宁|通辽|赤峰|鄂尔多斯|呼伦贝尔|阿拉善盟|哲里木盟|兴安盟|乌兰察布|锡林郭勒盟|巴彦淖尔|伊克昭盟");
CITYS[22]=new Array("广西","南宁|柳州|桂林|梧州|北海|防城港|钦州|贵港|玉林|南宁|柳州|贺州|百色|河池|来宾|崇左");
CITYS[23]=new Array("四川","成都|绵阳|德阳|自贡|攀枝花|广元|内江|乐山|南充|宜宾|广安|达州|雅安|眉山|甘孜|凉山|泸州|遂宁|巴中|资阳|阿坝");
CITYS[24]=new Array("贵州","贵阳|六盘水|遵义|安顺|铜仁|黔西南|毕节|黔东南|黔南");
CITYS[25]=new Array("云南","昆明|大理|曲靖|玉溪|昭通|楚雄|红河|文山|思茅|西双版纳|保山|德宏|丽江|怒江|迪庆|临沧");
CITYS[26]=new Array("西藏","拉萨|日喀则|山南|林芝|昌都|阿里|那曲");
CITYS[27]=new Array("海南","海口市|三亚市|三沙|五指山|琼海|文昌|万宁|定安|屯昌|澄迈|临高|儋州|东方|乐东|琼中|保亭|陵水|白沙|昌江|西沙群岛|南沙群岛|中沙群岛");
CITYS[28]=new Array("宁夏","银川|石嘴山|吴忠|固原");
CITYS[29]=new Array("青海","西宁|海东|海南|海北|黄南|玉树|果洛|海西");
CITYS[30]=new Array("新疆","乌鲁木齐|石河子|克拉玛依|伊犁|巴音郭勒|昌吉|克孜勒苏柯尔克孜|博尔塔拉|吐鲁番|哈密|喀什|和田|阿克苏");
CITYS[31]=new Array("香港","香港");
CITYS[32]=new Array("澳门","澳门");
CITYS[33]=new Array("台湾","台北|高雄|台中|台南|屏东|南投|云林|新竹|彰化|苗栗|嘉义|花莲|桃园|宜兰|基隆|台东|金门|马祖|澎湖");
CITYS[34]=new Array("海外","美国|日本|英国|法国|德国|加拿大|澳大利亚|俄罗斯|新西兰|意大利|韩国|比利时|瑞士|新加坡|墨西哥|荷兰|巴西|印度|爱尔兰|马来西亚|丹麦|南非|西班牙|葡萄牙|瑞典|其它");

document.writeln("<select name=\"PROVINCE\" id=\"PROVINCE\" onchange=\"ChangeCity(this.options[this.selectedIndex].value,'')\">");
document.writeln("<option value=\"\">=请选择=<\/option>");
document.writeln("<option value=\"北京\">北京<\/option>");
document.writeln("<option value=\"上海\">上海<\/option>");
document.writeln("<option value=\"天津\">天津<\/option>");
document.writeln("<option value=\"重庆\">重庆<\/option>");
document.writeln("<option value=\"河北\">河北<\/option>");
document.writeln("<option value=\"山西\">山西<\/option>");
document.writeln("<option value=\"辽宁\">辽宁<\/option>");
document.writeln("<option value=\"吉林\">吉林<\/option>");
document.writeln("<option value=\"黑龙江\">黑龙江<\/option>");
document.writeln("<option value=\"江苏\">江苏<\/option>");
document.writeln("<option value=\"浙江\">浙江<\/option>");
document.writeln("<option value=\"安徽\">安徽<\/option>");
document.writeln("<option value=\"福建\">福建<\/option>");
document.writeln("<option value=\"江西\">江西<\/option>");
document.writeln("<option value=\"山东\">山东<\/option>");
document.writeln("<option value=\"河南\">河南<\/option>");
document.writeln("<option value=\"湖北\">湖北<\/option>");
document.writeln("<option value=\"湖南\">湖南<\/option>");
document.writeln("<option value=\"广东\">广东<\/option>");
document.writeln("<option value=\"甘肃\">甘肃<\/option>");
document.writeln("<option value=\"陕西\">陕西<\/option>");
document.writeln("<option value=\"内蒙古\">内蒙古<\/option>");
document.writeln("<option value=\"广西\">广西<\/option>");
document.writeln("<option value=\"四川\">四川<\/option>");
document.writeln("<option value=\"贵州\">贵州<\/option>");
document.writeln("<option value=\"云南\">云南<\/option>");
document.writeln("<option value=\"西藏\">西藏<\/option>");
document.writeln("<option value=\"海南\">海南<\/option>");
document.writeln("<option value=\"宁夏\">宁夏<\/option>");
document.writeln("<option value=\"青海\">青海<\/option>");
document.writeln("<option value=\"新疆\">新疆<\/option>");
document.writeln("<option value=\"香港\">香港<\/option>");
document.writeln("<option value=\"澳门\">澳门<\/option>");
document.writeln("<option value=\"台湾\">台湾<\/option>");
document.writeln("<option value=\"海外\">海外<\/option>");
document.writeln("<\/select>");
document.writeln("<select style=\"width:80px;\" name=\"CITY\" id=\"CITY\">");
document.writeln("<option>=城市=<\/option>");
document.writeln("<\/select>")

function ChangeCity(getProvince,getCity)
{
	var getProvince=getProvince;
	var i,j,k;
	document.getElementById("CITY").length=0;	
	document.getElementById("CITY").options[document.getElementById("CITY").length]=new Option("=请选择=","");	
	for(i=0;i<CITYS.length;i++)
	{
		if(CITYS[i][0]==getProvince)
		{
			tmpCitys=CITYS[i][1].split("|")
			for(j=0;j<tmpCitys.length;j++)
			{
				document.getElementById("CITY").options[document.getElementById("CITY").length]=new Option(tmpCitys[j],tmpCitys[j]);
			}
		}
	}
	for(k=0;k<document.getElementById("CITY").options.length;k++)
	{
		if(document.getElementById("CITY").options[k].value==getCity)
		{			
			document.getElementById("CITY").options[k].selected=true;			
			break;
		}
	}	
}
function ChangeProvince(getProvince)
{
	for(pp=0;pp<document.getElementById("PROVINCE").options.length;pp++)
	{
		if(document.getElementById("PROVINCE").options[pp].value==getProvince)
		{
			document.getElementById("PROVINCE").options[pp].selected=true;
			break;
		}
	}
	ChangeCity(document.getElementById("PROVINCE").options[document.getElementById("PROVINCE").selectedIndex].value,"");
}
function Init(getProvince,getCity)
{
	ChangeProvince(getProvince);	
	ChangeCity(getProvince,getCity);	
}