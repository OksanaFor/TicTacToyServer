using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DAL.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasIndex(s => s.Id);
            builder.Property(s =>s.Email).IsRequired().HasMaxLength(128);
            builder.Property(s => s.Login).IsRequired().HasMaxLength(128);
            builder.Property(s => s.Password).IsRequired().HasMaxLength(128);
        }
    }
}