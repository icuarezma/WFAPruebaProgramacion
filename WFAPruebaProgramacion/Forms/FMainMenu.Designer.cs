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
            tabControl1 = new TabControl();
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
            tabControl1.SuspendLayout();
            tabPageUserManagement.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
            panel1.SuspendLayout();
            formPane.SuspendLayout();
            formMainPane.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageUserManagement);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(847, 499);
            tabControl1.TabIndex = 0;
            // 
            // tabPageUserManagement
            // 
            tabPageUserManagement.Controls.Add(panel2);
            tabPageUserManagement.Controls.Add(panel1);
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
            ClientSize = new Size(847, 499);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "FMainMenu";
            Text = "Menú Principal";
            WindowState = FormWindowState.Maximized;
            Load += FMainMenu_Load;
            tabControl1.ResumeLayout(false);
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

        private TabControl tabControl1;
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
    }
}