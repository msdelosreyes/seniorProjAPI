var GetLogin = function () {
    var loginid = $('#txtLoginID').val();
    var transactionkey = $('#txtTransactionKey').val();
    var loginUrl = "/api/values/GetLogin";
    var loginData = JSON.stringify({ "LoginID": loginid, "TransactionKey": transactionkey });

    $.ajax({
        type: "POST",
        data: loginData,
        url: loginUrl,
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            alert(result);
            if (result == "Logged In") {
                window.location = "https://localhost:44302/Home/CreditCardAuth";
                sessionStorage.setItem("checkLogin", result)
            }
        },
        error: function (result) {
            alert("Bad");
        }
    });
};

var GetPmt = function () {
    var loginId = $("#txtLoginId").val();
    var cardName = $("#txtCardName").val();
    var cardNum = $("#txtCardNum").val();
    var cardExp = $("#txtCardExp").val();
    var cardCVV = $("#txtCardCVV").val();
    var donAmt = $("#txtDonationAmt").val();

    var cardUrl = "/api/values/GetPmt";
    var cardData = JSON.stringify({
        "LoginId": loginId, "CardName": cardName, "CardNum": cardNum, "CardExp": cardExp, "CardCVV": cardCVV, "DonAmt": donAmt
    });

    $.ajax({
        type: "POST",
        data: cardData,
        url: cardUrl,
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            alert(result)
        },
        error: function (result) {
            alert(result)
        }
    });
};

const sessionEval = function (login, password) {
    if (
        sessionStorage.checkLogin != "Logged In" ||
        sessionStorage.checkLogin == null
        )
    {
        window.location = "https://localhost:44302/Home/Index";
    }
}