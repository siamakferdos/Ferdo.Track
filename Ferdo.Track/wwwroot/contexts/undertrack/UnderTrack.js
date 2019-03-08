$(function () {


    $("#add-group").click(function () {
        underTrackApi.addGroup();
    });
    $(document).on("click", "#btn-save-uder-track", function (e) {
        e.preventDefault();
        if ($("#form-add-under-track").valid()) {
            var form = $("#form-add-under-track").serialize();
            underTrackApi.addUnderTrack(form);
        }
    });
    $("#group-user").click(function () {
        underTrackApi.updateGroupUsers();
    });

    groupsTable.showGroupsTable();
});