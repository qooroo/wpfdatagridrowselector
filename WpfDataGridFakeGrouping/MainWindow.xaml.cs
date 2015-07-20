using System.Collections.ObjectModel;

namespace WpfDataGridFakeGrouping
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            var vm = new Vm();
            vm.Rows = new ObservableCollection<RowBase>
            {
                new GroupingRow {Header = "Grouped header"},
                new DefaultRow {Name = "Bob", Number = 123},
                new DefaultRow {Name = "Alice", Number = 456}
            };

            DataContext = vm;
        }
    }

    public class Vm
    {
        public ObservableCollection<RowBase> Rows { get; set; }
    }

    public class RowBase
    {
    }

    public class DefaultRow : RowBase
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }

    public class GroupingRow : RowBase
    {
        public string Header { get; set; }
    }
}
