$.validator.addMethod('filesize', function (value, element, param) {
    return element.files[0].size <= param;
});