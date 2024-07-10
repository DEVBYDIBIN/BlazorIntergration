

function showAlert33(message) {
    var element = document.getElementById("PCon");
    var NewElement = document.createElement("p");
    NewElement.innerHTML = "Appentline";
    element.append(NewElement);
    return alert(message);
}

export function Showalert1(message)
{
    alert(message);
};

function ShowAlert(message) {
    Swal.fire({
        icon: 'success',
        title: 'Success!',
        text: message,
        showConfirmButton: true,
        confirmButtonText: 'OK',
        timer: 3000
    });
}


window.ShowAlert4 = function (message) {
    alert(message);
};