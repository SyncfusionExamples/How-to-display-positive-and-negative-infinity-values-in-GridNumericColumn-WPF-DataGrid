using System.Collections.ObjectModel;

namespace SfDataGridDemo
{
    public class ViewModel
    {
        private ObservableCollection<OrderInfo> _orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public ViewModel()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo(double.PositiveInfinity, "Maria Anders", "Germany", "ALFKI", 25000));
            _orders.Add(new OrderInfo(double.NegativeInfinity, "Ana Trujilo", "Germany", "ANATR", 36000));
            _orders.Add(new OrderInfo(1003, "Antonio Moreno", "Germany", "ANTON", 40040));
            _orders.Add(new OrderInfo(1004, "Thomas Hardy", "Germany", "AROUT", 10700));
            _orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden", "BERGS", 20300));
        }
    }
}