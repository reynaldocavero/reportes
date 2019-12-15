var EMD = EMD || {};
EMD.Cliente = (function () {
    var tabla = $("#listaCliente");
    var init = function (xml) {
        

        lista(xml);
        tabla.off("click").on("click", "tr", function () {
            
            var $this = $(this);
            //console.log($this);
            if ($this.hasClass('info')) {
                $this.removeClass('info');
            } else {
                $("#listaCliente tr").removeClass('info');
                $this.addClass('info');
            }
        });

        tabla.off("dblclick").on("dblclick", "tr", function (e) {
            e.stopPropagation();

            //var filaData = tabla.row($(this)).data();
            var filaData = $(this).closest('tr');
            //console.log(filaData);
            //console.log(filaData);
            $(EMD.Cliente).trigger("cliente.selected", [{ clienteSeleccionado: filaData }]);

            //$("#exampleModalCenter .close").click();
        });

        
    };



    var lista = function (xml) {

        $.ajax({
            type: "POST",
            url: "/Documento/listaCliente",
            data: JSON.stringify({ xml: xml }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {

                console.log(data);

                $.each(data, function (key, val) {
                    var tr = $('<tr>');
                    tr.html('<td>' + val.id + '</td>' +
                        '<td>' + val.nombre + '</td>' +
                        '<td>' + val.tipDoc + '</td>' +
                        '<td>' + val.numDoc + '</td>' +
                        '<td>' + val.activo + '</td>');
                    $('#listaCliente').append(tr);
                    //$('#txtCliente').val(val.cliente);
                });
            },
            error: function (result) {
                alert('ERROR: ' + result.status + ' ' + result.statusText);
            }
        });
    };

    var registrar = function (xml) {

        $.ajax({
            type: "POST",
            url: "/Documento/registraCliente",
            data: JSON.stringify({ xml: xml }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {

                console.log(data);

                $.each(data, function (key, val) {
                    var tr = $('<tr>');
                    tr.html('<td>' + val.id + '</td>' +
                        '<td>' + val.nombre + '</td>' +
                        '<td>' + val.tipDoc + '</td>' +
                        '<td>' + val.numDoc + '</td>' +
                        '<td>' + val.activo + '</td>');
                    $('#listaCliente').append(tr);
                    //$('#txtCliente').val(val.cliente);
                });
            },
            error: function (result) {
                alert('ERROR: ' + result.status + ' ' + result.statusText);
            }
        });
    };

    var reporte = function () {
       $.ajax({
            type: "POST",
           url: "/Documento/reporteCliente",
            //url: "/Reportes/CrytalReport.aspx/LoadReport",
            //data: JSON.stringify({ nombre: nombre, tipo: tipo, numero: numero }),
            data: JSON.stringify({ xml: 'Cliente' }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data);
                window.open(data+'Reportes/Cliente.aspx', '_newtab');
            },
            error: function (result) {
                alert('ERROR: ' + result.status + ' ' + result.statusText);
            }
        });
        //window.open('http://localhost:50393/Reportes/Cliente.aspx', '_newtab');
    };


    return {

        init: init,
        lista: lista,
        registrar: registrar,
        reporte: reporte
    }

})();