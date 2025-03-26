using PWDBlazorApp.Models;

namespace PWDBlazorApp.Pages
{
    public partial class DepartmentComponent
    {
        public Department   Dept { get; set; }

        public int DeptId { get; set; }

        public List<Department> DeptList { get; set; }//=new List<Department>();

        public DepartmentComponent()
        {
            DeptList = new List<Department>();
            // Dept=new Department() { Id=1,Name="SD",ManagerName="Ahmed"};
            DeptList.Add(new Department() { Id = 1, Name = "SD", ManagerName = "Ahmed" });
            DeptList.Add(new Department() { Id = 2, Name = "OS", ManagerName = "Mohamed" });
            DeptList.Add(new Department() { Id = 3, Name = "PW", ManagerName = "Sabreen" });
            DeptList.Add(new Department() { Id = 4, Name = "UX", ManagerName = "Mariam" });
        }

        public void GetDEpt()
        {
            Dept= DeptList.FirstOrDefault(d => d.Id == DeptId);
        }
    }
}
