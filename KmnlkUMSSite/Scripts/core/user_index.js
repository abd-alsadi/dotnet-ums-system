var tag = "user_index";
var tableName = "dataTable";
var table = null;
var maxNumberPerPage = 10;
var countSelectedRows = 0;
var pageNum = 1;
var listPageCount = 0;
var urlObject = new Object();
var currentObject = new Object();
urlObject.All = urlAPI + "User/GetUsers";

jQuery(document).ready(function ($) {

    var actions = '<div class="dropdown" style="text-align:center;"> ' +
        '<button class="btn btn-secondary dropdown-toggle btn-sm" type= "button" id= "actionsRow" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" >'  + getResourceValue("resUMSActionOptionsTitle", lang) +'</button >' +
        '<div class="dropdown-menu" aria-labelledby="actionsRow">' +
        ' <button class="dropdown-item btn-sm" type="button">' + getResourceValue("resUMSActionOptionsDetailsTitle", lang) +'</button>' +
        '<button class="dropdown-item btn-sm" type="button">' + getResourceValue("resUMSActionOptionsEditTitle", lang) +'</button>' +
        ' <button class="dropdown-item btn-sm" type="button">' + getResourceValue("resUMSActionOptionsDeleteTitle", lang) +'</button>' +
        ' </div >' +
        '</div >';

    var actionbar = '<div class="btn-group"  style="height:40px; display: list-item; padding-left:5px; padding-right:5px;" role= "group">' +
        '<button id="btn_new" type= "button" style="background-color:#e9ecef; margin:10px;" class="btn float-left" data-toggle="modal" data-target="#newItemModal" >' + getResourceValue("resUMSNewButtonTitle", lang) + '</button> ';

    var pagging = '<nav aria-label="Page navigation" class="float-right" style="padding:5px; "> ' +
        '<ul class="pagination justify-content-center"> ' +
        '   <li class="page-item"><a style="color:black" class="page-link" href="' + '#' + '">' + getResourceValue("resUMSPaggingFirstTitle", lang) + '</a></li> ' +
        '   <li class="page-item"><a style="color:black" class="page-link" href="' + '#' + '">' + getResourceValue("resUMSPaggingPrivTitle", lang) +'</a></li> ' +
        '   <li id="paggingnumber" style="color:black" class="page-item"><a class="page-link">1/2</a></li> ' +
        '   <li class="page-item"><a style="color:black" class="page-link" href="' + '#' + '">' + getResourceValue("resUMSPaggingNextTitle", lang) +'</a></li> ' +
        '  <li class="page-item"><a style="color:black" class="page-link" href="' + '#' + '">' + getResourceValue("resUMSPaggingLastTitle", lang)+'</a></li> ' +
        ' </ul> ' +
        '  </nav> ';

    actionbar += pagging;
    actionbar += '</div >';


    table = init(tableName, actionbar);
    $('#dataTable_filter').css('display','none'); // hide search input
    globalSearch(table);
    loadData(table, parent, actions);

    



});

// functions ....
function loadData(table, parent, actions) {
    var element = parent.getElementById('loading');
    showWaitLoading(element, true);
    $('#contentPage').css("display", "none");
    setTimeout(function () {
        KmnlkGET(urlObject.All, function (result, status, xhr) {
            if (result != null && result.code == 200) {
                if (result.data != null) {
                    listPageCount = result.data.length;
                    for (var index = 0; index < result.data.length; index++) {
                        if (index >= maxNumberPerPage) { break; }
                        var item = result.data[index];
                        var blocked = "";
                        if (item.fldBlocked == 1) {
                            blocked ='<input type="checkbox" style="width:20px; height:20px; text-align:center;" class="form-control" checked disabled/>';
                        } else {
                            blocked = '<input type="checkbox" style="width:20px; height:20px; text-align:center;" class="form-control" disabled/>'
                        }
                        table.row.add([
                            '<input class="item_list_checkbox" type="checkbox" id="item_list_' + index+'" onchange="changeCheckBox(\'item_list_' + index + '\')" style="width:20px; height:20px; text-align:center;" class="form-control" />',
                            item.fldName,
                            item.fldPassword,
                            item.fldDefaultPositionUid,
                            item.fldNote,
                            item.fldLastLogin,
                            blocked,
                            actions

                        ]).draw(false);
                    }
                }
                showWaitLoading(element, false);
                $('#contentPage').css("display", "");
            } else {
                showWaitLoading(element, false);
                $('#contentPage').css("display", "");
            }
        }, function (xhr, status, error) {
            showWaitLoading(element, false);
            $('#contentPage').css("display", "");
            showErrorMessage(parent.getElementById("divMessageError"), parent.getElementById("messageError"), error, true);
        });

    }, 500);
}


function globalSearch(table) {
    var item = parent.getElementById('navbarSearch');
    var doSearch = parent.getElementById('navbarDoSearch');
    if (doSearch != null && doSearch != undefined) {
        $(doSearch).on('click', function () {
            if (item != null && item != undefined) {
                var value = item.value;
                table.search(value).draw(); //pass whatever you want here
            }
        });
    }

}

function init(tableName, actionbar) {

    // Initialize Datatables
    // $.fn.dataTable.ext.classes.sPageButton = 'button button-primary'; // Change Pagination Button Class


    var table = $('#' + tableName).DataTable({
        ordering: true,
        "pagingType": "simple",
        "paging": false,
        "dom": '<"toolbar">frtip',
        "language": {
            "decimal": "",
            "emptyTable": getResourceValue("resUMSPaggingNotFoundDataAvariable",lang),
            "info": "Showing _START_ to _END_ of _TOTAL_ entries",
            "infoEmpty": "Showing 0 to 0 of 0 entries",
            "infoFiltered": "(filtered from _MAX_ total entries)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Show _MENU_ entries",
            "loadingRecords": "Loading...",
            "processing": "Processing...",
            "search": "Search:",
            "zeroRecords": getResourceValue("resUMSPaggingNotFoundDataMatched", lang),
            "paginate": {
                "first": "First",
                "last": "Last",
                "next": "Next",
                "previous": "Previous"
            },
            "aria": {
                "sortAscending": ": activate to sort column ascending",
                "sortDescending": ": activate to sort column descending"
            }
        }

    });



    $("div.toolbar").html(actionbar);


    // Setup - add a text input to each header cell
    var len = $('#' + tableName + ' .filters td').length;
    $('#' + tableName + ' .filters td').each(function (colIdx) {
        if (colIdx != 0 && colIdx != len - 1) {
            var title = $('#' + tableName + ' thead th').eq($(this).index()).text();
            $(this).html('<input type="text" class="filter" placeholder="' + getResourceValue("resUMSTableColumnSearch", lang) + ' ' + title + '" title="' + getResourceValue("resUMSTableColumnSearch", lang) + ' ' + title + '" style="text-align:center; width:100%;" class="form-control" onchange="searchInput(' + colIdx + ')" />');
        }
    });

    return table;
}
function searchInput(index) {
    debugger
    var value = $('#' + tableName + ' .filters td input')[index].value;
    table.column(index).search(value).draw();
}
function changeCheckBoxAll() {
    var value = $('#checkboxall').prop('checked');
    if (value == true) {
        countSelectedRows = 0;
    }
    $('.item_list_checkbox').each(function (index) {
        $(this).prop('checked', value);
        if (value == true) {
            countSelectedRows++;
        } else {
            countSelectedRows--;
        }

    });
}
function changeCheckBox(id) {
    var value = $('#'+id).prop('checked');
        if (value == true) {
            countSelectedRows++;
        } else {
            countSelectedRows--;
        }
}
