using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace practice_project_1._14_retrieve_student_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------RAINBOW SCHOOL---------------------");


            Console.WriteLine("                                                         ");
            Console.WriteLine("---------------------STUDENTS DATA----------------------");

            try
            {
                string fpath = "D:/practic exercise/practice project/project1.14/student data.txt";
                string[] lines = File.ReadAllLines(fpath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
               
            }
            catch (Exception ex)
            { Console.WriteLine("error!!!" + ex.Message); }
            finally { Console.ReadKey(); }

        }

    }
}

