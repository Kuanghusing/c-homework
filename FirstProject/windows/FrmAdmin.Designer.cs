namespace FirstProject
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.tsmiAccountAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddStu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchStuByGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchStuByName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStuList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStuSum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdmin = new System.Windows.Forms.ToolStrip();
            this.tsNewStu = new System.Windows.Forms.ToolStripButton();
            this.tsSearchStuByName = new System.Windows.Forms.ToolStripButton();
            this.tsSearchStuByGender = new System.Windows.Forms.ToolStripButton();
            this.tsStuList = new System.Windows.Forms.ToolStripButton();
            this.tsSubList = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStuSum = new System.Windows.Forms.ToolStripButton();
            this.msAdmin.SuspendLayout();
            this.tsAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAdmin
            // 
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAccountAdmin,
            this.tsmiStuAdmin,
            this.tsmiSubject,
            this.tsmiHelp});
            this.msAdmin.Location = new System.Drawing.Point(0, 0);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(1081, 25);
            this.msAdmin.TabIndex = 0;
            this.msAdmin.Text = "menuStrip1";
            // 
            // tsmiAccountAdmin
            // 
            this.tsmiAccountAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangePwd,
            this.toolStripMenuItem1,
            this.tsmiExit});
            this.tsmiAccountAdmin.Name = "tsmiAccountAdmin";
            this.tsmiAccountAdmin.Size = new System.Drawing.Size(68, 21);
            this.tsmiAccountAdmin.Text = "账号管理";
            // 
            // tsmiChangePwd
            // 
            this.tsmiChangePwd.Name = "tsmiChangePwd";
            this.tsmiChangePwd.Size = new System.Drawing.Size(124, 22);
            this.tsmiChangePwd.Text = "修改密码";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(124, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiStuAdmin
            // 
            this.tsmiStuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStu,
            this.tsmiSearchStuByGrade,
            this.tsmiSearchStuByName,
            this.tsmiStuList,
            this.tsmiStuSum});
            this.tsmiStuAdmin.Name = "tsmiStuAdmin";
            this.tsmiStuAdmin.Size = new System.Drawing.Size(92, 21);
            this.tsmiStuAdmin.Text = "学生用户管理";
            // 
            // tsmiAddStu
            // 
            this.tsmiAddStu.Name = "tsmiAddStu";
            this.tsmiAddStu.Size = new System.Drawing.Size(152, 22);
            this.tsmiAddStu.Text = "新增学生";
            this.tsmiAddStu.Click += new System.EventHandler(this.tsNewStu_Click);
            // 
            // tsmiSearchStuByGrade
            // 
            this.tsmiSearchStuByGrade.Name = "tsmiSearchStuByGrade";
            this.tsmiSearchStuByGrade.Size = new System.Drawing.Size(152, 22);
            this.tsmiSearchStuByGrade.Text = "按年级查找";
            this.tsmiSearchStuByGrade.Click += new System.EventHandler(this.tsmiSearchStuByGrade_Click);
            // 
            // tsmiSearchStuByName
            // 
            this.tsmiSearchStuByName.Name = "tsmiSearchStuByName";
            this.tsmiSearchStuByName.Size = new System.Drawing.Size(152, 22);
            this.tsmiSearchStuByName.Text = "按姓名查找";
            this.tsmiSearchStuByName.Click += new System.EventHandler(this.tsSearchStuByName_Click);
            // 
            // tsmiStuList
            // 
            this.tsmiStuList.Name = "tsmiStuList";
            this.tsmiStuList.Size = new System.Drawing.Size(152, 22);
            this.tsmiStuList.Text = "学生列表";
            this.tsmiStuList.Click += new System.EventHandler(this.tsStuList_Click);
            // 
            // tsmiStuSum
            // 
            this.tsmiStuSum.Name = "tsmiStuSum";
            this.tsmiStuSum.Size = new System.Drawing.Size(152, 22);
            this.tsmiStuSum.Text = "统计学生人数";
            this.tsmiStuSum.Click += new System.EventHandler(this.tsmiStuSum_Click);
            // 
            // tsmiSubject
            // 
            this.tsmiSubject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddSubject});
            this.tsmiSubject.Name = "tsmiSubject";
            this.tsmiSubject.Size = new System.Drawing.Size(68, 21);
            this.tsmiSubject.Text = "科目管理";
            // 
            // tsmiAddSubject
            // 
            this.tsmiAddSubject.Name = "tsmiAddSubject";
            this.tsmiAddSubject.Size = new System.Drawing.Size(124, 22);
            this.tsmiAddSubject.Text = "新增科目";
            this.tsmiAddSubject.Click += new System.EventHandler(this.新增科目ToolStripMenuItem_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 21);
            this.tsmiHelp.Text = "帮助";
            // 
            // tsAdmin
            // 
            this.tsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNewStu,
            this.tsSearchStuByName,
            this.tsSearchStuByGender,
            this.tsStuList,
            this.tsSubList,
            this.tsbtnStuSum});
            this.tsAdmin.Location = new System.Drawing.Point(0, 25);
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Size = new System.Drawing.Size(1081, 25);
            this.tsAdmin.TabIndex = 1;
            this.tsAdmin.Text = "toolStrip1";
            // 
            // tsNewStu
            // 
            this.tsNewStu.Image = ((System.Drawing.Image)(resources.GetObject("tsNewStu.Image")));
            this.tsNewStu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNewStu.Name = "tsNewStu";
            this.tsNewStu.Size = new System.Drawing.Size(100, 22);
            this.tsNewStu.Text = "新增学生信息";
            this.tsNewStu.Click += new System.EventHandler(this.tsNewStu_Click);
            // 
            // tsSearchStuByName
            // 
            this.tsSearchStuByName.Image = ((System.Drawing.Image)(resources.GetObject("tsSearchStuByName.Image")));
            this.tsSearchStuByName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSearchStuByName.Name = "tsSearchStuByName";
            this.tsSearchStuByName.Size = new System.Drawing.Size(112, 22);
            this.tsSearchStuByName.Text = "按姓名查找学生";
            this.tsSearchStuByName.ToolTipText = "按姓名查找学生";
            this.tsSearchStuByName.Click += new System.EventHandler(this.tsSearchStuByName_Click);
            // 
            // tsSearchStuByGender
            // 
            this.tsSearchStuByGender.Image = ((System.Drawing.Image)(resources.GetObject("tsSearchStuByGender.Image")));
            this.tsSearchStuByGender.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSearchStuByGender.Name = "tsSearchStuByGender";
            this.tsSearchStuByGender.Size = new System.Drawing.Size(112, 22);
            this.tsSearchStuByGender.Text = "按性别查找学生";
            this.tsSearchStuByGender.ToolTipText = "toolStripButton3sss";
            // 
            // tsStuList
            // 
            this.tsStuList.Image = ((System.Drawing.Image)(resources.GetObject("tsStuList.Image")));
            this.tsStuList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStuList.Name = "tsStuList";
            this.tsStuList.Size = new System.Drawing.Size(76, 22);
            this.tsStuList.Text = "学生列表";
            this.tsStuList.Click += new System.EventHandler(this.tsStuList_Click);
            // 
            // tsSubList
            // 
            this.tsSubList.Image = ((System.Drawing.Image)(resources.GetObject("tsSubList.Image")));
            this.tsSubList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSubList.Name = "tsSubList";
            this.tsSubList.Size = new System.Drawing.Size(76, 22);
            this.tsSubList.Text = "科目列表";
            // 
            // tsbtnStuSum
            // 
            this.tsbtnStuSum.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStuSum.Image")));
            this.tsbtnStuSum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStuSum.Name = "tsbtnStuSum";
            this.tsbtnStuSum.Size = new System.Drawing.Size(100, 22);
            this.tsbtnStuSum.Text = "统计学生人数";
            this.tsbtnStuSum.Click += new System.EventHandler(this.tsmiStuSum_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 723);
            this.Controls.Add(this.tsAdmin);
            this.Controls.Add(this.msAdmin);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msAdmin;
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.tsAdmin.ResumeLayout(false);
            this.tsAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccountAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePwd;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiStuAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchStuByGrade;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchStuByName;
        private System.Windows.Forms.ToolStripMenuItem tsmiStuList;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubject;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStrip tsAdmin;
        private System.Windows.Forms.ToolStripButton tsNewStu;
        private System.Windows.Forms.ToolStripButton tsSearchStuByName;
        private System.Windows.Forms.ToolStripButton tsSearchStuByGender;
        private System.Windows.Forms.ToolStripButton tsStuList;
        private System.Windows.Forms.ToolStripButton tsSubList;
        private System.Windows.Forms.ToolStripMenuItem tsmiStuSum;
        private System.Windows.Forms.ToolStripButton tsbtnStuSum;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddSubject;

    }
}