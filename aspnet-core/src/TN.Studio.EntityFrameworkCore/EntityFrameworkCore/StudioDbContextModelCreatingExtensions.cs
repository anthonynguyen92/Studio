using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace TN.Studio.EntityFrameworkCore
{
    public static class StudioDbContextModelCreatingExtensions
    {
        public static void ConfigureStudio(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(StudioConsts.DbTablePrefix + "YourEntities", StudioConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}