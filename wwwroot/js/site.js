function openNewDeviceForm() {
    closeNewOperationForm();
    document.getElementById("NewDeviceForm").style.display = "flex";
}

function closeNewDeviceForm() {
    document.getElementById("NewDeviceForm").style.display = "none";
}



function openNewOperationForm() {
    closeNewDeviceForm();
    document.getElementById("NewOperationForm").style.display = "flex";
}

function closeNewOperationForm() {
    document.getElementById("NewOperationForm").style.display = "none";
}