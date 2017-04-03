/**
 * 百宝阁
 * Author: Yunsd
 * Date:  2009-11-12
 */
var userCash,annJson,Itemjson;
//显示指定id的公告
function Showann(id){		
			var id = Number(id);			
			$("#ann").html("");
			$('<h3></h3>')
				.appendTo("#ann");
			$('<p></p>')
				.html( annJson[id].news)
				.appendTo("#ann");
			$('<p></p>')
				.html(annJson[id].time)
				.css('text-align','right')
				.css('color','#aaa')
				.appendTo("#ann");
			if (id >= annJson.length-1) {$("#next").hide()} else {$("#next").val(id+1);$("#next").show()};
			if (id == 0) {$("#per").hide()} else {$("#per").val(id-1);$("#per").show()};
}
//获取用户元宝
function Showcash(){
		$("#cash").html("<img src='images/load.gif'>");
		$("#free").html("<img src='images/load.gif'>");
		$.getJSON("get.aspx","act=userCash&time="+new Date(),function(json){
		if (json.error!=undefined) {
		var error = eval(json.error);
		if (error[0].err == 1) {self.location.href = "error.htm";return false}
		}
		userCash = eval(json.userCash);
		//alert(userCash[0].cash);
		$("#cash").html(userCash[0].cash);
		$("#free").html(userCash[0].free);
		}); 
}
//获取公告数组
function getAnn(){
		$(".nav_right a").removeClass("act");
		$("#annshow").addClass("act");
		$("#right_col>div").hide();
		
		$("#anndiv").show();
		$("#right_load").show();
		$("#anndiv").html("");
		$.getJSON("get.aspx","act=ann",function(json){
		if (json.error!=undefined) {
		var error = eval(json.error);
		if (error[0].err == 1) {self.location.href = "error.htm";return false}
		}
		annJson = eval(json.ann);
		$('<div id="ann"></div><p id="page"><button value="" id="per" onclick="Showann(this.value)">上一页</button> <button value="" id="next" onclick="Showann(this.value)">下一页</button></p>')
		.prependTo("#anndiv");
		Showann(0);
		$("#right_load").hide();
	}); 
}
//获取物品栏数据
function getBag(){
		$(".nav_right a").removeClass("act");
		$("#myitem").addClass("act");
		$("#right_col>div").hide();
		$("#right_load").show();
		$("#itembag").show();
		$.getJSON("get.aspx","act=mybag&time="+new Date(),function(json){
		if (json.error!=undefined) {
		var error = eval(json.error);
		if (error[0].err == 1) {self.location.href = "error.htm";return false}
		}
		var mybag = eval(json.mybag);
		$("#bagall").html(mybag[0].all);
		$("#bagnow").html(mybag[0].now);
		$("#right_load").hide('fast');
	}); 
}
//显示帮助
function showHelp(){
		$(".nav_right a").removeClass("act");
		$(".nav_left a").removeClass("act");
		$("#showhelp").addClass("act");
		$("#help").show();
		helpmain("help01")
}
//获取帮助内容
function helpmain(id){
		for (var i=1; i<5;i++ )
		{
			$("#help0"+i).attr("src","images/help0"+i+".gif");
		}
		$("#"+id).attr("src","images/"+id+"_o.gif");
		$.ajax({
			url: id+".html",
			dataType: 'html',
			error: function(){
				$(".helpmain").html('Error loading HTML document');
			},
			success: function(html){
				$(".helpmain").html(html);
		  }
		}); 
}
//关闭帮助
function closehelp(){
		$("#help").hide();
}
//获取购买记录
function getBuylog(){
		$(".nav_right a").removeClass("act");
		$("#mybuy").addClass("act");
		$("#right_col>div").hide();
		$("#right_load").show();
		$("#mybuylog").show();
		$("#buyloglist").html("");
		$.getJSON("get.aspx","act=mybuylog",function(json){
		if (json.error!=undefined) {
		var error = eval(json.error);
		if (error[0].err == 1) {self.location.href = "error.htm";return false}
		}
		var myBuylog = eval(json.Buylog);
		$(myBuylog).each(function(i){
			$('<tr></tr>')
				.html( "<td style=\"text-align:left;padding-left:8px\">"+myBuylog[i].name+"</td><td>"+myBuylog[i].num+"</td><td>"+myBuylog[i].cash+"</td>")
				.appendTo("#buyloglist");
		}); 
		$("#right_load").hide('fast');
	}); 
}
//获取物品列表
function GetItme(type,page){
	$(".nav_left a").removeClass("act");
	$("#showitem"+type).addClass("act");
	$("#table-item").html("");
	$("#left_load").show();
	$.getJSON("get.aspx","act=item&type="+type+"&page="+page,function(date){
		if (date.error!=undefined) {
		var error = eval(date.error);
		if (error[0].err == 1) {self.location.href = "error.htm";return false}
		}
		Itemjson = eval(date.item);
		$(Itemjson).each(function(i){
			$('<tr></tr>')
				.html( "<td><img height=\"32\" border=\"0\" align=\"absMiddle\" width=\"32\" style=\"cursor:pointer;\"onclick=\"buyItem("+i+")\" src=\""+Itemjson[i].pic+"\"/></td><td><a href=\"#\"  onclick=\"buyItem("+i+");return false\">"+Itemjson[i].name+"</a></td><td><strong>"+Itemjson[i].jg+"</strong></td><td class=\"cell-align-l\">"+Itemjson[i].info+"</td>")
				.appendTo("#table-item");
		}); 
		var jsonpage = eval(date.pages);
		var pages = new showPages('pages');
		pages.argName = type;
		pages.page = page;
		pages.pageCount = jsonpage[0].pagenum;
		pages.printHtml(1);
		$("#left_load").hide('fast');
	}); 	
}
//选择物品详细信息
function buyItem(i){
	$("#right_col>div").hide();
	$(".nav_right a").removeClass("act");

	if (Itemjson[i].type==3&Itemjson[i].jg<=0)
	{
		$("#buy_info_background").show();
		$("#DivShuxIn").show();
	    $("#Itemid").val(Itemjson[i].id);
	    $("#Span1").html(Itemjson[i].name);
	    $("#Span2").html(Itemjson[i].info);
	    $("#ItemImgUrl")[0].src="Images/Item/"+Itemjson[i].id+"_b.gif";
	    view_money();
	}
	else
	{
	    $("#itemform").show();
	    $("#itemname").html(Itemjson[i].name);
	    $("#itemyjg").html(Itemjson[i].yjg);
	    $("#itemjg").html(Itemjson[i].jg);
	    $("#iteminfo").html(Itemjson[i].info);
	    $("#itemid").val(Itemjson[i].id);
	    $("#itemje").val(Itemjson[i].jg);
	    $("#itemnum").val(1);
	    $("#itemPrice").html(Itemjson[i].jg);
	    $("#itempic").html("<img height=\"60\" border=\"0\" align=\"absMiddle\" width=\"60\" src=\"Images/Item/"+Itemjson[i].id+"_b.gif\"/>");
	}
}

//提交购买信息
function getForm() {          
        //获取表单中域的值  
        var itemid = $('input[name=itemid]');  
        var itemnum = $('select[name=itemnum]');  
        var itemje = $('input[name=itemje]');  
        //合并发送参数
        var data = 'itemid=' + itemid.val() + '&itemnum=' + itemnum.val() + '&itemje=' 
        + itemje.val();  
        //显示预加载动画 
        $('#loading').hide();  
        //ajax提交表单 
        $.ajax({  
            //后台处理数据的路径
            url: "getform.aspx",   
            //所使用的方法  
            type: "GET",  
            //发送给后台的参数           
            data: data,
			dataType: 'json',
            //取消缓存 
            cache: false,  
            //成功后的回调函数
            success: function (json) {
                //根据后台返回的1或0判断其成功与否
				buytitle = eval(json.goumai);
                if (buytitle[0].state==1) {
					//重新获取用户元宝数据
					Showcash();
                    //隐藏表单 
                    $('#itemform').fadeOut('fast');                    
                    //显示成功后的信息
                    $('.done').fadeIn('fast');  
					$('.done').html(buytitle[0].title)
                } else alert(buytitle[0].title);    
				$("#loading").hide('fast');
            }         
        });  
 }

//初始化
$(function(){
    $("#buy_info_background").hide();
    $("#DivShuxIn").hide();
    $('#option1').click(function(){view_money();return false;});  
    $('#option2').click(function(){view_money();return false;});  
    $('#option3').click(function(){view_money();return false;});  
    $('#option4').click(function(){view_money();return false;});  
    $('#Okprice').click(function(){item_buy();return false;});  
    $('#Closeprice').click(function(){CloseForm();return false;});  

  getAnn();
  Showcash();
  GetItme(1,1);
  //绑定事件
  $("a").bind("focus",function(){if(this.blur)this.blur();});

  $("#showitem1").click(function(){GetItme(1,1);closehelp();return false;});
  $("#showitem2").click(function(){GetItme(2,1);closehelp();return false;});
  $("#showitem3").click(function(){GetItme(3,1);closehelp();return false;});
  $("#annshow").click(function(){getAnn();closehelp();return false;});
  $("#myitem").click(function(){getBag();closehelp();return false;});
  $("#mybuy").click(function(){getBuylog();closehelp();return false;});
  $("#showhelp").click(function(){showHelp();return false;});
  $(".helpnav>img").click(function(){helpmain(this.id);return false;});
  $('#submit').click(function(){getForm();return false;});  

  
  $("#itemnum").change(function(){
	  var itemje = $("#itemjg").text() * $("#itemnum").val()
	  $("#itemje").val(itemje);
	  $("#itemPrice").html(itemje);
	});
});




//提交购买信息
function getOkForm() {          
        //获取表单中域的值  
        //合并发送参数
        var data = 'type=3&itemid=' + $("#Itemid").val() + '&itemje=' + $("#total_price").val() + '&option1=' + $("#option1").attr("value").split(":")[0]+ '&option2=' + $("#option2").attr("value").split(":")[0]+ '&option3=' + $("#option3").attr("value").split(":")[0]+ '&option4=' + $("#option4").attr("value").split(":")[0];  
        //显示预加载动画 
        $('#loading').hide();  
        //ajax提交表单 
        $.ajax({  
            //后台处理数据的路径
            url: "getform.aspx",   
            //所使用的方法  
            type: "GET",  
            //发送给后台的参数           
            data: data,
			dataType: 'json',
            //取消缓存 
            cache: false,  
            //成功后的回调函数
            success: function (json) {
                //根据后台返回的1或0判断其成功与否
				buytitle = eval(json.goumai);
                if (buytitle[0].state==1) {
					//重新获取用户元宝数据
					Showcash();
					alert(buytitle[0].title);  
                    $("#DivShuxIn").hide();
                    $("#buy_info_background").hide();
                } else alert(buytitle[0].title);    
				$("#loading").hide('fast');
            }         
        });  
 }

function CloseForm() { 
    $("#DivShuxIn").hide();
    $("#buy_info_background").hide();
}
function view_money(){ 
var option1_price= parseInt($("#option1").attr("value").split(":")[1]);
var option2_price= parseInt($("#option2").attr("value").split(":")[1]);
var option3_price= parseInt($("#option3").attr("value").split(":")[1]);
var option4_price= parseInt($("#option4").attr("value").split(":")[1]);

var total_price = option1_price + option2_price + option3_price + option4_price;
$("#total_price").attr("value",total_price);
}
function item_buy()
{
    if (confirm(get_selected_item_text()))
    {
        getOkForm();
        //document.getElementById('BuyBtn').innerHTML = "";
        //document.form1.submit();
    }
}

function get_selected_item_text() { 
var temp = [];

var option1= document.getElementById('option1').value.split(":");

if (parseInt(option1[1]) > 0){
var text = [option1[2], " : ", option1[1], " 元宝"].join("");
temp.push(text);
}

var option2= document.getElementById('option2').value.split(":");

if (parseInt(option2[1]) > 0){
var text = [option2[2], " : ", option2[1], " 元宝"].join("");
temp.push(text);
}

var option3= document.getElementById('option3').value.split(":");

if (parseInt(option3[1]) > 0){
var text = [option3[2], " : ", option3[1], " 元宝"].join("");
temp.push(text);
}

var option4= document.getElementById('option4').value.split(":");

if (parseInt(option4[1]) > 0){
var text = [option4[2], " : ", option4[1], " 元宝"].join("");
temp.push(text);
}

var msg = "";

msg += "万圣骷髅(男) \r\n\r\n\r\n";
msg += temp.join("\r\n");
msg += "\r\n\r\n";
msg += "--------------------------------   ";
msg += "\r\n\r\n";
msg += "结算总金额 : " + document.getElementById('total_price').value + " 元宝 \t";
msg += "\r\n\r\n";
msg += "确定要购买吗？";
return msg ;

}