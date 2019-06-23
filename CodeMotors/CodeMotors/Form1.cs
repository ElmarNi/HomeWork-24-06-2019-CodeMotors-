using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMotors
{
    public partial class Form1 : Form
    {
        private readonly CodeMotorsEntities _context;
        public Form1()
        {
            _context = new CodeMotorsEntities();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.All_autos.ToList();
            _context.SaveChanges();
        }
    }
}
