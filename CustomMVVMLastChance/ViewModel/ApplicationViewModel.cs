using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CustomMVVMLastChance.Model;


namespace CustomMVVMLastChance.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        
        public ObservableCollection<FileInfo> files { get; set; }

        private FileInfo _selectedFile;
        public FileInfo selectedFile
        {
            get
            {
                return _selectedFile;
            }
            set
            {
                _selectedFile = value;
                OnPropertyChanged("selectedFile");
            }
        }

        public ApplicationViewModel()
        {
            files = new ObservableCollection<FileInfo>
            {
                new FileInfo{Id = 1 , Name = "Film", Size = 100 },
                new FileInfo{Id = 2 , Name = "Game", Size = 200 },
                new FileInfo{Id = 3 , Name = "Photo", Size = 300 },
                new FileInfo{Id = 4 , Name = "Word", Size = 400 },
                new FileInfo{Id = 5 , Name = "Excel", Size = 500 },
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
