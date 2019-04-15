using FeedbackApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackApp.Interfaces.Services
{
    public interface IFBAnswerService
    {
        UserFormData GetUserFormData(int userId);
        bool SaveUserFormData(UserFormData userFormData);
    }
}
