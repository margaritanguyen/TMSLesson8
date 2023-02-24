namespace TMSLesson8
{
    public class FinancialInvoice : Document
    {
        private string number = string.Empty;
        private DateTime date;
        private int departmentCode;
        private decimal sum;

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

        public int DepartmentCode
        {
            get { return departmentCode; }
            set { departmentCode = value; }
        }

        public decimal Sum
        {
            get { return sum; }
            set
            {
                if (value >= 0)
                {
                    sum = value;
                }
                else
                {
                    Console.WriteLine("Сумма не может быть меньше нуля");
                }
            }
        }

        public FinancialInvoice() 
        {
            this.Number = "FI000000";
            this.Date = DateTime.Now.Date;
            this.DepartmentCode = 0;
            this.Sum = 0M;
        }

        public FinancialInvoice(string number, DateTime date, int departmentCode, int sum)
        {
            this.Number = number;
            this.Date = date;
            this.DepartmentCode = departmentCode;
            this.Sum = sum;
        }
    }
}
