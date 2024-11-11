namespace SystemLibrary
{
    partial class remove
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Book_data1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.book_id = new System.Windows.Forms.TextBox();
            this.book_isbn = new System.Windows.Forms.TextBox();
            this.deletebook_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.book_author = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.book_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refresh_bt = new System.Windows.Forms.Button();
            this.searchtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Book_data1)).BeginInit();
            this.SuspendLayout();
            // 
            // Book_data1
            // 
            this.Book_data1.BackgroundColor = System.Drawing.Color.White;
            this.Book_data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Book_data1.Location = new System.Drawing.Point(66, 61);
            this.Book_data1.Name = "Book_data1";
            this.Book_data1.ReadOnly = true;
            this.Book_data1.Size = new System.Drawing.Size(557, 184);
            this.Book_data1.TabIndex = 2;
            this.Book_data1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Book_data1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Book ID         ";
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(189, 274);
            this.book_id.Multiline = true;
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(226, 20);
            this.book_id.TabIndex = 21;
            // 
            // book_isbn
            // 
            this.book_isbn.Location = new System.Drawing.Point(189, 394);
            this.book_isbn.Multiline = true;
            this.book_isbn.Name = "book_isbn";
            this.book_isbn.Size = new System.Drawing.Size(226, 20);
            this.book_isbn.TabIndex = 20;
            // 
            // deletebook_btn
            // 
            this.deletebook_btn.BackColor = System.Drawing.Color.Red;
            this.deletebook_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebook_btn.ForeColor = System.Drawing.Color.White;
            this.deletebook_btn.Location = new System.Drawing.Point(66, 437);
            this.deletebook_btn.Name = "deletebook_btn";
            this.deletebook_btn.Size = new System.Drawing.Size(92, 37);
            this.deletebook_btn.TabIndex = 19;
            this.deletebook_btn.Text = "Delete";
            this.deletebook_btn.UseVisualStyleBackColor = false;
            this.deletebook_btn.Click += new System.EventHandler(this.deletebook_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Book ISBN     ";
            // 
            // book_author
            // 
            this.book_author.Location = new System.Drawing.Point(189, 352);
            this.book_author.Multiline = true;
            this.book_author.Name = "book_author";
            this.book_author.Size = new System.Drawing.Size(226, 20);
            this.book_author.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Book Author  ";
            // 
            // book_title
            // 
            this.book_title.Location = new System.Drawing.Point(189, 314);
            this.book_title.Multiline = true;
            this.book_title.Name = "book_title";
            this.book_title.Size = new System.Drawing.Size(226, 20);
            this.book_title.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Book Title     ";
            // 
            // refresh_bt
            // 
            this.refresh_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.refresh_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_bt.ForeColor = System.Drawing.Color.White;
            this.refresh_bt.Location = new System.Drawing.Point(189, 437);
            this.refresh_bt.Name = "refresh_bt";
            this.refresh_bt.Size = new System.Drawing.Size(92, 37);
            this.refresh_bt.TabIndex = 23;
            this.refresh_bt.Text = "Refresh";
            this.refresh_bt.UseVisualStyleBackColor = false;
            this.refresh_bt.Click += new System.EventHandler(this.refresh_bt_Click);
            // 
            // searchtext
            // 
            this.searchtext.Location = new System.Drawing.Point(215, 23);
            this.searchtext.Multiline = true;
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(185, 20);
            this.searchtext.TabIndex = 25;
            this.searchtext.TextChanged += new System.EventHandler(this.searchtext_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Book Title     ";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Gray;
            this.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(422, 23);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(92, 22);
            this.search_btn.TabIndex = 26;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemLibrary.Properties.Resources.leaf_1676640_19201;
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh_bt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.book_id);
            this.Controls.Add(this.book_isbn);
            this.Controls.Add(this.deletebook_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.book_author);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.book_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Book_data1);
            this.Name = "remove";
            this.Size = new System.Drawing.Size(678, 488);
            this.Load += new System.EventHandler(this.remove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Book_data1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Book_data1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.TextBox book_isbn;
        private System.Windows.Forms.Button deletebook_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox book_author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox book_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refresh_bt;
        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_btn;
    }
}
