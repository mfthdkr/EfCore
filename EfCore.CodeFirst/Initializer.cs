﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace EfCore.CodeFirst
{
    public class Initializer
    {   
        // appsetting.json' ı okuyabilmek için
        public static IConfigurationRoot Configuration;
        public static void Build()
        {   
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

        }
    }
}
