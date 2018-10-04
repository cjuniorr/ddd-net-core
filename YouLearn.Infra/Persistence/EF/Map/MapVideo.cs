using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YouLearn.Domain.Entities;

namespace YouLearn.Infra.Persistence.EF.Map
{
    public class MapVideo : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.ToTable("Video");
            //Foreign key
            builder.HasOne(x => x.UserSuggested).WithMany().HasForeignKey("IdUser");
            builder.HasOne(x => x.Channel).WithMany().HasForeignKey("IdChannel");
            builder.HasOne(x => x.Playlist).WithMany().HasForeignKey("IdPlaylist");

            // Properties
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Tags).HasMaxLength(100).IsRequired();
            builder.Property(x => x.PlaylistOrder);
            //builder.Property(x => x.UrlLogo).HasMaxLength(200).IsRequired();
            builder.Property(x => x.IdVideoYoutube).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
