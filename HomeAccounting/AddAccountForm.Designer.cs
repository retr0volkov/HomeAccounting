namespace HomeAccounting
{
    partial class AddAccountForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.labelInitialBalance = new System.Windows.Forms.Label();
            this.numericUpDownInitialBalance = new System.Windows.Forms.NumericUpDown();
            this.labelAccountType = new System.Windows.Forms.Label();
            this.textBoxAccountType = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInitialBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя Аккаунта:";
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Location = new System.Drawing.Point(124, 12);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(186, 20);
            this.textBoxAccountName.TabIndex = 1;
            // 
            // labelInitialBalance
            // 
            this.labelInitialBalance.AutoSize = true;
            this.labelInitialBalance.Location = new System.Drawing.Point(12, 45);
            this.labelInitialBalance.Name = "labelInitialBalance";
            this.labelInitialBalance.Size = new System.Drawing.Size(106, 13);
            this.labelInitialBalance.TabIndex = 2;
            this.labelInitialBalance.Text = "Начальный баланс:";
            // 
            // numericUpDownInitialBalance
            // 
            this.numericUpDownInitialBalance.DecimalPlaces = 2;
            this.numericUpDownInitialBalance.Location = new System.Drawing.Point(124, 43);
            this.numericUpDownInitialBalance.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownInitialBalance.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDownInitialBalance.Name = "numericUpDownInitialBalance";
            this.numericUpDownInitialBalance.Size = new System.Drawing.Size(106, 20);
            this.numericUpDownInitialBalance.TabIndex = 3;
            // 
            // labelAccountType
            // 
            this.labelAccountType.AutoSize = true;
            this.labelAccountType.Location = new System.Drawing.Point(12, 75);
            this.labelAccountType.Name = "labelAccountType";
            this.labelAccountType.Size = new System.Drawing.Size(79, 13);
            this.labelAccountType.TabIndex = 4;
            this.labelAccountType.Text = "Тип Аккаунта:";
            // 
            // textBoxAccountType
            // 
            this.textBoxAccountType.Location = new System.Drawing.Point(124, 72);
            this.textBoxAccountType.Name = "textBoxAccountType";
            this.textBoxAccountType.Size = new System.Drawing.Size(186, 20);
            this.textBoxAccountType.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(154, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddAccountForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(334, 151);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxAccountType);
            this.Controls.Add(this.labelAccountType);
            this.Controls.Add(this.numericUpDownInitialBalance);
            this.Controls.Add(this.labelInitialBalance);
            this.Controls.Add(this.textBoxAccountName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить Новый Аккаунт";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInitialBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAccountName;
        private System.Windows.Forms.Label labelInitialBalance;
        private System.Windows.Forms.NumericUpDown numericUpDownInitialBalance;
        private System.Windows.Forms.Label labelAccountType;
        private System.Windows.Forms.TextBox textBoxAccountType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}