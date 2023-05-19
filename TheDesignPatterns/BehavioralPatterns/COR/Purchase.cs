namespace TheDesignPatterns.BehavioralPatterns.COR
{
    public class Purchase
    {
        public int number;
        public double price;
        public string purpose;
        public Purchase(int _number, double _price, string _purpose)
        {
            number = _number;
            price = _price;
            purpose = _purpose;
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Purpose
        {
            get { return purpose; }
            set { purpose = value;}
        }
    }
    
}