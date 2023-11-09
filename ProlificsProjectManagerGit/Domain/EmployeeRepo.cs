using System;
using PPM.Model;
using IEntityOperation;

namespace PPM.Domain
{
    public class EmployeeRepo : IEntity<Employee>
    {
        public static List<Employee> employeeList = new List<Employee>();


        public void Add(Employee employeeObject)              
        {
            if (employeeObject.RoleId != 0)
            {
                employeeList.Add(employeeObject);
            }
        }

        public List<Employee> ViewAll()
        {
            return employeeList;
        }
        public Employee GetById(int eid)
        {
            Employee emp = new Employee();
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (eid == employeeList[i].EmployeeId)
                {
                    emp = employeeList[i];
                    return emp;
                }
            }
            return emp;
        }

        public Employee ViewByID(int employeeId)
        {
            return employeeList.FirstOrDefault(e => e.EmployeeId == employeeId);
        }

        public void DeleteByID(int employeeId)
        {
            Employee employeeToDelete = employeeList.FirstOrDefault(
                e => e.EmployeeId == employeeId
            );
            if (employeeToDelete != null)
            {
                employeeList.Remove(employeeToDelete);
            }
        }
    }
}
