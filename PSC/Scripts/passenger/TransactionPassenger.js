function initTransactionPassenger() {
    $("#pagecontainer").empty();
    $("#pagecontainer").load("/Scripts/passenger/transaction.html");
    setTimeout(setData, 2000);
}
function setData() {
    for (var i = 0; i < PASSENGER.Maskapai.length; i++) {
        $("#maskapai").append("<option value='" + PASSENGER.Maskapai[i].Id + "'>" + PASSENGER.Maskapai[i].Name + "</option>");
    }
    $("#gate").empty().text(PASSENGER.Gate.Name);
    $("#tanggal").val(getCurrentDate());
    $("#maskapai").change(changeMaskapai);
    $("#btnBayar").click(Bayar);
}
function getCurrentDate() {
    var curr = new Date();
    var day = (curr.getDate() < 10) ? ("0" + curr.getDate()).slice(-2) : curr.getDate();
    var month = ("0" + (curr.getMonth() + 1)).slice(-2);
    var year = curr.getFullYear();
    return day + "-" + month + "-" + year;
}
function changeMaskapai() {
    clearAllField();
    var maskapaiId = $(this).val();
    var maskapai = findMaskapai(maskapaiId);
    $("#amount").val(maskapai.Amount);
    $("#jenispenerbangan").empty().text(findJenisPenerbanganById(maskapai.JenisId).Name);
}
function findMaskapai(id) {
    for (var i = 0; i < PASSENGER.Maskapai.length; i++) {
        if (PASSENGER.Maskapai[i].Id == id) {
            return PASSENGER.Maskapai[i];
        }
    }
}
function clearAllField() {
    $("#amount").val('');
    $("#jenispenerbangan").empty().text("-");
}
function clearAll() {
    $("#amount").val('');
    $("#jenispenerbangan").empty().text("-");
    $("#notransaction").val('');
    $("#maskapai").val(0);
    $("#namapassenger").val('');
    $("#flightno").val('');
}
function findJenisPenerbanganById(id) {
    if (id == 1)
        return PASSENGER.JenisPenerbangan.Domestik;
    return PASSENGER.JenisPenerbangan.Internasional;
}
function Bayar() {
    var pessanger = {};
    pessanger.TransactionNo = $("#notransaction").val();
    pessanger.Tanggal = $("#tanggal").val();
    pessanger.Maskapai = findMaskapai($("#maskapai").val()).Name;
    pessanger.JenisPenerbangan = $("#jenispenerbangan").text();
    pessanger.Amount = $("#amount").val();
    pessanger.Gate = $("#gate").text();
    pessanger.PassengerName = $("#namapassenger").val();
    pessanger.FlightNo = $("#flightno").val();
    if (pessanger.TransactionNo == "" || pessanger.Tanggal == "" || pessanger.Maskapai == "" || pessanger.JenisPenerbangan == "" || pessanger.Amount == "" || pessanger.Gate == "") {
        return errorMessage("Semua field harus diisi.");
    }

    $.ajax({
        type: 'POST',
        url: '/TransactionPassenger/Bayar',
        data: pessanger,
        dataType: 'json',
        success: function (data) {
            showResult(data);
        }
    });
}