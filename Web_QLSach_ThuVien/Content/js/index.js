function isEmail(inputEmail) {
    var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(inputEmail);
}
function validatePassword(inputPassword) {
    return inputPassword.length > 4;
}

$(document).ready(function () {
    $('#email').change(function () {
        var email = $(this).val().trim();
        // alert(`email = ${JSON.stringify(email)}`)
        if (!isEmail(email)) {
            //Error ?
            $(".emailError").html("Email is not valid format");
        } else {
            $(".emailError").html("");
        }
    });
    $('#password').change(function () {
        var password = $(this).val();
        if (!validatePassword(password)) {
            $(".passwordError").html("Password must be at least 5 characters");
        } else {
            $(".passwordError").html("");
        }
    });
});

function showRegisterForm() {
    $('.loginBox').fadeOut('fast', function () {
        $('.registerBox').fadeIn('fast');
        $('.login-footer').fadeOut('fast', function () {
            $('.register-footer').fadeIn('fast');
        });
        $('.modal-title').html('Đăng ký');
    });
    $('.error').removeClass('alert alert-danger').html('');
}
function showLoginForm() {
    $('.registerBox').fadeOut('fast', function () {
        $('.loginBox').fadeIn('fast');
        $('.register-footer').fadeOut('fast', function () {
            $('.login-footer').fadeIn('fast');
        });
        $('.modal-title').html('Đăng nhập');
    });
    $('.error').removeClass('alert alert-danger').html('');

