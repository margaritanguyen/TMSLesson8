namespace TMSLesson8
{
    public class Register : IRegister
    {
        private Document[] documents = new Document[10];

        public void GetInformation(Document document)
        {
            if (document.GetType() == typeof(SupplyContract))
            {
                Console.WriteLine($"Номер документа: {((SupplyContract)document).Number}");
                Console.WriteLine($"Дата документа: {((SupplyContract)document).Date.ToString("dd.MM.yyyy")}");
                Console.WriteLine($"Тип продукта: {((SupplyContract)document).ProductTypeId}");
                Console.WriteLine($"Количество: {((SupplyContract)document).ProductCount}");
                Console.WriteLine();
                return;
            }

            if (document.GetType() == typeof(EmployeeContract))
            {
                Console.WriteLine($"Номер документа: {((EmployeeContract)document).Number}");
                Console.WriteLine($"Дата документа: {((EmployeeContract)document).Date.ToString("dd.MM.yyyy")}");
                Console.WriteLine($"Имя сотрудника: {((EmployeeContract)document).EmployeeName}");
                Console.WriteLine($"Дата окончания контракта: {((EmployeeContract)document).EndDate.ToString("dd.MM.yyyy")}");
                Console.WriteLine();
                return;
            }

            if (document.GetType() == typeof(FinancialInvoice))
            {
                Console.WriteLine($"Номер документа: {((FinancialInvoice)document).Number}");
                Console.WriteLine($"Дата документа: {((FinancialInvoice)document).Date.ToString("dd.MM.yyyy")}");
                Console.WriteLine($"Код департамента: {((FinancialInvoice)document).DepartmentCode}");
                Console.WriteLine($"Итоговая сумма за месяц: {((FinancialInvoice)document).Sum}");
                Console.WriteLine();
                return;
            }
        }

        public void Save(Document document)
        {
            int documentCount = documents.Where(x => x != null).Count();

            if (documentCount < 10)
            {
                documents[documentCount] = document;
            }
            else
            {
                Console.WriteLine("Регистр заполнен");
            }
        }
    }
}
