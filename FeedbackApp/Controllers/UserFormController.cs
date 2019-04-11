using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedbackApp.Interfaces.Services;
using FeedbackApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackApp.Controllers
{
    [Route("api/UserForm")]
    public class UserFormController : Controller
    {
        //add code first migration
        //design the user page
        //design the admin page using ng-prime
        //add authentication
        private IFBAnswerService _fbAnswerService;

        public UserFormController(IFBAnswerService iFBAnswerService)
        {
            _fbAnswerService = iFBAnswerService;
        }

        [HttpGet("[action]")]
        public UserFormData Get()
        {
            var data = new UserFormData()
            {
                UserName = "Prasad Bhalerao",
                QuestionsList = new List<QuestionViewModel>()
                {
                    new QuestionViewModel()
                    {
                        Question = "How was your exp?",
                        Answer = "Great!",
                        AnswerId = 1,
                        QuestionId = 1
                    },
                    new QuestionViewModel()
                    {
                        Question = "How was your exp?",
                        Answer = "Great!",
                        AnswerId = 1,
                        QuestionId = 1
                    },
                    new QuestionViewModel()
                    {
                        Question = "How was your exp?",
                        Answer = "Great!",
                        AnswerId = 1,
                        QuestionId = 1
                    },
                }
            };

            return data;
        }
    }
}
