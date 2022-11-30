using Day_36_EmployeePayRoll_Threading;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        EmployeePayroll employeePayrollDatabase = new EmployeePayroll();
        [TestMethod]
        public void GivenEmployeeList_InAddingEmployeeMethod_ReturnSameListThatisAdded()
        {
            List<EmployeeDetails> employeesListToBeAddedToDB = new List<EmployeeDetails>();
            employeesListToBeAddedToDB.Add(new EmployeeDetails { employeeName = "mahehs", gender = "M", phoneNo = 9811223344, employeeAddress = "9b nagar, Maharashtra", startDate = DateTime.Now, basicPay = 1800000, deductions = 250000, incomeTax = 150000, companySelect = 1, employeeSelect = 18, departmentSelect = 2, });
            employeesListToBeAddedToDB.Add(new EmployeeDetails { employeeName = "Rajesj", gender = "M", phoneNo = 9812343344, employeeAddress = "9b nagar, Maharashtra", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 3, employeeSelect = 19, departmentSelect = 4, });
            employeesListToBeAddedToDB.Add(new EmployeeDetails { employeeName = "Akshay", gender = "M", phoneNo = 9811123344, employeeAddress = "9b nagar, Maharashtra", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 2, employeeSelect = 20, departmentSelect = 3, });
            employeesListToBeAddedToDB.Add(new EmployeeDetails { employeeName = "Himanshu", gender = "M", phoneNo = 9811223344, employeeAddress = "9b nagar, Maharashtra", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 1, employeeSelect = 21, departmentSelect = 2, });
            employeesListToBeAddedToDB.Add(new EmployeeDetails { employeeName = "Sheetal", gender = "F", phoneNo = 9818765344, employeeAddress = "9b nagar, Maharashtra", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 5, employeeSelect = 22, departmentSelect = 3, });
            employeesListToBeAddedToDB.Add(new EmployeeDetails { employeeName = "Pramod", gender = "M", phoneNo = 9811234564, employeeAddress = "9b nagar, Maharashtra", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 4, employeeSelect = 23, departmentSelect = 4, });
            employeesListToBeAddedToDB.Add(new EmployeeDetails { employeeName = "Gaurav", gender = "M", phoneNo = 9811123454, employeeAddress = "9b nagar, Maharashtra", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 3, employeeSelect = 24, departmentSelect = 2, });
            employeesListToBeAddedToDB.Add(new EmployeeDetails { employeeName = "Poonam", gender = "F", phoneNo = 9814545344, employeeAddress = "9b nagar, Maharashtra", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 2, employeeSelect = 25, departmentSelect = 4, });
            employeesListToBeAddedToDB.Add(new EmployeeDetails { employeeName = "Manoj", gender = "F", phoneNo = 9899776344, employeeAddress = "9b nagar, Maharashtra", startDate = DateTime.Now, basicPay = 1200000, deductions = 200000, incomeTax = 100000, companySelect = 3, employeeSelect = 26, departmentSelect = 3, });

            //DateTime startDateTime = DateTime.Now;
            //Console.WriteLine($"Data Addition to DB started on {startDateTime}");
            //employeePayrollDatabase.AddEmployeeListToDBWithoutThread(employeesListToBeAddedToDB);
            //DateTime endDateTime = DateTime.Now;
            //Console.WriteLine($"Data Addition to DB ended on {endDateTime}");
            //Console.WriteLine($"Time for Adding Data to DB is {endDateTime - startDateTime}");

            DateTime startDateTime1 = DateTime.Now;
            Console.WriteLine($"Data Addition to DB started on {startDateTime1}");
            employeePayrollDatabase.AddEmployeeListToDBWithThread(employeesListToBeAddedToDB);
            DateTime endDateTime1 = DateTime.Now;
            Console.WriteLine($"Data Addition to DB ended on {endDateTime1}");
            Console.WriteLine($"Time for Adding Data to DB is {endDateTime1 - startDateTime1}");
        }
    }
}