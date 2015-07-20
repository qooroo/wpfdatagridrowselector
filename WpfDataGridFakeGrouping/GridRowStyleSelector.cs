using System.Windows;
using System.Windows.Controls;

namespace WpfDataGridFakeGrouping
{
    public class GridRowStyleSelector : StyleSelector
    {
        public Style DefaultRowStyle { get; set; }

        public Style GroupHeaderRowStyle { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            var groupingRow = item as GroupingRow;

            return groupingRow != null ? GroupHeaderRowStyle: DefaultRowStyle;
        }
    }
}
