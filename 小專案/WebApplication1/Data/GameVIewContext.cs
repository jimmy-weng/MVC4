using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class GameVIewContext: DbContext
    {
        public GameVIewContext(DbContextOptions<GameVIewContext> options)
          : base(options)
        {

        }

    }
}
