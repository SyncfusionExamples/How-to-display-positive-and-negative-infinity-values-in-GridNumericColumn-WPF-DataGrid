using System.ComponentModel;

namespace SfDataGridDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        double orderID;
        string customerId;
        string country;
        string customerName;
        int unitPrice;
        
        public double OrderID
        {
            get { return orderID; }
            set
            {
                orderID = value;
                OnPropertyChanged("OrderID");
            }
        }
        
        public string CustomerID
        {
            get { return customerId; }
            set
            {
                customerId = value;
                OnPropertyChanged("CustomerID");
            }
        }
        
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                OnPropertyChanged("CustomerName");
            }
        }
        
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }
        
        public int UnitPrice
        {
            get { return unitPrice; }
            set
            {
                unitPrice = value;
                OnPropertyChanged("UnitPrice");
            }
        }

        public OrderInfo()
        {
                
        }

        public OrderInfo(double orderId, string customerName, string country, string customerId, int unitPrice)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerID = customerId;
            this.UnitPrice = unitPrice;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}