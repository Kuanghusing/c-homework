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
            this.stuListView = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // stuListView
            // 
            this.stuListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chNo,
            this.chGender});
            this.stuListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stuListView.Location = new System.Drawing.Point(0, 0);
            this.stuListView.Name = "stuListView";
            this.stuListView.Size = new System.Drawing.Size(531, 374);
            this.stuListView.TabIndex = 0;
            this.stuListView.UseCompatibleStateImageBehavior = false;
            this.stuListView.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "姓名";
            this.chName.Width = 115;
            // 
            // chNo
            // 
            this.chNo.Text = "学号";
            this.chNo.Width = 101;
            // 
            // chGender
            // 
            this.chGender.Text = "性别";
            this.chGender.Width = 153;
            // 
            // StuListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 374);
            this.Controls.Add(this.stuListView);
            this.Name = "StuListFrm";
            this.Text = "StuListFrm";
            this.Load += new System.EventHandler(this.StuListFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView stuListView;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chNo;
        private System.Windows.Forms.ColumnHeader chGender;
    }
}