using Divarcheh.Domain.Core.Entities.Advertisement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Divarcheh.Infrastructure.EfCore.Configurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).IsRequired().HasMaxLength(100);

            builder.HasMany(x => x.Advertisements)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.SubCategories)
                .WithOne(x => x.ParentCategory)
                .HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(new List<Category>()
            {
                new Category() { Id = 1, Title = "ماشین و وسایل نقلیه", ParentId = null },
                new Category() { Id = 2, Title = "دستگاه‌های دیجیتال و گجت‌ها", ParentId = null },
                new Category() { Id = 3, Title = "املاک", ParentId = null },
                new Category() { Id = 4, Title = "وسایل ورزشی", ParentId = null },
                new Category() { Id = 5, Title = " مد و زیبایی", ParentId = null },

                new Category() { Id = 6, Title = "اتومبیل و اتوبوس", ParentId = 1 },
                new Category() { Id = 7, Title = "موتور سیکلت و اسکوتر", ParentId = 1 },

                new Category() { Id = 8, Title = "رهن خانه", ParentId = 3 },
                new Category() { Id = 9, Title = "اجاره خانه و آپارتمان", ParentId = 3 },

            });
        }
    }
}
