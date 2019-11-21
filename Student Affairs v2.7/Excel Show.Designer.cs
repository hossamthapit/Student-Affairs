namespace Student_Affairs_v2._7 {
    partial class Excel_Show {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excel_Show));
            this.buttonSelectExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelExit = new System.Windows.Forms.Label();
            this.comboCoulms = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureSetting = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboNeededCoulms = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectExcel
            // 
            this.buttonSelectExcel.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelectExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectExcel.ForeColor = System.Drawing.Color.White;
            this.buttonSelectExcel.Location = new System.Drawing.Point(375, 25);
            this.buttonSelectExcel.Name = "buttonSelectExcel";
            this.buttonSelectExcel.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectExcel.TabIndex = 0;
            this.buttonSelectExcel.Text = "Select File";
            this.buttonSelectExcel.UseVisualStyleBackColor = false;
            this.buttonSelectExcel.Click += new System.EventHandler(this.buttonSelectExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(799, 395);
            this.dataGridView1.TabIndex = 1;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(801, 9);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(21, 20);
            this.labelExit.TabIndex = 2;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // comboCoulms
            // 
            this.comboCoulms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCoulms.FormattingEnabled = true;
            this.comboCoulms.Location = new System.Drawing.Point(634, 51);
            this.comboCoulms.Name = "comboCoulms";
            this.comboCoulms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboCoulms.Size = new System.Drawing.Size(188, 21);
            this.comboCoulms.TabIndex = 3;
            this.comboCoulms.SelectedIndexChanged += new System.EventHandler(this.comboCoulms_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1019, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureSetting
            // 
            this.pictureSetting.BackColor = System.Drawing.Color.Transparent;
            this.pictureSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureSetting.BackgroundImage")));
            this.pictureSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureSetting.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureSetting.InitialImage")));
            this.pictureSetting.Location = new System.Drawing.Point(23, 9);
            this.pictureSetting.Name = "pictureSetting";
            this.pictureSetting.Size = new System.Drawing.Size(41, 31);
            this.pictureSetting.TabIndex = 5;
            this.pictureSetting.TabStop = false;
            this.pictureSetting.Click += new System.EventHandler(this.pictureSetting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(486, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Needed Coulmns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(518, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Needed Coulmns";
            // 
            // comboNeededCoulms
            // 
            this.comboNeededCoulms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboNeededCoulms.FormattingEnabled = true;
            this.comboNeededCoulms.Location = new System.Drawing.Point(635, 78);
            this.comboNeededCoulms.Name = "comboNeededCoulms";
            this.comboNeededCoulms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboNeededCoulms.Size = new System.Drawing.Size(187, 21);
            this.comboNeededCoulms.TabIndex = 7;
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(19, 74);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(65, 20);
            this.update.TabIndex = 9;
            this.update.Text = "update";
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Excel_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 512);
            this.ControlBox = false;
            this.Controls.Add(this.update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboNeededCoulms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureSetting);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboCoulms);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSelectExcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Excel_Show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.ComboBox comboCoulms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboNeededCoulms;
        private System.Windows.Forms.Label update;
    }
}