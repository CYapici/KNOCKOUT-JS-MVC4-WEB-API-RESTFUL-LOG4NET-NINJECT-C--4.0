$(document).ready(function () {

$(function () {
    $("a.select").live('click', function () {
 
        var id = $(this).data('customer-id');
      
        $.ajax({
            url: "/api/customers/" + id,
            type: 'GET',
            cache: false,
            statusCode: {
                200: function (data) {
                    var name = document.getElementById("customername");
                    name.value = data.Name;
                    var funds = document.getElementById("moneyamount");
                    funds.value = data.Money;
                    var id = document.getElementById("id");
                    id.value = data.ID;
                }
            }
        });

        return false;
    });
});



});
