
namespace Example.ViewModel {
    public class MainViewModel {
        public virtual string Parameter1 { get; set; }
        public virtual string Parameter2 { get; set; }
        public void ChangeParameter1() {
            counter1++;
            Parameter1 = "Parameter #" + counter1.ToString();
        }
        public void ChangeParameter2() {
            counter2++;
            Parameter2 = "Parameter #" + counter2.ToString();
        }

        int counter1 = 0;
        int counter2 = 0;
    }
}
