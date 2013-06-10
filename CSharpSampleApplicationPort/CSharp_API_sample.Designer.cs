namespace CSharpSampleApplicationPort
{
    partial class dlgMainWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgMainWnd));
            this.cmdReqMarketDataType = new System.Windows.Forms.Button();
            this.cmdReqGlobalCancel = new System.Windows.Forms.Button();
            this.cmdCancelCalcOptionPrice = new System.Windows.Forms.Button();
            this.cmdCancelCalcImpliedVolatility = new System.Windows.Forms.Button();
            this.cmdCalcOptionPrice = new System.Windows.Forms.Button();
            this.cmdCalcImpliedVolatility = new System.Windows.Forms.Button();
            this.cmdWhatIf = new System.Windows.Forms.Button();
            this.cmdReqCurrentTime = new System.Windows.Forms.Button();
            this.cmdCancelRealTimeBars = new System.Windows.Forms.Button();
            this.cmdReqRealTimeBars = new System.Windows.Forms.Button();
            this.cmdCancelHistData = new System.Windows.Forms.Button();
            this.cmdScanner = new System.Windows.Forms.Button();
            this.cmdExerciseOptions = new System.Windows.Forms.Button();
            this.cmdReqHistoricalData = new System.Windows.Forms.Button();
            this.cmdFinancialAdvisor = new System.Windows.Forms.Button();
            this.cmdReqAccts = new System.Windows.Forms.Button();
            this.cmdReqAllOpenOrders = new System.Windows.Forms.Button();
            this.cmdReqAutoOpenOrders = new System.Windows.Forms.Button();
            this.cmdServerLogLevel = new System.Windows.Forms.Button();
            this.cmdReqNews = new System.Windows.Forms.Button();
            this.cmdReqAcctData = new System.Windows.Forms.Button();
            this.cmdReqExecutions = new System.Windows.Forms.Button();
            this.cmdReqIds = new System.Windows.Forms.Button();
            this.cmdClearForm = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdDisconnect = new System.Windows.Forms.Button();
            this.cmdReqMktData = new System.Windows.Forms.Button();
            this.cmdCancelMktData = new System.Windows.Forms.Button();
            this.cmdReqMktDepth = new System.Windows.Forms.Button();
            this.cmdCancelMktDepth = new System.Windows.Forms.Button();
            this.cmdPlaceOrder = new System.Windows.Forms.Button();
            this.cmdCancelOrder = new System.Windows.Forms.Button();
            this.cmdExtendedOrderAtribs = new System.Windows.Forms.Button();
            this.cmdReqContractData = new System.Windows.Forms.Button();
            this.cmdReqOpenOrders = new System.Windows.Forms.Button();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.lstErrors = new System.Windows.Forms.ListBox();
            this.lstServerResponses = new System.Windows.Forms.ListBox();
            this.lstMktData = new System.Windows.Forms.ListBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Tws1 = new AxTWSLib.AxTws();
            ((System.ComponentModel.ISupportInitialize)(this.Tws1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdReqMarketDataType
            // 
            this.cmdReqMarketDataType.Location = new System.Drawing.Point(544, 751);
            this.cmdReqMarketDataType.Name = "cmdReqMarketDataType";
            this.cmdReqMarketDataType.Size = new System.Drawing.Size(134, 21);
            this.cmdReqMarketDataType.TabIndex = 33;
            this.cmdReqMarketDataType.Text = "Req Mkt Data Type";
            this.cmdReqMarketDataType.UseVisualStyleBackColor = false;
            this.cmdReqMarketDataType.Click += new System.EventHandler(this.cmdReqMarketDataType_Click);
            // 
            // cmdReqGlobalCancel
            // 
            this.cmdReqGlobalCancel.Font = new System.Drawing.Font("Arial", 8F);
            this.cmdReqGlobalCancel.Location = new System.Drawing.Point(544, 726);
            this.cmdReqGlobalCancel.Name = "cmdReqGlobalCancel";
            this.cmdReqGlobalCancel.Size = new System.Drawing.Size(134, 21);
            this.cmdReqGlobalCancel.TabIndex = 32;
            this.cmdReqGlobalCancel.Text = "Global Cancel";
            this.cmdReqGlobalCancel.UseVisualStyleBackColor = false;
            this.cmdReqGlobalCancel.Click += new System.EventHandler(this.cmdReqGlobalCancel_Click);
            // 
            // cmdCancelCalcOptionPrice
            // 
            this.cmdCancelCalcOptionPrice.Font = new System.Drawing.Font("Arial", 8F);
            this.cmdCancelCalcOptionPrice.Location = new System.Drawing.Point(544, 318);
            this.cmdCancelCalcOptionPrice.Name = "cmdCancelCalcOptionPrice";
            this.cmdCancelCalcOptionPrice.Size = new System.Drawing.Size(134, 21);
            this.cmdCancelCalcOptionPrice.TabIndex = 15;
            this.cmdCancelCalcOptionPrice.Text = "Cancel Calc Opt Price";
            this.cmdCancelCalcOptionPrice.UseVisualStyleBackColor = false;
            this.cmdCancelCalcOptionPrice.Click += new System.EventHandler(this.cmdCancelCalcOptionPrice_Click);
            // 
            // cmdCancelCalcImpliedVolatility
            // 
            this.cmdCancelCalcImpliedVolatility.Font = new System.Drawing.Font("Arial", 8F);
            this.cmdCancelCalcImpliedVolatility.Location = new System.Drawing.Point(544, 270);
            this.cmdCancelCalcImpliedVolatility.Name = "cmdCancelCalcImpliedVolatility";
            this.cmdCancelCalcImpliedVolatility.Size = new System.Drawing.Size(134, 21);
            this.cmdCancelCalcImpliedVolatility.TabIndex = 13;
            this.cmdCancelCalcImpliedVolatility.Text = "Cancel Calc Impl Vol";
            this.cmdCancelCalcImpliedVolatility.UseVisualStyleBackColor = false;
            this.cmdCancelCalcImpliedVolatility.Click += new System.EventHandler(this.cmdCancelCalcImpliedVolatility_Click);
            // 
            // cmdCalcOptionPrice
            // 
            this.cmdCalcOptionPrice.Font = new System.Drawing.Font("Arial", 8F);
            this.cmdCalcOptionPrice.Location = new System.Drawing.Point(544, 294);
            this.cmdCalcOptionPrice.Name = "cmdCalcOptionPrice";
            this.cmdCalcOptionPrice.Size = new System.Drawing.Size(134, 21);
            this.cmdCalcOptionPrice.TabIndex = 14;
            this.cmdCalcOptionPrice.Text = "Calc Option Price";
            this.cmdCalcOptionPrice.UseVisualStyleBackColor = false;
            this.cmdCalcOptionPrice.Click += new System.EventHandler(this.cmdCalcOptionPrice_Click);
            // 
            // cmdCalcImpliedVolatility
            // 
            this.cmdCalcImpliedVolatility.Font = new System.Drawing.Font("Arial", 8F);
            this.cmdCalcImpliedVolatility.Location = new System.Drawing.Point(544, 246);
            this.cmdCalcImpliedVolatility.Name = "cmdCalcImpliedVolatility";
            this.cmdCalcImpliedVolatility.Size = new System.Drawing.Size(134, 21);
            this.cmdCalcImpliedVolatility.TabIndex = 12;
            this.cmdCalcImpliedVolatility.Text = "Calc Implied Volatility";
            this.cmdCalcImpliedVolatility.UseVisualStyleBackColor = false;
            this.cmdCalcImpliedVolatility.Click += new System.EventHandler(this.cmdCalcImpliedVolatility_Click);
            // 
            // cmdWhatIf
            // 
            this.cmdWhatIf.BackColor = System.Drawing.SystemColors.Control;
            this.cmdWhatIf.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdWhatIf.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWhatIf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdWhatIf.Location = new System.Drawing.Point(544, 342);
            this.cmdWhatIf.Name = "cmdWhatIf";
            this.cmdWhatIf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdWhatIf.Size = new System.Drawing.Size(134, 21);
            this.cmdWhatIf.TabIndex = 16;
            this.cmdWhatIf.Text = "What If...";
            this.cmdWhatIf.UseVisualStyleBackColor = false;
            this.cmdWhatIf.Click += new System.EventHandler(this.cmdWhatIf_Click);
            // 
            // cmdReqCurrentTime
            // 
            this.cmdReqCurrentTime.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqCurrentTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqCurrentTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqCurrentTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqCurrentTime.Location = new System.Drawing.Point(544, 198);
            this.cmdReqCurrentTime.Name = "cmdReqCurrentTime";
            this.cmdReqCurrentTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqCurrentTime.Size = new System.Drawing.Size(134, 21);
            this.cmdReqCurrentTime.TabIndex = 10;
            this.cmdReqCurrentTime.Text = "Current Time";
            this.cmdReqCurrentTime.UseVisualStyleBackColor = false;
            this.cmdReqCurrentTime.Click += new System.EventHandler(this.cmdReqCurrentTime_Click);
            // 
            // cmdCancelRealTimeBars
            // 
            this.cmdCancelRealTimeBars.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCancelRealTimeBars.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancelRealTimeBars.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelRealTimeBars.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCancelRealTimeBars.Location = new System.Drawing.Point(544, 174);
            this.cmdCancelRealTimeBars.Name = "cmdCancelRealTimeBars";
            this.cmdCancelRealTimeBars.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancelRealTimeBars.Size = new System.Drawing.Size(134, 21);
            this.cmdCancelRealTimeBars.TabIndex = 9;
            this.cmdCancelRealTimeBars.Text = "Canc Real Time Bars";
            this.cmdCancelRealTimeBars.UseVisualStyleBackColor = false;
            this.cmdCancelRealTimeBars.Click += new System.EventHandler(this.cmdCancelRealTimeBars_Click);
            // 
            // cmdReqRealTimeBars
            // 
            this.cmdReqRealTimeBars.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqRealTimeBars.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqRealTimeBars.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqRealTimeBars.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqRealTimeBars.Location = new System.Drawing.Point(544, 150);
            this.cmdReqRealTimeBars.Name = "cmdReqRealTimeBars";
            this.cmdReqRealTimeBars.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqRealTimeBars.Size = new System.Drawing.Size(134, 21);
            this.cmdReqRealTimeBars.TabIndex = 8;
            this.cmdReqRealTimeBars.Text = "Real Time Bars";
            this.cmdReqRealTimeBars.UseVisualStyleBackColor = false;
            this.cmdReqRealTimeBars.Click += new System.EventHandler(this.cmdReqRealTimeBars_Click);
            // 
            // cmdCancelHistData
            // 
            this.cmdCancelHistData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCancelHistData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancelHistData.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelHistData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCancelHistData.Location = new System.Drawing.Point(544, 126);
            this.cmdCancelHistData.Name = "cmdCancelHistData";
            this.cmdCancelHistData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancelHistData.Size = new System.Drawing.Size(134, 21);
            this.cmdCancelHistData.TabIndex = 7;
            this.cmdCancelHistData.Text = "Cancel Hist. Data...";
            this.cmdCancelHistData.UseVisualStyleBackColor = false;
            this.cmdCancelHistData.Click += new System.EventHandler(this.cmdCancelHistData_Click);
            // 
            // cmdScanner
            // 
            this.cmdScanner.BackColor = System.Drawing.SystemColors.Control;
            this.cmdScanner.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdScanner.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdScanner.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdScanner.Location = new System.Drawing.Point(544, 222);
            this.cmdScanner.Name = "cmdScanner";
            this.cmdScanner.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdScanner.Size = new System.Drawing.Size(134, 21);
            this.cmdScanner.TabIndex = 11;
            this.cmdScanner.Text = "Market Scanner...";
            this.cmdScanner.UseVisualStyleBackColor = false;
            this.cmdScanner.Click += new System.EventHandler(this.cmdScanner_Click);
            // 
            // cmdExerciseOptions
            // 
            this.cmdExerciseOptions.BackColor = System.Drawing.SystemColors.Control;
            this.cmdExerciseOptions.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdExerciseOptions.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExerciseOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdExerciseOptions.Location = new System.Drawing.Point(544, 414);
            this.cmdExerciseOptions.Name = "cmdExerciseOptions";
            this.cmdExerciseOptions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdExerciseOptions.Size = new System.Drawing.Size(134, 21);
            this.cmdExerciseOptions.TabIndex = 19;
            this.cmdExerciseOptions.Text = "Exercise Options...";
            this.cmdExerciseOptions.UseVisualStyleBackColor = false;
            this.cmdExerciseOptions.Click += new System.EventHandler(this.cmdExerciseOptions_Click);
            // 
            // cmdReqHistoricalData
            // 
            this.cmdReqHistoricalData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqHistoricalData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqHistoricalData.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqHistoricalData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqHistoricalData.Location = new System.Drawing.Point(544, 102);
            this.cmdReqHistoricalData.Name = "cmdReqHistoricalData";
            this.cmdReqHistoricalData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqHistoricalData.Size = new System.Drawing.Size(134, 21);
            this.cmdReqHistoricalData.TabIndex = 6;
            this.cmdReqHistoricalData.Text = "Historical Data...";
            this.cmdReqHistoricalData.UseVisualStyleBackColor = false;
            this.cmdReqHistoricalData.Click += new System.EventHandler(this.cmdReqHistoricalData_Click);
            // 
            // cmdFinancialAdvisor
            // 
            this.cmdFinancialAdvisor.BackColor = System.Drawing.SystemColors.Control;
            this.cmdFinancialAdvisor.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdFinancialAdvisor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFinancialAdvisor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdFinancialAdvisor.Location = new System.Drawing.Point(544, 702);
            this.cmdFinancialAdvisor.Name = "cmdFinancialAdvisor";
            this.cmdFinancialAdvisor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFinancialAdvisor.Size = new System.Drawing.Size(134, 21);
            this.cmdFinancialAdvisor.TabIndex = 31;
            this.cmdFinancialAdvisor.Text = "Financial Advisor";
            this.cmdFinancialAdvisor.UseVisualStyleBackColor = false;
            this.cmdFinancialAdvisor.Click += new System.EventHandler(this.cmdFinancialAdvisor_Click);
            // 
            // cmdReqAccts
            // 
            this.cmdReqAccts.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqAccts.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqAccts.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqAccts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqAccts.Location = new System.Drawing.Point(544, 678);
            this.cmdReqAccts.Name = "cmdReqAccts";
            this.cmdReqAccts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqAccts.Size = new System.Drawing.Size(134, 21);
            this.cmdReqAccts.TabIndex = 30;
            this.cmdReqAccts.Text = "Req Accounts";
            this.cmdReqAccts.UseVisualStyleBackColor = false;
            this.cmdReqAccts.Click += new System.EventHandler(this.cmdReqAccts_Click);
            // 
            // cmdReqAllOpenOrders
            // 
            this.cmdReqAllOpenOrders.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqAllOpenOrders.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqAllOpenOrders.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqAllOpenOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqAllOpenOrders.Location = new System.Drawing.Point(544, 510);
            this.cmdReqAllOpenOrders.Name = "cmdReqAllOpenOrders";
            this.cmdReqAllOpenOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqAllOpenOrders.Size = new System.Drawing.Size(134, 21);
            this.cmdReqAllOpenOrders.TabIndex = 23;
            this.cmdReqAllOpenOrders.Text = "Req All Open Orders";
            this.cmdReqAllOpenOrders.UseVisualStyleBackColor = false;
            this.cmdReqAllOpenOrders.Click += new System.EventHandler(this.cmdReqAllOpenOrders_Click);
            // 
            // cmdReqAutoOpenOrders
            // 
            this.cmdReqAutoOpenOrders.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqAutoOpenOrders.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqAutoOpenOrders.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqAutoOpenOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqAutoOpenOrders.Location = new System.Drawing.Point(544, 534);
            this.cmdReqAutoOpenOrders.Name = "cmdReqAutoOpenOrders";
            this.cmdReqAutoOpenOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqAutoOpenOrders.Size = new System.Drawing.Size(134, 21);
            this.cmdReqAutoOpenOrders.TabIndex = 24;
            this.cmdReqAutoOpenOrders.Text = "Req Auto Open Orders";
            this.cmdReqAutoOpenOrders.UseVisualStyleBackColor = false;
            this.cmdReqAutoOpenOrders.Click += new System.EventHandler(this.cmdReqAutoOpenOrders_Click);
            // 
            // cmdServerLogLevel
            // 
            this.cmdServerLogLevel.BackColor = System.Drawing.SystemColors.Control;
            this.cmdServerLogLevel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdServerLogLevel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdServerLogLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdServerLogLevel.Location = new System.Drawing.Point(544, 654);
            this.cmdServerLogLevel.Name = "cmdServerLogLevel";
            this.cmdServerLogLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdServerLogLevel.Size = new System.Drawing.Size(134, 21);
            this.cmdServerLogLevel.TabIndex = 29;
            this.cmdServerLogLevel.Text = "Log Configuration...";
            this.cmdServerLogLevel.UseVisualStyleBackColor = false;
            this.cmdServerLogLevel.Click += new System.EventHandler(this.cmdServerLogLevel_Click);
            // 
            // cmdReqNews
            // 
            this.cmdReqNews.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqNews.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqNews.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqNews.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqNews.Location = new System.Drawing.Point(544, 630);
            this.cmdReqNews.Name = "cmdReqNews";
            this.cmdReqNews.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqNews.Size = new System.Drawing.Size(134, 21);
            this.cmdReqNews.TabIndex = 28;
            this.cmdReqNews.Text = "Req News Bulletins...";
            this.cmdReqNews.UseVisualStyleBackColor = false;
            this.cmdReqNews.Click += new System.EventHandler(this.cmdReqNews_Click);
            // 
            // cmdReqAcctData
            // 
            this.cmdReqAcctData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqAcctData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqAcctData.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqAcctData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqAcctData.Location = new System.Drawing.Point(544, 558);
            this.cmdReqAcctData.Name = "cmdReqAcctData";
            this.cmdReqAcctData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqAcctData.Size = new System.Drawing.Size(134, 21);
            this.cmdReqAcctData.TabIndex = 25;
            this.cmdReqAcctData.Text = "Req Acct Data...";
            this.cmdReqAcctData.UseVisualStyleBackColor = false;
            this.cmdReqAcctData.Click += new System.EventHandler(this.cmdReqAcctData_Click);
            // 
            // cmdReqExecutions
            // 
            this.cmdReqExecutions.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqExecutions.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqExecutions.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqExecutions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqExecutions.Location = new System.Drawing.Point(544, 582);
            this.cmdReqExecutions.Name = "cmdReqExecutions";
            this.cmdReqExecutions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqExecutions.Size = new System.Drawing.Size(134, 21);
            this.cmdReqExecutions.TabIndex = 26;
            this.cmdReqExecutions.Text = "Req Executions...";
            this.cmdReqExecutions.UseVisualStyleBackColor = false;
            this.cmdReqExecutions.Click += new System.EventHandler(this.cmdReqExecutions_Click);
            // 
            // cmdReqIds
            // 
            this.cmdReqIds.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqIds.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqIds.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqIds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqIds.Location = new System.Drawing.Point(544, 606);
            this.cmdReqIds.Name = "cmdReqIds";
            this.cmdReqIds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqIds.Size = new System.Drawing.Size(134, 21);
            this.cmdReqIds.TabIndex = 27;
            this.cmdReqIds.Text = "Req Next Id...";
            this.cmdReqIds.UseVisualStyleBackColor = false;
            this.cmdReqIds.Click += new System.EventHandler(this.cmdReqIds_Click);
            // 
            // cmdClearForm
            // 
            this.cmdClearForm.BackColor = System.Drawing.SystemColors.Control;
            this.cmdClearForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdClearForm.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClearForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClearForm.Location = new System.Drawing.Point(216, 763);
            this.cmdClearForm.Name = "cmdClearForm";
            this.cmdClearForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdClearForm.Size = new System.Drawing.Size(89, 25);
            this.cmdClearForm.TabIndex = 34;
            this.cmdClearForm.Text = "Clear";
            this.cmdClearForm.UseVisualStyleBackColor = false;
            this.cmdClearForm.Click += new System.EventHandler(this.cmdClearForm_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.SystemColors.Control;
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdClose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClose.Location = new System.Drawing.Point(320, 763);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdClose.Size = new System.Drawing.Size(89, 25);
            this.cmdClose.TabIndex = 35;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdDisconnect
            // 
            this.cmdDisconnect.BackColor = System.Drawing.SystemColors.Control;
            this.cmdDisconnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdDisconnect.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDisconnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDisconnect.Location = new System.Drawing.Point(320, 4);
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDisconnect.Size = new System.Drawing.Size(113, 25);
            this.cmdDisconnect.TabIndex = 1;
            this.cmdDisconnect.Text = "Disconnect";
            this.cmdDisconnect.UseVisualStyleBackColor = false;
            this.cmdDisconnect.Click += new System.EventHandler(this.cmdDisconnect_Click);
            // 
            // cmdReqMktData
            // 
            this.cmdReqMktData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqMktData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqMktData.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqMktData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqMktData.Location = new System.Drawing.Point(544, 6);
            this.cmdReqMktData.Name = "cmdReqMktData";
            this.cmdReqMktData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqMktData.Size = new System.Drawing.Size(134, 21);
            this.cmdReqMktData.TabIndex = 2;
            this.cmdReqMktData.Text = "Req Mkt Data...";
            this.cmdReqMktData.UseVisualStyleBackColor = false;
            this.cmdReqMktData.Click += new System.EventHandler(this.cmdReqMktData_Click);
            // 
            // cmdCancelMktData
            // 
            this.cmdCancelMktData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCancelMktData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancelMktData.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelMktData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCancelMktData.Location = new System.Drawing.Point(544, 30);
            this.cmdCancelMktData.Name = "cmdCancelMktData";
            this.cmdCancelMktData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancelMktData.Size = new System.Drawing.Size(134, 21);
            this.cmdCancelMktData.TabIndex = 3;
            this.cmdCancelMktData.Text = "Cancel Mkt Data...";
            this.cmdCancelMktData.UseVisualStyleBackColor = false;
            this.cmdCancelMktData.Click += new System.EventHandler(this.cmdCancelMktData_Click);
            // 
            // cmdReqMktDepth
            // 
            this.cmdReqMktDepth.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqMktDepth.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqMktDepth.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqMktDepth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqMktDepth.Location = new System.Drawing.Point(544, 54);
            this.cmdReqMktDepth.Name = "cmdReqMktDepth";
            this.cmdReqMktDepth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqMktDepth.Size = new System.Drawing.Size(134, 21);
            this.cmdReqMktDepth.TabIndex = 4;
            this.cmdReqMktDepth.Text = "Req Mkt Depth...";
            this.cmdReqMktDepth.UseVisualStyleBackColor = false;
            this.cmdReqMktDepth.Click += new System.EventHandler(this.cmdReqMktDepth_Click);
            // 
            // cmdCancelMktDepth
            // 
            this.cmdCancelMktDepth.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCancelMktDepth.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancelMktDepth.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelMktDepth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCancelMktDepth.Location = new System.Drawing.Point(544, 78);
            this.cmdCancelMktDepth.Name = "cmdCancelMktDepth";
            this.cmdCancelMktDepth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancelMktDepth.Size = new System.Drawing.Size(134, 21);
            this.cmdCancelMktDepth.TabIndex = 5;
            this.cmdCancelMktDepth.Text = "Cancel Mkt Depth...";
            this.cmdCancelMktDepth.UseVisualStyleBackColor = false;
            this.cmdCancelMktDepth.Click += new System.EventHandler(this.cmdCancelMktDepth_Click);
            // 
            // cmdPlaceOrder
            // 
            this.cmdPlaceOrder.BackColor = System.Drawing.SystemColors.Control;
            this.cmdPlaceOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdPlaceOrder.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPlaceOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdPlaceOrder.Location = new System.Drawing.Point(544, 366);
            this.cmdPlaceOrder.Name = "cmdPlaceOrder";
            this.cmdPlaceOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdPlaceOrder.Size = new System.Drawing.Size(134, 21);
            this.cmdPlaceOrder.TabIndex = 17;
            this.cmdPlaceOrder.Text = "Place Order...";
            this.cmdPlaceOrder.UseVisualStyleBackColor = false;
            this.cmdPlaceOrder.Click += new System.EventHandler(this.cmdPlaceOrder_Click);
            // 
            // cmdCancelOrder
            // 
            this.cmdCancelOrder.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCancelOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancelOrder.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCancelOrder.Location = new System.Drawing.Point(544, 390);
            this.cmdCancelOrder.Name = "cmdCancelOrder";
            this.cmdCancelOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancelOrder.Size = new System.Drawing.Size(134, 21);
            this.cmdCancelOrder.TabIndex = 18;
            this.cmdCancelOrder.Text = "Cancel Order...";
            this.cmdCancelOrder.UseVisualStyleBackColor = false;
            this.cmdCancelOrder.Click += new System.EventHandler(this.cmdCancelOrder_Click);
            // 
            // cmdExtendedOrderAtribs
            // 
            this.cmdExtendedOrderAtribs.BackColor = System.Drawing.SystemColors.Control;
            this.cmdExtendedOrderAtribs.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdExtendedOrderAtribs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExtendedOrderAtribs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdExtendedOrderAtribs.Location = new System.Drawing.Point(544, 438);
            this.cmdExtendedOrderAtribs.Name = "cmdExtendedOrderAtribs";
            this.cmdExtendedOrderAtribs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdExtendedOrderAtribs.Size = new System.Drawing.Size(134, 21);
            this.cmdExtendedOrderAtribs.TabIndex = 20;
            this.cmdExtendedOrderAtribs.Text = "Extended...";
            this.cmdExtendedOrderAtribs.UseVisualStyleBackColor = false;
            this.cmdExtendedOrderAtribs.Click += new System.EventHandler(this.cmdExtendedOrderAtribs_Click);
            // 
            // cmdReqContractData
            // 
            this.cmdReqContractData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqContractData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqContractData.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqContractData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqContractData.Location = new System.Drawing.Point(544, 462);
            this.cmdReqContractData.Name = "cmdReqContractData";
            this.cmdReqContractData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqContractData.Size = new System.Drawing.Size(134, 21);
            this.cmdReqContractData.TabIndex = 21;
            this.cmdReqContractData.Text = "Req Contract Data...";
            this.cmdReqContractData.UseVisualStyleBackColor = false;
            this.cmdReqContractData.Click += new System.EventHandler(this.cmdReqContractData_Click);
            // 
            // cmdReqOpenOrders
            // 
            this.cmdReqOpenOrders.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReqOpenOrders.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReqOpenOrders.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReqOpenOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReqOpenOrders.Location = new System.Drawing.Point(544, 486);
            this.cmdReqOpenOrders.Name = "cmdReqOpenOrders";
            this.cmdReqOpenOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReqOpenOrders.Size = new System.Drawing.Size(134, 21);
            this.cmdReqOpenOrders.TabIndex = 22;
            this.cmdReqOpenOrders.Text = "Req Open Orders";
            this.cmdReqOpenOrders.UseVisualStyleBackColor = false;
            this.cmdReqOpenOrders.Click += new System.EventHandler(this.cmdReqOpenOrders_Click);
            // 
            // cmdConnect
            // 
            this.cmdConnect.BackColor = System.Drawing.SystemColors.Control;
            this.cmdConnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdConnect.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdConnect.Location = new System.Drawing.Point(200, 4);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdConnect.Size = new System.Drawing.Size(113, 25);
            this.cmdConnect.TabIndex = 0;
            this.cmdConnect.Text = "Connect...";
            this.cmdConnect.UseVisualStyleBackColor = false;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // lstErrors
            // 
            this.lstErrors.BackColor = System.Drawing.SystemColors.Window;
            this.lstErrors.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstErrors.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstErrors.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstErrors.HorizontalScrollbar = true;
            this.lstErrors.ItemHeight = 14;
            this.lstErrors.Location = new System.Drawing.Point(8, 515);
            this.lstErrors.Name = "lstErrors";
            this.lstErrors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstErrors.Size = new System.Drawing.Size(529, 242);
            this.lstErrors.TabIndex = 41;
            // 
            // lstServerResponses
            // 
            this.lstServerResponses.BackColor = System.Drawing.SystemColors.Window;
            this.lstServerResponses.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstServerResponses.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstServerResponses.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstServerResponses.HorizontalScrollbar = true;
            this.lstServerResponses.ItemHeight = 14;
            this.lstServerResponses.Location = new System.Drawing.Point(8, 256);
            this.lstServerResponses.Name = "lstServerResponses";
            this.lstServerResponses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstServerResponses.Size = new System.Drawing.Size(529, 228);
            this.lstServerResponses.TabIndex = 39;
            // 
            // lstMktData
            // 
            this.lstMktData.BackColor = System.Drawing.SystemColors.Window;
            this.lstMktData.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstMktData.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMktData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstMktData.HorizontalScrollbar = true;
            this.lstMktData.ItemHeight = 14;
            this.lstMktData.Location = new System.Drawing.Point(8, 36);
            this.lstMktData.Name = "lstMktData";
            this.lstMktData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstMktData.Size = new System.Drawing.Size(529, 200);
            this.lstMktData.TabIndex = 37;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(8, 495);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(120, 17);
            this.Label3.TabIndex = 40;
            this.Label3.Text = "Errors and Messages";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(8, 240);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(136, 17);
            this.Label2.TabIndex = 38;
            this.Label2.Text = "TWS Server Responses";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(8, 20);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(144, 17);
            this.Label1.TabIndex = 36;
            this.Label1.Text = "Market and Historical Data";
            // 
            // Tws1
            // 
            this.Tws1.Enabled = true;
            this.Tws1.Location = new System.Drawing.Point(19, 763);
            this.Tws1.Name = "Tws1";
            this.Tws1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Tws1.OcxState")));
            this.Tws1.Size = new System.Drawing.Size(145, 25);
            this.Tws1.TabIndex = 42;
            // 
            // dlgMainWnd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(680, 800);
            this.Controls.Add(this.Tws1);
            this.Controls.Add(this.cmdReqMarketDataType);
            this.Controls.Add(this.cmdReqGlobalCancel);
            this.Controls.Add(this.cmdCancelCalcOptionPrice);
            this.Controls.Add(this.cmdCancelCalcImpliedVolatility);
            this.Controls.Add(this.cmdCalcOptionPrice);
            this.Controls.Add(this.cmdCalcImpliedVolatility);
            this.Controls.Add(this.cmdWhatIf);
            this.Controls.Add(this.cmdReqCurrentTime);
            this.Controls.Add(this.cmdCancelRealTimeBars);
            this.Controls.Add(this.cmdReqRealTimeBars);
            this.Controls.Add(this.cmdCancelHistData);
            this.Controls.Add(this.cmdScanner);
            this.Controls.Add(this.cmdExerciseOptions);
            this.Controls.Add(this.cmdReqHistoricalData);
            this.Controls.Add(this.cmdFinancialAdvisor);
            this.Controls.Add(this.cmdReqAccts);
            this.Controls.Add(this.cmdReqAllOpenOrders);
            this.Controls.Add(this.cmdReqAutoOpenOrders);
            this.Controls.Add(this.cmdServerLogLevel);
            this.Controls.Add(this.cmdReqNews);
            this.Controls.Add(this.cmdReqAcctData);
            this.Controls.Add(this.cmdReqExecutions);
            this.Controls.Add(this.cmdReqIds);
            this.Controls.Add(this.cmdClearForm);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdDisconnect);
            this.Controls.Add(this.cmdReqMktData);
            this.Controls.Add(this.cmdCancelMktData);
            this.Controls.Add(this.cmdReqMktDepth);
            this.Controls.Add(this.cmdCancelMktDepth);
            this.Controls.Add(this.cmdPlaceOrder);
            this.Controls.Add(this.cmdCancelOrder);
            this.Controls.Add(this.cmdExtendedOrderAtribs);
            this.Controls.Add(this.cmdReqContractData);
            this.Controls.Add(this.cmdReqOpenOrders);
            this.Controls.Add(this.cmdConnect);
            this.Controls.Add(this.lstErrors);
            this.Controls.Add(this.lstServerResponses);
            this.Controls.Add(this.lstMktData);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(348, 193);
            this.Name = "dlgMainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Sample using TWS ActiveX Control";
            ((System.ComponentModel.ISupportInitialize)(this.Tws1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button cmdWhatIf;
        public System.Windows.Forms.Button cmdReqCurrentTime;
        public System.Windows.Forms.Button cmdCancelRealTimeBars;
        public System.Windows.Forms.Button cmdReqRealTimeBars;
        public System.Windows.Forms.Button cmdCancelHistData;
        public System.Windows.Forms.Button cmdScanner;
        public System.Windows.Forms.Button cmdExerciseOptions;
        public System.Windows.Forms.Button cmdReqHistoricalData;
        public System.Windows.Forms.Button cmdFinancialAdvisor;
        public System.Windows.Forms.Button cmdReqAccts;
        public System.Windows.Forms.Button cmdReqAllOpenOrders;
        public System.Windows.Forms.Button cmdReqAutoOpenOrders;
        public System.Windows.Forms.Button cmdServerLogLevel;
        public System.Windows.Forms.Button cmdReqNews;
        public System.Windows.Forms.Button cmdReqAcctData;
        public System.Windows.Forms.Button cmdReqExecutions;
        public System.Windows.Forms.Button cmdReqIds;
        public System.Windows.Forms.Button cmdClearForm;
        public System.Windows.Forms.Button cmdClose;
        public System.Windows.Forms.Button cmdDisconnect;
        public System.Windows.Forms.Button cmdReqMktData;
        public System.Windows.Forms.Button cmdCancelMktData;
        public System.Windows.Forms.Button cmdReqMktDepth;
        public System.Windows.Forms.Button cmdCancelMktDepth;
        public System.Windows.Forms.Button cmdPlaceOrder;
        public System.Windows.Forms.Button cmdCancelOrder;
        public System.Windows.Forms.Button cmdExtendedOrderAtribs;
        public System.Windows.Forms.Button cmdReqContractData;
        public System.Windows.Forms.Button cmdReqOpenOrders;
        public System.Windows.Forms.Button cmdConnect;
        public System.Windows.Forms.ListBox lstErrors;
        public System.Windows.Forms.ListBox lstServerResponses;
        public System.Windows.Forms.ListBox lstMktData;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label1;
        public AxTWSLib.AxTws Tws1;
        public System.Windows.Forms.Button cmdCalcImpliedVolatility;
        public System.Windows.Forms.Button cmdReqMarketDataType;
        public System.Windows.Forms.Button cmdReqGlobalCancel;
        public System.Windows.Forms.Button cmdCancelCalcOptionPrice;
        public System.Windows.Forms.Button cmdCancelCalcImpliedVolatility;
        public System.Windows.Forms.Button cmdCalcOptionPrice;
    }
}

