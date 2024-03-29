
namespace Tyuiu.RazumovMO.Sprint7.Project.V5
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ButtonNamedInfo_RMO = new System.Windows.Forms.Button();
            this.ButtonNamedProducts_rmo = new System.Windows.Forms.Button();
            this.ButtonNamedProviders_rmo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ButtonNamedAddProduct_rmo = new System.Windows.Forms.Button();
            this.ButtonNamedAddProviders_rmo = new System.Windows.Forms.Button();
            this.ButtonNamedChangeTime_rmo = new System.Windows.Forms.Button();
            this.ButtonNamedDeleteProviderOrProduct_rmo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonNamedInfo_RMO
            // 
            this.ButtonNamedInfo_RMO.Location = new System.Drawing.Point(2, 2);
            this.ButtonNamedInfo_RMO.Name = "ButtonNamedInfo_RMO";
            this.ButtonNamedInfo_RMO.Size = new System.Drawing.Size(64, 26);
            this.ButtonNamedInfo_RMO.TabIndex = 0;
            this.ButtonNamedInfo_RMO.Text = "Справка";
            this.ButtonNamedInfo_RMO.UseVisualStyleBackColor = true;
            this.ButtonNamedInfo_RMO.Click += new System.EventHandler(this.ButtonNamedInfo_RMO_Click);
            // 
            // ButtonNamedProducts_rmo
            // 
            this.ButtonNamedProducts_rmo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonNamedProducts_rmo.Location = new System.Drawing.Point(307, 34);
            this.ButtonNamedProducts_rmo.Name = "ButtonNamedProducts_rmo";
            this.ButtonNamedProducts_rmo.Size = new System.Drawing.Size(141, 54);
            this.ButtonNamedProducts_rmo.TabIndex = 1;
            this.ButtonNamedProducts_rmo.Text = "Товары";
            this.ButtonNamedProducts_rmo.UseVisualStyleBackColor = false;
            this.ButtonNamedProducts_rmo.Click += new System.EventHandler(this.ButtonNamedProducts_rmo_Click);
            // 
            // ButtonNamedProviders_rmo
            // 
            this.ButtonNamedProviders_rmo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonNamedProviders_rmo.Location = new System.Drawing.Point(95, 34);
            this.ButtonNamedProviders_rmo.Name = "ButtonNamedProviders_rmo";
            this.ButtonNamedProviders_rmo.Size = new System.Drawing.Size(141, 54);
            this.ButtonNamedProviders_rmo.TabIndex = 3;
            this.ButtonNamedProviders_rmo.Text = "Поставщики";
            this.ButtonNamedProviders_rmo.UseVisualStyleBackColor = false;
            this.ButtonNamedProviders_rmo.Click += new System.EventHandler(this.ButtonNamedProviders_rmo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ButtonNamedAddProduct_rmo
            // 
            this.ButtonNamedAddProduct_rmo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonNamedAddProduct_rmo.Location = new System.Drawing.Point(307, 143);
            this.ButtonNamedAddProduct_rmo.Name = "ButtonNamedAddProduct_rmo";
            this.ButtonNamedAddProduct_rmo.Size = new System.Drawing.Size(141, 54);
            this.ButtonNamedAddProduct_rmo.TabIndex = 4;
            this.ButtonNamedAddProduct_rmo.Text = "Добавить товар";
            this.ButtonNamedAddProduct_rmo.UseVisualStyleBackColor = false;
            this.ButtonNamedAddProduct_rmo.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonNamedAddProviders_rmo
            // 
            this.ButtonNamedAddProviders_rmo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonNamedAddProviders_rmo.Location = new System.Drawing.Point(95, 143);
            this.ButtonNamedAddProviders_rmo.Name = "ButtonNamedAddProviders_rmo";
            this.ButtonNamedAddProviders_rmo.Size = new System.Drawing.Size(141, 54);
            this.ButtonNamedAddProviders_rmo.TabIndex = 5;
            this.ButtonNamedAddProviders_rmo.Text = "Добавить поставщика";
            this.ButtonNamedAddProviders_rmo.UseVisualStyleBackColor = false;
            this.ButtonNamedAddProviders_rmo.Click += new System.EventHandler(this.ButtonNamedAddProviders_rmo_Click);
            // 
            // ButtonNamedChangeTime_rmo
            // 
            this.ButtonNamedChangeTime_rmo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonNamedChangeTime_rmo.Location = new System.Drawing.Point(524, 143);
            this.ButtonNamedChangeTime_rmo.Name = "ButtonNamedChangeTime_rmo";
            this.ButtonNamedChangeTime_rmo.Size = new System.Drawing.Size(141, 54);
            this.ButtonNamedChangeTime_rmo.TabIndex = 6;
            this.ButtonNamedChangeTime_rmo.Text = "Изменить срок поставки";
            this.ButtonNamedChangeTime_rmo.UseVisualStyleBackColor = false;
            this.ButtonNamedChangeTime_rmo.Click += new System.EventHandler(this.ButtonNamedChangeTime_rmo_Click);
            // 
            // ButtonNamedDeleteProviderOrProduct_rmo
            // 
            this.ButtonNamedDeleteProviderOrProduct_rmo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonNamedDeleteProviderOrProduct_rmo.Location = new System.Drawing.Point(521, 34);
            this.ButtonNamedDeleteProviderOrProduct_rmo.Name = "ButtonNamedDeleteProviderOrProduct_rmo";
            this.ButtonNamedDeleteProviderOrProduct_rmo.Size = new System.Drawing.Size(144, 54);
            this.ButtonNamedDeleteProviderOrProduct_rmo.TabIndex = 7;
            this.ButtonNamedDeleteProviderOrProduct_rmo.Text = "Удалить поставщика\\товар";
            this.ButtonNamedDeleteProviderOrProduct_rmo.UseVisualStyleBackColor = false;
            this.ButtonNamedDeleteProviderOrProduct_rmo.Click += new System.EventHandler(this.ButtonNamedDeleteProviderOrProduct_rmo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonNamedDeleteProviderOrProduct_rmo);
            this.Controls.Add(this.ButtonNamedChangeTime_rmo);
            this.Controls.Add(this.ButtonNamedAddProviders_rmo);
            this.Controls.Add(this.ButtonNamedAddProduct_rmo);
            this.Controls.Add(this.ButtonNamedProviders_rmo);
            this.Controls.Add(this.ButtonNamedProducts_rmo);
            this.Controls.Add(this.ButtonNamedInfo_RMO);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Оптовая база";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonNamedInfo_RMO;
        private System.Windows.Forms.Button ButtonNamedProducts_rmo;
        private System.Windows.Forms.Button ButtonNamedProviders_rmo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ButtonNamedAddProduct_rmo;
        private System.Windows.Forms.Button ButtonNamedAddProviders_rmo;
        private System.Windows.Forms.Button ButtonNamedChangeTime_rmo;
        private System.Windows.Forms.Button ButtonNamedDeleteProviderOrProduct_rmo;
    }
}

