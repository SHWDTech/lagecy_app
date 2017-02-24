function ge(a){return document.getElementById(a)}
function SetDisplayValue(b,a){var c=ge(b);if(c){if(c.style){c.style.display=a}}}
function ShowDiv(a){SetDisplayValue(a,"block")}
function ChangeDiv(b){var a=ge(b);if(a==null){return}a.style.display=a.style.display=="none"?"":"none"}
function ChangeImgSrc(f,c,e,b){var a=ge(f);if(a==null){return}var d=ge(c);if(d){if(a.style.display=="none"){d.src=e}else{d.src=b}d.parentNode.blur()}}
function extend(a) {
    if (document.getElementById(a + "second").style.display == "none") {
        document.getElementById(a + "first").style.display = "none";
        document.getElementById(a + "second").style.display = ""
    }
    else { document.getElementById(a + "first").style.display = "";document.getElementById(a + "second").style.display = "none"; }
    document.getElementById(a + "child").style.display = document.getElementById(a + "child").style.display == "none" ? "" : "none";
}
//function plusclick(a){document.getElementById(a+"child").style.display="";
//document.getElementById(a+"first").style.display="none";
//document.getElementById(a+"second").style.display=""}
//function reduceclick(a){if(document.getElementById(a+"child")){if(document.getElementById(a+"child").innerHTML!=""){document.getElementById(a+"child").style.display="none"}}if(document.getElementById(a+"first")){document.getElementById(a+"first").style.display=""}if(document.getElementById(a+"second")){document.getElementById(a+"second").style.display="none"}}
// 
function AddRowEx(divid,divindex,divcount){try{if(!ge(divindex)||!ge(divcount)||ge(divindex).value==ge(divcount).value){return}var curID=parseInt(ge(divindex).value);var copyID=curID+1;var curTrID=divid+"_"+curID.toString();var copyTrID=divid+"_"+copyID.toString();var copyHtml="";
	if($("#"+copyTrID).html()!=null){$("#"+copyTrID).show()}else{var cloneObj=$("#"+curTrID).clone();
	if(curID==1){if(cloneObj.find("td:first")!=null){cloneObj.find("td:first").remove()}
	if(cloneObj.find("span:first")!=null){cloneObj.find("span:first").remove()}var logicalTd=$("#hidden_logical_"+divid).html();if(logicalTd!=""){var reg=/{key}/g;logicalTd=logicalTd.replace(reg,copyTrID);cloneObj=cloneObj.prepend(logicalTd)}}copyHtml=$("<div></div>").append(cloneObj).html();var reg1=eval("/"+curTrID+"/g");copyHtml=copyHtml.replace(reg1,divid+"_"+copyID.toString());if(copyHtml!=""){$("#"+curTrID).after(copyHtml)}}var objvalue=ge(copyTrID+"_value1");if(objvalue!=null){objvalue.value=""}objvalue=ge(copyTrID+"_value2");if(objvalue!=null){objvalue.value=""}ge(divindex).value=copyID.toString();var obj=ge(copyTrID+"_sel");if(!obj){obj=ge(copyTrID+"_sel1")}if(obj){obj.options[copyID-1].selected=true;obj.onchange()}}catch(e){}} 
function DeleteRowSaveID(d,a,h,b){try{if(ge(a).value=="1"){return}else{var j=parseInt(ge(a).value);var g=d+"_"+j;var c=ge(g+"_value1");if(c!=null){c.value=""}c=ge(g+"_value2");if(c!=null){c.value=""}SetDisplayValue(g,"none");j--;ge(a).value=j;if(ge(b)){ge(b).value=ge(b).value.replace(g+",","")}}}catch(f){return}} 
var swichSearchMode=-1;
function getSearchTabActiveID(){try{return getElementsByClassName("active","li","searchmenu")[0].id}catch(a){return""}}
function SubmitTab(e,m,h,j,c){
var l=ge("searchmenu").getElementsByTagName("Li");
var f=l.length;
var k=getSearchTabActiveID();
if(("1_"+c)==k){return}
for(var a=0;a<f;a++)
{l[a].className=""}
var b=ge("1_"+c);
b.className="active";
var d="&dbCatalog="+escape(e)+"&dbPrefix="+m;d+="&tab="+h+"&zone="+j;
if(c){if(typeof(c)=="number"){swichSearchMode=c}
if(h.toLowerCase()=="normol"){swichSearchMode=-1}}
try{CommonDeal("gettab","../request/GettabHandler.ashx",d,tabresult,"");
if(h=="normol"&&ge("GroupViewTitle")){ge("GroupViewTitle").innerHTML='<span class="red01">3.'+message.groupSelect+"</span><font>("+message.moreGroup+")</font>"}
else{if(ge("GroupViewTitle")){ge("GroupViewTitle").innerHTML='<span class="red01">'+message.groupSelect+"</span><font>("+message.moreGroup+")</font>"}}var n=document.getElementsByName("ddSubmit");
if(n){for(var a=0;a<n.length;a++){if(n[a]){n[a].style.display="none"}}}}catch(g){}}
var SubmitFlg=0;
function SubmitTabNoDiv(e,m,j,k,b)
{SubmitFlg=1;var l=ge("searchmenu").getElementsByTagName("Li");
var f=l.length;
for(var a=0;a<f;a++){l[a].className=""}ge("1_"+b).className="active";
var c="&dbCatalog="+escape(e)+"&dbPrefix="+m;c+="&tab="+j+"&zone="+k;
if(b){if(typeof(b)=="number"){swichSearchMode=b}if(j.toLowerCase()=="normol"){swichSearchMode=-1}}try{CommonDealNoDiv("gettab","../request/GettabHandler.ashx",c,tabresult,"");var g=ge("GroupViewTitle");if(g){var d='<span class="red01">';if(j=="normol"){d=d+"3."}g.innerHTML=d+message.groupSelect+"</span><font>("+message.moreGroup+")</font>"}var n=document.getElementsByName("ddSubmit");if(n){for(var a=0;a<n.length;a++){if(n[a]){n[a].style.display="none"}}}}catch(h){}}
var LanguageEncode="GB";
function KeywordVal(a){if(!a){return false}a=a.replace(/(^\s*)|(\s*$)/g,"");if(a.replace(/\s+/g,"")==""){return false}var c=[];switch(LanguageEncode){case"GB":c=new Array("点击输入","输入作者","全部子库","全部学科","全部资源","全部研究层次","输入基金","输入检索词","输入作者单位","输入主办单位名称","请输入学位授予单位名称","输入出版单位名称","输入会议名称","输入年鉴名称","输入报纸名称","输入作者姓名","输入主编或作者","输入单位","输入期刊名称","请输入","输入来源名称","输入网络出版投稿人名称","输入辑刊名称","请选择省份","请选择城市","请选择县");break;case"BG":c=new Array("點擊輸入","輸入作者","全部子库","全部学科","全部资源","全部研究层次","全部子庫","全部學科","全部資源","全部研究層次","輸入基金","輸入檢索詞","輸入做者單蒞","輸入主辦單位名稱","請輸入學位授予單位名稱","輸入出版單位名稱","輸入會議名稱","輸入年鑒名稱","輸入報紙名稱","輸入作者姓名","輸入主編或作者","輸入單位","輸入期刊名稱","請輸入","輸入來源名稱","輸入網絡出版投稿人名稱","輸入輯刊名稱","請選擇省份","請選擇城市","請選擇縣");break;case"EN":c=new Array("Click to input","Input author","全部子库","全部学科","全部资源","全部研究层次","Input fund","Input terms","Input author affiliation","Input sponsor","Input degree grantor","Input publisher","Input conference name","Input yearbook title","Input newspaper title","Input author's name","Input chief editor or author","Input institution","Input journal title","Input","Please input","Input source name","Input contributor");break}for(var b=0;b<c.length;b++){if(a.indexOf(c[b])>=0){return false}}return true}function SignVal(f,c,d){if(c=="sign"){d=(d)?d:((window.event)?window.event:"");var a=d.keyCode?d.keyCode:d.which;if((a==39&&document.all)||a==34||a==59){alert(message.noInputWord1);if(d.keyCode){d.keyCode=0}}}else{if(c=="value"){if(window.clipboardData){var b=clipboardData.getData("text");if(b.indexOf("'")!=-1||b.indexOf('"')!=-1||b.indexOf(";")!=-1||b.indexOf("\\")!=-1||b.indexOf("/")!=-1){alert(message.noInputWord2);return false}}}else{if(c=="input"){var b=f.value;if(b.indexOf("'")!=-1||b.indexOf('"')!=-1||b.indexOf(";")!=-1||b.indexOf("<")!=-1||b.indexOf(">")!=-1||b.indexOf("\\")!=-1||b.indexOf("/")!=-1){return false}}}}return true}
function SignVal(f,c,d){if(c=="sign"){d=(d)?d:((window.event)?window.event:"");var a=d.keyCode?d.keyCode:d.which;if((a==39&&document.all)||a==34||a==59){alert(message.noInputWord1);if(d.keyCode){d.keyCode=0}}}else{if(c=="value"){if(window.clipboardData){var b=clipboardData.getData("text");if(b.indexOf("'")!=-1||b.indexOf('"')!=-1||b.indexOf(";")!=-1||b.indexOf("\\")!=-1||b.indexOf("/")!=-1){alert(message.noInputWord2);return false}}}else{if(c=="input"){var b=f.value;if(b.indexOf("'")!=-1||b.indexOf('"')!=-1||b.indexOf(";")!=-1||b.indexOf("<")!=-1||b.indexOf(">")!=-1||b.indexOf("\\")!=-1||b.indexOf("/")!=-1){return false}}}}return true}
function SignVal1(a) { }

function ChangeSelect() { }