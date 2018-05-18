using System;
using TriviaExperiment.Models;
using System.Linq;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Windows.Input;
using TriviaExperiment.Views;

namespace TriviaExperiment.ViewModels
{
	public class QuestionsViewModel : INotifyPropertyChanged
    {

		#region Singleton

		private static QuestionsViewModel instance = null;

		public QuestionsViewModel()
        {
            InitClass();
            InitCommands();
        }
              
        public static QuestionsViewModel GetInstance()
        {
            if (instance == null)
				instance = new QuestionsViewModel();

            return instance;
        }

        public static void DeleteInstance()
        {
            if (instance != null)
                instance = null;
        }

		#endregion



		#region Instances

        //LISTA DE PREGUNTAS
		private ObservableCollection<QuestionsModel> _lstQuestions = new ObservableCollection<QuestionsModel>();
		public ObservableCollection<QuestionsModel> lstQuestions
		{
			get { return _lstQuestions; }
			set
			{
				_lstQuestions = value;
				OnPropertyChanged("lstQuestions");
			}
		}

		private ObservableCollection<QuestionsModel> _lstQuestionsIncorrect = new ObservableCollection<QuestionsModel>();
        public ObservableCollection<QuestionsModel> lstQuestionsIncorrect
        {
			get { return _lstQuestionsIncorrect; }
            set
            {
                _lstQuestions = value;
                OnPropertyChanged("lstQuestionsIncorrect");
            }
        }

		//PREGUNTA ESCOGIDA
		private QuestionsModel _CurrentQuestion = new QuestionsModel();
		public QuestionsModel CurrentQuestion 
		{
			get { return _CurrentQuestion; }
			set
			{
				_CurrentQuestion = value;
				OnPropertyChanged("CurrentQuestion");	
			}
		}

		//LISTA DE RESPUESTAS DE PREGUNTA ESCOGIDA
		private ObservableCollection<AnswerOptionModel> _lstAnswers = new ObservableCollection<AnswerOptionModel>();
		public ObservableCollection<AnswerOptionModel> lstAnswers
		{
			get { return _lstAnswers; }
			set
			{
				_lstAnswers = value;
				OnPropertyChanged("lstAnswers");   
			}
		}

		private AnswerOptionModel _CurrentAnswer = new AnswerOptionModel();
        public AnswerOptionModel CurrentAnswer
        {
			get { return _CurrentAnswer; }
            set
            {
                _CurrentAnswer = value;
                OnPropertyChanged("CurrentAnswer");
            }
        }




		private bool _IsAnswered { get; set; } = false;
		public bool IsAnswered
		{
			get { return _IsAnswered; }
			set
			{
				_IsAnswered = value;
				OnPropertyChanged("IsAnswered");
			}
		}


		private bool _IsCorrect { get; set; }
        public bool IsCorrect
        {
            get { return _IsCorrect; }
            set
            {
                _IsCorrect = value;
                OnPropertyChanged("IsCorrect");
            }
        }


		#endregion

		public ICommand SelectAnswerCommand { get; set; }
        
		private void SelectAnswer(int id)
		{
			CurrentAnswer = lstAnswers.Where(x => x.ID == id).FirstOrDefault();
            CurrentAnswer.IsSelected = true;

            OnPropertyChanged("lstAnswers");

			App.Current.MainPage = new LevelView();



		}



		public ICommand SubmitAnswerCommand { get; set; }

		private void SubmitAnswer()
		{
			AnswerOptionModel Correct = lstAnswers.Where(x => x.IsCorrect == true).FirstOrDefault();
			if (CurrentAnswer.ID != Correct.ID)
				IsCorrect = false;
			else
				IsCorrect = true;
			


			App.Current.MainPage = new FeedbackView();
		}
       

		private async void InitClass()
        {
			lstQuestions = await QuestionsModel.ObtenerPreguntas();
			CurrentQuestion = lstQuestions.First();
			lstAnswers = new ObservableCollection<AnswerOptionModel>(CurrentQuestion.Answers);
        }

		private void InitCommands()
		{
			SubmitAnswerCommand = new Command(SubmitAnswer);
			SelectAnswerCommand = new Command<int>(SelectAnswer);
		}



		#region INotifyPropertyChange Interface

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }

        #endregion
    }
}
