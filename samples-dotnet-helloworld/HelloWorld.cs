/*
* PURPOSE: Makes a connection to an instance of InterSystems IRIS Data Platform.
*/

using System;

using InterSystems.Data.IRISClient;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String ip = "localhost";
            int port = 51773;
            String Namespace = "USER";
            String username = "SuperUser";
            String password = "SYS";
            try
            {
                // Using IRISADOConnection to connect
                IRISADOConnection connect = new IRISADOConnection();

                // Create connection string
                connect.ConnectionString = "Server = " + ip + "; Port = " + port + "; Namespace =  " + Namespace + "; Password = " + password + "; User ID = " + username;
                connect.Open();
                Console.WriteLine("Hello World! You have successfully connected to InterSystems IRIS. Press any key to continue.");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection failed:\n" + e);
            }
        }
    }
}