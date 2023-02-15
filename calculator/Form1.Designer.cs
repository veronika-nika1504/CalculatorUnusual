namespace calculator
{
    partial class FormCalc
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalc));
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.BtnRoll = new System.Windows.Forms.Button();
            this.BtnTransform = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.TxtEstimation = new System.Windows.Forms.TextBox();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnBackSpace = new System.Windows.Forms.Button();
            this.BtnMS = new System.Windows.Forms.Button();
            this.BtnMminus = new System.Windows.Forms.Button();
            this.BtnMplus = new System.Windows.Forms.Button();
            this.BtnMC = new System.Windows.Forms.Button();
            this.BtnMR = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.BtnX2 = new System.Windows.Forms.Button();
            this.Btn1X = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnSubstraction = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnPM = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnDesimal = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Mindicate = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.TextBox();
            this.Help = new System.Windows.Forms.ToolTip(this.components);
            this.PanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.CalcMenuView = new System.Windows.Forms.Label();
            this.separatorM1 = new System.Windows.Forms.Label();
            this.NormalView = new System.Windows.Forms.Button();
            this.EngineeringView = new System.Windows.Forms.Button();
            this.separatorM2 = new System.Windows.Forms.Label();
            this.UnitConverterView = new System.Windows.Forms.Button();
            this.FuelConsumptionView = new System.Windows.Forms.Button();
            this.PnlTitle.SuspendLayout();
            this.PnlHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTitle.BackColor = System.Drawing.Color.PowderBlue;
            this.PnlTitle.Controls.Add(this.BtnRoll);
            this.PnlTitle.Controls.Add(this.BtnTransform);
            this.PnlTitle.Controls.Add(this.BtnExit);
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(350, 40);
            this.PnlTitle.TabIndex = 0;
            // 
            // BtnRoll
            // 
            this.BtnRoll.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRoll.FlatAppearance.BorderSize = 0;
            this.BtnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRoll.Image = ((System.Drawing.Image)(resources.GetObject("BtnRoll.Image")));
            this.BtnRoll.Location = new System.Drawing.Point(200, 0);
            this.BtnRoll.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(50, 40);
            this.BtnRoll.TabIndex = 1;
            this.Help.SetToolTip(this.BtnRoll, "Свернуть");
            this.BtnRoll.UseVisualStyleBackColor = false;
            this.BtnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // BtnTransform
            // 
            this.BtnTransform.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnTransform.FlatAppearance.BorderSize = 0;
            this.BtnTransform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTransform.Image = ((System.Drawing.Image)(resources.GetObject("BtnTransform.Image")));
            this.BtnTransform.Location = new System.Drawing.Point(250, 0);
            this.BtnTransform.Margin = new System.Windows.Forms.Padding(0);
            this.BtnTransform.Name = "BtnTransform";
            this.BtnTransform.Size = new System.Drawing.Size(50, 40);
            this.BtnTransform.TabIndex = 2;
            this.Help.SetToolTip(this.BtnTransform, "Изменить размер");
            this.BtnTransform.UseVisualStyleBackColor = false;
            this.BtnTransform.Click += new System.EventHandler(this.BtnTransform_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(300, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(50, 40);
            this.BtnExit.TabIndex = 3;
            this.Help.SetToolTip(this.BtnExit, "Закрыть");
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PnlHistory
            // 
            this.PnlHistory.Controls.Add(this.RtBoxDisplayHistory);
            this.PnlHistory.Controls.Add(this.BtnClearHistory);
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.Location = new System.Drawing.Point(0, 565);
            this.PnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(350, 5);
            this.PnlHistory.TabIndex = 1;
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.PowderBlue;
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtBoxDisplayHistory.ForeColor = System.Drawing.Color.Black;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(350, 0);
            this.RtBoxDisplayHistory.TabIndex = 4;
            this.RtBoxDisplayHistory.Text = "";
            this.RtBoxDisplayHistory.ZoomFactor = 1.5F;
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderSize = 0;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearHistory.Image")));
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -35);
            this.BtnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(350, 40);
            this.BtnClearHistory.TabIndex = 36;
            this.Help.SetToolTip(this.BtnClearHistory, "Очистить историю");
            this.BtnClearHistory.UseVisualStyleBackColor = false;
            this.BtnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Controls.Add(this.BtnHistory);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 2;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(50, 40);
            this.BtnMenu.TabIndex = 4;
            this.Help.SetToolTip(this.BtnMenu, "Меню");
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.MenuClick_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHistory.FlatAppearance.BorderSize = 0;
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnHistory.Image")));
            this.BtnHistory.Location = new System.Drawing.Point(300, 0);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.MinimumSize = new System.Drawing.Size(18, 18);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(50, 40);
            this.BtnHistory.TabIndex = 5;
            this.Help.SetToolTip(this.BtnHistory, "История");
            this.BtnHistory.UseVisualStyleBackColor = false;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // TxtEstimation
            // 
            this.TxtEstimation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEstimation.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtEstimation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEstimation.Font = new System.Drawing.Font("Gadugi", 14F);
            this.TxtEstimation.ForeColor = System.Drawing.Color.Black;
            this.TxtEstimation.Location = new System.Drawing.Point(0, 80);
            this.TxtEstimation.Margin = new System.Windows.Forms.Padding(0);
            this.TxtEstimation.Multiline = true;
            this.TxtEstimation.Name = "TxtEstimation";
            this.TxtEstimation.Size = new System.Drawing.Size(350, 35);
            this.TxtEstimation.TabIndex = 3;
            this.TxtEstimation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDisplay.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold);
            this.TxtDisplay.ForeColor = System.Drawing.Color.Black;
            this.TxtDisplay.Location = new System.Drawing.Point(0, 115);
            this.TxtDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(350, 50);
            this.TxtDisplay.TabIndex = 14;
            this.TxtDisplay.Text = "0";
            this.TxtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnBackSpace.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnBackSpace.FlatAppearance.BorderSize = 0;
            this.BtnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackSpace.ForeColor = System.Drawing.Color.White;
            this.BtnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackSpace.Image")));
            this.BtnBackSpace.Location = new System.Drawing.Point(264, 217);
            this.BtnBackSpace.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(80, 55);
            this.BtnBackSpace.TabIndex = 15;
            this.Help.SetToolTip(this.BtnBackSpace, "Стереть последний символ");
            this.BtnBackSpace.UseVisualStyleBackColor = false;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // BtnMS
            // 
            this.BtnMS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMS.FlatAppearance.BorderSize = 0;
            this.BtnMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnMS.Location = new System.Drawing.Point(272, 174);
            this.BtnMS.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMS.Name = "BtnMS";
            this.BtnMS.Size = new System.Drawing.Size(50, 30);
            this.BtnMS.TabIndex = 10;
            this.BtnMS.Text = "MS";
            this.Help.SetToolTip(this.BtnMS, "Сохранить в память");
            this.BtnMS.UseVisualStyleBackColor = false;
            this.BtnMS.Click += new System.EventHandler(this.BMemory_Click);
            // 
            // BtnMminus
            // 
            this.BtnMminus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMminus.FlatAppearance.BorderSize = 0;
            this.BtnMminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMminus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnMminus.Location = new System.Drawing.Point(210, 174);
            this.BtnMminus.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMminus.Name = "BtnMminus";
            this.BtnMminus.Size = new System.Drawing.Size(50, 30);
            this.BtnMminus.TabIndex = 9;
            this.BtnMminus.Text = "M-";
            this.Help.SetToolTip(this.BtnMminus, "Из числа в памяти вычесть число, на экране");
            this.BtnMminus.UseVisualStyleBackColor = false;
            this.BtnMminus.Click += new System.EventHandler(this.BMemory_Click);
            // 
            // BtnMplus
            // 
            this.BtnMplus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMplus.FlatAppearance.BorderSize = 0;
            this.BtnMplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMplus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnMplus.Location = new System.Drawing.Point(148, 174);
            this.BtnMplus.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMplus.Name = "BtnMplus";
            this.BtnMplus.Size = new System.Drawing.Size(50, 30);
            this.BtnMplus.TabIndex = 8;
            this.BtnMplus.Text = "M+";
            this.Help.SetToolTip(this.BtnMplus, "К числу в памяти прибавить число, на экране");
            this.BtnMplus.UseVisualStyleBackColor = false;
            this.BtnMplus.Click += new System.EventHandler(this.BMemory_Click);
            // 
            // BtnMC
            // 
            this.BtnMC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMC.FlatAppearance.BorderSize = 0;
            this.BtnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMC.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnMC.Location = new System.Drawing.Point(24, 174);
            this.BtnMC.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMC.Name = "BtnMC";
            this.BtnMC.Size = new System.Drawing.Size(50, 30);
            this.BtnMC.TabIndex = 6;
            this.BtnMC.Text = "MC";
            this.Help.SetToolTip(this.BtnMC, "Очистить память");
            this.BtnMC.UseVisualStyleBackColor = false;
            this.BtnMC.Click += new System.EventHandler(this.BMemory_Click);
            // 
            // BtnMR
            // 
            this.BtnMR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMR.FlatAppearance.BorderSize = 0;
            this.BtnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMR.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnMR.Location = new System.Drawing.Point(86, 174);
            this.BtnMR.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMR.Name = "BtnMR";
            this.BtnMR.Size = new System.Drawing.Size(50, 30);
            this.BtnMR.TabIndex = 7;
            this.BtnMR.Text = "MR";
            this.Help.SetToolTip(this.BtnMR, "Сохранить число в память");
            this.BtnMR.UseVisualStyleBackColor = false;
            this.BtnMR.Click += new System.EventHandler(this.BMemory_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPercent.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnPercent.FlatAppearance.BorderSize = 0;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.ForeColor = System.Drawing.Color.Black;
            this.BtnPercent.Location = new System.Drawing.Point(6, 217);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(80, 55);
            this.BtnPercent.TabIndex = 12;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = false;
            this.BtnPercent.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCE.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnCE.FlatAppearance.BorderSize = 0;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.ForeColor = System.Drawing.Color.Black;
            this.BtnCE.Location = new System.Drawing.Point(92, 217);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(80, 55);
            this.BtnCE.TabIndex = 13;
            this.BtnCE.Text = "CE";
            this.Help.SetToolTip(this.BtnCE, "Очистить окно ввода");
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnC
            // 
            this.BtnC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnC.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.ForeColor = System.Drawing.Color.Black;
            this.BtnC.Location = new System.Drawing.Point(178, 217);
            this.BtnC.Margin = new System.Windows.Forms.Padding(0);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(80, 55);
            this.BtnC.TabIndex = 0;
            this.BtnC.Text = "C";
            this.Help.SetToolTip(this.BtnC, "Стереть");
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSquare.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnSquare.FlatAppearance.BorderSize = 0;
            this.BtnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSquare.Font = new System.Drawing.Font("Gadugi", 17F);
            this.BtnSquare.ForeColor = System.Drawing.Color.Black;
            this.BtnSquare.Location = new System.Drawing.Point(178, 273);
            this.BtnSquare.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(80, 55);
            this.BtnSquare.TabIndex = 18;
            this.BtnSquare.Text = "√x";
            this.BtnSquare.UseVisualStyleBackColor = false;
            this.BtnSquare.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnX2
            // 
            this.BtnX2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnX2.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnX2.FlatAppearance.BorderSize = 0;
            this.BtnX2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnX2.Font = new System.Drawing.Font("Gadugi", 17F);
            this.BtnX2.ForeColor = System.Drawing.Color.Black;
            this.BtnX2.Location = new System.Drawing.Point(92, 273);
            this.BtnX2.Margin = new System.Windows.Forms.Padding(0);
            this.BtnX2.Name = "BtnX2";
            this.BtnX2.Size = new System.Drawing.Size(80, 55);
            this.BtnX2.TabIndex = 17;
            this.BtnX2.Text = "x²";
            this.BtnX2.UseVisualStyleBackColor = false;
            this.BtnX2.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // Btn1X
            // 
            this.Btn1X.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn1X.BackColor = System.Drawing.Color.MediumPurple;
            this.Btn1X.FlatAppearance.BorderSize = 0;
            this.Btn1X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1X.Font = new System.Drawing.Font("Gadugi", 17F);
            this.Btn1X.ForeColor = System.Drawing.Color.Black;
            this.Btn1X.Location = new System.Drawing.Point(6, 273);
            this.Btn1X.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1X.Name = "Btn1X";
            this.Btn1X.Size = new System.Drawing.Size(80, 55);
            this.Btn1X.TabIndex = 16;
            this.Btn1X.Text = "⅟x";
            this.Btn1X.UseVisualStyleBackColor = false;
            this.Btn1X.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnDivision.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnDivision.FlatAppearance.BorderSize = 0;
            this.BtnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivision.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnDivision.ForeColor = System.Drawing.Color.Black;
            this.BtnDivision.Location = new System.Drawing.Point(264, 273);
            this.BtnDivision.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(80, 55);
            this.BtnDivision.TabIndex = 19;
            this.BtnDivision.Text = "÷";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn7
            // 
            this.Btn7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn7.BackColor = System.Drawing.Color.DarkGray;
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn7.ForeColor = System.Drawing.Color.Black;
            this.Btn7.Location = new System.Drawing.Point(6, 329);
            this.Btn7.Margin = new System.Windows.Forms.Padding(0);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(80, 55);
            this.Btn7.TabIndex = 20;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn8
            // 
            this.Btn8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn8.BackColor = System.Drawing.Color.DarkGray;
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn8.ForeColor = System.Drawing.Color.Black;
            this.Btn8.Location = new System.Drawing.Point(92, 329);
            this.Btn8.Margin = new System.Windows.Forms.Padding(0);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(80, 55);
            this.Btn8.TabIndex = 21;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn9
            // 
            this.Btn9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn9.BackColor = System.Drawing.Color.DarkGray;
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn9.ForeColor = System.Drawing.Color.Black;
            this.Btn9.Location = new System.Drawing.Point(178, 329);
            this.Btn9.Margin = new System.Windows.Forms.Padding(0);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(80, 55);
            this.Btn9.TabIndex = 22;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnSubstraction
            // 
            this.BtnSubstraction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSubstraction.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnSubstraction.FlatAppearance.BorderSize = 0;
            this.BtnSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubstraction.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnSubstraction.ForeColor = System.Drawing.Color.Black;
            this.BtnSubstraction.Location = new System.Drawing.Point(264, 385);
            this.BtnSubstraction.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSubstraction.Name = "BtnSubstraction";
            this.BtnSubstraction.Size = new System.Drawing.Size(80, 55);
            this.BtnSubstraction.TabIndex = 27;
            this.BtnSubstraction.Text = "-";
            this.BtnSubstraction.UseVisualStyleBackColor = false;
            this.BtnSubstraction.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn4
            // 
            this.Btn4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn4.BackColor = System.Drawing.Color.DarkGray;
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn4.ForeColor = System.Drawing.Color.Black;
            this.Btn4.Location = new System.Drawing.Point(6, 385);
            this.Btn4.Margin = new System.Windows.Forms.Padding(0);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(80, 55);
            this.Btn4.TabIndex = 24;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn5
            // 
            this.Btn5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn5.BackColor = System.Drawing.Color.DarkGray;
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn5.ForeColor = System.Drawing.Color.Black;
            this.Btn5.Location = new System.Drawing.Point(92, 385);
            this.Btn5.Margin = new System.Windows.Forms.Padding(0);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(80, 55);
            this.Btn5.TabIndex = 25;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn6
            // 
            this.Btn6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn6.BackColor = System.Drawing.Color.DarkGray;
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn6.ForeColor = System.Drawing.Color.Black;
            this.Btn6.Location = new System.Drawing.Point(178, 385);
            this.Btn6.Margin = new System.Windows.Forms.Padding(0);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(80, 55);
            this.Btn6.TabIndex = 26;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMultiply.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnMultiply.FlatAppearance.BorderSize = 0;
            this.BtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiply.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnMultiply.ForeColor = System.Drawing.Color.Black;
            this.BtnMultiply.Location = new System.Drawing.Point(264, 329);
            this.BtnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(80, 55);
            this.BtnMultiply.TabIndex = 23;
            this.BtnMultiply.Text = "×";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn1
            // 
            this.Btn1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn1.BackColor = System.Drawing.Color.DarkGray;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn1.ForeColor = System.Drawing.Color.Black;
            this.Btn1.Location = new System.Drawing.Point(6, 441);
            this.Btn1.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(80, 55);
            this.Btn1.TabIndex = 28;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn2
            // 
            this.Btn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn2.BackColor = System.Drawing.Color.DarkGray;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn2.ForeColor = System.Drawing.Color.Black;
            this.Btn2.Location = new System.Drawing.Point(92, 441);
            this.Btn2.Margin = new System.Windows.Forms.Padding(0);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(80, 55);
            this.Btn2.TabIndex = 29;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn3
            // 
            this.Btn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn3.BackColor = System.Drawing.Color.DarkGray;
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn3.ForeColor = System.Drawing.Color.Black;
            this.Btn3.Location = new System.Drawing.Point(178, 441);
            this.Btn3.Margin = new System.Windows.Forms.Padding(0);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(80, 55);
            this.Btn3.TabIndex = 30;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEquals.BackColor = System.Drawing.Color.Chocolate;
            this.BtnEquals.FlatAppearance.BorderSize = 0;
            this.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquals.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnEquals.ForeColor = System.Drawing.Color.Black;
            this.BtnEquals.Location = new System.Drawing.Point(264, 497);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(80, 55);
            this.BtnEquals.TabIndex = 35;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // BtnPM
            // 
            this.BtnPM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPM.BackColor = System.Drawing.Color.DarkGray;
            this.BtnPM.FlatAppearance.BorderSize = 0;
            this.BtnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPM.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.BtnPM.ForeColor = System.Drawing.Color.Black;
            this.BtnPM.Location = new System.Drawing.Point(6, 497);
            this.BtnPM.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(80, 55);
            this.BtnPM.TabIndex = 32;
            this.BtnPM.Text = "±";
            this.BtnPM.UseVisualStyleBackColor = false;
            this.BtnPM.Click += new System.EventHandler(this.BtnPlMn_Click);
            // 
            // Btn0
            // 
            this.Btn0.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn0.BackColor = System.Drawing.Color.DarkGray;
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn0.ForeColor = System.Drawing.Color.Black;
            this.Btn0.Location = new System.Drawing.Point(92, 497);
            this.Btn0.Margin = new System.Windows.Forms.Padding(0);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(80, 55);
            this.Btn0.TabIndex = 33;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnDesimal
            // 
            this.BtnDesimal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnDesimal.BackColor = System.Drawing.Color.DarkGray;
            this.BtnDesimal.FlatAppearance.BorderSize = 0;
            this.BtnDesimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesimal.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.BtnDesimal.ForeColor = System.Drawing.Color.Black;
            this.BtnDesimal.Location = new System.Drawing.Point(178, 497);
            this.BtnDesimal.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDesimal.Name = "BtnDesimal";
            this.BtnDesimal.Size = new System.Drawing.Size(80, 55);
            this.BtnDesimal.TabIndex = 34;
            this.BtnDesimal.Text = ",";
            this.BtnDesimal.UseVisualStyleBackColor = false;
            this.BtnDesimal.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Location = new System.Drawing.Point(264, 441);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(80, 55);
            this.BtnAdd.TabIndex = 31;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Mindicate
            // 
            this.Mindicate.AutoSize = true;
            this.Mindicate.Font = new System.Drawing.Font("Gadugi", 17F);
            this.Mindicate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Mindicate.Location = new System.Drawing.Point(12, 128);
            this.Mindicate.Name = "Mindicate";
            this.Mindicate.Size = new System.Drawing.Size(33, 27);
            this.Mindicate.TabIndex = 36;
            this.Mindicate.Text = "M";
            this.Help.SetToolTip(this.Mindicate, "В памяти есть число");
            this.Mindicate.Visible = false;
            // 
            // Autor
            // 
            this.Autor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Autor.BackColor = System.Drawing.Color.PowderBlue;
            this.Autor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Autor.Font = new System.Drawing.Font("Gadugi", 7.5F);
            this.Autor.ForeColor = System.Drawing.Color.White;
            this.Autor.Location = new System.Drawing.Point(200, 555);
            this.Autor.Margin = new System.Windows.Forms.Padding(0);
            this.Autor.Multiline = true;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Size = new System.Drawing.Size(150, 15);
            this.Autor.TabIndex = 37;
            this.Autor.Text = "veronika-nika1504@yandex.ru";
            this.Autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Help
            // 
            this.Help.AutoPopDelay = 5000;
            this.Help.InitialDelay = 500;
            this.Help.ReshowDelay = 50;
            this.Help.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Help.ToolTipTitle = "Подсказка";
            // 
            // PanelMenu
            // 
            this.PanelMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.PanelMenu.Controls.Add(this.CalcMenuView);
            this.PanelMenu.Controls.Add(this.separatorM1);
            this.PanelMenu.Controls.Add(this.NormalView);
            this.PanelMenu.Controls.Add(this.EngineeringView);
            this.PanelMenu.Controls.Add(this.separatorM2);
            this.PanelMenu.Controls.Add(this.UnitConverterView);
            this.PanelMenu.Controls.Add(this.FuelConsumptionView);
            this.PanelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelMenu.ForeColor = System.Drawing.Color.DarkViolet;
            this.PanelMenu.Location = new System.Drawing.Point(14, 75);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(154, 175);
            this.PanelMenu.TabIndex = 7;
            this.PanelMenu.Visible = false;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // CalcMenuView
            // 
            this.CalcMenuView.Font = new System.Drawing.Font("Gadugi", 13F);
            this.CalcMenuView.Location = new System.Drawing.Point(6, 3);
            this.CalcMenuView.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.CalcMenuView.Name = "CalcMenuView";
            this.CalcMenuView.Size = new System.Drawing.Size(145, 25);
            this.CalcMenuView.TabIndex = 0;
            this.CalcMenuView.Text = "Вид калькулятора";
            this.CalcMenuView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separatorM1
            // 
            this.separatorM1.BackColor = System.Drawing.Color.White;
            this.separatorM1.Font = new System.Drawing.Font("Gadugi", 13F);
            this.separatorM1.ForeColor = System.Drawing.Color.White;
            this.separatorM1.Location = new System.Drawing.Point(12, 38);
            this.separatorM1.Margin = new System.Windows.Forms.Padding(12, 7, 3, 5);
            this.separatorM1.Name = "separatorM1";
            this.separatorM1.Size = new System.Drawing.Size(130, 1);
            this.separatorM1.TabIndex = 704;
            this.separatorM1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NormalView
            // 
            this.NormalView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NormalView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(214)))));
            this.NormalView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalView.Location = new System.Drawing.Point(7, 44);
            this.NormalView.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.NormalView.Name = "NormalView";
            this.NormalView.Size = new System.Drawing.Size(144, 30);
            this.NormalView.TabIndex = 705;
            this.NormalView.Text = "Обычный";
            this.NormalView.UseVisualStyleBackColor = false;
            this.NormalView.Click += new System.EventHandler(this.CalculatorTypes_Click);
            // 
            // EngineeringView
            // 
            this.EngineeringView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EngineeringView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(214)))));
            this.EngineeringView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EngineeringView.Location = new System.Drawing.Point(7, 74);
            this.EngineeringView.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.EngineeringView.Name = "EngineeringView";
            this.EngineeringView.Size = new System.Drawing.Size(144, 30);
            this.EngineeringView.TabIndex = 706;
            this.EngineeringView.Text = "Инженерный";
            this.EngineeringView.UseVisualStyleBackColor = false;
            this.EngineeringView.Click += new System.EventHandler(this.CalculatorTypes_Click);
            // 
            // separatorM2
            // 
            this.separatorM2.BackColor = System.Drawing.Color.White;
            this.separatorM2.Font = new System.Drawing.Font("Gadugi", 13F);
            this.separatorM2.ForeColor = System.Drawing.Color.White;
            this.separatorM2.Location = new System.Drawing.Point(12, 107);
            this.separatorM2.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.separatorM2.Name = "separatorM2";
            this.separatorM2.Size = new System.Drawing.Size(130, 1);
            this.separatorM2.TabIndex = 708;
            this.separatorM2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitConverterView
            // 
            this.UnitConverterView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnitConverterView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(214)))));
            this.UnitConverterView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnitConverterView.Location = new System.Drawing.Point(7, 111);
            this.UnitConverterView.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.UnitConverterView.Name = "UnitConverterView";
            this.UnitConverterView.Size = new System.Drawing.Size(144, 30);
            this.UnitConverterView.TabIndex = 709;
            this.UnitConverterView.Text = "Конвертер величин";
            this.UnitConverterView.UseVisualStyleBackColor = false;
            this.UnitConverterView.Click += new System.EventHandler(this.CalculatorTypes_Click);
            // 
            // FuelConsumptionView
            // 
            this.FuelConsumptionView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FuelConsumptionView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(214)))));
            this.FuelConsumptionView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FuelConsumptionView.Location = new System.Drawing.Point(7, 141);
            this.FuelConsumptionView.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.FuelConsumptionView.Name = "FuelConsumptionView";
            this.FuelConsumptionView.Size = new System.Drawing.Size(144, 30);
            this.FuelConsumptionView.TabIndex = 710;
            this.FuelConsumptionView.Text = "Расход топлива";
            this.FuelConsumptionView.UseVisualStyleBackColor = false;
            this.FuelConsumptionView.Click += new System.EventHandler(this.CalculatorTypes_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(350, 570);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Mindicate);
            this.Controls.Add(this.PnlHistory);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDesimal);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.BtnPM);
            this.Controls.Add(this.BtnX2);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.Btn1X);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.BtnSubstraction);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.BtnMC);
            this.Controls.Add(this.BtnMR);
            this.Controls.Add(this.BtnMplus);
            this.Controls.Add(this.BtnMminus);
            this.Controls.Add(this.BtnMS);
            this.Controls.Add(this.BtnBackSpace);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.TxtEstimation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalc";
            this.Load += new System.EventHandler(this.FormCalc_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KBPress);
            this.PnlTitle.ResumeLayout(false);
            this.PnlHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Button BtnTransform;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PnlHistory;
        private System.Windows.Forms.Button BtnRoll;
        private System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
        private System.Windows.Forms.Button BtnClearHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.TextBox TxtEstimation;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnBackSpace;
        private System.Windows.Forms.Button BtnMS;
        private System.Windows.Forms.Button BtnMminus;
        private System.Windows.Forms.Button BtnMplus;
        private System.Windows.Forms.Button BtnMC;
        private System.Windows.Forms.Button BtnMR;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.Button BtnX2;
        private System.Windows.Forms.Button Btn1X;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnSubstraction;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button BtnPM;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnDesimal;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label Mindicate;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.ToolTip Help;
        private System.Windows.Forms.Label CalcMenuView;
        private System.Windows.Forms.FlowLayoutPanel PanelMenu;
        private System.Windows.Forms.Label separatorM1;
        private System.Windows.Forms.Button NormalView;
        private System.Windows.Forms.Button EngineeringView;
        private System.Windows.Forms.Label separatorM2;
        private System.Windows.Forms.Button UnitConverterView;
        private System.Windows.Forms.Button FuelConsumptionView;
    }
}

