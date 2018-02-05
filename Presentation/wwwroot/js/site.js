//$(function() {
//    jQuery.validator.addMethod("check_phoneNum",
//        function(value, element, params) {
//            var phone = $(params[0]).val();
//            if (phone.length !== 11) {
//                return false;
//            }
//            var regex = /^(((\+44\s?\d{4}|\(?0\d{4}\)?)\s?\d{3}\s?\d{3})|((\+44\s?\d{3}|\(?0\d{3}\)?)\s?\d{3}\s?\d{4})|((\+44\s?\d{2}|\(?0\d{2}\)?)\s?\d{4}\s?\d{4}))(\s?\#(\d{4}|\d{3}))?$/;
//            if (!regex.match(phone)) {
//                return false;
//            }
//            return true;
//        });

//    jQuery.validator.unobtrusive.adapters.add("check_phoneNum",
//        ["element", "phone"],
//        function(options) {
//            var element = $(options.form).find("select#phone")[0];
//            options.rules["check_phoneNum"] = [element, options.params["phone"]];
//            options.messages["check_phoneNum"] = options.message;
//        }
//    );
//})