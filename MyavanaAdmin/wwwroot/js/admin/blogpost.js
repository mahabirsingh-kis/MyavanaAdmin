//$('#uploadImage').on('change', function () {
//	let fileName = $(this).val().split('\\').pop();
//	$(this).next('.custom-file-label').addClass("selected").html(fileName);
//});

var fileModel = new FormData();
$("#uploadImage").change(function () {

    fileModel = new FormData();

    var file = $("#uploadImage").get(0).files[0];
    fileModel.append("FormFile", file);
    $('#lblImage').val(file.name);
});

function SaveBlogs() {

    if ($('#headline').val().trim() == "" || $('#details').val().trim() == "" || $('#imageUrl').val().trim() == "" || $('#additionalUrl').val().trim() == "") {
        $('#failureMessage').text("Fields can't be empty!");
        $('.alert-danger').css("display", "block");
        $('.alert-danger').delay(3000).fadeOut();
        return false;
    }
    if (! /((([A-Za-z]{3,9}:(?:\/\/)?)(?:[-;:&=\+\$,\w]+@)?[A-Za-z0-9.-]+|(?:www.|[-;:&=\+\$,\w]+@)[A-Za-z0-9.-]+)((?:\/[\+~%\/.\w-_]*)?\??(?:[-\+=&;%@.\w_]*)#?(?:[\w]*))?)/.test($('#imageUrl').val())) {
        $('#failureMessage').text("Wrong image Url");
        $('.alert-danger').css("display", "block");
        $('.alert-danger').delay(3000).fadeOut();
        return false;
    }
    if (! /((([A-Za-z]{3,9}:(?:\/\/)?)(?:[-;:&=\+\$,\w]+@)?[A-Za-z0-9.-]+|(?:www.|[-;:&=\+\$,\w]+@)[A-Za-z0-9.-]+)((?:\/[\+~%\/.\w-_]*)?\??(?:[-\+=&;%@.\w_]*)#?(?:[\w]*))?)/.test($('#additionalUrl').val())) {
        $('#failureMessage').text("Wrong addition Url");
        $('.alert-danger').css("display", "block");
        $('.alert-danger').delay(3000).fadeOut();
        return false;
    }
    var blogPostModel = {
        BlogArticleId: $('#articleId').val(),
        Headline: $('#headline').val().trim(),
        Details: $("#details").val().trim(),
        ImageUrl: $("#imageUrl").val().trim(),
        Url: $("#additionalUrl").val().trim()
    }
	$('.preloader').css('display', 'block');
    $.ajax({
        type: "POST",
        url: "/Articles/CreateArticles",
        data: blogPostModel,
        success: function (response) {
            if (response == "1") {
                $('#successMessage').text("Article saved/updated successfully !");
                $('.alert-success').css("display", "block");
                $('.alert-success').delay(3000).fadeOut();
                setTimeout(function () { window.location.href = '/Articles/ViewArticles'; }, 3000);
            }
            else {
                $('#failureMessage').text("Oops something goes wrong !");
                $('.alert-danger').css("display", "block");
                $('.alert-danger').delay(3000).fadeOut();
			}

			$('.preloader').css('display', 'none');
        },
    });
};