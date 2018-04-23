using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace Example.ViewModel {
    public class ChildPOCOViewModel : ISupportParameter {
        [ServiceProperty(SearchMode=ServiceSearchMode.PreferParents)]
        protected virtual IMessageBoxService MessageBoxService { get { return null; } }
        public virtual object Parameter { get; set; }

        protected virtual void OnParameterChanged() {
            if(Parameter is string)
                MessageBoxService.Show("ChildPOCOViewModel: Parameter = " + (string)Parameter);
        }
    }
}
