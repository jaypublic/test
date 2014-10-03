using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aaa");
<<<<<<< HEAD
            MessageBox.Show("bbb");//test
=======
            MessageBox.Show("bbb");
            MessageBox.Show("ccc");
>>>>>>> 6ee6a16fc315807982729c65c3485de7914a1934
        }
    }
}
