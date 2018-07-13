namespace AutoCoding
{
    partial class MainForm
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbConnStr = new System.Windows.Forms.Label();
            this.btnConn = new System.Windows.Forms.Button();
            this.tbConnStr = new System.Windows.Forms.TextBox();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.tbModule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.tbProj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.gbCenter = new System.Windows.Forms.GroupBox();
            this.spContent = new System.Windows.Forms.SplitContainer();
            this.lvTable = new System.Windows.Forms.ListView();
            this.TableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.cbDb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.gbCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContent)).BeginInit();
            this.spContent.Panel1.SuspendLayout();
            this.spContent.Panel2.SuspendLayout();
            this.spContent.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lbConnStr);
            this.pnTop.Controls.Add(this.btnConn);
            this.pnTop.Controls.Add(this.tbConnStr);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1029, 40);
            this.pnTop.TabIndex = 1;
            // 
            // lbConnStr
            // 
            this.lbConnStr.AutoSize = true;
            this.lbConnStr.Location = new System.Drawing.Point(19, 13);
            this.lbConnStr.Name = "lbConnStr";
            this.lbConnStr.Size = new System.Drawing.Size(65, 12);
            this.lbConnStr.TabIndex = 6;
            this.lbConnStr.Text = "数据库连接";
            // 
            // btnConn
            // 
            this.btnConn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConn.Location = new System.Drawing.Point(943, 8);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 23);
            this.btnConn.TabIndex = 5;
            this.btnConn.Text = "连接";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // tbConnStr
            // 
            this.tbConnStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConnStr.Location = new System.Drawing.Point(90, 10);
            this.tbConnStr.Name = "tbConnStr";
            this.tbConnStr.Size = new System.Drawing.Size(847, 21);
            this.tbConnStr.TabIndex = 4;
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.tbModule);
            this.pnBottom.Controls.Add(this.label3);
            this.pnBottom.Controls.Add(this.btnScan);
            this.pnBottom.Controls.Add(this.tbProj);
            this.pnBottom.Controls.Add(this.label2);
            this.pnBottom.Controls.Add(this.btnGen);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 446);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1029, 35);
            this.pnBottom.TabIndex = 2;
            // 
            // tbModule
            // 
            this.tbModule.Location = new System.Drawing.Point(516, 9);
            this.tbModule.Name = "tbModule";
            this.tbModule.Size = new System.Drawing.Size(119, 21);
            this.tbModule.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "生成模块";
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnScan.Location = new System.Drawing.Point(398, 8);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(40, 23);
            this.btnScan.TabIndex = 6;
            this.btnScan.Text = "浏览";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // tbProj
            // 
            this.tbProj.Location = new System.Drawing.Point(96, 9);
            this.tbProj.Name = "tbProj";
            this.tbProj.Size = new System.Drawing.Size(299, 21);
            this.tbProj.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "选择生成目录";
            // 
            // btnGen
            // 
            this.btnGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGen.Location = new System.Drawing.Point(948, 7);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 1;
            this.btnGen.Text = "生成";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // gbCenter
            // 
            this.gbCenter.Controls.Add(this.spContent);
            this.gbCenter.Controls.Add(this.pnTitle);
            this.gbCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCenter.Location = new System.Drawing.Point(0, 40);
            this.gbCenter.Name = "gbCenter";
            this.gbCenter.Size = new System.Drawing.Size(1029, 406);
            this.gbCenter.TabIndex = 3;
            this.gbCenter.TabStop = false;
            // 
            // spContent
            // 
            this.spContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContent.Location = new System.Drawing.Point(3, 53);
            this.spContent.Name = "spContent";
            // 
            // spContent.Panel1
            // 
            this.spContent.Panel1.Controls.Add(this.lvTable);
            // 
            // spContent.Panel2
            // 
            this.spContent.Panel2.Controls.Add(this.tabMain);
            this.spContent.Size = new System.Drawing.Size(1023, 350);
            this.spContent.SplitterDistance = 200;
            this.spContent.TabIndex = 1;
            // 
            // lvTable
            // 
            this.lvTable.CheckBoxes = true;
            this.lvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TableName});
            this.lvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTable.Location = new System.Drawing.Point(0, 0);
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(200, 350);
            this.lvTable.TabIndex = 0;
            this.lvTable.UseCompatibleStateImageBehavior = false;
            this.lvTable.View = System.Windows.Forms.View.Details;
            this.lvTable.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvTable_ItemChecked);
            // 
            // TableName
            // 
            this.TableName.Text = "表名称";
            this.TableName.Width = 200;
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(819, 350);
            this.tabMain.TabIndex = 0;
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.cbDb);
            this.pnTitle.Controls.Add(this.label1);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(3, 17);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1023, 36);
            this.pnTitle.TabIndex = 0;
            // 
            // cbDb
            // 
            this.cbDb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDb.FormattingEnabled = true;
            this.cbDb.Location = new System.Drawing.Point(87, 9);
            this.cbDb.Name = "cbDb";
            this.cbDb.Size = new System.Drawing.Size(113, 20);
            this.cbDb.TabIndex = 1;
            this.cbDb.SelectedIndexChanged += new System.EventHandler(this.cbDb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择数据库";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 481);
            this.Controls.Add(this.gbCenter);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTop);
            this.Name = "MainForm";
            this.Text = "芝麻自动";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            this.pnBottom.PerformLayout();
            this.gbCenter.ResumeLayout(false);
            this.spContent.Panel1.ResumeLayout(false);
            this.spContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContent)).EndInit();
            this.spContent.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbConnStr;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.TextBox tbConnStr;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.GroupBox gbCenter;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.SplitContainer spContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDb;
        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.ColumnHeader TableName;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TextBox tbProj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbModule;
    }
}