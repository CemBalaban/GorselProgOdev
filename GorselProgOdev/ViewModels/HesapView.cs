using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dangl.Calculator;
using GorselProgOdev.ViewModels.Common;
using System.Windows.Input;

namespace GorselProgOdev.ViewModels;

public partial class HesapView : BaseView
{
    [ObservableProperty]
    private string? _formula;

    [ObservableProperty]
    private string? _result;

    [RelayCommand]
    public void Operation(string operation)
    {
        Formula += operation;
    }

    public ICommand ResetCommand => new Command(() =>
    {
        Formula = string.Empty;
        Result = "0";
    });
    public ICommand BackSpaceCommand => new Command(() =>
    {
        if(Formula?.Length > 0) 
        {
                Formula= Formula.Substring(0, Formula.Length - 1);
        }
    });
    public ICommand CalculateCommand => new Command(() =>
    {
        if (Formula?.Length <= 0)
        {
            return;
        }
        var calculation = Calculator.Calculate(Formula);
        Result = calculation.Result.ToString();
    });

}