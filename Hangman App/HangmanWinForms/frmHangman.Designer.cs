namespace Hangman_App
{
    partial class frmHangman
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangman));
            tblMain = new TableLayoutPanel();
            tblLeft = new TableLayoutPanel();
            tblToolbar = new TableLayoutPanel();
            btnStart = new Button();
            lblHowManyLetters = new Label();
            txtHowManyLetters = new TextBox();
            lblTriesLeft = new Label();
            tblWord = new TableLayoutPanel();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            txt4 = new TextBox();
            txt5 = new TextBox();
            txt6 = new TextBox();
            txt7 = new TextBox();
            txt8 = new TextBox();
            txt9 = new TextBox();
            tblLetters = new TableLayoutPanel();
            btnZ = new Button();
            btnY = new Button();
            btnX = new Button();
            btnW = new Button();
            btnV = new Button();
            btnU = new Button();
            btnT = new Button();
            btnS = new Button();
            btnR = new Button();
            btnQ = new Button();
            btnP = new Button();
            btnO = new Button();
            btnN = new Button();
            btnM = new Button();
            btnL = new Button();
            btnK = new Button();
            btnJ = new Button();
            btnI = new Button();
            btnH = new Button();
            btnG = new Button();
            btnF = new Button();
            btnE = new Button();
            btnD = new Button();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            picGallows = new PictureBox();
            lblMessage = new Label();
            tblMain.SuspendLayout();
            tblLeft.SuspendLayout();
            tblToolbar.SuspendLayout();
            tblWord.SuspendLayout();
            tblLetters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGallows).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.7078056F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.2921944F));
            tblMain.Controls.Add(tblLeft, 0, 0);
            tblMain.Controls.Add(picGallows, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(1102, 644);
            tblMain.TabIndex = 0;
            // 
            // tblLeft
            // 
            tblLeft.ColumnCount = 1;
            tblLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLeft.Controls.Add(tblToolbar, 0, 0);
            tblLeft.Controls.Add(tblWord, 0, 2);
            tblLeft.Controls.Add(tblLetters, 0, 4);
            tblLeft.Controls.Add(lblMessage, 0, 1);
            tblLeft.Dock = DockStyle.Fill;
            tblLeft.Location = new Point(3, 3);
            tblLeft.Name = "tblLeft";
            tblLeft.RowCount = 5;
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 18.5897427F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 81.4102554F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 172F));
            tblLeft.Size = new Size(663, 638);
            tblLeft.TabIndex = 0;
            // 
            // tblToolbar
            // 
            tblToolbar.AutoSize = true;
            tblToolbar.ColumnCount = 4;
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.3039455F));
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.30395F));
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.091186F));
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.3009224F));
            tblToolbar.Controls.Add(btnStart, 0, 0);
            tblToolbar.Controls.Add(lblHowManyLetters, 1, 0);
            tblToolbar.Controls.Add(txtHowManyLetters, 2, 0);
            tblToolbar.Controls.Add(lblTriesLeft, 3, 0);
            tblToolbar.Dock = DockStyle.Fill;
            tblToolbar.Location = new Point(3, 3);
            tblToolbar.Name = "tblToolbar";
            tblToolbar.RowCount = 1;
            tblToolbar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblToolbar.Size = new Size(657, 52);
            tblToolbar.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("Segoe UI", 11F);
            btnStart.Location = new Point(3, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(193, 46);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // lblHowManyLetters
            // 
            lblHowManyLetters.AutoSize = true;
            lblHowManyLetters.Dock = DockStyle.Fill;
            lblHowManyLetters.Font = new Font("Segoe UI", 11F);
            lblHowManyLetters.Location = new Point(202, 0);
            lblHowManyLetters.Name = "lblHowManyLetters";
            lblHowManyLetters.Size = new Size(193, 52);
            lblHowManyLetters.TabIndex = 1;
            lblHowManyLetters.Text = "How Many Letters: ";
            lblHowManyLetters.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHowManyLetters
            // 
            txtHowManyLetters.Dock = DockStyle.Fill;
            txtHowManyLetters.Location = new Point(401, 3);
            txtHowManyLetters.Multiline = true;
            txtHowManyLetters.Name = "txtHowManyLetters";
            txtHowManyLetters.Size = new Size(53, 46);
            txtHowManyLetters.TabIndex = 2;
            // 
            // lblTriesLeft
            // 
            lblTriesLeft.AutoSize = true;
            lblTriesLeft.Dock = DockStyle.Fill;
            lblTriesLeft.Font = new Font("Segoe UI", 11F);
            lblTriesLeft.Location = new Point(460, 0);
            lblTriesLeft.Name = "lblTriesLeft";
            lblTriesLeft.Size = new Size(194, 52);
            lblTriesLeft.TabIndex = 3;
            lblTriesLeft.Text = " ";
            lblTriesLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblWord
            // 
            tblWord.ColumnCount = 9;
            tblWord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11111F));
            tblWord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblWord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblWord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblWord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblWord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblWord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblWord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblWord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblWord.Controls.Add(txt1, 0, 0);
            tblWord.Controls.Add(txt2, 1, 0);
            tblWord.Controls.Add(txt3, 2, 0);
            tblWord.Controls.Add(txt4, 3, 0);
            tblWord.Controls.Add(txt5, 4, 0);
            tblWord.Controls.Add(txt6, 5, 0);
            tblWord.Controls.Add(txt7, 6, 0);
            tblWord.Controls.Add(txt8, 7, 0);
            tblWord.Controls.Add(txt9, 8, 0);
            tblWord.Dock = DockStyle.Fill;
            tblWord.Location = new Point(3, 315);
            tblWord.Name = "tblWord";
            tblWord.RowCount = 1;
            tblWord.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblWord.Size = new Size(657, 81);
            tblWord.TabIndex = 1;
            // 
            // txt1
            // 
            txt1.BorderStyle = BorderStyle.None;
            txt1.Dock = DockStyle.Fill;
            txt1.Font = new Font("Segoe UI", 32F);
            txt1.Location = new Point(3, 3);
            txt1.Multiline = true;
            txt1.Name = "txt1";
            txt1.ReadOnly = true;
            txt1.Size = new Size(66, 75);
            txt1.TabIndex = 0;
            txt1.TextAlign = HorizontalAlignment.Center;
            // 
            // txt2
            // 
            txt2.BorderStyle = BorderStyle.None;
            txt2.Dock = DockStyle.Fill;
            txt2.Font = new Font("Segoe UI", 32F);
            txt2.Location = new Point(75, 3);
            txt2.Multiline = true;
            txt2.Name = "txt2";
            txt2.ReadOnly = true;
            txt2.Size = new Size(66, 75);
            txt2.TabIndex = 1;
            txt2.TextAlign = HorizontalAlignment.Center;
            // 
            // txt3
            // 
            txt3.BorderStyle = BorderStyle.None;
            txt3.Dock = DockStyle.Fill;
            txt3.Font = new Font("Segoe UI", 32F);
            txt3.Location = new Point(147, 3);
            txt3.Multiline = true;
            txt3.Name = "txt3";
            txt3.ReadOnly = true;
            txt3.Size = new Size(66, 75);
            txt3.TabIndex = 2;
            txt3.TextAlign = HorizontalAlignment.Center;
            // 
            // txt4
            // 
            txt4.BorderStyle = BorderStyle.None;
            txt4.Dock = DockStyle.Fill;
            txt4.Font = new Font("Segoe UI", 32F);
            txt4.Location = new Point(219, 3);
            txt4.Multiline = true;
            txt4.Name = "txt4";
            txt4.ReadOnly = true;
            txt4.Size = new Size(66, 75);
            txt4.TabIndex = 3;
            txt4.TextAlign = HorizontalAlignment.Center;
            // 
            // txt5
            // 
            txt5.BorderStyle = BorderStyle.None;
            txt5.Dock = DockStyle.Fill;
            txt5.Font = new Font("Segoe UI", 32F);
            txt5.Location = new Point(291, 3);
            txt5.Multiline = true;
            txt5.Name = "txt5";
            txt5.ReadOnly = true;
            txt5.Size = new Size(66, 75);
            txt5.TabIndex = 4;
            txt5.TextAlign = HorizontalAlignment.Center;
            // 
            // txt6
            // 
            txt6.BorderStyle = BorderStyle.None;
            txt6.Dock = DockStyle.Fill;
            txt6.Font = new Font("Segoe UI", 32F);
            txt6.Location = new Point(363, 3);
            txt6.Multiline = true;
            txt6.Name = "txt6";
            txt6.ReadOnly = true;
            txt6.Size = new Size(66, 75);
            txt6.TabIndex = 5;
            txt6.TextAlign = HorizontalAlignment.Center;
            // 
            // txt7
            // 
            txt7.BorderStyle = BorderStyle.None;
            txt7.Dock = DockStyle.Fill;
            txt7.Font = new Font("Segoe UI", 32F);
            txt7.Location = new Point(435, 3);
            txt7.Multiline = true;
            txt7.Name = "txt7";
            txt7.ReadOnly = true;
            txt7.Size = new Size(66, 75);
            txt7.TabIndex = 6;
            txt7.TextAlign = HorizontalAlignment.Center;
            // 
            // txt8
            // 
            txt8.BorderStyle = BorderStyle.None;
            txt8.Dock = DockStyle.Fill;
            txt8.Font = new Font("Segoe UI", 32F);
            txt8.Location = new Point(507, 3);
            txt8.Multiline = true;
            txt8.Name = "txt8";
            txt8.ReadOnly = true;
            txt8.Size = new Size(66, 75);
            txt8.TabIndex = 7;
            txt8.TextAlign = HorizontalAlignment.Center;
            // 
            // txt9
            // 
            txt9.BorderStyle = BorderStyle.None;
            txt9.Dock = DockStyle.Fill;
            txt9.Font = new Font("Segoe UI", 32F);
            txt9.Location = new Point(579, 3);
            txt9.Multiline = true;
            txt9.Name = "txt9";
            txt9.ReadOnly = true;
            txt9.Size = new Size(75, 75);
            txt9.TabIndex = 8;
            txt9.TextAlign = HorizontalAlignment.Center;
            // 
            // tblLetters
            // 
            tblLetters.ColumnCount = 9;
            tblLetters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblLetters.Controls.Add(btnZ, 7, 2);
            tblLetters.Controls.Add(btnY, 6, 2);
            tblLetters.Controls.Add(btnX, 5, 2);
            tblLetters.Controls.Add(btnW, 4, 2);
            tblLetters.Controls.Add(btnV, 3, 2);
            tblLetters.Controls.Add(btnU, 2, 2);
            tblLetters.Controls.Add(btnT, 1, 2);
            tblLetters.Controls.Add(btnS, 0, 2);
            tblLetters.Controls.Add(btnR, 8, 1);
            tblLetters.Controls.Add(btnQ, 7, 1);
            tblLetters.Controls.Add(btnP, 6, 1);
            tblLetters.Controls.Add(btnO, 5, 1);
            tblLetters.Controls.Add(btnN, 4, 1);
            tblLetters.Controls.Add(btnM, 3, 1);
            tblLetters.Controls.Add(btnL, 2, 1);
            tblLetters.Controls.Add(btnK, 1, 1);
            tblLetters.Controls.Add(btnJ, 0, 1);
            tblLetters.Controls.Add(btnI, 8, 0);
            tblLetters.Controls.Add(btnH, 7, 0);
            tblLetters.Controls.Add(btnG, 6, 0);
            tblLetters.Controls.Add(btnF, 5, 0);
            tblLetters.Controls.Add(btnE, 4, 0);
            tblLetters.Controls.Add(btnD, 3, 0);
            tblLetters.Controls.Add(btnA, 0, 0);
            tblLetters.Controls.Add(btnB, 1, 0);
            tblLetters.Controls.Add(btnC, 2, 0);
            tblLetters.Dock = DockStyle.Fill;
            tblLetters.Location = new Point(3, 468);
            tblLetters.Name = "tblLetters";
            tblLetters.RowCount = 3;
            tblLetters.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLetters.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLetters.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLetters.Size = new Size(657, 167);
            tblLetters.TabIndex = 2;
            // 
            // btnZ
            // 
            btnZ.Dock = DockStyle.Fill;
            btnZ.Enabled = false;
            btnZ.Font = new Font("Segoe UI", 20F);
            btnZ.Location = new Point(507, 113);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(66, 51);
            btnZ.TabIndex = 25;
            btnZ.Text = "Z";
            btnZ.UseVisualStyleBackColor = true;
            // 
            // btnY
            // 
            btnY.Dock = DockStyle.Fill;
            btnY.Enabled = false;
            btnY.Font = new Font("Segoe UI", 20F);
            btnY.Location = new Point(435, 113);
            btnY.Name = "btnY";
            btnY.Size = new Size(66, 51);
            btnY.TabIndex = 24;
            btnY.Text = "Y";
            btnY.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            btnX.Dock = DockStyle.Fill;
            btnX.Enabled = false;
            btnX.Font = new Font("Segoe UI", 20F);
            btnX.Location = new Point(363, 113);
            btnX.Name = "btnX";
            btnX.Size = new Size(66, 51);
            btnX.TabIndex = 23;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            // 
            // btnW
            // 
            btnW.Dock = DockStyle.Fill;
            btnW.Enabled = false;
            btnW.Font = new Font("Segoe UI", 20F);
            btnW.Location = new Point(291, 113);
            btnW.Name = "btnW";
            btnW.Size = new Size(66, 51);
            btnW.TabIndex = 22;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = true;
            // 
            // btnV
            // 
            btnV.Dock = DockStyle.Fill;
            btnV.Enabled = false;
            btnV.Font = new Font("Segoe UI", 20F);
            btnV.Location = new Point(219, 113);
            btnV.Name = "btnV";
            btnV.Size = new Size(66, 51);
            btnV.TabIndex = 21;
            btnV.Text = "V";
            btnV.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            btnU.Dock = DockStyle.Fill;
            btnU.Enabled = false;
            btnU.Font = new Font("Segoe UI", 20F);
            btnU.Location = new Point(147, 113);
            btnU.Name = "btnU";
            btnU.Size = new Size(66, 51);
            btnU.TabIndex = 20;
            btnU.Text = "U";
            btnU.UseVisualStyleBackColor = true;
            // 
            // btnT
            // 
            btnT.Dock = DockStyle.Fill;
            btnT.Enabled = false;
            btnT.Font = new Font("Segoe UI", 20F);
            btnT.Location = new Point(75, 113);
            btnT.Name = "btnT";
            btnT.Size = new Size(66, 51);
            btnT.TabIndex = 19;
            btnT.Text = "T";
            btnT.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            btnS.Dock = DockStyle.Fill;
            btnS.Enabled = false;
            btnS.Font = new Font("Segoe UI", 20F);
            btnS.Location = new Point(3, 113);
            btnS.Name = "btnS";
            btnS.Size = new Size(66, 51);
            btnS.TabIndex = 18;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            btnR.Dock = DockStyle.Fill;
            btnR.Enabled = false;
            btnR.Font = new Font("Segoe UI", 20F);
            btnR.Location = new Point(579, 58);
            btnR.Name = "btnR";
            btnR.Size = new Size(75, 49);
            btnR.TabIndex = 17;
            btnR.Text = "R";
            btnR.UseVisualStyleBackColor = true;
            // 
            // btnQ
            // 
            btnQ.Dock = DockStyle.Fill;
            btnQ.Enabled = false;
            btnQ.Font = new Font("Segoe UI", 20F);
            btnQ.Location = new Point(507, 58);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(66, 49);
            btnQ.TabIndex = 16;
            btnQ.Text = "Q";
            btnQ.UseVisualStyleBackColor = true;
            // 
            // btnP
            // 
            btnP.Dock = DockStyle.Fill;
            btnP.Enabled = false;
            btnP.Font = new Font("Segoe UI", 20F);
            btnP.Location = new Point(435, 58);
            btnP.Name = "btnP";
            btnP.Size = new Size(66, 49);
            btnP.TabIndex = 15;
            btnP.Text = "P";
            btnP.UseVisualStyleBackColor = true;
            // 
            // btnO
            // 
            btnO.Dock = DockStyle.Fill;
            btnO.Enabled = false;
            btnO.Font = new Font("Segoe UI", 20F);
            btnO.Location = new Point(363, 58);
            btnO.Name = "btnO";
            btnO.Size = new Size(66, 49);
            btnO.TabIndex = 14;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = true;
            // 
            // btnN
            // 
            btnN.Dock = DockStyle.Fill;
            btnN.Enabled = false;
            btnN.Font = new Font("Segoe UI", 20F);
            btnN.Location = new Point(291, 58);
            btnN.Name = "btnN";
            btnN.Size = new Size(66, 49);
            btnN.TabIndex = 13;
            btnN.Text = "N";
            btnN.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            btnM.Dock = DockStyle.Fill;
            btnM.Enabled = false;
            btnM.Font = new Font("Segoe UI", 20F);
            btnM.Location = new Point(219, 58);
            btnM.Name = "btnM";
            btnM.Size = new Size(66, 49);
            btnM.TabIndex = 12;
            btnM.Text = "M";
            btnM.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            btnL.Dock = DockStyle.Fill;
            btnL.Enabled = false;
            btnL.Font = new Font("Segoe UI", 20F);
            btnL.Location = new Point(147, 58);
            btnL.Name = "btnL";
            btnL.Size = new Size(66, 49);
            btnL.TabIndex = 11;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = true;
            // 
            // btnK
            // 
            btnK.Dock = DockStyle.Fill;
            btnK.Enabled = false;
            btnK.Font = new Font("Segoe UI", 20F);
            btnK.Location = new Point(75, 58);
            btnK.Name = "btnK";
            btnK.Size = new Size(66, 49);
            btnK.TabIndex = 10;
            btnK.Text = "K";
            btnK.UseVisualStyleBackColor = true;
            // 
            // btnJ
            // 
            btnJ.Dock = DockStyle.Fill;
            btnJ.Enabled = false;
            btnJ.Font = new Font("Segoe UI", 20F);
            btnJ.Location = new Point(3, 58);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(66, 49);
            btnJ.TabIndex = 9;
            btnJ.Text = "J";
            btnJ.UseVisualStyleBackColor = true;
            // 
            // btnI
            // 
            btnI.Dock = DockStyle.Fill;
            btnI.Enabled = false;
            btnI.Font = new Font("Segoe UI", 20F);
            btnI.Location = new Point(579, 3);
            btnI.Name = "btnI";
            btnI.Size = new Size(75, 49);
            btnI.TabIndex = 8;
            btnI.Text = "I";
            btnI.UseVisualStyleBackColor = true;
            // 
            // btnH
            // 
            btnH.Dock = DockStyle.Fill;
            btnH.Enabled = false;
            btnH.Font = new Font("Segoe UI", 20F);
            btnH.Location = new Point(507, 3);
            btnH.Name = "btnH";
            btnH.Size = new Size(66, 49);
            btnH.TabIndex = 7;
            btnH.Text = "H";
            btnH.UseVisualStyleBackColor = true;
            // 
            // btnG
            // 
            btnG.Dock = DockStyle.Fill;
            btnG.Enabled = false;
            btnG.Font = new Font("Segoe UI", 20F);
            btnG.Location = new Point(435, 3);
            btnG.Name = "btnG";
            btnG.Size = new Size(66, 49);
            btnG.TabIndex = 6;
            btnG.Text = "G";
            btnG.UseVisualStyleBackColor = true;
            // 
            // btnF
            // 
            btnF.Dock = DockStyle.Fill;
            btnF.Enabled = false;
            btnF.Font = new Font("Segoe UI", 20F);
            btnF.Location = new Point(363, 3);
            btnF.Name = "btnF";
            btnF.Size = new Size(66, 49);
            btnF.TabIndex = 5;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            btnE.Dock = DockStyle.Fill;
            btnE.Enabled = false;
            btnE.Font = new Font("Segoe UI", 20F);
            btnE.Location = new Point(291, 3);
            btnE.Name = "btnE";
            btnE.Size = new Size(66, 49);
            btnE.TabIndex = 4;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            btnD.Dock = DockStyle.Fill;
            btnD.Enabled = false;
            btnD.Font = new Font("Segoe UI", 20F);
            btnD.Location = new Point(219, 3);
            btnD.Name = "btnD";
            btnD.Size = new Size(66, 49);
            btnD.TabIndex = 3;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            btnA.Dock = DockStyle.Fill;
            btnA.Enabled = false;
            btnA.Font = new Font("Segoe UI", 20F);
            btnA.Location = new Point(3, 3);
            btnA.Name = "btnA";
            btnA.Size = new Size(66, 49);
            btnA.TabIndex = 0;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            btnB.Dock = DockStyle.Fill;
            btnB.Enabled = false;
            btnB.Font = new Font("Segoe UI", 20F);
            btnB.Location = new Point(75, 3);
            btnB.Name = "btnB";
            btnB.Size = new Size(66, 49);
            btnB.TabIndex = 1;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Dock = DockStyle.Fill;
            btnC.Enabled = false;
            btnC.Font = new Font("Segoe UI", 20F);
            btnC.Location = new Point(147, 3);
            btnC.Name = "btnC";
            btnC.Size = new Size(66, 49);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // picGallows
            // 
            picGallows.Dock = DockStyle.Fill;
            picGallows.Image = (Image)resources.GetObject("picGallows.Image");
            picGallows.Location = new Point(672, 3);
            picGallows.Name = "picGallows";
            picGallows.Size = new Size(427, 638);
            picGallows.SizeMode = PictureBoxSizeMode.Zoom;
            picGallows.TabIndex = 1;
            picGallows.TabStop = false;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(3, 58);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(657, 254);
            lblMessage.TabIndex = 3;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmHangman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 644);
            Controls.Add(tblMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHangman";
            Text = "Hangman";
            tblMain.ResumeLayout(false);
            tblLeft.ResumeLayout(false);
            tblLeft.PerformLayout();
            tblToolbar.ResumeLayout(false);
            tblToolbar.PerformLayout();
            tblWord.ResumeLayout(false);
            tblWord.PerformLayout();
            tblLetters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picGallows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblLeft;
        private TableLayoutPanel tblToolbar;
        private Button btnStart;
        private Label lblHowManyLetters;
        private TextBox txtHowManyLetters;
        private Label lblTriesLeft;
        private TableLayoutPanel tblWord;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private TextBox txt4;
        private TextBox txt5;
        private TextBox txt6;
        private TextBox txt7;
        private TextBox txt8;
        private TextBox txt9;
        private TableLayoutPanel tblLetters;
        private Button btnZ;
        private Button btnY;
        private Button btnX;
        private Button btnW;
        private Button btnV;
        private Button btnU;
        private Button btnT;
        private Button btnS;
        private Button btnR;
        private Button btnQ;
        private Button btnP;
        private Button btnO;
        private Button btnN;
        private Button btnM;
        private Button btnL;
        private Button btnK;
        private Button btnJ;
        private Button btnI;
        private Button btnH;
        private Button btnG;
        private Button btnF;
        private Button btnE;
        private Button btnD;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private PictureBox picGallows;
        private Label lblMessage;
    }
}
