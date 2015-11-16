$(function () {


    
    function Reset() {
        form.reset();
    }

    document.getElementById("resetBtn").onclick = function () {
        var name = document.getElementById("customername");
        name.value = "";
        var funds = document.getElementById("moneyamount");
        funds.value = "";
        var id = document.getElementById("id");
        id.value = -10;
    }
    var form = $('#newCustomerForm');
    document.getElementById("sendBtn").onclick=function () {
        var form = $(this);
     

        var customer = { ID: $('#id').val(), Name: $('#customername').val(), Money: $('#moneyamount').val() };
        var json = JSON.stringify(customer);

      
            $.ajax({
                url: '/api/customers',
                cache: false,
                type: 'POST',
                data: json,
                contentType: 'application/json; charset=utf-8',
                statusCode: {
                    201 /*Created*/: function (data) {
                        viewModel.customers.push(data);
                    },

                    200 /*Created*/: function (data) {
                        $.get('/api/customers', function (data) {

                            //  Web API call.
                            viewModel.customers(data);
                        });
                    }


                }
                ,
                error: function (jqXHR, textStatus, errorThrown) {
                   
                }
            });
        
      



        return false;
    } ;
 

});