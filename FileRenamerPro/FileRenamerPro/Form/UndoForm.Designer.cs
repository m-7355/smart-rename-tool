namespace FileRenamerPro
{
    partial class UndoForm
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
            this.UndoResult_dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Excute_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UndoResult_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // UndoResult_dgv
            // 
            this.UndoResult_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UndoResult_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UndoResult_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UndoResult_dgv.Location = new System.Drawing.Point(9, 56);
            this.UndoResult_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UndoResult_dgv.Name = "UndoResult_dgv";
            this.UndoResult_dgv.RowHeadersWidth = 51;
            this.UndoResult_dgv.RowTemplate.Height = 24;
            this.UndoResult_dgv.Size = new System.Drawing.Size(682, 318);
            this.UndoResult_dgv.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(287, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "プレビュー表示";
            // 
            // Excute_btn
            // 
            this.Excute_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Excute_btn.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Excute_btn.Location = new System.Drawing.Point(291, 392);
            this.Excute_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Excute_btn.Name = "Excute_btn";
            this.Excute_btn.Size = new System.Drawing.Size(130, 27);
            this.Excute_btn.TabIndex = 5;
            this.Excute_btn.Text = "修復を確定する";
            this.Excute_btn.UseVisualStyleBackColor = true;
            this.Excute_btn.Click += new System.EventHandler(this.Excute_btn_Click);
            // 
            // UndoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.Excute_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UndoResult_dgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UndoForm";
            this.Text = "修復画面";
            this.Load += new System.EventHandler(this.UndoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UndoResult_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UndoResult_dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Excute_btn;
    }
}