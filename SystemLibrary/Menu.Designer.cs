namespace SystemLibrary
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.remove_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.member_btn = new System.Windows.Forms.Button();
            this.transaction_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboard1 = new SystemLibrary.dashboard();
            this.bookAdd1 = new SystemLibrary.bookAdd();
            this.viewbook1 = new SystemLibrary.viewbook();
            this.remove1 = new SystemLibrary.remove();
            this.transactionform1 = new SystemLibrary.transactionform();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 32);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(838, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(28, 20);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Libaray System Management";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.remove_btn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.member_btn);
            this.panel2.Controls.Add(this.transaction_btn);
            this.panel2.Controls.Add(this.add_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 522);
            this.panel2.TabIndex = 1;
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.Transparent;
            this.remove_btn.FlatAppearance.BorderSize = 2;
            this.remove_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.remove_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Image = global::SystemLibrary.Properties.Resources.icons8_member_32;
            this.remove_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove_btn.Location = new System.Drawing.Point(22, 265);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(151, 50);
            this.remove_btn.TabIndex = 6;
            this.remove_btn.Text = "Remove Book";
            this.remove_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logout";
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Image = global::SystemLibrary.Properties.Resources.icons8_logout_24;
            this.logout_btn.Location = new System.Drawing.Point(12, 476);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(37, 32);
            this.logout_btn.TabIndex = 2;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // member_btn
            // 
            this.member_btn.BackColor = System.Drawing.Color.Transparent;
            this.member_btn.FlatAppearance.BorderSize = 2;
            this.member_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.member_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.member_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.member_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_btn.Image = global::SystemLibrary.Properties.Resources.icons8_member_32;
            this.member_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.member_btn.Location = new System.Drawing.Point(22, 410);
            this.member_btn.Name = "member_btn";
            this.member_btn.Size = new System.Drawing.Size(151, 50);
            this.member_btn.TabIndex = 5;
            this.member_btn.Text = "View Book    ";
            this.member_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.member_btn.UseVisualStyleBackColor = false;
            this.member_btn.Click += new System.EventHandler(this.member_btn_Click);
            // 
            // transaction_btn
            // 
            this.transaction_btn.BackColor = System.Drawing.Color.Transparent;
            this.transaction_btn.FlatAppearance.BorderSize = 2;
            this.transaction_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.transaction_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.transaction_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_btn.Image = global::SystemLibrary.Properties.Resources.icons8_transactions_32;
            this.transaction_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transaction_btn.Location = new System.Drawing.Point(22, 336);
            this.transaction_btn.Name = "transaction_btn";
            this.transaction_btn.Size = new System.Drawing.Size(151, 50);
            this.transaction_btn.TabIndex = 4;
            this.transaction_btn.Text = "Transactions ";
            this.transaction_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transaction_btn.UseVisualStyleBackColor = false;
            this.transaction_btn.Click += new System.EventHandler(this.transaction_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_btn.FlatAppearance.BorderSize = 2;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Image = global::SystemLibrary.Properties.Resources.icons8_book_32;
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.Location = new System.Drawing.Point(22, 198);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(151, 50);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Add Book    ";
            this.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_btn.FlatAppearance.BorderSize = 2;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.Image = global::SystemLibrary.Properties.Resources.icons8_dashboard_32;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(22, 132);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(151, 50);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "Dashboard  ";
            this.dashboard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SystemLibrary.Properties.Resources.icons8_library_50;
            this.pictureBox1.Location = new System.Drawing.Point(73, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard1
            // 
            this.dashboard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboard1.BackgroundImage")));
            this.dashboard1.Location = new System.Drawing.Point(202, 32);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(678, 488);
            this.dashboard1.TabIndex = 3;
            // 
            // bookAdd1
            // 
            this.bookAdd1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookAdd1.BackgroundImage")));
            this.bookAdd1.Location = new System.Drawing.Point(202, 32);
            this.bookAdd1.Name = "bookAdd1";
            this.bookAdd1.Size = new System.Drawing.Size(678, 488);
            this.bookAdd1.TabIndex = 2;
            // 
            // viewbook1
            // 
            this.viewbook1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewbook1.BackgroundImage")));
            this.viewbook1.Location = new System.Drawing.Point(202, 31);
            this.viewbook1.Name = "viewbook1";
            this.viewbook1.Size = new System.Drawing.Size(678, 488);
            this.viewbook1.TabIndex = 4;
            // 
            // remove1
            // 
            this.remove1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remove1.BackgroundImage")));
            this.remove1.Location = new System.Drawing.Point(202, 32);
            this.remove1.Name = "remove1";
            this.remove1.Size = new System.Drawing.Size(678, 488);
            this.remove1.TabIndex = 5;
            // 
            // transactionform1
            // 
            this.transactionform1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("transactionform1.BackgroundImage")));
            this.transactionform1.Location = new System.Drawing.Point(202, 32);
            this.transactionform1.Name = "transactionform1";
            this.transactionform1.Size = new System.Drawing.Size(678, 488);
            this.transactionform1.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemLibrary.Properties.Resources.leaf_1676640_1920;
            this.ClientSize = new System.Drawing.Size(880, 520);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.bookAdd1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.viewbook1);
            this.Controls.Add(this.remove1);
            this.Controls.Add(this.transactionform1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button member_btn;
        private System.Windows.Forms.Button transaction_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private bookAdd bookAdd1;
        private dashboard dashboard1;
        private viewbook viewbook1;
        private System.Windows.Forms.Button remove_btn;
        private remove remove1;
        private transactionform transactionform1;
    }
}