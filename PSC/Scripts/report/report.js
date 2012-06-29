$(document).ready(function () {
    setDatePicker();
});
function setDatePicker() {
    var dates = $("#fromDate, #toDate").datepicker({ dateFormat: 'yy-mm-dd',
        defaultDate: "+1w",
        changeMonth: true,
        gotoCurrent: true,
        numberOfMonths: 1,
        onSelect: function (selectedDate) {
            var option = this.id == "fromDate" ? "minDate" : "maxDate",
					instance = $(this).data("datepicker"),
					date = $.datepicker.parseDate(
						instance.settings.dateFormat ||
						$.datepicker._defaults.dateFormat,
						selectedDate, instance.settings);
            dates.not(this).datepicker("option", option, date);
        }
    });
}
function PrintLaporan() {
    $("#attn").show();
    var result = $("#tblReport");
    result.jqprint();
    $("#attn").hide();
}