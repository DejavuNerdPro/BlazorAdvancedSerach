window.initializeSelect2 = (elementId) => {
    console.log("ID : ", elementId);
    $('#' + elementId).select2({ multiple:true});
    $('#' + elementId).on('select2:opening select2:closing', function (event) {
        var $searchfield = $(this).parent().find('.select2-search__field');
        $searchfield.prop('disabled', true);
    });
    console.log("Selected.");
};
