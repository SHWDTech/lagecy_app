/**
 * @author ADC
 */
$(function(){	
	$(".controlCapture").bind("click",function(){ 
		execute(this,"NO"); 
	});
	$(".controlCapture2").bind("click",function(){ 
		execute2(this,"NO"); 
	});
	$(".controlUp").bind("click",function(){ 
		execute(this,"UP"); 
	});
	$(".controlUpLeft").bind("click",function(){ 
		execute(this,"UP_LEFT"); 
	});
	$(".controlUpRight").bind("click",function(){ 
		execute(this,"UP_RIGHT"); 
	});
	$(".controlDown").bind("click",function(){ 
		execute(this,"DOWN"); 
	});
	$(".controlDownLeft").bind("click",function(){ 
		execute(this,"DOWN_LEFT"); 
	});
	$(".controlDownRight").bind("click",function(){ 
		execute(this,"DOWN_RIGHT"); 
	});
	$(".controlLeft").bind("click",function(){ 
		execute(this,"LEFT"); 
	});
	$(".controlRight").bind("click",function(){ 
		execute(this,"RIGHT"); 
	});
	$(".controlZoomIn").bind("click",function(){ 
		execute(this,"IN"); 
	});
	$(".controlZoomOut").bind("click",function(){ 
		execute(this,"OUT"); 
	});
	
	$(".controlUp2").bind("click",function(){ 
		execute2(this,"UP"); 
	});
	$(".controlDown2").bind("click",function(){ 
		execute2(this,"DOWN"); 
	});
	$(".controlLeft2").bind("click",function(){ 
		execute2(this,"LEFT"); 
	});
	$(".controlRight2").bind("click",function(){ 
		execute2(this,"RIGHT"); 
	});
	$(".controlZoomIn2").bind("click",function(){ 
		execute2(this,"IN"); 
	});
	$(".controlZoomOut2").bind("click",function(){ 
		execute2(this,"OUT"); 
	});
	
	$(".controlDefault").bind("click",function(){ 
		execute(this,"DEF"); 
	});
	$(".controlDefault2").bind("click",function(){ 
		execute2(this,"DEF"); 
	});
	$(".controlSave").bind("click",function(){ 
		execute(this,"SAVE"); 
	});
	$(".controlSave2").bind("click",function(){ 
		execute2(this,"SAVE"); 
	});
});

/*
 * 设置与跳转预置位
 */
function defaultPos(button,direct)
{
	var spotNum = $(button).parent().parent().parent().attr("id");
	var devCode = "devCode=" + $("#"+spotNum + " .devCode").text();
	devCode += "&direct=" + direct;
	alert(devCode);
	
	var url;
	if(direct==="set")
		url = "set_pos.action";
	else
		url = "turn_into_pos.action";
}

/*
 * 执行ajax指令，与设备交互并返回
 */
function execute(button,order)
{
	var data = "action=1";
	data +="&devCode=" + $("#devCode").val();
	data += "&devId=" + $("#devId").val();
	data += "&order=" + order;
	
	$.ajax({ 
		url: "action/Photos.ashx", 
		data:data,cache:false,
		beforeSend:function(xhr){
			showBg();
		},
		complete:function(XHR, TS){
			closeBg();
		},
		success: function(data, textStatus)
		{
		    var json = eval("(" + data + ")");
			if(!json.success)
			{
			    alert("拍摄失败！请检查相关设备是否正常连接");
			}
			else
			{			
				$("#photo").attr("src",json.data[0].Url);;
				//将新的时间消息替换原来的
				var con_time= "拍摄时间 : " + json.data[0].Time;
				$("#photoTime").text(con_time);	
			}
		},
		error: function(data, textStatus)
		{
			alert("拍摄失败！请检查相关设备是否正常连接");
		}
   	});
}

/*
 * 执行ajax指令，与设备交互并返回
 */
function execute2(button,order)
{
	var data = "order=" + order;
	data += "&devCode=" + $("#devCode").val();
	data += "&preset=" + $("#controlPreset").val();
	
	//alert(data);
	
	$.ajax({ 
		url: "action/Photos.ashx", 
		data:data,cache:false,
		beforeSend:function(xhr){
			parent.showBg();
		},
		complete:function(XHR, TS){
			parent.closeBg();
		},
		success: function(data, textStatus)
		{
			if(data==='succ')
			{
				alert("操作成功！");
			}
			else if(data==='error')
			{
				alert("拍摄失败！请检查相关设备是否正常连接");
			}
			else
			{
				var jData = eval("("+data+")");//转换为json对象
				
				$("#photo").attr("src",jData.url);
				
				//将新的时间消息替换原来的
				var con_time= "拍摄时间 : " + jData.time;
				$("#photoTime").text(con_time);
				
				alert(jData.message);
			}
		},
		error: function(data, textStatus)
		{
			alert("拍摄失败！请检查相关设备是否正常连接");
		}
   	});
}

//显示灰色 jQuery 遮罩层
function showBg() {
    var bh = $(document).height();
    var bw = $(document).width();
    
    $("#fullbg").css({
        height:bh,
        width:bw,
        display:"block"
    });
    $("#dialog").show();
}
//关闭灰色 jQuery 遮罩
function closeBg() {
    $("#fullbg,#dialog").hide();
}
