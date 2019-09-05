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

        [Route("Get/{id}")]
        [HttpGet]
        public UserFormData Get([FromRoute]int id)
        {
            var data = _fbAnswerService.GetUserFormData(id);

            return data;
        }

        [HttpPost]
        public bool Post([FromBody] UserFormData userFormData)
        {
            return _fbAnswerService.SaveUserFormData(userFormData);
        }
    }
}
