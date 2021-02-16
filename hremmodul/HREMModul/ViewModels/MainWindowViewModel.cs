using System.Threading.Tasks;
using System.Windows;
using Prism.Commands;
using Prism.Mvvm;

namespace HREMModul.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        string messageBoxText = "Vil du gemme patienten i Høremappen?";
        string caption = "Gem patient i Høremappe ";
        MessageBoxButton button = MessageBoxButton.OKCancel;
        MessageBoxImage icon = MessageBoxImage.Warning;
        private string _title = "Høremappe modul";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            
            // Display message box
            
        }

        public DelegateCommand dialog => new DelegateCommand(async () => await ShowDialog());

        private async Task ShowDialog()
        {
            MessageBox.Show(messageBoxText, caption, button, icon);
        }
    }
}
