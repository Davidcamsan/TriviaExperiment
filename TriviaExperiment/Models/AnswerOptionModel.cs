using System;
using Xamarin.Forms;
namespace TriviaExperiment.Models
{
    public class AnswerOptionModel
    {
        public AnswerOptionModel()
        {
        }

		public int ID { get; set; }
		public string Answer { get; set; }
		public bool IsSelected { get; set; }
		public bool IsCorrect { get; set; }
    }
}
