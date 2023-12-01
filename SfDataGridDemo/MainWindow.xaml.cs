using System.Windows;

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Remove the default numeric cell renderer
            this.sfDataGrid.CellRenderers.Remove("Numeric");
            // Add the custom numeric cell renderer
            this.sfDataGrid.CellRenderers.Add("Numeric", new GridCellNumericRendererExt());
        }
    }    
}