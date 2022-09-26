namespace EvrazPromGroup
{
    partial class ProductForm
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCodebar = new System.Windows.Forms.Label();
            this.textBoxCodebar = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.White;
            this.buttonOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOk.Location = new System.Drawing.Point(123, 210);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(105, 38);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(234, 210);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 38);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(124, 70);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(169, 20);
            this.textBoxCustomer.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(124, 96);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(169, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomer.Location = new System.Drawing.Point(50, 70);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(68, 19);
            this.labelCustomer.TabIndex = 7;
            this.labelCustomer.Text = "Customer";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(50, 97);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 19);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(50, 123);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(60, 19);
            this.labelQuantity.TabIndex = 9;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(50, 149);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(46, 19);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "Status";
            // 
            // labelCodebar
            // 
            this.labelCodebar.AutoSize = true;
            this.labelCodebar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCodebar.Location = new System.Drawing.Point(50, 45);
            this.labelCodebar.Name = "labelCodebar";
            this.labelCodebar.Size = new System.Drawing.Size(63, 19);
            this.labelCodebar.TabIndex = 12;
            this.labelCodebar.Text = "Codebar";
            // 
            // textBoxCodebar
            // 
            this.textBoxCodebar.Location = new System.Drawing.Point(124, 44);
            this.textBoxCodebar.Name = "textBoxCodebar";
            this.textBoxCodebar.Size = new System.Drawing.Size(169, 20);
            this.textBoxCodebar.TabIndex = 13;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(123, 147);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(170, 21);
            this.comboBoxStatus.TabIndex = 14;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(124, 122);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(169, 20);
            this.numericUpDownQuantity.TabIndex = 15;
            // 
            // ProductForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(378, 282);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxCodebar);
            this.Controls.Add(this.labelCodebar);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.MaximumSize = new System.Drawing.Size(394, 321);
            this.MinimumSize = new System.Drawing.Size(394, 321);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCodebar;
        private System.Windows.Forms.TextBox textBoxCodebar;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
    }
}