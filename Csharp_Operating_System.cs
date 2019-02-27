using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Csharp_Operating_system
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             info
             create file
             append
             clear
             exit
             read
             date
             time
             delete file
             attack
             color
             rename
             backcolor
             create dir
             delete dir
             rename dir
             copy dir
             today
             
             */





            try
            {

                Console.WriteLine("your user name");
                string name = Console.ReadLine();
                string user = "";

                Console.Clear();

                Console.WriteLine("Copyright 2019 all right reserved C.M.T software house");
                Console.WriteLine("Developed by Muhammad Tayyab\n");

                do
                {
                    Console.Write("C:\\Users\\" + name + " ");
                    user = Console.ReadLine();

                    if (user == "create file" || user == "Create file")
                    {
                        Console.WriteLine("Enter path\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string path = Console.ReadLine();

                        Console.WriteLine("Enter file name\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string fname = Console.ReadLine();

                        Console.WriteLine("Created Sucessfully\n");

                        FileStream fs = new FileStream("" + path + "\\" + fname + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    }
                    else if (user == "info" || user == "Info")
                    {
                        Console.WriteLine(Environment.OSVersion);
                        Console.WriteLine("Windows version: {0}", Environment.OSVersion);
                        Console.WriteLine("64 Bit operating system? : {0}", Environment.Is64BitOperatingSystem ? "Yes" : "No");
                        Console.WriteLine("PC Name : {0}", Environment.MachineName);
                        Console.WriteLine("Number of CPUS : {0}", Environment.ProcessorCount);
                        Console.WriteLine("Windows folder : {0}", Environment.SystemDirectory);
                        Console.WriteLine("Logical Drives Available : {0}", String.Join(", ", Environment.GetLogicalDrives()) + "\n");
                    }
                    else if (user == "append" || user == "Append")
                    {
                        Console.WriteLine("enter path\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string path = Console.ReadLine();

                        Console.WriteLine("Enter file name\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string currentfile = Console.ReadLine();

                        Console.WriteLine("Enter data\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string newcontent = Console.ReadLine();

                        File.AppendAllText("" + path + "\\" + currentfile + ".txt", newcontent);

                        Console.WriteLine("Sucessfully Complete\n");
                    }
                    else if (user == "clear" || user == "Clear")
                    {
                        Console.Clear();
                        Console.WriteLine("Copyright 2019 all right reserved C.M.T software house");
                        Console.WriteLine("Developed by Muhammad Tayyab\n");
                    }
                    else if (user == "read" || user == "open" || user == "Read" || user == "Open")
                    {
                        Console.WriteLine("enter path\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string path = Console.ReadLine();

                        Console.WriteLine("Enter file name\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string readfilename = Console.ReadLine();

                        string data = File.ReadAllText("" + path + "\\" + readfilename + ".txt");
                        Console.WriteLine("" + data + "\n");
                    }
                    else if (user == "date" || user == "Date")
                    {
                        string date = DateTime.Now.ToString("MM/dd/yyyy");
                        Console.WriteLine("" + date + "\n");
                    }
                    else if (user == "time" || user == "Time")
                    {
                        string time = DateTime.Now.ToString("HH:mm:ss");
                        Console.WriteLine("" + time + "\n");
                    }
                    else if (user == "file delete" || user == "File delete")
                    {
                        Console.WriteLine("Enter path\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string path = Console.ReadLine();

                        Console.WriteLine("Enter file name\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string readfilename = Console.ReadLine();

                        File.Delete("" + path + "\\" + readfilename + ".txt");

                        Console.WriteLine("Sucessfully delete\n");
                    }
                    else if (user == "attack" || user == "Attack")
                    {
                        Console.WriteLine("enter path\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string path = Console.ReadLine();

                        Console.WriteLine("It my damage your data");
                        Console.WriteLine("are you sure? press 1 to continue\n");
                        string op = Console.ReadLine();

                        if (op == "1")
                        {

                            for (int i = 0; i <= 1000; i++)
                            {
                                FileStream fs = new FileStream("" + path + "\\" + i + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                            }
                            Console.WriteLine("Attack sucessfully complete\n");
                        }
                    }
                    else if (user == "color" || user == "Color")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else if (user == "rename" || user == "Rename")
                    {
                        Console.WriteLine("Enter path\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string path = Console.ReadLine();

                        Console.WriteLine("Enter file name\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string readfilename = Console.ReadLine();

                        Console.WriteLine("Enter new file name\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string readfilename1 = Console.ReadLine();

                        File.Move("" + path + "" + readfilename + ".txt", "" + path + "" + readfilename1 + ".txt");
                        Console.WriteLine("Name change sucessfull\n");
                    }
                    else if (user == "backcolor" || user == "Backcolor")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else if (user == "create dir" || user == "Create dir")
                    {
                        Console.WriteLine("Enter path\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string path = Console.ReadLine();

                        Console.WriteLine("Enter file name\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string fname = Console.ReadLine();

                        Directory.CreateDirectory(@"" + path + "\\" + fname + "");

                        Console.WriteLine("Directory created sucessfully\n");

                    }
                    else if (user == "delete dir" || user == "Delete dir")
                    {
                        Console.WriteLine("Enter path\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string path = Console.ReadLine();

                        Console.WriteLine("Enter file name\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string fname = Console.ReadLine();


                        Console.WriteLine("It my damage your data");
                        Console.WriteLine("are you sure? press 1 to continue\n");
                        string op = Console.ReadLine();

                        if (op == "1")
                        {
                            Directory.Delete(@"" + path + "\\" + fname + "");
                            Console.WriteLine("Directory Delete sucessfully\n");
                        }
                    }
                    else if (user == "rename dir" || user == "Rename dir")
                    {
                        Console.WriteLine("Enter path\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string path = Console.ReadLine();

                        Console.WriteLine("Enter file name\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string fname = Console.ReadLine();

                        Console.WriteLine("Enter file name\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string rname = Console.ReadLine();

                        Directory.Move(@"" + path + "\\" + fname + "", @"" + path + "\\" + rname + "");

                        Console.WriteLine("Rename sucessfull\n");
                    }
                    else if (user == "copy dir" || user == "Copy dir")
                    {
                        Console.WriteLine("Enter path\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string path = Console.ReadLine();

                        Console.WriteLine("Enter path\n");

                        Console.Write("C:\\Users\\" + name + " ");
                        string path1 = Console.ReadLine();

                        CopyFolderContents(@"" + path + "", @"" + path1 + "");

                        Console.WriteLine("Copy Sucessfull\n");
                    }
                    else if (user == "today" || user == "Today")
                    {
                        string today = DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");
                        Console.WriteLine(today + "\n");
                    }


                    else
                    {
                        Console.WriteLine("\ninvalid command");
                        Console.WriteLine("You can use only these commands");
                        Console.WriteLine("\n1) info    2) create file    3) append    4) clear    5) exit    6) read        7) date    8) time    9) delete file    10) open    11) attack    12) color     13) rename    14) backcolor    15) create dir    16) delete dir                 17) rename dir    18) copy dir    19) today\n");
                    }



                }
                while (user != "exit");
            }
            catch
            {
                Console.WriteLine("invalid or wrong input");
            }


        }


        public static void CopyFolderContents(string sourceFolder, string destinationFolder)
        {
            if (Directory.Exists(sourceFolder))
            {
                // Copy folder structure
                foreach (string sourceSubFolder in Directory.GetDirectories(sourceFolder, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(sourceSubFolder.Replace(sourceFolder, destinationFolder));
                }

                // Copy files
                foreach (string sourceFile in Directory.GetFiles(sourceFolder, "*", SearchOption.AllDirectories))
                {
                    string destinationFile = sourceFile.Replace(sourceFolder, destinationFolder);
                    File.Copy(sourceFile, destinationFile, true);
                }
            }
        }



    }
}

