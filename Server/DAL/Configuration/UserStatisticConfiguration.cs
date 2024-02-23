using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DAL.Configuration
{
    internal class UserStatisticConfiguration : IEntityTypeConfiguration<UserStatistics>
    {
        public void Configure(EntityTypeBuilder<UserStatistics> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasIndex(s => s.Id);
            builder.HasOne(s => s.User)
                .WithOne(s => s.UserStatistics)
                .HasForeignKey<UserStatistics>(s => s.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
