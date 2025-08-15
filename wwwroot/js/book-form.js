$(document).ready(function () {
    $('#ImageUrl').on('change', function () {
        $('.img-preview').attr('src', window.URL.createObjectURL(this.files[0]));
    });
});