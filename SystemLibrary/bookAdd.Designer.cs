namespace SystemLibrary
{
    partial class bookAdd
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
            this.Book_data = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.book_title = new System.Windows.Forms.TextBox();
            this.book_author = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addbook_btn = new System.Windows.Forms.Button();
            this.book_isbn = new System.Windows.Forms.TextBox();
            this.book_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.searchtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Book_data)).BeginInit();
            this.SuspendLayout();
            // 
            // Book_data
            // 
            this.Book_data.BackgroundColor = System.Drawing.Color.White;
            this.Book_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Book_data.Location = new System.Drawing.Point(66, 61);
            this.Book_data.Name = "Book_data";
            this.Book_data.ReadOnly = true;
            this.Book_data.Size = new System.Drawing.Size(557, 184);
            this.Book_data.TabIndex = 1;
            this.Book_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Book_data_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Title     ";
            // 
            // book_title
            // 
            this.book_title.Location = new System.Drawing.Point(190, 311);
            this.book_title.Multiline = true;
            this.book_title.Name = "book_title";
            this.book_title.Size = new System.Drawing.Size(226, 20);
            this.book_title.TabIndex = 3;
            // 
            // book_author
            // 
            this.book_author.Location = new System.Drawing.Point(190, 349);
            this.book_author.Multiline = true;
            this.book_author.Name = "book_author";
            this.book_author.Size = new System.Drawing.Size(226, 20);
            this.book_author.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Author  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Book ISBN     ";
            // 
            // addbook_btn
            // 
            this.addbook_btn.BackColor = System.Drawing.Color.LightCoral;
            this.addbook_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbook_btn.ForeColor = System.Drawing.Color.White;
            this.addbook_btn.Location = new System.Drawing.Point(66, 432);
            this.addbook_btn.Name = "addbook_btn";
            this.addbook_btn.Size = new System.Drawing.Size(92, 37);
            this.addbook_btn.TabIndex = 8;
            this.addbook_btn.Text = "Add";
            this.addbook_btn.UseVisualStyleBackColor = false;
            this.addbook_btn.Click += new System.EventHandler(this.addbook_btn_Click);
            // 
            // book_isbn
            // 
            this.book_isbn.Location = new System.Drawing.Point(190, 391);
            this.book_isbn.Multiline = true;
            this.book_isbn.Name = "book_isbn";
            this.book_isbn.Size = new System.Drawing.Size(226, 20);
            this.book_isbn.TabIndex = 11;
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(190, 271);
            this.book_id.Multiline = true;
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(226, 20);
            this.book_id.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Book ID         ";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Gray;
            this.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(438, 24);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(92, 22);
            this.search_btn.TabIndex = 29;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // searchtext
            // 
            this.searchtext.Location = new System.Drawing.Point(231, 24);
            this.searchtext.Multiline = true;
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(185, 20);
            this.searchtext.TabIndex = 28;
            this.searchtext.TextChanged += new System.EventHandler(this.searchtext_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Book Title     ";
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(190, 432);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(92, 37);
            this.clear_btn.TabIndex = 30;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // bookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemLibrary.Properties.Resources.leaf_1676640_19201;
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.book_id);
            this.Controls.Add(this.book_isbn);
            this.Controls.Add(this.addbook_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.book_author);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.book_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Book_data);
            this.Name = "bookAdd";
            this.Size = new System.Drawing.Size(678, 488);
            this.Load += new System.EventHandler(this.bookAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Book_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Book_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox book_title;
        private System.Windows.Forms.TextBox book_author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addbook_btn;
        private System.Windows.Forms.TextBox book_isbn;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_btn;
    }
}
