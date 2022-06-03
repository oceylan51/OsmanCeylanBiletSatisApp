
$(".food-feature").hover(function () {
    $("#food-icon-descripton").removeClass("d-none");
})
$(".food-feature").mouseleave(function () {
    $("#food-icon-descripton").addClass("d-none");
})


$(".tv-feature").hover(function () {
    $("#tv-icon-descripton").removeClass("d-none");
})
$(".tv-feature").mouseleave(function () {
    $("#tv-icon-descripton").addClass("d-none");
})


$(".wifi-feature").hover(function () {
    $("#wifi-icon-descripton").removeClass("d-none");
})
$(".wifi-feature").mouseleave(function () {
    $("#wifi-icon-descripton").addClass("d-none");
})


$(".socket-feature").hover(function () {
    $("#socket-icon-descripton").removeClass("d-none");
})
$(".socket-feature").mouseleave(function () {
    $("#socket-icon-descripton").addClass("d-none");
})

$(".android-feature").hover(function () {
    $("#android-icon-descripton").removeClass("d-none");
})
$(".android-feature").mouseleave(function () {
    $("#android-icon-descripton").addClass("d-none");
})


$(".usb-feature").hover(function () {
    $("#usb-icon-descripton").removeClass("d-none");
})
$(".usb-feature").mouseleave(function () {
    $("#usb-icon-descripton").addClass("d-none");
})
$("#sefer-btn").click(function () {
    $(".oturma-duzeni").toggleClass("d-none");
})
$("#sefer-btn").click(function () {
    if ($("#date").val() == "") {
        $("#date-control").html("Lütfen Tarih giriniz");
    }
})
$(".koltuk").click(function () {
    var a = $(this).hasClass("bg-danger");
    console.log(a);
    if (!a) {
        var val = $(this).html()
        console.log(val);
        $("#seatNumber").attr('value', val);
        $(".koltuk").removeClass("bg-warning");
        $(this).addClass("bg-warning")
    }
})

