window.initializeSelect2 = (elementId) => {
    console.log("ID : ", elementId);
    $('#' + elementId).select2({
        multiple: true,
        placeholder: {
            id: '-1',
            text: 'Select an option'
        }
    });
    $('#' + elementId).on('select2:opening select2:closing', function (event) {
        var $searchfield = $(this).parent().find('.select2-search__field');
        $searchfield.prop('disabled', true);
    });
    $('#' + elementId).prop('selected', false);
    console.log("Selected.");
};
