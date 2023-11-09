using PPM.Domain;

namespace PPM.UI
{
    public class ConsoleDeleteEmployeeFormProject
    {
        public  void DeleteEmployeeToProject()
        {
              ProjectRepo projectObj = new();
            EmployeeRepo employeeObj = new();
         Console.WriteLine("Enter the ProjectId");
                        int pid1 = int.Parse(Console.ReadLine());
                        while (true)
                        {
                            if (projectObj.IsProject(pid1))
                            {
                                Console.WriteLine("Enter the EmployeeId");
                                int emp = int.Parse(Console.ReadLine());
                                var emp1 = employeeObj.GetById(emp);
                                projectObj.DeleteEmployeeToProject( pid1,  emp1);
                                Console.WriteLine("Employee is Removed Successfully from the Project");
                                // break;
                              

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