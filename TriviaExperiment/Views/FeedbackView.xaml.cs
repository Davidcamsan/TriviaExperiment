using System;
using System.Collections.Generic;
using TriviaExperiment.ViewModels;

using Xamarin.Forms;

namespace TriviaExperiment.Views
{
    public partial class FeedbackView : ContentPage
    {
        public FeedbackView()
        {
            InitializeComponent();
			BindingContext = QuestionsViewModel.GetInstance();
        }
    }
}
