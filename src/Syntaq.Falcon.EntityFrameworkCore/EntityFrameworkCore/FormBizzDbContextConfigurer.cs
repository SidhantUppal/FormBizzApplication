using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FormBizz.EntityFrameworkCore
{
    public static class FormBizzDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FormBizzDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FormBizzDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}