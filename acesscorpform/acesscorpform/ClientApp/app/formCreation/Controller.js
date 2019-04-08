formCreationApp.controller('formCreationCtrl', function ($scope, formCreationService) {
    function load() {
        var result = formCreationService.getAll();

        result.then(function (response) {
            $scope.FormCreation = response.data;
        }, function () {
            alert('Ocorreu um erro ao tentar listar todos os funcionários!');
        });
    }
});