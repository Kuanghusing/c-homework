namespace FirstProject
{
    partial class SearchStuByNameFrm
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
            this.listStu = new System.Windows.Forms.ListView();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditStu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteStu = new System.Windows.Forms.ToolStripMenuItem();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // listStu
            // 
            this.listStu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listStu.Location = new System.Drawing.Point(0, 88);
            this.listStu.Name = "listStu";
            this.listStu.Size = new System.Drawing.Size(645, 346);
            this.listStu.TabIndex = 0;
            this.listStu.UseCompatibleStateImageBehavior = false;
            this.listStu.View = System.Windows.Forms.View.Details;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(183, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(71, 33);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(89, 21);
            this.txtSearchName.TabIndex = 3;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditStu,
            this.tsmiDeleteStu});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiEditStu
            // 
            this.tsmiEditStu.Name = "tsmiEditStu";
            this.tsmiEditStu.Size = new System.Drawing.Size(100, 22);
            this.tsmiEditStu.Text = "修改";
            this.tsmiEditStu.Click += new System.EventHandler(this.tsmiEditStu_Click);
            // 
            // tsmiDeleteStu
            // 
            this.tsmiDeleteStu.Name = "tsmiDeleteStu";
            this.tsmiDeleteStu.Size = new System.Drawing.Size(100, 22);
            this.tsmiDeleteStu.Text = "删除";
            this.tsmiDeleteStu.Click += new System.EventHandler(this.tsmiDeleteStu_Click);
            // 
            // SearchStuByNameFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 434);
            this.ContextMenuStrip = this.cms;
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.listStu);
            this.Name = "SearchStuByNameFrm";
            this.Text = "SearchStuByNameFrm";
            this.Load += new System.EventHandler(this.SearchStuByNameFrm_Load);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listStu;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditStu;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteStu;
    }
}