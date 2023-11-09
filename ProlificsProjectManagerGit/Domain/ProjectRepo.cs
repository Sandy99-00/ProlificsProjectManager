using System;
using System.Reflection.Metadata;
using PPM.Model;
using IEntityOperation;

namespace PPM.Domain
{
    public class ProjectRepo : IEntity<Project>
    {
        public static List<Project> projectList = new List<Project>();

        public  Project ViewByID(int id)
        {
             var viewProjectById = projectList.FirstOrDefault(p => p.ProjectId == id);
           return viewProjectById;
        }
 
        public  void DeleteByID(int deleteid)
        {
            projectList.RemoveAll(item => item.ProjectId == deleteid);
        }

        public  void Add( Project ProjectObject)
        {
            projectList.Add(ProjectObject);
        }

        public bool IsProject(int pid)

        {
            for (int i = 0; i < projectList.Count; i++)
            {
                if (pid == projectList[i].ProjectId)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Project> ViewAll()
        {
            return projectList;
        }

        public void AddEmployeeToProject(int pid, Employee emp)
        {
            for (int i = 0; i < projectList.Count; i++)
            {
                if (pid == projectList[i].ProjectId)
                {
                    projectList[i].projectEmployees.Add(emp);
                }
            }
        }

        public void DeleteEmployeeToProject(int pid, Employee emp)
        {
            for (int i = 0; i < projectList.Count; i++)
            {
                if (pid == projectList[i].ProjectId)
                {
                    projectList[i].projectEmployees.Remove(emp);
                }
            }
        }
    }
}
