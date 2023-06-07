using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisePABD2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet1.Anggota' table. You can move, or remove it, as needed.
            this.anggotaTableAdapter.Fill(this.perpustakaanDataSet1.Anggota);
            // TODO: This line of code loads data into the 'perpustakaanDataSet1.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.perpustakaanDataSet1.Buku);
            // TODO: This line of code loads data into the 'perpustakaanDataSet1.Administrasi' table. You can move, or remove it, as needed.
            this.administrasiTableAdapter.Fill(this.perpustakaanDataSet1.Administrasi);

        }

        private void TAbel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
