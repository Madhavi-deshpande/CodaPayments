using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using CsvHelper;


namespace LoadCSV
{
    enum TypesOfRecords
    {
        
        phoneNumber,
        email,
        number,
        stirng_value
    }
    public partial class LoadForm : Form
    {
        static readonly log4net.ILog s_Logger = log4net.LogManager.GetLogger(typeof(LoadForm));
        const string checkFile = "Please check if the file you  are trying to load is open by another process or deleted";
        const string filePathForXml = "Please find the converted xmls under same path as input file exists";
        const string conversionError = "Can not convert to xml";
        public LoadForm()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            openFileDialog_CSV.ShowDialog();
            openFileDialog_CSV.InitialDirectory = @"C:\";
            openFileDialog_CSV.CheckFileExists = true;
            openFileDialog_CSV.CheckPathExists = true;
            openFileDialog_CSV.ReadOnlyChecked = true;
            openFileDialog_CSV.Filter = "csv files (*.csv)|*.csv";
            txtFileName.Text = openFileDialog_CSV.FileName;
            WriteCSVContentToXml(txtFileName.Text);
           

        }


        public void WriteCSVContentToXml(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                using (CsvReader readerCsv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    dynamic rows = readerCsv.GetRecords<dynamic>();
                     foreach (var row in rows)
                    {
                        List<string> fields = new List<string>();
                        List<string> headers = new List<string>();
                        IDictionary<string, object> rowValues = row;
                        foreach (var val in rowValues)
                        {
                            headers.Add(val.Key.ToString());
                        }
                        foreach (var val in rowValues)
                        {
                            fields.Add(val.Value.ToString());
                        }
                        var dirName = Path.GetDirectoryName(filePath);
                        string path = dirName +@"\" + fields[0] + ".txt";
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            for (int j = 0; j < fields.Count; j++)
                            {
                                string type = TypesOfRecords.stirng_value.ToString();
                                 if (PhoneNumber.IsPhoneNbr(fields[j]))
                                  {
                                    type = TypesOfRecords.phoneNumber.ToString();
                                   }
                                else if (EMail.IsEmail(fields[j]))
                                {
                                    type = TypesOfRecords.email.ToString();
                                }
                                else if (int.TryParse(fields[j], out int res))
                                {
                                    type = TypesOfRecords.number.ToString();
                                }
                                XElement node = new XElement(
                                        new XElement(headers[j].Replace(" ", ""),
                                         new XElement("Value", fields[j]),
                                         new XElement("Type", type))
                                         );
                                sw.Write(node.ToString() + "\n");
                            }
                        }
                    }
                }
                labelInfo.Visible = true;
                labelInfo.Text = filePathForXml;
                buttonOk.Visible = true;
            }

            catch (IOException ex)
            {
                labelInfo.Visible = true;
                labelInfo.Text = checkFile;
                buttonOk.Visible = true;
                s_Logger.Error("Erro message:" + ex.Message.ToString(), ex);
            }
            catch (Exception ex)
            {
                labelInfo.Visible = true;
                labelInfo.Text = conversionError;
                buttonOk.Visible = true;
                s_Logger.Error("Erro message:" + ex.Message.ToString(), ex);
            }


        }
                private void buttonOk_Click(object sender, EventArgs e)
                {
                    if (labelInfo.Text == checkFile)
                    {
                        labelInfo.Visible = false;
                        buttonOk.Visible = false;

                    }
                    else
                    {
                       // buttonOk.Visible = true;
                        this.Close();
                    }
                }
            }
        }

