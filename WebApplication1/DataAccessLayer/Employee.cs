using WebApplication1.Interfaces;

namespace WebApplication1.DataAccessLayer
{
    public class Employee : IEmployee
    {
        Guid id;
        public Employee()
        {
            id= Guid.NewGuid();
        }
        public Guid Generateguid()
        {
            return id;
        }

        public List<string> GetEmployeeList()
        {
            List<string> objList = new List<string>();
            objList.Add("Pooja");
            objList.Add("Ramya");
            objList.Add("Shravan");
            objList.Add("Srinu");
            objList.Add("Tulsi");
            objList.Add("Pavan");
            objList.Add("Sindhu");
            objList.Add("Pooja");
            objList.Add("Ramya");
            objList.Add("Shravan");
            objList.Add("Srinu");
            objList.Add("Tulsi");
            objList.Add("Pavan");
            objList.Add("Sindhu");

            return objList;
        }
    }
}
