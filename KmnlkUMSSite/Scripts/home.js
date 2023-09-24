var contentID = "";
var lang = "0";
var urlAPI = "http://localhost:65172/";

jQuery(document).ready(function ($) {
  
    initLang();
    loadCss();
    generateResources();

    $("#navbarSearch").attr("placeholder", getResourceValue("resUMSGeneralSearchTitle", lang));
});

function loadCss() {
    var link = document.createElement("link");
    link.type = "text/css";
    link.rel = "stylesheet";
    if (lang == "0") {
        link.href = "Content/theme/css/sb-admin.css";
    } else {
        link.href = "Content/theme/css/sb-admin-ar.css";
    }

    document.head.appendChild(link);
    setTimeout(function () {
        $('#page-top').css("display", "");
    },700);

}

function initLang() {
    var la = getCookie("lang");
    if (la == "") {
        setCookie("lang", lang, 7);
    } else {
        lang = la;
    }

    if (lang == "0") {
        $('#itemLang').text("عربي");
    } else {
        $('#itemLang').text("En");
    }
}

function changeLang() {
    if (lang == "0") {
        lang = "1";
    } else {
        lang = "0";
    }   
    setCookie("lang", lang, 7);
    location.reload();
}

function KmnlkGET(url, success, error) {
    $.ajax(url, {
        type: 'GET',
        beforeSend: function (req) {
        },
        crossDomain: true,
        dataType: 'json',
        async: true,
        success: success,
        error: error
    });
}
function KmnlkPOST(url, data, success, error) {
    $.ajax(url, {
        type: 'POST',
        success: success,
        error: error,
        data: data,
    });
}

function getCookie(key) {
    var name = key + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}
function checkCookie(key) {
    var val = getCookie(key);
    if (val != "") {
        return true;
    } else {
        return false;
    }
}
function setCookie(key, value, exdays) {
    var d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    var expires = "expires=" + d.toUTCString();
    document.cookie = key + "=" + value + ";" + expires + ";path=/";
}

function generateResources() {
    $('span[resourceID]').each(function (index) {
        debugger
        var key = $(this).attr("resourceID");
        if (key != undefined && key != "") {
            var value = getResourceValue(key, lang);
            $(this).text(value);
        }
    });
}