using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using FeedbackApp.Persistence.Models;
using FeedbackApp.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FeedbackApp.Persistence
{
    public class FeedbackDBContext : DbContext, IFeedbackDBContext
    {
        public FeedbackDBContext(DbContextOptions options) : base(options)
        {
                    
        }
        public DbSet<FBQuestion> FBQuestions { get; set; }
        public DbSet<FBAnswer> FBAnswers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FBQuestion>().HasData(
                new FBQuestion() { KeyID = 1, Question = "How was your exp1?" },
                new FBQuestion() { KeyID = 2, Question = "How was your exp2?" },
                new FBQuestion() { KeyID = 3, Question = "How was your exp3?" },
                new FBQuestion() { KeyID = 4, Question = "How was your exp4?" },
                new FBQuestion() { KeyID = 5, Question = "How was your exp5?" },
                new FBQuestion() { KeyID = 6, Question = "How was your exp6?" },
                new FBQuestion() { KeyID = 7, Question = "How was your exp7?" });

            modelBuilder.Entity<User>().HasData(
                new User() { KeyID = 1, UserName = "Prasad Bhalerao" });

            base.OnModelCreating(modelBuilder);

        }
    }
}
