using PPM.Domain;

namespace PPM.UI
{
    public class ConsoleAddEmployeeToProject
    {
        public  void AddingEmployeeToProject()
        {
            ProjectRepo projectObj = new();
            EmployeeRepo employeeObj = new();
            Console.WriteLine("Enter the ProjectId");
            int pid = int.Parse(Console.ReadLine());
            while (true)
            {
                if (projectObj.IsProject(pid))
                {
                    Console.WriteLine("Enter the EmployeeId");
                    int emp = int.Parse(Console.ReadLine());
                    var emp1 = employeeObj.GetById(emp);
                    if (emp1.RoleId != 0)
                    {
                    projectObj.AddEmployeeToProject(pid, emp1);
                    Console.WriteLine("Employee is added Successfully to the Project");
                    }
                    else
                    {
                        System.Console.WriteLine("The EmployeeId doesnot Exist");

                    }
                  
                }
                else
                {
                    Console.WriteLine("Enter the Valid ProjectId");
                    break;
                }
                break;
            }
        }
        
    }
}
