using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recruitment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Data.Configurations
{
    public class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder.ToTable("Feedbacks");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CommentOn).IsRequired();

        }
    }
}
