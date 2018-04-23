using DevExpress.Mvvm;

namespace Example.ViewModel {
    public class ChildViewModelBase : ViewModelBase {
        IMessageBoxService MessageBoxService { get { return GetService<IMessageBoxService>(ServiceSearchMode.PreferParents); } }
        protected override void OnParameterChanged(object parameter) {
            base.OnParameterChanged(parameter);
            if(parameter is string)
                MessageBoxService.Show("ChildViewModelBase: Parameter = " + (string)parameter);
        }
    }
}
