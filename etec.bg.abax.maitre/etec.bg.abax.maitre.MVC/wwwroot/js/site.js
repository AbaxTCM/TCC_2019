// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function cancelar() {

    document.getElementById("email").value = "";
    document.getElementById("nome").value = "";
    document.getElementById("telefone").value = "";
    document.getElementById("endereco").value = "";
    document.getElementById("senha").value = "";
    document.getElementById("confirmarsenha").value = "";
    document.getElementById("cnpj").value = "";

};

function validarLogin() {
    document.getElementById("loading").style.display = "block";
    var email = document.getElementById("email").value;
    var senha = document.getElementById("senha").value;
    var data = {};
    $.ajax({
        type: "POST",
        url: "../Home/ValidLogin",
        data: { "email": email, "senha": senha }
    }).then(function (response) {

        if (response.sucesso == true) {
            window.location.href = '../Home/Menu';
        }
        else {
            alert(response.erro);
        }
    });
    console.log(data);
    document.getElementById("loading").style.display = "none";

    email = ""; senha = "";
};

function registrarCliente() {

    var email = document.getElementById("emailCliente").value;
    var nome = document.getElementById("nomeCliente").value;
    var telefone = document.getElementById("telefoneCliente").value;
    var senha = document.getElementById("senhaCliente").value;
    var confSenha = document.getElementById("confirmarSenhaCliente").value;
    var cpf = document.getElementById("cpfCliente").value;

    var valores = { "email": email, "senha": senha, "telefone": telefone, "nome": nome, "cpf": cpf, "funcao": "cli" };
    if (nome == "" || email == "" || telefone == "" || senha == "" || cpf == "") {
    }
    else {
        if (senha != confSenha) {
            alert("Senhas não se correspondem");
        }
        else {
            $.ajax({
                type: "POST",
                url: "../Home/Cadastros",
                data: valores
            }).then(function (response) {

                if (response.sucesso == true) {
                    alert(response.mensagem);
                    window.location.href = '../Home/BemVindo';
                }
                else {
                    alert(response.erro);
                }
                $('#registrarUsuario').modal('toggle');
            });
        }
    }
    console.log(valores);

    nome = ""; email = ""; telefone = ""; senha = ""; cpf = "";
};

function registrarRestaurante() {
    var email = document.getElementById("emailRestaurante").value;
    var nome = document.getElementById("nomeRestaurante").value;
    var telefone = document.getElementById("telefoneRestaurante").value;
    var senha = document.getElementById("senhaRestaurante").value;
    var confSenha = document.getElementById("confirmarSenhaRestaurante").value;
    var cnpj = document.getElementById("cnpjRestaurante").value;
    var endereco = document.getElementById("enderecoRestaurante").value;

    var valores = { "email": email, "senha": senha, "telefone": telefone, "nome": nome, "cnpj": cnpj, "endereco": endereco, "funcao": "rest" };
    if (nome == "" || email == "" || telefone == "" || senha == "" || cnpj == "" || endereco == "") {

    }
    else {
        if (senha != confSenha) {
            alert("Senhas não correspondem");
        }
        else {
            $.ajax({
                type: "POST",
                url: "../Home/Cadastros",
                data: valores
            }).then(function (response) {

                if (response.sucesso == true) {
                    alert(response.mensagem);
                    window.location.href = '../Home/BemVindo';
                }
                else {
                    alert(response.erro);
                }
                $('#RegistrarUsuario').modal('toggle');
            });
        }
    }
    console.log(valores);

    nome = ""; email = ""; telefone = ""; senha = ""; cnpj = "";
};

