using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public interface IStudent
    {
        int StudID { get; set; }
        string StudName { get; set; }
        string StudGender { get; set; }
        int StudAge { get; set; }
        string StudClass { get; set; }
        float StudAvgMark { get; }

        void Print();
    }
    class Program
    {

        static void Main(string[] args)
        {
            Hashtable studentHashtable = new Hashtable();

            int option = 0;
            int StudID, StudAge;
            string StudName, StudGender, StudClass;

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("====================================");
                Console.WriteLine("  1. Insert new student");
                Console.WriteLine("  2. Display all the student list");
                Console.WriteLine("  3. Calculate average mark");
                Console.WriteLine("  4. Search student");
                Console.WriteLine("  5. Exit");
                Console.WriteLine("====================================");

                Console.Write("Option: ");
                option = Convert.ToInt32(Console.ReadLine());
                Student student = new Student();


                switch (option)
                {
                    case 1:

                        Console.WriteLine("1. Insert new student: ");
                        Console.WriteLine("ID: ");
                        student.StudID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Name: ");
                        student.StudName = Console.ReadLine();
                        Console.WriteLine("Gender: ");
                        student.StudGender = Console.ReadLine();
                        Console.WriteLine("Age: ");
                        student.StudAge = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Class: ");
                        student.StudClass = Console.ReadLine();

                        Console.WriteLine("Enter 3 marks:");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("Mark " + (i + 1) + ": ");
                            student[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        student.CalAvg();
                        studentHashtable.Add(student.StudID, student);


                        break;
                    case 2:
                        Console.WriteLine("2. Display student list: ");
                        foreach (DictionaryEntry entry in studentHashtable)
                        {
                            IStudent iStd = (IStudent)entry.Value;
                            iStd.Print();
                            Console.WriteLine();
                        }

                        break;
                    case 3:
                        Console.WriteLine("3. Calculate average mark: ");
                        foreach (DictionaryEntry entry in studentHashtable)
                        {
                            Student std = (Student)entry.Value;
                            std.CalAvg();
                            std.Print();
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Search student: ");
                        Console.WriteLine("Please select an option to search:");
                        Console.WriteLine("1. By ID");
                        Console.WriteLine("2. By Name");
                        Console.WriteLine("3. By Class");
                        Console.Write("Option: ");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:


                                Console.Write("Enter ID: ");
                                int searchID = Convert.ToInt32(Console.ReadLine());
                                ArrayList searchResults = new ArrayList();
                                foreach (DictionaryEntry entry in studentHashtable)
                                {
                                    Student stdID = (Student)entry.Value;
                                    if (stdID.StudID == searchID)
                                    {
                                        searchResults.Add(stdID);
                                    }
                                }

                                if (searchResults.Count > 0)
                                {
                                    Console.WriteLine("Search results:");
                                    foreach (Student stdID in searchResults)
                                    {
                                        stdID.Print();
                                        Console.WriteLine();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Not found.");
                                }

                                break;
                            case 2:

                                Console.Write("Enter name to search: ");
                                string searchName = Console.ReadLine();

                                ArrayList searchResults1 = new ArrayList();
                                foreach (DictionaryEntry entry in studentHashtable)
                                {
                                    Student stdName = (Student)entry.Value;
                                    if (stdName.StudName.Equals(searchName))
                                    {
                                        searchResults1.Add(stdName);
                                    }
                                }

                                if (searchResults1.Count > 0)
                                {
                                    Console.WriteLine("Search results: ");
                                    foreach (Student stdName in searchResults1)
                                    {
                                        stdName.Print();
                                        Console.WriteLine();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Not found.");
                                }
                                break;
                            case 3:

                                Console.Write("Enter class to search: ");
                                string searchClass = Console.ReadLine();

                                ArrayList searchResults2 = new ArrayList();
                                foreach (DictionaryEntry entry in studentHashtable)
                                {
                                    Student stdClass = (Student)entry.Value;
                                    if (stdClass.StudClass.Equals(searchClass))
                                    {
                                        searchResults2.Add(stdClass);
                                    }
                                }

                                if (searchResults2.Count > 0)
                                {
                                    Console.WriteLine("Search results:");
                                    foreach (Student stdClass in searchResults2)
                                    {
                                        stdClass.Print();
                                        Console.WriteLine();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Not found.");
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid option. Retry.");
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exit the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Press anything to clear.");
                Console.ReadLine();
                Console.Clear();
            }

        }




    }
}




