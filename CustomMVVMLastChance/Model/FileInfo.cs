using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CustomMVVMLastChance.Model
{
    public class FileInfo : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private int _size;

        public int Id { 
            get 
            {
                return _id;
            } 
            set 
            {
                _id = value;
                OnPropertyChanged("Id");
            } 
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
                OnPropertyChanged("Value");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
