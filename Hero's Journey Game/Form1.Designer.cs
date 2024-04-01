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
            this.lvlBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.charRegion = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.clearBox = new System.Windows.Forms.Button();
            this.dialogueButton = new System.Windows.Forms.Button();
            this.classesText = new System.Windows.Forms.TextBox();
            this.warriorButton = new System.Windows.Forms.Button();
            this.mageButton = new System.Windows.Forms.Button();
            this.charGender = new System.Windows.Forms.TextBox();
            this.playerHealth = new System.Windows.Forms.Label();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.enemyHealth = new System.Windows.Forms.Label();
            this.enemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.rougeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forwardButt
            // 
            this.forwardButt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardButt.Location = new System.Drawing.Point(765, 476);
            this.forwardButt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.forwardButt.Name = "forwardButt";
            this.forwardButt.Size = new System.Drawing.Size(84, 28);
            this.forwardButt.TabIndex = 0;
            this.forwardButt.Text = "Forward";
            this.forwardButt.UseVisualStyleBackColor = true;
            this.forwardButt.Click += new System.EventHandler(this.forwardButt_Click);
            // 
            // playerCoords
            // 
            this.playerCoords.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCoords.Location = new System.Drawing.Point(1280, 53);
            this.playerCoords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerCoords.Name = "playerCoords";
            this.playerCoords.ReadOnly = true;
            this.playerCoords.Size = new System.Drawing.Size(132, 27);
            this.playerCoords.TabIndex = 2;
            this.playerCoords.Text = "Coordinates";
            this.playerCoords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updateBox
            // 
            this.updateBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.updateBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBox.ForeColor = System.Drawing.SystemColors.Window;
            this.updateBox.FormattingEnabled = true;
            this.updateBox.ItemHeight = 19;
            this.updateBox.Location = new System.Drawing.Point(396, 94);
            this.updateBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(815, 232);
            this.updateBox.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(765, 543);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(84, 28);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // rightButt
            // 
            this.rightButt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButt.Location = new System.Drawing.Point(847, 512);
            this.rightButt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightButt.Name = "rightButt";
            this.rightButt.Size = new System.Drawing.Size(71, 28);
            this.rightButt.TabIndex = 5;
            this.rightButt.Text = "Right";
            this.rightButt.UseVisualStyleBackColor = true;
            this.rightButt.Click += new System.EventHandler(this.rightButt_Click);
            // 
            // leftButton
            // 
            this.leftButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(696, 512);
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
            this.combatText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatText.Location = new System.Drawing.Point(97, 262);
            this.combatText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combatText.Name = "combatText";
            this.combatText.ReadOnly = true;
            this.combatText.Size = new System.Drawing.Size(132, 27);
            this.combatText.TabIndex = 7;
            this.combatText.Text = "Combat Buttons";
            this.combatText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // attackButt
            // 
            this.attackButt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButt.Location = new System.Drawing.Point(81, 357);
            this.attackButt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attackButt.Name = "attackButt";
            this.attackButt.Size = new System.Drawing.Size(76, 28);
            this.attackButt.TabIndex = 8;
            this.attackButt.Text = "Attack 1";
            this.attackButt.UseVisualStyleBackColor = true;
            this.attackButt.Click += new System.EventHandler(this.attackButt_Click);
            // 
            // blockButt
            // 
            this.blockButt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockButt.Location = new System.Drawing.Point(131, 322);
            this.blockButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blockButt.Name = "blockButt";
            this.blockButt.Size = new System.Drawing.Size(71, 28);
            this.blockButt.TabIndex = 9;
            this.blockButt.Text = "Block";
            this.blockButt.UseVisualStyleBackColor = true;
            this.blockButt.Click += new System.EventHandler(this.blockButt_Click);
            // 
            // okButt
            // 
            this.okButt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButt.Location = new System.Drawing.Point(1217, 290);
            this.okButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okButt.Name = "okButt";
            this.okButt.Size = new System.Drawing.Size(71, 28);
            this.okButt.TabIndex = 10;
            this.okButt.Text = "OK";
            this.okButt.UseVisualStyleBackColor = true;
            // 
            // navText
            // 
            this.navText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navText.Location = new System.Drawing.Point(725, 442);
            this.navText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navText.Name = "navText";
            this.navText.ReadOnly = true;
            this.navText.Size = new System.Drawing.Size(159, 27);
            this.navText.TabIndex = 11;
            this.navText.Text = "Navigation Buttons";
            this.navText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectButt
            // 
            this.selectButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButt.Location = new System.Drawing.Point(594, 193);
            this.selectButt.Name = "selectButt";
            this.selectButt.Size = new System.Drawing.Size(116, 23);
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
            this.characterInfo.Size = new System.Drawing.Size(143, 23);
            this.characterInfo.TabIndex = 14;
            this.characterInfo.Text = "Character Information";
            this.characterInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // charName
            // 
            this.charName.Location = new System.Drawing.Point(37, 38);
            this.charName.Name = "charName";
            this.charName.Size = new System.Drawing.Size(124, 22);
            this.charName.TabIndex = 15;
            this.charName.Text = "Character Name";
            this.charName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CharLvl
            // 
            this.CharLvl.Location = new System.Drawing.Point(99, 66);
            this.CharLvl.Name = "CharLvl";
            this.CharLvl.Size = new System.Drawing.Size(62, 22);
            this.CharLvl.TabIndex = 16;
            this.CharLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // levelText
            // 
            this.levelText.Location = new System.Drawing.Point(37, 66);
            this.levelText.Name = "levelText";
            this.levelText.Size = new System.Drawing.Size(62, 22);
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
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1265, 257);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(159, 27);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Selection Buttons";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(1307, 290);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(71, 28);
            this.nextButton.TabIndex = 13;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButt
            // 
            this.backButt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButt.Location = new System.Drawing.Point(1388, 290);
            this.backButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(71, 28);
            this.backButt.TabIndex = 14;
            this.backButt.Text = "Back";
            this.backButt.UseVisualStyleBackColor = true;
            // 
            // charInfo
            // 
            this.charInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charInfo.Location = new System.Drawing.Point(109, 48);
            this.charInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charInfo.Name = "charInfo";
            this.charInfo.ReadOnly = true;
            this.charInfo.Size = new System.Drawing.Size(169, 27);
            this.charInfo.TabIndex = 15;
            this.charInfo.Text = "Character Information";
            this.charInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // charNam
            // 
            this.charNam.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charNam.Location = new System.Drawing.Point(109, 81);
            this.charNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charNam.Name = "charNam";
            this.charNam.ReadOnly = true;
            this.charNam.Size = new System.Drawing.Size(169, 27);
            this.charNam.TabIndex = 16;
            this.charNam.Text = "Character Name";
            this.charNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // charLevel
            // 
            this.charLevel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charLevel.Location = new System.Drawing.Point(109, 149);
            this.charLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charLevel.Name = "charLevel";
            this.charLevel.ReadOnly = true;
            this.charLevel.Size = new System.Drawing.Size(79, 27);
            this.charLevel.TabIndex = 17;
            this.charLevel.Text = "Lvl.";
            this.charLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvlBox
            // 
            this.lvlBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlBox.Location = new System.Drawing.Point(200, 149);
            this.lvlBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvlBox.Name = "lvlBox";
            this.lvlBox.ReadOnly = true;
            this.lvlBox.Size = new System.Drawing.Size(79, 27);
            this.lvlBox.TabIndex = 18;
            this.lvlBox.Text = "0";
            this.lvlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(165, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Attack 2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // charRegion
            // 
            this.charRegion.Location = new System.Drawing.Point(15, 14);
            this.charRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charRegion.Name = "charRegion";
            this.charRegion.Size = new System.Drawing.Size(100, 22);
            this.charRegion.TabIndex = 29;
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(629, 28);
            this.titleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(436, 58);
            this.titleBox.TabIndex = 21;
            this.titleBox.Text = "Hero\'s Journey";
            this.titleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Honeydew;
            this.progressBar.Location = new System.Drawing.Point(109, 183);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(171, 12);
            this.progressBar.TabIndex = 22;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(749, 394);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 23;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // clearBox
            // 
            this.clearBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBox.Location = new System.Drawing.Point(1236, 324);
            this.clearBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBox.Name = "clearBox";
            this.clearBox.Size = new System.Drawing.Size(223, 28);
            this.clearBox.TabIndex = 24;
            this.clearBox.Text = "Clear Text";
            this.clearBox.UseVisualStyleBackColor = true;
            this.clearBox.Click += new System.EventHandler(this.clearBox_Click);
            // 
            // dialogueButton
            // 
            this.dialogueButton.Location = new System.Drawing.Point(749, 357);
            this.dialogueButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dialogueButton.Name = "dialogueButton";
            this.dialogueButton.Size = new System.Drawing.Size(100, 28);
            this.dialogueButton.TabIndex = 25;
            this.dialogueButton.Text = "Dialogue";
            this.dialogueButton.UseVisualStyleBackColor = true;
            this.dialogueButton.Click += new System.EventHandler(this.dialogueButton_Click);
            // 
            // classesText
            // 
            this.classesText.Enabled = false;
            this.classesText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classesText.Location = new System.Drawing.Point(1280, 512);
            this.classesText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.classesText.Name = "classesText";
            this.classesText.Size = new System.Drawing.Size(132, 27);
            this.classesText.TabIndex = 26;
            this.classesText.Text = "Classes";
            this.classesText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.classesText.Visible = false;
            // 
            // warriorButton
            // 
            this.warriorButton.Location = new System.Drawing.Point(1188, 547);
            this.warriorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.warriorButton.Name = "warriorButton";
            this.warriorButton.Size = new System.Drawing.Size(100, 28);
            this.warriorButton.TabIndex = 27;
            this.warriorButton.Text = "Warrior";
            this.warriorButton.UseVisualStyleBackColor = true;
            this.warriorButton.Visible = false;
            this.warriorButton.Click += new System.EventHandler(this.warriorButton_Click);
            // 
            // mageButton
            // 
            this.mageButton.Location = new System.Drawing.Point(1296, 547);
            this.mageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mageButton.Name = "mageButton";
            this.mageButton.Size = new System.Drawing.Size(100, 28);
            this.mageButton.TabIndex = 28;
            this.mageButton.Text = "Mage";
            this.mageButton.UseVisualStyleBackColor = true;
            this.mageButton.Visible = false;
            this.mageButton.Click += new System.EventHandler(this.mageButton_Click);
            // 
            // charGender
            // 
            this.charGender.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charGender.Location = new System.Drawing.Point(109, 116);
            this.charGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charGender.Name = "charGender";
            this.charGender.ReadOnly = true;
            this.charGender.Size = new System.Drawing.Size(169, 27);
            this.charGender.TabIndex = 30;
            this.charGender.Text = "Character Gender";
            this.charGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerHealth
            // 
            this.playerHealth.AutoSize = true;
            this.playerHealth.BackColor = System.Drawing.SystemColors.Control;
            this.playerHealth.Location = new System.Drawing.Point(1005, 357);
            this.playerHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(86, 16);
            this.playerHealth.TabIndex = 31;
            this.playerHealth.Text = "Player Name";
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.ForeColor = System.Drawing.Color.Honeydew;
            this.playerHealthBar.Location = new System.Drawing.Point(971, 377);
            this.playerHealthBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(160, 12);
            this.playerHealthBar.TabIndex = 32;
            // 
            // enemyHealth
            // 
            this.enemyHealth.AutoSize = true;
            this.enemyHealth.BackColor = System.Drawing.SystemColors.Control;
            this.enemyHealth.Location = new System.Drawing.Point(517, 363);
            this.enemyHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enemyHealth.Name = "enemyHealth";
            this.enemyHealth.Size = new System.Drawing.Size(89, 16);
            this.enemyHealth.TabIndex = 33;
            this.enemyHealth.Text = "Enemy Name";
            // 
            // enemyHealthBar
            // 
            this.enemyHealthBar.ForeColor = System.Drawing.Color.Honeydew;
            this.enemyHealthBar.Location = new System.Drawing.Point(480, 383);
            this.enemyHealthBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enemyHealthBar.Name = "enemyHealthBar";
            this.enemyHealthBar.Size = new System.Drawing.Size(160, 12);
            this.enemyHealthBar.TabIndex = 34;
            // 
            // rougeButton
            // 
            this.rougeButton.Location = new System.Drawing.Point(1403, 547);
            this.rougeButton.Name = "rougeButton";
            this.rougeButton.Size = new System.Drawing.Size(100, 28);
            this.rougeButton.TabIndex = 35;
            this.rougeButton.Text = "Rogue";
            this.rougeButton.UseVisualStyleBackColor = true;
            this.rougeButton.Click += new System.EventHandler(this.rougeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1593, 737);
            this.Controls.Add(this.rougeButton);
            this.Controls.Add(this.enemyHealthBar);
            this.Controls.Add(this.enemyHealth);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.playerHealth);
            this.Controls.Add(this.charGender);
            this.Controls.Add(this.mageButton);
            this.Controls.Add(this.warriorButton);
            this.Controls.Add(this.classesText);
            this.Controls.Add(this.dialogueButton);
            this.Controls.Add(this.clearBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.charRegion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvlBox);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "s";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.TextBox charInfo;
        private System.Windows.Forms.TextBox charNam;
        private System.Windows.Forms.TextBox charLevel;
        private System.Windows.Forms.TextBox lvlBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox charRegion;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button clearBox;
        private System.Windows.Forms.Button dialogueButton;
        private System.Windows.Forms.TextBox classesText;
        private System.Windows.Forms.Button warriorButton;
        private System.Windows.Forms.Button mageButton;
        private System.Windows.Forms.TextBox charGender;
        private System.Windows.Forms.Label playerHealth;
        private System.Windows.Forms.ProgressBar playerHealthBar;
        private System.Windows.Forms.Label enemyHealth;
        private System.Windows.Forms.ProgressBar enemyHealthBar;
        private System.Windows.Forms.Button rougeButton;
    }
}

