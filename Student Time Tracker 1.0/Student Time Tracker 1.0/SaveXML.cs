using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Threading.Tasks;


namespace Student_Time_Tracker_1._0
{
   public class SaveXML
    {
       public static void SaveData (object obj, String filename)
       {
           XmlSerializer sr = new XmlSerializer(obj.GetType());
           TextWriter writer = new StreamWriter(filename);
           sr.Serialize(writer, obj);
           writer.Close();

       }
    }
}
