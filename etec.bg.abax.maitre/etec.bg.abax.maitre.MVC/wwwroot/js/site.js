// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {

});
function validar() {
    var email, senha;
    email = document.form.email.value;
    senha = document.form.senha.value;
    if ((email == "") && (senha == "")) {
        alert("Por favor preencher este campo");
    }

}

