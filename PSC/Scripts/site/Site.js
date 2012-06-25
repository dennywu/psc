$(function () {
    // Setup drop down menu
    $('.dropdown-toggle').dropdown();

    // Fix input element click problem
    $('.dropdown input, .dropdown label').click(function (e) {
        e.stopPropagation();
    });
    $(document).ready(function () {
        $('.pix_diapo').diapo();
    });
});