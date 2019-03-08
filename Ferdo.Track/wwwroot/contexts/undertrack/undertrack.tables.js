var groupsTable = function() {
    var groupTables;
    return {
        showGroupsTable: function (groupsData, targetId) {
            var columnsdef = [
                {
                    data: groupsData,
                    columns: [
                        { title: "Name" },
                        { title: "Id" }
                    ],
                    "defaultContent": "<button>Click!</button>"
                }
            ];
            groupTables[targetId] = showTable(targetId, columnsdef);
            targetId.off('click', 'tr');
            targetId.on('click', 'tr', function () {
                var data = groupTables[targetId].row(this).data();
                alert('You clicked on ' + data[0] + '\'s row');
            });
        },
        showUsersTable: function (usersData, targetId) {
            var columnsdef = [
                {
                    data: usersData,
                    columns: [
                        { title: "Name" },
                        { title: "Id" }
                    ],
                    "defaultContent": "<button>Click!</button>"
                }
            ];
            groupTables[targetId] = showTable(targetId, columnsdef);
            targetId.off('click', 'tr');
            targetId.on('click', 'tr', function () {
                var data = groupTables[targetId].row(this).data();
                alert('You clicked on ' + data[0] + '\'s row');
            });
        },
        showGroupUsersTable: function (groupUsersData, targetId) {
            var columnsdef = [
                {
                    data: groupUsersData,
                    columns: [
                        { title: "Name" },
                        { title: "Id" }
                    ],
                    "defaultContent": "<button>Click!</button>"
                }
            ];
            groupTables[targetId] = showTable(targetId, columnsdef);
            targetId.off('click', 'tr');
            targetId.on('click', 'tr', function () {
                var data = groupTables[targetId].row(this).data();
                alert('You clicked on ' + data[0] + '\'s row');
            });
        }
    };

    function showTable(tableTarget, columnsDef) {
        return tableTarget.DataTable({
            "columnDefs": columnsDef
        });
    }
}();

