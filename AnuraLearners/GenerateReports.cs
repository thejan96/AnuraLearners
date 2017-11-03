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
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace AnuraLearners
{
    public partial class GenerateReports : Form
    {
        public GenerateReports()
        {
            InitializeComponent();
        }
        DbConnection db;
        static string reportName = "";
        private void button5_Click(object sender, EventArgs e)
        {
            reportName = "Delay";
            db = new DbConnection();
            DataTable dt = db.generateRep(dtmFrom.Value, dtmTo.Value, 5);
            dataGridView1.DataSource = dt;
        }

        private void GenerateReports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportName = "Customer";
            db = new DbConnection();
            DataTable dt = db.generateRep(dtmFrom.Value, dtmTo.Value, 1);
            dataGridView1.DataSource = dt;
        }

        private void btnTotalIncome_Click(object sender, EventArgs e)
        {
            reportName = "Income";
            db = new DbConnection();
            DataTable dt = db.generateRep(dtmFrom.Value, dtmTo.Value, 2);
            dataGridView1.DataSource = dt;
        }

        private void btnExamReport_Click(object sender, EventArgs e)
        {
            reportName = "Exam";
            db = new DbConnection();
            DataTable dt = db.generateRep(dtmFrom.Value, dtmTo.Value, 3);
            dataGridView1.DataSource = dt;
        }

        private void btnTrialReport_Click(object sender, EventArgs e)
        {
            reportName = "Trial";
            db = new DbConnection();
            DataTable dt = db.generateRep(dtmFrom.Value, dtmTo.Value, 4);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != -1 && dataGridView1.RowCount != 0)
            {
                try
                {
                    //Creating iTextSharp Table from the DataTable data
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 30;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfTable.DefaultCell.BorderWidth = 1;

                    //Adding Header row
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        //cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                        pdfTable.AddCell(cell);
                    }

                    //Adding DataRow

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                    }


                    //Exporting to PDF
                    string folderPath = "C:\\PDFs\\General\\";
                    switch (reportName)
                    {
                        case "Customer":
                            folderPath = "C:\\PDFs\\Customer\\";
                            break;
                        case "Exam":
                            folderPath = "C:\\PDFs\\Exam\\";
                            break;
                        case "Trial":
                            folderPath = "C:\\PDFs\\Trials\\";
                            break;
                        case "Delay":
                            folderPath = "C:\\PDFs\\PaymentsDelayed\\";
                            break;
                        case "Income":
                            folderPath = "C:\\PDFs\\Income\\";
                            break;

                        default:
                            break;
                    }
                    
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    using (FileStream stream = new FileStream(folderPath +  dtmFrom.Value.ToShortDateString().Replace("/","_")+" to " +dtmTo.Value.ToShortDateString().Replace("/", "_") + ".pdf", FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("Exported Successfully to " + folderPath, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                    //MessageBox.Show("Exporting Failed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No data to be Exported", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
