namespace QueueGames.Data.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QueueGames.Data.CodeFirst.Context.QueueGamesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QueueGames.Data.CodeFirst.Context.QueueGamesContext context)
        {
            context.Games.AddOrUpdate(
                new Entities.Games()
                {
                    Developer = "id Software",
                    YearLaunch = 2016,
                    Platform = "PC, Xbox ONE, PlayStation 4",
                    Name = "Doom (2016)"
                },
                new Entities.Games()
                {
                    Developer = "Nethersoft",
                    YearLaunch = 2015,
                    Platform = "PC, Xbox ONE, PlayStation 4",
                    Name = "Mortal Kombat X"
                },
                new Entities.Games()
                {
                    Developer = "Sierra",
                    YearLaunch = 1995,
                    Platform = "PC, Sega Saturn",
                    Name = "Phantasmagoria"
                },
                new Entities.Games()
                {
                    Developer = "Capcom",
                    YearLaunch = 1996,
                    Platform = "PC, Sega Saturn, PlayStation",
                    Name = "Resident Evil"
                },
                new Entities.Games()
                {
                    Developer = "Capcom",
                    YearLaunch = 1998,
                    Platform = "Capcom",
                    Name = "Resident Evil 2"
                },
                new Entities.Games()
                {
                    Developer = "Capcom",
                    YearLaunch = 1999,
                    Platform = "PC, PlayStation, Sega Dreamcast",
                    Name = "Resident Evil 3: Nemesis"
                },
                new Entities.Games()
                {
                    Developer = "Capcom",
                    YearLaunch = 2000,
                    Platform = "Sega Dreamcast, PlayStation 2, Nintendo GameCube",
                    Name = "Resident Evil Code: Veronica"
                },
                new Entities.Games()
                {
                    Developer = "Midway",
                    YearLaunch = 1992,
                    Platform = "Arcade, Super Nintendo, Sega Genesis",
                    Name = "Mortal Kombat"
                },
                new Entities.Games()
                {
                    Developer = "Midway",
                    YearLaunch = 1994,
                    Platform = "Arcade, Super Nintendo, Sega Genesis, PC",
                    Name = "Mortal Kombat 2"
                },
                new Entities.Games()
                {
                    Developer = "Midway",
                    YearLaunch = 1995,
                    Platform = "Arcade, Super Nintendo, Sega Genesis, PC, Sega Saturn, Playstation",
                    Name = "Mortal Kombat 3"
                }
            );

            context.Products.AddOrUpdate
                (new Entities.Products()
                {
                    ProductName = "Chai",
                    SupplierID = 1,
                    CategoryID = 1,
                    QuantityPerUnit = "10 boxes x 20 bags",
                    UnitPrice = 30.500m,
                    UnitsInStock = 39,
                    UnitsOnOrder = 0,
                    ReorderLevel = 10,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Chang",
                    SupplierID = 1,
                    CategoryID = 1,
                    QuantityPerUnit = "24 - 12 oz bottles",
                    UnitPrice = 19.000m,
                    UnitsInStock = 17,
                    UnitsOnOrder = 40,
                    ReorderLevel = 25,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Aniseed Syrup",
                    SupplierID = 1,
                    CategoryID = 2,
                    QuantityPerUnit = "12 - 550 ml bottles",
                    UnitPrice = 10.000m,
                    UnitsInStock = 13,
                    UnitsOnOrder = 70,
                    ReorderLevel = 25,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Chef Anton's Cajun Seasoning",
                    SupplierID = 2,
                    CategoryID = 2,
                    QuantityPerUnit = "48 - 6 oz jars",
                    UnitPrice = 22.000m,
                    UnitsInStock = 53,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Chef Anton's Gumbo Mix",
                    SupplierID = 2,
                    CategoryID = 2,
                    QuantityPerUnit = "36 boxes",
                    UnitPrice = 21.3500m,
                    UnitsInStock = 0,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = true
                },
                new Entities.Products()
                {
                    ProductName = "Grandma's Boysenberry Spread",
                    SupplierID = 3,
                    CategoryID = 2,
                    QuantityPerUnit = "12 - 8 oz jars",
                    UnitPrice = 25.000m,
                    UnitsInStock = 120,
                    UnitsOnOrder = 0,
                    ReorderLevel = 25,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Uncle Bob's Organic Dried Pears",
                    SupplierID = 3,
                    CategoryID = 7,
                    QuantityPerUnit = "12 - 1 lb pkgs.",
                    UnitPrice = 30.000m,
                    UnitsInStock = 15,
                    UnitsOnOrder = 0,
                    ReorderLevel = 10,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Northwoods Cranberry Sauce",
                    SupplierID = 3,
                    CategoryID = 2,
                    QuantityPerUnit = "12 - 12 oz jars",
                    UnitPrice = 40.000m,
                    UnitsInStock = 6,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Mishi Kobe Niku",
                    SupplierID = 4,
                    CategoryID = 6,
                    QuantityPerUnit = "18 - 500 g pkgs.",
                    UnitPrice = 97.000m,
                    UnitsInStock = 29,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = true
                },
                new Entities.Products()
                {
                    ProductName = "Ikura",
                    SupplierID = 4,
                    CategoryID = 8,
                    QuantityPerUnit = "12 - 200 ml jars",
                    UnitPrice = 31.000m,
                    UnitsInStock = 31,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Queso Cabrales",
                    SupplierID = 5,
                    CategoryID = 4,
                    QuantityPerUnit = "1 kg pkg.",
                    UnitPrice = 21.000m,
                    UnitsInStock = 22,
                    UnitsOnOrder = 30,
                    ReorderLevel = 30,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Queso Manchego La Pastora",
                    SupplierID = 5,
                    CategoryID = 4,
                    QuantityPerUnit = "10 - 500 g pkgs.",
                    UnitPrice = 38.000m,
                    UnitsInStock = 86,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Konbu",
                    SupplierID = 6,
                    CategoryID = 8,
                    QuantityPerUnit = "2 kg box",
                    UnitPrice = 6.0000m,
                    UnitsInStock = 24,
                    UnitsOnOrder = 0,
                    ReorderLevel = 5,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Tofu",
                    SupplierID = 6,
                    CategoryID = 7,
                    QuantityPerUnit = "40 - 100 g pkgs.",
                    UnitPrice = 23.2500m,
                    UnitsInStock = 35,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Genen Shouyu",
                    SupplierID = 6,
                    CategoryID = 2,
                    QuantityPerUnit = "24 - 250 ml bottles",
                    UnitPrice = 15.5000m,
                    UnitsInStock = 39,
                    UnitsOnOrder = 0,
                    ReorderLevel = 5,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Pavlova",
                    SupplierID = 7,
                    CategoryID = 3,
                    QuantityPerUnit = "32 - 500 g boxes",
                    UnitPrice = 17.4500m,
                    UnitsInStock = 29,
                    UnitsOnOrder = 0,
                    ReorderLevel = 10,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Alice Mutton",
                    SupplierID = 7,
                    CategoryID = 6,
                    QuantityPerUnit = "20 - 1 kg tins",
                    UnitPrice = 39.0000m,
                    UnitsInStock = 0,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = true
                },
                new Entities.Products()
                {
                    ProductName = "Carnarvon Tigers",
                    SupplierID = 7,
                    CategoryID = 8,
                    QuantityPerUnit = "16 kg pkg.",
                    UnitPrice = 62.5000m,
                    UnitsInStock = 42,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Teatime Chocolate Biscuits",
                    SupplierID = 8,
                    CategoryID = 3,
                    QuantityPerUnit = "10 boxes x 12 pieces",
                    UnitPrice = 9.2000m,
                    UnitsInStock = 25,
                    UnitsOnOrder = 0,
                    ReorderLevel = 5,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Sir Rodney's Marmalade",
                    SupplierID = 8,
                    CategoryID = 3,
                    QuantityPerUnit = "30 gift boxes",
                    UnitPrice = 81.0000m,
                    UnitsInStock = 40,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Sir Rodney's Scones",
                    SupplierID = 8,
                    CategoryID = 3,
                    QuantityPerUnit = "24 pkgs. x 4 pieces",
                    UnitPrice = 10.0000m,
                    UnitsInStock = 3,
                    UnitsOnOrder = 40,
                    ReorderLevel = 5,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Gustaf's Knäckebröd",
                    SupplierID = 9,
                    CategoryID = 5,
                    QuantityPerUnit = "24 - 500 g pkgs.",
                    UnitPrice = 21.0000m,
                    UnitsInStock = 104,
                    UnitsOnOrder = 0,
                    ReorderLevel = 25,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Tunnbröd",
                    SupplierID = 9,
                    CategoryID = 5,
                    QuantityPerUnit = "12 - 250 g pkgs.",
                    UnitPrice = 9.0000m,
                    UnitsInStock = 61,
                    UnitsOnOrder = 0,
                    ReorderLevel = 25,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Guaraná Fantástica",
                    SupplierID = 10,
                    CategoryID = 1,
                    QuantityPerUnit = "12 - 355 ml cans",
                    UnitPrice = 4.5000m,
                    UnitsInStock = 20,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = true
                },
                new Entities.Products()
                {
                    ProductName = "NuNuCa Nuß-Nougat-Creme",
                    SupplierID = 11,
                    CategoryID = 3,
                    QuantityPerUnit = "20 - 450 g glasses",
                    UnitPrice = 14.0000m,
                    UnitsInStock = 76,
                    UnitsOnOrder = 0,
                    ReorderLevel = 30,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Gumbär Gummibärchen",
                    SupplierID = 11,
                    CategoryID = 3,
                    QuantityPerUnit = "100 - 250 g bags",
                    UnitPrice = 31.2300m,
                    UnitsInStock = 15,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Schoggi Schokolade",
                    SupplierID = 11,
                    CategoryID = 3,
                    QuantityPerUnit = "100 - 100 g pieces",
                    UnitPrice = 43.9000m,
                    UnitsInStock = 49,
                    UnitsOnOrder = 0,
                    ReorderLevel = 30,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Rössle Sauerkraut",
                    SupplierID = 12,
                    CategoryID = 7,
                    QuantityPerUnit = "25 - 825 g cans",
                    UnitPrice = 45.6000m,
                    UnitsInStock = 26,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = true
                },
                new Entities.Products()
                {
                    ProductName = "Thüringer Rostbratwurst",
                    SupplierID = 12,
                    CategoryID = 6,
                    QuantityPerUnit = "50 bags x 30 sausgs.",
                    UnitPrice = 123.7900m,
                    UnitsInStock = 0,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = true
                },
                new Entities.Products()
                {
                    ProductName = "Nord-Ost Matjeshering",
                    SupplierID = 13,
                    CategoryID = 8,
                    QuantityPerUnit = "10 - 200 g glasses",
                    UnitPrice = 25.8900m,
                    UnitsInStock = 10,
                    UnitsOnOrder = 0,
                    ReorderLevel = 15,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Gorgonzola Telino",
                    SupplierID = 14,
                    CategoryID = 4,
                    QuantityPerUnit = "12 - 100 g pkgs",
                    UnitPrice = 12.5000m,
                    UnitsInStock = 0,
                    UnitsOnOrder = 70,
                    ReorderLevel = 20,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Mascarpone Fabioli",
                    SupplierID = 14,
                    CategoryID = 4,
                    QuantityPerUnit = "24 - 200 g pkgs.",
                    UnitPrice = 32.0000m,
                    UnitsInStock = 9,
                    UnitsOnOrder = 40,
                    ReorderLevel = 25,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Geitost",
                    SupplierID = 15,
                    CategoryID = 4,
                    QuantityPerUnit = "500 g",
                    UnitPrice = 2.5000m,
                    UnitsInStock = 112,
                    UnitsOnOrder = 0,
                    ReorderLevel = 20,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Sasquatch Ale",
                    SupplierID = 16,
                    CategoryID = 1,
                    QuantityPerUnit = "24 - 12 oz bottles",
                    UnitPrice = 14.0000m,
                    UnitsInStock = 111,
                    UnitsOnOrder = 0,
                    ReorderLevel = 15,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Steeleye Stout",
                    SupplierID = 16,
                    CategoryID = 1,
                    QuantityPerUnit = "24 - 12 oz bottles",
                    UnitPrice = 18.0000m,
                    UnitsInStock = 20,
                    UnitsOnOrder = 0,
                    ReorderLevel = 15,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Inlagd Sill",
                    SupplierID = 17,
                    CategoryID = 8,
                    QuantityPerUnit = "24 - 250 g  jars",
                    UnitPrice = 19.0000m,
                    UnitsInStock = 112,
                    UnitsOnOrder = 0,
                    ReorderLevel = 20,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Gravad lax",
                    SupplierID = 17,
                    CategoryID = 8,
                    QuantityPerUnit = "12 - 500 g pkgs.",
                    UnitPrice = 26.0000m,
                    UnitsInStock = 11,
                    UnitsOnOrder = 50,
                    ReorderLevel = 25,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Côte de Blaye",
                    SupplierID = 18,
                    CategoryID = 1,
                    QuantityPerUnit = "12 - 75 cl bottles",
                    UnitPrice = 263.5000m,
                    UnitsInStock = 17,
                    UnitsOnOrder = 0,
                    ReorderLevel = 15,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Chartreuse verte",
                    SupplierID = 18,
                    CategoryID = 1,
                    QuantityPerUnit = "750 cc per bottle",
                    UnitPrice = 18.0000m,
                    UnitsInStock = 69,
                    UnitsOnOrder = 0,
                    ReorderLevel = 5,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Boston Crab Meat",
                    SupplierID = 19,
                    CategoryID = 8,
                    QuantityPerUnit = "24 - 4 oz tins",
                    UnitPrice = 18.4000m,
                    UnitsInStock = 123,
                    UnitsOnOrder = 0,
                    ReorderLevel = 30,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Jack's New England Clam Chowder",
                    SupplierID = 19,
                    CategoryID = 8,
                    QuantityPerUnit = "12 - 12 oz cans",
                    UnitPrice = 9.6500m,
                    UnitsInStock = 85,
                    UnitsOnOrder = 0,
                    ReorderLevel = 10,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Singaporean Hokkien Fried Mee",
                    SupplierID = 20,
                    CategoryID = 5,
                    QuantityPerUnit = "32 - 1 kg pkgs.",
                    UnitPrice = 14.0000m,
                    UnitsInStock = 26,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = true
                },
                new Entities.Products()
                {
                    ProductName = "Ipoh Coffee",
                    SupplierID = 20,
                    CategoryID = 1,
                    QuantityPerUnit = "16 - 500 g tins",
                    UnitPrice = 46.0000m,
                    UnitsInStock = 17,
                    UnitsOnOrder = 10,
                    ReorderLevel = 25,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Gula Malacca",
                    SupplierID = 20,
                    CategoryID = 2,
                    QuantityPerUnit = "20 - 2 kg bags",
                    UnitPrice = 19.4500m,
                    UnitsInStock = 27,
                    UnitsOnOrder = 0,
                    ReorderLevel = 15,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Rogede sild",
                    SupplierID = 21,
                    CategoryID = 8,
                    QuantityPerUnit = "1k pkg.",
                    UnitPrice = 9.5000m,
                    UnitsInStock = 5,
                    UnitsOnOrder = 70,
                    ReorderLevel = 15,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Spegesild",
                    SupplierID = 21,
                    CategoryID = 8,
                    QuantityPerUnit = "4 - 450 g glasses",
                    UnitPrice = 12.0000m,
                    UnitsInStock = 95,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Zaanse koeken",
                    SupplierID = 22,
                    CategoryID = 3,
                    QuantityPerUnit = "10 - 4 oz boxes",
                    UnitPrice = 9.5000m,
                    UnitsInStock = 36,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Chocolade",
                    SupplierID = 22,
                    CategoryID = 3,
                    QuantityPerUnit = "10 pkgs.",
                    UnitPrice = 12.7500m,
                    UnitsInStock = 15,
                    UnitsOnOrder = 70,
                    ReorderLevel = 25,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Maxilaku",
                    SupplierID = 23,
                    CategoryID = 3,
                    QuantityPerUnit = "24 - 50 g pkgs.",
                    UnitPrice = 20.0000m,
                    UnitsInStock = 10,
                    UnitsOnOrder = 60,
                    ReorderLevel = 15,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Valkoinen suklaa",
                    SupplierID = 23,
                    CategoryID = 3,
                    QuantityPerUnit = "12 - 100 g bars",
                    UnitPrice = 16.2500m,
                    UnitsInStock = 65,
                    UnitsOnOrder = 0,
                    ReorderLevel = 30,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Manjimup Dried Apples",
                    SupplierID = 24,
                    CategoryID = 7,
                    QuantityPerUnit = "50 - 300 g pkgs.",
                    UnitPrice = 53.0000m,
                    UnitsInStock = 20,
                    UnitsOnOrder = 0,
                    ReorderLevel = 10,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Filo Mix",
                    SupplierID = 24,
                    CategoryID = 5,
                    QuantityPerUnit = "16 - 2 kg boxes",
                    UnitPrice = 7.0000m,
                    UnitsInStock = 38,
                    UnitsOnOrder = 0,
                    ReorderLevel = 25,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Perth Pasties",
                    SupplierID = 24,
                    CategoryID = 6,
                    QuantityPerUnit = "48 pieces",
                    UnitPrice = 32.8000m,
                    UnitsInStock = 0,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = true
                },
                new Entities.Products()
                {
                    ProductName = "Tourtière",
                    SupplierID = 25,
                    CategoryID = 6,
                    QuantityPerUnit = "16 pies",
                    UnitPrice = 7.4500m,
                    UnitsInStock = 21,
                    UnitsOnOrder = 0,
                    ReorderLevel = 10,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Pâté chinois",
                    SupplierID = 25,
                    CategoryID = 6,
                    QuantityPerUnit = "24 boxes x 2 pies",
                    UnitPrice = 24.0000m,
                    UnitsInStock = 115,
                    UnitsOnOrder = 0,
                    ReorderLevel = 20,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Gnocchi di nonna Alice",
                    SupplierID = 26,
                    CategoryID = 5,
                    QuantityPerUnit = "24 - 250 g pkgs.",
                    UnitPrice = 38.0000m,
                    UnitsInStock = 21,
                    UnitsOnOrder = 10,
                    ReorderLevel = 30,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Ravioli Angelo",
                    SupplierID = 26,
                    CategoryID = 5,
                    QuantityPerUnit = "24 - 250 g pkgs.",
                    UnitPrice = 19.5000m,
                    UnitsInStock = 36,
                    UnitsOnOrder = 0,
                    ReorderLevel = 20,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Escargots de Bourgogne",
                    SupplierID = 27,
                    CategoryID = 8,
                    QuantityPerUnit = "24 pieces",
                    UnitPrice = 13.2500m,
                    UnitsInStock = 62,
                    UnitsOnOrder = 0,
                    ReorderLevel = 20,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Raclette Courdavault",
                    SupplierID = 28,
                    CategoryID = 4,
                    QuantityPerUnit = "5 kg pkg.",
                    UnitPrice = 55.0000m,
                    UnitsInStock = 79,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Camembert Pierrot",
                    SupplierID = 28,
                    CategoryID = 4,
                    QuantityPerUnit = "15 - 300 g rounds",
                    UnitPrice = 34.0000m,
                    UnitsInStock = 19,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Sirop d'érable",
                    SupplierID = 29,
                    CategoryID = 2,
                    QuantityPerUnit = "24 - 500 ml bottles",
                    UnitPrice = 28.5000m,
                    UnitsInStock = 113,
                    UnitsOnOrder = 0,
                    ReorderLevel = 25,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Tarte au sucre",
                    SupplierID = 29,
                    CategoryID = 3,
                    QuantityPerUnit = "48 pies",
                    UnitPrice = 0,
                    UnitsInStock = 17,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Vegie-spread",
                    SupplierID = 7,
                    CategoryID = 2,
                    QuantityPerUnit = "15 - 625 g jars",
                    UnitPrice = 43.9000m,
                    UnitsInStock = 24,
                    UnitsOnOrder = 0,
                    ReorderLevel = 5,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Wimmers gute Semmelknödel",
                    SupplierID = 12,
                    CategoryID = 5,
                    QuantityPerUnit = "20 bags x 4 pieces",
                    UnitPrice = 33.2500m,
                    UnitsInStock = 22,
                    UnitsOnOrder = 80,
                    ReorderLevel = 30,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Louisiana Fiery Hot Pepper Sauce",
                    SupplierID = 2,
                    CategoryID = 2,
                    QuantityPerUnit = "32 - 8 oz bottles",
                    UnitPrice = 21.0500m,
                    UnitsInStock = 76,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Louisiana Hot Spiced Okra",
                    SupplierID = 2,
                    CategoryID = 2,
                    QuantityPerUnit = "24 - 8 oz jars",
                    UnitPrice = 17.0000m,
                    UnitsInStock = 4,
                    UnitsOnOrder = 100,
                    ReorderLevel = 20,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Laughing Lumberjack Lager",
                    SupplierID = 16,
                    CategoryID = 1,
                    QuantityPerUnit = "24 - 12 oz bottles",
                    UnitPrice = 14.0000m,
                    UnitsInStock = 52,
                    UnitsOnOrder = 0,
                    ReorderLevel = 10,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Scottish Longbreads",
                    SupplierID = 8,
                    CategoryID = 3,
                    QuantityPerUnit = "10 boxes x 8 pieces",
                    UnitPrice = 12.5000m,
                    UnitsInStock = 6,
                    UnitsOnOrder = 10,
                    ReorderLevel = 15,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Gudbrandsdalsost",
                    SupplierID = 15,
                    CategoryID = 4,
                    QuantityPerUnit = "10 kg pkg.",
                    UnitPrice = 36.0000m,
                    UnitsInStock = 26,
                    UnitsOnOrder = 0,
                    ReorderLevel = 15,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Outback Lager",
                    SupplierID = 7,
                    CategoryID = 1,
                    QuantityPerUnit = "24 - 355 ml bottles",
                    UnitPrice = 15.0000m,
                    UnitsInStock = 15,
                    UnitsOnOrder = 10,
                    ReorderLevel = 30,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Flotemysost",
                    SupplierID = 15,
                    CategoryID = 4,
                    QuantityPerUnit = "10 - 500 g pkgs.",
                    UnitPrice = 21.5000m,
                    UnitsInStock = 26,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Mozzarella di Giovanni",
                    SupplierID = 14,
                    CategoryID = 4,
                    QuantityPerUnit = "24 - 200 g pkgs.",
                    UnitPrice = 34.8000m,
                    UnitsInStock = 14,
                    UnitsOnOrder = 0,
                    ReorderLevel = 0,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Röd Kaviar",
                    SupplierID = 17,
                    CategoryID = 8,
                    QuantityPerUnit = "24 - 150 g jars",
                    UnitPrice = 15.0000m,
                    UnitsInStock = 101,
                    UnitsOnOrder = 0,
                    ReorderLevel = 5,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Longlife Tofu",
                    SupplierID = 4,
                    CategoryID = 7,
                    QuantityPerUnit = "5 kg pkg.",
                    UnitPrice = 10.0000m,
                    UnitsInStock = 4,
                    UnitsOnOrder = 20,
                    ReorderLevel = 5,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Rhönbräu Klosterbier",
                    SupplierID = 12,
                    CategoryID = 1,
                    QuantityPerUnit = "24 - 0.5 l bottles",
                    UnitPrice = 7.7500m,
                    UnitsInStock = 125,
                    UnitsOnOrder = 0,
                    ReorderLevel = 25,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Lakkalikööri",
                    SupplierID = 23,
                    CategoryID = 1,
                    QuantityPerUnit = "500 ml",
                    UnitPrice = 18.0000m,
                    UnitsInStock = 57,
                    UnitsOnOrder = 0,
                    ReorderLevel = 20,
                    Discontinued = false
                },
                new Entities.Products()
                {
                    ProductName = "Original Frankfurter grüne Soße",
                    SupplierID = 12,
                    CategoryID = 2,
                    QuantityPerUnit = "12 boxes",
                    UnitPrice = 13.0000m,
                    UnitsInStock = 32,
                    UnitsOnOrder = 0,
                    ReorderLevel = 15,
                    Discontinued = false
                }
                );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
