namespace AmIBattlEyeBanned
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bancheck_btn = new System.Windows.Forms.Button();
            this.bancheck_status = new System.Windows.Forms.Label();
            this.bancheck_input = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.name2rid_btn = new System.Windows.Forms.Button();
            this.name2rid_status = new System.Windows.Forms.Label();
            this.name2rid_input = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bancheck_btn);
            this.groupBox1.Controls.Add(this.bancheck_status);
            this.groupBox1.Controls.Add(this.bancheck_input);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check BattlEye Ban by Rockstar ID";
            // 
            // bancheck_btn
            // 
            this.bancheck_btn.Location = new System.Drawing.Point(155, 17);
            this.bancheck_btn.Name = "bancheck_btn";
            this.bancheck_btn.Size = new System.Drawing.Size(49, 23);
            this.bancheck_btn.TabIndex = 2;
            this.bancheck_btn.Text = "Submit";
            this.bancheck_btn.UseVisualStyleBackColor = true;
            this.bancheck_btn.Click += new System.EventHandler(this.bancheck_btn_Click);
            // 
            // bancheck_status
            // 
            this.bancheck_status.AutoSize = true;
            this.bancheck_status.Location = new System.Drawing.Point(6, 46);
            this.bancheck_status.Name = "bancheck_status";
            this.bancheck_status.Size = new System.Drawing.Size(76, 13);
            this.bancheck_status.TabIndex = 1;
            this.bancheck_status.Text = "Awaiting input.";
            // 
            // bancheck_input
            // 
            this.bancheck_input.Location = new System.Drawing.Point(6, 19);
            this.bancheck_input.Name = "bancheck_input";
            this.bancheck_input.Size = new System.Drawing.Size(143, 20);
            this.bancheck_input.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.name2rid_btn);
            this.groupBox2.Controls.Add(this.name2rid_status);
            this.groupBox2.Controls.Add(this.name2rid_input);
            this.groupBox2.Location = new System.Drawing.Point(228, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convert Username to Rockstar ID";
            // 
            // name2rid_btn
            // 
            this.name2rid_btn.Location = new System.Drawing.Point(155, 17);
            this.name2rid_btn.Name = "name2rid_btn";
            this.name2rid_btn.Size = new System.Drawing.Size(49, 23);
            this.name2rid_btn.TabIndex = 3;
            this.name2rid_btn.Text = "Submit";
            this.name2rid_btn.UseVisualStyleBackColor = true;
            this.name2rid_btn.Click += new System.EventHandler(this.name2rid_btn_Click);
            // 
            // name2rid_status
            // 
            this.name2rid_status.AutoSize = true;
            this.name2rid_status.Location = new System.Drawing.Point(7, 46);
            this.name2rid_status.Name = "name2rid_status";
            this.name2rid_status.Size = new System.Drawing.Size(76, 13);
            this.name2rid_status.TabIndex = 1;
            this.name2rid_status.Text = "Awaiting input.";
            // 
            // name2rid_input
            // 
            this.name2rid_input.Location = new System.Drawing.Point(6, 19);
            this.name2rid_input.Name = "name2rid_input";
            this.name2rid_input.Size = new System.Drawing.Size(143, 20);
            this.name2rid_input.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(102, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Try the manual way.";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 94);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Am I BattlEye-banned?";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox bancheck_input;
        private System.Windows.Forms.Label bancheck_status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label name2rid_status;
        private System.Windows.Forms.TextBox name2rid_input;
        private System.Windows.Forms.Button bancheck_btn;
        private System.Windows.Forms.Button name2rid_btn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

