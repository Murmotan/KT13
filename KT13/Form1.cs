using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");
            ToolStripMenuItem saveItem = new ToolStripMenuItem("Сохранить") { Checked = true, CheckOnClick = true };
            saveItem.Click += saveItem_Click;
            saveItem.ShortcutKeys = Keys.Control | Keys.P;
            fileItem.DropDownItems.Add(saveItem);
            menuStrip1.Items.Add(fileItem);

            fileToolStripMenuItem.Image = Image.FromFile(@"C:\Users\Public\Pictures\hqdefault.jpg");

        }

        void saveItem_Click(object sender, EventArgs e)

        {

            MessageBox.Show("Сохранение");

        }
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("saved");
        }

        private void pngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("exported as PNG");
        }

        private void gPEGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("exported as JPEG");
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("exported as XML ");

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("show the way for...   saved");

        }
    }
}
