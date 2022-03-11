using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Session_07
{
    public partial class Professor : Form
    {
        private InstituteLib.Professor _professor;
        public string name=string.Empty;
        public int age;
        public string rank;
        public List<Course> Courses { get; set; }
        public InstituteLib.Rank Rank { get; set; }
        public Professor()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Professor_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void textEditRank_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        public void ProfessorData()
        {
            //rank = this.textEditRank.Text;
            name = this.textEditName.Text;
            age = Convert.ToInt32(this.textEditAge.Text);
        }
    }  
    
}
