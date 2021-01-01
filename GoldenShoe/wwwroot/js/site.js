// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function addToCart(urlToSend, prodId, sId) {
    $.ajax({
        url: urlToSend,
        type: 'GET',
        datatype: 'html',
        data: { "productId": prodId, "sizeId" : sId },
        success: function (data) {
            window.location.href = data;
            location.reload();
        }
    })
}

function changeShoppingCartNotification(numberInCart) {
    $('#shoppingCartBadge').text(numberInCart);
}