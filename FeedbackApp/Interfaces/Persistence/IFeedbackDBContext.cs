using FeedbackApp.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackApp.Interfaces.Persistence
{
    public interface IFeedbackDBContext
    {
        DbSet<FBQuestion> FBQuestions { get; set; }
        DbSet<FBAnswer> FBAnswers { get; set; }
    }
}
