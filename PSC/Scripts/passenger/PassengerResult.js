function showResult(data) {
    if (data.error == true)
        throw data.data;
    $("#transactionPassengerContain").hide();
    $("#resultContain").load("/Scripts/passenger/result.html");
    setTimeout(function () {
        setResult(data.data);
    }, 700);
}
function setResult(data) {
    $("#resultamount").text("Rp. " + data.Amount.toCurrency(2));
    $("#resulttanggal").text(data.Tanggal.toDefaultFormatDate());
    $("#resultmaskapai").text(data.Maskapai);
    $("#resultjenispenerbangan").text(data.JenisPenerbangan);
    $("#resultflightno").text(data.FlightNo);
    $("#btnReturnToTransaksi").click(backToTransaction);
    $("#btnPrint").click(printResult);
}
function backToTransaction() {
    $("#resultContain").empty();
    clearAll();
    $("#transactionPassengerContain").show();
}
function printResult() {
    var result = $("#resultContainer");
    result.jqprint();
}