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
        //add code first migration -> done
        //design the user page -> done
        //design the admin page using ng-prime
        //add authentication
        private IFBAnswerService _fbAnswerService;

        public UserFormController(IFBAnswerService iFBAnswerService)
        {
            _fbAnswerService = iFBAnswerService;
        }

        [Route("/Get/id")]
        [HttpGet("id")]
        public UserFormData Get([FromRoute] int id)
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
                        Question = "How was your exp2?",
                        Answer = "Great2!",
                        AnswerId = 2,
                        QuestionId = 2
                    },
                    new QuestionViewModel()
                    {
                        Question = "How was your exp3?",
                        Answer = "Great3!",
                        AnswerId = 3,
                        QuestionId = 3
                    },
                }
            };

            return data;
        }

        [HttpPost]
        public bool Post([FromBody] UserFormData userFormData)
        {
            return true;
        }
    }
}
