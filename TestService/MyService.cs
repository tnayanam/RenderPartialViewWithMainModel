﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace TestService
{
    class MyService : IMyService
    {
        public string GetData()
        {
            return "Hello World";
        }

        public int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        public string GetMessage(string Message)
        {
            return "Hello" + Message;
        }

        public string GetResult(Student S)
        {
            double avg = S.M1 + S.M2 + S.M3 / 3;
            if (avg < 35)
                return "Fail";
            return "Pass";
        }

        public int[] GetSorted(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        public void GetAllCountries()
        {
            List<Country> LC = new List<Country>();
            string conStr = @"data source =.\MSSQLSERVER01; initial catalog = WCF; integrated security = True";

            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("Select * from Country", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Debug.Write("Hello");
            }
        }
        // so I went to SQL Server Mangement Studio and added one database there. Kindly note that SQL Server is already 
        // installed, I had isntalled SSMS client on top of it. And now after creating the database, I wrote above codde to 
        // connect my Visual Studio to the SQL Server.

    }
}
/*
 * A WCF Service has 3 components: 
 * Create a Service
 * Host a Service
 * Consume the Service
 * Now in this check in we created a basic service and changed the App.Config file accordingly.
 * and we ran it Visual Studio did two things, hosted our service as well as Gave us a clinet which consumed this service
 * On running the app Double clicked on the GetData and then clicked on Invoke to run the consume the service.
 */
