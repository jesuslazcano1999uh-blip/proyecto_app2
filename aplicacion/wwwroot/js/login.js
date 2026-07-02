document.addEventListener("DOMContentLoaded", function () {

    const form = document.getElementById("loginForm");

    form.addEventListener("submit", function (e) {

        const usuario =
            document.getElementById("usuario").value.trim();

        const password =
            document.getElementById("password").value.trim();

        if (usuario.length === 0) {

            alert("Debe capturar el usuario.");

            e.preventDefault();
            return;
        }

        if (password.length === 0) {

            alert("Debe capturar la contraseña.");

            e.preventDefault();
            return;
        }
    });

});
