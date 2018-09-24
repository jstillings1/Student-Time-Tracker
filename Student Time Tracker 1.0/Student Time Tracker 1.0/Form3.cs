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
    public partial class Form3 : Form
    {
        public Form3()
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
        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");


            Information info = new Information();
            info.Student1 = textBox1.Text;
            info.Student2 = textBox2.Text;
            info.Student3 = textBox3.Text;
            info.Student4 = textBox4.Text;
            info.Student5 = textBox5.Text;
            info.Student6 = textBox6.Text;
            info.Student7 = textBox7.Text;
            info.Student8 = textBox8.Text;
            info.Student9 = textBox9.Text;
            info.Student10 = textBox10.Text;
            info.Student11 = textBox11.Text;
            info.Student12 = textBox12.Text;
            info.Student13 = textBox13.Text;
            info.Student14 = textBox14.Text;
            info.Student15 = textBox15.Text;
            info.Student16 = textBox16.Text;
            info.Student17 = textBox17.Text;
            info.Student18 = textBox18.Text;
            info.Student19 = textBox19.Text;
            info.Student20 = textBox20.Text;
            info.Student21 = textBox21.Text;
            info.Student22 = textBox22.Text;
            info.Student23 = textBox23.Text;
            info.Student24 = textBox24.Text;
            info.Student25 = textBox25.Text;
            info.Student26 = textBox26.Text;
            info.Student27 = textBox27.Text;
            info.Student28 = textBox28.Text;
            info.Student29 = textBox29.Text;
            info.Student30 = textBox30.Text;
            // Start check box verifications
            if (checkBox1.Checked == true)
            {
                var node = doc.SelectSingleNode("//Student_Roster/Student1/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student1 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student1/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");

            }
            if (checkBox2.Checked == true)
            {
                var node = doc.SelectSingleNode("//Student_Roster/Student2/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student2 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student2/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }
            if (checkBox3.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student3/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student3 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student3/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }
            if (checkBox4.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student4/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student4 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student4/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }
            if (checkBox5.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student4/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student4 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student4/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }
            if (checkBox6.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student6/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student6 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student6/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }
            if (checkBox7.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student7/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student7 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student7/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }
            if (checkBox8.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student8/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student8 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student8/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }
            if (checkBox9.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student9/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student9 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student9/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox10.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student10/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student10 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student10/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }
            if (checkBox11.Checked == true)
            {
                var node = doc.SelectSingleNode("//Student_Roster/Student11/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student11 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student11/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox12.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student12/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student12 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student12/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }
            if (checkBox13.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student13/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student13 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student13/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox14.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student14/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student14 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student14/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox15.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student15/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student15 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student15/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox16.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student16/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student16 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student16/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox17.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student17/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student17 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student17/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox18.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student18/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student18 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student18/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }


            if (checkBox19.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student19/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student19 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student19/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox20.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student20/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student20 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student20/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox21.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student21/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student21 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student21/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox22.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student22/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student22 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student22/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }


            if (checkBox23.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student23/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student23 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student23/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox24.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student24/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student24 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student24/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }
            if (checkBox25.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student25/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student25 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student25/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox26.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student26/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student26 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student26/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }
            if (checkBox27.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student27/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student27 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student27/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox28.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student28/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student28 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student28/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }

            if (checkBox29.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student29/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student29 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student29/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }
            if (checkBox30.Checked == true)
            {

                var node = doc.SelectSingleNode("//Student_Roster/Student30/Math_Lesson");

                XmlElement newReadingElement = doc.CreateElement("Lesson");
                XmlElement newTimeElement = doc.CreateElement("Time");
                newReadingElement.InnerText = textBox33.Text + " : " + info.Student30 + (" Date Selected : ") + monthCalendar1.SelectionRange.Start + (" Start Time: ") + textBox31.Text + (" End Time: ") + textBox32.Text;
                TimeSpan duration = DateTime.Parse(textBox32.Text).Subtract(DateTime.Parse(textBox31.Text));
                newTimeElement.InnerText = duration.ToString(@"hh\:mm");
                node.AppendChild(newReadingElement);
                var node2 = doc.SelectSingleNode("//Student_Roster/Student30/Time");

                node2.AppendChild(newTimeElement);
                doc.Save("data.xml");
            }


            MessageBox.Show("Saved");
        }

      
    }
}
