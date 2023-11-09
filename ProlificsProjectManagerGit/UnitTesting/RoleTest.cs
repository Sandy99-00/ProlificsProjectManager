using PPM.Domain;
using PPM.Main;
using PPM.Model;
using PPM.UI;


class RoleTest
{
 ConsoleRoles roleObj=new();

       
 [Test]
    public  void ValidRoleTest()
    {
        RoleRepo roleRepoObj = new RoleRepo();

        Assert.IsTrue(roleRepoObj.IsRole(1));
    }
 
    [Test]
    public  void IsInvalidRoleTest()
    {
        RoleRepo roleRepoObj = new RoleRepo();
        Assert.IsFalse(roleRepoObj.IsRole(10));
    }

    [Test]
        public void ViewRole()
        {
            var details=roleObj.ViewRoles();
            
        }

        [Test]
        public void AddRole()
        {
            Roles roleObj = new Roles();
            RoleRepo roleRepoObj = new RoleRepo();

            roleObj.RoleId = 1;
            roleObj.RoleName = "Developer";

            roleRepoObj.Add(roleObj);
            Assert.That(
                RoleRepo.ListRole.Count,
                Is.EqualTo(1),
                "Expected one object to be added to the list."
            );

            Assert.IsTrue(RoleRepo.ListRole.Contains(roleObj));
        }


}