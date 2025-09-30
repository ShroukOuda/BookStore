$(document).ready(function () {
    $('.js-delete').on('click', function() {
        var btn = $(this);
        
        $.ajax({
            url: `/Books/Delete/${btn.data('id')}`,
            method: 'DELETE',

            success: function () {
                alert('success');
            },
            error: function()
            {
                alert('error')
            }
        });
    });
});