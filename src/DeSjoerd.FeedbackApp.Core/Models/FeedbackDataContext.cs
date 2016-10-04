using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeSjoerd.FeedbackApp.Core.Models
{
    public class FeedbackDataContext : DbContext
    {
        public FeedbackDataContext(DbContextOptions<FeedbackDataContext> options)
            : base(options)
        { }

        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
