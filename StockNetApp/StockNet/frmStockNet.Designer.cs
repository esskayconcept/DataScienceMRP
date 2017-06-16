namespace StockNet
{
    partial class frmStockNet
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
            this.components = new System.ComponentModel.Container();
            this.txtDataPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDataPath = new System.Windows.Forms.Button();
            this.cmdPathRefresh = new System.Windows.Forms.Button();
            this.toolTipStockNet = new System.Windows.Forms.ToolTip(this.components);
            this.pnlPriceCanvas = new System.Windows.Forms.Panel();
            this.pnlAggreagtor = new System.Windows.Forms.Panel();
            this.pnlOscilatorCanvas = new System.Windows.Forms.Panel();
            this.pnlTimeLine = new System.Windows.Forms.Panel();
            this.tabControlStockNet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nbrMAPeriod = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chkWMA = new System.Windows.Forms.CheckBox();
            this.chkLR = new System.Windows.Forms.CheckBox();
            this.chkMA = new System.Windows.Forms.CheckBox();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.nbrReturnPeriod = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.chkLS = new System.Windows.Forms.CheckBox();
            this.chkReturn = new System.Windows.Forms.CheckBox();
            this.cmdRefershReturn = new System.Windows.Forms.Button();
            this.chkMaxDailyReturn = new System.Windows.Forms.CheckBox();
            this.chkDailyReturn = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlParameters = new System.Windows.Forms.Panel();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMaxEndDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdFilterRefresh = new System.Windows.Forms.Button();
            this.lblMinStartDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dbgrdData = new System.Windows.Forms.DataGridView();
            this.prgbar = new System.Windows.Forms.ProgressBar();
            this.lvwStocks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlDegree = new System.Windows.Forms.Panel();
            this.cmdShowAllPath = new System.Windows.Forms.Button();
            this.nbrApproximateExponent = new System.Windows.Forms.NumericUpDown();
            this.pnlGraphProperties = new System.Windows.Forms.Panel();
            this.lblRadius = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblDensity = new System.Windows.Forms.Label();
            this.lblPossibleEdges = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblIsAllConnected = new System.Windows.Forms.Label();
            this.lblNoOfEdges = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNoOfNodes = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdShowPath = new System.Windows.Forms.Button();
            this.pnlDegreeDistribution = new System.Windows.Forms.Panel();
            this.lvwNodes = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpMapType = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nbrThreshhold = new System.Windows.Forms.NumericUpDown();
            this.optShowAdjacencyMatrix = new System.Windows.Forms.RadioButton();
            this.optShowHeatMap = new System.Windows.Forms.RadioButton();
            this.chkShowCorrelation = new System.Windows.Forms.CheckBox();
            this.prgbarCorreation = new System.Windows.Forms.ProgressBar();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblCorrelation = new System.Windows.Forms.Label();
            this.cboTargetNode = new System.Windows.Forms.ComboBox();
            this.cboSourceNode = new System.Windows.Forms.ComboBox();
            this.cboCorrelationAttribute = new System.Windows.Forms.ComboBox();
            this.pnlHeatmap = new System.Windows.Forms.Panel();
            this.cmdRefreshNode = new System.Windows.Forms.Button();
            this.cmdExportResult = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.cmdCorrelation = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlStockNet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrMAPeriod)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrReturnPeriod)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrApproximateExponent)).BeginInit();
            this.pnlGraphProperties.SuspendLayout();
            this.grpMapType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrThreshhold)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDataPath
            // 
            this.txtDataPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataPath.Location = new System.Drawing.Point(79, 6);
            this.txtDataPath.Name = "txtDataPath";
            this.txtDataPath.Size = new System.Drawing.Size(224, 20);
            this.txtDataPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Path :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdDataPath
            // 
            this.cmdDataPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDataPath.Location = new System.Drawing.Point(309, 5);
            this.cmdDataPath.Name = "cmdDataPath";
            this.cmdDataPath.Size = new System.Drawing.Size(44, 23);
            this.cmdDataPath.TabIndex = 2;
            this.cmdDataPath.Text = "...";
            this.cmdDataPath.UseVisualStyleBackColor = true;
            this.cmdDataPath.Click += new System.EventHandler(this.cmdDataPath_Click);
            // 
            // cmdPathRefresh
            // 
            this.cmdPathRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPathRefresh.Location = new System.Drawing.Point(359, 5);
            this.cmdPathRefresh.Name = "cmdPathRefresh";
            this.cmdPathRefresh.Size = new System.Drawing.Size(88, 23);
            this.cmdPathRefresh.TabIndex = 2;
            this.cmdPathRefresh.Text = "Load Data";
            this.cmdPathRefresh.UseVisualStyleBackColor = true;
            this.cmdPathRefresh.Click += new System.EventHandler(this.cmdPathRefresh_Click);
            // 
            // pnlPriceCanvas
            // 
            this.pnlPriceCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPriceCanvas.Location = new System.Drawing.Point(0, 37);
            this.pnlPriceCanvas.Name = "pnlPriceCanvas";
            this.pnlPriceCanvas.Size = new System.Drawing.Size(1316, 117);
            this.pnlPriceCanvas.TabIndex = 1;
            this.toolTipStockNet.SetToolTip(this.pnlPriceCanvas, "Price Chart");
            this.pnlPriceCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPriceCanvas_Paint);
            this.pnlPriceCanvas.Resize += new System.EventHandler(this.pnlPriceCanvas_Resize);
            // 
            // pnlAggreagtor
            // 
            this.pnlAggreagtor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAggreagtor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAggreagtor.Location = new System.Drawing.Point(0, 159);
            this.pnlAggreagtor.Name = "pnlAggreagtor";
            this.pnlAggreagtor.Size = new System.Drawing.Size(1318, 181);
            this.pnlAggreagtor.TabIndex = 3;
            this.toolTipStockNet.SetToolTip(this.pnlAggreagtor, "Accumulation / Distribution Line (Money Fow Line)");
            this.pnlAggreagtor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAggreagtor_Paint);
            this.pnlAggreagtor.Resize += new System.EventHandler(this.pnlAggreagtor_Resize);
            // 
            // pnlOscilatorCanvas
            // 
            this.pnlOscilatorCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOscilatorCanvas.Location = new System.Drawing.Point(0, 37);
            this.pnlOscilatorCanvas.Name = "pnlOscilatorCanvas";
            this.pnlOscilatorCanvas.Size = new System.Drawing.Size(1316, 284);
            this.pnlOscilatorCanvas.TabIndex = 2;
            this.toolTipStockNet.SetToolTip(this.pnlOscilatorCanvas, "Returns");
            this.pnlOscilatorCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOscilatorCanvas_Paint);
            // 
            // pnlTimeLine
            // 
            this.pnlTimeLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTimeLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTimeLine.Location = new System.Drawing.Point(0, 666);
            this.pnlTimeLine.Name = "pnlTimeLine";
            this.pnlTimeLine.Size = new System.Drawing.Size(1318, 104);
            this.pnlTimeLine.TabIndex = 0;
            this.toolTipStockNet.SetToolTip(this.pnlTimeLine, "Volume");
            this.pnlTimeLine.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTimeLine_Paint);
            this.pnlTimeLine.Resize += new System.EventHandler(this.pnlTimeLine_Resize);
            // 
            // tabControlStockNet
            // 
            this.tabControlStockNet.Controls.Add(this.tabPage1);
            this.tabControlStockNet.Controls.Add(this.tabPage2);
            this.tabControlStockNet.Controls.Add(this.tabPage3);
            this.tabControlStockNet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStockNet.Location = new System.Drawing.Point(0, 0);
            this.tabControlStockNet.Name = "tabControlStockNet";
            this.tabControlStockNet.SelectedIndex = 0;
            this.tabControlStockNet.Size = new System.Drawing.Size(1799, 802);
            this.tabControlStockNet.TabIndex = 3;
            this.tabControlStockNet.SelectedIndexChanged += new System.EventHandler(this.tabControlStockNet_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.splitter1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1791, 776);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.splitter3);
            this.panel2.Controls.Add(this.pnlAggreagtor);
            this.panel2.Controls.Add(this.splitter2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pnlTimeLine);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(470, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1318, 770);
            this.panel2.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pnlPriceCanvas);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1318, 156);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.nbrMAPeriod);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.chkWMA);
            this.panel6.Controls.Add(this.chkLR);
            this.panel6.Controls.Add(this.chkMA);
            this.panel6.Controls.Add(this.cmdRefresh);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1316, 37);
            this.panel6.TabIndex = 0;
            // 
            // nbrMAPeriod
            // 
            this.nbrMAPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbrMAPeriod.Location = new System.Drawing.Point(1177, 8);
            this.nbrMAPeriod.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nbrMAPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbrMAPeriod.Name = "nbrMAPeriod";
            this.nbrMAPeriod.Size = new System.Drawing.Size(69, 20);
            this.nbrMAPeriod.TabIndex = 2;
            this.nbrMAPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbrMAPeriod.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1128, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Period :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkWMA
            // 
            this.chkWMA.AutoSize = true;
            this.chkWMA.ForeColor = System.Drawing.Color.Green;
            this.chkWMA.Location = new System.Drawing.Point(145, 10);
            this.chkWMA.Name = "chkWMA";
            this.chkWMA.Size = new System.Drawing.Size(153, 17);
            this.chkWMA.TabIndex = 0;
            this.chkWMA.Text = "Weigthed Moving Average";
            this.chkWMA.UseVisualStyleBackColor = true;
            // 
            // chkLR
            // 
            this.chkLR.AutoSize = true;
            this.chkLR.ForeColor = System.Drawing.Color.Red;
            this.chkLR.Location = new System.Drawing.Point(321, 10);
            this.chkLR.Name = "chkLR";
            this.chkLR.Size = new System.Drawing.Size(150, 17);
            this.chkLR.TabIndex = 0;
            this.chkLR.Text = "Moving LInear Regression";
            this.chkLR.UseVisualStyleBackColor = true;
            // 
            // chkMA
            // 
            this.chkMA.AutoSize = true;
            this.chkMA.ForeColor = System.Drawing.Color.Blue;
            this.chkMA.Location = new System.Drawing.Point(17, 9);
            this.chkMA.Name = "chkMA";
            this.chkMA.Size = new System.Drawing.Size(104, 17);
            this.chkMA.TabIndex = 0;
            this.chkMA.Text = "Moving Average";
            this.chkMA.UseVisualStyleBackColor = true;
            this.chkMA.CheckedChanged += new System.EventHandler(this.chkMA_CheckedChanged);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRefresh.Location = new System.Drawing.Point(1252, 6);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(54, 23);
            this.cmdRefresh.TabIndex = 2;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(0, 156);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(1318, 3);
            this.splitter3.TabIndex = 4;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 340);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1318, 3);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pnlOscilatorCanvas);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1318, 323);
            this.panel3.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.checkBox1);
            this.panel7.Controls.Add(this.checkBox2);
            this.panel7.Controls.Add(this.checkBox3);
            this.panel7.Controls.Add(this.nbrReturnPeriod);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.chkLS);
            this.panel7.Controls.Add(this.chkReturn);
            this.panel7.Controls.Add(this.cmdRefershReturn);
            this.panel7.Controls.Add(this.chkMaxDailyReturn);
            this.panel7.Controls.Add(this.chkDailyReturn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1316, 37);
            this.panel7.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(858, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Weigthed Moving Average";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(1017, 10);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(150, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Moving LInear Regression";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.Color.Black;
            this.checkBox3.Location = new System.Drawing.Point(748, 9);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(104, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Moving Average";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // nbrReturnPeriod
            // 
            this.nbrReturnPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbrReturnPeriod.Location = new System.Drawing.Point(1177, 8);
            this.nbrReturnPeriod.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nbrReturnPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbrReturnPeriod.Name = "nbrReturnPeriod";
            this.nbrReturnPeriod.Size = new System.Drawing.Size(69, 20);
            this.nbrReturnPeriod.TabIndex = 2;
            this.nbrReturnPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbrReturnPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1128, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Period :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkLS
            // 
            this.chkLS.AutoSize = true;
            this.chkLS.ForeColor = System.Drawing.Color.Green;
            this.chkLS.Location = new System.Drawing.Point(322, 9);
            this.chkLS.Name = "chkLS";
            this.chkLS.Size = new System.Drawing.Size(141, 17);
            this.chkLS.TabIndex = 0;
            this.chkLS.Text = "Linear Regression Slope";
            this.chkLS.UseVisualStyleBackColor = true;
            // 
            // chkReturn
            // 
            this.chkReturn.AutoSize = true;
            this.chkReturn.ForeColor = System.Drawing.Color.Red;
            this.chkReturn.Location = new System.Drawing.Point(237, 9);
            this.chkReturn.Name = "chkReturn";
            this.chkReturn.Size = new System.Drawing.Size(69, 17);
            this.chkReturn.TabIndex = 0;
            this.chkReturn.Text = "% Return";
            this.chkReturn.UseVisualStyleBackColor = true;
            this.chkReturn.CheckedChanged += new System.EventHandler(this.chkReturn_CheckedChanged);
            // 
            // cmdRefershReturn
            // 
            this.cmdRefershReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRefershReturn.Location = new System.Drawing.Point(1252, 7);
            this.cmdRefershReturn.Name = "cmdRefershReturn";
            this.cmdRefershReturn.Size = new System.Drawing.Size(54, 23);
            this.cmdRefershReturn.TabIndex = 2;
            this.cmdRefershReturn.Text = "Refresh";
            this.cmdRefershReturn.UseVisualStyleBackColor = true;
            this.cmdRefershReturn.Click += new System.EventHandler(this.cmdRefershReturn_Click);
            // 
            // chkMaxDailyReturn
            // 
            this.chkMaxDailyReturn.AutoSize = true;
            this.chkMaxDailyReturn.ForeColor = System.Drawing.Color.Blue;
            this.chkMaxDailyReturn.Location = new System.Drawing.Point(113, 9);
            this.chkMaxDailyReturn.Name = "chkMaxDailyReturn";
            this.chkMaxDailyReturn.Size = new System.Drawing.Size(107, 17);
            this.chkMaxDailyReturn.TabIndex = 0;
            this.chkMaxDailyReturn.Text = "Daily Max Return";
            this.chkMaxDailyReturn.UseVisualStyleBackColor = true;
            this.chkMaxDailyReturn.CheckedChanged += new System.EventHandler(this.chkMaxDailyReturn_CheckedChanged);
            // 
            // chkDailyReturn
            // 
            this.chkDailyReturn.AutoSize = true;
            this.chkDailyReturn.Checked = true;
            this.chkDailyReturn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDailyReturn.Location = new System.Drawing.Point(17, 9);
            this.chkDailyReturn.Name = "chkDailyReturn";
            this.chkDailyReturn.Size = new System.Drawing.Size(84, 17);
            this.chkDailyReturn.TabIndex = 0;
            this.chkDailyReturn.Text = "Daily Return";
            this.chkDailyReturn.UseVisualStyleBackColor = true;
            this.chkDailyReturn.CheckedChanged += new System.EventHandler(this.chkDailyReturn_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(467, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 770);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlParameters);
            this.panel1.Controls.Add(this.cmdDataPath);
            this.panel1.Controls.Add(this.dbgrdData);
            this.panel1.Controls.Add(this.txtDataPath);
            this.panel1.Controls.Add(this.prgbar);
            this.panel1.Controls.Add(this.cmdPathRefresh);
            this.panel1.Controls.Add(this.lvwStocks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 770);
            this.panel1.TabIndex = 7;
            // 
            // pnlParameters
            // 
            this.pnlParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlParameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParameters.Controls.Add(this.dateTimePickerEndDate);
            this.pnlParameters.Controls.Add(this.dateTimePickerStartDate);
            this.pnlParameters.Controls.Add(this.label6);
            this.pnlParameters.Controls.Add(this.lblMaxEndDate);
            this.pnlParameters.Controls.Add(this.label3);
            this.pnlParameters.Controls.Add(this.label4);
            this.pnlParameters.Controls.Add(this.cmdFilterRefresh);
            this.pnlParameters.Controls.Add(this.lblMinStartDate);
            this.pnlParameters.Controls.Add(this.label2);
            this.pnlParameters.Location = new System.Drawing.Point(15, 666);
            this.pnlParameters.Name = "pnlParameters";
            this.pnlParameters.Size = new System.Drawing.Size(432, 100);
            this.pnlParameters.TabIndex = 6;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CustomFormat = " dd-MMM-yyyy";
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(81, 55);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(113, 20);
            this.dateTimePickerEndDate.TabIndex = 2;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CustomFormat = " dd-MMM-yyyy";
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(81, 21);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(113, 20);
            this.dateTimePickerStartDate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Maximum";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaxEndDate
            // 
            this.lblMaxEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaxEndDate.Location = new System.Drawing.Point(264, 56);
            this.lblMaxEndDate.Name = "lblMaxEndDate";
            this.lblMaxEndDate.Size = new System.Drawing.Size(84, 19);
            this.lblMaxEndDate.TabIndex = 1;
            this.lblMaxEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Minimum";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "End Date :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdFilterRefresh
            // 
            this.cmdFilterRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFilterRefresh.Location = new System.Drawing.Point(366, 21);
            this.cmdFilterRefresh.Name = "cmdFilterRefresh";
            this.cmdFilterRefresh.Size = new System.Drawing.Size(49, 56);
            this.cmdFilterRefresh.TabIndex = 2;
            this.cmdFilterRefresh.Text = "Apply";
            this.cmdFilterRefresh.UseVisualStyleBackColor = true;
            this.cmdFilterRefresh.Click += new System.EventHandler(this.cmdPathRefresh_Click);
            // 
            // lblMinStartDate
            // 
            this.lblMinStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinStartDate.Location = new System.Drawing.Point(264, 23);
            this.lblMinStartDate.Name = "lblMinStartDate";
            this.lblMinStartDate.Size = new System.Drawing.Size(84, 19);
            this.lblMinStartDate.TabIndex = 1;
            this.lblMinStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dbgrdData
            // 
            this.dbgrdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbgrdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdData.Location = new System.Drawing.Point(15, 287);
            this.dbgrdData.Name = "dbgrdData";
            this.dbgrdData.Size = new System.Drawing.Size(432, 363);
            this.dbgrdData.TabIndex = 5;
            // 
            // prgbar
            // 
            this.prgbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgbar.Location = new System.Drawing.Point(15, 258);
            this.prgbar.Name = "prgbar";
            this.prgbar.Size = new System.Drawing.Size(432, 23);
            this.prgbar.TabIndex = 4;
            this.prgbar.Visible = false;
            // 
            // lvwStocks
            // 
            this.lvwStocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwStocks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvwStocks.FullRowSelect = true;
            this.lvwStocks.GridLines = true;
            this.lvwStocks.Location = new System.Drawing.Point(15, 38);
            this.lvwStocks.Name = "lvwStocks";
            this.lvwStocks.Size = new System.Drawing.Size(432, 214);
            this.lvwStocks.TabIndex = 3;
            this.lvwStocks.UseCompatibleStateImageBehavior = false;
            this.lvwStocks.View = System.Windows.Forms.View.Details;
            this.lvwStocks.SelectedIndexChanged += new System.EventHandler(this.lvwStocks_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ticker";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 67;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Exchange";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 74;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Start";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 84;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "End";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 81;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlDegree);
            this.tabPage2.Controls.Add(this.cmdShowAllPath);
            this.tabPage2.Controls.Add(this.nbrApproximateExponent);
            this.tabPage2.Controls.Add(this.pnlGraphProperties);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cmdShowPath);
            this.tabPage2.Controls.Add(this.pnlDegreeDistribution);
            this.tabPage2.Controls.Add(this.lvwNodes);
            this.tabPage2.Controls.Add(this.grpMapType);
            this.tabPage2.Controls.Add(this.chkShowCorrelation);
            this.tabPage2.Controls.Add(this.prgbarCorreation);
            this.tabPage2.Controls.Add(this.lblPath);
            this.tabPage2.Controls.Add(this.lblCorrelation);
            this.tabPage2.Controls.Add(this.cboTargetNode);
            this.tabPage2.Controls.Add(this.cboSourceNode);
            this.tabPage2.Controls.Add(this.cboCorrelationAttribute);
            this.tabPage2.Controls.Add(this.pnlHeatmap);
            this.tabPage2.Controls.Add(this.cmdRefreshNode);
            this.tabPage2.Controls.Add(this.cmdExportResult);
            this.tabPage2.Controls.Add(this.cmdSave);
            this.tabPage2.Controls.Add(this.cmdLoad);
            this.tabPage2.Controls.Add(this.cmdCorrelation);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1791, 776);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Relationship";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlDegree
            // 
            this.pnlDegree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDegree.Location = new System.Drawing.Point(1121, 529);
            this.pnlDegree.Name = "pnlDegree";
            this.pnlDegree.Size = new System.Drawing.Size(659, 227);
            this.pnlDegree.TabIndex = 13;
            this.pnlDegree.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDegree_Paint);
            // 
            // cmdShowAllPath
            // 
            this.cmdShowAllPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdShowAllPath.Location = new System.Drawing.Point(1705, 445);
            this.cmdShowAllPath.Name = "cmdShowAllPath";
            this.cmdShowAllPath.Size = new System.Drawing.Size(75, 23);
            this.cmdShowAllPath.TabIndex = 12;
            this.cmdShowAllPath.Text = "Show All Paths";
            this.cmdShowAllPath.UseVisualStyleBackColor = true;
            this.cmdShowAllPath.Click += new System.EventHandler(this.cmdShowAllPath_Click);
            // 
            // nbrApproximateExponent
            // 
            this.nbrApproximateExponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbrApproximateExponent.DecimalPlaces = 2;
            this.nbrApproximateExponent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nbrApproximateExponent.Location = new System.Drawing.Point(1567, 114);
            this.nbrApproximateExponent.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbrApproximateExponent.Name = "nbrApproximateExponent";
            this.nbrApproximateExponent.Size = new System.Drawing.Size(46, 20);
            this.nbrApproximateExponent.TabIndex = 8;
            this.nbrApproximateExponent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbrApproximateExponent.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.nbrApproximateExponent.ValueChanged += new System.EventHandler(this.nbrThreshhold_ValueChanged);
            // 
            // pnlGraphProperties
            // 
            this.pnlGraphProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphProperties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraphProperties.Controls.Add(this.lblRadius);
            this.pnlGraphProperties.Controls.Add(this.label23);
            this.pnlGraphProperties.Controls.Add(this.lblDiameter);
            this.pnlGraphProperties.Controls.Add(this.lblDensity);
            this.pnlGraphProperties.Controls.Add(this.lblPossibleEdges);
            this.pnlGraphProperties.Controls.Add(this.label18);
            this.pnlGraphProperties.Controls.Add(this.lblIsAllConnected);
            this.pnlGraphProperties.Controls.Add(this.lblNoOfEdges);
            this.pnlGraphProperties.Controls.Add(this.label16);
            this.pnlGraphProperties.Controls.Add(this.label20);
            this.pnlGraphProperties.Controls.Add(this.label14);
            this.pnlGraphProperties.Controls.Add(this.label12);
            this.pnlGraphProperties.Controls.Add(this.lblNoOfNodes);
            this.pnlGraphProperties.Controls.Add(this.label11);
            this.pnlGraphProperties.Location = new System.Drawing.Point(862, 447);
            this.pnlGraphProperties.Name = "pnlGraphProperties";
            this.pnlGraphProperties.Size = new System.Drawing.Size(218, 323);
            this.pnlGraphProperties.TabIndex = 11;
            // 
            // lblRadius
            // 
            this.lblRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRadius.Location = new System.Drawing.Point(116, 208);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(88, 21);
            this.lblRadius.TabIndex = 9;
            this.lblRadius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 211);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Radius * :";
            // 
            // lblDiameter
            // 
            this.lblDiameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiameter.Location = new System.Drawing.Point(117, 175);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(88, 21);
            this.lblDiameter.TabIndex = 8;
            this.lblDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDensity
            // 
            this.lblDensity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDensity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDensity.Location = new System.Drawing.Point(117, 143);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(88, 21);
            this.lblDensity.TabIndex = 8;
            this.lblDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPossibleEdges
            // 
            this.lblPossibleEdges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPossibleEdges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPossibleEdges.Location = new System.Drawing.Point(117, 109);
            this.lblPossibleEdges.Name = "lblPossibleEdges";
            this.lblPossibleEdges.Size = new System.Drawing.Size(88, 21);
            this.lblPossibleEdges.TabIndex = 8;
            this.lblPossibleEdges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Diameter * :";
            // 
            // lblIsAllConnected
            // 
            this.lblIsAllConnected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIsAllConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIsAllConnected.Location = new System.Drawing.Point(117, 43);
            this.lblIsAllConnected.Name = "lblIsAllConnected";
            this.lblIsAllConnected.Size = new System.Drawing.Size(88, 21);
            this.lblIsAllConnected.TabIndex = 8;
            this.lblIsAllConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoOfEdges
            // 
            this.lblNoOfEdges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoOfEdges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNoOfEdges.Location = new System.Drawing.Point(117, 77);
            this.lblNoOfEdges.Name = "lblNoOfEdges";
            this.lblNoOfEdges.Size = new System.Drawing.Size(88, 21);
            this.lblNoOfEdges.TabIndex = 8;
            this.lblNoOfEdges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Density :";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "All Connected ?";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Possible Edges :";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "No. of Edges :";
            // 
            // lblNoOfNodes
            // 
            this.lblNoOfNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoOfNodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNoOfNodes.Location = new System.Drawing.Point(117, 12);
            this.lblNoOfNodes.Name = "lblNoOfNodes";
            this.lblNoOfNodes.Size = new System.Drawing.Size(88, 21);
            this.lblNoOfNodes.TabIndex = 8;
            this.lblNoOfNodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "No. of Nodes :";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1442, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Approximate Exponent :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1329, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Target  Node :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1118, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Source  Node :";
            // 
            // cmdShowPath
            // 
            this.cmdShowPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdShowPath.Location = new System.Drawing.Point(1525, 445);
            this.cmdShowPath.Name = "cmdShowPath";
            this.cmdShowPath.Size = new System.Drawing.Size(75, 23);
            this.cmdShowPath.TabIndex = 10;
            this.cmdShowPath.Text = "Show Path";
            this.cmdShowPath.UseVisualStyleBackColor = true;
            this.cmdShowPath.Click += new System.EventHandler(this.cmdShowPath_Click);
            // 
            // pnlDegreeDistribution
            // 
            this.pnlDegreeDistribution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDegreeDistribution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDegreeDistribution.Location = new System.Drawing.Point(1460, 164);
            this.pnlDegreeDistribution.Name = "pnlDegreeDistribution";
            this.pnlDegreeDistribution.Size = new System.Drawing.Size(320, 265);
            this.pnlDegreeDistribution.TabIndex = 9;
            this.pnlDegreeDistribution.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDegreeDistribution_Paint);
            // 
            // lvwNodes
            // 
            this.lvwNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwNodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader10,
            this.columnHeader11});
            this.lvwNodes.FullRowSelect = true;
            this.lvwNodes.GridLines = true;
            this.lvwNodes.Location = new System.Drawing.Point(862, 164);
            this.lvwNodes.Name = "lvwNodes";
            this.lvwNodes.Size = new System.Drawing.Size(578, 265);
            this.lvwNodes.TabIndex = 8;
            this.lvwNodes.UseCompatibleStateImageBehavior = false;
            this.lvwNodes.View = System.Windows.Forms.View.Details;
            this.lvwNodes.SelectedIndexChanged += new System.EventHandler(this.lvwNodes_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "No.";
            this.columnHeader2.Width = 30;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ticker";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 67;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Exchange";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 74;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Degree";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 84;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Eccentricity";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 81;
            // 
            // grpMapType
            // 
            this.grpMapType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMapType.Controls.Add(this.label8);
            this.grpMapType.Controls.Add(this.nbrThreshhold);
            this.grpMapType.Controls.Add(this.optShowAdjacencyMatrix);
            this.grpMapType.Controls.Add(this.optShowHeatMap);
            this.grpMapType.Location = new System.Drawing.Point(1010, 97);
            this.grpMapType.Name = "grpMapType";
            this.grpMapType.Size = new System.Drawing.Size(408, 49);
            this.grpMapType.TabIndex = 7;
            this.grpMapType.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Threshhold :";
            // 
            // nbrThreshhold
            // 
            this.nbrThreshhold.DecimalPlaces = 2;
            this.nbrThreshhold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nbrThreshhold.Location = new System.Drawing.Point(355, 18);
            this.nbrThreshhold.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbrThreshhold.Name = "nbrThreshhold";
            this.nbrThreshhold.Size = new System.Drawing.Size(46, 20);
            this.nbrThreshhold.TabIndex = 8;
            this.nbrThreshhold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbrThreshhold.ValueChanged += new System.EventHandler(this.nbrThreshhold_ValueChanged);
            // 
            // optShowAdjacencyMatrix
            // 
            this.optShowAdjacencyMatrix.AutoSize = true;
            this.optShowAdjacencyMatrix.Location = new System.Drawing.Point(133, 19);
            this.optShowAdjacencyMatrix.Name = "optShowAdjacencyMatrix";
            this.optShowAdjacencyMatrix.Size = new System.Drawing.Size(136, 17);
            this.optShowAdjacencyMatrix.TabIndex = 0;
            this.optShowAdjacencyMatrix.Text = "Show Adjacency Matrix";
            this.optShowAdjacencyMatrix.UseVisualStyleBackColor = true;
            this.optShowAdjacencyMatrix.CheckedChanged += new System.EventHandler(this.optShowAdjacencyMatrix_CheckedChanged);
            // 
            // optShowHeatMap
            // 
            this.optShowHeatMap.AutoSize = true;
            this.optShowHeatMap.Checked = true;
            this.optShowHeatMap.Location = new System.Drawing.Point(17, 19);
            this.optShowHeatMap.Name = "optShowHeatMap";
            this.optShowHeatMap.Size = new System.Drawing.Size(98, 17);
            this.optShowHeatMap.TabIndex = 0;
            this.optShowHeatMap.TabStop = true;
            this.optShowHeatMap.Text = "Show Heatmap";
            this.optShowHeatMap.UseVisualStyleBackColor = true;
            this.optShowHeatMap.CheckedChanged += new System.EventHandler(this.optShowHeatMap_CheckedChanged);
            // 
            // chkShowCorrelation
            // 
            this.chkShowCorrelation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowCorrelation.AutoSize = true;
            this.chkShowCorrelation.Checked = true;
            this.chkShowCorrelation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowCorrelation.Location = new System.Drawing.Point(862, 114);
            this.chkShowCorrelation.Name = "chkShowCorrelation";
            this.chkShowCorrelation.Size = new System.Drawing.Size(142, 17);
            this.chkShowCorrelation.TabIndex = 6;
            this.chkShowCorrelation.Text = "Show Correlation Value :";
            this.chkShowCorrelation.UseVisualStyleBackColor = true;
            this.chkShowCorrelation.CheckedChanged += new System.EventHandler(this.chkShowCorrelation_CheckedChanged);
            // 
            // prgbarCorreation
            // 
            this.prgbarCorreation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prgbarCorreation.Location = new System.Drawing.Point(862, 60);
            this.prgbarCorreation.Name = "prgbarCorreation";
            this.prgbarCorreation.Size = new System.Drawing.Size(918, 23);
            this.prgbarCorreation.TabIndex = 5;
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(1121, 487);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(659, 21);
            this.lblPath.TabIndex = 3;
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrelation
            // 
            this.lblCorrelation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorrelation.AutoSize = true;
            this.lblCorrelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelation.Location = new System.Drawing.Point(859, 21);
            this.lblCorrelation.Name = "lblCorrelation";
            this.lblCorrelation.Size = new System.Drawing.Size(124, 16);
            this.lblCorrelation.TabIndex = 3;
            this.lblCorrelation.Text = "Correlation Attribute";
            // 
            // cboTargetNode
            // 
            this.cboTargetNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTargetNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTargetNode.FormattingEnabled = true;
            this.cboTargetNode.Location = new System.Drawing.Point(1411, 447);
            this.cboTargetNode.Name = "cboTargetNode";
            this.cboTargetNode.Size = new System.Drawing.Size(91, 21);
            this.cboTargetNode.TabIndex = 2;
            // 
            // cboSourceNode
            // 
            this.cboSourceNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSourceNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSourceNode.FormattingEnabled = true;
            this.cboSourceNode.Items.AddRange(new object[] {
            ""});
            this.cboSourceNode.Location = new System.Drawing.Point(1203, 447);
            this.cboSourceNode.Name = "cboSourceNode";
            this.cboSourceNode.Size = new System.Drawing.Size(91, 21);
            this.cboSourceNode.TabIndex = 2;
            // 
            // cboCorrelationAttribute
            // 
            this.cboCorrelationAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCorrelationAttribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCorrelationAttribute.FormattingEnabled = true;
            this.cboCorrelationAttribute.Items.AddRange(new object[] {
            "Return",
            "Daily Return",
            "Daily Max Return",
            "Linear Regression Slope",
            "Return Based on Moving Average",
            "Return Based on Weigted Moving Average",
            "Return Based on oving Linear Regression",
            "Linear Regression Slope Based on Moving Average",
            "Linear Regression Slope Based on Weigted Moving Average",
            "Linear Regression Slope Return Based on oving Linear Regression"});
            this.cboCorrelationAttribute.Location = new System.Drawing.Point(989, 20);
            this.cboCorrelationAttribute.Name = "cboCorrelationAttribute";
            this.cboCorrelationAttribute.Size = new System.Drawing.Size(259, 21);
            this.cboCorrelationAttribute.TabIndex = 2;
            // 
            // pnlHeatmap
            // 
            this.pnlHeatmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeatmap.Location = new System.Drawing.Point(8, 11);
            this.pnlHeatmap.Name = "pnlHeatmap";
            this.pnlHeatmap.Size = new System.Drawing.Size(817, 769);
            this.pnlHeatmap.TabIndex = 1;
            this.pnlHeatmap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeatmap_Paint);
            this.pnlHeatmap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeatmap_MouseUp);
            // 
            // cmdRefreshNode
            // 
            this.cmdRefreshNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRefreshNode.Location = new System.Drawing.Point(1710, 111);
            this.cmdRefreshNode.Name = "cmdRefreshNode";
            this.cmdRefreshNode.Size = new System.Drawing.Size(70, 26);
            this.cmdRefreshNode.TabIndex = 0;
            this.cmdRefreshNode.Text = "Refresh";
            this.cmdRefreshNode.UseVisualStyleBackColor = true;
            this.cmdRefreshNode.Click += new System.EventHandler(this.cmdRefreshNode_Click);
            // 
            // cmdExportResult
            // 
            this.cmdExportResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExportResult.Location = new System.Drawing.Point(1404, 16);
            this.cmdExportResult.Name = "cmdExportResult";
            this.cmdExportResult.Size = new System.Drawing.Size(176, 26);
            this.cmdExportResult.TabIndex = 0;
            this.cmdExportResult.Text = "Export Result";
            this.cmdExportResult.UseVisualStyleBackColor = true;
            this.cmdExportResult.Click += new System.EventHandler(this.cmdExportResult_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Location = new System.Drawing.Point(1586, 16);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(94, 26);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdLoad
            // 
            this.cmdLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdLoad.Location = new System.Drawing.Point(1686, 15);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(94, 26);
            this.cmdLoad.TabIndex = 0;
            this.cmdLoad.Text = "Load";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // cmdCorrelation
            // 
            this.cmdCorrelation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCorrelation.Location = new System.Drawing.Point(1254, 16);
            this.cmdCorrelation.Name = "cmdCorrelation";
            this.cmdCorrelation.Size = new System.Drawing.Size(137, 26);
            this.cmdCorrelation.TabIndex = 0;
            this.cmdCorrelation.Text = "Correlation Coeffefficient";
            this.cmdCorrelation.UseVisualStyleBackColor = true;
            this.cmdCorrelation.Click += new System.EventHandler(this.cmdCorrelation_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlGraph);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1791, 776);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Graph";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlGraph
            // 
            this.pnlGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraph.Location = new System.Drawing.Point(25, 36);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(1738, 714);
            this.pnlGraph.TabIndex = 0;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Closeness";
            // 
            // frmStockNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 802);
            this.Controls.Add(this.tabControlStockNet);
            this.Name = "frmStockNet";
            this.Text = "Stock Net";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStockNet_Load);
            this.Resize += new System.EventHandler(this.frmStockNet_Resize);
            this.tabControlStockNet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrMAPeriod)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrReturnPeriod)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlParameters.ResumeLayout(false);
            this.pnlParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrApproximateExponent)).EndInit();
            this.pnlGraphProperties.ResumeLayout(false);
            this.pnlGraphProperties.PerformLayout();
            this.grpMapType.ResumeLayout(false);
            this.grpMapType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrThreshhold)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDataPath;
        private System.Windows.Forms.Button cmdPathRefresh;
        private System.Windows.Forms.ToolTip toolTipStockNet;
        private System.Windows.Forms.TabControl tabControlStockNet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvwStocks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ProgressBar prgbar;
        private System.Windows.Forms.DataGridView dbgrdData;
        private System.Windows.Forms.Panel pnlParameters;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMinStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMaxEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel pnlAggreagtor;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlTimeLine;
        private System.Windows.Forms.Panel pnlPriceCanvas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nbrMAPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkMA;
        private System.Windows.Forms.CheckBox chkLR;
        private System.Windows.Forms.Panel pnlOscilatorCanvas;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown nbrReturnPeriod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkLS;
        private System.Windows.Forms.CheckBox chkReturn;
        private System.Windows.Forms.CheckBox chkDailyReturn;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.CheckBox chkMaxDailyReturn;
        private System.Windows.Forms.Button cmdFilterRefresh;
        private System.Windows.Forms.Button cmdRefershReturn;
        private System.Windows.Forms.CheckBox chkWMA;
        private System.Windows.Forms.Button cmdCorrelation;
        private System.Windows.Forms.Panel pnlHeatmap;
        private System.Windows.Forms.Label lblCorrelation;
        private System.Windows.Forms.ComboBox cboCorrelationAttribute;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ProgressBar prgbarCorreation;
        private System.Windows.Forms.CheckBox chkShowCorrelation;
        private System.Windows.Forms.GroupBox grpMapType;
        private System.Windows.Forms.RadioButton optShowAdjacencyMatrix;
        private System.Windows.Forms.RadioButton optShowHeatMap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nbrThreshhold;
        private System.Windows.Forms.ListView lvwNodes;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button cmdRefreshNode;
        private System.Windows.Forms.Panel pnlDegreeDistribution;
        private System.Windows.Forms.Button cmdShowPath;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboTargetNode;
        private System.Windows.Forms.ComboBox cboSourceNode;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Panel pnlGraphProperties;
        private System.Windows.Forms.Label lblNoOfNodes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblNoOfEdges;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPossibleEdges;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblIsAllConnected;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button cmdShowAllPath;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown nbrApproximateExponent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cmdExportResult;
        private System.Windows.Forms.Panel pnlDegree;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}

