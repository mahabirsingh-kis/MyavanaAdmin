function onRenderProductType(data, type, row, meta) {
    var tr = '<a href="/Products/CreateProductCategory/' + row.ProductTypeId + '" Title="Edit Category" ><i class="fa fa-pencil" aria-hidden="true"></i></a>';
    tr += '<a Title="Delete Category" onclick="deleteConfirmProductType(this)" data-code="' + row.ProductTypeId + '"><i class="fa fa-trash" aria-hidden="true"></i></a>';
    return tr;
}


function deleteConfirmProductType(event) {
    var value = $(event).attr('data-code');

    $('#confirmModalHeader').text('Delete');
    $('#confirmModalText').text('Are you sure you want to delete?');
    $('#confirmMethod').removeAttr('onclick');
    $('#confirmMethod').text('Delete');
    $('#confirmModal').modal('show');
    $("#confirmMethod").prop("onclick", null).off("click");
    $("#confirmMethod").click(function () {
        DeleteProductType(value);
    });
}

function DeleteProductType(productTypeId) {
    var productTypeEntity = {
        Id: productTypeId
    }
    $('.preloader').css('display', 'block');
    $.ajax({
        type: "POST",
        url: "/Products/DeleteProductCategory",
        data: productTypeEntity,
        success: function (response) {
            if (response === "1") {
                $('#successMessage').text("Product Category deleted successfully !");
                $('.alert-success').css("display", "block");
                $('.alert-success').delay(3000).fadeOut();
                $('#confirmModal').modal('hide');
                setTimeout(function () { window.location.href = '/Products/ProductsCategory'; }, 2000);
            }
            $('.preloader').css('display', 'none');
        },
        error: function (response) {

        },
        complete: function () {

        }
    });
}


function onRenderHair(data, type, row, meta) {
    var tr = "";
    if (row.IsHair == true) {
        tr = '<i class="fa fa-check-circle green-color" ></i>';
        return tr;
    }
    return tr;
}

function onRenderRegimen(data, type, row, meta) {
    var tr = "";
    if (row.IsRegimen == true) {
        tr = '<i class="fa fa-check-circle green-color" ></i>';
        return tr;
    }
    return tr;
}