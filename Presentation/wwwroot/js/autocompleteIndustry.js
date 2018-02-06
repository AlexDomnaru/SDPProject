$(function () {
    var industryTags = [
        "Abattoir worker",
        "Aboriginal and Torres Strait Islander health worker",
        "Accountant (general)",
        "Accounts clerk",
        "Actor",
        "Actuary",
        "Acupuncturist",
        "Advertising specialist",
        "Aeronautical engineer",
        "Aeroplane pilot",
        "Aged care worker",
        "Agricultural consultant",
        "Agricultural engineer",
        "Agricultural scientist",
        "Air combat officer",
        "Air force - general entrant",
        "Air force technician/ tradesperson",
        "Air traffic controller",
        "Air- conditioning and refrigeration mechanic",
        "Aircraft baggage handler and airline ground crew",
        "Aircraft maintenance engineer (avionics)",
        "Aircraft maintenance engineer (mechanical)",
        "Aircraft maintenance engineer (structural)",
        "Alarm, security or surveillance monitor"
    ];
    $("#industryTags").autocomplete({
        source: industryTags
    });
});

