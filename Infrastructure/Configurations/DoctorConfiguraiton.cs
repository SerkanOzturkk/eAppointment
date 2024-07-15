using eAppointmentServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eAppointmentServer.Infrastructure.Configurations
{
    internal sealed class DoctorConfiguraiton : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(p => p.FirstName).HasColumnName("varchar(50)");
            builder.Property(p => p.LastName).HasColumnName("varchar(50)");
            //builder.HasIndex(x => new { x.FirstName, x.LastName }).IsUnique();
        }
    }
}