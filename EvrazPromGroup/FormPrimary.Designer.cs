namespace EvrazPromGroup
{
    partial class FormPrimary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrimary));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonaEmployees = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.labelChildForm = new System.Windows.Forms.Label();
            this.panelDesk = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SlateGray;
            this.panelMenu.Controls.Add(this.buttonaEmployees);
            this.panelMenu.Controls.Add(this.buttonAbout);
            this.panelMenu.Controls.Add(this.buttonOrders);
            this.panelMenu.Controls.Add(this.buttonProfile);
            this.panelMenu.Controls.Add(this.panelTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(186, 476);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonaEmployees
            // 
            this.buttonaEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonaEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaEmployees.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaEmployees.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonaEmployees.Image = global::EvrazPromGroup.Properties.Resources.Icons8_Ios7_Finance_Purchase_Order;
            this.buttonaEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonaEmployees.Location = new System.Drawing.Point(0, 182);
            this.buttonaEmployees.Name = "buttonaEmployees";
            this.buttonaEmployees.Size = new System.Drawing.Size(186, 55);
            this.buttonaEmployees.TabIndex = 5;
            this.buttonaEmployees.Text = "Employees";
            this.buttonaEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonaEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonaEmployees.UseVisualStyleBackColor = true;
            this.buttonaEmployees.Click += new System.EventHandler(this.buttonaEmployees_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAbout.Image = global::EvrazPromGroup.Properties.Resources.output_onlinepngtools;
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(0, 422);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(186, 54);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrders.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOrders.Image = global::EvrazPromGroup.Properties.Resources.Icons8_Ios7_Finance_Purchase_Order;
            this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.Location = new System.Drawing.Point(0, 127);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(186, 55);
            this.buttonOrders.TabIndex = 2;
            this.buttonOrders.Text = "Orders";
            this.buttonOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProfile.Image = global::EvrazPromGroup.Properties.Resources.output_onlinepngtools__3_;
            this.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.Location = new System.Drawing.Point(0, 72);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(186, 55);
            this.buttonProfile.TabIndex = 1;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.SlateGray;
            this.panelTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTitle.BackgroundImage")));
            this.panelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(186, 72);
            this.panelTitle.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel.Controls.Add(this.labelChildForm);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(186, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(633, 72);
            this.panel.TabIndex = 1;
            // 
            // labelChildForm
            // 
            this.labelChildForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelChildForm.AutoSize = true;
            this.labelChildForm.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChildForm.ForeColor = System.Drawing.SystemColors.Control;
            this.labelChildForm.Location = new System.Drawing.Point(234, 16);
            this.labelChildForm.Name = "labelChildForm";
            this.labelChildForm.Size = new System.Drawing.Size(185, 40);
            this.labelChildForm.TabIndex = 0;
            this.labelChildForm.Text = "EvrazPromGroup";
            this.labelChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesk
            // 
            this.panelDesk.BackColor = System.Drawing.Color.Silver;
            this.panelDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesk.Location = new System.Drawing.Point(186, 72);
            this.panelDesk.MinimumSize = new System.Drawing.Size(614, 378);
            this.panelDesk.Name = "panelDesk";
            this.panelDesk.Size = new System.Drawing.Size(633, 404);
            this.panelDesk.TabIndex = 2;
            // 
            // FormPrimary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 476);
            this.Controls.Add(this.panelDesk);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormPrimary";
            this.Text = "FormPrimary";
            this.Load += new System.EventHandler(this.FormPrimary_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelDesk;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Label labelChildForm;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonaEmployees;
    }
}