namespace Hero_s_Journey_Game
{
    partial class NameForm
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
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Location = new System.Drawing.Point(44, 21);
            this.EnterNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(117, 13);
            this.EnterNameLabel.TabIndex = 0;
            this.EnterNameLabel.Text = "Enter Your Name Hero!";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(46, 37);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(108, 20);
            this.txtboxName.TabIndex = 1;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(46, 61);
            this.btnName.Margin = new System.Windows.Forms.Padding(2);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(56, 19);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "Submit";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 197);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.EnterNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "NameForm";
            this.Text = "NameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterNameLabel;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Button btnName;
    }
}