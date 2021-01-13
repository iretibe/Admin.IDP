$("#btnChangePassword").click(function () {

    var newPassword = $("#newPassword").val();
    var confirmPassword = $("#confirmPassword").val();

    if (newPassword !== confirmPassword) {
        $("#newPassword").val("");
        $("#confirmPassword").val("");

        return toastr.info("Password does not match, please try again");
    }

    var objToSend = {};
    objToSend.email = $("#emailAddress").val();
    objToSend.newPassword = $("#newPassword").val();

    var url = "http://psl-app-vm3/TaxRevenueUserAPI/api/Users/PostResetUserPassword";
    apiCaller(url, "POST", objToSend, successFunc)
});

var successFunc = function () {
    toastr.success("Password successfully changed!");
};

var apiCaller = function (url, type, data, callback) {
    $('html').showLoading();

    $.ajax({
        url: url,
        type: type,
        crossDomain: true,
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        headers: {
        },
        dataType: 'json',
        success: function (response) {
            $('html').hideLoading();
            callback(response);
        },
        statusCode: {
            204: function (response) {
                $('html').hideLoading();
            }
        },
        error: function (error) {
            $('html').hideLoading();
            toastr.error(error.statusText);
        }
    });
};