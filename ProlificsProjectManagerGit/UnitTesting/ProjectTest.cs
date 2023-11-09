 using PPM.Domain;
using PPM.Main;
using PPM.Model;
using PPM.UI;

 public class AddProjectTest
 {
 
 [Test]
        public void ProjectTest()
        {
            Project projectObj = new Project();
            ProjectRepo projectRepoObj = new ProjectRepo();
            projectObj.ProjectId = 1;
            projectObj.ProjectName = "Solar";
            projectObj.StartDate = new DateTime(2000, 12, 09);
            projectObj.EndDate = new DateTime(2022, 12, 09);

            projectRepoObj.Add(projectObj);

            Assert.That(ProjectRepo.projectList.Count, Is.EqualTo(1));
            Assert.That(ProjectRepo.projectList[0].ProjectName, Is.EqualTo("Solar"));
            Assert.That(ProjectRepo.projectList[0].ProjectId, Is.EqualTo(1));
            Assert.That(
                ProjectRepo.projectList[0].StartDate,
                Is.EqualTo(new DateTime(2000, 12, 09))
            );
            Assert.That(ProjectRepo.projectList[0].EndDate, Is.EqualTo(new DateTime(2022, 12, 09)));
        }


        [Test]
        public void ViewProject()
        {
           var ProjectDetailsOnly=ProjectConsole.ViewDetails();

           Assert.That(ProjectDetailsOnly.Count,Is.EqualTo(1));
        }
        
 }