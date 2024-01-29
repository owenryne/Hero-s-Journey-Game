namespace Hero_s_Journey_Game
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
            this.forwardButt = new System.Windows.Forms.Button();
            this.playerCoords = new System.Windows.Forms.TextBox();
            this.updateBox = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.rightButt = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forwardButt
            // 
            this.forwardButt.Location = new System.Drawing.Point(284, 219);
            this.forwardButt.Name = "forwardButt";
            this.forwardButt.Size = new System.Drawing.Size(53, 23);
            this.forwardButt.TabIndex = 0;
            this.forwardButt.Text = "Forward";
            this.forwardButt.UseVisualStyleBackColor = true;
            this.forwardButt.Click += new System.EventHandler(this.forwardButt_Click);
            // 
            // playerCoords
            // 
            this.playerCoords.Location = new System.Drawing.Point(555, 30);
            this.playerCoords.Name = "playerCoords";
            this.playerCoords.Size = new System.Drawing.Size(100, 20);
            this.playerCoords.TabIndex = 2;
            this.playerCoords.TextChanged += new System.EventHandler(this.playerCoords_TextChanged);
            // 
            // updateBox
            // 
            this.updateBox.FormattingEnabled = true;
            this.updateBox.Location = new System.Drawing.Point(224, 66);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(173, 147);
            this.updateBox.TabIndex = 3;
            this.updateBox.SelectedIndexChanged += new System.EventHandler(this.updateBox_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(284, 248);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(53, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // rightButt
            // 
            this.rightButt.Location = new System.Drawing.Point(343, 235);
            this.rightButt.Name = "rightButt";
            this.rightButt.Size = new System.Drawing.Size(53, 23);
            this.rightButt.TabIndex = 5;
            this.rightButt.Text = "Right";
            this.rightButt.UseVisualStyleBackColor = true;
            this.rightButt.Click += new System.EventHandler(this.button3_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(225, 235);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(53, 23);
            this.leftButton.TabIndex = 6;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.rightButt);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateBox);
            this.Controls.Add(this.playerCoords);
            this.Controls.Add(this.forwardButt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forwardButt;
        private System.Windows.Forms.TextBox playerCoords;
        private System.Windows.Forms.ListBox updateBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button rightButt;
        private System.Windows.Forms.Button leftButton;
    }
}

