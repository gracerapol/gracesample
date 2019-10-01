

$(document).ready(function() { 
$("#calculate").click(function() {
	var investment = ParseInt($("#investment").val());
	var rate = ParseInt($("#annual_rate").val()); 
	var years = ParseInt($("#years").val()); 
	var isValid =true;
			
	if($(":investment").val()==""){
		$("#investment").next().text("Please enter a value");
	//$("#investment").next().text("No Value"); 
	}
	else if (isNaN($("#investment").val())){
	$("#investment").next().text("Please enter a number");}
else if(investment<100}} investment>100000)
{
$("#investment").next().text("Must be an integer from 100 to 100000");	
}
	else {
			$("#investment").next().text("*");
			}
	if($(":annual_rate").val()==""){
		$("#annual_rate").next().text("Please enter a value");
	//$("#rate").next().text("No Value"); 
	}
	else if (isNaN($("#annual_rate").val())){
	$("#annual_rate").next().text("Please enter a number");}
	else if(<100}} investment>100000)
{
$("#annual_rate").next().text("Annual rate must be 1 to 10");	
}
else {
		$("#annual_rate").next().text("*");
			}
	if($(":years").val()==""){
		$("#years").next().text("Please enter a value");
	//$("#rate").next().text("No Value"); 
	}
	else if (isNaN($("#years").val())){
	$("#years").next().text("Please enter a number");}
	else {
			$("#years").next().text("*");
			}
					
if( isValid ==true){
	$("future_value").val = calculateFV(investment, rate, years);}
})
});
var calculateFV = function(investment, rate, years) {
var futureValue = investment;
    for (var i = 1; i <= years; i++ ) {
futureValue += futureValue * rate / 100;
    }
    futureValue = futureValue.toFixed(2);
return futureValue;

	}

/*"use strict";
var $ = function (id) {
    return document.getElementById(id);
}
var calculateFV = function(investment, rate, years) {
var futureValue = investment;
    for (var i = 1; i <= years; i++ ) {
futureValue += futureValue * rate / 100;
    }
    futureValue = futureValue.toFixed(2);
return futureValue;
}
var processEntries = function() {
    var investment = parseFloat( $("investment").value );
    var rate = parseFloat( $("annual_rate").value );
    var years = parseInt( $("years").value );
var isValid = true ;


if (isNaN(investment) || isNaN(rate) || isNaN(years))  {
$("investment").nextElementSibling.firstChild.nodeValue= "This is a required value";
$("annual_rate").nextElementSibling.firstChild.nodeValue= "This is a required value";

$("years").nextElementSibling.firstChild.nodeValue= "This is a required value" ;

}
else if (investment < 100 || investment > 100000) {
$("investment").nextElementSibling.firstChild.nodeValue= "Must be Integer from 100 to 100,000";
$("annual_rate").nextElementSibling.firstChild.nodeValue= "Must be a value from 1 to 12";
$("years").nextElementSibling.firstChild.nodeValue= "Must be an integer from 1 to 50";
isValid=false;
}

else if (rate < 1 ||rate> 10)
{ $("investment").nextElementSibling.firstChild.nodeValue= "Must be Integer from 100 to 100,000";
$("annual_rate").nextElementSibling.firstChild.nodeValue= "Must be a value from 1 to 12";
$("years").nextElementSibling.firstChild.nodeValue= "Must be an integer from 1 to 50";
isValid=false;
}
else if (years < 1 || years > 25)
{ 
$("investment").nextElementSibling.firstChild.nodeValue= "Must be Integer from 100 to 100,000";
$("annual_rate").nextElementSibling.firstChild.nodeValue= "Must be a value from 1 to 12";
$("years").nextElementSibling.firstChild.nodeValue= "Must be an integer from 1 to 50";
isValid=false;
}
else {
if(isValid==true)
$("future_value").value = calculateFV(investment, rate, years);
}
}


var button = document.getElementById("clear"),
  count = 0;
button.onclick = function() {
  count += 1;
	if(count==1){
	var clearValues = function () {
	$("investment").value= "";
	$("annual_rate").value= "";
	$("years").value= "";
	$("future_value").value ="";
}}
  if(count==2)
	 { 
		 var clearValues = function () {
	$("investment").nextElementSibling.firstChild.nodeValue= "";
	$("annual_rate").nextElementSibling.firstChild.nodeValue= "";
	$("years").nextElementSibling.firstChild.nodeValue= ""; 
	
} }
	  
};


window.onload = function () {
    $("calculate").onclick = processEntries;
$("clear").onclick = clearValues;
    $("investment").focus();
}*/
