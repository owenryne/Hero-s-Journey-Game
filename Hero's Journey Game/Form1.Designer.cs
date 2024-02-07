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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButt = new System.Windows.Forms.Button();
            this.charInfo = new System.Windows.Forms.TextBox();
            this.charNam = new System.Windows.Forms.TextBox();
            this.charLevel = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // forwardButt
            // 
            this.forwardButt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardButt.Location = new System.Drawing.Point(574, 300);
            this.forwardButt.Name = "forwardButt";
            this.forwardButt.Size = new System.Drawing.Size(63, 23);
            this.forwardButt.TabIndex = 0;
            this.forwardButt.Text = "Forward";
            this.forwardButt.UseVisualStyleBackColor = true;
            this.forwardButt.Click += new System.EventHandler(this.forwardButt_Click);
            // 
            // playerCoords
            // 
            this.playerCoords.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCoords.Location = new System.Drawing.Point(1074, 11);
            this.playerCoords.Margin = new System.Windows.Forms.Padding(2);
            this.playerCoords.Name = "playerCoords";
            this.playerCoords.Size = new System.Drawing.Size(100, 23);
            this.playerCoords.TabIndex = 2;
            this.playerCoords.Text = "Coordinates";
            this.playerCoords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.playerCoords.TextChanged += new System.EventHandler(this.playerCoords_TextChanged);
            // 
            // updateBox
            // 
            this.updateBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.updateBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBox.ForeColor = System.Drawing.SystemColors.Window;
            this.updateBox.FormattingEnabled = true;
            this.updateBox.ItemHeight = 15;
            this.updateBox.Location = new System.Drawing.Point(455, 56);
            this.updateBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(301, 199);
            this.updateBox.TabIndex = 3;
            //this.updateBox.SelectedIndexChanged += new System.EventHandler(this.updateBox_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(574, 353);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(53, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            //this.backButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // rightButt
            // 
            this.rightButt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButt.Location = new System.Drawing.Point(635, 331);
            this.rightButt.Name = "rightButt";
            this.rightButt.Size = new System.Drawing.Size(53, 23);
            this.rightButt.TabIndex = 5;
            this.rightButt.Text = "Right";
            this.rightButt.UseVisualStyleBackColor = true;
            //this.rightButt.Click += new System.EventHandler(this.button3_Click);
            // 
            // leftButton
            // 
            this.leftButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(515, 331);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(53, 23);
            this.leftButton.TabIndex = 6;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // combatText
            // 
            this.combatText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatText.Location = new System.Drawing.Point(97, 262);
            this.combatText.Margin = new System.Windows.Forms.Padding(2);
            this.combatText.Name = "combatText";
            this.combatText.Size = new System.Drawing.Size(100, 23);
            this.combatText.TabIndex = 7;
            this.combatText.Text = "Combat Buttons";
            this.combatText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // attackButt
            // 
            this.attackButt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButt.Location = new System.Drawing.Point(61, 290);
            this.attackButt.Name = "attackButt";
            this.attackButt.Size = new System.Drawing.Size(57, 23);
            this.attackButt.TabIndex = 8;
            this.attackButt.Text = "Attack 1";
            this.attackButt.UseVisualStyleBackColor = true;
            // 
            // blockButt
            // 
            this.blockButt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockButt.Location = new System.Drawing.Point(186, 290);
            this.blockButt.Margin = new System.Windows.Forms.Padding(2);
            this.blockButt.Name = "blockButt";
            this.blockButt.Size = new System.Drawing.Size(53, 23);
            this.blockButt.TabIndex = 9;
            this.blockButt.Text = "Block";
            this.blockButt.UseVisualStyleBackColor = true;
            // 
            // okButt
            // 
            this.okButt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButt.Location = new System.Drawing.Point(927, 272);
            this.okButt.Margin = new System.Windows.Forms.Padding(2);
            this.okButt.Name = "okButt";
            this.okButt.Size = new System.Drawing.Size(53, 23);
            this.okButt.TabIndex = 10;
            this.okButt.Text = "OK";
            this.okButt.UseVisualStyleBackColor = true;
            // 
            // navText
            // 
            this.navText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navText.Location = new System.Drawing.Point(547, 272);
            this.navText.Margin = new System.Windows.Forms.Padding(2);
            this.navText.Name = "navText";
            this.navText.Size = new System.Drawing.Size(120, 23);
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
            //this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(949, 248);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Selection Buttons";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(984, 272);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(53, 23);
            this.nextButton.TabIndex = 13;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // backButt
            // 
            this.backButt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButt.Location = new System.Drawing.Point(1041, 272);
            this.backButt.Margin = new System.Windows.Forms.Padding(2);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(53, 23);
            this.backButt.TabIndex = 14;
            this.backButt.Text = "Back";
            this.backButt.UseVisualStyleBackColor = true;
            // 
            // charInfo
            // 
            this.charInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charInfo.Location = new System.Drawing.Point(78, 20);
            this.charInfo.Margin = new System.Windows.Forms.Padding(2);
            this.charInfo.Name = "charInfo";
            this.charInfo.Size = new System.Drawing.Size(128, 23);
            this.charInfo.TabIndex = 15;
            this.charInfo.Text = "Character Information";
            this.charInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // charNam
            // 
            this.charNam.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charNam.Location = new System.Drawing.Point(78, 56);
            this.charNam.Margin = new System.Windows.Forms.Padding(2);
            this.charNam.Name = "charNam";
            this.charNam.Size = new System.Drawing.Size(128, 23);
            this.charNam.TabIndex = 16;
            this.charNam.Text = "Character Name";
            this.charNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.charNam.TextChanged += new System.EventHandler(this.charNam_TextChanged);
            // 
            // charLevel
            // 
            this.charLevel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charLevel.Location = new System.Drawing.Point(78, 93);
            this.charLevel.Margin = new System.Windows.Forms.Padding(2);
            this.charLevel.Name = "charLevel";
            this.charLevel.Size = new System.Drawing.Size(60, 23);
            this.charLevel.TabIndex = 17;
            this.charLevel.Text = "Lvl.";
            this.charLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.charLevel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(146, 93);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 23);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(124, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Attack 2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(78, 132);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 23);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "Character Region";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1195, 599);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.charLevel);
            this.Controls.Add(this.charNam);
            this.Controls.Add(this.charInfo);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.textBox1);
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
            this.Name = "Form1";
            this.Text = "s";
            //this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.TextBox charInfo;
        private System.Windows.Forms.TextBox charNam;
        private System.Windows.Forms.TextBox charLevel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

