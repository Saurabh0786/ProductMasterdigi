﻿namespace ProductMasterdigi
{
    partial class ProductMaster
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnProductMaster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Product Type";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProductMaster
            // 
            this.btnProductMaster.Location = new System.Drawing.Point(29, 131);
            this.btnProductMaster.Name = "btnProductMaster";
            this.btnProductMaster.Size = new System.Drawing.Size(75, 48);
            this.btnProductMaster.TabIndex = 2;
            this.btnProductMaster.Text = "ProductMaster";
            this.btnProductMaster.UseVisualStyleBackColor = true;
            this.btnProductMaster.Click += new System.EventHandler(this.btnProductMaster_Click);
            // 
            // ProductMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnProductMaster);
            this.Controls.Add(this.button2);
            this.Name = "ProductMaster";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnProductMaster;
    }
}

