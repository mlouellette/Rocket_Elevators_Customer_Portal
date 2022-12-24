$(document).ready(function () {

    let building = $('#building').html();
    let battery = $('#battery').html();
    let column = $('#column').html();
    let elevator = $('#elevator').html();

    $('#building').change(function () {

        buildingSelected = $('#building :selected').text();

        //console.log(buildingSelected);


        $.getJSON("https://localhost:7234/api/batteries/building/" + buildingSelected, function (response) {
            console.log(response)

            if (response) {
                $.each(response, function (index, value) {
                    var option = '<option value="' + value.id + '">' + value.id + '</option>';
                    $(option).appendTo("#battery")
                });
            }

        });

    });

    $('#battery').change(function () {

        batterySelected = $('#battery :selected').text();

        //console.log(batterySelected);


        $.getJSON("https://localhost:7234/api/columns/battery/" + batterySelected, function (response) {
            console.log(response)

            if (response) {
                $.each(response, function (index, value) {
                    var option = '<option value="' + value.id + '">' + value.id + '</option>';
                    $(option).appendTo("#column")
                });
            }

        });

    });

    $('#column').change(function () {

        columnSelected = $('#column :selected').text();

        //console.log(batterySelected);


        $.getJSON("https://localhost:7234/api/elevators/column/" + columnSelected, function (response) {
            console.log(response)

            if (response) {
                $.each(response, function (index, value) {
                    var option = '<option value="' + value.id + '">' + value.id + '</option>';
                    $(option).appendTo("#elevator")
                });
            }

        });

    });

});