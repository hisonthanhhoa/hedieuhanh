namespace hedieuhanh
{
    partial class Form1
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
            this.btnW = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnpaint = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnPP = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(107, 61);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(111, 63);
            this.btnW.TabIndex = 0;
            this.btnW.Text = "Word";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(271, 61);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(116, 63);
            this.btnE.TabIndex = 1;
            this.btnE.Text = "Execl";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnpaint
            // 
            this.btnpaint.Location = new System.Drawing.Point(417, 61);
            this.btnpaint.Name = "btnpaint";
            this.btnpaint.Size = new System.Drawing.Size(118, 63);
            this.btnpaint.TabIndex = 2;
            this.btnpaint.Text = "Paint";
            this.btnpaint.UseVisualStyleBackColor = true;
            this.btnpaint.Click += new System.EventHandler(this.btnpaint_Click);
            // 
            // btnNote
            // 
            this.btnNote.Location = new System.Drawing.Point(107, 194);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(111, 63);
            this.btnNote.TabIndex = 3;
            this.btnNote.Text = "NotePad";
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnPP
            // 
            this.btnPP.Location = new System.Drawing.Point(271, 194);
            this.btnPP.Name = "btnPP";
            this.btnPP.Size = new System.Drawing.Size(116, 63);
            this.btnPP.TabIndex = 4;
            this.btnPP.Text = "máy tính";
            this.btnPP.UseVisualStyleBackColor = true;
            this.btnPP.Click += new System.EventHandler(this.btnPP_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(459, 323);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dừng";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "winword",
            "execl",
            "paint",
            "calculator",
            "notepad"});
            this.comboBox1.Location = new System.Drawing.Point(96, 323);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 30);
            this.comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnPP);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.btnpaint);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnW);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "ứng dụng mở và tắt ứng dụng trong windownform";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnpaint;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Button btnPP;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

