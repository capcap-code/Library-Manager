using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DoAn.view
{
    public partial class clientData1 : UserControl
    {
        public clientData1()
        {
            InitializeComponent();
        }
        [Category("clientData")]
        public string CustomerName
        {
            get { return clientName.Text; }
            set { clientName.Text = value; }
        }

        [Category("clientData")]
        public string CustomerPhone
        {
            get { return clientPhone.Text; }
            set { clientPhone.Text = value; }
        }

        [Category("clientData")]
        public string RentedBooksCount
        {
            get { return clientBook.Text; }
            set { clientBook.Text = value; }
        }
    }
}
