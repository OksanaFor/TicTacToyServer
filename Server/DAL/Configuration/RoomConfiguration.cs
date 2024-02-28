using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DAL.Configuration
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasIndex(s => s.Id);
            builder.Property(s => s.Password).IsRequired();


        }
    }
}
