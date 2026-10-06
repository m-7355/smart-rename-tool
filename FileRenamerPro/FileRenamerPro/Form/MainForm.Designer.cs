namespace FileRenamerPro
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SelectFolder_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectFolderPath_txb = new System.Windows.Forms.TextBox();
            this.Preview_dgv = new System.Windows.Forms.DataGridView();
            this.SelectFolder_Group = new System.Windows.Forms.GroupBox();
            this.UpdatedRename_Group = new System.Windows.Forms.GroupBox();
            this.LastName_txb = new System.Windows.Forms.TextBox();
            this.NumberLength_txb = new System.Windows.Forms.TextBox();
            this.StartNumber_txb = new System.Windows.Forms.TextBox();
            this.FirstName_txb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Preview_bt = new System.Windows.Forms.Button();
            this.Excute_bt = new System.Windows.Forms.Button();
            this.Undo_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Preview_dgv)).BeginInit();
            this.SelectFolder_Group.SuspendLayout();
            this.UpdatedRename_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFolder_bt
            // 
            this.SelectFolder_bt.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SelectFolder_bt.Location = new System.Drawing.Point(9, 16);
            this.SelectFolder_bt.Margin = new System.Windows.Forms.Padding(2);
            this.SelectFolder_bt.Name = "SelectFolder_bt";
            this.SelectFolder_bt.Size = new System.Drawing.Size(196, 43);
            this.SelectFolder_bt.TabIndex = 0;
            this.SelectFolder_bt.Text = "フォルダ選択";
            this.SelectFolder_bt.UseVisualStyleBackColor = true;
            this.SelectFolder_bt.Click += new System.EventHandler(this.SelectFolder_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "選択されたフォルダパス";
            // 
            // SelectFolderPath_txb
            // 
            this.SelectFolderPath_txb.Location = new System.Drawing.Point(9, 98);
            this.SelectFolderPath_txb.Margin = new System.Windows.Forms.Padding(2);
            this.SelectFolderPath_txb.Name = "SelectFolderPath_txb";
            this.SelectFolderPath_txb.Size = new System.Drawing.Size(198, 19);
            this.SelectFolderPath_txb.TabIndex = 3;
            // 
            // Preview_dgv
            // 
            this.Preview_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preview_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Preview_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Preview_dgv.Location = new System.Drawing.Point(238, 8);
            this.Preview_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.Preview_dgv.Name = "Preview_dgv";
            this.Preview_dgv.RowHeadersWidth = 62;
            this.Preview_dgv.RowTemplate.Height = 27;
            this.Preview_dgv.Size = new System.Drawing.Size(490, 362);
            this.Preview_dgv.TabIndex = 4;
            // 
            // SelectFolder_Group
            // 
            this.SelectFolder_Group.Controls.Add(this.SelectFolder_bt);
            this.SelectFolder_Group.Controls.Add(this.label1);
            this.SelectFolder_Group.Controls.Add(this.SelectFolderPath_txb);
            this.SelectFolder_Group.Location = new System.Drawing.Point(8, 8);
            this.SelectFolder_Group.Margin = new System.Windows.Forms.Padding(2);
            this.SelectFolder_Group.Name = "SelectFolder_Group";
            this.SelectFolder_Group.Padding = new System.Windows.Forms.Padding(2);
            this.SelectFolder_Group.Size = new System.Drawing.Size(215, 129);
            this.SelectFolder_Group.TabIndex = 5;
            this.SelectFolder_Group.TabStop = false;
            // 
            // UpdatedRename_Group
            // 
            this.UpdatedRename_Group.Controls.Add(this.LastName_txb);
            this.UpdatedRename_Group.Controls.Add(this.NumberLength_txb);
            this.UpdatedRename_Group.Controls.Add(this.StartNumber_txb);
            this.UpdatedRename_Group.Controls.Add(this.FirstName_txb);
            this.UpdatedRename_Group.Controls.Add(this.label6);
            this.UpdatedRename_Group.Controls.Add(this.label5);
            this.UpdatedRename_Group.Controls.Add(this.label4);
            this.UpdatedRename_Group.Controls.Add(this.label3);
            this.UpdatedRename_Group.Controls.Add(this.label2);
            this.UpdatedRename_Group.Location = new System.Drawing.Point(8, 150);
            this.UpdatedRename_Group.Margin = new System.Windows.Forms.Padding(2);
            this.UpdatedRename_Group.Name = "UpdatedRename_Group";
            this.UpdatedRename_Group.Padding = new System.Windows.Forms.Padding(2);
            this.UpdatedRename_Group.Size = new System.Drawing.Size(215, 142);
            this.UpdatedRename_Group.TabIndex = 6;
            this.UpdatedRename_Group.TabStop = false;
            this.UpdatedRename_Group.Text = "ファイル名変更";
            // 
            // LastName_txb
            // 
            this.LastName_txb.Location = new System.Drawing.Point(85, 114);
            this.LastName_txb.Margin = new System.Windows.Forms.Padding(2);
            this.LastName_txb.Name = "LastName_txb";
            this.LastName_txb.Size = new System.Drawing.Size(122, 19);
            this.LastName_txb.TabIndex = 8;
            // 
            // NumberLength_txb
            // 
            this.NumberLength_txb.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.NumberLength_txb.Location = new System.Drawing.Point(85, 69);
            this.NumberLength_txb.Margin = new System.Windows.Forms.Padding(2);
            this.NumberLength_txb.Name = "NumberLength_txb";
            this.NumberLength_txb.ShortcutsEnabled = false;
            this.NumberLength_txb.Size = new System.Drawing.Size(122, 19);
            this.NumberLength_txb.TabIndex = 7;
            this.NumberLength_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberLength_txb_KeyPress);
            // 
            // StartNumber_txb
            // 
            this.StartNumber_txb.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.StartNumber_txb.Location = new System.Drawing.Point(85, 46);
            this.StartNumber_txb.Margin = new System.Windows.Forms.Padding(2);
            this.StartNumber_txb.Name = "StartNumber_txb";
            this.StartNumber_txb.ShortcutsEnabled = false;
            this.StartNumber_txb.Size = new System.Drawing.Size(122, 19);
            this.StartNumber_txb.TabIndex = 6;
            this.StartNumber_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartNumber_txb_KeyPress);
            // 
            // FirstName_txb
            // 
            this.FirstName_txb.Location = new System.Drawing.Point(85, 22);
            this.FirstName_txb.Margin = new System.Windows.Forms.Padding(2);
            this.FirstName_txb.Name = "FirstName_txb";
            this.FirstName_txb.Size = new System.Drawing.Size(122, 19);
            this.FirstName_txb.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(4, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "末尾文字";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(4, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "※必要なら入力してください";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(4, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "連番桁数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(4, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "開始番号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(4, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "頭文字";
            // 
            // Preview_bt
            // 
            this.Preview_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Preview_bt.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Preview_bt.Location = new System.Drawing.Point(8, 295);
            this.Preview_bt.Margin = new System.Windows.Forms.Padding(2);
            this.Preview_bt.Name = "Preview_bt";
            this.Preview_bt.Size = new System.Drawing.Size(101, 36);
            this.Preview_bt.TabIndex = 7;
            this.Preview_bt.Text = "プレビュー";
            this.Preview_bt.UseVisualStyleBackColor = true;
            this.Preview_bt.Click += new System.EventHandler(this.Preview_bt_Click);
            // 
            // Excute_bt
            // 
            this.Excute_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Excute_bt.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Excute_bt.Location = new System.Drawing.Point(8, 334);
            this.Excute_bt.Margin = new System.Windows.Forms.Padding(2);
            this.Excute_bt.Name = "Excute_bt";
            this.Excute_bt.Size = new System.Drawing.Size(215, 35);
            this.Excute_bt.TabIndex = 8;
            this.Excute_bt.Text = "実行";
            this.Excute_bt.UseVisualStyleBackColor = true;
            this.Excute_bt.Click += new System.EventHandler(this.Excute_bt_Click);
            // 
            // Undo_bt
            // 
            this.Undo_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Undo_bt.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Undo_bt.Location = new System.Drawing.Point(122, 295);
            this.Undo_bt.Margin = new System.Windows.Forms.Padding(2);
            this.Undo_bt.Name = "Undo_bt";
            this.Undo_bt.Size = new System.Drawing.Size(101, 36);
            this.Undo_bt.TabIndex = 9;
            this.Undo_bt.Text = "修復↩";
            this.Undo_bt.UseVisualStyleBackColor = true;
            this.Undo_bt.Click += new System.EventHandler(this.Undo_bt_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 385);
            this.Controls.Add(this.Undo_bt);
            this.Controls.Add(this.Excute_bt);
            this.Controls.Add(this.Preview_bt);
            this.Controls.Add(this.UpdatedRename_Group);
            this.Controls.Add(this.SelectFolder_Group);
            this.Controls.Add(this.Preview_dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(754, 424);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FileRenamerPro";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.Preview_dgv)).EndInit();
            this.SelectFolder_Group.ResumeLayout(false);
            this.SelectFolder_Group.PerformLayout();
            this.UpdatedRename_Group.ResumeLayout(false);
            this.UpdatedRename_Group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectFolder_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SelectFolderPath_txb;
        private System.Windows.Forms.DataGridView Preview_dgv;
        private System.Windows.Forms.GroupBox SelectFolder_Group;
        private System.Windows.Forms.GroupBox UpdatedRename_Group;
        private System.Windows.Forms.Button Preview_bt;
        private System.Windows.Forms.Button Excute_bt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastName_txb;
        private System.Windows.Forms.TextBox NumberLength_txb;
        private System.Windows.Forms.TextBox StartNumber_txb;
        private System.Windows.Forms.TextBox FirstName_txb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Undo_bt;
    }
}

