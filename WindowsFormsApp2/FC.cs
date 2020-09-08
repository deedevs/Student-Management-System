using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FC : Form
    {
        public FC()
        {
            InitializeComponent();
        }

        private void aDDNEWCOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datagridview ss = new datagridview();
            ss.MdiParent = this;
            ss.Dock = DockStyle.Fill;
            ss.Show();
        }

        private void aDDNEWTEACHERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher sf = new AddTeacher();
            sf.MdiParent = this;
            sf.Dock = DockStyle.Fill;
            sf.Show();
        }

        private void aDDNEWSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent sd = new AddStudent();
            sd.MdiParent = this;
            sd.Dock = DockStyle.Fill;
            sd.Show();
        }

        private void aSSIGNCOURSETOINSTRUCTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseInstructor sd = new CourseInstructor();
            sd.MdiParent = this;
            sd.Dock = DockStyle.Fill;
            sd.Show();
        }
    }
}
