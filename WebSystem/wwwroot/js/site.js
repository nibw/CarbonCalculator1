// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#household').DataTable({
        ajax: {            
            url: UrlHousehold,
            type: 'GET',
            dataType: 'json',
            dataSrc: ''      
        },
        columnDefs: [
            { 'width' : '5%', 'targets':[0] },
            { 'width' : '10%', 'targets': [6] },            
        ],
        columns: [
            { data: 'householdId' },//0
            { data: 'amountPeople' },//1
            { data: 'standmeter' },//2
            { data: 'lpgConsumption' },//3
            { data: 'cityGasConsumption' },//4
            { data: 'createdDate' },//5
            {
                data: 'id',
                render: function (data, type, row, meta) {
                    return '<a class="btn btn-light" asd="qq" style="margin-right:5px;" href="/household/addhousehold/' + row.householdId + '"><i class="fa fa-pencil"></i></a>' +
                        '<a class="btn btn-light js-delete" style="margin-right:5px;" data-customer-id=' + row.householdId + '><i class="fa fa-trash"></i></a>'
                }
            },
        ],
    });
});


//$('#hoesehold').on('click', '.js-delete', function () {debugger
//    //console.log("Are you sure??");
//    var button = $(this);
//    bootbox.confirm("are you sure?", function (result) {
//        if (result) {
//            $.ajax ({
//                url: UrlDelete + button.attr('data-customer-id'),
//                method: 'DELETE',
//                success: function () {
//                    table.row(button.parents('tr')).remove().draw();
//                },
//                error: function (jqXHR, exception) {
//                    alert(exception);
//                }
//            })
//        }
//    });
//});

//function Edit() {
//    $('#test').on('click', function () {
//        alert('asdasdasd');
//    });
//}

//$(document).ready(function () {
//    $('a[asd="qq"]').on('click', function () {
//        alert('asdasdad');
//    });
//});

$(document).ready(function () {
    $('#test').on('click', function () {
        alert('oaksdj');
    });
});

