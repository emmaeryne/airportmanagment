using AM.applicationcore.domaine;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.infra.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasMany(p => p.Passengers)
                 .WithMany(f => f.Flights)
                 .UsingEntity(t=>t.ToTable("MyReservation"));
            builder.HasOne(p => p.Plane).WithMany(a => a.Flights)
                .HasForeignKey(f => f.PlaneFk);



        }
    }
}
