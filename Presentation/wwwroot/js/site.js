$(function() {
    jQuery.validator.addMethod("uknumber",
        function(value, element, params) {
            var phone = value;
            if (phone.length !== 11) {
                return false;
            }
            var regex =
                /^(((\+44\s?\d{4}|\(?0\d{4}\)?)\s?\d{3}\s?\d{3})|((\+44\s?\d{3}|\(?0\d{3}\)?)\s?\d{3}\s?\d{4})|((\+44\s?\d{2}|\(?0\d{2}\)?)\s?\d{4}\s?\d{4}))(\s?\#(\d{4}|\d{3}))?$/;
            if (!regex.test(phone)) {
                return false;
            }
            return true;
        });

    jQuery.validator.unobtrusive.adapters.add("uknumber",
        ["element", "phone"],
        function(options) {
            var element = $(options.form).find("select#PhoneNum")[0];
            options.rules["uknumber"] = [element, options.params["phone"]];
            options.messages["uknumber"] = options.message;
        }
    );
});