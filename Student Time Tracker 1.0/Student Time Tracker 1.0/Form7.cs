using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace Student_Time_Tracker_1._0
{

    public partial class Form7 : Form
    {
        public Form7()
        {

            InitializeComponent();

            {

                Information info = new Information();

                if (File.Exists("data.xml"))
                {     // Loads stored data onto our vars


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


            }

        }


        //End of loader
        void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("data.xml"))
            {
                //Save data if old data exists

                XmlDocument doc = new XmlDocument();
                Information info = new Information();
                doc.Load("data.xml");
                // Assign read data to a var
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

                // End assignments
                // Null checker

                if (textBox1.Text.Length == 0)
                {
                    info.Student1 = "Seat Vacent";
                }

                if (textBox2.Text.Length == 0)
                {
                    info.Student2 = "Seat Vacent";
                }


                if (textBox3.Text.Length == 0)
                {
                    info.Student3 = "Seat Vacent";
                }

                if (textBox4.Text.Length == 0)
                {
                    info.Student4 = "Seat Vacent";
                }

                if (textBox5.Text.Length == 0)
                {
                    info.Student5 = "Seat Vacent";
                }
                if (textBox6.Text.Length == 0)
                {
                    info.Student6 = "Seat Vacent";
                }
                if (textBox7.Text.Length == 0)
                {
                    info.Student7 = "Seat Vacent";
                }

                if (textBox8.Text.Length == 0)
                {
                    info.Student8 = "Seat Vacent";
                }

                if (textBox9.Text.Length == 0)
                {
                    info.Student9 = "Seat Vacent";
                }
                if (textBox10.Text.Length == 0)
                {
                    info.Student10 = "Seat Vacent";
                }
                if (textBox11.Text.Length == 0)
                {
                    info.Student11 = "Seat Vacent";
                }
                if (textBox12.Text.Length == 0)
                {
                    info.Student12 = "Seat Vacent";
                }
                if (textBox13.Text.Length == 0)
                {
                    info.Student13 = "Seat Vacent";
                }
                if (textBox14.Text.Length == 0)
                {
                    info.Student14 = "Seat Vacent";
                }
                if (textBox15.Text.Length == 0)
                {
                    info.Student15 = "Seat Vacent";
                }
                if (textBox16.Text.Length == 0)
                {
                    info.Student16 = "Seat Vacent";
                }
                if (textBox17.Text.Length == 0)
                {
                    info.Student17 = "Seat Vacent";
                }
                if (textBox18.Text.Length == 0)
                {
                    info.Student18 = "Seat Vacent";
                }
                if (textBox19.Text.Length == 0)
                {
                    info.Student19 = "Seat Vacent";
                }
                if (textBox20.Text.Length == 0)
                {
                    info.Student20 = "Seat Vacent";
                }
                if (textBox21.Text.Length == 0)
                {
                    info.Student21 = "Seat Vacent";
                }
                if (textBox22.Text.Length == 0)
                {
                    info.Student22 = "Seat Vacent";
                }
                if (textBox23.Text.Length == 0)
                {
                    info.Student23 = "Seat Vacent";
                }
                if (textBox24.Text.Length == 0)
                {
                    info.Student24 = "Seat Vacent";
                }
                if (textBox25.Text.Length == 0)
                {
                    info.Student25 = "Seat Vacent";
                }
                if (textBox26.Text.Length == 0)
                {
                    info.Student26 = "Seat Vacent";
                }
                if (textBox27.Text.Length == 0)
                {
                    info.Student27 = "Seat Vacent";
                }
                if (textBox28.Text.Length == 0)
                {
                    info.Student28 = "Seat Vacent";
                }
                if (textBox29.Text.Length == 0)
                {
                    info.Student29 = "Seat Vacent";
                }
                if (textBox30.Text.Length == 0)
                {
                    info.Student30 = "Seat Vacent";
                }
                // End Null Check

                //Rewrite Students

                doc.SelectSingleNode("Student_Roster/Student1/Name").InnerText = info.Student1;
                doc.SelectSingleNode("Student_Roster/Student2/Name").InnerText = info.Student2;
                doc.SelectSingleNode("Student_Roster/Student3/Name").InnerText = info.Student3;
                doc.SelectSingleNode("Student_Roster/Student4/Name").InnerText = info.Student4;
                doc.SelectSingleNode("Student_Roster/Student5/Name").InnerText = info.Student5;
                doc.SelectSingleNode("Student_Roster/Student6/Name").InnerText = info.Student6;
                doc.SelectSingleNode("Student_Roster/Student7/Name").InnerText = info.Student7;
                doc.SelectSingleNode("Student_Roster/Student8/Name").InnerText = info.Student8;
                doc.SelectSingleNode("Student_Roster/Student9/Name").InnerText = info.Student9;
                doc.SelectSingleNode("Student_Roster/Student10/Name").InnerText = info.Student10;
                doc.SelectSingleNode("Student_Roster/Student11/Name").InnerText = info.Student11;
                doc.SelectSingleNode("Student_Roster/Student12/Name").InnerText = info.Student12;
                doc.SelectSingleNode("Student_Roster/Student13/Name").InnerText = info.Student13;
                doc.SelectSingleNode("Student_Roster/Student14/Name").InnerText = info.Student14;
                doc.SelectSingleNode("Student_Roster/Student15/Name").InnerText = info.Student15;
                doc.SelectSingleNode("Student_Roster/Student16/Name").InnerText = info.Student16;
                doc.SelectSingleNode("Student_Roster/Student17/Name").InnerText = info.Student17;
                doc.SelectSingleNode("Student_Roster/Student18/Name").InnerText = info.Student18;
                doc.SelectSingleNode("Student_Roster/Student19/Name").InnerText = info.Student19;
                doc.SelectSingleNode("Student_Roster/Student20/Name").InnerText = info.Student20;
                doc.SelectSingleNode("Student_Roster/Student21/Name").InnerText = info.Student21;
                doc.SelectSingleNode("Student_Roster/Student22/Name").InnerText = info.Student22;
                doc.SelectSingleNode("Student_Roster/Student23/Name").InnerText = info.Student23;
                doc.SelectSingleNode("Student_Roster/Student24/Name").InnerText = info.Student24;
                doc.SelectSingleNode("Student_Roster/Student25/Name").InnerText = info.Student25;
                doc.SelectSingleNode("Student_Roster/Student26/Name").InnerText = info.Student26;
                doc.SelectSingleNode("Student_Roster/Student27/Name").InnerText = info.Student27;
                doc.SelectSingleNode("Student_Roster/Student28/Name").InnerText = info.Student28;
                doc.SelectSingleNode("Student_Roster/Student29/Name").InnerText = info.Student29;
                doc.SelectSingleNode("Student_Roster/Student30/Name").InnerText = info.Student30;
                doc.Save("data.xml");               
             
                
                //display saved
                MessageBox.Show("Saved");
            }



            else
            {
                //Creates a new data file if there isnt one.

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.NewLineOnAttributes = true;


                using (XmlWriter writer = XmlWriter.Create("data.xml", settings))
                {
                    Information info = new Information();
                    info.Student1  = textBox1.Text;
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

                    // Null checker

                    if (textBox1.Text.Length == 0)
                    {
                        info.Student1 = "Seat Vacent";
                    }

                    if (textBox2.Text.Length == 0)
                    {
                        info.Student2 = "Seat Vacent";
                    }


                    if (textBox3.Text.Length == 0)
                    {
                        info.Student3 = "Seat Vacent";
                    }

                    if (textBox4.Text.Length == 0)
                    {
                        info.Student4 = "Seat Vacent";
                    }

                    if (textBox5.Text.Length == 0)
                    {
                        info.Student5 = "Seat Vacent";
                    }
                    if (textBox6.Text.Length == 0)
                    {
                        info.Student6 = "Seat Vacent";
                    }
                    if (textBox7.Text.Length == 0)
                    {
                        info.Student7 = "Seat Vacent";
                    }

                    if (textBox8.Text.Length == 0)
                    {
                        info.Student8 = "Seat Vacent";
                    }

                    if (textBox9.Text.Length == 0)
                    {
                        info.Student9 = "Seat Vacent";
                    }
                    if (textBox10.Text.Length == 0)
                    {
                        info.Student10 = "Seat Vacent";
                    }
                    if (textBox11.Text.Length == 0)
                    {
                        info.Student11 = "Seat Vacent";
                    }
                    if (textBox12.Text.Length == 0)
                    {
                        info.Student12 = "Seat Vacent";
                    }
                    if (textBox13.Text.Length == 0)
                    {
                        info.Student13 = "Seat Vacent";
                    }
                    if (textBox14.Text.Length == 0)
                    {
                        info.Student14 = "Seat Vacent";
                    }
                    if (textBox15.Text.Length == 0)
                    {
                        info.Student15 = "Seat Vacent";
                    }
                    if (textBox16.Text.Length == 0)
                    {
                        info.Student16 = "Seat Vacent";
                    }
                    if (textBox17.Text.Length == 0)
                    {
                        info.Student17 = "Seat Vacent";
                    }
                    if (textBox18.Text.Length == 0)
                    {
                        info.Student18 = "Seat Vacent";
                    }
                    if (textBox19.Text.Length == 0)
                    {
                        info.Student19 = "Seat Vacent";
                    }
                    if (textBox20.Text.Length == 0)
                    {
                        info.Student20 = "Seat Vacent";
                    }
                    if (textBox21.Text.Length == 0)
                    {
                        info.Student21 = "Seat Vacent";
                    }
                    if (textBox22.Text.Length == 0)
                    {
                        info.Student22 = "Seat Vacent";
                    }
                    if (textBox23.Text.Length == 0)
                    {
                        info.Student23 = "Seat Vacent";
                    }
                    if (textBox24.Text.Length == 0)
                    {
                        info.Student24 = "Seat Vacent";
                    }
                    if (textBox25.Text.Length == 0)
                    {
                        info.Student25 = "Seat Vacent";
                    }
                    if (textBox26.Text.Length == 0)
                    {
                        info.Student26 = "Seat Vacent";
                    }
                    if (textBox27.Text.Length == 0)
                    {
                        info.Student27 = "Seat Vacent";
                    }
                    if (textBox28.Text.Length == 0)
                    {
                        info.Student28 = "Seat Vacent";
                    }
                    if (textBox29.Text.Length == 0)
                    {
                        info.Student29 = "Seat Vacent";
                    }
                    if (textBox30.Text.Length == 0)
                    {
                        info.Student30 = "Seat Vacent";
                    }
                   
                    //Open writer
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Student_Roster");
                    var counter = 1;
                    //Create Student 1
                          
                    writer.WriteStartElement("Student1");
                    writer.WriteElementString("Name", info.Student1);
                    writer.WriteElementString("ID", counter.ToString());
                   
                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                  
                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    
                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                   
                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 2
                    writer.WriteStartElement("Student2");
                    writer.WriteElementString("Name", info.Student2);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;

                    //Create Student 3
                    writer.WriteStartElement("Student3");
                    writer.WriteElementString("Name", info.Student3);
                   
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 4
                    writer.WriteStartElement("Student4");
                    writer.WriteElementString("Name", info.Student4);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 5
                    writer.WriteStartElement("Student5");
                    writer.WriteElementString("Name", info.Student5);
                   
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 6
                    writer.WriteStartElement("Student6");
                    writer.WriteElementString("Name", info.Student6);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 7
                    writer.WriteStartElement("Student7");
                    writer.WriteElementString("Name", info.Student7);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 8
                    writer.WriteStartElement("Student8");
                    writer.WriteElementString("Name", info.Student8);
                   
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 9
                    writer.WriteStartElement("Student9");
                    writer.WriteElementString("Name", info.Student9);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 10
                    writer.WriteStartElement("Student10");
                    writer.WriteElementString("Name", info.Student10);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 11
                    writer.WriteStartElement("Student11");
                    writer.WriteElementString("Name", info.Student11);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 12
                    writer.WriteStartElement("Student12");
                    writer.WriteElementString("Name", info.Student12);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 13
                    writer.WriteStartElement("Student13");
                    writer.WriteElementString("Name", info.Student13);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 14
                    writer.WriteStartElement("Student14");
                    writer.WriteElementString("Name", info.Student14);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 15
                    writer.WriteStartElement("Student15");
                    writer.WriteElementString("Name", info.Student15);
                   
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 16
                    writer.WriteStartElement("Student16");
                    writer.WriteElementString("Name", info.Student16);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 17
                    writer.WriteStartElement("Student17");
                    writer.WriteElementString("Name", info.Student17);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 18
                    writer.WriteStartElement("Student18");
                    writer.WriteElementString("Name", info.Student18);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 19
                    writer.WriteStartElement("Student19");
                    writer.WriteElementString("Name", info.Student19);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 20
                    writer.WriteStartElement("Student20");
                    writer.WriteElementString("Name", info.Student20);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 21
                    writer.WriteStartElement("Student21");
                    writer.WriteElementString("Name", info.Student21);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 22
                    writer.WriteStartElement("Student22");
                    writer.WriteElementString("Name", info.Student22);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 23
                    writer.WriteStartElement("Student23");
                    writer.WriteElementString("Name", info.Student23);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 24
                    writer.WriteStartElement("Student24");
                    writer.WriteElementString("Name", info.Student24);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 25
                    writer.WriteStartElement("Student25");
                    writer.WriteElementString("Name", info.Student25);
                   
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 26
                    writer.WriteStartElement("Student26");
                    writer.WriteElementString("Name", info.Student26);
                   
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 27
                    writer.WriteStartElement("Student27");
                    writer.WriteElementString("Name", info.Student27);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 28
                    writer.WriteStartElement("Student28");
                    writer.WriteElementString("Name", info.Student28);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 29
                    writer.WriteStartElement("Student29");
                    writer.WriteElementString("Name", info.Student29);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                    counter++;
                    //Create Student 30
                    writer.WriteStartElement("Student30");
                    writer.WriteElementString("Name", info.Student30);
                    
                    writer.WriteElementString("ID", counter.ToString());

                    writer.WriteElementString("Reading_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Math_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Social_Studies_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");

                    writer.WriteElementString("Science_Lesson", "Blank");
                    writer.WriteElementString("Time", "0");
                    writer.WriteEndElement();
                
















                   //End of Student Creation
                    writer.WriteEndDocument();
                    // Close writer
                    writer.Flush();
                    writer.Close();
                    //display saved
                    MessageBox.Show("Saved");
                                   
                }

            }
        }




    }
}
    


        
    
        
      

    
    
    

