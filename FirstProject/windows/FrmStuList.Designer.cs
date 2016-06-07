namespace FirstProject
{
    partial class StuListFrm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("男", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("女", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("s1", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("男", 1, 1);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("女", 2, 2);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("s2", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("男", 1, 1);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("女", 2, 2);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("y2", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("全部", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuListFrm));
            this.tvKind = new System.Windows.Forms.TreeView();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tvKind
            // 
            this.tvKind.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvKind.ImageIndex = 0;
            this.tvKind.ImageList = this.imgList;
            this.tvKind.Location = new System.Drawing.Point(0, 0);
            this.tvKind.Name = "tvKind";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "male";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Tag = "male";
            treeNode1.Text = "男";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "female";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Tag = "female";
            treeNode2.Text = "女";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "s1";
            treeNode3.SelectedImageIndex = 0;
            treeNode3.Text = "s1";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "male";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Tag = "male";
            treeNode4.Text = "男";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "female";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Tag = "female";
            treeNode5.Text = "女";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "s2";
            treeNode6.SelectedImageIndex = 0;
            treeNode6.Text = "s2";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "male";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Tag = "male";
            treeNode7.Text = "男";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "female";
            treeNode8.SelectedImageIndex = 2;
            treeNode8.Tag = "female";
            treeNode8.Text = "女";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "y2";
            treeNode9.SelectedImageIndex = 0;
            treeNode9.Text = "y2";
            treeNode10.Name = "all";
            treeNode10.Text = "全部";
            this.tvKind.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.tvKind.SelectedImageIndex = 0;
            this.tvKind.Size = new System.Drawing.Size(247, 599);
            this.tvKind.TabIndex = 0;
            this.tvKind.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKind_AfterSelect);
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvDetail.Location = new System.Drawing.Point(253, 0);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.Size = new System.Drawing.Size(469, 599);
            this.dgvDetail.TabIndex = 1;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "8.bmp");
            this.imgList.Images.SetKeyName(1, "5.bmp");
            this.imgList.Images.SetKeyName(2, "6.bmp");
            // 
            // StuListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 599);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.tvKind);
            this.Name = "StuListFrm";
            this.Text = "StuListFrm";
            this.Load += new System.EventHandler(this.StuListFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvKind;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.ImageList imgList;

    }
}