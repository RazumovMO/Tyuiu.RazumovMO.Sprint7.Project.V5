
namespace Tyuiu.RazumovMO.Sprint7.Project.V5
{
    partial class FormProvOrProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProvOrProd));
            this.ButtonNamedDeleteProd_rmo = new System.Windows.Forms.Button();
            this.ButtonNamedDeleteProv_rmo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonNamedDeleteProd_rmo
            // 
            this.ButtonNamedDeleteProd_rmo.Location = new System.Drawing.Point(52, 25);
            this.ButtonNamedDeleteProd_rmo.Name = "ButtonNamedDeleteProd_rmo";
            this.ButtonNamedDeleteProd_rmo.Size = new System.Drawing.Size(133, 48);
            this.ButtonNamedDeleteProd_rmo.TabIndex = 0;
            this.ButtonNamedDeleteProd_rmo.Text = "Удалить товары";
            this.ButtonNamedDeleteProd_rmo.UseVisualStyleBackColor = true;
            this.ButtonNamedDeleteProd_rmo.Click += new System.EventHandler(this.ButtonNamedDeleteProd_rmo_Click);
            // 
            // ButtonNamedDeleteProv_rmo
            // 
            this.ButtonNamedDeleteProv_rmo.Location = new System.Drawing.Point(52, 121);
            this.ButtonNamedDeleteProv_rmo.Name = "ButtonNamedDeleteProv_rmo";
            this.ButtonNamedDeleteProv_rmo.Size = new System.Drawing.Size(133, 46);
            this.ButtonNamedDeleteProv_rmo.TabIndex = 1;
            this.ButtonNamedDeleteProv_rmo.Text = "Удалить поставщиков";
            this.ButtonNamedDeleteProv_rmo.UseVisualStyleBackColor = true;
            this.ButtonNamedDeleteProv_rmo.Click += new System.EventHandler(this.ButtonNamedDeleteProv_rmo_Click);
            // 
            // FormProvOrProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 217);
            this.Controls.Add(this.ButtonNamedDeleteProv_rmo);
            this.Controls.Add(this.ButtonNamedDeleteProd_rmo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProvOrProd";
            this.Text = "DeleteMenu";
            this.Load += new System.EventHandler(this.FormProvOrProd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonNamedDeleteProd_rmo;
        private System.Windows.Forms.Button ButtonNamedDeleteProv_rmo;
    }
}