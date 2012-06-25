function getDay() {
    var day = new Date().getDay();
    return day;
}
function getDateByWeek(week) {
    
    var curr = new Date(); // get current date
    var first = curr.getDate() - curr.getDay(); // First day is the day of the month - the day of the week
    var last = first + 6; // last day is the first day + 6

    var firstday = new Date(curr.setDate(first));
    var lastday = new Date(curr.setDate(last));
    
    return firstday.getDate() + " "+ firstday.getMonth().ConvertToIndonesiaMonth() +" - " + lastday.getDate() + " " + lastday.getMonth().ConvertToIndonesiaMonth();
}
function getMonth() {
    var month = new Date().getMonth();
    return month;
}
function getYear() {
    var year = new Date().getFullYear();
    return year;
}

Number.prototype.ConvertToIndonesiaDay = function () {
    var days = ["Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", ""];
    var day = this;
    if(this < 0) {
        days = days.reverse();
        day = (day * -1);
    }
    return days[day];
}
Number.prototype.ConvertToIndonesiaMonth = function () {
    var months = new Array("Januari",
    "Februari", "Maret", "April",
    "Mei", "Juni", "Juli",
    "Agustus", "September",
    "Oktober", "November",
    "Desember");

    return months[this];
}
function getMonday(d) {
    var day = d.getDay(),
      diff = d.getDate() - day + (day == 0 ? -6 : 1); // adjust when day is sunday
    return new Date(d.setDate(diff));
}
function getDate() {
    var date = new Date().getDate();
    return date;
}
String.prototype.toDefaultFormatDate = function () {
    var dateFormated = new Date(parseInt(this.replace(/\/Date\((-?\d+)\)\//, '$1')));
    var day = dateFormated.getDate();
    var month = dateFormated.getMonth();
    var year = dateFormated.getFullYear();
    return day + " " + month.ConvertToIndonesiaMonth() + " " + year;
}

String.prototype.toDate = function () {
    return new Date(parseInt(this.replace(/\/Date\((-?\d+)\)\//, '$1')));
}