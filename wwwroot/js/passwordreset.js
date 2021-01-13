$(document).ready(function () {
    if (window.location.href.indexOf("?") > -1) {
        $("#content2").show();
        $("#content1").hide();
    } else {
        $("#content2").hide();
        $("#content1").show();
    }
});

$("#sendEmailBtn").click(function () {
    var objSend = {
        "strEmail": $("#emailAddress").val()
    };

    var apiUrl = "http://psl-app-vm3/TaxRevenueUserAPI/api/Users/PostForgotPassword";
    apiCaller(apiUrl, 'POST', objSend, successFunc1);
});

$("#btnChangePassword").click(function () {
    var newPassword = $("#newPassword").val();
    var confirmPassword = $("#confirmPassword").val();

    if (newPassword !== confirmPassword) {
        $("#newPassword").val("");
        $("#confirmPassword").val("");

        return toastr.info("Password does not match, please try again");
    }

    var objToSend = {
        "newPassword": $("#newPassword").val(),
        "confirmPassword": $("#newPassword").val(),
        "resetToken": ""
    };

    var url = "http://psl-app-vm3/TaxRevenueUserAPI/api/Users/PostResetUserPassword";
    apiCaller(url, "POST", objToSend, successFunc2)
});

var successFunc1 = function (response) {
    toastr.success("Check your email for a link to reset your password. If it doesn't appear within a few minutes, check your spam folder.");
};

var successFunc2 = function () {
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

            if (error.responseText.trim() == "")
                return toastr.error("Network error occured, please check your connection and try again!");

            toastr.error(error.responseText);
        }
    });
};

