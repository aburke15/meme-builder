using System;
using Microsoft.EntityFrameworkCore;

namespace MemeBuilderData
{
    public class MemeBuilderContext : DbContext
    {
        public MemeBuilderContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
