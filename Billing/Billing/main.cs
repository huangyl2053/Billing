using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using server;
using System.Collections;
using entity;

namespace Billing
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            server1 a = new server1();
            ArrayList tips = new ArrayList();
            int i = a.searchTest(ref tips);
            int all=0;
            DataSet.tableDataTable dt = new DataSet.tableDataTable();
            foreach (billEntity entity in tips) {
                DataSet.tableRow row = dt.NewtableRow();
                row.datetime = entity.Datetime;
                row.Tip1Text = entity.Tip1Text;
                row.Tip1 = entity.Tip1;
                row.Tip2Text = entity.Tip2Text;
                row.Tip2 = entity.Tip2;
                row.Tip3Text = entity.Tip3Text;
                row.Tip3 = entity.Tip3;
                row.Total = entity.Total;
                dt.AddtableRow(row);
                all = all + getNum(entity.Total);
            }
            this.Grid.DataSource = dt;
            this.Label_Total.Text = all.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            server1 a = new server1();
            billEntity entity = new billEntity();
            entity.Tip1Text = this.Text_TipName1.Text;
            entity.Tip1 = this.Text_Tip1.Text;
            entity.Tip2Text = this.Text_TipName2.Text;
            entity.Tip2 = this.Text_Tip2.Text;
            entity.Tip3Text = this.Text_TipName3.Text;
            entity.Tip3 = this.Text_Tip3.Text;
            int status=a.save(entity);
            this.search_Click(sender,e);

        }

        private int getNum(string tip)
        {
            if (string.IsNullOrEmpty(tip))
            {
                return 0;
            }
            else
            {
                return Int32.Parse(tip);
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.search_Click(sender, e);
        }
    }
}