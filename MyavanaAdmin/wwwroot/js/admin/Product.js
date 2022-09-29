var hairType = [];
var hairChallenges = [];
var productIndicators = [];
var productTags = [];
var productClassification = [];

function onRender(data, type, row, meta) {
    //var tr = '<div style="display:flex"><div><span>' + row.ProductLink + '</span></div><div style="margin-left: 15px;"><a href="/Products/CreateProduct/' + row.guid + '" Title="Edit Product" ><i class="fa fa-pencil" aria-hidden="true"></i></a> <a Title="Delete Product" onclick="deleteConfirmProduct(this)" data-code="' + row.guid + '"><i class="fa fa-trash" aria-hidden="true"></i></a></div></div>'
    //var tr = '<span>"' + row.ProductLink + '"</span>'
    var tr = '<a href="/Products/CreateProduct/' + row.guid + '" Title="Edit Product" ><i class="fa fa-pencil" aria-hidden="true"></i></a>';
    tr += '<a Title="Delete Product" onclick="deleteConfirmProduct(this)" data-code="' + row.guid + '"><i class="fa fa-trash" aria-hidden="true"></i></a>';
    return tr;
}

function seachText() {
    $('#ProductList').DataTable().search('The body shop').draw();

    
}
function onRenderImage(data, type, row, meta) {
    return "<a href='" + data + "' target='_blank'><img src='" + data + "' style='width:100px;height:auto;' /></a>";
}

function onCreatedOnRenderHairType(data, type, row, meta) {
    var td = '<td>';
    data.forEach(function (attachments, i) {
        var html = '';
        td += '<span>';
        if (attachments.value != null) {
            html += '(' + attachments.value + ')';
        }

        td += '' + attachments.description + ', ' + html;
        td += "</span>"

    });
    td += '</td>';
    return td;
}
function onCreatedOnRenderHairChallenge(data, type, row, meta) {
    var td = '<td>';
    data.forEach(function (attachments, i) {
        var html = '';
        td += '<span>';
        if (attachments.value != null) {
            html += '(' + attachments.value + ')';
        }

        td += '' + attachments.description + ', ' + html;
        td += "</span>";

    });
    td += '</td>';
    return td;
}
function onCreatedOnRenderProductIndicator(data, type, row, meta) {
    var td = '<td>';
    data.forEach(function (attachments, i) {
        var html = '';
        td += '<span>';
        if (attachments.value != null) {
            html += '(' + attachments.value + ')';
        }

        td += '' + attachments.description + ', ' + html;
        td += "</span>";

    });
    td += '</td>';
    return td;
}
function onCreatedOnRenderProductTags(data, type, row, meta) {
    var td = '<td>';
    data.forEach(function (attachments, i) {
        var html = '';
        td += '<span>';
        if (attachments.value != null) {
            html += '(' + attachments.value + ')';
        }

        td += '' + attachments.description + ', ' + html;
        td += "</span>";

    });
    td += '</td>';
    return td;
}
function onCreatedOnRenderProductClassification(data, type, row, meta) {
    var td = '<td>';
    data.forEach(function (attachments, i) {
        var html = '';
        td += '<span>';
        if (attachments.value != null) {
            html += '(' + attachments.value + ')';
        }

        td += '' + attachments.description + ', ' + html;
        td += "</span>";

    });
    td += '</td>';
    return td;
}

function deleteConfirmProduct(event) {
    var value = $(event).attr('data-code');

    $('#confirmModalHeader').text('Delete');
    $('#confirmModalText').text('Are you sure you want to delete?');
    $('#confirmMethod').removeAttr('onclick');
    $('#confirmMethod').text('Delete');
    $('#confirmModal').modal('show');
    $("#confirmMethod").prop("onclick", null).off("click");
    $("#confirmMethod").click(function () {
        DeleteProduct(value);
    });
}

function DeleteProduct(guid) {
    var productsEntity = {
        guid: guid
    }
    $('.preloader').css('display', 'block');
    $.ajax({
        type: "POST",
        url: "/Products/DeleteProduct",
        data: productsEntity,
        success: function (response) {
            if (response === "1") {
                $('#successMessage').text("Product deleted successfully !");
                $('.alert-success').css("display", "block");
                $('.alert-success').delay(3000).fadeOut();
                $('#confirmModal').modal('hide');
                setTimeout(function () { window.location.href = '/Products/Products'; }, 2000);
            }
            $('.preloader').css('display', 'none');
        },
        error: function (response) {

        },
        complete: function () {

        }
    });
}


$('#btnImageClick').click(function () {
    $('#productImage').click();
});

$('#productImage').change(function (event) {
    var filename = event.target.files[0].name;
    if (filename != null || filename != undefined) {
        //$('#selectedImage').css('display', 'block');
        $('#txtImageName').text('');
        $('#txtImageName').text(filename);
    }
});

var fileModel = new FormData();
function SaveProduct() {
    var onlyNumbers = /^[0-9\s]*$/;
    if ($('#productType').val() == "" || $('#txtProductName').val().trim() == "" || $('#txtActualName').val().trim() == "" ||
        $('#txtBrandName').val().trim() == "" || $('#hairType').val().length == 0 || $('#txtImageName').text().trim() == "" ||
        $('#txtIngredients').val().trim() == "" || $('#txtProductDetails').val().trim() == "" || $('#txtProductLink').val().trim() == "" ||
        $('#txtActualPrice').val().trim().trim() == "" || $('#txtDecimalPrice').val().trim() == "" || $('#productIndicators').val().length == 0 ||
        $('#productTags').val().length == 0 || $('#productClassification').val().length == 0) {
        $('#failureMessage').text("Fields can't be empty!");
        $('.alert-danger').css("display", "block");
        $('.alert-danger').delay(3000).fadeOut();
        return false;
    }
    //if (! /((([A-Za-z]{3,9}:(?:\/\/)?)(?:[-;:&=\+\$,\w]+@)?[A-Za-z0-9.-]+|(?:www.|[-;:&=\+\$,\w]+@)[A-Za-z0-9.-]+)((?:\/[\+~%\/.\w-_]*)?\??(?:[-\+=&;%@.\w_]*)#?(?:[\w]*))?)/.test($('#txtImageName').val())) {
    //    $('#failureMessage').text("Wrong image Url");
    //    $('.alert-danger').css("display", "block");
    //    $('.alert-danger').delay(3000).fadeOut();
    //    return false;
    //}
    if (! /((([A-Za-z]{3,9}:(?:\/\/)?)(?:[-;:&=\+\$,\w]+@)?[A-Za-z0-9.-]+|(?:www.|[-;:&=\+\$,\w]+@)[A-Za-z0-9.-]+)((?:\/[\+~%\/.\w-_]*)?\??(?:[-\+=&;%@.\w_]*)#?(?:[\w]*))?)/.test($('#txtProductLink').val())) {
        $('#failureMessage').text("Wrong image Url");
        $('.alert-danger').css("display", "block");
        $('.alert-danger').delay(3000).fadeOut();
        return false;
    }
    if (!onlyNumbers.test($('#txtActualPrice').val().trim())) {
        $('#failureMessage').text("Enter valid amount");
        $('.alert-danger').css("display", "block");
        $('.alert-danger').delay(3000).fadeOut();
        return false;
    }
    if (!onlyNumbers.test($('#txtDecimalPrice').val().trim())) {
        $('#failureMessage').text("Enter valid amount");
        $('.alert-danger').css("display", "block");
        $('.alert-danger').delay(3000).fadeOut();
        return false;
    }

    $('#hairType option:selected').each(function (i, sel) {
        var hairTypeList = {};
        hairTypeList.HairTypeId = $(this).val();
        hairTypeList.Description = $(this).text();
        hairType.push(hairTypeList);
    });

    $('#hairChallenges option:selected').each(function (i, sel) {
        var hairChallengesList = {};
        hairChallengesList.HairChallengeId = $(this).val();
        hairChallengesList.Description = $(this).text();
        hairChallenges.push(hairChallengesList);
    });

    $('#productIndicators option:selected').each(function (i, sel) {
        var productIndicatorsList = {};
        productIndicatorsList.ProductIndicatorId = $(this).val();
        productIndicatorsList.Description = $(this).text();
        productIndicators.push(productIndicatorsList);
    });

    $('#productTags option:selected').each(function (i, sel) {
        var productTagsList = {};
        productTagsList.ProductTagsId = $(this).val();
        productTagsList.Description = $(this).text();
        productTags.push(productTagsList);
    });

    $('#productClassification option:selected').each(function (i, sel) {
        var productClassificationList = {};
        productClassificationList.ProductClassificationId = $(this).val();
        productClassificationList.Description = $(this).text();
        productClassification.push(productClassificationList);
    });

    var file = $('#productImage').get(0).files[0];
    fileModel.append('guid', $('#productid').val());
    fileModel.append('ProductTypesId', $('#productType').val());
    fileModel.append('ProductName', $("#txtProductName").val().trim());
    fileModel.append('BrandName', $("#txtBrandName").val().trim());
    fileModel.append('ActualName', $("#txtActualName").val().trim());
    fileModel.append('TypeFor', JSON.stringify(hairType));
    //fileModel.append('ImageName', $("#txtImageName").val().trim());
    fileModel.append('Ingredients', $("#txtIngredients").val().trim());
    fileModel.append('ProductDetails', $("#txtProductDetails").val().trim());
    fileModel.append('ProductLink', $("#txtProductLink").val().trim());
    fileModel.append('Price', $('#txtActualPrice').val().trim() + "." + $('#txtDecimalPrice').val().trim());
    fileModel.append('HairChallenges', JSON.stringify(hairChallenges));
    fileModel.append('ProductIndicator', JSON.stringify(productIndicators));
    fileModel.append('ProductTags', JSON.stringify(productTags));
    fileModel.append('ProductClassification', JSON.stringify(productClassification));

    if (file != null || file != undefined) {
        fileModel.append('File', file);
    } else {
        fileModel.append('ImageName', $("#image").val())
    }
    
    $('.preloader').css('display', 'block');
    $.ajax({
        type: "POST",
        url: "/Products/CreateProduct",
        data: fileModel,
        processData: false,
        contentType: false,
        success: function (response) {
            var actualPrice = response.price;
            if (response == "1") {
                $('#successMessage').text("Product saved/updated successfully !");
                $('.alert-success').css("display", "block");
                $('.alert-success').delay(3000).fadeOut();
                setTimeout(function () { window.location.href = '/Products/Products'; }, 3000);
            }
            else {
                $('#failureMessage').text("Oops something goes wrong !");
                $('.alert-danger').css("display", "block");
                $('.alert-danger').delay(3000).fadeOut();
            }
            $('.preloader').css('display', 'none');
        },
    });
}

function onRenderProductType(data, type, row, meta) {
    var tr = '<a href="/Products/CreateProductType/' + row.Id + '" Title="Edit Product" ><i class="fa fa-pencil" aria-hidden="true"></i></a>';
    tr += '<a Title="Delete Product" onclick="deleteConfirmProductType(this)" data-code="' + row.Id + '"><i class="fa fa-trash" aria-hidden="true"></i></a>';
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
        url: "/Products/DeleteProductType",
        data: productTypeEntity,
        success: function (response) {
            if (response === "1") {
                $('#successMessage').text("Product deleted successfully !");
                $('.alert-success').css("display", "block");
                $('.alert-success').delay(3000).fadeOut();
                $('#confirmModal').modal('hide');
                setTimeout(function () { window.location.href = '/Products/ProductsType'; }, 2000);
            }
            $('.preloader').css('display', 'none');
        },
        error: function (response) {

        },
        complete: function () {

        }
    });
}

function SaveProductType() {
    if ($('#txtProductName').val() == "") {
        $('#failureMessage').text("Fields can't be empty!");
        $('.alert-danger').css("display", "block");
        $('.alert-danger').delay(3000).fadeOut();
        return false;
    }

    var productTypeEntity = {
        Id: $('#productTypeId').val(),
        ProductName: $('#txtProductName').val()
    }
    $('.preloader').css('display', 'block');
    $.ajax({
        type: "POST",
        url: "/Products/CreateProductType",
        data: productTypeEntity,
        success: function (response) {
            if (response == "1") {
                $('#successMessage').text("Product saved/updated successfully !");
                $('.alert-success').css("display", "block");
                $('.alert-success').delay(3000).fadeOut();
                setTimeout(function () { window.location.href = '/Products/ProductsType'; }, 3000);
            }
            else {
                $('#failureMessage').text("Oops something goes wrong !");
                $('.alert-danger').css("display", "block");
                $('.alert-danger').delay(3000).fadeOut();
            }
            $('.preloader').css('display', 'none');
        },
    });
}

$(document).ready(function () {
    $('#excelDownloadChange').on('click', function (e) {
        $("#productsTableToDownload").table2excel({
            exclude: ".noExport",
            name: "producttExcel",
            filename: "product",
        });
    });
});

var fileModel = new FormData();
function UploadSelectedExcelsheet() {
    fileModel = new FormData();
    $('#excelUpload').click();
};

function changeImage() {

    var excelUpload = $('#excelUpload').get(0).files[0];
    var validExtensions = ['xlsx', 'xlsm', 'xlsb', 'xltx', 'xltm', 'xls', 'xlt', 'csv']; //array of valid extensions
    var fileName = excelUpload.name;
    var fileNameExt = fileName.substr(fileName.lastIndexOf('.') + 1);
    if ($.inArray(fileNameExt, validExtensions) == -1) {
        $('#failureMessage').text("Please select an excel file !");
        $('.alert-danger').css("display", "block");
        $('.alert-danger').delay(3000).fadeOut();
        return false;
    }
    fileModel.append('file', excelUpload);
    $('.preloader').css('display', 'block');
    $.ajax({
        type: "POST",
        url: "/Products/UploadExcelsheet",
        contentType: false,
        processData: false,
        data: fileModel,
        success: function (result) {
            $('.preloader').css('display', 'none');
            if (result != "0" && result != "1") {
                $('#failureMessage').text(result);
                $('.alert-danger').css("display", "block");
                $('.alert-danger').delay(3000).fadeOut();
                $("#excelUpload")[0].value = '';
                return false;
            }
            else if (result == "1") {
                window.location.reload();
            }
            else {
                $('#failureMessage').text("Something goes wrong !!");
                $('.alert-danger').css("display", "block");
                $('.alert-danger').delay(3000).fadeOut();
                return false;
            }

        },
        error: {
        }
    });
}

$('#search').on('keyup', function () {
    debugger;
    $('#ProductList').DataTable().column(3)
        .search($('#search').val())
        .draw();
    //FilterProducts();
});

$('#search').on('keyup', function () {
    FilterProducts();
});

function FilterProducts()
{
    debugger;
    productListing = [];
    if (($('#search').val()) !== '') {
        productListing.push("searchtext/" + $('#search').val());
    }

    //var searchText = $('#search').val();
    $('#ProductList').DataTable().search(productListing).draw();
}

