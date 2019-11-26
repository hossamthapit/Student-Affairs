namespace Student_Affairs_v2._7.Forms {
    partial class Excel_Compare {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excel_Compare));
            this.labelExit = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSelectExcelOld = new System.Windows.Forms.Button();
            this.buttonSelectExcelNew = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(799, 9);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(21, 20);
            this.labelExit.TabIndex = 5;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(389, 403);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonSelectExcelOld
            // 
            this.buttonSelectExcelOld.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelectExcelOld.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectExcelOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectExcelOld.ForeColor = System.Drawing.Color.White;
            this.buttonSelectExcelOld.Location = new System.Drawing.Point(568, 55);
            this.buttonSelectExcelOld.Name = "buttonSelectExcelOld";
            this.buttonSelectExcelOld.Size = new System.Drawing.Size(112, 23);
            this.buttonSelectExcelOld.TabIndex = 3;
            this.buttonSelectExcelOld.Text = "Select Old File";
            this.buttonSelectExcelOld.UseVisualStyleBackColor = false;
            this.buttonSelectExcelOld.Click += new System.EventHandler(this.buttonSelectExcel_Click);
            // 
            // buttonSelectExcelNew
            // 
            this.buttonSelectExcelNew.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelectExcelNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectExcelNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectExcelNew.ForeColor = System.Drawing.Color.White;
            this.buttonSelectExcelNew.Location = new System.Drawing.Point(123, 55);
            this.buttonSelectExcelNew.Name = "buttonSelectExcelNew";
            this.buttonSelectExcelNew.Size = new System.Drawing.Size(109, 23);
            this.buttonSelectExcelNew.TabIndex = 6;
            this.buttonSelectExcelNew.Text = "Select New File";
            this.buttonSelectExcelNew.UseVisualStyleBackColor = false;
            this.buttonSelectExcelNew.Click += new System.EventHandler(this.buttonSelectExcelNew_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.BackColor = System.Drawing.Color.Transparent;
            this.buttonCompare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompare.ForeColor = System.Drawing.Color.White;
            this.buttonCompare.Location = new System.Drawing.Point(378, 55);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonCompare.TabIndex = 7;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = false;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 94);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(389, 403);
            this.dataGridView2.TabIndex = 8;
            // 
            // Excel_Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 509);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.buttonSelectExcelNew);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSelectExcelOld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Excel_Compare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Excel_Compare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSelectExcelOld;
        private System.Windows.Forms.Button buttonSelectExcelNew;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}