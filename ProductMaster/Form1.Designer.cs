namespace ProductMaster
{
    partial class Form1
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
            this.btnProductMaster = new System.Windows.Forms.Button();
            this.btnProductType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductMaster
            // 
            this.btnProductMaster.Location = new System.Drawing.Point(25, 79);
            this.btnProductMaster.Name = "btnProductMaster";
            this.btnProductMaster.Size = new System.Drawing.Size(85, 65);
            this.btnProductMaster.TabIndex = 0;
            this.btnProductMaster.Text = "Product Master";
            this.btnProductMaster.UseVisualStyleBackColor = true;
            this.btnProductMaster.Click += new System.EventHandler(this.btnProductMaster_Click);
            // 
            // btnProductType
            // 
            this.btnProductType.Location = new System.Drawing.Point(157, 79);
            this.btnProductType.Name = "btnProductType";
            this.btnProductType.Size = new System.Drawing.Size(86, 65);
            this.btnProductType.TabIndex = 1;
            this.btnProductType.Text = "Product Type";
            this.btnProductType.UseVisualStyleBackColor = true;
            this.btnProductType.Click += new System.EventHandler(this.btnProductType_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnProductType);
            this.Controls.Add(this.btnProductMaster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductMaster;
        private System.Windows.Forms.Button btnProductType;
    }
}

