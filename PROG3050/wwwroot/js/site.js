// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#Input_CountryId').change(function () {
        var countryId = $(this).val();
        if (countryId > 0) {
            LoadProvinces(countryId);
        }
        else {
            alert("Select Country");
            $('#Input_ProvinceId').attr('disabled', true);
        }
    });

})

function LoadProvinces(countryId) {
    $.ajax({
        url: '/Provinces/GetProvinces?countryId=' + countryId,
        success: function (response) {
            if (response != null && response != undefined && response.length > 0) {
                $('#Input_ProvinceId').empty();
                $.each(response, function (i, data) {
                    console.log(data);
                    $('#Input_ProvinceId').append('<option value=' + data.provinceId + '>' + data.provinceName + '</option>');
                })
            }
            else {
                alert("Something went wrong. Contact to Admin.");
                $('#Input_ProvinceId').attr('disabled', true);
            }
        },
        error: function (error) {
            alert(error);
        }
    });
}