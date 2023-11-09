using System.Net.Sockets;
using PPM.Domain;
using PPM.Main;
using PPM.Model;
using PPM.UI;

namespace TestProject1
{
    public class UnitTests
    {
        [Test]
        public void DeleteEmployeeProject_RemovesEmployeeFromProject()
        {
            ProjectRepo projectDomain = new ProjectRepo();

            Project ProjectObj = new Project()
            {
                ProjectId = 1,
                ProjectName = "Socket",
                StartDate = DateTime.MinValue,
                EndDate = DateTime.MaxValue
            };

            projectDomain.Add(ProjectObj);
            EmployeeRepo employeeDomain = new EmployeeRepo();
            Employee empObj = new Employee()
            {
                EmployeeId = 1,
                EmployeeFirstName = "Sandeep",
                EmployeeLastName = "Goud",
                Email = "Sam@gmail.com"
            };
            employeeDomain.Add(empObj);
            projectDomain.AddEmployeeToProject(1, empObj);
            projectDomain.DeleteEmployeeToProject(1, empObj);

            Assert.IsEmpty(ProjectRepo.projectList[0].projectEmployees);
            Assert.That(ProjectRepo.projectList[0].projectEmployees.Count, Is.EqualTo(0));
        }

        [Test]
        public void TestAddEmployeeToProject()
        {
            ProjectRepo projectRepo = new ProjectRepo();

            Employee employee = new Employee();

            List<Project> projectsList = new List<Project>
            {
                new Project
                {
                    ProjectId = 2,
                    projectEmployees = new List<Employee>
                    {
                        new Employee
                        {
                            EmployeeId = 1,
                            EmployeeFirstName = "Sandeep",
                            EmployeeLastName = "Goud",
                            Email = "Span@gmail.com",
                            MobileNumber = 6547984324,
                            Address = "Hyd",
                            RoleId = 1,
                        }
                    }
                }
            };

            int projectIdToAddTo = 2;

            projectRepo.AddEmployeeToProject(projectIdToAddTo, employee);

            Project targetProject = projectsList.Find(p => p.ProjectId == projectIdToAddTo);

            Assert.That(targetProject.projectEmployees.Count, Is.EqualTo(1));
            Assert.That(projectsList, Has.Count.EqualTo(1));
        }

        [Test]
        public   void ProjectDetailsWithEmployees()
        {
            var details = ProjectConsole.ViewDetails();

            Assert.That(details.Count, Is.EqualTo(2));
        }
    }
}
