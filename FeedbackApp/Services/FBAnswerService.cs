using FeedbackApp.Interfaces.Persistence;
using FeedbackApp.Interfaces.Services;
using FeedbackApp.Persistence.Models;
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
            var userData = _dbContext.Users.Single(x => x.KeyID == userId);

            var questions = (from question in _dbContext.FBQuestions
                            join answer in _dbContext.FBAnswers
                            on question.KeyID equals answer.FBQuestionID into answers
                            from ans in answers.DefaultIfEmpty()
                            select new QuestionViewModel()
                            {
                                QuestionId = question.KeyID,
                                Question = question.Question,
                                AnswerId = ans != null ? ans.KeyID : 0,
                                Answer = ans != null ? ans.Answer : ""
                            }).ToList();

            var userFormData = new UserFormData()
            {
                QuestionsList = questions,
                UserId = userData.KeyID,
                UserName = userData.UserName
            };

            return userFormData;
        }

        public bool SaveUserFormData(UserFormData userFormData)
        {
            var answerIds = userFormData.QuestionsList.Where(x => x.AnswerId != 0).Select(x => x.AnswerId);

            //update old answers
            if (answerIds.Count() > 0)
            {
                var persistedAnswers = _dbContext.FBAnswers.Where(x => answerIds.Contains(x.KeyID)).ToList();

                foreach (var answer in persistedAnswers)
                {
                    answer.Answer = userFormData.QuestionsList.Single(x => x.AnswerId == answer.KeyID).Answer;
                }
            }

            var newAnswers = userFormData.QuestionsList.Where(x => x.AnswerId == 0 && x.Answer.Length > 0)
                            .Select(x => new
                            {
                                x.QuestionId,
                                x.Answer
                            });

            //add new answers
            foreach (var newAnswer in newAnswers)
            {
                var answer = new FBAnswer()
                {
                    FBQuestionID = newAnswer.QuestionId,
                    Answer = newAnswer.Answer,
                    UserID = userFormData.UserId
                };
                _dbContext.FBAnswers.Add(answer);
            }

            _dbContext.SaveChanges();

            return true;
        }
    }
}
