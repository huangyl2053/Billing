using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;
using entity;

namespace server
{
    public class server1
    {
        private MySqlConnection myConnection;
        private billEntity oldEntity = new billEntity();

        public int searchTest(ref ArrayList tips) {
            string query = "select * from bill order by datetime desc";
            sqlConnectionOpen();
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            myCommand.ExecuteNonQuery();
            MySqlDataReader myDataReader = myCommand.ExecuteReader();
            while (myDataReader.Read())
            {
                billEntity entity = new billEntity();
                entity.Datetime = (string)myDataReader["datetime"];
                entity.Tip1Text = (string)myDataReader["tip1text"];
                entity.Tip1 = (string)myDataReader["tip1"];
                entity.Tip2Text = (string)myDataReader["tip2text"];
                entity.Tip2 = (string)myDataReader["tip2"];
                entity.Tip3Text = (string)myDataReader["tip3text"];
                entity.Tip3 = (string)myDataReader["tip3"];
                entity.Total = (string)myDataReader["total"];
                tips.Add(entity);
            }
            sqlConnectionClose();
            myDataReader.Close();
            myCommand.Dispose();
            return 1;
        }

        private void sqlConnectionOpen()
        {
            myConnection = new MySqlConnection("server=localhost;user id=root;password=;database=billing");
            myConnection.Open();
        }

        private void sqlConnectionClose()
        {
            myConnection.Close();
        }

        public int save(billEntity entity)
        {
            int status = 999;
            Boolean isUpdate = false;
            string nowDate = DateTime.Now.ToShortDateString();

            sqlConnectionOpen();
            string query = "select * from bill where datetime=@datetime";
            MySqlCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = query;
//new MySqlCommand(query, myConnection);
            myCommand.Parameters.AddWithValue("@datetime", nowDate);
            myCommand.ExecuteNonQuery();
            MySqlDataReader myDataReader = myCommand.ExecuteReader();
            while (myDataReader.Read())
            {
                oldEntity.Datetime = (string)myDataReader["datetime"];
                oldEntity.Tip1 = (string)myDataReader["tip1"];
                oldEntity.Tip2 = (string)myDataReader["tip2"];
                oldEntity.Tip3 = (string)myDataReader["tip3"];
                oldEntity.Total = (string)myDataReader["total"];
                isUpdate = true;
            }
            myDataReader.Close();

            if (isUpdate)
            {
                query = "UPDATE bill SET  tip1text=@tip1text, tip1=@tip1, tip2text=@tip2text, tip2=@tip2, tip3text=@tip3text, tip3=@tip3, total = @total, today = @today WHERE  datetime = @datetime ";

            }
            else
            {
                query = "insert into bill (datetime,tip1text,tip1,tip2text,tip2,tip3text,tip3,total,today) values ( @datetime, @tip1text, @tip1, @tip2text, @tip2, @tip3text,@tip3,  @total, @today) ";

            } 
            myCommand = myConnection.CreateCommand();
            myCommand.CommandText = query;
            myCommand.Parameters.AddWithValue("@datetime", nowDate);
            myCommand.Parameters.AddWithValue("@tip1text", getName(entity, 1));
            myCommand.Parameters.AddWithValue("@tip1", getTip(entity, 1));
            myCommand.Parameters.AddWithValue("@tip2text", getName(entity,2));
            myCommand.Parameters.AddWithValue("@tip2", getTip(entity, 2));
            myCommand.Parameters.AddWithValue("@tip3text", getName(entity, 3));
            myCommand.Parameters.AddWithValue("@tip3", getTip(entity, 3));
            myCommand.Parameters.AddWithValue("@total", getTotal(entity));
            myCommand.Parameters.AddWithValue("@today", entity.Today);
            myCommand.ExecuteNonQuery();

            myCommand.Dispose();
            sqlConnectionClose();
            return status;

        }

        private string getName(billEntity entity, int i)
        {
            switch (i)
            {
                case 1:
                    if (!string.IsNullOrEmpty(entity.Tip1Text))
                    {
                        return entity.Tip1Text;
                    }
                    else { 
                        return oldEntity.Tip1Text;
                    }
                case 2:
                    if (!string.IsNullOrEmpty(entity.Tip2Text))
                    {
                        return entity.Tip2Text;
                    }
                    else
                    {
                        return oldEntity.Tip2Text;
                    }
                case 3:
                    if (!string.IsNullOrEmpty(entity.Tip3Text))
                    {
                        return entity.Tip3Text;
                    }
                    else
                    {
                        return oldEntity.Tip3Text;
                    }
            }
            return string.Empty;
        }

        private string getTip(billEntity entity,int i)
        {
            int tip=0;
            switch (i)
            {
                case 1:
                    tip = getNum(entity.Tip1) + getNum(oldEntity.Tip1);
                    break;
                case 2:
                    tip = getNum(entity.Tip2) + getNum(oldEntity.Tip2);
                    break;
                case 3:
                    tip = getNum(entity.Tip3) + getNum(oldEntity.Tip3);
                    break;
            }
            return tip.ToString();
        }

        private int getNum(string tip)
        {
            if (string.IsNullOrEmpty(tip))
            {
                return 0;
            }
            else {
                return Int32.Parse(tip);
            }
        }

        private string getTotal(billEntity entity)
        {
            int total = getNum(entity.Tip1) + getNum(entity.Tip2) + getNum(entity.Tip3) + getNum(oldEntity.Total);
            return total.ToString();
        }
    }
}
