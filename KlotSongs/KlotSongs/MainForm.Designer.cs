namespace KlotSongs
{
	partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.mySongsListBox = new System.Windows.Forms.ListBox();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchedSongsListBox = new System.Windows.Forms.ListBox();
            this.songTxtBox = new System.Windows.Forms.TextBox();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MySongs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // mySongsListBox
            // 
            this.mySongsListBox.FormattingEnabled = true;
            this.mySongsListBox.ItemHeight = 16;
            this.mySongsListBox.Location = new System.Drawing.Point(19, 66);
            this.mySongsListBox.Name = "mySongsListBox";
            this.mySongsListBox.Size = new System.Drawing.Size(238, 388);
            this.mySongsListBox.TabIndex = 2;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(310, 66);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(241, 22);
            this.searchTxtBox.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(435, 13);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(116, 35);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "GO";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchedSongsListBox
            // 
            this.searchedSongsListBox.FormattingEnabled = true;
            this.searchedSongsListBox.ItemHeight = 16;
            this.searchedSongsListBox.Location = new System.Drawing.Point(310, 105);
            this.searchedSongsListBox.Name = "searchedSongsListBox";
            this.searchedSongsListBox.Size = new System.Drawing.Size(238, 388);
            this.searchedSongsListBox.TabIndex = 5;
            // 
            // songTxtBox
            // 
            this.songTxtBox.Location = new System.Drawing.Point(662, 13);
            this.songTxtBox.Multiline = true;
            this.songTxtBox.Name = "songTxtBox";
            this.songTxtBox.Size = new System.Drawing.Size(359, 436);
            this.songTxtBox.TabIndex = 6;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyBtn.Location = new System.Drawing.Point(662, 468);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(116, 35);
            this.modifyBtn.TabIndex = 7;
            this.modifyBtn.Text = "MODIFY";
            this.modifyBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(905, 467);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(116, 35);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(19, 467);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(238, 35);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 515);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.songTxtBox);
            this.Controls.Add(this.searchedSongsListBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.mySongsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox mySongsListBox;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox searchedSongsListBox;
        private System.Windows.Forms.TextBox songTxtBox;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
    }
}

