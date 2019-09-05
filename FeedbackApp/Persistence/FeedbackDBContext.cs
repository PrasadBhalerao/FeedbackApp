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
                new FBQuestion() { KeyID = 1, Question = "How do you rate your experience with C#?" },
                new FBQuestion() { KeyID = 3, Question = "How do you rate your experience with Java?" },
                new FBQuestion() { KeyID = 2, Question = "How do you rate your experience with Javascript?" },
                new FBQuestion() { KeyID = 4, Question = "How do you rate your experience with AngularJS?" },
                new FBQuestion() { KeyID = 5, Question = "How do you rate your experience with Angular?" },
                new FBQuestion() { KeyID = 6, Question = "How do you rate your experience with SQL?" },
                new FBQuestion() { KeyID = 7, Question = "How do you rate your experience with MongoDB?" });

            modelBuilder.Entity<User>().HasData(
                new User() { KeyID = 1, UserName = "Prasad Bhalerao" });

            base.OnModelCreating(modelBuilder);

        }
    }
}
