namespace forditoprog
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.First = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multiplication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashtag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeColumns = false;
            this.tabla.AllowUserToResizeRows = false;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.First,
            this.plus,
            this.multiplication,
            this.open,
            this.closer,
            this.i,
            this.hashtag});
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.Location = new System.Drawing.Point(22, 20);
            this.tabla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersVisible = false;
            this.tabla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tabla.RowTemplate.Height = 28;
            this.tabla.Size = new System.Drawing.Size(655, 361);
            this.tabla.TabIndex = 1;
            // 
            // First
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.First.DefaultCellStyle = dataGridViewCellStyle1;
            this.First.Frozen = true;
            this.First.HeaderText = " ";
            this.First.Name = "First";
            this.First.ReadOnly = true;
            this.First.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // plus
            // 
            this.plus.Frozen = true;
            this.plus.HeaderText = "+";
            this.plus.Name = "plus";
            this.plus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // multiplication
            // 
            this.multiplication.Frozen = true;
            this.multiplication.HeaderText = "*";
            this.multiplication.Name = "multiplication";
            this.multiplication.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // open
            // 
            this.open.Frozen = true;
            this.open.HeaderText = "(";
            this.open.Name = "open";
            this.open.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // closer
            // 
            this.closer.Frozen = true;
            this.closer.HeaderText = ")";
            this.closer.Name = "closer";
            this.closer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // i
            // 
            this.i.Frozen = true;
            this.i.HeaderText = "i";
            this.i.Name = "i";
            this.i.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // hashtag
            // 
            this.hashtag.Frozen = true;
            this.hashtag.HeaderText = "#";
            this.hashtag.Name = "hashtag";
            this.hashtag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 385);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabla);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn First;
        private System.Windows.Forms.DataGridViewTextBoxColumn plus;
        private System.Windows.Forms.DataGridViewTextBoxColumn multiplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn open;
        private System.Windows.Forms.DataGridViewTextBoxColumn closer;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashtag;
        private System.Windows.Forms.Button button1;
    }
}