$(document).ready(function () {
    $("#logIn").click(function () {
        $.ajax({
            url: "http://localhost:2286/user/logIn",
            data: {
                user: $("#userName").val(),
                password: $("#password").val()
            },
            type: 'POST',
            dataType: 'json',
            success: function (json) {
                if (json.Type === "Client") {
                    window.location.href = "Client/Client.html";
                }
                else {
                    window.location.href = "Employe/Employe.html";
                } 
            },
            error: function (xhr, status) {
                alert("error en la peticion");
            }
        });
    })
});