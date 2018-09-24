using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
namespace Student_Time_Tracker_1._0
{
    
    public partial class Form6 : Form
    {// declares passer vars
            public static bool Student1_Selected;
            public static bool Student2_Selected;
            public static bool Student3_Selected;
            public static bool Student4_Selected;
            public static bool Student5_Selected;
            public static bool Student6_Selected;
            public static bool Student7_Selected;
            public static bool Student8_Selected;
            public static bool Student9_Selected;
            public static bool Student10_Selected;
            public static bool Student11_Selected;
            public static bool Student12_Selected;
            public static bool Student13_Selected;
            public static bool Student14_Selected;
            public static bool Student15_Selected;
            public static bool Student16_Selected;
            public static bool Student17_Selected;
            public static bool Student18_Selected;
            public static bool Student19_Selected;
            public static bool Student20_Selected;
            public static bool Student21_Selected;
            public static bool Student22_Selected;
            public static bool Student23_Selected;
            public static bool Student24_Selected;
            public static bool Student25_Selected;
            public static bool Student26_Selected;
            public static bool Student27_Selected;
            public static bool Student28_Selected;
            public static bool Student29_Selected;
            public static bool Student30_Selected;

        
        public Form6()
        {
            InitializeComponent();

            
            // Loads stored data onto our vars


            System.Xml.XmlDocument Student_Roster = new System.Xml.XmlDocument();// Set up the XmlDocument (Student Roster) //
            Student_Roster.Load("data.xml"); //Load the data from the file into the XmlDocument  //
            System.Xml.XmlNodeList NodeList = Student_Roster.SelectNodes("/Student_Roster"); // Create a list of the nodes in the xml file //


            // Displays saved data

            foreach (XmlNode xn in NodeList)
            {

                XmlNode a = xn.SelectSingleNode("Student1");
                textBox1.Text = a.ChildNodes.Item(0).InnerText;

                XmlNode b = xn.SelectSingleNode("Student2");
                textBox2.Text = b.ChildNodes.Item(0).InnerText;

                XmlNode c = xn.SelectSingleNode("Student3");
                textBox3.Text = c.ChildNodes.Item(0).InnerText;

                XmlNode d = xn.SelectSingleNode("Student4");
                textBox4.Text = d.ChildNodes.Item(0).InnerText;

                XmlNode e = xn.SelectSingleNode("Student5");
                textBox5.Text = e.ChildNodes.Item(0).InnerText;

                XmlNode f = xn.SelectSingleNode("Student6");
                textBox6.Text = f.ChildNodes.Item(0).InnerText;

                XmlNode g = xn.SelectSingleNode("Student7");
                textBox7.Text = g.ChildNodes.Item(0).InnerText;

                XmlNode h = xn.SelectSingleNode("Student8");
                textBox8.Text = h.ChildNodes.Item(0).InnerText;

                XmlNode i = xn.SelectSingleNode("Student9");
                textBox9.Text = i.ChildNodes.Item(0).InnerText;

                XmlNode j = xn.SelectSingleNode("Student10");
                textBox10.Text = j.ChildNodes.Item(0).InnerText;

                XmlNode k = xn.SelectSingleNode("Student11");
                textBox11.Text = k.ChildNodes.Item(0).InnerText;

                XmlNode l = xn.SelectSingleNode("Student12");
                textBox12.Text = l.ChildNodes.Item(0).InnerText;

                XmlNode m = xn.SelectSingleNode("Student13");
                textBox13.Text = m.ChildNodes.Item(0).InnerText;

                XmlNode n = xn.SelectSingleNode("Student14");
                textBox14.Text = n.ChildNodes.Item(0).InnerText;

                XmlNode o = xn.SelectSingleNode("Student15");
                textBox15.Text = o.ChildNodes.Item(0).InnerText;

                XmlNode p = xn.SelectSingleNode("Student16");
                textBox16.Text = p.ChildNodes.Item(0).InnerText;

                XmlNode q = xn.SelectSingleNode("Student17");
                textBox17.Text = q.ChildNodes.Item(0).InnerText;

                XmlNode r = xn.SelectSingleNode("Student18");
                textBox18.Text = r.ChildNodes.Item(0).InnerText;

                XmlNode s = xn.SelectSingleNode("Student19");
                textBox19.Text = s.ChildNodes.Item(0).InnerText;

                XmlNode t = xn.SelectSingleNode("Student20");
                textBox20.Text = t.ChildNodes.Item(0).InnerText;

                XmlNode u = xn.SelectSingleNode("Student21");
                textBox21.Text = u.ChildNodes.Item(0).InnerText;

                XmlNode v = xn.SelectSingleNode("Student22");
                textBox22.Text = v.ChildNodes.Item(0).InnerText;

                XmlNode w = xn.SelectSingleNode("Student23");
                textBox23.Text = w.ChildNodes.Item(0).InnerText;

                XmlNode x = xn.SelectSingleNode("Student24");
                textBox24.Text = x.ChildNodes.Item(0).InnerText;

                XmlNode y = xn.SelectSingleNode("Student25");
                textBox25.Text = y.ChildNodes.Item(0).InnerText;

                XmlNode z = xn.SelectSingleNode("Student26");
                textBox26.Text = z.ChildNodes.Item(0).InnerText;

                XmlNode aa = xn.SelectSingleNode("Student27");
                textBox27.Text = aa.ChildNodes.Item(0).InnerText;

                XmlNode bb = xn.SelectSingleNode("Student28");
                textBox28.Text = bb.ChildNodes.Item(0).InnerText;

                XmlNode cc = xn.SelectSingleNode("Student29");
                textBox29.Text = cc.ChildNodes.Item(0).InnerText;

                XmlNode dd = xn.SelectSingleNode("Student30");
                textBox30.Text = dd.ChildNodes.Item(0).InnerText;

            }//End For each


        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Student1_Selected = true;
            }
            if (checkBox2.Checked == true)
            {
                Student2_Selected = true;
            }
            if (checkBox2.Checked == true)
            {
                Student2_Selected = true;
            }
            if (checkBox3.Checked == true)
            {
                Student3_Selected = true;
            }
            if (checkBox4.Checked == true)
            {
                Student4_Selected = true;
            }
            if (checkBox5.Checked == true)
            {
                Student5_Selected = true;
            }
            if (checkBox6.Checked == true)
            {
                Student6_Selected = true;
            }
            if (checkBox7.Checked == true)
            {
                Student7_Selected = true;
            }
            if (checkBox8.Checked == true)
            {
                Student8_Selected = true;
            }
            if (checkBox9.Checked == true)
            {
                Student9_Selected = true;
            }
            if (checkBox10.Checked == true)
            {
                Student10_Selected = true;
            }
            if (checkBox11.Checked == true)
            {
                Student11_Selected = true;
            }
            if (checkBox12.Checked == true)
            {
                Student12_Selected = true;
            }
            if (checkBox13.Checked == true)
            {
                Student13_Selected = true;
            }
            if (checkBox14.Checked == true)
            {
                Student14_Selected = true;
            }
            if (checkBox15.Checked == true)
            {
                Student15_Selected = true;
            }
            if (checkBox16.Checked == true)
            {
                Student16_Selected = true;
            }
            if (checkBox17.Checked == true)
            {
                Student17_Selected = true;
            }
            if (checkBox18.Checked == true)
            {
                Student18_Selected = true;
            }
            if (checkBox19.Checked == true)
            {
                Student19_Selected = true;
            }
            if (checkBox20.Checked == true)
            {
                Student20_Selected = true;
            }
            if (checkBox21.Checked == true)
            {
                Student21_Selected = true;
            }
            if (checkBox22.Checked == true)
            {
                Student22_Selected = true;
            }
            if (checkBox23.Checked == true)
            {
                Student23_Selected = true;
            }
            if (checkBox24.Checked == true)
            {
                Student24_Selected = true;
            }
            if (checkBox25.Checked == true)
            {
                Student25_Selected = true;
            }
            if (checkBox26.Checked == true)
            {
                Student26_Selected = true;
            }
            if (checkBox27.Checked == true)
            {
                Student27_Selected = true;
            }
            if (checkBox28.Checked == true)
            {
                Student28_Selected = true;
            }
            if (checkBox29.Checked == true)
            {
                Student29_Selected = true;
            }
            if (checkBox30.Checked == true)
            {
                Student30_Selected = true;
            }
            if (checkBox31.Checked == true)
            {
                Form10 Reading = new Form10();
                Reading.Show(); // Shows Reading Stats
                if (checkBox1.Checked == true)
                {
                    Student1_Selected = true;

                }
            }
            if (checkBox32.Checked == true)
                {
                    Form11 Math = new Form11();
                    Math.Show(); // Shows Math Stats
                }
            if (checkBox33.Checked == true)
                    {
                        Form12 Social = new Form12();
                        Social.Show(); // Shows Social Studies Stats
                    }
            if (checkBox34.Checked == true)
                    {
                        Form13 Science = new Form13();
                        Science.Show(); // Shows Science Stats
                    }
           
            }
        }

    }
