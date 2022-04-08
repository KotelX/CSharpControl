namespace CSharpControl
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ArrayInput = new System.Windows.Forms.DataGridView();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrayOutput = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoGenerateArray = new System.Windows.Forms.Button();
            this.SortSecond = new System.Windows.Forms.Button();
            this.Method = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // ArrayInput
            // 
            this.ArrayInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrayInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value});
            this.ArrayInput.Location = new System.Drawing.Point(12, 12);
            this.ArrayInput.Name = "ArrayInput";
            this.ArrayInput.RowHeadersVisible = false;
            this.ArrayInput.Size = new System.Drawing.Size(72, 405);
            this.ArrayInput.TabIndex = 0;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // ArrayOutput
            // 
            this.ArrayOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrayOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.ArrayOutput.Location = new System.Drawing.Point(90, 12);
            this.ArrayOutput.Name = "ArrayOutput";
            this.ArrayOutput.RowHeadersVisible = false;
            this.ArrayOutput.Size = new System.Drawing.Size(72, 405);
            this.ArrayOutput.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Value";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // AutoGenerateArray
            // 
            this.AutoGenerateArray.Location = new System.Drawing.Point(12, 423);
            this.AutoGenerateArray.Name = "AutoGenerateArray";
            this.AutoGenerateArray.Size = new System.Drawing.Size(150, 23);
            this.AutoGenerateArray.TabIndex = 2;
            this.AutoGenerateArray.Text = "Generate array";
            this.AutoGenerateArray.UseVisualStyleBackColor = true;
            this.AutoGenerateArray.Click += new System.EventHandler(this.AutoGenerateArray_Click);
            // 
            // SortSecond
            // 
            this.SortSecond.Location = new System.Drawing.Point(12, 481);
            this.SortSecond.Name = "SortSecond";
            this.SortSecond.Size = new System.Drawing.Size(150, 23);
            this.SortSecond.TabIndex = 4;
            this.SortSecond.Text = "Sort";
            this.SortSecond.UseVisualStyleBackColor = true;
            this.SortSecond.Click += new System.EventHandler(this.SortSecond_Click);
            // 
            // Method
            // 
            this.Method.FormattingEnabled = true;
            this.Method.Items.AddRange(new object[] {
            "Расческой",
            "Перемешиванием"});
            this.Method.Location = new System.Drawing.Point(27, 452);
            this.Method.Name = "Method";
            this.Method.Size = new System.Drawing.Size(121, 21);
            this.Method.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 514);
            this.Controls.Add(this.Method);
            this.Controls.Add(this.SortSecond);
            this.Controls.Add(this.AutoGenerateArray);
            this.Controls.Add(this.ArrayOutput);
            this.Controls.Add(this.ArrayInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ArrayInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ArrayInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridView ArrayOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button AutoGenerateArray;
        private System.Windows.Forms.Button SortSecond;
        private System.Windows.Forms.ComboBox Method;
    }
}

