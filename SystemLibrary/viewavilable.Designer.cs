namespace SystemLibrary
{
    partial class viewavilable
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataview_1 = new System.Windows.Forms.DataGridView();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.goback_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Book Details";
            // 
            // dataview_1
            // 
            this.dataview_1.BackgroundColor = System.Drawing.Color.White;
            this.dataview_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview_1.Location = new System.Drawing.Point(38, 88);
            this.dataview_1.Name = "dataview_1";
            this.dataview_1.ReadOnly = true;
            this.dataview_1.Size = new System.Drawing.Size(601, 271);
            this.dataview_1.TabIndex = 12;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.LightCoral;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(547, 410);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(92, 37);
            this.refresh_btn.TabIndex = 13;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // goback_btn
            // 
            this.goback_btn.BackColor = System.Drawing.Color.Magenta;
            this.goback_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback_btn.ForeColor = System.Drawing.Color.White;
            this.goback_btn.Location = new System.Drawing.Point(422, 410);
            this.goback_btn.Name = "goback_btn";
            this.goback_btn.Size = new System.Drawing.Size(92, 37);
            this.goback_btn.TabIndex = 14;
            this.goback_btn.Text = "Go Back";
            this.goback_btn.UseVisualStyleBackColor = false;
            this.goback_btn.Click += new System.EventHandler(this.goback_btn_Click);
            // 
            // viewavilable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemLibrary.Properties.Resources.leaf_1676640_19201;
            this.ClientSize = new System.Drawing.Size(678, 488);
            this.Controls.Add(this.goback_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.dataview_1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewavilable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewavilable";
            ((System.ComponentModel.ISupportInitialize)(this.dataview_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataview_1;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button goback_btn;
    }
}