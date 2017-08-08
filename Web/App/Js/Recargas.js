$(document).ready(function () {

    $.ajax({
        url: "http://localhost:2286/client/GetRecharges",

        type: 'GET',
        dataType: 'json',
        success: function (json) {
            html = "";
            divMain = "<div class=\"rowGrid\">";
            div = "";
            for (var i = 0; i < json.length; i++) {

                promo = "No";
                if (json[i].ApplyPromo === true) 
                {
                    promo = "Si";    
                }             
                var d = new Date(0); // The 0 there is the key, which sets the date to the epoch
                d.setUTCSeconds(json[i].DateRecharge);

                
                div = "<div class=\"headerGridItem\">" + toDateFromJson(json[i].DateRecharge) + "</div>";
                div =  div + "<div class=\"headerGridItem\">"+json[i].Value+"</div>";
                div = div + "<div class=\"headerGridItem\">" + json[i].BondsValue + "</div>";
                div = div + "<div class=\"headerGridItem\">" + promo + "</div>";

                div = divMain + div + "<div>";
                $("#gridData").append(div);
            }
            
            
        },
        error: function (xhr, status) {
            alert("error en la peticion");
        }
    });

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

    function toDateFromJson(src) {
        return new Date(parseInt(src.substr(6)));
    }


    $("#recharge").click(function () {
        value = $("#value").val();
        if (value !== "" || values != undefined) {
            $.ajax({
                url: "http://localhost:2286/client/recharge",
                data: {
                    value: value
                },
                type: 'POST',
                dataType: 'json',
                success: function (json) {
                    alert("se recargo satisfactoriamente se recargo un valor de " + json.TotalRecharge + " dividido en: valor de la recarga " + json.Value + " Valor promocional: " + json.BondsValue)

                },
                error: function (xhr, status) {
                    alert("error en la peticion");
                }
            });

        }
        else {
            alert("Escriba un valor para la recarga")
        }
    })
})