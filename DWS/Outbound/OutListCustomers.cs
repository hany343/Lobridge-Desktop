using ClosedXML.Excel;
using System;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class OutListCustomers : Form
    {
        DataTable perm;
        public OutListCustomers(DataTable dataTable)
        {
            perm = dataTable;
            InitializeComponent();
        }

        private void ListData_Load(object sender, EventArgs e)
        {

            if (perm.Rows[0]["__customers_EditBtn"].ToString() != "1")
            {
                EditBtn.Enabled = false;
            }

            reload();
        }

        private void fillByCNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillByCName(this.oUTDataset.Customers, cnameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cnameToolStripTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                this.customersTableAdapter.FillByCName(this.oUTDataset.Customers, "%" + cnameToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OUTCustomer oc = new OUTCustomer(new DataTable());
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == oc.Text)
                {
                    oc = (LoBridge.OUTCustomer)frm;
                }
            }
            try
            {
                if (customersDataGridView.Rows.Count > 0)
                {

                    if (customersDataGridView.SelectedRows.Count > 1)
                    {
                        MessageBox.Show("يرجي تحديد عميل واحد فقط");
                    }
                    else
                    {
                        int cidnum = ((int)(System.Convert.ChangeType(customersDataGridView.Rows[customersDataGridView.CurrentCell.RowIndex].Cells[0].Value, typeof(int))));
                        oc.Editcustomer(cidnum);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message);
            }

        }
        public void reload()
        {
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Customers' table. You can move, or remove it, as needed.
                this.customersTableAdapter.Fill(this.oUTDataset.Customers);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ExportXlsBtn_Click(object sender, EventArgs e)
        {


            string fileName;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.Title = "To Excel";
            saveFileDialog1.FileName = this.Text + " (" + DateTime.Now.ToString("yyyy-MM-dd") + ")";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add(this.Text);
                for (int i = 0; i < customersDataGridView.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = customersDataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < customersDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < customersDataGridView.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = customersDataGridView.Rows[i].Cells[j].Value.ToString();

                        if (worksheet.Cell(i + 2, j + 1).Value.ToString().Length > 0)
                        {
                            XLAlignmentHorizontalValues align;

                            switch (customersDataGridView.Rows[i].Cells[j].Style.Alignment)
                            {
                                case DataGridViewContentAlignment.BottomRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;
                                case DataGridViewContentAlignment.MiddleRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;
                                case DataGridViewContentAlignment.TopRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;

                                case DataGridViewContentAlignment.BottomCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;
                                case DataGridViewContentAlignment.MiddleCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;
                                case DataGridViewContentAlignment.TopCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;

                                default:
                                    align = XLAlignmentHorizontalValues.Left;
                                    break;
                            }

                            worksheet.Cell(i + 2, j + 1).Style.Alignment.Horizontal = align;

                            XLColor xlColor = XLColor.FromColor(customersDataGridView.Rows[i].Cells[j].Style.SelectionBackColor);
                            worksheet.Cell(i + 2, j + 1).AddConditionalFormat().WhenLessThan(1).Fill.SetBackgroundColor(xlColor);

                            worksheet.Cell(i + 2, j + 1).Style.Font.FontName = customersDataGridView.Font.Name;
                            worksheet.Cell(i + 2, j + 1).Style.Font.FontSize = customersDataGridView.Font.Size;

                        }
                    }
                }
                try
                {
                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(fileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
