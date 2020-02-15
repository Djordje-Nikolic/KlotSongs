namespace KlotSongs
{
    partial class EditForm
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
            this.textBoxSong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxParagraph = new System.Windows.Forms.TextBox();
            this.textBoxParagraphType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownAddAfterParagraph = new System.Windows.Forms.NumericUpDown();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.buttonDeleteParagraph = new System.Windows.Forms.Button();
            this.textBoxEditedParagraphType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.buttonLoadParagraph = new System.Windows.Forms.Button();
            this.textBoxEditedParagraph = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownParagraphChoice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCommitGlobal = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddAfterParagraph)).BeginInit();
            this.tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParagraphChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSong
            // 
            this.textBoxSong.Location = new System.Drawing.Point(12, 32);
            this.textBoxSong.Multiline = true;
            this.textBoxSong.Name = "textBoxSong";
            this.textBoxSong.ReadOnly = true;
            this.textBoxSong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSong.Size = new System.Drawing.Size(377, 431);
            this.textBoxSong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Song";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Controls.Add(this.tabPageEdit);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(433, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 431);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.label5);
            this.tabPageAdd.Controls.Add(this.textBoxParagraph);
            this.tabPageAdd.Controls.Add(this.textBoxParagraphType);
            this.tabPageAdd.Controls.Add(this.label4);
            this.tabPageAdd.Controls.Add(this.buttonAdd);
            this.tabPageAdd.Controls.Add(this.label3);
            this.tabPageAdd.Controls.Add(this.numericUpDownAddAfterParagraph);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(575, 402);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Add";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Paragraph To Add";
            // 
            // textBoxParagraph
            // 
            this.textBoxParagraph.Location = new System.Drawing.Point(9, 34);
            this.textBoxParagraph.Multiline = true;
            this.textBoxParagraph.Name = "textBoxParagraph";
            this.textBoxParagraph.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxParagraph.Size = new System.Drawing.Size(550, 265);
            this.textBoxParagraph.TabIndex = 5;
            // 
            // textBoxParagraphType
            // 
            this.textBoxParagraphType.Location = new System.Drawing.Point(445, 305);
            this.textBoxParagraphType.Name = "textBoxParagraphType";
            this.textBoxParagraphType.Size = new System.Drawing.Size(114, 22);
            this.textBoxParagraphType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Paragraph Type:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(480, 361);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(79, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Insert at index:";
            // 
            // numericUpDownAddAfterParagraph
            // 
            this.numericUpDownAddAfterParagraph.Location = new System.Drawing.Point(514, 333);
            this.numericUpDownAddAfterParagraph.Name = "numericUpDownAddAfterParagraph";
            this.numericUpDownAddAfterParagraph.Size = new System.Drawing.Size(45, 22);
            this.numericUpDownAddAfterParagraph.TabIndex = 0;
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.buttonDeleteParagraph);
            this.tabPageEdit.Controls.Add(this.textBoxEditedParagraphType);
            this.tabPageEdit.Controls.Add(this.label7);
            this.tabPageEdit.Controls.Add(this.buttonCommit);
            this.tabPageEdit.Controls.Add(this.buttonLoadParagraph);
            this.tabPageEdit.Controls.Add(this.textBoxEditedParagraph);
            this.tabPageEdit.Controls.Add(this.label6);
            this.tabPageEdit.Controls.Add(this.numericUpDownParagraphChoice);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdit.Size = new System.Drawing.Size(575, 402);
            this.tabPageEdit.TabIndex = 1;
            this.tabPageEdit.Text = "Edit";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteParagraph
            // 
            this.buttonDeleteParagraph.Location = new System.Drawing.Point(324, 16);
            this.buttonDeleteParagraph.Name = "buttonDeleteParagraph";
            this.buttonDeleteParagraph.Size = new System.Drawing.Size(140, 23);
            this.buttonDeleteParagraph.TabIndex = 11;
            this.buttonDeleteParagraph.Text = "Delete Paragraph";
            this.buttonDeleteParagraph.UseVisualStyleBackColor = true;
            this.buttonDeleteParagraph.Click += new System.EventHandler(this.buttonDeleteParagraph_Click);
            // 
            // textBoxEditedParagraphType
            // 
            this.textBoxEditedParagraphType.Location = new System.Drawing.Point(445, 314);
            this.textBoxEditedParagraphType.Name = "textBoxEditedParagraphType";
            this.textBoxEditedParagraphType.Size = new System.Drawing.Size(114, 22);
            this.textBoxEditedParagraphType.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Paragraph Type:";
            // 
            // buttonCommit
            // 
            this.buttonCommit.Location = new System.Drawing.Point(422, 353);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(137, 23);
            this.buttonCommit.TabIndex = 8;
            this.buttonCommit.Text = "Commit edit";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // buttonLoadParagraph
            // 
            this.buttonLoadParagraph.Location = new System.Drawing.Point(178, 16);
            this.buttonLoadParagraph.Name = "buttonLoadParagraph";
            this.buttonLoadParagraph.Size = new System.Drawing.Size(140, 23);
            this.buttonLoadParagraph.TabIndex = 7;
            this.buttonLoadParagraph.Text = "Load Paragraph";
            this.buttonLoadParagraph.UseVisualStyleBackColor = true;
            this.buttonLoadParagraph.Click += new System.EventHandler(this.buttonLoadParagraph_Click);
            // 
            // textBoxEditedParagraph
            // 
            this.textBoxEditedParagraph.Location = new System.Drawing.Point(9, 43);
            this.textBoxEditedParagraph.Multiline = true;
            this.textBoxEditedParagraph.Name = "textBoxEditedParagraph";
            this.textBoxEditedParagraph.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEditedParagraph.Size = new System.Drawing.Size(550, 265);
            this.textBoxEditedParagraph.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Choose Paragraph";
            // 
            // numericUpDownParagraphChoice
            // 
            this.numericUpDownParagraphChoice.Location = new System.Drawing.Point(134, 17);
            this.numericUpDownParagraphChoice.Name = "numericUpDownParagraphChoice";
            this.numericUpDownParagraphChoice.Size = new System.Drawing.Size(38, 22);
            this.numericUpDownParagraphChoice.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Paragraph Control";
            // 
            // buttonCommitGlobal
            // 
            this.buttonCommitGlobal.Location = new System.Drawing.Point(915, 12);
            this.buttonCommitGlobal.Name = "buttonCommitGlobal";
            this.buttonCommitGlobal.Size = new System.Drawing.Size(97, 23);
            this.buttonCommitGlobal.TabIndex = 11;
            this.buttonCommitGlobal.Text = "Commit global";
            this.buttonCommitGlobal.UseVisualStyleBackColor = true;
            this.buttonCommitGlobal.Click += new System.EventHandler(this.buttonCommitGlobal_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 487);
            this.Controls.Add(this.buttonCommitGlobal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddAfterParagraph)).EndInit();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParagraphChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxParagraph;
        private System.Windows.Forms.TextBox textBoxParagraphType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownAddAfterParagraph;
        private System.Windows.Forms.Button buttonCommit;
        private System.Windows.Forms.Button buttonLoadParagraph;
        private System.Windows.Forms.TextBox textBoxEditedParagraph;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownParagraphChoice;
        private System.Windows.Forms.TextBox textBoxEditedParagraphType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCommitGlobal;
        private System.Windows.Forms.Button buttonDeleteParagraph;
    }
}