var PASSENGER = {};
PASSENGER.Maskapai = [];
PASSENGER.Gate = {};

$(document).ready(function () {
    $("#btnSelectPassenger").click(selectPassanger);
});

function selectPassanger() {
    try {
        getMaskapai();
        getGate();
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
    console.log(PASSENGER);
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

function errorMessage(msg) {
    $("#error").append("<div class='alert alert-block alert-error span7'>" +
                              "<a class='close' data-dismiss='alert' href='#'>×</a>" +
                              "<h4 class='alert-heading'>Warning!</h4>" + msg +
                            "</div>");
    $(".alert").fadeOut(8000);
}