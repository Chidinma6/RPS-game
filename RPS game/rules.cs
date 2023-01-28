using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS_game
{
    public partial class rules : Form
    {
        public rules()
        {
            InitializeComponent();
        }

        private void bachbtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form.
            MainPage rule = new MainPage(); // Create new instance of the new
            rule.Show(); // Show it
        }
    }
}
