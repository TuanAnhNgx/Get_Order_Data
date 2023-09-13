namespace Get_Orders_Data
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnInput = new Button();
            txtInput = new TextBox();
            dgvData = new DataGridView();
            btnStart = new Button();
            richTextBox1 = new RichTextBox();
            txtExcel = new TextBox();
            btnExcel = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 0;
            label1.Text = "Input";
            // 
            // btnInput
            // 
            btnInput.Location = new Point(491, 9);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(44, 29);
            btnInput.TabIndex = 1;
            btnInput.Text = "...";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(68, 11);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(417, 27);
            txtInput.TabIndex = 2;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 124);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.Size = new Size(523, 575);
            dgvData.TabIndex = 3;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(68, 89);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(417, 29);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start Get Data";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(592, 124);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(556, 575);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // txtExcel
            // 
            txtExcel.Location = new Point(68, 44);
            txtExcel.Name = "txtExcel";
            txtExcel.Size = new Size(417, 27);
            txtExcel.TabIndex = 8;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(491, 42);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(44, 29);
            btnExcel.TabIndex = 7;
            btnExcel.Text = "...";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 42);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 6;
            label2.Text = "Excel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 711);
            Controls.Add(txtExcel);
            Controls.Add(btnExcel);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(btnStart);
            Controls.Add(dgvData);
            Controls.Add(txtInput);
            Controls.Add(btnInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnInput;
        private TextBox txtInput;
        private DataGridView dgvData;
        private Button btnStart;
        private RichTextBox richTextBox1;
        private TextBox txtExcel;
        private Button btnExcel;
        private Label label2;
    }
}