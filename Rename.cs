using System;
using System.IO;
using System.Windows.Forms;
using Rename;
using System.Globalization;
using System.Threading;
using Microsoft.Win32;

namespace Rename
{
	/// <summary>
	/// Summary description for Rename.
	/// This class contains the procedure for renaming the files
	/// </summary>
	public class RenameFiles : Form1
	{
		public RenameFiles() 
		{ 
				
		}

		public void RenameFiles1(ListBox FilesSelectedlist)
		{
            FileStream f = new FileStream("undo.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            try
            {
                int i = 0;
                string newpath, oldpath, space, digit;
                //RegistryKey rootkey, license;

                //rootkey = Registry.LocalMachine.OpenSubKey("Software", true);
                //license = rootkey.OpenSubKey("RenLis");

                // Display the names of the files.

                if (selectedFiles.Count > 0)
                {
                    for (i = 0; i < selectedFiles.Count; i++)
                    {

                        //Change the prefix to something that is not already there

                        //Get the culture property of the thread.
                        CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                        //Create TextInfo object.
                        TextInfo textInfo = cultureInfo.TextInfo;

                        string pathFilename = selectedFiles[i].ToString();

                        Array arr = pathFilename.Split('\\');
                        string oldFilenameWithExt = arr.GetValue(arr.Length - 1).ToString(); //filename with extension

                        Array arrExt = oldFilenameWithExt.Split('.');
                        string extension = arrExt.GetValue(arrExt.Length - 1).ToString();

                        string oldFilename = "";
                        for (int j = 0; j < arrExt.Length - 1; j++)
                            oldFilename = oldFilename + arrExt.GetValue(j).ToString();

                        oldpath = "";
                        for (int j = 0; j < arr.Length - 1; j++)
                            oldpath = oldpath + arr.GetValue(j).ToString() + "\\";


                        //	MessageBox.Show(selectedFiles[i].ToString().Split('\\','1'),"OldPath");
                        if (changeCase == true)
                        {
                            if (toLowerCheck == true)
                            {
                                oldFilename = oldFilename.ToLower();
                                extension = extension.ToLower();
                            }

                            if (toUpperCheck == true)
                            {
                                oldFilename = oldFilename.ToUpper();
                                extension = extension.ToUpper();
                            }

                            if (toTitleCheck == true)
                                oldFilename = textInfo.ToTitleCase(oldFilename);
                        }

                        // Remove digits space and alphabets
                        if (remove_DSA == true)
                        {
                            digit = Properties.Settings.Default.removeDigit;
                            if (removeDigitsCheck == true)
                            {
                                if (digit == "All")
                                    for (int k = 0; k < 10; k++)
                                        oldFilename = oldFilename.Replace(digits[k].ToString(), "");
                                else if (digit == "Start")
                                    oldFilename = oldFilename.TrimStart(digits);
                                else if (digit == "End")
                                    oldFilename = oldFilename.TrimEnd(digits);
                                else if (digit == "Both")
                                    oldFilename = oldFilename.Trim(digits);
                            }

                            if (removeAlphabetsCheck == true)
                            {
                                oldFilename = oldFilename.ToLower();
                                for (int k = 0; k < 26; k++)
                                    oldFilename = oldFilename.Replace(alphabets[k].ToString(), "");
                            }

                            space = Properties.Settings.Default.removeSpace;
                            if (removeSpaceCheck == true)
                            {
                                if (space == "All")
                                    oldFilename = oldFilename.Replace(" ", "");
                                else if (space == "Start")
                                    oldFilename = oldFilename.TrimStart();
                                else if (space == "End")
                                    oldFilename = oldFilename.TrimEnd();
                                else if (space == "Both")
                                    oldFilename = oldFilename.Trim();
                            }
                        }

                        // Find and replace text in filename
                        if (renameFromText.Count != 0)
                            for (int k = 0; k < renameFromText.Count; k++)
                                oldFilename = oldFilename.Replace(renameFromText[k].ToString(), renameToText[k].ToString());

                        if (truncateDataBefore != "")
                            if (oldFilename.IndexOf(truncateDataBefore) >= 0)
                                oldFilename = oldFilename.Substring(oldFilename.IndexOf(truncateDataBefore));

                        if (truncateDataAfter != "")
                            if (oldFilename.IndexOf(truncateDataAfter) >= 0)
                                oldFilename = oldFilename.Substring(0, oldFilename.IndexOf(truncateDataAfter) + truncateDataAfter.Length);

                        if (prefixTextbox != "")
                            oldFilename = prefixTextbox + oldFilename;

                        if (postfixTextbox != "")
                            oldFilename = oldFilename + postfixTextbox;

                        if (prefixNumberCheckbox == true)
                            oldFilename = i.ToString().PadLeft(prefixPadLength, '0') + oldFilename;

                        if (postfixNumberCheckbox == true)
                            oldFilename = oldFilename + i.ToString().PadLeft(postfixPadLength, '0');

                        newpath = oldpath + oldFilename + '.' + extension;
                        //MessageBox.Show(textInfo.ToTitleCase(fiArr.GetValue(i).ToString()));

                        if (selectedFiles[i].ToString() == newpath)
                            successStatus.Add("No Change");
                        else
                        {
                            if (File.Exists(selectedFiles[i].ToString())) //If source file does not exits
                            {
                                File.Move(selectedFiles[i].ToString(), oldpath + "TempRenamed191184.pk"); //Rename the file temporarily

                                if (File.Exists(newpath)) //If destination file name already exits
                                {
                                   File.Move(oldpath + "TempRenamed191184.pk", selectedFiles[i].ToString()); //Revert back the file renamed temporarily to original file name
                                    successStatus.Add("Failed");

                                    // MessageBox.Show("File already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    log = Properties.Settings.Default.logger;
                                    if (log == "yes")
                                        LogMessage.LogMsg(selectedFiles[i].ToString() + " Could not be Renamed to " + newpath + " The destination file name already exits", LogMessage.LogType.Error);
                                }

                                else
                                {
                                    try
                                    {
                                        File.Move(oldpath + "TempRenamed191184.pk", newpath);
                                        //File.Move(selectedFiles[i].ToString(), newpath);
                                    }
                                    catch (Exception exp)
                                    {
                                        MessageBox.Show(exp.Message);
                                    }
                                    log = Properties.Settings.Default.logger;
                                    if (log == "yes")
                                        LogMessage.LogMsg(selectedFiles[i].ToString() + " Renamed to " + newpath, LogMessage.LogType.Info);

                                    s.WriteLine("{0}", selectedFiles[i].ToString() + "," + newpath); //Only if success add into undo log
                                    successStatus.Add("Success");
                                }
                            }
                            else
                            {
                                //File.Move(oldpath + "TempRenamed191184.pk", selectedFiles[i].ToString());  //Revert back the file renamed temporarily to original file name
                                successStatus.Add("Failed");
                                log = Properties.Settings.Default.logger;
                                if (log == "yes")
                                    LogMessage.LogMsg(selectedFiles[i].ToString() + " Could not be Renamed to " + newpath + " The source file does not exits", LogMessage.LogType.Error);
                            }
                        }
                        renamedFrom.Add(selectedFiles[i].ToString());//To show in the Log ListView
                        renamedTo.Add(newpath.ToString()); //To show in the Log ListView

                    }
                    if (log == "yes")
                        LogMessage.LogMsg("The files have been successfully renamed", LogMessage.LogType.Info);

                    MessageBox.Show("Files have been renamed\nPlease view log for more details", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (log == "yes")
                        LogMessage.LogMsg("There were no files to be renamed", LogMessage.LogType.Info);

                    MessageBox.Show("Please select files to be renamed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                s.Close();
                f.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("The process failed: \n" + exp.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                s.Close();
                f.Close();
            }
		}
	}
}
