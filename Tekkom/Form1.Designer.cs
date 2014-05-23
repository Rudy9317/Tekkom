namespace Tekkom
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
            this.input = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hasil = new System.Windows.Forms.Label();
            this.hasilProses = new System.Windows.Forms.Label();
            this.proses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(215, 35);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(50, 20);
            this.input.TabIndex = 0;
            this.input.Text = "Input ";
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(271, 35);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(178, 20);
            this.inputbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Convert Postfix To Quadruple :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Intermediate Code";
            // 
            // hasil
            // 
            this.hasil.AutoSize = true;
            this.hasil.Location = new System.Drawing.Point(507, 123);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(0, 13);
            this.hasil.TabIndex = 5;
            // 
            // hasilProses
            // 
            this.hasilProses.AutoSize = true;
            this.hasilProses.Location = new System.Drawing.Point(250, 233);
            this.hasilProses.Name = "hasilProses";
            this.hasilProses.Size = new System.Drawing.Size(0, 13);
            this.hasilProses.TabIndex = 6;
            // 
            // proses
            // 
            this.proses.Location = new System.Drawing.Point(455, 32);
            this.proses.Name = "proses";
            this.proses.Size = new System.Drawing.Size(75, 23);
            this.proses.TabIndex = 7;
            this.proses.Text = "Proses";
            this.proses.UseVisualStyleBackColor = true;
            this.proses.Click += new System.EventHandler(this.proses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 478);
            this.Controls.Add(this.proses);
            this.Controls.Add(this.hasilProses);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hasil;
        private System.Windows.Forms.Label hasilProses;
        private System.Windows.Forms.Button proses;

    }
}

