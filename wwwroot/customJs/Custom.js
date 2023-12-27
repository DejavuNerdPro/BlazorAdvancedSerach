/*$(document).ready(function(){
    $('#age').on('change', (e) => {
        console.log("age on Change");
        dotnetHelper.invokeMethodAsync('BlazorAdvancedSerach', 'HandleAgeSelection', e);
        console.log("AGE");
    });
    $('#township').on('change', (e) => {
        console.log("township on Change");
        DotNet.invokeMethodAsync('BlazorAdvancedSerach', 'HandleAddressSelection', e);
        console.log("TOWNSHIP");
    });
    $('#phone').on('change', (e) => {
        console.log("Phone on Change");
        DotNet.invokeMethodAsync('BlazorAdvancedSerach', 'HandlePhoneSelection', e);
        console.log("PHONE");
    });
});*/

window.initializeSelect2 = (elementId,dotnetHelper) => {
    console.log("ID : ", elementId);
    $('#' + elementId).select2({
        multiple: true,
        placeholder: {
            id: '-1',
            text: 'Select an option'
        }
    });
    /*$('#' + elementId).on('select2:opening select2:closing', function (event) {
        var $searchfield = $(this).parent().find('.select2-search__field');
        $searchfield.prop('disabled', true);
    });*/
    $('#age').on('change', (e) => {
        console.log("age on Change");
        dotnetHelper.invokeMethodAsync('BlazorAdvancedSerach','handleAgeSelection', e);
        console.log("AGE");
    });
    $('#township').on('change', (e) => {
        console.log("township on Change");
        dotnetHelper.invokeMethodAsync('BlazorAdvancedSerach', 'handleAddressSelection', e);
        console.log("TOWNSHIP");
    });
    $('#phone').on('change', (e) => {
        console.log("Phone on Change");
        dotnetHelper.invokeMethodAsync('BlazorAdvancedSerach', 'handlePhoneSelection', e);
        console.log("PHONE");
    });
    
    $('#' + elementId).prop('selected', false);
    console.log("Selected.");
};

/*window.initializeSelect2 = (elementId) => {
    console.log("ID : ", elementId);
    *//*$('#' + elementId).select2({
        multiple: true,
        placeholder: {
            id: '-1',
            text: 'Select an option'
        }
    });*//*
    $('#age').select2({ multiple: true, placeholder: { id: '-1', text: 'Select an option' });
    $('#address').select2({ multiple: true, placeholder: { id: '-1', text: 'Select an option' } });
    $('#phone').select2({ multiple: true, placeholder: { id: '-1', text: 'Select an option' } });
    *//*$('#' + elementId).on('select2:opening select2:closing', function (event) {
        var $searchfield = $(this).parent().find('.select2-search__field');
        $searchfield.prop('disabled', true);
    });*//*
    *//*$('#' + elementId).prop('selected', false);*//*
    $('#age').on('select2:opening select2:closing', function (event) {
        var $searchfield = $(this).parent().find('.select2-search__field');
        $searchfield.prop('disabled', true);
    });
    $('#address').on('select2:opening select2:closing', function (event) {
        var $searchfield = $(this).parent().find('.select2-search__field');
        $searchfield.prop('disabled', true);
    });
    $('#phone').on('select2:opening select2:closing', function (event) {
        var $searchfield = $(this).parent().find('.select2-search__field');
        $searchfield.prop('disabled', true);
    });
    $('#age').on('change', (e) => {
        DotNet.invokeMethodAsync('BlazorAdvancedSerach', 'HandleAgeSelection');
    });
    $('#address').on('change', (e) => {
        DotNet.invokeMethodAsync('BlazorAdvancedSerach', 'HandleAddressSelection');
    });
    $('#phone').on('change', (e) => {
        DotNet.invokeMethodAsync('BlazorAdvancedSerach', 'HandlePhoneSelection');
    });
    console.log("Selected.");
};*/
