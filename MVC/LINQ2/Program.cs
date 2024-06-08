namespace LINQ2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Department
    {
        public int departmentId { get; set; }
        public string Name { get; set; }

        static void Main2(string[] args)
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { departmentId = 1, Name = "Account" });
            departments.Add(new Department { departmentId = 2, Name = "Sales" });
            departments.Add(new Department { departmentId = 3, Name = "Marketing" });

            var departmentList = from d in departments select d;

            foreach (var department in departmentList)
            {
                Console.WriteLine("Department Id={0}, Department Name={1}", department.departmentId, department.Name);
            }
        }
    }
}
