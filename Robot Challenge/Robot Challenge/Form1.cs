using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot_Challenge
{    
    public partial class Form1 : Form
    {
        private List<string> commands;
        public Form1()
        {
            InitializeComponent();
            commands = new List<string>();
        }

        private void btn_readinputs_Click(object sender, EventArgs e)
        {
            commands.Clear();
            for (int i = 0; i < txtbox_input.Lines.Length; i++)
            {
                commands.Add(txtbox_input.Lines[i]);
            }
        }

        private void btn_readfromfile_Click(object sender, EventArgs e)
        {

        }
    }
}
