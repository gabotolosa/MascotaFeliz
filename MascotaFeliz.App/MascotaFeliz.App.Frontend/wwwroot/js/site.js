window.$ = window.jquery = require('./node_modules/jquery');
window.dt = require('./node_modules/datatables.net')();
window.$('#Tables').DataTable();

$(document).ready( function () {
    $('#Tables').DataTable();
} );