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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewquadruples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStack)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(12, 9);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(50, 20);
            this.input.TabIndex = 0;
            this.input.Text = "Input ";
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(68, 9);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(178, 20);
            this.inputbox.TabIndex = 1;
            // 
            // lblQuadruple
            // 
            this.lblQuadruple.AutoSize = true;
            this.lblQuadruple.Location = new System.Drawing.Point(169, 150);
            this.lblQuadruple.Name = "lblQuadruple";
            this.lblQuadruple.Size = new System.Drawing.Size(62, 13);
            this.lblQuadruple.TabIndex = 3;
            this.lblQuadruple.Text = "Quadruple :";
            // 
            // lblStack
            // 
            this.lblStack.AutoSize = true;
            this.lblStack.Location = new System.Drawing.Point(13, 150);
            this.lblStack.Name = "lblStack";
            this.lblStack.Size = new System.Drawing.Size(41, 13);
            this.lblStack.TabIndex = 4;
            this.lblStack.Text = "Stack :";
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
            this.proses.Enabled = false;
            this.proses.Location = new System.Drawing.Point(16, 104);
            this.proses.Name = "proses";
            this.proses.Size = new System.Drawing.Size(75, 23);
            this.proses.TabIndex = 7;
            this.proses.Text = "Process";
            this.proses.UseVisualStyleBackColor = true;
            this.proses.Click += new System.EventHandler(this.proses_Click);
            // 
            // dataGridViewquadruples
            // 
            this.dataGridViewquadruples.AllowUserToAddRows = false;
            this.dataGridViewquadruples.AllowUserToDeleteRows = false;
            this.dataGridViewquadruples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewquadruples.Location = new System.Drawing.Point(172, 166);
            this.dataGridViewquadruples.MultiSelect = false;
            this.dataGridViewquadruples.Name = "dataGridViewquadruples";
            this.dataGridViewquadruples.ReadOnly = true;
            this.dataGridViewquadruples.Size = new System.Drawing.Size(400, 300);
            this.dataGridViewquadruples.TabIndex = 8;
            // 
            // btnNextInput
            // 
            this.btnNextInput.Location = new System.Drawing.Point(252, 6);
            this.btnNextInput.Name = "btnNextInput";
            this.btnNextInput.Size = new System.Drawing.Size(75, 23);
            this.btnNextInput.TabIndex = 9;
            this.btnNextInput.Text = "Next Input";
            this.btnNextInput.UseVisualStyleBackColor = true;
            this.btnNextInput.Click += new System.EventHandler(this.btnNextInput_Click);
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.AllowUserToAddRows = false;
            this.dataGridViewInput.AllowUserToDeleteRows = false;
            this.dataGridViewInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Enabled = false;
            this.dataGridViewInput.Location = new System.Drawing.Point(16, 35);
            this.dataGridViewInput.MultiSelect = false;
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.ReadOnly = true;
            this.dataGridViewInput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewInput.Size = new System.Drawing.Size(486, 63);
            this.dataGridViewInput.TabIndex = 10;
            this.dataGridViewInput.Visible = false;
            this.dataGridViewInput.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewInput_CellFormatting);
            // 
            // btnDefaultInput
            // 
            this.btnDefaultInput.Location = new System.Drawing.Point(333, 6);
            this.btnDefaultInput.Name = "btnDefaultInput";
            this.btnDefaultInput.Size = new System.Drawing.Size(88, 23);
            this.btnDefaultInput.TabIndex = 11;
            this.btnDefaultInput.Text = "Set to default";
            this.btnDefaultInput.UseVisualStyleBackColor = true;
            this.btnDefaultInput.Click += new System.EventHandler(this.btnDefaultInput_Click);
            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(427, 6);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(75, 23);
            this.btnClearInput.TabIndex = 12;
            this.btnClearInput.Text = "Clear Input";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // dataGridViewStack
            // 
            this.dataGridViewStack.AllowUserToAddRows = false;
            this.dataGridViewStack.AllowUserToDeleteRows = false;
            this.dataGridViewStack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStack.ColumnHeadersVisible = false;
            this.dataGridViewStack.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewStack.Location = new System.Drawing.Point(16, 166);
            this.dataGridViewStack.MultiSelect = false;
            this.dataGridViewStack.Name = "dataGridViewStack";
            this.dataGridViewStack.ReadOnly = true;
            this.dataGridViewStack.RowTemplate.ReadOnly = true;
            this.dataGridViewStack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStack.Size = new System.Drawing.Size(150, 300);
            this.dataGridViewStack.TabIndex = 13;
            // 
            // btnNextProcess
            // 
            this.btnNextProcess.Enabled = false;
            this.btnNextProcess.Location = new System.Drawing.Point(97, 104);
            this.btnNextProcess.Name = "btnNextProcess";
            this.btnNextProcess.Size = new System.Drawing.Size(80, 23);
            this.btnNextProcess.TabIndex = 14;
            this.btnNextProcess.Text = "Next Process";
            this.btnNextProcess.UseVisualStyleBackColor = true;
            this.btnNextProcess.Click += new System.EventHandler(this.btnNextProcess_Click);
            // 
            // lblProcessed
            // 
            this.lblProcessed.AutoSize = true;
            this.lblProcessed.Location = new System.Drawing.Point(213, 109);
            this.lblProcessed.Name = "lblProcessed";
            this.lblProcessed.Size = new System.Drawing.Size(89, 13);
            this.lblProcessed.TabIndex = 15;
            this.lblProcessed.Text = "Processed Index:";
            // 
            // txtProcessedIndex
            // 
            this.txtProcessedIndex.Location = new System.Drawing.Point(308, 106);
            this.txtProcessedIndex.Name = "txtProcessedIndex";
            this.txtProcessedIndex.ReadOnly = true;
            this.txtProcessedIndex.Size = new System.Drawing.Size(50, 20);
            this.txtProcessedIndex.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 481);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewquadruples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStack)).EndInit();
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

    }
}

