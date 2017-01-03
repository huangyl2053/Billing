using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using server;
using System.Collections;

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
            foreach (int tip1 in tips) {
                this.Text_Tip1.Text = tip1.ToString();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            serverTest a = new serverTest();
        }
    }
}