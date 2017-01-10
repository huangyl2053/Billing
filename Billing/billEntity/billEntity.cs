using System;
using System.Collections.Generic;
using System.Text;

namespace entity
{
    public class billEntity
    {
        private string _datetime;
        private string _tip1 = "0";
        private string _tip2 = "0";
        private string _tip3 = "0";
        private string _tip4 = "0";
        private string _tip1Text=string.Empty;
        private string _tip2Text = string.Empty;
        private string _tip3Text = string.Empty;
        private string _tip4Text = string.Empty;
        private string _total = "0";
        private string _today = string.Empty;

        public string Datetime
        {
            get { return _datetime; }
            set { _datetime = value; }
        }

        public string Tip1
        {
            get { return _tip1; }
            set { _tip1 = value; }
        }

        public string Tip2
        {
            get { return _tip2; }
            set { _tip2 = value; }
        }

        public string Tip3
        {
            get { return _tip3; }
            set { _tip3 = value; }
        }

        public string Tip4
        {
            get { return _tip4; }
            set { _tip4 = value; }
        }

        public string Tip1Text
        {
            get { return _tip1Text; }
            set { _tip1Text = value; }
        }

        public string Tip2Text
        {
            get { return _tip2Text; }
            set { _tip2Text = value; }
        }

        public string Tip3Text
        {
            get { return _tip3Text; }
            set { _tip3Text = value; }
        }

        public string Tip4Text
        {
            get { return _tip4Text; }
            set { _tip4Text = value; }
        }

        public string Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public string Today
        {
            get { return _today; }
            set { _today = value; }
        }
    }
}
