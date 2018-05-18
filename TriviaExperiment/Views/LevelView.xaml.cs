using System;
using System.Collections.Generic;
using TriviaExperiment.ViewModels;

using Xamarin.Forms;

namespace TriviaExperiment.Views
{
    public partial class LevelView : ContentPage
    {
        public LevelView()
        {
            InitializeComponent();
			BindingContext = QuestionsViewModel.GetInstance();
        }
    }
}
