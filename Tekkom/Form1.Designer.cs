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
            this.lblQuadruple = new System.Windows.Forms.Label();
            this.lblStack = new System.Windows.Forms.Label();
            this.hasilProses = new System.Windows.Forms.Label();
            this.proses = new System.Windows.Forms.Button();
            this.dataGridViewquadruples = new System.Windows.Forms.DataGridView();
            this.btnNextInput = new System.Windows.Forms.Button();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.btnDefaultInput = new System.Windows.Forms.Button();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.dataGridViewStack = new System.Windows.Forms.DataGridView();
            this.btnNextProcess = new System.Windows.Forms.Button();
            this.lblProcessed = new System.Windows.Forms.Label();
            this.txtProcessedIndex = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStackOutput = new System.Windows.Forms.Label();
            this.btnProcessToFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.advancedModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewquadruples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStack)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.BackColor = System.Drawing.Color.Transparent;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(12, 42);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(56, 20);
            this.input.TabIndex = 0;
            this.input.Text = "Input ";
            // 
            // inputbox
            // 
            this.inputbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputbox.Location = new System.Drawing.Point(74, 43);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(178, 22);
            this.inputbox.TabIndex = 1;
            // 
            // lblQuadruple
            // 
            this.lblQuadruple.AutoSize = true;
            this.lblQuadruple.BackColor = System.Drawing.Color.Transparent;
            this.lblQuadruple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuadruple.Location = new System.Drawing.Point(219, 186);
            this.lblQuadruple.Name = "lblQuadruple";
            this.lblQuadruple.Size = new System.Drawing.Size(73, 13);
            this.lblQuadruple.TabIndex = 3;
            this.lblQuadruple.Text = "Quadruple :";
            // 
            // lblStack
            // 
            this.lblStack.AutoSize = true;
            this.lblStack.BackColor = System.Drawing.Color.Transparent;
            this.lblStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStack.Location = new System.Drawing.Point(13, 186);
            this.lblStack.Name = "lblStack";
            this.lblStack.Size = new System.Drawing.Size(48, 13);
            this.lblStack.TabIndex = 4;
            this.lblStack.Text = "Stack :";
            // 
            // hasilProses
            // 
            this.hasilProses.AutoSize = true;
            this.hasilProses.Location = new System.Drawing.Point(250, 269);
            this.hasilProses.Name = "hasilProses";
            this.hasilProses.Size = new System.Drawing.Size(0, 13);
            this.hasilProses.TabIndex = 6;
            // 
            // proses
            // 
            this.proses.BackColor = System.Drawing.Color.Transparent;
            this.proses.Enabled = false;
            this.proses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.proses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proses.Location = new System.Drawing.Point(16, 140);
            this.proses.Name = "proses";
            this.proses.Size = new System.Drawing.Size(100, 23);
            this.proses.TabIndex = 7;
            this.proses.Text = "Process";
            this.proses.UseVisualStyleBackColor = false;
            this.proses.Click += new System.EventHandler(this.proses_Click);
            // 
            // dataGridViewquadruples
            // 
            this.dataGridViewquadruples.AllowUserToAddRows = false;
            this.dataGridViewquadruples.AllowUserToDeleteRows = false;
            this.dataGridViewquadruples.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.dataGridViewquadruples.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewquadruples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewquadruples.Location = new System.Drawing.Point(222, 202);
            this.dataGridViewquadruples.MultiSelect = false;
            this.dataGridViewquadruples.Name = "dataGridViewquadruples";
            this.dataGridViewquadruples.ReadOnly = true;
            this.dataGridViewquadruples.RowHeadersVisible = false;
            this.dataGridViewquadruples.Size = new System.Drawing.Size(350, 300);
            this.dataGridViewquadruples.TabIndex = 8;
            // 
            // btnNextInput
            // 
            this.btnNextInput.BackColor = System.Drawing.Color.Transparent;
            this.btnNextInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextInput.Location = new System.Drawing.Point(265, 42);
            this.btnNextInput.Name = "btnNextInput";
            this.btnNextInput.Size = new System.Drawing.Size(84, 23);
            this.btnNextInput.TabIndex = 9;
            this.btnNextInput.Text = "Next Input";
            this.btnNextInput.UseVisualStyleBackColor = false;
            this.btnNextInput.Click += new System.EventHandler(this.btnNextInput_Click);
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.AllowUserToAddRows = false;
            this.dataGridViewInput.AllowUserToDeleteRows = false;
            this.dataGridViewInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewInput.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewInput.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.dataGridViewInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Enabled = false;
            this.dataGridViewInput.Location = new System.Drawing.Point(16, 71);
            this.dataGridViewInput.MultiSelect = false;
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.ReadOnly = true;
            this.dataGridViewInput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewInput.Size = new System.Drawing.Size(556, 63);
            this.dataGridViewInput.TabIndex = 10;
            this.dataGridViewInput.Visible = false;
            this.dataGridViewInput.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewInput_CellFormatting);
            // 
            // btnDefaultInput
            // 
            this.btnDefaultInput.BackColor = System.Drawing.Color.Transparent;
            this.btnDefaultInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDefaultInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefaultInput.Location = new System.Drawing.Point(355, 42);
            this.btnDefaultInput.Name = "btnDefaultInput";
            this.btnDefaultInput.Size = new System.Drawing.Size(106, 23);
            this.btnDefaultInput.TabIndex = 11;
            this.btnDefaultInput.Text = "Set to default";
            this.btnDefaultInput.UseVisualStyleBackColor = false;
            this.btnDefaultInput.Click += new System.EventHandler(this.btnDefaultInput_Click);
            // 
            // btnClearInput
            // 
            this.btnClearInput.BackColor = System.Drawing.Color.Transparent;
            this.btnClearInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInput.Location = new System.Drawing.Point(467, 42);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(105, 23);
            this.btnClearInput.TabIndex = 12;
            this.btnClearInput.Text = "Clear Input";
            this.btnClearInput.UseVisualStyleBackColor = false;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // dataGridViewStack
            // 
            this.dataGridViewStack.AllowUserToAddRows = false;
            this.dataGridViewStack.AllowUserToDeleteRows = false;
            this.dataGridViewStack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.dataGridViewStack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStack.ColumnHeadersVisible = false;
            this.dataGridViewStack.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewStack.Location = new System.Drawing.Point(16, 202);
            this.dataGridViewStack.MultiSelect = false;
            this.dataGridViewStack.Name = "dataGridViewStack";
            this.dataGridViewStack.ReadOnly = true;
            this.dataGridViewStack.RowHeadersVisible = false;
            this.dataGridViewStack.RowTemplate.ReadOnly = true;
            this.dataGridViewStack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStack.Size = new System.Drawing.Size(200, 300);
            this.dataGridViewStack.TabIndex = 13;
            // 
            // btnNextProcess
            // 
            this.btnNextProcess.BackColor = System.Drawing.Color.Transparent;
            this.btnNextProcess.Enabled = false;
            this.btnNextProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextProcess.Location = new System.Drawing.Point(122, 140);
            this.btnNextProcess.Name = "btnNextProcess";
            this.btnNextProcess.Size = new System.Drawing.Size(100, 23);
            this.btnNextProcess.TabIndex = 14;
            this.btnNextProcess.Text = "Next Process";
            this.btnNextProcess.UseVisualStyleBackColor = false;
            this.btnNextProcess.Click += new System.EventHandler(this.btnNextProcess_Click);
            // 
            // lblProcessed
            // 
            this.lblProcessed.AutoSize = true;
            this.lblProcessed.BackColor = System.Drawing.Color.Transparent;
            this.lblProcessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessed.Location = new System.Drawing.Point(404, 143);
            this.lblProcessed.Name = "lblProcessed";
            this.lblProcessed.Size = new System.Drawing.Size(112, 16);
            this.lblProcessed.TabIndex = 15;
            this.lblProcessed.Text = "Processed Index:";
            // 
            // txtProcessedIndex
            // 
            this.txtProcessedIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.txtProcessedIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessedIndex.Location = new System.Drawing.Point(522, 141);
            this.txtProcessedIndex.Name = "txtProcessedIndex";
            this.txtProcessedIndex.ReadOnly = true;
            this.txtProcessedIndex.Size = new System.Drawing.Size(50, 22);
            this.txtProcessedIndex.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introductionToolStripMenuItem,
            this.methodToolStripMenuItem,
            this.howToUseToolStripMenuItem,
            this.advancedModeToolStripMenuItem,
            this.creditsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // introductionToolStripMenuItem
            // 
            this.introductionToolStripMenuItem.Name = "introductionToolStripMenuItem";
            this.introductionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.introductionToolStripMenuItem.Text = "&Introduction";
            this.introductionToolStripMenuItem.Click += new System.EventHandler(this.introductionToolStripMenuItem_Click);
            // 
            // methodToolStripMenuItem
            // 
            this.methodToolStripMenuItem.Name = "methodToolStripMenuItem";
            this.methodToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.methodToolStripMenuItem.Text = "&Method";
            this.methodToolStripMenuItem.Click += new System.EventHandler(this.processToolStripMenuItem_Click);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.howToUseToolStripMenuItem.Text = "&How to use?";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.creditsToolStripMenuItem.Text = "&Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblStackOutput
            // 
            this.lblStackOutput.AutoSize = true;
            this.lblStackOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblStackOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStackOutput.Location = new System.Drawing.Point(67, 186);
            this.lblStackOutput.Name = "lblStackOutput";
            this.lblStackOutput.Size = new System.Drawing.Size(82, 13);
            this.lblStackOutput.TabIndex = 18;
            this.lblStackOutput.Text = "Stack Output";
            // 
            // btnProcessToFile
            // 
            this.btnProcessToFile.BackColor = System.Drawing.Color.Transparent;
            this.btnProcessToFile.Enabled = false;
            this.btnProcessToFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcessToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessToFile.Location = new System.Drawing.Point(228, 140);
            this.btnProcessToFile.Name = "btnProcessToFile";
            this.btnProcessToFile.Size = new System.Drawing.Size(100, 23);
            this.btnProcessToFile.TabIndex = 19;
            this.btnProcessToFile.Text = "Process to file";
            this.btnProcessToFile.UseVisualStyleBackColor = false;
            this.btnProcessToFile.Click += new System.EventHandler(this.btnProcessToFile_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // advancedModeToolStripMenuItem
            // 
            this.advancedModeToolStripMenuItem.Name = "advancedModeToolStripMenuItem";
            this.advancedModeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.advancedModeToolStripMenuItem.Text = "Ad&vanced Mode";
            this.advancedModeToolStripMenuItem.Click += new System.EventHandler(this.advancedModeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tekkom.Properties.Resources.BG2;
            this.ClientSize = new System.Drawing.Size(584, 517);
            this.ControlBox = false;
            this.Controls.Add(this.btnProcessToFile);
            this.Controls.Add(this.lblStackOutput);
            this.Controls.Add(this.txtProcessedIndex);
            this.Controls.Add(this.lblProcessed);
            this.Controls.Add(this.btnNextProcess);
            this.Controls.Add(this.dataGridViewStack);
            this.Controls.Add(this.btnClearInput);
            this.Controls.Add(this.btnDefaultInput);
            this.Controls.Add(this.dataGridViewInput);
            this.Controls.Add(this.btnNextInput);
            this.Controls.Add(this.dataGridViewquadruples);
            this.Controls.Add(this.proses);
            this.Controls.Add(this.hasilProses);
            this.Controls.Add(this.lblStack);
            this.Controls.Add(this.lblQuadruple);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.input);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intermediate Code Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewquadruples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStack)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Label lblQuadruple;
        private System.Windows.Forms.Label lblStack;
        private System.Windows.Forms.Label hasilProses;
        private System.Windows.Forms.Button proses;
        private System.Windows.Forms.DataGridView dataGridViewquadruples;
        private System.Windows.Forms.Button btnNextInput;
        private System.Windows.Forms.DataGridView dataGridViewInput;
        private System.Windows.Forms.Button btnDefaultInput;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.DataGridView dataGridViewStack;
        private System.Windows.Forms.Button btnNextProcess;
        private System.Windows.Forms.Label lblProcessed;
        private System.Windows.Forms.TextBox txtProcessedIndex;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem introductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblStackOutput;
        private System.Windows.Forms.Button btnProcessToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem advancedModeToolStripMenuItem;

    }
}

