using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class WorkerPrivate
    {
        private string _name;
        private int _age;
        private float _salary;
        public void SetName(string name) { _name = name; }
        public string GetName() { return _name; }
        public void SetAge(int age)
        {
            if (CheckAge(age))
            {
                _age = age;
            }
        }

        public int GetAge() { return _age; }
        public void SetSalary(float salary) { _salary = salary; }
        public float GetSalary() { return _salary; }
        private bool CheckAge(int age) { return age >= 1 && age <= 100; }

    }

}
