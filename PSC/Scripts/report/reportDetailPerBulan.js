$(document).ready(function () {
    $("#fromMonth").val(getCurrentMonth());
    $("#toMonth").val(getCurrentMonth());
    $("#fromYear").val(getCurrentYear());
    $("#toYear").val(getCurrentYear());
});
function getCurrentYear() {
    var curDate = new Date();
    return curDate.getFullYear();
}
function getCurrentMonth() {
    var currDate = new Date();
    return ("0" + (currDate.getMonth() + 1)).slice(-2)
}
function PrintLaporan() {
    $("#attn").show();
    var result = $("#tblReport");
    result.jqprint();
    $("#attn").hide();
}