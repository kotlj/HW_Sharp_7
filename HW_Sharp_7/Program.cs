using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Sharp_7
{
    internal class Program
    {
        class CoWorker
        {
            private string fullName;
            private DateTime birth;
            private string phone;
            private string workMail;
            private string post;
            private string description;
            private int salary;

            public string Fullname
            {
                get
                {
                    return fullName;
                }
                set
                {
                    fullName = value;
                }
            }
            public DateTime Birth
            {
                get
                {
                    return birth;
                }
                set
                {
                    birth = value;
                }
            }
            public string Phone
            {
                get
                {
                    return phone;
                }
                set
                {
                    phone = value;
                }
            }
            public string WorkMail
            {
                get
                {
                    return workMail;
                }
                set
                {
                    workMail = value;
                }
            }
            public string Post
            {
                get
                {
                    return post;
                }
                set
                {
                    post = value;
                }
            }
            public string Description
            {
                get
                {
                    return description;
                }
                set
                {
                    description = value;
                }
            }
            public int Salary
            {
                get
                {
                    return salary;
                }
                set
                {
                    salary = value;
                }
            }

            public static int operator +(CoWorker co, int value)
            {
                co.salary += value;
                return co.salary;
            }
            public static int operator -(CoWorker co, int value)
            {
                co.salary -= value;
                return value - co.salary;
            }
            public static bool operator ==(CoWorker co, CoWorker second)
            {
                return co.salary == second.salary;
            }
            public static bool operator !=(CoWorker co, CoWorker second)
            {
                return co.salary != second.salary;
            }
            public static bool operator <(CoWorker co, CoWorker second)
            {
                return co.salary < second.salary;
            }
            public static bool operator >(CoWorker co, CoWorker second)
            {
                return co.salary > second.salary;
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
