var urlAPI = parent.urlAPI;
var lang = parent.lang;
var parent = window.parent.document;

jQuery(document).ready(function ($) {
    generateResources();
});



function KmnlkGET(url, success,error) {
    $.ajax(url,{
        type: 'GET',
        beforeSend: function (req) {
        },
        crossDomain: true,
        dataType: 'json',
        async:true,
        success: success,
        error: error
    });
}
function KmnlkPOST(url,data, success, error) {
    $.ajax(url,{
        type: 'POST',
        success: success,
        error: error,
        data:data,
    });
}


function showWaitLoading(control,isOk) {
    
    if (isOk == false) {
        control.style.display="none";
    }
    else {
        control.style.display = "block";
    }
}

function showErrorMessage(div,control,msg ,isOk) {
    if (isOk == false) {
        div.style.display = "none";
        control.innerText = "";
    }
    else {
        div.style.display = "block";
        control.innerText = msg;
    }
}
function generateResources() {
    $('span[resourceID]').each(function (index) {
        var key = $(this).attr("resourceID");
        if (key != undefined && key != "") {
            var value = getResourceValue(key, lang);
            $(this).text(value);
        }
    });
}