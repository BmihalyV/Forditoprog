namespace forditoprog
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
            this.label3 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.accept = new System.Windows.Forms.Button();
            this.stepsListBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.originalInput = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(2, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inputszalag:";
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.Color.Red;
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputText.ForeColor = System.Drawing.SystemColors.Window;
            this.inputText.Location = new System.Drawing.Point(112, 171);
            this.inputText.Margin = new System.Windows.Forms.Padding(2);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(158, 29);
            this.inputText.TabIndex = 5;
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.Color.Blue;
            this.accept.ForeColor = System.Drawing.SystemColors.Window;
            this.accept.Location = new System.Drawing.Point(183, 204);
            this.accept.Margin = new System.Windows.Forms.Padding(2);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(87, 30);
            this.accept.TabIndex = 8;
            this.accept.Text = "Számítás";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // stepsListBox1
            // 
            this.stepsListBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stepsListBox1.Location = new System.Drawing.Point(274, 30);
            this.stepsListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.stepsListBox1.Name = "stepsListBox1";
            this.stepsListBox1.ReadOnly = true;
            this.stepsListBox1.Size = new System.Drawing.Size(317, 331);
            this.stepsListBox1.TabIndex = 9;
            this.stepsListBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(274, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Szabályzat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(2, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Eredeti Input:";
            // 
            // originalInput
            // 
            this.originalInput.AutoSize = true;
            this.originalInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.originalInput.Location = new System.Drawing.Point(108, 141);
            this.originalInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.originalInput.Name = "originalInput";
            this.originalInput.Size = new System.Drawing.Size(0, 20);
            this.originalInput.TabIndex = 17;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCount.Location = new System.Drawing.Point(11, 368);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 20);
            this.labelCount.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 407);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.originalInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stepsListBox1);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.RichTextBox stepsListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label originalInput;
        private System.Windows.Forms.Label labelCount;
    }
}

