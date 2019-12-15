var EMD = EMD || {};
EMD.Documento = (function () {

    var init = function (xml) {
        EMD.Cliente.init(xml);
    };


    var registrarCliente = function (xml) {
        EMD.Cliente.registrar(xml);
    };
    
    
    



    return {

        init: init,
        registrarCliente: registrarCliente
    }

})();

(function () {

    EMD.Documento.init('rey');


})();
