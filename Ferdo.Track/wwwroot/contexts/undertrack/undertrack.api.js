var underTrackApi = function() {
    return {
        getGroups: function(callback) {
            $.post("/UnderTrack/GetGroups",
                {},
                function(data) {
                    data = JSON.parse(data);
                    if (callback) callback(data);
                });
        },
        getUsers: function (callback) {
            $.post("/UnderTrack/GetUsers",
                {},
                function (data) {
                    data = JSON.parse(data);
                    if (callback) callback(data);
                });
        },
        getGroupUsers: function (callback) {
            $.post("/UnderTrack/GetGroupUsers",
                {},
                function (data) {
                    data = JSON.parse(data);
                    if (callback) callback(data);
                });
        },
        addGroup: function(group, callback) {
            $.post("/UnderTrack/AddGroups", group,
                function(data) {
                    data = JSON.parse(data);
                    if (callback) callback(data);
                });
        },
        addUnderTrack: function (underTrack, callback) {
            $.post("/UnderTrack/AddUnderTrack", underTrack,
                function (data) {
                    data = JSON.parse(data);
                    if (callback) callback(data);
                });
        },
        updateGroupUsers: function (groupUsers, callback) {
            $.post("/UnderTrack/AddGroupUsers", group,
                function (data) {
                    data = JSON.parse(data);
                    if (callback) callback(data);
                });
        }
    };
}();