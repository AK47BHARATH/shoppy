
namespace shoppy
{
    partial class frmUserDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripTOP = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAPPFName = new System.Windows.Forms.Label();
            this.lblLoggedinuser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblfooter = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.menustripTOP});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1323, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.salesToolStripMenuItem.Text = "Sales ";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // menustripTOP
            // 
            this.menustripTOP.Name = "menustripTOP";
            this.menustripTOP.Size = new System.Drawing.Size(69, 20);
            this.menustripTOP.Text = "Inventory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(464, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Billing and Inventory Management";
            // 
            // lblAPPFName
            // 
            this.lblAPPFName.AutoSize = true;
            this.lblAPPFName.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPPFName.ForeColor = System.Drawing.Color.Crimson;
            this.lblAPPFName.Location = new System.Drawing.Point(439, 270);
            this.lblAPPFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAPPFName.Name = "lblAPPFName";
            this.lblAPPFName.Size = new System.Drawing.Size(664, 82);
            this.lblAPPFName.TabIndex = 10;
            this.lblAPPFName.Text = "ZIGMA SHOPPY";
            this.lblAPPFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoggedinuser
            // 
            this.lblLoggedinuser.AutoSize = true;
            this.lblLoggedinuser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedinuser.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblLoggedinuser.Location = new System.Drawing.Point(61, 36);
            this.lblLoggedinuser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoggedinuser.Name = "lblLoggedinuser";
            this.lblLoggedinuser.Size = new System.Drawing.Size(116, 25);
            this.lblLoggedinuser.TabIndex = 9;
            this.lblLoggedinuser.Text = "A K Bharath";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.DeepPink;
            this.lblUser.Location = new System.Drawing.Point(5, 32);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(63, 30);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "User:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblfooter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 522);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 39);
            this.panel1.TabIndex = 7;
            // 
            // lblfooter
            // 
            this.lblfooter.AutoSize = true;
            this.lblfooter.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfooter.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblfooter.Location = new System.Drawing.Point(362, 12);
            this.lblfooter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfooter.Name = "lblfooter";
            this.lblfooter.Size = new System.Drawing.Size(225, 19);
            this.lblfooter.TabIndex = 0;
            this.lblfooter.Text = "Developed by: A K Barath";
            // 
            // frmUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1323, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAPPFName);
            this.Controls.Add(this.lblLoggedinuser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menustripTOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAPPFName;
        private System.Windows.Forms.Label lblLoggedinuser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblfooter;
    }
}