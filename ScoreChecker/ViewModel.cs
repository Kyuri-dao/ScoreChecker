using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ScoreChecker
{
    internal partial class ViewModel : ObservableObject, INotifyPropertyChanged
    {
        [ObservableProperty]
        private string? description = "計算式：240 - (前期中間 + 前期期末 + 後期中間)";

        [ObservableProperty]
        private string? enterFirstScore;
        [ObservableProperty]
        private string? enterSecondScore;
        [ObservableProperty]
        private string? enterThirdScore;

        [ObservableProperty]
        private string? viewResult = "ここに結果が表示されます";

        [RelayCommand]
        private void OnClickedViewResult()
        {
            if (enterFirstScore == null)
            {
                enterFirstScore = "0";
            }
            if (enterSecondScore == null)
            {
                enterSecondScore = "0";
            }
            if (enterThirdScore == null)
            {
                enterThirdScore = "0";
            }

            int FirstInt = int.Parse(EnterFirstScore);
            int SecondInt = int.Parse(EnterSecondScore);
            int ThirdInt = int.Parse(EnterThirdScore);


            int ResultInt = 240 - (FirstInt + SecondInt + ThirdInt);

            ResultInt.ToString();

            ViewResult = $"あと{ResultInt}点必要です！";
        }

        

    }
}
