namespace TMSLesson8
{
    public class SupplyContract : Document
    {
        private string number = string.Empty;
        private DateTime date;
        private int productTypeId;
        private int productCount;

        public override string Number 
        {
            get { return number; }
            set { number = value; }
        }

        public override DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int ProductTypeId
        {
            get { return productTypeId; }
            set { productTypeId = value; }
        }

        public int ProductCount 
        {
            get { return productCount; }
            set
            {
                if (value >= 0)
                {
                    productCount = value;
                }
                else
                {
                    Console.WriteLine("Количество не может быть меньше нуля");
                }
            }
        }

        public SupplyContract() 
        {
            this.Number = "SC000000";
            this.Date = DateTime.Now.Date;
            this.ProductTypeId = 0;
            this.ProductCount = 0;
        }

        public SupplyContract(string number, DateTime date, int productType, int productCount)
        {
            this.Number = number;
            this.Date = date;
            this.ProductTypeId = productType;
            this.ProductCount = productCount;
        }
    }
}
