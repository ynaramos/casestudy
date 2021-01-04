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
            window.location.reload(true);
        }
    })
}

function addVoucher(urlToSend, voucherId) {
    $.ajax({
        url: urlToSend,
        cache: false,
        type: 'GET',
        datatype: 'html',
        data: { voucherId },
        success: function (data) {
            if (data.success != null) {
                alert(data.message);
            }
            else {
                window.location.reload(true);
            }
        }
    })
}

function changeShoppingCartNotification(numberInCart) {
    $('#shoppingCartBadge').text(numberInCart);
}

function enableApplyVoucherButton() {
    $('#voucherButton').removeAttr('disabled');
}