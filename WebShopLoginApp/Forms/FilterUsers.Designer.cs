namespace WebShopLoginApp
{
    partial class frmFilterUsers
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
            this.FilterUsers = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterUsers
            // 
            this.FilterUsers.FormattingEnabled = true;
            this.FilterUsers.ItemHeight = 16;
            this.FilterUsers.Location = new System.Drawing.Point(60, 171);
            this.FilterUsers.Name = "FilterUsers";
            this.FilterUsers.Size = new System.Drawing.Size(305, 340);
            this.FilterUsers.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(695, 504);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 29);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(160, 90);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(205, 22);
            this.txtLastName.TabIndex = 19;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(57, 93);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 20;
            this.lblLastName.Text = "Last Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 57);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(329, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Filter Users";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(60, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(305, 29);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmFilterUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 562);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.FilterUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFilterUsers";
            this.Text = "FilterUsers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FilterUsers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
    }
}