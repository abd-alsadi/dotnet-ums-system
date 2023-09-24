
jQuery(document).ready(function ($) {
    var parent = window.parent.document;

    var tableName = "dataTable";

    var table = init(tableName);

    $('#dataTable_wrapper .row:first').css('display','none'); // hide search input
    globalSearch(table);

    loadData(table, parent);




    // functions ....

    function loadData(table) {
        var element = parent.getElementById('loading');
        showWaitLoading(element, true);
        $('#contentPage').css("display", "none");
        setTimeout(function () {
            KmnlkGET('http://localhost:49337/api/v1/User/All', function (result, status, xhr) {
                if (result.code == 200) {
                    if (result.data != null) {
                        for (var index = 0; index < result.data.length; index++) {
                            if (index >= 10) { break; }
                            var item = result.data[index];
                            table.row.add([
                                '<input class="checkbox" type="checkbox" style="width:20px; height:20px;" class="form-control" />', item.fldName, item.fldPassword, 'asd', 'asd'
                            ]).draw(false);
                        }
                    } else {
                        // not found any data
                    }
                }
                showWaitLoading(element, false);
                $('#contentPage').css("display", "");
            }, function (xhr, status, error) {

            });

        }, 2000);


    }

    function changeCheckBoxAll() {
        debugger
        $('.checkbox').each(function (index) {
            var value = $('#checkboxall').prop('checked');
            $(this).prop('checked', value);
        });
    }

    function globalSearch(table) {

        var item = $('#navbarSearch');
        var doSearch = $('#navbarDoSearch');
        if (doSearch != null && doSearch != undefined) {
            doSearch.on('click', function () {
                if (item != null && item != undefined) {
                    table.search($(this).val()).draw(); //pass whatever you want here
                }
            });
        }

    }

    function init(tableName) {

        // Initialize Datatables
        $.fn.dataTable.ext.classes.sPageButton = 'button button-primary'; // Change Pagination Button Class


        var table = $('#' + tableName).DataTable({
            ordering: true,
            "pagingType": "simple",
            "paging": false,
            "language": {
                "decimal": "",
                "emptyTable": "No data available in table",
                "info": "Showing _START_ to _END_ of _TOTAL_ entries",
                "infoEmpty": "Showing 0 to 0 of 0 entries",
                "infoFiltered": "(filtered from _MAX_ total entries)",
                "infoPostFix": "",
                "thousands": ",",
                "lengthMenu": "Show _MENU_ entries",
                "loadingRecords": "Loading...",
                "processing": "Processing...",
                "search": "Search:",
                "zeroRecords": "No matching records found",
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

        // Setup - add a text input to each header cell
        $('#' + tableName + ' .filters td').each(function (colIdx) {
            if (colIdx != 0) {
                var title = $('#' + tableName + ' thead th').eq($(this).index()).text();
                $(this).html('<input type="text" placeholder="Search ' + title + '" style="text-align:center; width:100%;" class="form-control" />');
            }
        });


        // Apply the search
        table.columns().eq(0).each(function (colIdx) {
            if (colIdx != 0) {
                $('input[type="text"]', $('.filters td .filter')[colIdx]).on('keyup change', function () {
                    table.column(colIdx)
                        .search(this.value)
                        .draw();
                });
            }
        });


        //$('a.toggle-vis').on('click', function (e) {
        //    e.preventDefault();

        //    // Get the column API object
        //    var column = table.column($(this).attr('data-column'));

        //    // Toggle the visibility
        //    column.visible(!column.visible());
        //});

        return table;
    }



});



