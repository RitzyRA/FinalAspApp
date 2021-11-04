// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const validateEmail = () => {
    var isEmailValid = false;
    var emailElement = document.getElementById("Input_Email");
    if (!emailElement.value.match(/^.+@.+\..+$/g)) {
        document.getElementById("emailWarn").style.display = "";
    } else {
        document.getElementById("emailWarn").style.display = "none";
        isEmailValid = true;
    }
    return isEmailValid;
};

const validatePassword = () => {
    var isPassValid = false;
    var check1 = false;
    var check2 = false;
    var check3 = false;
    var check4 = false;
    var check5 = false;
    var passElement = document.getElementById("Input_Password");
    if (passElement.value.length < 8) {
        document.getElementById("passWarn1").style.display = "";
    }
    else {
        document.getElementById("passWarn1").style.display = "none";
        check1 = true;
    }
    if (!passElement.value.match(/[\d]{1,}/g)) {
        document.getElementById("passWarn2").style.display = "";
    }
    else {
        document.getElementById("passWarn2").style.display = "none";
        check2 = true;
    }
    if (!passElement.value.match(/[a-z]{1,}/g)) {
        document.getElementById("passWarn3").style.display = "";
    }
    else {
        document.getElementById("passWarn3").style.display = "none";
        check3 = true;
    }
    if (!passElement.value.match(/[A-Z]{1,}/g)) {
        document.getElementById("passWarn4").style.display = "";
    }
    else {
        document.getElementById("passWarn4").style.display = "none";
        check4 = true;
    }
    if (!passElement.value.match(/[\W]{1,}/g)) {
        document.getElementById("passWarn5").style.display = "";
    }
    else {
        document.getElementById("passWarn5").style.display = "none";
        check5 = true;
    }
    if (check1, check2, check3, check4, check5) {
        isPassValid = true;
    }
    return isPassValid;
};

const validatePasswordRepeat = () => {
    var isRepeatValid = false;
    var repeatElement = document.getElementById("Input_ConfirmPassword");
    if (repeatElement.value !== document.getElementById("Input_Password").value) {
        document.getElementById("repeatWarn").style.display = "";
    } else {
        document.getElementById("repeatWarn").style.display = "none";
        document.getElementById("sendButton").disabled = false;
        isRepeatValid = true;
    }
    return isRepeatValid;
};

 const enableButton = () => {
 	let registrationButton = document.getElementById("registerBtn");
     if (validateEmail() && validatePassword() && validatePasswordRepeat()) {
 		registrationButton.classList.remove("disabled");
 	} else {
 		registrationButton.classList.add("disabled");
 	}
 }
