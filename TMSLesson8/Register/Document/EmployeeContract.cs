namespace TMSLesson8
{
    public class EmployeeContract : Document
    {
        private string number = string.Empty;
        private DateTime date;
        private DateTime endDate;
        private string employeeName = string.Empty;

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

        public DateTime EndDate
        {
            get { return endDate; }
            set
            {
                if (value > date)
                {
                    endDate = value;
                }
                else
                {
                    Console.WriteLine("Дата окончания не может быть раньше даты начала");
                }
            }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public EmployeeContract() 
        {
            this.Number = "EC000000";
            this.EmployeeName = string.Empty;
            this.Date = DateTime.Now.Date;
            this.EndDate = DateTime.Now.Date.AddYears(5);
        }

        public EmployeeContract(string number, string employeeName, DateTime date, DateTime endDate)
        {
            this.Number = number;
            this.EmployeeName = employeeName;
            this.Date = date;
            this.EndDate = endDate;
        }

    }
}
