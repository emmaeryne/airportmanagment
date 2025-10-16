using AM.applicationcore.domaine;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.infra.Configurations
{
    public class PlaneConfiguration : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {

            builder.HasKey(pk=>pk.PLaneiD);//config clee primaire
            builder.ToTable("MyPlanes");
            builder.Property(p => p.Capacity)
                .HasColumnName("PlaneCapacity").IsRequired();
        }
    }
}
