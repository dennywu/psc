function selectPassanger() {
    try {
        getMaskapai();
        getGate();
        initTransactionPassenger();
    } catch (ex) {
        errorMessage(ex);
    }
}
function getMaskapai() {
    if ($(".maskapai:checked").length == 0)
        throw "Silahkan pilih maskapai penerbangan.";
    var maskapaiLength = 0;
    for (var i = 0; i < $(".maskapai:checked").length; i++) {
        $.ajax({
            type: 'GET',
            url: '/Maskapai/GetById?id=' + $(".maskapai:checked")[i].value,
            dataType: 'json',
            success: function (data) {
                PASSENGER.Maskapai[maskapaiLength] = {};
                PASSENGER.Maskapai[maskapaiLength].Id = data.Id;
                PASSENGER.Maskapai[maskapaiLength].Name = data.Name;
                PASSENGER.Maskapai[maskapaiLength].JenisId = data.JenisId;
                PASSENGER.Maskapai[maskapaiLength].Amount = data.Amount;
                maskapaiLength++;
            }
        });
    }
}
function getGate() {
    var gateid = $("#gate").val();
    if (gateid == 0)
        throw "Silahkan pilih gate.";
    $.ajax({
        type: 'GET',
        url: '/Gate/GetById?id=' + gateid,
        dataType: 'json',
        success: function (data) {
            PASSENGER.Gate.Id = data.Id;
            PASSENGER.Gate.Name = data.Name;
        }
    });
}