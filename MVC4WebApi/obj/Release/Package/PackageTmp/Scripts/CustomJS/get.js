$(function () {
    // Knockout js  model. 
    viewModel.customers([]);

    $.get('/api/customers', function (data) {

        //  Web API call.
        viewModel.customers(data);
    });
});
