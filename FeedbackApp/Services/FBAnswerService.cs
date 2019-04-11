using FeedbackApp.Interfaces.Persistence;
using FeedbackApp.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackApp.Services
{
    public class FBAnswerService : IFBAnswerService
    {
        private IFeedbackDBContext _dbContext;

        public FBAnswerService(IFeedbackDBContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
