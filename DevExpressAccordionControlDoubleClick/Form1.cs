using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressAccordionControlDoubleClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        bool isDoubleClick = false;

        private void accordionControl1_DoubleClick(object sender, EventArgs e)
        {
            isDoubleClick = true;
        }

        private void accordionControl1_ElementClick(object sender, ElementClickEventArgs e)
        {
            //isDoubleClick && e.Element.Style = ElementStyle.Item (only item double click)
            // item or group double click
            if (isDoubleClick)
            {
                isDoubleClick = false;
                MessageBox.Show(e.Element.Text);
                //////
            }
        }
    }
}
