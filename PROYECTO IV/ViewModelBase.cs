using System.ComponentModel;

namespace PROYECTO_IV
{
    class ViewModelBase : INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
}
    