namespace Tekkom
{
    partial class FormPseudoCode
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
            this.btnUploadInput = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblInputType = new System.Windows.Forms.Label();
            this.ddlInputType = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.btnDefaultInput = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUploadInput
            // 
            this.btnUploadInput.Location = new System.Drawing.Point(12, 145);
            this.btnUploadInput.Name = "btnUploadInput";
            this.btnUploadInput.Size = new System.Drawing.Size(85, 23);
            this.btnUploadInput.TabIndex = 0;
            this.btnUploadInput.Text = "Upload Input";
            this.btnUploadInput.UseVisualStyleBackColor = true;
            this.btnUploadInput.Click += new System.EventHandler(this.btnUploadInput_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 39);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(560, 100);
            this.txtInput.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(12, 174);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(85, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblInputType
            // 
            this.lblInputType.AutoSize = true;
            this.lblInputType.Location = new System.Drawing.Point(12, 15);
            this.lblInputType.Name = "lblInputType";
            this.lblInputType.Size = new System.Drawing.Size(60, 13);
            this.lblInputType.TabIndex = 3;
            this.lblInputType.Text = "Input type: ";
            // 
            // ddlInputType
            // 
            this.ddlInputType.FormattingEnabled = true;
            this.ddlInputType.Items.AddRange(new object[] {
            "-Choose Type-",
            "Postfix",
            "Pseudocode"});
            this.ddlInputType.Location = new System.Drawing.Point(78, 12);
            this.ddlInputType.Name = "ddlInputType";
            this.ddlInputType.Size = new System.Drawing.Size(121, 21);
            this.ddlInputType.TabIndex = 4;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // btnDefaultInput
            // 
            this.btnDefaultInput.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDefaultInput.Location = new System.Drawing.Point(103, 145);
            this.btnDefaultInput.Name = "btnDefaultInput";
            this.btnDefaultInput.Size = new System.Drawing.Size(85, 23);
            this.btnDefaultInput.TabIndex = 5;
            this.btnDefaultInput.Text = "Default Input";
            this.btnDefaultInput.UseVisualStyleBackColor = true;
            this.btnDefaultInput.Click += new System.EventHandler(this.btnDefaultInput_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(12, 223);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(33, 13);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "Note:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(103, 174);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormPseudoCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 527);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnDefaultInput);
            this.Controls.Add(this.ddlInputType);
            this.Controls.Add(this.lblInputType);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnUploadInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPseudoCode";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intermediate Code Generator";
            this.Load += new System.EventHandler(this.FormPseudoCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUploadInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblInputType;
        private System.Windows.Forms.ComboBox ddlInputType;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Button btnDefaultInput;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnBack;
    }
}