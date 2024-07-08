window.sweetAlertInterop = {
    showError: function (title, message) {
        Swal.fire({
            icon: 'error',
            title: title,
            text: message
        });
    }
};