

function deleteConfirmGroup(hairType) {
    $('#confirmModalHeader').text('Delete');
    $('#confirmModalText').text('Are you sure you want to delete?');
    $('#confirmMethod').removeAttr('onclick');
    $('#confirmMethod').text('Delete');
    $('#confirmModal').modal('show');
    $("#confirmMethod").prop("onclick", null).off("click");
    $("#confirmMethod").click(function () {
        DeleteGroup(hairType);
    });
}

function DeleteGroup(hairType) {
    debugger;
    var grpModel = {
        HairType: hairType
    }
    $('.preloader').css('display', 'block');
    $.ajax({
        type: "POST",
        url: "/Groups/DeleteGroup",
        data: grpModel,
        success: function (response) {
            if (response === "1") {
                $('#successMessage').text("Group deleted successfully !");
                $('.alert-success').css("display", "block");
                $('.alert-success').delay(3000).fadeOut();
                $('#confirmModal').modal('hide');
                setTimeout(function () { window.location.href = '/Groups/GroupList'; }, 2000);
            }
            else {
                $('#failureMessage').text("Oop! something goes wrong. Please try later.");
                $('.alert-danger').css("display", "block");
                $('.alert-danger').delay(3000).fadeOut();
                return false;
            }
            $('.preloader').css('display', 'none');
        },
        error: function (response) {

        },
        complete: function () {

        }
    });
}

