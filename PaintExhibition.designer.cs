
namespace FinalArt
{
    partial class PaintExhibition
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnShowPaintEx = new System.Windows.Forms.Button();
            this.btnShowExVisit = new System.Windows.Forms.Button();
            this.v_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paint_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(339, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.v_id,
            this.ex_number});
            this.dataGridView1.Location = new System.Drawing.Point(56, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 281);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paint_number,
            this.ex_num});
            this.dataGridView3.Location = new System.Drawing.Point(501, 157);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(244, 281);
            this.dataGridView3.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(82, 27);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "label1";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // btnShowPaintEx
            // 
            this.btnShowPaintEx.Location = new System.Drawing.Point(589, 122);
            this.btnShowPaintEx.Name = "btnShowPaintEx";
            this.btnShowPaintEx.Size = new System.Drawing.Size(75, 23);
            this.btnShowPaintEx.TabIndex = 5;
            this.btnShowPaintEx.Text = "button1";
            this.btnShowPaintEx.UseVisualStyleBackColor = true;
            this.btnShowPaintEx.Click += new System.EventHandler(this.btnShowPaintEx_Click);
            // 
            // btnShowExVisit
            // 
            this.btnShowExVisit.Location = new System.Drawing.Point(122, 122);
            this.btnShowExVisit.Name = "btnShowExVisit";
            this.btnShowExVisit.Size = new System.Drawing.Size(75, 23);
            this.btnShowExVisit.TabIndex = 6;
            this.btnShowExVisit.Text = "button1";
            this.btnShowExVisit.UseVisualStyleBackColor = true;
            this.btnShowExVisit.Click += new System.EventHandler(this.btnShowExVisit_Click);
            // 
            // v_id
            // 
            this.v_id.DataPropertyName = "visitorId";
            this.v_id.HeaderText = "Visitor ID";
            this.v_id.Name = "v_id";
            // 
            // ex_number
            // 
            this.ex_number.DataPropertyName = "exhibitionNo";
            this.ex_number.HeaderText = "Exhibition No.";
            this.ex_number.Name = "ex_number";
            // 
            // paint_number
            // 
            this.paint_number.DataPropertyName = "paintNumber";
            this.paint_number.HeaderText = "Paint Number";
            this.paint_number.Name = "paint_number";
            // 
            // ex_num
            // 
            this.ex_num.DataPropertyName = "exhibitionNo";
            this.ex_num.HeaderText = "Exhibition No.";
            this.ex_num.Name = "ex_num";
            // 
            // ExhibitionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowExVisit);
            this.Controls.Add(this.btnShowPaintEx);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitle);
            this.Name = "ExhibitionDetails";
            this.Text = "ExhibitionDetails";
            this.Load += new System.EventHandler(this.ExhibitionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnShowPaintEx;
        private System.Windows.Forms.Button btnShowExVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn paint_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_num;
    }
}