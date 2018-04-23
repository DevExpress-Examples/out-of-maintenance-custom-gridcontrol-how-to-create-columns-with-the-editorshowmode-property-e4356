namespace GridProject
{
    partial class Form1
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
            this.extendedGridControl1 = new ExtendedGridViewSpace.ExtendedGridControl();
            this.extendedGridView1 = new ExtendedGridViewSpace.ExtendedGridView();
            ((System.ComponentModel.ISupportInitialize)(this.extendedGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // extendedGridControl1
            // 
            this.extendedGridControl1.Location = new System.Drawing.Point(29, 38);
            this.extendedGridControl1.MainView = this.extendedGridView1;
            this.extendedGridControl1.Name = "extendedGridControl1";
            this.extendedGridControl1.Size = new System.Drawing.Size(521, 369);
            this.extendedGridControl1.TabIndex = 0;
            this.extendedGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.extendedGridView1});
            // 
            // extendedGridView1
            // 
            this.extendedGridView1.GridControl = this.extendedGridControl1;
            this.extendedGridView1.Name = "extendedGridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 584);
            this.Controls.Add(this.extendedGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.extendedGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedGridViewSpace.ExtendedGridControl extendedGridControl1;
        private ExtendedGridViewSpace.ExtendedGridView extendedGridView1;


    }
}

