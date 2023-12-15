namespace WFAPruebaProgramacion.Forms
{
    partial class FormAddOptions
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAccept = new Button();
            btnCancel = new Button();
            txtOptionName = new TextBox();
            txtProductName = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            rdActiveOption = new RadioButton();
            rdInactiveOption = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 3);
            tableLayoutPanel1.Controls.Add(txtOptionName, 0, 0);
            tableLayoutPanel1.Controls.Add(txtProductName, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(260, 252);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAccept);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 192);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(254, 57);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.Left;
            btnAccept.Location = new Point(3, 3);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 0;
            btnAccept.Text = "Aceptar";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left;
            btnCancel.Location = new Point(84, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtOptionName
            // 
            txtOptionName.Anchor = AnchorStyles.Left;
            txtOptionName.Location = new Point(3, 20);
            txtOptionName.Name = "txtOptionName";
            txtOptionName.PlaceholderText = "Nombre de Opción";
            txtOptionName.Size = new Size(250, 23);
            txtOptionName.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Left;
            txtProductName.Location = new Point(3, 83);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Nombre del Producto";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(250, 23);
            txtProductName.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(rdActiveOption);
            flowLayoutPanel2.Controls.Add(rdInactiveOption);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 129);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(254, 57);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // rdActiveOption
            // 
            rdActiveOption.AutoSize = true;
            rdActiveOption.Checked = true;
            rdActiveOption.Location = new Point(3, 3);
            rdActiveOption.Name = "rdActiveOption";
            rdActiveOption.Size = new Size(59, 19);
            rdActiveOption.TabIndex = 0;
            rdActiveOption.TabStop = true;
            rdActiveOption.Text = "Activo";
            rdActiveOption.UseVisualStyleBackColor = true;
            // 
            // rdInactiveOption
            // 
            rdInactiveOption.AutoSize = true;
            rdInactiveOption.Location = new Point(68, 3);
            rdInactiveOption.Name = "rdInactiveOption";
            rdInactiveOption.Size = new Size(67, 19);
            rdInactiveOption.TabIndex = 1;
            rdInactiveOption.Text = "Inactivo";
            rdInactiveOption.UseVisualStyleBackColor = true;
            // 
            // FormAddOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 252);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "FormAddOptions";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormAddOptions";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAccept;
        private Button btnCancel;
        private TextBox txtOptionName;
        private TextBox txtProductName;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton rdActiveOption;
        private RadioButton rdInactiveOption;
    }
}