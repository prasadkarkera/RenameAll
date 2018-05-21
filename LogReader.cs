using System;
using System.IO;
using System.Windows.Forms;

namespace Rename
{
    /// <summary>
    /// Summary description for LogReader.
    /// </summary>
    public class LogReader : Form1
    {
        public LogReader()
        {
            //
            // TODO: Add constructor logic here
            //

        }

        public void Log()
        {
            File.Copy("RenameAll.log", "tempcopyRenameAll.log");
            FileStream f = new FileStream("tempcopyRenameAll.log", FileMode.Open);
            StreamReader s = new StreamReader(f);
           
            try
            {
                string line = s.ReadLine();
                while (line != null)
                {
                    if ((line.IndexOf("INFO") > 0))
                        if (line.IndexOf("Logger Initialised") < 0)
                            if (line.IndexOf("The files have been successfully renamed") < 0)
                                if (line.IndexOf("Could not be Renamed to") < 0)
                                {
                                    dateTime.Add(line.Substring(0, 19));
                                    Array arr = line.Split(',');
                                    arr.GetValue(0).ToString();
                                    string line2 = arr.GetValue(1).ToString();

                                    line2 = line2.Remove(0, line2.IndexOf("- ") + 2);
                                    fromPath.Add(line2.Substring(0, line2.IndexOf("Renamed to") - 1));
                                    toPath.Add(line2.Substring(line2.IndexOf("Renamed to") + 11));
                                    if (File.Exists(line2.Substring(line2.IndexOf("Renamed to") + 11)))
                                        exists.Add("Possible");
                                    else
                                        exists.Add("Not Possible");
                                    //MessageBox.Show("from " +arr2.GetValue(6).ToString() + "To:" + arr2.GetValue(9).ToString(),"");
                                }
                    line = s.ReadLine();
                }   
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "");
            }
            s.Close();
            f.Close();
            File.Delete("tempcopyRenameAll.log");
        }
    }
}
