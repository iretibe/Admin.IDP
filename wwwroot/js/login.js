$("#forgotPasswordLink").click(function () {
    if (window.location.host == "localhost:5002")
        window.location.href = "https://localhost:5002/Account/PasswordReset";
    if (window.location.host == "192.168.0.68")
        window.location.href = "http://192.168.0.68/taxrevenueidp/Account/PasswordReset";
    if (window.location.host == "psl-app-vm3")
        window.location.href = "https://psl-app-vm3/taxrevenueidp/Account/PasswordReset";
    if (window.location.host == "collect.localrevenue-gh.com")
        window.location.href = "https://collect.localrevenue-gh.com/TaxRevenueIdp/Account/PasswordReset";
});