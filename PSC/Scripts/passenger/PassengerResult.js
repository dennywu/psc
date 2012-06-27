function showResult(data){
    $("#transactionPassengerContain").hide();
    $("#pagecontainer").load("/Scripts/passenger/result.html");
    setTimeout(function () {
        setResult(data);
    }, 500);
}
function setResult(data) {
    $("#resultamount").text("Rp. " + data.Amount);
    $("#resulttanggal").text(data.Tanggal);
    $("#resultmaskapai").text(data.Maskapai);
    $("#resultjenispenerbangan").text(data.JenisPenerbangan);
}