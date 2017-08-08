$(document).ready(function () {

    $("#createClient").click(function () {
        
        validator = false;
        psw1 = $("#Pass1").val();
        psw2 = $("#Pass2").val();

        if ($("#registerForm").valid()) {
            if (psw1 === psw2) {

            }
            else {
                alert("constraseñas diferentes");
            }

            $.ajax({
                url: "http://localhost:2286/user/CreateClient",
                data: {
                    UserName: $("#userName").val(),
                    Name: $("#name").val(),
                    LastName: $("#lastName").val(),
                    Phone: $("#Phone").val(),
                    Address: $("#address").val(),
                    Email: $("#Email").val(),
                    Password: psw1,
                    NUI: $("#NUI").val()
                },
                type: 'POST',
                dataType: 'json',
                success: function (json) {
                    $("#Validator").html("<div> El usuario " + json.UserName + " se creo con el id <strong>" + json.Id + "</strong></div>")
                },
                error: function (xhr, status) {
                    alert("error en la peticion");
                }
            });

        }
        else {
            alert("todos los campos son obligatorios");
        }

       
    });
});