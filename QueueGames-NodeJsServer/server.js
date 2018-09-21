var express = require('express');
var app = express();

app.use(function(req, res, next) {
    res.header("Access-Control-Allow-Origin", "*");
    res.header("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");
    next();
});

app.get('/', function (request, response) {
    response.end('root of the NodeJS server');
});

app.get('/api/Games', function (request, response) {
    response.json('[{ "Id": "1", "Name": "Mortal Kombat", "YearLaunch": "1992", "Platform": "Arcade" }, { "Id": "2", "Name": "Mortal Kombat 2", "YearLaunch": "1993", "Platform": "Arcade" }]');
});

app.post('/api/Like', function (request, response) {
    response.end();
});

app.post('/api/Buy', function (request, response) {
    response.end();
});

app.get('/api/Products', function (request, response) {
    response.json('[{ "ProductID": "1", "ProductName": "Augustiner Helles Bier", "QuantityPerUnit": "10", "UnitPrice": "1" }]');
});

app.listen(10100);