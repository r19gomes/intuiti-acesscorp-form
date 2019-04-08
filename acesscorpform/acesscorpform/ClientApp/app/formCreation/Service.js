formCreationApp.service('formCreationService', function ($http) {
    this.getAll = function () {
        return $http.get('/FormCreation/GetAll');
    };
});