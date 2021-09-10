using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot_Challenge
{    
    public partial class Form1 : Form
    {
        public List<string> commands;
        public List<string> filelines;
        public Robot robot;
        public bool first_command;
        public ReadFile file;
        public Form1()
        {
            InitializeComponent();
            commands = new List<string>();
            robot = new Robot();
            first_command = true;
            file = new ReadFile();
            filelines = new List<string>();
        }

        //This method selects which robot command to call from the robot class based off the string input
        public void SelectCommand(string input)
        {
            Regex rgx = new Regex("^((MOVE)|(REPORT)|(LEFT)|(RIGHT))$", RegexOptions.IgnoreCase);
            //first call can't be move, report, left or right
            if (rgx.IsMatch(input) && first_command)
            {
                return;
            }
            //first call must be a place
            else if (first_command)
            {
                robot = robot.Place(robot, input);
                first_command = false;
            }
            //not first call, but move, report, left or right command
            else if (rgx.IsMatch(input) && !first_command)
            {
                switch (input.ToUpper())
                {
                    case "MOVE":
                        robot = robot.Move(robot);
                        break;
                    case "REPORT":
                        txtbox_output.AppendText(Report(robot) + Environment.NewLine); 
                        break;
                    case "LEFT":
                        robot.current_orientation = robot.Left(robot.current_orientation);
                        break;
                    case "RIGHT":
                        robot.current_orientation = robot.Right(robot.current_orientation);
                        break;
                    default: 
                        return;
                }

            }
            //not a first call but a place command            
            else
            {
                robot = robot.Place(robot, input);
            }
        }

        public string Report(Robot robot)
        {
            return $"{robot.current_x_position},{robot.current_y_position},{robot.current_orientation}";
        }

        //Read input textbox
        private void btn_readinputs_Click(object sender, EventArgs e)
        {
            commands.Clear();
            txtbox_output.Clear();
            for (int i = 0; i < txtbox_input.Lines.Length; i++)
            {
                if(robot.CheckValidInput(txtbox_input.Lines[i]))
                {
                    commands.Add(txtbox_input.Lines[i]);
                }                
            }
            foreach (string value in commands)
            {
                SelectCommand(value);
            }
        }

        //Read file
        private void btn_readfromfile_Click(object sender, EventArgs e)
        {
            filelines.Clear();
            txtbox_output.Clear();            
            try
            {
                filelines = file.ReadTextFile(txtbox_filelocation.Text);
                foreach (string value in filelines)
                {
                    SelectCommand(value);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                txtbox_filelocation.Text = "Please enter a valid file location path";
            }
            catch (System.ArgumentException)
            {
                txtbox_filelocation.Text = "Please enter a valid file location path";
            }
        }
    }
}
