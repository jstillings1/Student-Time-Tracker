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
using System.IO;

namespace Student_Time_Tracker_1._0
{
    public partial class Form10 : Form
    {
        public Form10()
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
                XmlNode la = xn.SelectSingleNode("Student1/Reading_Lesson");
                XmlNode ta = xn.SelectSingleNode("Student1/Time");

                XmlNode b = xn.SelectSingleNode("Student2");
                XmlNode bl = xn.SelectSingleNode("Student2/Reading_Lesson");
                XmlNode tb = xn.SelectSingleNode("Student2/Time");

                XmlNode c = xn.SelectSingleNode("Student3");


                XmlNode d = xn.SelectSingleNode("Student4");


                XmlNode e = xn.SelectSingleNode("Student5");


                XmlNode f = xn.SelectSingleNode("Student6");


                XmlNode g = xn.SelectSingleNode("Student7");


                XmlNode h = xn.SelectSingleNode("Student8");


                XmlNode i = xn.SelectSingleNode("Student9");


                XmlNode j = xn.SelectSingleNode("Student10");


                XmlNode k = xn.SelectSingleNode("Student11");


                XmlNode l = xn.SelectSingleNode("Student12");


                XmlNode m = xn.SelectSingleNode("Student13");


                XmlNode n = xn.SelectSingleNode("Student14");

                XmlNode o = xn.SelectSingleNode("Student15");


                XmlNode p = xn.SelectSingleNode("Student16");


                XmlNode q = xn.SelectSingleNode("Student17");


                XmlNode r = xn.SelectSingleNode("Student18");


                XmlNode s = xn.SelectSingleNode("Student19");


                XmlNode t = xn.SelectSingleNode("Student20");


                XmlNode u = xn.SelectSingleNode("Student21");


                XmlNode v = xn.SelectSingleNode("Student22");


                XmlNode w = xn.SelectSingleNode("Student23");


                XmlNode x = xn.SelectSingleNode("Student24");


                XmlNode y = xn.SelectSingleNode("Student25");


                XmlNode z = xn.SelectSingleNode("Student26");


                XmlNode aa = xn.SelectSingleNode("Student27");


                XmlNode bb = xn.SelectSingleNode("Student28");


                XmlNode cc = xn.SelectSingleNode("Student29");


                XmlNode dd = xn.SelectSingleNode("Student30");


                //End For each



              
                if (Form6.Student1_Selected == true)
                {

                    TextBox Student1_textBox = new TextBox();
                    Student1_textBox.Location = new Point(25, 25);
                    this.Controls.Add(Student1_textBox);
                    Student1_textBox.Text = a.ChildNodes.Item(0).InnerText;
                    System.Xml.XmlNodeList Lesson = Student_Roster.SelectNodes("Student_Roster/Student1/Reading_Lesson/Lesson");
                    var lx_axis = 200;
                    var ly_axis = 25;
                    var lcounter = 1;
                    foreach (XmlNode xy in Lesson)
                    {                                                                 
                        TextBox Readinglesson = new TextBox();
                        Readinglesson.Location = new Point(lx_axis, ly_axis);
                        this.Controls.Add(Readinglesson);
                        Readinglesson.Text = la.ChildNodes.Item(lcounter).InnerText;
                        Size size = TextRenderer.MeasureText(Readinglesson.Text, Readinglesson.Font);
                        Readinglesson.Width = size.Width;
                        Readinglesson.Height = size.Height;


                        lx_axis = lx_axis + 0;
                        ly_axis = ly_axis + 25;
                        ; lcounter++;

                    }

                    System.Xml.XmlNodeList Time = Student_Roster.SelectNodes("Student_Roster/Student1/Time/Time");
                    var tx_axis = 875;
                    var ty_axis =25;
                    var tcounter = 1;
                    foreach ( XmlNode txy in Time)
                    {
                        TextBox timetotal = new TextBox();
                        timetotal.Location = new Point(tx_axis, ty_axis);
                        this.Controls.Add(timetotal);
                        timetotal.Text = ta.ChildNodes.Item(tcounter).InnerText;

                        tx_axis = tx_axis + 0;
                        ty_axis = ty_axis + 25;
                        ; tcounter++;

                    }


                }

                if (Form6.Student2_Selected == true)
                {

                    TextBox Student2_textBox = new TextBox();
                    Student2_textBox.Location = new Point(25, 25);
                    this.Controls.Add(Student2_textBox);
                    Student2_textBox.Text = b.ChildNodes.Item(0).InnerText;
                    System.Xml.XmlNodeList Lesson = Student_Roster.SelectNodes("Student_Roster/Student2/Reading_Lesson/Lesson");
                    var lx_axis = 200;
                    var ly_axis = 25;
                    var lcounter = 1;
                    foreach (XmlNode xy in Lesson)
                    {
                        TextBox Readinglesson = new TextBox();
                        Readinglesson.Location = new Point(lx_axis, ly_axis);
                        this.Controls.Add(Readinglesson);
                        Readinglesson.Text = bl.ChildNodes.Item(lcounter).InnerText;
                        Size size = TextRenderer.MeasureText(Readinglesson.Text, Readinglesson.Font);
                        Readinglesson.Width = size.Width;
                        Readinglesson.Height = size.Height;


                        lx_axis = lx_axis + 0;
                        ly_axis = ly_axis + 25;
                        ; lcounter++;

                    }

                    System.Xml.XmlNodeList Time = Student_Roster.SelectNodes("Student_Roster/Student2/Time/Time");
                    var tx_axis = 875;
                    var ty_axis = 25;
                    var tcounter = 1;
                    foreach (XmlNode txy in Time)
                    {
                        TextBox timetotal = new TextBox();
                        timetotal.Location = new Point(tx_axis, ty_axis);
                        this.Controls.Add(timetotal);
                        timetotal.Text = tb.ChildNodes.Item(tcounter).InnerText;

                        tx_axis = tx_axis + 0;
                        ty_axis = ty_axis + 25;
                        ; tcounter++;

                    }


                }

            }
        }
    }
}