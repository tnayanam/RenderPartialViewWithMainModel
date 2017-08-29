$(function () {
    var instrumentSelect = $('#InstrumentId');
    $('#MusicTypeId').change(function () {
        var musicTypeId = $(this).val();
        var url = $(this).data('url');
        console.log(url);
        instrumentSelect.empty();
        if (!musicTypeId) {
            return;
        }
        $.ajax({
            url: url,
            data: { musicTypeId: musicTypeId },
            success: function (response) {
                instrumentSelect.append($('<option></option>').val('').text('None'));
                $.each(response, function (i, data) {
                    instrumentSelect.append($('<option></option>').val(data.Value).text(data.Text));
                });
            },
            error: function () { }
        });
    });
})
