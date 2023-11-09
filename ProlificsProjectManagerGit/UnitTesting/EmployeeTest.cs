using PPM.Domain;
using PPM.Main;
using PPM.Model;
using PPM.UI;

public class EmployeeTest
{
    [Test]
    public void AddEmployeeTest()
    {
        Employee empObj = new Employee();
        EmployeeRepo employeeRepoObj = new EmployeeRepo();
        empObj.EmployeeId = 11;
        empObj.EmployeeFirstName = "Sandeep";
        empObj.EmployeeLastName = "Goud";
        empObj.Email = "Span@gmail.com";
        empObj.MobileNumber = 6547984324;
        empObj.Address = "Hyd";
        empObj.RoleId = 1;

        employeeRepoObj.Add(empObj);

        Assert.That(EmployeeRepo.employeeList.Count, Is.EqualTo(1));
        Assert.That(EmployeeRepo.employeeList[0].EmployeeId, Is.EqualTo(11));
        Assert.That(EmployeeRepo.employeeList[0].EmployeeFirstName, Is.EqualTo("Sandeep"));
        Assert.That(EmployeeRepo.employeeList[0].EmployeeLastName, Is.EqualTo("Goud"));
        Assert.That(EmployeeRepo.employeeList[0].Email, Is.EqualTo("Span@gmail.com"));
        Assert.That(EmployeeRepo.employeeList[0].MobileNumber, Is.EqualTo(6547984324));
        Assert.That(EmployeeRepo.employeeList[0].Address, Is.EqualTo("Hyd"));
        Assert.That(EmployeeRepo.employeeList[0].RoleId, Is.EqualTo(1));
    }

    [Test]
    public void viewEmployee()
    {
        var details=ConsoleUIs.ViewEmployees();
        Assert.That(details.Count,Is.EqualTo(1));
    }

   
}
