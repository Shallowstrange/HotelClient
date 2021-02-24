namespace HotelRegulator
{
    partial class RoomStatusAndInformation
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
            this.btnquery = new System.Windows.Forms.Button();
            this.txtcha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvshitu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshitu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnquery
            // 
            this.btnquery.Location = new System.Drawing.Point(469, 23);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(75, 23);
            this.btnquery.TabIndex = 0;
            this.btnquery.Text = "查询";
            this.btnquery.UseVisualStyleBackColor = true;
            this.btnquery.Click += new System.EventHandler(this.Btnquery_Click);
            // 
            // txtcha
            // 
            this.txtcha.Location = new System.Drawing.Point(351, 24);
            this.txtcha.Name = "txtcha";
            this.txtcha.Size = new System.Drawing.Size(100, 21);
            this.txtcha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "房间编号";
            // 
            // dgvshitu
            // 
            this.dgvshitu.AllowUserToAddRows = false;
            this.dgvshitu.AllowUserToDeleteRows = false;
            this.dgvshitu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvshitu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshitu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvshitu.Location = new System.Drawing.Point(12, 62);
            this.dgvshitu.Name = "dgvshitu";
            this.dgvshitu.ReadOnly = true;
            this.dgvshitu.RowTemplate.Height = 23;
            this.dgvshitu.Size = new System.Drawing.Size(759, 324);
            this.dgvshitu.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RoomNumber";
            this.Column1.HeaderText = "房间编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "RoomType";
            this.Column2.HeaderText = "房间类型";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "RoomStatus";
            this.Column3.HeaderText = "房间状态";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // RoomStatusAndInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 398);
            this.Controls.Add(this.dgvshitu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcha);
            this.Controls.Add(this.btnquery);
            this.Name = "RoomStatusAndInformation";
            this.Text = "房间状态及信息";
            this.Load += new System.EventHandler(this.RoomStatusAndInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshitu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnquery;
        private System.Windows.Forms.TextBox txtcha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvshitu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}