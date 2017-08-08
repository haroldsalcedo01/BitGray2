$(document).ready(function () {

    $.ajax({
        url: "http://localhost:2286/client/GetClientLog",
        type: 'GET',
        dataType: 'json',
        success: function (json) {
            $("#userNamePage").text(json.Name + " " + json.LastName);
            $("#balancePage").text(json.Balance);
        },
        error: function (xhr, status) {
            alert("error en la peticion");
        }

    });

    $.ajax({
        url: "http://localhost:2286/client/GetConsumes",
        type: 'GET',
        dataType: 'json',
        success: function (json) {
            html = "";
            divMain = "<div class=\"rowGrid\">";
            div = "";
            for (var i = 0; i < json.length; i++) {
                div = "<div class=\"headerGridItem\">" + toDateFromJson(json[i].DateCall) + "</div>";
                div = div + "<div class=\"headerGridItem\">" + json[i].Time + "</div>";
                div = div + "<div class=\"headerGridItem\">" + json[i].ValueCall + "</div>";

                div = divMain + div + "<div>";
                $("#gridData").append(div);
            }
        },
        error: function (xhr, status) {
            alert("error en la peticion");
        }

    });

    
    function toDateFromJson(src) {
        return new Date(parseInt(src.substr(6)));
    }



    //timer actions
    $("#btn").click(function () {
        switch ($(this).html().toLowerCase()) {
            case "llamar":
                s = parseInt($("input[name='s']").val());
                if (isNaN(s)) {
                    s = 0;
                    $("input[name='s']").val(0);
                }
                //you can specify action via object or a string
                $("#t").timer({
                    action: 'start',
                    seconds: s
                });
                $(this).html("Colgar");
                $("input[name='s']").attr("disabled", "disabled");
                $("#t").addClass("badge-important");
                break;

           

            case "colgar":
                //you can specify action via object
                $("#t").timer('pause');
                seconds = $("#t").data('seconds');

                $.ajax({
                    url: "http://localhost:2286/client/call",
                    data: {
                        seconds: seconds                       
                    },
                    type: 'POST',
                    dataType: 'json',
                    success: function (json) {
                        alert("Llamada finalizada");
                        location.reload();
                    },
                    error: function (xhr, status) {
                        alert("error en la peticion");
                    }

                });


                $(this).html("Llamar")
                $("#t").removeClass("badge-important");
                break;
        }
    });




})