using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Time_Tracker_1._0
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            var FormStart = new Form9();
           

            FormStart.MdiParent = this;
            FormStart.Show();
                                   
        }  
           
        
        private void Loadform2(object sender, EventArgs e)
        {
            var newMDIChild2 = new Form2();
            ActiveMdiChild.Close();
            var FormStart = new Form9();
            FormStart.MdiParent = this;
            FormStart.Show();
            newMDIChild2.MdiParent = this;
            newMDIChild2.Show();
            
                    
            
        }

        private void LoadForm3(object sender, EventArgs e)
        {
            var newMDIChild3 = new Form3();
            ActiveMdiChild.Close();
            var FormStart = new Form9();
            FormStart.MdiParent = this;
            FormStart.Show();
            newMDIChild3.MdiParent = this;
            newMDIChild3.Show();
           
        }

        private void LoadForm4(object sender, EventArgs e)
        {
            var newMDIChild4 = new Form4();
            ActiveMdiChild.Close();
            var FormStart = new Form9();
            FormStart.MdiParent = this;
            FormStart.Show();
            newMDIChild4.MdiParent = this;
            newMDIChild4.Show();
            
            
        }

        private void LoadForm5(object sender, EventArgs e)
        {
            var newMDIChild5 = new Form5();
            ActiveMdiChild.Close();
            var FormStart = new Form9();
            FormStart.MdiParent = this;
            FormStart.Show();
            newMDIChild5.MdiParent = this;
            newMDIChild5.Show();
           
            
        }

        private void LoadForm6(object sender, EventArgs e)
        {
            var newMDIChild6 = new Form6();
            ActiveMdiChild.Close();
            var FormStart = new Form9();
            FormStart.MdiParent = this;
            FormStart.Show();
            newMDIChild6.MdiParent = this;
            newMDIChild6.Show();
            
        }

        private void LoadForm7(object sender, EventArgs e)
        {
            var newMDIChild7 = new Form7();
            ActiveMdiChild.Close();
            var FormStart = new Form9();
            FormStart.MdiParent = this;
            FormStart.Show();
            newMDIChild7.MdiParent = this;
            newMDIChild7.Show();
           
        }

        private void LoadForm8(object sender, EventArgs e)
        {
            var newMDIChild8 = new Form8();
            ActiveMdiChild.Close();
            var FormStart = new Form9();
            FormStart.MdiParent = this;
            FormStart.Show();
            newMDIChild8.MdiParent = this;
            newMDIChild8.Show();
           
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        
    }
   
}
