jQuery(document).ready(function ($) {
    // Initialize Datatables
    $.fn.dataTable.ext.classes.sPageButton = 'button button-primary'; // Change Pagination Button Class

    $('#dataTable').DataTable({
        "order": [[1, "asc"]],
        select: true,
    });
});


jQuery(document).ready(function ($) {
    // Initialize Datatables
    //$.fn.dataTable.ext.classes.sPageButton = 'button button-primary'; // Change Pagination Button Class

    // Disable search and ordering by default
    //$.extend($.fn.dataTable.defaults, {
    //    searching: false,
    //    ordering: false
    //});

    $('#test').DataTable({
        ajax: {
            url: '/api/myData',
            dataSrc: 'staff'
        },
        columns: [
            { data: 'id' },
            { data: 'name' },
        ],

        // options
        //paging: false,
        //scrollY: 400,
        //scrollX:711,
        //order: [[1, "asc"]],
        //or 
        //order: [["nameColoumn", "asc"]],
        pageLength: 25,
        select: true,
        
        // For this specific table we are going to enable ordering
        // (searching is still disabled)
        ordering: true,
        
        "pagingType": "simple"
    });
});

//example 

//{
//    "staff": [
//        {
//            "name": "Tiger Nixon",
//            "position": "System Architect",
//            "salary": "$320,800",
//            "start_date": "2011/04/25",
//            "office": "Edinburgh",
//            "extn": "5421"
//        },
//        ...
//    ]
//}