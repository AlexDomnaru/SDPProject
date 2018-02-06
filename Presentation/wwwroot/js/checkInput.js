function checkInput(element) {
    var value = element.value;

    if (value === "") {
        return;
    }

    
    if (value === "Employed" | value === "Self Employed") {
        document.getElementById("hidden-occ-fields").classList.remove("hidden");
        document.getElementById("occupations2").classList.remove("hidden");
        removeAttributes(document.getElementById("occupationTags"));
        return;
    }
    if (value === "In Education") {
        document.getElementById("hidden-occ-fields").classList.remove("hidden");
        document.getElementById("occupations1").classList.remove("hidden");
        removeAttributes(document.getElementById("occ-list"));
        var industry = document.getElementById("industryTags");
        industry.value = "Education";
        industry.classList.add("hidden");
        return;
    }

    document.getElementById("occupationTags").value = "none";
    removeAttributes(document.getElementById("occ-list"));
    document.getElementById("industryTags").value = "none";
}

function removeAttributes(element) {
    var attributes = element.attributes; 
    for (var i = 0; i < attributes.length; i++) {
        var atr = attributes[i];
        if (atr.name.startsWith("data-val")) {
            element.removeAttribute(attributes[i]);
        }
    }
}