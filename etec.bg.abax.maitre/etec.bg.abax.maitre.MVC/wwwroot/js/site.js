// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(function (form) {

    $("#btn-registro").on('click', function () {
        var email = document.getElementById("email").value;
        var senha = document.getElementById("senha").value;
        if (email == "" || senha == "") {
        }
        else {
            $("#btn-registro").attr("data-dismiss", "modal");
            document.getElementById("email").value = "";
            document.getElementById("nome").value = "";
            document.getElementById("telefone").value = "";
            document.getElementById("endereco").value = "";
            document.getElementById("senha").value = "";
            document.getElementById("confirmarsenha").value = "";
        }
    });
});

function cancelar() {
    $("#btn-cancelar").attr("data-dismiss", "modal");


    document.getElementById("email").value = "";
        document.getElementById("nome").value = "";
        document.getElementById("telefone").value = "";
        document.getElementById("endereco").value = "";
        document.getElementById("senha").value = "";
        document.getElementById("confirmarsenha").value = "";
        
};

