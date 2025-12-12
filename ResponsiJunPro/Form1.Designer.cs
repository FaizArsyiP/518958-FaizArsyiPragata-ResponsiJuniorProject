namespace ResponsiJunPro
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
            DGV = new DataGridView();
            txtNama = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cmbStatus = new ComboBox();
            cmbProyek = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label4 = new Label();
            txtBug = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtFitur = new TextBox();
            InsertBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            groupBox3 = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Dock = DockStyle.Fill;
            DGV.Location = new Point(3, 19);
            DGV.Name = "DGV";
            DGV.Size = new Size(766, 178);
            DGV.TabIndex = 0;
            DGV.CellClick += DGV_CellClick;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(139, 22);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(223, 23);
            txtNama.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(8, 25);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 2;
            label1.Text = "Nama Developer       :\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(cmbProyek);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNama);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(170, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(769, 112);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATA DEVELOPER";
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(139, 72);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(223, 23);
            cmbStatus.TabIndex = 6;
            cmbStatus.Text = "Dropdown";
            // 
            // cmbProyek
            // 
            cmbProyek.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProyek.FormattingEnabled = true;
            cmbProyek.Location = new Point(139, 46);
            cmbProyek.Name = "cmbProyek";
            cmbProyek.Size = new Size(223, 23);
            cmbProyek.TabIndex = 5;
            cmbProyek.Text = "Dropdown";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(8, 72);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 4;
            label3.Text = "Status Kontrak           :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(8, 48);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 3;
            label2.Text = "Pilih Proyek                 :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtBug);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtFitur);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(170, 279);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(769, 112);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATA KINERJA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(192, 59);
            label7.Name = "label7";
            label7.Size = new Size(166, 15);
            label7.TabIndex = 6;
            label7.Text = "(Jumlah bug yang ditemukan)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(192, 30);
            label4.Name = "label4";
            label4.Size = new Size(164, 15);
            label4.TabIndex = 5;
            label4.Text = "(Jumlah fitur yang dikerjakan)";
            // 
            // txtBug
            // 
            txtBug.Location = new Point(139, 51);
            txtBug.Name = "txtBug";
            txtBug.Size = new Size(47, 23);
            txtBug.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(8, 48);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 3;
            label5.Text = "Jumlah Bug        :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(8, 25);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 2;
            label6.Text = "Fitur Selesai       :\r\n";
            // 
            // txtFitur
            // 
            txtFitur.Location = new Point(139, 22);
            txtFitur.Name = "txtFitur";
            txtFitur.Size = new Size(47, 23);
            txtFitur.TabIndex = 1;
            // 
            // InsertBtn
            // 
            InsertBtn.Location = new Point(170, 414);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(163, 40);
            InsertBtn.TabIndex = 7;
            InsertBtn.Text = "INSERT";
            InsertBtn.UseVisualStyleBackColor = true;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(374, 414);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(163, 40);
            UpdateBtn.TabIndex = 8;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(582, 414);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(163, 40);
            DeleteBtn.TabIndex = 9;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DGV);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(170, 472);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(772, 200);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "DAFTAR PERFORMA TIM";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(229, 64);
            label8.Name = "label8";
            label8.Size = new Size(104, 45);
            label8.TabIndex = 11;
            label8.Text = "LOGO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(462, 129);
            label9.Name = "label9";
            label9.Size = new Size(267, 21);
            label9.TabIndex = 12;
            label9.Text = "Developer Team Performance Tracker";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(514, 89);
            label10.Name = "label10";
            label10.Size = new Size(172, 40);
            label10.TabIndex = 13;
            label10.Text = "JUDUL APP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 684);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(groupBox3);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(InsertBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private TextBox txtNama;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cmbStatus;
        private ComboBox cmbProyek;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label7;
        private Label label4;
        private TextBox txtBug;
        private Label label5;
        private Label label6;
        private TextBox txtFitur;
        private Button InsertBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private GroupBox groupBox3;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
