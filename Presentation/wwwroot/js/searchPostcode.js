function searchPostcode() {
    var input = document.getElementById("code");

    if (input.value === "") {
        showWarning();
        return;
    } else if (input.value.toLowerCase() === "nn16 0rz") {
        if (document.getElementById("selectAddress") === null) {
            var p = document.createElement("p");
            p.textContent = "Please select your address from the dropdown list below";
            p.classList.add("label");

            var select = document.createElement("select");
            select.id = "selectAddress";
            select.classList.add("form-control");
            select.setAttribute("onchange", "autocompleteAddress(this)");

            for (var i = 5; i <= 19; i += 2) {
                var opt = document.createElement("option");
                opt.textContent = i + ", " + "Mill Road, " + "Kettering";
                select.appendChild(opt);
            }

            hideWarning();

            var postcodeForm = document.getElementById("postcodeForm");
            postcodeForm.appendChild(p);
            postcodeForm.appendChild(select);
        }
    }
}

function autocompleteAddress(element) {
    var street = document.getElementById("street");
    var housenum = document.getElementById("housenum");
    var city = document.getElementById("city");

    var content = element.value;
    content = content.split(",");

    housenum.value = content[0].trim();
    street.value = content[1].trim();
    city.value = content[2].trim();
    document.getElementById("selectAddress").classList.add("hidden");
    hideWarning();  
    displayFields();
}

function hideWarning() {
    var warning = document.getElementById("warning-empty-pc");
    if (!warning.classList.contains("hidden")) {
        warning.classList.add("hidden");
    }
}

function displayFields() {
    hideWarning();
    document.getElementById("hidden-stuff").classList.remove("hidden");
}

function showWarning() {
    var warning = document.getElementById("warning-empty-pc");
    warning.classList.remove("hidden");
}