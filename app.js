"use strict";
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
{ $("investment").nextElementSibling.firstChild.nodeValue= "Must be Integer from 100 to 100,000";
$("annual_rate").nextElementSibling.firstChild.nodeValue= "Must be a value from 1 to 12";
$("years").nextElementSibling.firstChild.nodeValue= "Must be an integer from 1 to 50";
isValid=false;
}
else {
if(isValid==true)
$("future_value").value = calculateFV(investment, rate, years);
}
}

var clearValues = function () {
$("investment").value= "";
$("annual_rate").value= "";
$("years").value= "";
$("future_value").value ="";
}

window.onload = function () {
    $("calculate").onclick = processEntries;
$("clear").onclick = clearValues;
    $("investment").focus();
}
