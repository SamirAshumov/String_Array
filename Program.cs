using System.Xml.Linq;

namespace String_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string no, checkStr, fullname;
            string Strlimit;
            byte check;
            double avgPoint;
            int intLimit = 0;


            do
            {

                Console.WriteLine("\nYaradilacag grupun adini daxil edin : (ex : AB204)\n");
                no = Console.ReadLine();

                if (no == String.Empty)
                {
                    Console.WriteLine("\nGrup adi bos qoyula bilmez\n");
                }

                else if (!(no.Length == 5 && char.IsUpper(no[0]) && char.IsUpper(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]) && char.IsDigit(no[4])))
                {
                    Console.WriteLine("\nGrup adi verilmis standarta uygun deyil");
                }

                
            } while (!(no != String.Empty && no.Length == 5 && char.IsUpper(no[0]) && char.IsUpper(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]) && char.IsDigit(no[4]))); 
 


            do
            {
                do
                {

                    Console.WriteLine("\nGrupdaki telebe limitini daxil edin : (ex : [0-20])\n");
                    Strlimit = Console.ReadLine();
                    
                } while (!int.TryParse(Strlimit, out intLimit));
                

                if (!(intLimit >= 0 &&  intLimit <= 20))
                {
                    Console.WriteLine("\nLimit yalniz [0-20] araliginda teyin oluna biler");
                }               

            }while(!(intLimit >= 0 && intLimit <= 20));


            Group group = new Group(intLimit);

            do
            {
                Console.WriteLine("\n1. Telebe elave et\n2. Butun telebelere bax\n3. Telebeler uzre axtaris et\n0. Proqrami bitir\n");

                do
                {
                    checkStr = Console.ReadLine();

                    if (byte.TryParse(checkStr, out check) == false)
                    {
                        Console.WriteLine("\nDaxil olunan emeliyyat sehvdir. Zehmet olmasa duzgun emeliyyati secin : ");
                        Console.WriteLine("\n1. Telebe elave et\n2. Butun telebelere bax\n3. Telebeler uzre axtaris et\n0. Proqrami bitir\n");
                    }


                } while (!byte.TryParse(checkStr, out check));


                if (check == 1)
                {
                    do
                    {
                        Console.WriteLine("\nTelebenin ad ve soyadini daxil edin : ");
                        fullname = Console.ReadLine();

                        if (fullname == string.Empty)
                        {
                            Console.WriteLine("Telebenin ad ve soyadi bos qoyula bilmez!");
                        }

                    } while (fullname == string.Empty);



                    do
                    {

                        Console.WriteLine("\nGrup adini daxil edin : (ex : AB204)\n");
                        no = Console.ReadLine();

                        if (no == String.Empty)
                        {
                            Console.WriteLine("\nGrup adi bos qoyula bilmez\n");
                        }

                        else if (!(no.Length == 5 && char.IsUpper(no[0]) && char.IsUpper(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]) && char.IsDigit(no[4])))
                        {
                            Console.WriteLine("\nGrup adi verilmis standarta uygun deyil");
                        }


                    } while (!(no != String.Empty && no.Length == 5 && char.IsUpper(no[0]) && char.IsUpper(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]) && char.IsDigit(no[4])));


                    do
                    {
                        Console.WriteLine("\nTelebenin ortalama balini daxil edin : ");
                        avgPoint = Convert.ToDouble(Console.ReadLine());

                        if (!(avgPoint >= 0 && avgPoint <= 100))
                        {
                            Console.WriteLine("\nDaxil olunan ortalama bal duzgun deyil. Zehmet olmasa yeniden daxil edin : ");
                        }

                    } while (!(avgPoint >= 0 && avgPoint <=100)); 

                    Student student = new Student(fullname, no, avgPoint, intLimit);
                    group.AddStudent(student);
                                       
                   
                }

                else if (check == 2)
                {
                    Console.WriteLine("-----------------------------------------");
                    group.ShowAllStudents();
                    Console.WriteLine("-----------------------------------------");
                }

                else if (check == 3)
                {
                    Console.WriteLine("\nAxtarilan telebenin ad ve soyadini daxil edin : ");
                    fullname = Console.ReadLine();

                    Console.WriteLine("-----------------------------------------");
                    group.SearchStudent(fullname);                    

                }

                else if (check == 0)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("\nEmeliyyat duzgun secilmeyib. Zehmet olmasa duzgun emeliyyati secin :\n");
                }

            } while (true);



        }
    }
}
