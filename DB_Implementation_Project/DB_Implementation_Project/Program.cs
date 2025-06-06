using System;

class Program
{
    static void Main(string[] args)
    {
        DBService service = new DBService();
        //service.SaveEmp();
        //service.FetchEmpDetails();

        int choice = 0;
        Console.WriteLine("Enter Choice:\n 1:Save Employee\n 2:Fetch Employee\n 3:Update Employee\n 4:Serach Employee\n 5:Exit");
        while (true)
        {
            //Console.WriteLine("Enter Choice:\n 1:Save Employee\n 2:Fetch Employee\n 3:Exit");

            if (choice == 1)
            {
                service.SaveEmp();
            }
            else if (choice == 2)
            {
                service.FetchEmpDetails();
            }
            else if (choice == 3)
            {
                service.DeleteEmp();
            }
            else if (choice == 4)
            {
                service.UpdateEmp();
            }
            else break;


        }


        AuthService auths = new AuthService();

        auths.InsertUser();


    }

}