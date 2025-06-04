namespace HomeAccounting
{
    partial class GreetingForm
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
            this.btnOpenApp = new System.Windows.Forms.Button();
            this.btnDocumentation = new System.Windows.Forms.Button();
            this.btnCloseMenu = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenApp
            // 
            this.btnOpenApp.Location = new System.Drawing.Point(100, 80);
            this.btnOpenApp.Name = "btnOpenApp";
            this.btnOpenApp.Size = new System.Drawing.Size(200, 35);
            this.btnOpenApp.TabIndex = 1;
            this.btnOpenApp.Text = "Открыть Приложение";
            this.btnOpenApp.UseVisualStyleBackColor = true;
            this.btnOpenApp.Click += new System.EventHandler(this.BtnOpenApp_Click);
            // 
            // btnDocumentation
            // 
            this.btnDocumentation.Location = new System.Drawing.Point(100, 130);
            this.btnDocumentation.Name = "btnDocumentation";
            this.btnDocumentation.Size = new System.Drawing.Size(200, 35);
            this.btnDocumentation.TabIndex = 2;
            this.btnDocumentation.Text = "Открыть Руководство";
            this.btnDocumentation.UseVisualStyleBackColor = true;
            this.btnDocumentation.Click += new System.EventHandler(this.BtnDocumentation_Click);
            // 
            // btnCloseMenu
            // 
            this.btnCloseMenu.Location = new System.Drawing.Point(100, 180);
            this.btnCloseMenu.Name = "btnCloseMenu";
            this.btnCloseMenu.Size = new System.Drawing.Size(200, 35);
            this.btnCloseMenu.TabIndex = 3;
            this.btnCloseMenu.Text = "Закрыть";
            this.btnCloseMenu.UseVisualStyleBackColor = true;
            this.btnCloseMenu.Click += new System.EventHandler(this.BtnCloseMenu_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(50, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(270, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Домашняя Бухгалтерия";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GreetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnOpenApp);
            this.Controls.Add(this.btnDocumentation);
            this.Controls.Add(this.btnCloseMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GreetingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenApp;
        private System.Windows.Forms.Button btnDocumentation;
        private System.Windows.Forms.Button btnCloseMenu;
        private System.Windows.Forms.Label lblWelcome;
    }
}