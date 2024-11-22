using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class Cams : Form
    {
        public Cams()
        {
            InitializeComponent();
        }

        private void cameraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                this.Validate();
                this.cameraBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dLWSDataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "  1 حدثت مشكلة في تحميل البيانات", "مشكلة في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //log error()
            }

            Cursor.Current = Cursors.Default;
            this.Refresh();
        }

        private void Cams_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Camera' table. You can move, or remove it, as needed.
                this.cameraTableAdapter.Fill(this.dLWSDataSet.Camera);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "  1 حدثت مشكلة في تحميل البيانات", "مشكلة في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //log error()
            }

            Cursor.Current = Cursors.Default;
            this.Refresh();
        }

    }
}
