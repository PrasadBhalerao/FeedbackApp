using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackApp.ViewModels
{
    public class UserFormData
    {
        public string UserName { get; set; }
        public List<QuestionViewModel> QuestionsList { get; set; }
        public int UserId { get; set; }
    }

    public class QuestionViewModel
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
    }
}
