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
            this.charLabel2 = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.charLabel1 = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.charLabel3 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.genderLabel = new System.Windows.Forms.Label();
            this.femaleBtn = new System.Windows.Forms.Button();
            this.maleBtn = new System.Windows.Forms.Button();
            this.preferBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.txtBoxName2 = new System.Windows.Forms.TextBox();
            this.raceLabel = new System.Windows.Forms.Label();
            this.txtboxRace = new System.Windows.Forms.TextBox();
            this.modLabel = new System.Windows.Forms.Label();
            this.strengthBtn = new System.Windows.Forms.Button();
            this.speedBtn = new System.Windows.Forms.Button();
            this.manaBtn = new System.Windows.Forms.Button();
            this.defBtn = new System.Windows.Forms.Button();
            this.verifyLabel = new System.Windows.Forms.Label();
            this.btnName2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // charLabel2
            // 
            this.charLabel2.AutoSize = true;
            this.charLabel2.Location = new System.Drawing.Point(44, 49);
            this.charLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.charLabel2.Name = "charLabel2";
            this.charLabel2.Size = new System.Drawing.Size(117, 13);
            this.charLabel2.TabIndex = 0;
            this.charLabel2.Text = "Enter Your Name Hero!";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(47, 64);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(108, 20);
            this.txtboxName.TabIndex = 1;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(47, 88);
            this.btnName.Margin = new System.Windows.Forms.Padding(2);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(56, 19);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "Submit";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // charLabel1
            // 
            this.charLabel1.AutoSize = true;
            this.charLabel1.Location = new System.Drawing.Point(44, 22);
            this.charLabel1.Name = "charLabel1";
            this.charLabel1.Size = new System.Drawing.Size(157, 13);
            this.charLabel1.TabIndex = 3;
            this.charLabel1.Text = "If you have a character already:";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.Location = new System.Drawing.Point(230, 62);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(43, 25);
            this.orLabel.TabIndex = 4;
            this.orLabel.Text = "OR";
            // 
            // charLabel3
            // 
            this.charLabel3.AutoSize = true;
            this.charLabel3.Location = new System.Drawing.Point(315, 22);
            this.charLabel3.Name = "charLabel3";
            this.charLabel3.Size = new System.Drawing.Size(183, 13);
            this.charLabel3.TabIndex = 5;
            this.charLabel3.Text = "If you don\'t have a character already:";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(339, 62);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(132, 23);
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
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(665, 167);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(85, 13);
            this.raceLabel.TabIndex = 13;
            this.raceLabel.Text = "Character Race:";
            // 
            // txtboxRace
            // 
            this.txtboxRace.Location = new System.Drawing.Point(762, 167);
            this.txtboxRace.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxRace.Name = "txtboxRace";
            this.txtboxRace.Size = new System.Drawing.Size(108, 20);
            this.txtboxRace.TabIndex = 14;
            // 
            // modLabel
            // 
            this.modLabel.AutoSize = true;
            this.modLabel.Location = new System.Drawing.Point(667, 227);
            this.modLabel.Name = "modLabel";
            this.modLabel.Size = new System.Drawing.Size(80, 13);
            this.modLabel.TabIndex = 15;
            this.modLabel.Text = "Character Mod:";
            // 
            // strengthBtn
            // 
            this.strengthBtn.Location = new System.Drawing.Point(762, 222);
            this.strengthBtn.Name = "strengthBtn";
            this.strengthBtn.Size = new System.Drawing.Size(71, 23);
            this.strengthBtn.TabIndex = 16;
            this.strengthBtn.Text = "+1 Strength";
            this.strengthBtn.UseVisualStyleBackColor = true;
            this.strengthBtn.Click += new System.EventHandler(this.strengthBtn_Click);
            // 
            // speedBtn
            // 
            this.speedBtn.Location = new System.Drawing.Point(839, 222);
            this.speedBtn.Name = "speedBtn";
            this.speedBtn.Size = new System.Drawing.Size(71, 23);
            this.speedBtn.TabIndex = 17;
            this.speedBtn.Text = "+1 Speed";
            this.speedBtn.UseVisualStyleBackColor = true;
            this.speedBtn.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // manaBtn
            // 
            this.manaBtn.Location = new System.Drawing.Point(762, 251);
            this.manaBtn.Name = "manaBtn";
            this.manaBtn.Size = new System.Drawing.Size(71, 23);
            this.manaBtn.TabIndex = 18;
            this.manaBtn.Text = "+1 Mana";
            this.manaBtn.UseVisualStyleBackColor = true;
            this.manaBtn.Click += new System.EventHandler(this.manaBtn_Click);
            // 
            // defBtn
            // 
            this.defBtn.Location = new System.Drawing.Point(839, 251);
            this.defBtn.Name = "defBtn";
            this.defBtn.Size = new System.Drawing.Size(71, 23);
            this.defBtn.TabIndex = 19;
            this.defBtn.Text = "+1 Defence";
            this.defBtn.UseVisualStyleBackColor = true;
            this.defBtn.Click += new System.EventHandler(this.defBtn_Click);
            // 
            // verifyLabel
            // 
            this.verifyLabel.AutoSize = true;
            this.verifyLabel.Location = new System.Drawing.Point(693, 316);
            this.verifyLabel.Name = "verifyLabel";
            this.verifyLabel.Size = new System.Drawing.Size(228, 13);
            this.verifyLabel.TabIndex = 20;
            this.verifyLabel.Text = "**Verify your answers before you click submit!**";
            // 
            // btnName2
            // 
            this.btnName2.Location = new System.Drawing.Point(744, 382);
            this.btnName2.Margin = new System.Windows.Forms.Padding(2);
            this.btnName2.Name = "btnName2";
            this.btnName2.Size = new System.Drawing.Size(56, 19);
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
            this.Controls.Add(this.defBtn);
            this.Controls.Add(this.manaBtn);
            this.Controls.Add(this.speedBtn);
            this.Controls.Add(this.strengthBtn);
            this.Controls.Add(this.modLabel);
            this.Controls.Add(this.txtboxRace);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.txtBoxName2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.preferBtn);
            this.Controls.Add(this.maleBtn);
            this.Controls.Add(this.femaleBtn);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.charLabel3);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.charLabel1);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.charLabel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "NameForm";
            this.Text = "NameForm";
            this.Load += new System.EventHandler(this.NameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label charLabel2;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Label charLabel1;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Label charLabel3;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Button femaleBtn;
        private System.Windows.Forms.Button maleBtn;
        private System.Windows.Forms.Button preferBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox txtBoxName2;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.TextBox txtboxRace;
        private System.Windows.Forms.Label modLabel;
        private System.Windows.Forms.Button strengthBtn;
        private System.Windows.Forms.Button speedBtn;
        private System.Windows.Forms.Button manaBtn;
        private System.Windows.Forms.Button defBtn;
        private System.Windows.Forms.Label verifyLabel;
        private System.Windows.Forms.Button btnName2;
    }
}