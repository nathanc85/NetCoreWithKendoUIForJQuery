namespace NetCoreWithKendoUIForJQuery.Models
{
    public class EmployeeRepository
    {
        public List<EmployeeModel> GetAllEmployees()
        {
            var employeesList = new List<EmployeeModel>() {
                new EmployeeModel() { ID = 1, Name = "Tom", HireDate = "10/15/2022" },
                new EmployeeModel() { ID = 2, Name = "John", HireDate = "11/25/2022" },
                new EmployeeModel() { ID = 3, Name = "Annie", HireDate = "05/09/2022" },
                new EmployeeModel() { ID = 4, Name = "Rachel", HireDate = "08/06/2022" },
                new EmployeeModel() { ID = 5, Name = "Klemens", HireDate = "10/07/2022" },
                new EmployeeModel() { ID = 6, Name = "Micah", HireDate = "05/19/2022" },
                new EmployeeModel() { ID = 7, Name = "Junie", HireDate = "04/04/2022" },
                new EmployeeModel() { ID = 8, Name = "Krishnah", HireDate = "07/19/2022" },
                new EmployeeModel() { ID = 9, Name = "Enrichetta", HireDate = "01/11/2022" },
                new EmployeeModel() { ID = 10, Name = "Marten", HireDate = "02/13/2022" },
                new EmployeeModel() { ID = 11, Name = "Rosmunda", HireDate = "08/15/2022" },
            };

            return employeesList;
        }
    }
}
