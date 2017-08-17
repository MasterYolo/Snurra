namespace Snurra
{
    partial class Snurra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snurra));
            this.panel = new System.Windows.Forms.Panel();
            this.AssignmentTwo = new System.Windows.Forms.CheckBox();
            this.AssignmentOne = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Textbox = new System.Windows.Forms.RichTextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.AssignmentTwo);
            this.panel.Controls.Add(this.AssignmentOne);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.dateTimePicker1);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.Textbox);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(811, 496);
            this.panel.TabIndex = 0;
            // 
            // AssignmentTwo
            // 
            this.AssignmentTwo.AutoSize = true;
            this.AssignmentTwo.Location = new System.Drawing.Point(127, 33);
            this.AssignmentTwo.Name = "AssignmentTwo";
            this.AssignmentTwo.Size = new System.Drawing.Size(104, 17);
            this.AssignmentTwo.TabIndex = 5;
            this.AssignmentTwo.Text = "Assignment Two";
            this.AssignmentTwo.UseVisualStyleBackColor = true;
            // 
            // AssignmentOne
            // 
            this.AssignmentOne.AutoSize = true;
            this.AssignmentOne.Location = new System.Drawing.Point(17, 33);
            this.AssignmentOne.Name = "AssignmentOne";
            this.AssignmentOne.Size = new System.Drawing.Size(103, 17);
            this.AssignmentOne.TabIndex = 4;
            this.AssignmentOne.Text = "Assignment One";
            this.AssignmentOne.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "End date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(342, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2007, 12, 31, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Read, identyfy and write to output file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Textbox
            // 
            this.Textbox.Location = new System.Drawing.Point(3, 62);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(799, 431);
            this.Textbox.TabIndex = 0;
            this.Textbox.Text = "";
            // 
            // Snurra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 540);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Snurra";
            this.Text = "Snurra";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RichTextBox Textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox AssignmentOne;
        private System.Windows.Forms.CheckBox AssignmentTwo;
    }
}

