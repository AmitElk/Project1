using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.UI;
using MySql.Data.MySqlClient;

namespace Application3
{
    public class Customer
    {
        private string userName;
        private string Password;
        private int id;
        public Customer(string username, int Id)
        {
            userName = username;
            id = Id;
        }
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public static Customer Login(string username, string password)
        {
            MySqlConnection conn = new MySqlConnection(ServerNames.CDT);
            string sqlQuerty = $@" SELECT id ,username 
                                   from natan 
                             where username='{username}' and Password1= '{password}'";
            MySqlCommand comm = new MySqlCommand(sqlQuerty, conn);
            Customer cust = null;
            conn.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                int id = dr.GetInt32(0);
                string name = dr.GetString(1);
                cust = new Customer(name, id);
            }
            conn.Close();
            return cust;
        }
        public override string ToString()
        {
            string str = $"Hellow {userName}";
            return str;
        }
        public static bool SingUp(string username, string password, string Phone)
        {
            MySqlConnection conn = new MySqlConnection(ServerNames.CDT);
            string sqlQuerty1 = $@"INSERT INTO natan (UserName,Password1,Phone) VALUES ('{username}','{password}','{Phone}')";
            MySqlCommand comm = new MySqlCommand(sqlQuerty1, conn);
            Customer cust = null;
            conn.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                int id = dr.GetInt32(0);
                string name = dr.GetString(1);
                cust = new Customer(name, id);
            }
            conn.Close();
            Customer cust1 = Login(username, password);
            if (cust1 != null) { return true; }
            else { return false; }
        }
        public static bool ChangePassword(string username, string password, string newpassword)
        {
            MySqlConnection conn = new MySqlConnection(ServerNames.CDT);
            Customer cust0 = Login(username, password);
            if (cust0 != null)
            {
                string sqlQuerty1 = $@"UPDATE natan SET Password1 = '{newpassword}' 
             WHERE UserName = '{username}'";
                MySqlCommand comm = new MySqlCommand(sqlQuerty1, conn);
                Customer cust = null;
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string name = dr.GetString(1);
                    cust = new Customer(name, id);
                }
                conn.Close();
                Customer cust1 = Login(username, newpassword);
                if (cust1 != null) { return true; }
                else { return false; }
            }
            return false;
            /*public static Customer CreatCustomer(string username, string password)
            {
                if (!File.Exists(ServerNames.CDT)) return null;
                StreamReader sr = new StreamReader(ServerNames.CDT);
                string line;

                line= sr.ReadLine();
                while(line !=null)
                {
                    string usr = line.Substring(0,line.IndexOf(";"));
                    string pass = line.Substring(line.IndexOf(";") + 1);
                    if (usr == username && pass == password)
                    {
                        sr.Close();
                        return new Customer(username, password);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                return null;
            }
            public static bool AddCustomer(string username, string password)
            {
                if (!File.Exists(ServerNames.CDT)) return false;
                StreamWriter sw = new StreamWriter(ServerNames.CDT, true);
                sw.WriteLine($"{username};{password}");
                sw.Close();
                return true;
                */
        }

    }
}
