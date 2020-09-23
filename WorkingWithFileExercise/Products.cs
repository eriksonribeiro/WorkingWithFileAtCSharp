using System.Globalization;
namespace WorkingWithFileExercise
{
  public  class Products
    {
        private string _name { get; set; }
        private double _price { get; set; }
        private int _quantity { get; set; }

        public Products(string name, double price, int quantity)
        {
            this._name = name;
            this._price = price;
            this._quantity = quantity;
        }

        public double Amount()
        { 
           return _price * _quantity;
        }

        public override string ToString()
        {
            return _name +", "+ Amount().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
