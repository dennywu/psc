var PASSENGER = {};
PASSENGER.Maskapai = [];
PASSENGER.Gate = {};
PASSENGER.JenisPenerbangan = {};
PASSENGER.JenisPenerbangan.Domestik = {};
PASSENGER.JenisPenerbangan.Domestik.Id = 1;
PASSENGER.JenisPenerbangan.Domestik.Name = "Domestik";
PASSENGER.JenisPenerbangan.Internasional = {};
PASSENGER.JenisPenerbangan.Internasional.Id = 2;
PASSENGER.JenisPenerbangan.Internasional.Name = "Internasional";

$(document).ready(function () {
    $("#btnSelectPassenger").click(selectPassanger);
});


function errorMessage(msg) {
    $("#error").append("<div class='alert alert-block alert-error span7 offset2'>" +
                              "<a class='close' data-dismiss='alert' href='#'>×</a>" +
                              "<h4 class='alert-heading'>Warning!</h4>" + msg +
                            "</div>");
    $(".alert").fadeOut(8000);
}