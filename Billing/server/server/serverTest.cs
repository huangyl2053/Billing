using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;

namespace server
{
    public class serverTest
    {
        public int searchTest(ref ArrayList tips) {
            string query = "select * from test";

            MySqlConnection myConnection = new MySqlConnection("server=localhost;user id=root;password=root;database=billing");
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            MySqlDataReader myDataReader = myCommand.ExecuteReader();
            while (myDataReader.Read() == true)
            {
                tips.Add(myDataReader["tip1"]);
            }  
            myDataReader.Close();
            myCommand.Dispose();
            myConnection.Close();
            return 1;
        }
        public int save() {
            int status = 999;

            //MySqlConnection myConnection = new MySqlConnection("server=localhost;user id=root;password=root;database=billing");
            //MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            //myConnection.Open();
            //myCommand.ExecuteNonQuery();
            //MySqlDataReader myDataReader = myCommand.ExecuteReader();
            //while (myDataReader.Read() == true)
            //{
            //    tips.Add(myDataReader["tip1"]);
            //}
            //myDataReader.Close();
            //myCommand.Dispose();
            //myConnection.Close();
            return status;

        }
    }
}
