using System;
using System.Collections.Generic;
using System.Text;

using Recruitment.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Recruitment.Data.Configurations
{
    public class Job_JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.ToTable("Job_Jobs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Position).HasMaxLength(255).IsRequired();      
            builder.Property(x => x.CreatedOn).IsRequired();
        }
    }
}