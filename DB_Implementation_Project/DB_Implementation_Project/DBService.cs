using Microsoft.Data.SqlClient;
//using System.Data.SqlClient;
using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
class DBService : DBRepo
{
    SqlConnection conn;
    public DBService()
    {
        conn = new SqlConnection("Data Source=SS\SQLEXPRESS;Initial Catalog=sqldbprac;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True");

        conn.Open();
    }

    public void SaveEmp()
    {
        string empname, empemail, empdept;
        double empsalary;

        Console.WriteLine("Enter Name:");
        empname = Console.ReadLine();

        Console.WriteLine("Enter Email:");
        empemail = Console.ReadLine();

        Console.WriteLine("Enter Dept:");
        empdept = Console.ReadLine();

        Console.WriteLine("Enter Salary:");
        empsalary = double.Parse(Console.ReadLine());

        try
        {
            string q = $"exec SaveEmp '{empname}','{empemail}','{empdept}','{empsalary}'";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Employee Added Successfully");


        }
        catch (Exception e)
        {
            throw e;
        }





    }

    public void FetchEmpDetails()
    {
        string q = "exec FetchEmp";
        SqlCommand cmd = new SqlCommand(q, conn);
        SqlDataReader rdr = cmd.ExecuteReader();

        if (rdr.HasRows)
        {
            while (rdr.Read())
            {
                string s = $"Emp Id : {rdr["id"]}\nEmp name : {rdr["name"]}\nEmp email : {rdr["email"]}\nEmp dept : {rdr["dept"]}\nEmp salary : {rdr["salary"]}\n===========================================";
                Console.WriteLine(s);


            }
        }
        else
        {
            Console.WriteLine("Data Not Found");
        }
    }

    public void DeleteEmp()
    {
        try
        {
            string q = "exec DeleteEmp";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Employee Record Deleted Successfully");
        }
        catch (Exception e)
        {
            throw e;
        }


    }

    public void SearchEmp()
    {
        string q = "exec SearchEmp";
        SqlCommand cmd = new SqlCommand(q, conn);
        SqlDataReader rdr = cmd.ExecuteReader();

    }

    public void UpdateEmp()
    {

        try
        {
            string q = "exec UpdateEmp";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Employee Updated Successfully");
        }
        catch(Exception e)
        {
            throw e;
        }
        



    }
    


}


