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
            this.combatText = new System.Windows.Forms.TextBox();
            this.attackButt = new System.Windows.Forms.Button();
            this.blockButt = new System.Windows.Forms.Button();
            this.okButt = new System.Windows.Forms.Button();
            this.navText = new System.Windows.Forms.TextBox();
            this.selectButt = new System.Windows.Forms.TextBox();
            this.goBackButt = new System.Windows.Forms.Button();
            this.characterInfo = new System.Windows.Forms.TextBox();
            this.charName = new System.Windows.Forms.TextBox();
            this.CharLvl = new System.Windows.Forms.TextBox();
            this.levelText = new System.Windows.Forms.TextBox();
            this.nextButt = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forwardButt
            // 
            this.forwardButt.Location = new System.Drawing.Point(495, 336);
            this.forwardButt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.forwardButt.Name = "forwardButt";
            this.forwardButt.Size = new System.Drawing.Size(71, 28);
            this.forwardButt.TabIndex = 0;
            this.forwardButt.Text = "Forward";
            this.forwardButt.UseVisualStyleBackColor = true;
            this.forwardButt.Click += new System.EventHandler(this.forwardButt_Click);
            // 
            // playerCoords
            // 
            this.playerCoords.Location = new System.Drawing.Point(555, 30);
            this.playerCoords.Name = "playerCoords";
            this.playerCoords.Size = new System.Drawing.Size(132, 22);
            this.playerCoords.TabIndex = 2;
            this.playerCoords.Text = "Coordinates";
            this.playerCoords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerCoords.TextChanged += new System.EventHandler(this.playerCoords_TextChanged);
            // 
            // updateBox
            // 
            this.updateBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.updateBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBox.ForeColor = System.Drawing.SystemColors.Window;
            this.updateBox.FormattingEnabled = true;
            this.updateBox.Location = new System.Drawing.Point(308, 66);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(173, 147);
            this.updateBox.TabIndex = 3;
            this.updateBox.SelectedIndexChanged += new System.EventHandler(this.updateBox_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(495, 407);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(71, 28);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // rightButt
            // 
            this.rightButt.Location = new System.Drawing.Point(573, 372);
            this.rightButt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightButt.Name = "rightButt";
            this.rightButt.Size = new System.Drawing.Size(71, 28);
            this.rightButt.TabIndex = 5;
            this.rightButt.Text = "Right";
            this.rightButt.UseVisualStyleBackColor = true;
            this.rightButt.Click += new System.EventHandler(this.button3_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(416, 372);
            this.leftButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(71, 28);
            this.leftButton.TabIndex = 6;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // combatText
            // 
            this.combatText.Location = new System.Drawing.Point(47, 193);
            this.combatText.Name = "combatText";
            this.combatText.Size = new System.Drawing.Size(132, 22);
            this.combatText.TabIndex = 7;
            this.combatText.Text = "Combat Buttons";
            this.combatText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // attackButt
            // 
            this.attackButt.Location = new System.Drawing.Point(36, 270);
            this.attackButt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attackButt.Name = "attackButt";
            this.attackButt.Size = new System.Drawing.Size(71, 28);
            this.attackButt.TabIndex = 8;
            this.attackButt.Text = "Attack";
            this.attackButt.UseVisualStyleBackColor = true;
            // 
            // blockButt
            // 
            this.blockButt.Location = new System.Drawing.Point(112, 219);
            this.blockButt.Name = "blockButt";
            this.blockButt.Size = new System.Drawing.Size(71, 28);
            this.blockButt.TabIndex = 9;
            this.blockButt.Text = "Block";
            this.blockButt.UseVisualStyleBackColor = true;
            // 
            // okButt
            // 
            this.okButt.Location = new System.Drawing.Point(371, 302);
            this.okButt.Name = "okButt";
            this.okButt.Size = new System.Drawing.Size(71, 28);
            this.okButt.TabIndex = 10;
            this.okButt.Text = "OK";
            this.okButt.UseVisualStyleBackColor = true;
            // 
            // navText
            // 
            this.navText.Location = new System.Drawing.Point(347, 247);
            this.navText.Name = "navText";
            this.navText.Size = new System.Drawing.Size(100, 20);
            this.navText.TabIndex = 11;
            this.navText.Text = "Navigation Buttons";
            this.navText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectButt
            // 
            this.selectButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButt.Location = new System.Drawing.Point(594, 193);
            this.selectButt.Name = "selectButt";
            this.selectButt.Size = new System.Drawing.Size(116, 20);
            this.selectButt.TabIndex = 12;
            this.selectButt.Text = "Selection Buttons";
            this.selectButt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goBackButt
            // 
            this.goBackButt.Location = new System.Drawing.Point(685, 219);
            this.goBackButt.Name = "goBackButt";
            this.goBackButt.Size = new System.Drawing.Size(58, 23);
            this.goBackButt.TabIndex = 13;
            this.goBackButt.Text = "Go Back";
            this.goBackButt.UseVisualStyleBackColor = true;
            // 
            // characterInfo
            // 
            this.characterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterInfo.Location = new System.Drawing.Point(28, 12);
            this.characterInfo.Name = "characterInfo";
            this.characterInfo.Size = new System.Drawing.Size(143, 20);
            this.characterInfo.TabIndex = 14;
            this.characterInfo.Text = "Character Information";
            this.characterInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // charName
            // 
            this.charName.Location = new System.Drawing.Point(37, 38);
            this.charName.Name = "charName";
            this.charName.Size = new System.Drawing.Size(124, 20);
            this.charName.TabIndex = 15;
            this.charName.Text = "Character Name";
            this.charName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CharLvl
            // 
            this.CharLvl.Location = new System.Drawing.Point(99, 66);
            this.CharLvl.Name = "CharLvl";
            this.CharLvl.Size = new System.Drawing.Size(62, 20);
            this.CharLvl.TabIndex = 16;
            this.CharLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // levelText
            // 
            this.levelText.Location = new System.Drawing.Point(37, 66);
            this.levelText.Name = "levelText";
            this.levelText.Size = new System.Drawing.Size(62, 20);
            this.levelText.TabIndex = 17;
            this.levelText.Text = "Lvl:";
            this.levelText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextButt
            // 
            this.nextButt.Location = new System.Drawing.Point(626, 219);
            this.nextButt.Name = "nextButt";
            this.nextButt.Size = new System.Drawing.Size(53, 23);
            this.nextButt.TabIndex = 18;
            this.nextButt.Text = "Next";
            this.nextButt.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(271, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(262, 45);
            this.title.TabIndex = 19;
            this.title.Text = "Hero\'s Journey";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navText);
            this.Controls.Add(this.okButt);
            this.Controls.Add(this.blockButt);
            this.Controls.Add(this.attackButt);
            this.Controls.Add(this.combatText);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.rightButt);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateBox);
            this.Controls.Add(this.playerCoords);
            this.Controls.Add(this.forwardButt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox combatText;
        private System.Windows.Forms.Button attackButt;
        private System.Windows.Forms.Button blockButt;
        private System.Windows.Forms.Button okButt;
        private System.Windows.Forms.TextBox navText;
        private System.Windows.Forms.TextBox selectButt;
        private System.Windows.Forms.Button goBackButt;
        private System.Windows.Forms.TextBox characterInfo;
        private System.Windows.Forms.TextBox charName;
        private System.Windows.Forms.TextBox CharLvl;
        private System.Windows.Forms.TextBox levelText;
        private System.Windows.Forms.Button nextButt;
        private System.Windows.Forms.Label title;
    }
}

