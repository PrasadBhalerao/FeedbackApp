using FeedbackApp.Interfaces.Persistence;
using FeedbackApp.Interfaces.Services;
using FeedbackApp.ViewModels;
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

        public UserFormData GetUserFormData(int userId)
        {
            throw new NotImplementedException();
        }

        public bool SaveUserFormData(UserFormData userFormData)
        {
            throw new NotImplementedException();
        }
    }
}
