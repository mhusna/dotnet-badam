// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function areYouSure() {
    return confirm("Silmek istediğinize emin misiniz ?");
}

// Validations: Yöntem 2
function isEmpty(obj)
{
    if (obj.value == "")
    {
        obj.style = "border: 1px solid red";
        return true;
    }
    obj.style = "";
    return false;
}

function controllAllElements() {

    let elements = document.getElementsByClassName("required");

    let result = false;

    for (let txt of elements)
    {
        result = isEmpty(txt);
    }

    return result? false : true;
}