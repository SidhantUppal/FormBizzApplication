(function () {

    // Added my table id
    var _$personsTable = $('#PersonTable');
    var _personServices = abp.services.app.person;

    // Adding permission
    var _permissions = {
        create: abp.auth.hasPermission('Pages.PhoneBook.Create'),
        edit: abp.auth.hasPermission('Pages.PhoneBook.Edit'),
        delete: abp.auth.hasPermission('Pages.PhoneBook.Delete'),
    };

    // Create new person / model 
    var _createOrEditModal = new app.ModalManager({
        viewUrl: abp.appPath + 'FormBizz/PhoneBook/CreatePersonModal',
        scriptUrl: abp.appPath + 'view-resources/Areas/FormBizz/Views/PhoneBook/_CreatePersonModal.js',
        modalClass: 'CreatePersonModal'
    });

    // Bind Table
    var dataTable = _$personsTable.DataTable({
        paging: false,
        serverSide: false,
        processing: false,
        listAction: {
            ajaxFunction: _personServices.getPersons,
            inputFilter: function () {
                return {
                    filter: $('#FilterPeopleText').val(), // Added filter here
                };
            },
        },
        columnDefs: [
            {
                className: 'dtr-control responsive',
                orderable: false,
                render: function () {
                    return '';
                },
                targets: 0,
            },
            {
                targets: 1,
                data: null,
                orderable: false,
                autoWidth: false,
                defaultContent: '',
                rowAction: {
                    text:
                        '<i class="fa fa-cog"></i> <span class="d-none d-md-inline-block d-lg-inline-block d-xl-inline-block">' +
                        app.localize('Actions') +
                        '</span> <span class="caret"></span>',
                    items: [
                        {
                            text: app.localize('Edit'),
                            visible: function () {
                                return _permissions.edit;
                            },
                            action: function (data) {
                                _createOrEditModal.open({ id: data.record.id });
                            },
                        },
                        {
                            text: app.localize('Delete'),
                            visible: function (data) {
                                return _permissions.delete;
                            },
                            action: function (data) {
                                deletePerson(data.record);
                            },
                        },
                    ],
                }
            },
            {
                targets: 2,
                data: 'name'
            },
            {
                targets: 3,
                data: 'surname'
            },
            {
                targets: 4,
                data: 'emailAddress'
            },
            {
                targets: 5,
                data: 'creationTime',
                render: function (creationTime) {
                    return moment(creationTime).format('L');
                },
            },
        ],
    });

    // Open create new person model 
    $('#CreateNewPersonButton').click(function (e) {
        e.preventDefault();
        _createOrEditModal.open();
    });

    // Delete person
    function deletePerson(person) {
        debugger;
        abp.message.confirm(
            app.localize('AreYouSureToDeleteThePerson', person.name),
            app.localize('AreYouSure'),
            function (isConfirmed) {
                if (isConfirmed) {
                    _personServices
                        .deletePerson({
                            id: person.id,
                        })
                        .done(function () {
                            getPersons();
                            abp.notify.success(app.localize('SuccessfullyDeleted'));
                        });
                }
            }
        );
    }

    // Reload data 
    function getPersons() {
        dataTable.ajax.reload();
    }

    // Serach button onClick
    $('#btnFilterPeopleSearch, #RefreshUserListButton').click(function (e) {
        e.preventDefault();
        getPersons();
    });

    // on key down 
    $('#btnFilterPeopleSearch').on('keydown', function (e) {
        if (e.keyCode !== 13) {
            return;
        }

        e.preventDefault();
        getPersons();
    });
})();
