namespace OnTap
{
    partial class frmDanhBa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhBa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstSoLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.fllKey = new System.Windows.Forms.FlowLayoutPanel();
            this.bdsContact = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContact)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(123, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DANH BẠ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(95, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(377, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.dgvContact);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 279);
            this.panel1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tstSoLuong});
            this.statusStrip1.Location = new System.Drawing.Point(0, 257);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(460, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel1.Text = "Số liên hệ";
            // 
            // tstSoLuong
            // 
            this.tstSoLuong.Name = "tstSoLuong";
            this.tstSoLuong.Size = new System.Drawing.Size(19, 17);
            this.tstSoLuong.Text = "22";
            // 
            // dgvContact
            // 
            this.dgvContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContact.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.phone,
            this.email});
            this.dgvContact.Location = new System.Drawing.Point(3, 27);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.Size = new System.Drawing.Size(454, 223);
            this.dgvContact.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "Name";
            this.ten.HeaderText = "Họ Tên";
            this.ten.Name = "ten";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "PhoneNumber";
            this.phone.HeaderText = "Số điện thoại";
            this.phone.Name = "phone";
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnAdd,
            this.btnDelete,
            this.btnEdit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(460, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "Danh sách liên hệ";
            // 
            // btnAdd
            // 
            this.btnAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 22);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 22);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(46, 22);
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // fllKey
            // 
            this.fllKey.Location = new System.Drawing.Point(491, 68);
            this.fllKey.Name = "fllKey";
            this.fllKey.Size = new System.Drawing.Size(34, 313);
            this.fllKey.TabIndex = 4;
            this.fllKey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fllKey_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "UpFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDanhBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fllKey);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDanhBa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDanhBa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tstSoLuong;
        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.FlowLayoutPanel fllKey;
        private System.Windows.Forms.BindingSource bdsContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button button1;
    }
}