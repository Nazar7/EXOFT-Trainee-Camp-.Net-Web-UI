﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreExample
{
    public static class DbInitializer
    {
        public static void Initialize(MyContext context)
        {
            context.Database.EnsureCreated();
          
            context.SaveChanges();
        }
    }
}
