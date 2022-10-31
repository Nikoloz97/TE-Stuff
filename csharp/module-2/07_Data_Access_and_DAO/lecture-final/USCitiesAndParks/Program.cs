﻿using USCitiesAndParks.DAO;

namespace USCitiesAndParks
{
    class Program
    {
        static void Main(string[] args)
        {
            //IConfigurationBuilder builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            //IConfigurationRoot configuration = builder.Build();
            //string connectionString = configuration.GetConnectionString("UnitedStates");




            //@ = prevents backslash from escaping you out of string
            //SQLEXPRESS = local machine (i.e. your computer right now)
            //Trusted_Connection=True = use Windows user account to establish connection
            ICityDao cityDao = new CitySqlDao(@"Server=.\SQLEXPRESS;Database=UnitedStates;Trusted_Connection=True;");
            IStateDao stateDao = new StateSqlDao(@"Server=.\SQLEXPRESS;Database=UnitedStates;Trusted_Connection=True;");
            IParkDao parkDao = new ParkSqlDao(@"Server=.\SQLEXPRESS;Database=UnitedStates;Trusted_Connection=True;");

            USCitiesAndParksCLI cli = new USCitiesAndParksCLI(cityDao, stateDao, parkDao);
            cli.RunCLI();
        }
    }
}
