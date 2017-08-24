using PropertyChanged;
using System.ComponentModel;

namespace WpfFolderFileHierarchy
{
    /// <summary>
    ///  A base view model that fires Property Changed events as needed
    /// </summary>
    [AddINotifyPropertyChangedInterfaceAttribute]
  

    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        ///  The event is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
