namespace WFAPruebaProgramacion.Forms
{
    partial class FMainMenu
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
            tabControlMain = new TabControl();
            tabPageProducts = new TabPage();
            panel6 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            pbImage = new PictureBox();
            paneMainCenterProductos = new Panel();
            panel5 = new Panel();
            dgvProducts = new DataGridView();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            checkStateFilterByName = new CheckBox();
            txtFilterByName = new TextBox();
            groupBox2 = new GroupBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            rbActives = new RadioButton();
            rbInactives = new RadioButton();
            rbAllByState = new RadioButton();
            tabPageUserManagement = new TabPage();
            panel2 = new Panel();
            panel3 = new Panel();
            dgUsers = new DataGridView();
            panel1 = new Panel();
            formPane = new TableLayoutPanel();
            btnAddUser = new Button();
            formMainPane = new TableLayoutPanel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtName = new TextBox();
            txtLastname = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            checkFormEnabled = new CheckBox();
            lblWarning = new Label();
            tabControlMain.SuspendLayout();
            tabPageProducts.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            paneMainCenterProductos.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            tabPageUserManagement.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
            panel1.SuspendLayout();
            formPane.SuspendLayout();
            formMainPane.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageProducts);
            tabControlMain.Controls.Add(tabPageUserManagement);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(847, 499);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageProducts
            // 
            tabPageProducts.Controls.Add(panel6);
            tabPageProducts.Controls.Add(paneMainCenterProductos);
            tabPageProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPageProducts.Location = new Point(4, 24);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new Padding(3);
            tabPageProducts.Size = new Size(839, 471);
            tabPageProducts.TabIndex = 1;
            tabPageProducts.Text = "Productos";
            tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel2);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(3, 192);
            panel6.Name = "panel6";
            panel6.Size = new Size(833, 276);
            panel6.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(833, 276);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pbImage);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(410, 270);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Imagen";
            // 
            // pbImage
            // 
            pbImage.Dock = DockStyle.Fill;
            pbImage.Location = new Point(3, 25);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(404, 242);
            pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // paneMainCenterProductos
            // 
            paneMainCenterProductos.Controls.Add(panel5);
            paneMainCenterProductos.Controls.Add(panel4);
            paneMainCenterProductos.Dock = DockStyle.Fill;
            paneMainCenterProductos.Location = new Point(3, 3);
            paneMainCenterProductos.Name = "paneMainCenterProductos";
            paneMainCenterProductos.Size = new Size(833, 465);
            paneMainCenterProductos.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvProducts);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 94);
            panel5.Name = "panel5";
            panel5.Size = new Size(833, 371);
            panel5.TabIndex = 3;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.Size = new Size(833, 260);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellMouseClick += dgvProducts_CellMouseClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(833, 94);
            panel4.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(833, 94);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por Nombre";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(checkStateFilterByName);
            flowLayoutPanel2.Controls.Add(txtFilterByName);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 25);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(404, 60);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // checkStateFilterByName
            // 
            checkStateFilterByName.Anchor = AnchorStyles.Left;
            checkStateFilterByName.AutoSize = true;
            checkStateFilterByName.Location = new Point(3, 10);
            checkStateFilterByName.Name = "checkStateFilterByName";
            checkStateFilterByName.Size = new Size(15, 14);
            checkStateFilterByName.TabIndex = 1;
            checkStateFilterByName.UseVisualStyleBackColor = true;
            checkStateFilterByName.CheckedChanged += checkStateFilterByName_CheckedChanged;
            // 
            // txtFilterByName
            // 
            txtFilterByName.Anchor = AnchorStyles.None;
            txtFilterByName.Enabled = false;
            txtFilterByName.Location = new Point(24, 3);
            txtFilterByName.Name = "txtFilterByName";
            txtFilterByName.PlaceholderText = "Buscar";
            txtFilterByName.Size = new Size(200, 29);
            txtFilterByName.TabIndex = 0;
            txtFilterByName.TextChanged += txtFilterByName_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(419, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(411, 88);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtrar por Estado";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(rbActives);
            flowLayoutPanel3.Controls.Add(rbInactives);
            flowLayoutPanel3.Controls.Add(rbAllByState);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 25);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(405, 60);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // rbActives
            // 
            rbActives.AutoSize = true;
            rbActives.Location = new Point(3, 3);
            rbActives.Name = "rbActives";
            rbActives.Size = new Size(82, 25);
            rbActives.TabIndex = 0;
            rbActives.Text = "Activos";
            rbActives.UseVisualStyleBackColor = true;
            rbActives.CheckedChanged += rbActives_CheckedChanged;
            // 
            // rbInactives
            // 
            rbInactives.AutoSize = true;
            rbInactives.Location = new Point(91, 3);
            rbInactives.Name = "rbInactives";
            rbInactives.Size = new Size(93, 25);
            rbInactives.TabIndex = 1;
            rbInactives.Text = "Inactivos";
            rbInactives.UseVisualStyleBackColor = true;
            rbInactives.CheckedChanged += rbInactives_CheckedChanged;
            // 
            // rbAllByState
            // 
            rbAllByState.AutoSize = true;
            rbAllByState.Checked = true;
            rbAllByState.Location = new Point(190, 3);
            rbAllByState.Name = "rbAllByState";
            rbAllByState.Size = new Size(72, 25);
            rbAllByState.TabIndex = 2;
            rbAllByState.TabStop = true;
            rbAllByState.Text = "Todos";
            rbAllByState.UseVisualStyleBackColor = true;
            rbAllByState.CheckedChanged += rbAllByState_CheckedChanged;
            // 
            // tabPageUserManagement
            // 
            tabPageUserManagement.Controls.Add(panel2);
            tabPageUserManagement.Controls.Add(panel1);
            tabPageUserManagement.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPageUserManagement.ImageKey = "(none)";
            tabPageUserManagement.Location = new Point(4, 24);
            tabPageUserManagement.Name = "tabPageUserManagement";
            tabPageUserManagement.Padding = new Padding(3);
            tabPageUserManagement.Size = new Size(839, 471);
            tabPageUserManagement.TabIndex = 0;
            tabPageUserManagement.Text = "Usuarios";
            tabPageUserManagement.ToolTipText = "Ventana de Administración de Usuarios";
            tabPageUserManagement.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 274);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgUsers);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(833, 274);
            panel3.TabIndex = 1;
            // 
            // dgUsers
            // 
            dgUsers.AllowUserToAddRows = false;
            dgUsers.AllowUserToDeleteRows = false;
            dgUsers.AllowUserToResizeColumns = false;
            dgUsers.AllowUserToResizeRows = false;
            dgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsers.Dock = DockStyle.Fill;
            dgUsers.Location = new Point(0, 0);
            dgUsers.Name = "dgUsers";
            dgUsers.ReadOnly = true;
            dgUsers.Size = new Size(833, 274);
            dgUsers.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(formPane);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 191);
            panel1.TabIndex = 0;
            // 
            // formPane
            // 
            formPane.ColumnCount = 2;
            formPane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            formPane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            formPane.Controls.Add(btnAddUser, 1, 0);
            formPane.Controls.Add(formMainPane, 0, 0);
            formPane.Dock = DockStyle.Fill;
            formPane.Location = new Point(0, 0);
            formPane.Name = "formPane";
            formPane.RowCount = 1;
            formPane.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            formPane.Size = new Size(833, 191);
            formPane.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.None;
            btnAddUser.BackColor = Color.MidnightBlue;
            btnAddUser.Enabled = false;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = SystemColors.Control;
            btnAddUser.Location = new Point(656, 74);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(103, 43);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Agregar";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // formMainPane
            // 
            formMainPane.ColumnCount = 2;
            formMainPane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            formMainPane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            formMainPane.Controls.Add(txtUsername, 0, 1);
            formMainPane.Controls.Add(txtPassword, 1, 1);
            formMainPane.Controls.Add(txtName, 0, 2);
            formMainPane.Controls.Add(txtLastname, 1, 2);
            formMainPane.Controls.Add(txtEmail, 0, 3);
            formMainPane.Controls.Add(txtPhone, 1, 3);
            formMainPane.Controls.Add(checkFormEnabled, 0, 0);
            formMainPane.Controls.Add(lblWarning, 1, 0);
            formMainPane.Dock = DockStyle.Fill;
            formMainPane.Location = new Point(3, 3);
            formMainPane.Name = "formMainPane";
            formMainPane.RowCount = 4;
            formMainPane.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            formMainPane.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            formMainPane.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            formMainPane.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            formMainPane.Size = new Size(577, 185);
            formMainPane.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Segoe UI", 11.25F);
            txtUsername.Location = new Point(3, 55);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Nombre de Usuario";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left;
            txtPassword.Enabled = false;
            txtPassword.Font = new Font("Segoe UI", 11.25F);
            txtPassword.Location = new Point(291, 55);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left;
            txtName.Enabled = false;
            txtName.Font = new Font("Segoe UI", 11.25F);
            txtName.Location = new Point(3, 101);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nombre";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 2;
            // 
            // txtLastname
            // 
            txtLastname.Anchor = AnchorStyles.Left;
            txtLastname.Enabled = false;
            txtLastname.Font = new Font("Segoe UI", 11.25F);
            txtLastname.Location = new Point(291, 101);
            txtLastname.Name = "txtLastname";
            txtLastname.PlaceholderText = "Apellido";
            txtLastname.Size = new Size(200, 27);
            txtLastname.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left;
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(3, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Correo Electrónico";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Left;
            txtPhone.Enabled = false;
            txtPhone.Font = new Font("Segoe UI", 11.25F);
            txtPhone.Location = new Point(291, 148);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Teléfono";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 5;
            // 
            // checkFormEnabled
            // 
            checkFormEnabled.Anchor = AnchorStyles.Left;
            checkFormEnabled.AutoSize = true;
            checkFormEnabled.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkFormEnabled.Location = new Point(3, 10);
            checkFormEnabled.Name = "checkFormEnabled";
            checkFormEnabled.Size = new Size(154, 25);
            checkFormEnabled.TabIndex = 6;
            checkFormEnabled.Text = "Registrar Usuario";
            checkFormEnabled.UseVisualStyleBackColor = true;
            checkFormEnabled.CheckedChanged += checkFormEnabled_CheckedChanged;
            // 
            // lblWarning
            // 
            lblWarning.Anchor = AnchorStyles.Left;
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(291, 13);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(48, 20);
            lblWarning.TabIndex = 7;
            lblWarning.Text = "label1";
            lblWarning.Visible = false;
            // 
            // FMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(847, 499);
            Controls.Add(tabControlMain);
            Name = "FMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            WindowState = FormWindowState.Maximized;
            tabControlMain.ResumeLayout(false);
            tabPageProducts.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            paneMainCenterProductos.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            tabPageUserManagement.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
            panel1.ResumeLayout(false);
            formPane.ResumeLayout(false);
            formMainPane.ResumeLayout(false);
            formMainPane.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageUserManagement;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private DataGridView dgUsers;
        private TableLayoutPanel formPane;
        private Button btnAddUser;
        private TableLayoutPanel formMainPane;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtName;
        private TextBox txtLastname;
        private CheckBox checkFormEnabled;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label lblWarning;
        private TabPage tabPageProducts;
        private Panel paneMainCenterProductos;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dgvProducts;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox txtFilterByName;
        private GroupBox groupBox2;
        private CheckBox checkStateFilterByName;
        private FlowLayoutPanel flowLayoutPanel3;
        private RadioButton rbActives;
        private RadioButton rbInactives;
        private RadioButton rbAllByState;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox3;
        private PictureBox pbImage;
    }
}