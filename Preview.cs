using System;
using System.IO;
using System.Windows.Forms;
using Rename;
using System.Globalization;
using System.Threading;
using Microsoft.Win32;
using System.Collections;

namespace Rename
{
    /// <summary>
    /// Summary description for Rename.
    /// This class contains the procedure for renaming the files
    /// </summary>
    public class PreviewFiles : Form1
    {
        public PreviewFiles()
        {

        }

        public void PreviewRenameFiles(ListBox FilesSelectedlist)
        {
            try
            {
                int i = 0;
                string newpath, oldpath, space, digit;
                ArrayList renamedFromDummyHardisk = new ArrayList();

                //RegistryKey rootkey, license;
                //rootkey = Registry.LocalMachine.OpenSubKey("Software", true);
                //license = rootkey.OpenSubKey("RenLis");
                
                // Display the names of the files

                renamedFromDummyHardisk.Clear();

                for (int l = 0; l < selectedFiles.Count; l++)
                    renamedFromDummyHardisk.Add(selectedFiles[l].ToString());//To show in the Log ListView

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
                            if (renamedFromDummyHardisk.Contains(selectedFiles[i].ToString())) //If source file does not exits
                            {
                                renamedFromDummyHardisk.Remove(selectedFiles[i].ToString()); //Remove the file from the array temporarily
                                
                                if (renamedFromDummyHardisk.Contains(newpath)) //If destination file name already exits
                                {
                                    renamedFromDummyHardisk.Add(selectedFiles[i].ToString()); //Revert back the file renamed temporarily to original file name
                                    successStatus.Add("Fail");

                                    // MessageBox.Show("File already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                                }

                                else
                                {
                                    renamedFromDummyHardisk.Add(newpath);
                                    successStatus.Add("Success");
                                }
                            }
                            else
                            {
                                renamedFromDummyHardisk.Add(selectedFiles[i].ToString());  //Revert back the file renamed temporarily to original file name
                                successStatus.Add("Fail");  
                            }
                        }
                        renamedFrom.Add(selectedFiles[i].ToString());//To show in the Log ListView
                        renamedTo.Add(newpath.ToString()); //To show in the Log ListView
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please select files to be renamed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("The preview process failed: \n" + exp.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
