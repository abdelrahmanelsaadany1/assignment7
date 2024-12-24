namespace answers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HiringDate hireDate = new HiringDate(8, 5, 2006);

            
            Employee[] EmpArr = new Employee[3];

            try
            {
           
                EmpArr[0] = new Employee(1, "abdelrahman", EmployeeSecurityPrivilege.DBA, 4500m, hireDate, 'M');
                EmpArr[1] = new Employee(2, "Ahmed", EmployeeSecurityPrivilege.Guest, 1500m, hireDate, 'F');
                EmpArr[2] = new Employee(3, "mohamed", EmployeeSecurityPrivilege.SecurityOfficer, 5000m, hireDate, 'x');
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);  
            }

           
            foreach (var emp in EmpArr)
            {
               
                if (emp != null)
                {
                    Console.WriteLine(emp);
                }
            }
        }
    }
}
