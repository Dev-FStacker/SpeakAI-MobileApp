﻿using SpeakAI.Services.Interfaces;
using SpeakAI.ViewModels;

namespace SpeakAI.Views;

public partial class ExerciseDetailPage : ContentPage
{
	public ExerciseDetailPage(ICourseService courseService)
	{
		InitializeComponent();
        var viewModel = new ExerciseDetailViewModel(courseService);
        BindingContext = viewModel;
        if (BindingContext == null)
        {
            Console.WriteLine("BindingContext not set properly.");
        }
    }
    private void OnOptionSelected(object sender, CheckedChangedEventArgs e)
    {
        if (sender is RadioButton radioButton && radioButton.IsChecked)
        {
            if (BindingContext is ExerciseDetailViewModel viewModel)
            {
                viewModel.SelectedAnswer = radioButton.Content.ToString();
            }
        }
    }
    private void _OnCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is RadioButton radioButton && e.Value)
        {
            var selectedAnswer = radioButton.Content.ToString().ToLower();

            if (BindingContext is ExerciseDetailViewModel viewModel && viewModel.SelectedAnswer != selectedAnswer)
            {
                viewModel.SelectedAnswer = selectedAnswer;
                Console.WriteLine($"[DOTNET] SelectedAnswer set to: {viewModel.SelectedAnswer}");
            }
        }
    }
}