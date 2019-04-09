using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;
using FeedbackApp.Persistence.Models;

namespace FeedbackApp.Persistence
{
    public class FeedbackDBContext : DbContext
    {
        public FeedbackDBContext(DbContextOptions options) : base(options)
        {
                    
        }
        public DbSet<FBQuestion> FBQuestions { get; set; }
        public DbSet<FBAnswer> FBAnswers { get; set; }
    }
}
