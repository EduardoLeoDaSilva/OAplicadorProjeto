$(document).ready(function () {
    removeSeta();
});

$(window).resize(function () {
    removeSeta();
});

function removeSeta() {
    if ($(document).width() < 1080) {
        $('.slick-arrow').hide();
    } else {
        $('.slick-arrow').show();
    }
}

$('.carousel').slick({
    dots: true,
    autoplay: true,
    arrows: true
});

/* scroll suave */

var $doc = $('html, body');
$('#scrollSuave').click(function () {
    $doc.animate({
        scrollTop: $($.attr(this, 'href')).offset().top
    }, 500);
    return false;
});

var conteudo = $('html, body');
$('#scrollSuaveTop').click(function () {
    conteudo.animate({
        scrollTop: $($.attr(this, 'href')).offset().top
    }, 1200);
    return false;
});

/* script button search menu */

function showSearch() {
    $("#box-search").css("height", "120px");
    $("#imgBusca").css("cursor", "context-menu");
}

function hideSearch() {
    $("#box-search").css("height", "0%");
    $("#imgBusca").css('cursor', 'pointer');
}

function showMenu() {
    $("#box-menu").css("height", "120px");
    $("#imgBusca").css("cursor", "context-menu");
}

function hideMenu() {
    $("#box-menu").css("height", "0%");
    $("#imgBusca").css('cursor', 'pointer');
}

/* scriptmenu responsive */

var slidebar_width = 370; //slidebar width + padding size
var slide_bar = $(".side-menu-wrapper"); //slidebar
var slide_open_btn = $(".slide-menu-open"); //slidebar close btn
var slide_close_btn = $(".menu-close"); //slidebar close btn
var overlay = $(".side-menu-overlay"); //slidebar close btn
var text_search = $(".busca"); //
var search_close_btn = $(".closebtn"); //

slide_open_btn.click(function (e) {
    e.preventDefault();
    slide_bar.css({
        "left": "0px"
    }); //change to "right" for right positioned menu
    overlay.css({
        "opacity": "1",
        "width": "100%"
    });
    $(".side-menu-wrapper").fadeIn(5000);
    $(".backgroundMenu").fadeIn(500);
});

slide_close_btn.click(function (e) {
    e.preventDefault();
    slide_bar.css({
        "left": "-" + slidebar_width + "px"
    }); //change to "right" for right positioned menu
    overlay.css({
        "opacity": "0",
        "width": "0"
    });
    $(".backgroundMenu").fadeOut(500);
});

text_search.click(function (e) {
    e.preventDefault();
    slide_bar.css({
        "left": "-" + slidebar_width + "px"
    }); //change to "right" for right positioned menu
    overlay.css({
        "opacity": "0",
        "width": "0"
    });
    $("#box-search").css("height", "120px");
    $(".backgroundMenu").fadeOut(500);
});

search_close_btn.click(function (e) {
    e.preventDefault();

    slide_bar.css({
        "left": "-" + slidebar_width + "px"
    }); //change to "right" for right positioned menu

    overlay.css({
        "opacity": "0",
        "width": "0"
    });

    $("#box-search").css("height", "0%");
    $("#imgBusca").css('cursor', 'pointer');
    $(".backgroundMenu").fadeOut(500);
});

$(function () {
    $('.selecione-pagamento').click(function () {
        $('.selecione-pagamento').removeClass('active');
        $('.pagamento-selecionado').removeClass('active');
        $(this).addClass('active');
        var id = $(this).data('id');
        var content = $('.pagamento-selecionado').filter(function () {
            return $(this).data("id") == id
        });
        content.addClass('active');
    });
});