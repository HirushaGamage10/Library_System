namespace SystemLibrary
{
    partial class transactionform
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
            this.label1 = new System.Windows.Forms.Label();
            this.refresh_btn1 = new System.Windows.Forms.Button();
            this.transaction_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Book Transaction";
            // 
            // refresh_btn1
            // 
            this.refresh_btn1.BackColor = System.Drawing.Color.LightCoral;
            this.refresh_btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn1.ForeColor = System.Drawing.Color.White;
            this.refresh_btn1.Location = new System.Drawing.Point(548, 416);
            this.refresh_btn1.Name = "refresh_btn1";
            this.refresh_btn1.Size = new System.Drawing.Size(92, 37);
            this.refresh_btn1.TabIndex = 12;
            this.refresh_btn1.Text = "Refresh";
            this.refresh_btn1.UseVisualStyleBackColor = false;
            this.refresh_btn1.Click += new System.EventHandler(this.refresh_btn1_Click);
            // 
            // transaction_data
            // 
            this.transaction_data.BackgroundColor = System.Drawing.Color.White;
            this.transaction_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaction_data.Location = new System.Drawing.Point(39, 94);
            this.transaction_data.Name = "transaction_data";
            this.transaction_data.ReadOnly = true;
            this.transaction_data.Size = new System.Drawing.Size(601, 271);
            this.transaction_data.TabIndex = 11;
            // 
            // transactionform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemLibrary.Properties.Resources.leaf_1676640_19201;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh_btn1);
            this.Controls.Add(this.transaction_data);
            this.Name = "transactionform";
            this.Size = new System.Drawing.Size(678, 488);
            ((System.ComponentModel.ISupportInitialize)(this.transaction_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refresh_btn1;
        private System.Windows.Forms.DataGridView transaction_data;
    }
}
