using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.Windows.Shared;
using System.Windows.Controls;

namespace SfDataGridDemo
{
    //Custom numeric cell renderer
    public class GridCellNumericRendererExt : GridCellNumericRenderer
    {
        // Override the OnInitializeDisplayElement method
        public override void OnInitializeDisplayElement(DataColumnBase dataColumn, TextBlock uiElement, object dataContext)
        {

            base.OnInitializeDisplayElement(dataColumn, uiElement, dataContext);
            // Get the value from the datacontext
            var value = (double)dataContext.GetType().GetProperty(dataColumn.GridColumn.MappingName).GetValue(dataContext, null);

            // Check whether the value is infinity or not
            if (double.IsInfinity(value))
            {
                // Set the text as infinity
                uiElement.Text = value.ToString();
            }
        }

        // Override the OnInitializeEditElement method
        public override void OnInitializeEditElement(DataColumnBase dataColumn, DoubleTextBox uiElement, object dataContext)
        {
            base.OnInitializeEditElement(dataColumn, uiElement, dataContext);

            // Get the value from the datacontext
            var value = (double)dataContext.GetType().GetProperty(dataColumn.GridColumn.MappingName).GetValue(dataContext, null);

            // Check whether the value is infinity or not
            if (double.IsInfinity(value))
            {
                // Set the max and min values as infinity
                uiElement.MaxValue = double.PositiveInfinity;
                uiElement.MinValue = double.NegativeInfinity;
            }
        }
    }
}