using PPM.Model;
using IEntityOperation;
namespace PPM.Domain
{
    public class RoleRepo:IEntity<Roles>
    {
        public static List<Roles> ListRole = new List<Roles>();

        public void Add(Roles RoleObj)
        {
            ListRole.Add(RoleObj);
            System.Console.WriteLine("Added Role details");
        }

        public List<Roles> ViewAll()
        {
            foreach (Roles i in ListRole)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"RoleId:{i.RoleId},RoleName:{i.RoleName}");
                Console.ResetColor();
            }
            return ListRole;

        }

        public bool IsRole(int rid)
        {
            for (int i = 0; i < ListRole.Count; i++)
            {
                if (rid == ListRole[i].RoleId)
                {
                    return true;
                }
            }
            return false;
        }

        public Roles ViewByID(int roleId)
        {
            return ListRole.FirstOrDefault(r => r.RoleId == roleId);
        }

        public void DeleteByID(int roleId)
        {
            Roles roleToDelete = ListRole.FirstOrDefault(r => r.RoleId == roleId);
            if (roleToDelete != null)
            {
                ListRole.Remove(roleToDelete);
            }
        }
    }
}
