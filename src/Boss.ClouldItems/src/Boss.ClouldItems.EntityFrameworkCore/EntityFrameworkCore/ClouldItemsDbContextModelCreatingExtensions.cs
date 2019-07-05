using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Boss.ClouldItems.EntityFrameworkCore
{
    public static class ClouldItemsDbContextModelCreatingExtensions
    {
        public static void ConfigureClouldItems(
            this ModelBuilder builder,
            Action<ClouldItemsModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ClouldItemsModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureFullAuditedAggregateRoot();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */

            builder.Entity<Sku>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Skus", options.Schema);

                b.ConfigureByConvention();

                b.Property(a => a.Name).IsRequired().HasMaxLength(SkuConsts.NameMaxLenght);
                b.Property(a => a.Ename).HasMaxLength(SkuConsts.EnameMaxLenght);
                b.Property(a => a.Description).HasMaxLength(SkuConsts.DescriptionMaxLenght);
                b.Property(a => a.Code).IsRequired().HasMaxLength(SkuConsts.CodeMaxLenght);
                b.Property(a => a.Barcode).HasMaxLength(SkuConsts.BarcodeMaxLenght);
                b.Property(a => a.Unit).HasMaxLength(SkuConsts.UnitMaxLenght);

            });
        }
    }
}