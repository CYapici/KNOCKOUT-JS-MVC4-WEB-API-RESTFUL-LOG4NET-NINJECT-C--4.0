$(function() {
    $("a.delete").live('click', function () {
        var id = $(this).data('customer-id');

        $.ajax({
            url: "/api/customers/" + id,
            type: 'DELETE',
            cache: false,
            statusCode: {
                200: function(data) {
                    viewModel.customers.remove(
                        function (customers) {
                            return customers.ID == data.ID;
                        }
                    );
                }
            }
        });

        return false;
    });
});