using Microsoft.Data.SqlClient;
//using System.Data.SqlClient;
using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

class AuthService : AuthRepro
{
    SqlConnection conn;
    public AuthService()
    {
        conn = new SqlConnection("Data Source=SS\SQLEXPRESS;Initial Catalog=sqldbprac;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True");

        conn.Open();
    }

    public void InsertUser()
    {
        string useremail, username, userpassword, userrole="user";

        Console.WriteLine("Enter Email:");
        useremail = Console.ReadLine();

        Console.WriteLine("Enter User Name:");
        username = Console.ReadLine();

        Console.WriteLine("Enter Password:");
        userpassword = Console.ReadLine();

        Console.WriteLine("Enter Role:");
        userrole = Console.ReadLine();

        try
        {
            string q = $"exec InsertUser '{useremail}','{username}','{userpassword}','{userrole}'";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();

            Console.WriteLine("User is Saved Successfully");


        }
        catch (Exception e)
        {
            throw e;
        }

    }

}