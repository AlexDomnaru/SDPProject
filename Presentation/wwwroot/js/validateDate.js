$(function () {
    jQuery.validator.addMethod("minyear",
        function (value, element, params) {
            var date = new Date(element.value);
            var year = date.getYear();
            var day = date.getDate();
            var month = date.getMonth();
            var now = Date.now();
            return year < 1919 && year > now.Year && month > now.Month && day > now.Day;
        });

    jQuery.validator.unobtrusive.adapters.add("minyear",
        ["element", "year"],
        function (options) {
            var element = $("body").find("select#ResidentSince")[0];
            options.rules["minyear"] = [element, options.params["year"]];
            options.messages["minyear"] = options.message;
        }
    );
});