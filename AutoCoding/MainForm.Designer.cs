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
            this.button1 = new System.Windows.Forms.Button();
            this.gbCenter = new System.Windows.Forms.GroupBox();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.spContent = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDb = new System.Windows.Forms.ComboBox();
            this.lvTable = new System.Windows.Forms.ListView();
            this.TableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pnTop.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.gbCenter.SuspendLayout();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContent)).BeginInit();
            this.spContent.Panel1.SuspendLayout();
            this.spContent.Panel2.SuspendLayout();
            this.spContent.SuspendLayout();
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
            this.tbConnStr.Text = "Server=ZHANGTAO\\SQLEXPRESS;database=JooWMS;user id=sa;Password=511549108";
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.button1);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 446);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1029, 35);
            this.pnBottom.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(948, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择数据库";
            // 
            // cbDb
            // 
            this.cbDb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDb.FormattingEnabled = true;
            this.cbDb.Location = new System.Drawing.Point(87, 9);
            this.cbDb.Name = "cbDb";
            this.cbDb.Size = new System.Drawing.Size(180, 20);
            this.cbDb.TabIndex = 1;
            this.cbDb.SelectedIndexChanged += new System.EventHandler(this.cbDb_SelectedIndexChanged);
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
            this.gbCenter.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.spContent.Panel1.ResumeLayout(false);
            this.spContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContent)).EndInit();
            this.spContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbConnStr;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.TextBox tbConnStr;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbCenter;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.SplitContainer spContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDb;
        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.ColumnHeader TableName;
        private System.Windows.Forms.TabControl tabMain;
    }
}