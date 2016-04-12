namespace XMLProgram
{
    partial class mainForm
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
            this.readButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.writeButton = new System.Windows.Forms.Button();
            this.nodeSelect = new System.Windows.Forms.TextBox();
            this.contentSelect = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.newContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(38, 23);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(64, 32);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "Read File";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(35, 122);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(305, 284);
            this.outputLabel.TabIndex = 1;
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(108, 23);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(64, 32);
            this.writeButton.TabIndex = 2;
            this.writeButton.Text = "Write File";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // nodeSelect
            // 
            this.nodeSelect.Location = new System.Drawing.Point(220, 35);
            this.nodeSelect.Name = "nodeSelect";
            this.nodeSelect.Size = new System.Drawing.Size(100, 20);
            this.nodeSelect.TabIndex = 3;
            // 
            // contentSelect
            // 
            this.contentSelect.Location = new System.Drawing.Point(220, 63);
            this.contentSelect.Name = "contentSelect";
            this.contentSelect.Size = new System.Drawing.Size(100, 20);
            this.contentSelect.TabIndex = 4;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(338, 36);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(47, 46);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // newContent
            // 
            this.newContent.Location = new System.Drawing.Point(220, 89);
            this.newContent.Name = "newContent";
            this.newContent.Size = new System.Drawing.Size(100, 20);
            this.newContent.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 448);
            this.Controls.Add(this.newContent);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.contentSelect);
            this.Controls.Add(this.nodeSelect);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.readButton);
            this.Name = "mainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.TextBox nodeSelect;
        private System.Windows.Forms.TextBox contentSelect;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox newContent;
    }
}

