using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Accommoodation_allocation
{
    class roominfo
    {
        // databse setting room > res > floor,room, person
        protected string roomno, floor;
        protected bool status = false;
        static bool flag = false;
        public roominfo()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O3T9IRP\\SQLEXPRESS;Initial Catalog=room;User ID=sa;Password=1234");
            con.Open();

            // run this only for first setup
            //for (int i = 1; i <= 8; i++)
            //{
            //    for (int j = 1; j <= 38; j++)
            //    {
            //        con.Open();

            //        SqlCommand cmd = new SqlCommand("insert into res(floor,room,person)values('" + i + "','" + j + "','0')", con);
            //        cmd.ExecuteNonQuery();

            //        con.Close();

            //    }
            //}
            //Console.WriteLine("success");



            SqlDataAdapter adp = new SqlDataAdapter("select * from res", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int fl = int.Parse(dt.Rows[i]["floor"].ToString());
                int ro = int.Parse(dt.Rows[i]["room"].ToString());
                int per = int.Parse(dt.Rows[i]["person"].ToString());

                
                if(per<3)
                {
                    if (flag==false)
                    {
                        roomno = Convert.ToString(ro);
                        floor = Convert.ToString(fl);
                        status = true;
                        per++;
                        flag = true;
                        SqlCommand cmd = new SqlCommand("update res set person='" + per + "' where floor='" + fl + "' AND room='" + ro + "'", con);
                        cmd.ExecuteNonQuery();

                        break;
                    }
                }
                else
                {
                    continue;
                }
            }
            
            
        }
    }
    
    class info:roominfo
    {
        string name, reg, year, disablity, nationality, program, sch,fee;

        public info(string na, string re,string ye,string dis,string nat,string pro,string sc)
        {
            name = na;
            reg = re;
            year = ye;
            disablity = dis;
            nationality = na;
            program = pro;
            sch = sc;

            if(sch=="no")
            {
                Console.WriteLine("Your fee is paid? yes / no");
                fee = Console.ReadLine();
            }
        }

        public void display()
        {
            if (status == true)
            {
                Console.WriteLine("congratulations! Your request had been processed");
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("Name                : " + name);
                Console.WriteLine("Registration number : " + reg);
                Console.WriteLine("Year                : " + year);
                Console.WriteLine("Disablity           : " + disablity);
                Console.WriteLine("Nationality         : " + nationality);
                Console.WriteLine("Program             : " + program);
                Console.WriteLine("Scholoarship        : " + sch);
                Console.WriteLine("Fee paid            : " + fee);
                Console.WriteLine("Room number         : " + roomno);
                Console.WriteLine("Floor number        : " + floor);
                Console.WriteLine("__________________________________________________");
            }
            else
            {
                Console.WriteLine("Sorry! You are not applicable for room allocation");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name");
            string name = Console.ReadLine();

            Console.WriteLine("Registration number");
            string reg = Console.ReadLine();

            Console.WriteLine("Year of study");
            string year = Console.ReadLine();

            Console.WriteLine("Disabled? yes / no");
            string disabilty = Console.ReadLine().ToLower();

            Console.WriteLine("Nationality");
            string nationality = Console.ReadLine();

            Console.WriteLine("Degree program");
            string program = Console.ReadLine();

            Console.WriteLine("You are on full scholarship? yes / no");
            string sch = Console.ReadLine().ToLower();


            info objec = new info(name, reg, year, disabilty, nationality, program, sch);
            roominfo obj = new roominfo();

            objec.display();
        }
    }
}
