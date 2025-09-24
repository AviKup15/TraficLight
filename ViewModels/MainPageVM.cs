using System.Windows.Input;
using TraficLight.Models;

namespace TraficLight.ViewModels
{
    class MainPageVM : ObservableObject
    {
        private ModelsLogic.TraficLight tl = new();

        public ICommand ChangeLightCommand => new Command(ChangeLight);
        public ICommand SwitchAutoChangeCommand => new Command(SwitchAutoChange);
        public ICommand SetTimerCommand => new Command(SetTimer);

        private string _timerInput = string.Empty;
        public string TimerInput
        {
            get => _timerInput;
            set
            {
                _timerInput = value;
                OnPropertyChanged(nameof(TimerInput));
            }
        }

        private void SetTimer()
        {
            if (int.TryParse(TimerInput, out int seconds))
            {
                tl.SetTimerInterval(seconds);
            }
            else
            {
            }
        }

        private void SwitchAutoChange()
        {
            tl.SwitchAutoChange();
            OnPropertyChanged(nameof(SwitchChangeLightText));
        }

        public Color RedColor => tl.RedColor;
        public Color YellowColor => tl.YellowColor;
        public Color GreenColor => tl.GreenColor;
        public string LightImage => tl.LightImage;
        public string SwitchChangeLightText => tl.SwitchChangeLightText;

        private void ChangeLight()
        {
            tl.ChangeLight();
        }

        public MainPageVM() 
        {
            tl.LightChanged += OnLightChanged;
        }

        private void OnLightChanged(object? sender, LightChengedEventArgs e)
        {
            ColorChanged(e.Light);
        }

        private void ColorChanged(TraficLightModel.TraficLight light)
        {
            switch (light)
            {
                case TraficLightModel.TraficLight.Red:
                    OnPropertyChanged(nameof(RedColor));
                    break;
                case TraficLightModel.TraficLight.Yellow:
                    OnPropertyChanged(nameof(YellowColor));
                    break;
                case TraficLightModel.TraficLight.Green:
                    OnPropertyChanged(nameof(GreenColor));
                    break;
            }
            OnPropertyChanged(nameof(LightImage));
        }
    }
}
