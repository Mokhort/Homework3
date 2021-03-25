using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}