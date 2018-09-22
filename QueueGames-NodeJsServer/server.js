var bodyParser = require('body-parser');
var express = require('express');
var app = express();

//MongoDB will come :D
var games = [
    { "Id": "1", "Name": "Mortal Kombat", "YearLaunch": "1992", "Platform": "Arcade" },
    { "Id": "2", "Name": "Mortal Kombat 2", "YearLaunch": "1993", "Platform": "Arcade" }
];
var products = [{ "ProductID": "1", "ProductName": "Augustiner Helles Bier", "QuantityPerUnit": "10", "UnitPrice": "1" }];
var gameId = 2;
var productId = 1;

app.use(function(req, res, next) {
    res.header("Access-Control-Allow-Origin", "*");
    res.header("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");
    next();
});
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

app.get('/', function (request, response) {
    response.end('root of the NodeJS server');
});

app.get('/api/Games', function (request, response) {
    response.json(games);
});

app.post('/api/Games', function(request, response) {
    console.log(request.body);
    request.body.Id = ++gameId;
    games.push(request.body);
    response.end();
});

app.get('/api/Products', function (request, response) {
    response.json(products);
});

app.post('/api/Products', function (request, response) {
    console.log(request.body);
    request.body.ProductID = ++productId;
    products.push(request.body);
    response.end();
});

app.post('/api/Like', function (request, response) {
    response.end();
});

app.post('/api/Buy', function (request, response) {
    response.end();
});

app.listen(10100);