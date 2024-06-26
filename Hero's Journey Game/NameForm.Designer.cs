﻿namespace Hero_s_Journey_Game
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
            this.charLabel3 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.genderLabel = new System.Windows.Forms.Label();
            this.femaleBtn = new System.Windows.Forms.Button();
            this.maleBtn = new System.Windows.Forms.Button();
            this.preferBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.txtBoxName2 = new System.Windows.Forms.TextBox();
            this.verifyLabel = new System.Windows.Forms.Label();
            this.btnName2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // charLabel3
            // 
            this.charLabel3.AutoSize = true;
            this.charLabel3.Location = new System.Drawing.Point(315, 22);
            this.charLabel3.Name = "charLabel3";
            this.charLabel3.Size = new System.Drawing.Size(128, 13);
            this.charLabel3.TabIndex = 5;
            this.charLabel3.Text = "Start your Journey Today!";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(278, 62);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(211, 62);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Create Character";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(665, 37);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(45, 13);
            this.genderLabel.TabIndex = 7;
            this.genderLabel.Text = "Gender:";
            // 
            // femaleBtn
            // 
            this.femaleBtn.Location = new System.Drawing.Point(744, 17);
            this.femaleBtn.Name = "femaleBtn";
            this.femaleBtn.Size = new System.Drawing.Size(50, 23);
            this.femaleBtn.TabIndex = 8;
            this.femaleBtn.Text = "Female";
            this.femaleBtn.UseVisualStyleBackColor = true;
            this.femaleBtn.Click += new System.EventHandler(this.femaleBtn_Click);
            // 
            // maleBtn
            // 
            this.maleBtn.Location = new System.Drawing.Point(820, 17);
            this.maleBtn.Name = "maleBtn";
            this.maleBtn.Size = new System.Drawing.Size(50, 23);
            this.maleBtn.TabIndex = 9;
            this.maleBtn.Text = "Male";
            this.maleBtn.UseVisualStyleBackColor = false;
            this.maleBtn.Click += new System.EventHandler(this.maleBtn_Click);
            // 
            // preferBtn
            // 
            this.preferBtn.Location = new System.Drawing.Point(744, 46);
            this.preferBtn.Name = "preferBtn";
            this.preferBtn.Size = new System.Drawing.Size(132, 23);
            this.preferBtn.TabIndex = 10;
            this.preferBtn.Text = "Prefer not to say";
            this.preferBtn.UseVisualStyleBackColor = true;
            this.preferBtn.Click += new System.EventHandler(this.preferBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(665, 111);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 13);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Character Name:";
            // 
            // txtBoxName2
            // 
            this.txtBoxName2.Location = new System.Drawing.Point(762, 111);
            this.txtBoxName2.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxName2.Name = "txtBoxName2";
            this.txtBoxName2.Size = new System.Drawing.Size(108, 20);
            this.txtBoxName2.TabIndex = 12;
            // 
            // verifyLabel
            // 
            this.verifyLabel.AutoSize = true;
            this.verifyLabel.Location = new System.Drawing.Point(679, 182);
            this.verifyLabel.Name = "verifyLabel";
            this.verifyLabel.Size = new System.Drawing.Size(228, 13);
            this.verifyLabel.TabIndex = 20;
            this.verifyLabel.Text = "**Verify your answers before you click submit!**";
            // 
            // btnName2
            // 
            this.btnName2.Location = new System.Drawing.Point(744, 220);
            this.btnName2.Margin = new System.Windows.Forms.Padding(2);
            this.btnName2.Name = "btnName2";
            this.btnName2.Size = new System.Drawing.Size(118, 34);
            this.btnName2.TabIndex = 21;
            this.btnName2.Text = "Submit";
            this.btnName2.UseVisualStyleBackColor = true;
            this.btnName2.Click += new System.EventHandler(this.btnName2_Click);
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 613);
            this.Controls.Add(this.btnName2);
            this.Controls.Add(this.verifyLabel);
            this.Controls.Add(this.txtBoxName2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.preferBtn);
            this.Controls.Add(this.maleBtn);
            this.Controls.Add(this.femaleBtn);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.charLabel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "NameForm";
            this.Text = "NameForm";
            this.Load += new System.EventHandler(this.NameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label charLabel3;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Button femaleBtn;
        private System.Windows.Forms.Button maleBtn;
        private System.Windows.Forms.Button preferBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox txtBoxName2;
        private System.Windows.Forms.Label verifyLabel;
        private System.Windows.Forms.Button btnName2;
    }
}