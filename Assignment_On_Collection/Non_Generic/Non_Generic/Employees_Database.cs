using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Generic
{
    class Employees_Database
    {
        public int Emp_id;
        public string Emp_Name;
    }

    class Test_Emp
    {
        ArrayList ar;
        public Test_Emp()
        {
            Employees_Database s1 = new Employees_Database() { Emp_id = 1001, Emp_Name = "Rohan" };
            Employees_Database s2 = new Employees_Database() { Emp_id = 1005, Emp_Name = "Karan" };
            Employees_Database s3 = new Employees_Database() { Emp_id = 1003, Emp_Name = "Charan" };
            Employees_Database s4 = new Employees_Database() { Emp_id = 1006, Emp_Name = "Suren" };
            Employees_Database s5 = new Employees_Database() { Emp_id = 1004, Emp_Name = "David" };
            Employees_Database s6 = new Employees_Database() { Emp_id = 1002, Emp_Name = "Sachin" };
            ar = new ArrayList();
            ar.Add(s1);
            ar.Add(s2);
            ar.Add(s3);
            ar.Add(s4);
            ar.Add(s5);
            ar.Add(s6);
        }

        public static void Solution()
        {
            Test_Emp obj = new Test_Emp();
            Employees_Database s = obj.Search(1001);
            foreach (int k in obj.Keys)
            {
                Console.WriteLine("Emp_Id:{0} Emp_Name:{1}", k, obj[k]);
            }

            
        }
    }
}
