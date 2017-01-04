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
            serverTest a = new serverTest();
            ArrayList tips = new ArrayList();
            int i = a.searchTest(ref tips);
            DataSet.tableDataTable dt = new DataSet.tableDataTable();
            foreach (billEntity entity in tips) {
                DataSet.tableRow row = dt.NewtableRow();
                row.datetime = entity.Datetime;
                row.Tip1 = entity.Tip1;
                row.Tip2 = entity.Tip2;
                row.Tip3 = entity.Tip3;
                dt.AddtableRow(row);
            }
            this.Grid.DataSource = dt;
        }

        private void save_Click(object sender, EventArgs e)
        {
            serverTest a = new serverTest();
            billEntity entity = new billEntity();
            entity.Tip1 = this.Text_Tip1.Text;
            entity.Tip2 = this.Text_Tip2.Text;
            entity.Tip3 = this.Text_Tip3.Text;
            int status=a.save(entity);
            this.search_Click(sender,e);

        }
    }
}