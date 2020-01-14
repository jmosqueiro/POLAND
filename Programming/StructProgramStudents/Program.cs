using System;

namespace StructProgramStudents
{
    class Program
    {

        struct Student
        {
            public string name;
            public string surname;
            public int index;
            public double avg;
        }

        static void Main(string[] args)
        {
            int choice;
            int nOfStudents = 2;
            Student[] student = new Student[nOfStudents];
            do
            {
                System.Console.WriteLine("1. Add");
                System.Console.WriteLine("2. Print");
                System.Console.WriteLine("3. Search");
                System.Console.WriteLine("4. EXIT");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    for (int i = 0; i < nOfStudents; i++)
                    {
                        System.Console.WriteLine("Student {0}:",i);
                        System.Console.Write("name: ");
                        student[i].name = Console.ReadLine();
                        System.Console.WriteLine("Surname :");
                        student[i].surname = Console.ReadLine();
                        Console.Write("index: ");
                        student[i].index = Convert.ToInt32(Console.ReadLine());
                        Console.Write("AVG: ");
                        student[i].avg = Convert.ToDouble(Console.ReadLine());
                    }
                    break;
                    case 2:
                    for (int i = 0; i < nOfStudents; i++)
                    {
                        System.Console.WriteLine("Student: {0} {1}, index {2}, avg: {3}",student[i].name, student[i].surname, student[i].index, student[i].avg);
                    }
                    break;

                    case 3:
                    
                    int num;
                    System.Console.WriteLine("How do you want to search?");
                    System.Console.WriteLine("1. name");
                    System.Console.WriteLine("2. surname");
                    System.Console.WriteLine("3. index");
                    System.Console.WriteLine("4. avg");
                    
                    num = int.Parse(Console.ReadLine());
                    int found = 0;
                    
                    switch (num)
                    {
                        case 1:
                            string name1;
                            System.Console.WriteLine("what is the name of the sudent? ");
                            name1 = Console.ReadLine();
        
                            for (int i = 0; i < nOfStudents; i++)
                            {
                                if (student[i].name == name1)
                                {
                                    System.Console.WriteLine("Student: {0} {1}, index {2}, avg: {3}",student[i].name, student[i].surname, student[i].index, student[i].avg);
                                    found++;
                                }
                                if (found == 0)
                                {
                                    System.Console.WriteLine("#no students found");
                                }
                            }
                        break;
                        case 2:
                            string surname1;
                                System.Console.WriteLine("what is the surname of the sudent? ");
                                surname1 = Console.ReadLine();
            
                                for (int i = 0; i < nOfStudents; i++)
                                {
                                    if (student[i].surname == surname1)
                                    {
                                        System.Console.WriteLine("Student: {0} {1}, index {2}, avg: {3}",student[i].name, student[i].surname, student[i].index, student[i].avg);
                                        found++;
                                    }
                                    if (found == 0)
                                    {
                                        System.Console.WriteLine(" no students found ");
                                    }
                                }
                        break;
                        case 3:
                            int indexToFind;
                            System.Console.WriteLine("What index: ");
                            indexToFind = int.Parse(Console.ReadLine());
                            for (int i = 0; i < nOfStudents; i++)
                            {
                                if (student[i].index == indexToFind)
                                {
                                    System.Console.WriteLine("Student: {0} {1}, index {2}, avg: {3}",student[i].name, student[i].surname, student[i].index, student[i].avg);
                                    found++;
                                } 
                            }
                            if (found == 0)
                            {
                                System.Console.WriteLine("No students found");
                            }
                        break;
                        case 4:
                            int avgToFind;
                            System.Console.WriteLine("What avg: ");
                            avgToFind = int.Parse(Console.ReadLine());
                            for (int i = 0; i < nOfStudents; i++)
                            {
                                if (student[i].avg == avgToFind)
                                {
                                    System.Console.WriteLine("Student: {0} {1}, index {2}, avg: {3}",student[i].name, student[i].surname, student[i].index, student[i].avg);
                                    found++;
                                } 
                            }
                            if (found == 0)
                            {
                                System.Console.WriteLine("No students found");
                            }
                        break;
                        default:
                        System.Console.WriteLine("try again");
                        break;
                    }
                    
                        
                    
                    
                    
                    
                    
                    
                    /* for (int i = 0; i < nOfStudents; i++)
                    {
                        System.Console.WriteLine("teste");
                        //indexToFind = Convert.ToInt32(Console.ReadLine());
                        if (student[i].index == indexToFind) 
                        {
                            System.Console.WriteLine("true");
                        }
                        else
                        {
                            System.Console.WriteLine("false");
                        }
                    } */

                    break;

                    case 4:
                    Console.Clear();                    
                    System.Console.WriteLine("Exit");
                    break;
                    default:
                    System.Console.WriteLine("Wrong choice, try again");
                    break;
                }

            } while (choice != 4);
            
        }
    }
}
