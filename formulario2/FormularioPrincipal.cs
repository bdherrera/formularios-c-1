using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario2
{
    public partial class FormularioPrincipal : Form
    {
        private int childFormNumber = 0;

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void condicionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ciclicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estucturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioFor formularioFor = new FormularioFor();
            formularioFor.MdiParent = this;
            formularioFor.Show();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tryCatchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ciclicasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioIf formularioIf = new FormularioIf();
            formularioIf.MdiParent = this;
            formularioIf.Show();

        }

        private void swichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioSwich formularioSwich = new FormularioSwich();
            formularioSwich.MdiParent = this;
            formularioSwich.Show();
        }

        private void whileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tryCatchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormularioTryCatch formularioTryCatch = new FormularioTryCatch();
            formularioTryCatch.MdiParent = this;
            formularioTryCatch.Show();
        }

        private void doWhilwToolStripMenuItem_Click(object sender, EventArgs e) { 
        } 
           
    }
}
