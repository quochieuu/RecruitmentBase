using System;
using System.Collections.Generic;
using System.Text;

using Recruitment.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Recruitment.Data.Configurations
{
    public class Job_CandidateConfiguration : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.ToTable("Candidates");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedOn).IsRequired();
        }
    }
}