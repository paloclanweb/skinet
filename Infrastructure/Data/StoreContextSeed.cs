using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entitities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        // los metodos estrticos nos permiten que sean usados sin 
        // necesidad de instanciar la clase
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.BuildTypes.Any())
                {
                    var buildtypesData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/buildtype.json");
                    var buildtypes = JsonSerializer.Deserialize<List<BuildType>>(buildtypesData);

                    foreach (var item in buildtypes)
                    {
                        context.BuildTypes.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.BuildTypesLgs.Any())
                {
                    var buildtypeLgsData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/buildtypelg.json");
                    var buildtypelgs = JsonSerializer.Deserialize<List<BuildTypeLg>>(buildtypeLgsData);

                    foreach (var item in buildtypelgs)
                    {
                        context.BuildTypesLgs.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Currencies.Any())
                {
                    var currenciesData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/currency.json");
                    var currencies = JsonSerializer.Deserialize<List<Currency>>(currenciesData);

                    foreach (var item in currencies)
                    {
                        context.Currencies.Add(item);
                    }

                    await context.SaveChangesAsync();
                }
                if (!context.HouseTypes.Any())
                {
                    var houseTypesData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/housetype.json");
                    var housestype = JsonSerializer.Deserialize<List<HouseType>>(houseTypesData);

                    foreach (var item in housestype)
                    {
                        context.HouseTypes.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.HouseTypeLgs.Any())
                {
                    var houseTypeLgsData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/housetypelg.json");
                    var housestypelg = JsonSerializer.Deserialize<List<HouseTypeLg>>(houseTypeLgsData);

                    foreach (var item in housestypelg)
                    {
                        context.HouseTypeLgs.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.PropertyTypes.Any())
                {
                    var propertyTypesData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/houseproperty.json");
                    var propertytype = JsonSerializer.Deserialize<List<PropertyType>>(propertyTypesData);

                    foreach (var item in propertytype)
                    {
                        context.PropertyTypes.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.PropertyTypeLgs.Any())
                {
                    var propertyTypesLgsData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/housepropertylg.json");
                    var propertytypelg = JsonSerializer.Deserialize<List<PropertyTypeLg>>(propertyTypesLgsData);

                    foreach (var item in propertytypelg)
                    {
                        context.PropertyTypeLgs.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Houses.Any())
                {
                    var housesData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/house.json");
                    var houses = JsonSerializer.Deserialize<List<House>>(housesData);

                    foreach (var item in houses)
                    {
                        context.Houses.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.HouseDestinationLgs.Any())
                {
                    var housedestinationLgsData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/housedestinationlg.json");
                    var housedestinationlgs = JsonSerializer.Deserialize<List<HouseDestinationLg>>(housedestinationLgsData);

                    foreach (var item in housedestinationlgs)
                    {
                        context.HouseDestinationLgs.Add(item);
                    }

                    await context.SaveChangesAsync();
                }


                if (!context.HousePhotos.Any())
                {
                    var housePhotosData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/housephoto.json");
                    var housesphoto = JsonSerializer.Deserialize<List<HousePhoto>>(housePhotosData);

                    foreach (var item in housesphoto)
                    {
                        context.HousePhotos.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.HousePrices.Any())
                {
                    var housePricesData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/houseprice.json");
                    var housesprice = JsonSerializer.Deserialize<List<HousePrice>>(housePricesData);

                    foreach (var item in housesprice)
                    {
                        context.HousePrices.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.HouseLgs.Any())
                {
                    var houseLgsData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/houselg.json");
                    var houseslg = JsonSerializer.Deserialize<List<HouseLg>>(houseLgsData);

                    foreach (var item in houseslg)
                    {
                        context.HouseLgs.Add(item);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex, "An error ocurred during migration");
            }
        }
    }
}