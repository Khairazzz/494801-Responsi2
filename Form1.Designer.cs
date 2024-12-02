namespace Responsi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblKaryawan = new Label();
            lblDep = new Label();
            tbNama = new TextBox();
            cbDep = new ComboBox();
            label1 = new Label();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            btnLoad = new Button();
            lblJabatan = new Label();
            tbJabatan = new TextBox();
            lblIdKaryawan = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(34, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 64);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblKaryawan
            // 
            lblKaryawan.AutoSize = true;
            lblKaryawan.Location = new Point(34, 122);
            lblKaryawan.Name = "lblKaryawan";
            lblKaryawan.Size = new Size(99, 15);
            lblKaryawan.TabIndex = 1;
            lblKaryawan.Text = "Nama Karyawan :";
            // 
            // lblDep
            // 
            lblDep.AutoSize = true;
            lblDep.Location = new Point(34, 159);
            lblDep.Name = "lblDep";
            lblDep.Size = new Size(100, 15);
            lblDep.TabIndex = 2;
            lblDep.Text = "Dep. Karyawan    :";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(150, 119);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(359, 23);
            tbNama.TabIndex = 3;
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Location = new Point(150, 156);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(359, 23);
            cbDep.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(595, 119);
            label1.Name = "label1";
            label1.Size = new Size(90, 105);
            label1.TabIndex = 5;
            label1.Text = "ID Departemen:\r\nHR : HR\r\nENG : Engineer\r\nDEV : Developer\r\nPM : Product M\r\nFIN : Finance\r\n\r\n";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(86, 226);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(89, 31);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(249, 226);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(89, 31);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(420, 226);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 31);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(34, 318);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(714, 162);
            dgvData.TabIndex = 9;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(659, 486);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(89, 31);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblJabatan
            // 
            lblJabatan.AutoSize = true;
            lblJabatan.Location = new Point(36, 197);
            lblJabatan.Name = "lblJabatan";
            lblJabatan.Size = new Size(98, 15);
            lblJabatan.TabIndex = 11;
            lblJabatan.Text = "Jabatan                :";
            // 
            // tbJabatan
            // 
            tbJabatan.Location = new Point(150, 192);
            tbJabatan.Name = "tbJabatan";
            tbJabatan.Size = new Size(359, 23);
            tbJabatan.TabIndex = 12;
            // 
            // lblIdKaryawan
            // 
            lblIdKaryawan.AutoSize = true;
            lblIdKaryawan.Location = new Point(36, 279);
            lblIdKaryawan.Name = "lblIdKaryawan";
            lblIdKaryawan.Size = new Size(78, 15);
            lblIdKaryawan.TabIndex = 13;
            lblIdKaryawan.Text = "ID Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 279);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 14;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 529);
            Controls.Add(label3);
            Controls.Add(lblIdKaryawan);
            Controls.Add(tbJabatan);
            Controls.Add(lblJabatan);
            Controls.Add(btnLoad);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(label1);
            Controls.Add(cbDep);
            Controls.Add(tbNama);
            Controls.Add(lblDep);
            Controls.Add(lblKaryawan);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblKaryawan;
        private Label lblDep;
        private TextBox tbNama;
        private ComboBox cbDep;
        private Label label1;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private Button btnLoad;
        private Label lblJabatan;
        private TextBox tbJabatan;
        private Label lblIdKaryawan;
        private Label label3;
    }
}
