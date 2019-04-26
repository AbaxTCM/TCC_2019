// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    var contador = 1;
    var img1 = "login1.jpg";
    var img2 = "img2.jpg";
    var img3 = "img3.jpg";
    var img4 = "img4.png";
    var img5 = "img5.jpg";
    var img6 = "img6.jpg";

    Exibindo();

    function Exibindo() {
        if (!document.images)
            return;

        document.images["slide"].src = eval("img" + contador);

        if (contador < 6)
            contador++;
        else
            contador = 1;
        setTimeout("Exibindo()", 3000);
});

