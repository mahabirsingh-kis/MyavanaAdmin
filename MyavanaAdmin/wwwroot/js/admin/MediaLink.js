function SaveMediaLink() {
    var cv = $('#txtVideo').val();
    if ($('#txtVideo').val() == "" || $('#txtDescription').val() == "" || $('#txtTitle').val() == "") {
        $('#failureMessage').text("Fill atleast one field to save!");
        $('.alert-danger').css("display", "block");
        $('.alert-danger').delay(3000).fadeOut();
        return false;
    }
    var mediaLinkEntityModel = {
        Id: $('#medaiLinkId').val(),
        VideoId: $('#txtVideo').val(),
        Description: $("#txtDescription").val(),
        Title: $("#txtTitle").val()
    }

	$('.preloader').css('display', 'block');
    $.ajax({
        type: "POST",
        url: "/SocialMedia/CreateVideo",
        data: mediaLinkEntityModel,
        success: function (response) {
            if (response == "1") {
                $('#successMessage').text("Video saved/updated successfully !");
                $('.alert-success').css("display", "block");
                $('.alert-success').delay(3000).fadeOut();
                setTimeout(function () { window.location.href = '/SocialMedia/EducationalVideos'; }, 3000);
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