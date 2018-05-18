using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace TriviaExperiment.Models
{
    public class QuestionsModel
    {
        public QuestionsModel()
        {
        }

		public int ID { get; set; }
		public bool IsAnswered { get; set; }
		public string Question { get; set; }
		public List<AnswerOptionModel> Answers { get; set; } = new List<AnswerOptionModel>();


		public static async Task<ObservableCollection<QuestionsModel>> ObtenerPreguntas()
		{
			ObservableCollection<QuestionsModel> lstQuestions = new ObservableCollection<QuestionsModel>();
            
            //QUESTION 1
			AnswerOptionModel ans1Q1 = new AnswerOptionModel { ID = 1, Answer = "Question 1, Answer 1", IsCorrect = false };
			AnswerOptionModel ans2Q1 = new AnswerOptionModel { ID = 2, Answer = "Question 1, Answer 2", IsCorrect = false};
			AnswerOptionModel ans3Q1 = new AnswerOptionModel { ID = 3, Answer = "Question 1, Answer 3", IsCorrect = true };
			AnswerOptionModel ans4Q1 = new AnswerOptionModel { ID = 4, Answer = "Question 1, Answer 4", IsCorrect = false };
                     
			QuestionsModel Question1 = new QuestionsModel { ID = 1, Question = "Question 1", IsAnswered = false, Answers = new List<AnswerOptionModel> {ans1Q1,ans2Q1,ans3Q1,ans4Q1}};
            
            //QUESTION 2
			AnswerOptionModel ans1Q2 = new AnswerOptionModel { ID = 1, Answer = "Question 2, Answer 1", IsCorrect = false, IsSelected = false };
            AnswerOptionModel ans2Q2 = new AnswerOptionModel { ID = 2, Answer = "Question 2, Answer 2", IsCorrect = true, IsSelected = false };
            AnswerOptionModel ans3Q2 = new AnswerOptionModel { ID = 3, Answer = "Question 2, Answer 3", IsCorrect = false, IsSelected = false };
            AnswerOptionModel ans4Q2 = new AnswerOptionModel { ID = 4, Answer = "Question 2, Answer 4", IsCorrect = false, IsSelected = false };
            
            QuestionsModel Question2 = new QuestionsModel { ID = 2, Question = "Question 2", IsAnswered = false, Answers = new List<AnswerOptionModel> { ans1Q2, ans2Q2, ans3Q2, ans4Q2 } };

            //QUESTION 3
			AnswerOptionModel ans1Q3 = new AnswerOptionModel { ID = 1, Answer = "Question 3, Answer 1", IsCorrect = false, IsSelected = false };
            AnswerOptionModel ans2Q3 = new AnswerOptionModel { ID = 2, Answer = "Question 3, Answer 2", IsCorrect = false, IsSelected = false };
            AnswerOptionModel ans3Q3 = new AnswerOptionModel { ID = 3, Answer = "Question 3, Answer 3", IsCorrect = true, IsSelected = false };
            AnswerOptionModel ans4Q3 = new AnswerOptionModel { ID = 4, Answer = "Question 3, Answer 4", IsCorrect = false, IsSelected = false };
            
            QuestionsModel Question3 = new QuestionsModel { ID = 3, Question = "Question 3", IsAnswered = false, Answers = new List<AnswerOptionModel> { ans1Q3, ans2Q3, ans3Q3, ans4Q3 } };


			lstQuestions.Add(Question1);
			lstQuestions.Add(Question2);
			lstQuestions.Add(Question3);

			Task.Delay(1000);

			return lstQuestions;
         
		}
    }
}
