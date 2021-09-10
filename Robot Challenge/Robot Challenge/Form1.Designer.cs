
namespace Robot_Challenge
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_readfromfile = new System.Windows.Forms.Button();
            this.btn_readinputs = new System.Windows.Forms.Button();
            this.txtbox_filelocation = new System.Windows.Forms.TextBox();
            this.lbl_filelocation = new System.Windows.Forms.Label();
            this.txtbox_output = new System.Windows.Forms.TextBox();
            this.txtbox_input = new System.Windows.Forms.TextBox();
            this.lbl_outputcommands = new System.Windows.Forms.Label();
            this.lbl_inputcommands = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_readfromfile
            // 
            this.btn_readfromfile.Location = new System.Drawing.Point(148, 467);
            this.btn_readfromfile.Name = "btn_readfromfile";
            this.btn_readfromfile.Size = new System.Drawing.Size(116, 32);
            this.btn_readfromfile.TabIndex = 15;
            this.btn_readfromfile.Text = "Read From File";
            this.btn_readfromfile.UseVisualStyleBackColor = true;
            this.btn_readfromfile.Click += new System.EventHandler(this.btn_readfromfile_Click);
            // 
            // btn_readinputs
            // 
            this.btn_readinputs.Location = new System.Drawing.Point(168, 17);
            this.btn_readinputs.Name = "btn_readinputs";
            this.btn_readinputs.Size = new System.Drawing.Size(81, 32);
            this.btn_readinputs.TabIndex = 14;
            this.btn_readinputs.Text = "Read Inputs";
            this.btn_readinputs.UseVisualStyleBackColor = true;
            this.btn_readinputs.Click += new System.EventHandler(this.btn_readinputs_Click);
            // 
            // txtbox_filelocation
            // 
            this.txtbox_filelocation.Location = new System.Drawing.Point(36, 506);
            this.txtbox_filelocation.Name = "txtbox_filelocation";
            this.txtbox_filelocation.Size = new System.Drawing.Size(692, 20);
            this.txtbox_filelocation.TabIndex = 13;
            // 
            // lbl_filelocation
            // 
            this.lbl_filelocation.AutoSize = true;
            this.lbl_filelocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filelocation.Location = new System.Drawing.Point(30, 473);
            this.lbl_filelocation.Name = "lbl_filelocation";
            this.lbl_filelocation.Size = new System.Drawing.Size(92, 18);
            this.lbl_filelocation.TabIndex = 12;
            this.lbl_filelocation.Text = "File Location";
            // 
            // txtbox_output
            // 
            this.txtbox_output.Location = new System.Drawing.Point(411, 55);
            this.txtbox_output.Multiline = true;
            this.txtbox_output.Name = "txtbox_output";
            this.txtbox_output.ReadOnly = true;
            this.txtbox_output.Size = new System.Drawing.Size(318, 392);
            this.txtbox_output.TabIndex = 11;
            // 
            // txtbox_input
            // 
            this.txtbox_input.Location = new System.Drawing.Point(33, 55);
            this.txtbox_input.Multiline = true;
            this.txtbox_input.Name = "txtbox_input";
            this.txtbox_input.Size = new System.Drawing.Size(318, 392);
            this.txtbox_input.TabIndex = 10;
            // 
            // lbl_outputcommands
            // 
            this.lbl_outputcommands.AutoSize = true;
            this.lbl_outputcommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outputcommands.Location = new System.Drawing.Point(408, 18);
            this.lbl_outputcommands.Name = "lbl_outputcommands";
            this.lbl_outputcommands.Size = new System.Drawing.Size(134, 18);
            this.lbl_outputcommands.TabIndex = 9;
            this.lbl_outputcommands.Text = "Output Commands";
            // 
            // lbl_inputcommands
            // 
            this.lbl_inputcommands.AutoSize = true;
            this.lbl_inputcommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inputcommands.Location = new System.Drawing.Point(26, 18);
            this.lbl_inputcommands.Name = "lbl_inputcommands";
            this.lbl_inputcommands.Size = new System.Drawing.Size(121, 18);
            this.lbl_inputcommands.TabIndex = 8;
            this.lbl_inputcommands.Text = "Input Commands";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 573);
            this.Controls.Add(this.btn_readfromfile);
            this.Controls.Add(this.btn_readinputs);
            this.Controls.Add(this.txtbox_filelocation);
            this.Controls.Add(this.lbl_filelocation);
            this.Controls.Add(this.txtbox_output);
            this.Controls.Add(this.txtbox_input);
            this.Controls.Add(this.lbl_outputcommands);
            this.Controls.Add(this.lbl_inputcommands);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_readfromfile;
        private System.Windows.Forms.Button btn_readinputs;
        private System.Windows.Forms.TextBox txtbox_filelocation;
        private System.Windows.Forms.Label lbl_filelocation;
        private System.Windows.Forms.TextBox txtbox_output;
        private System.Windows.Forms.TextBox txtbox_input;
        private System.Windows.Forms.Label lbl_outputcommands;
        private System.Windows.Forms.Label lbl_inputcommands;
    }
}

