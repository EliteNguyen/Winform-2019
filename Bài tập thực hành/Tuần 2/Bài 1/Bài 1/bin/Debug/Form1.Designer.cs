namespace Bài_1
{
    partial class Lab0201
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
            this.Number1 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.Number2 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Eliminate = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Number1
            // 
            this.Number1.AutoSize = true;
            this.Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number1.Location = new System.Drawing.Point(120, 72);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(86, 20);
            this.Number1.TabIndex = 0;
            this.Number1.Text = "Number 1";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(242, 72);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(256, 20);
            this.txtNumber1.TabIndex = 1;
            // 
            // Number2
            // 
            this.Number2.AutoSize = true;
            this.Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number2.Location = new System.Drawing.Point(120, 119);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(86, 20);
            this.Number2.TabIndex = 2;
            this.Number2.Text = "Number 2";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(242, 118);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(256, 20);
            this.txtNumber2.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(80, 201);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 40);
            this.Add.TabIndex = 4;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Eliminate
            // 
            this.Eliminate.Location = new System.Drawing.Point(196, 201);
            this.Eliminate.Name = "Eliminate";
            this.Eliminate.Size = new System.Drawing.Size(75, 40);
            this.Eliminate.TabIndex = 5;
            this.Eliminate.Text = "-";
            this.Eliminate.UseVisualStyleBackColor = true;
            this.Eliminate.Click += new System.EventHandler(this.Eliminate_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(307, 201);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 40);
            this.Multiply.TabIndex = 6;
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(443, 201);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 40);
            this.Division.TabIndex = 7;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.Location = new System.Drawing.Point(124, 305);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(68, 20);
            this.Answer.TabIndex = 8;
            this.Answer.Text = "Answer";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(242, 305);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(256, 20);
            this.txtAnswer.TabIndex = 9;
            // 
            // Lab0201
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 462);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Eliminate);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.Number1);
            this.Name = "Lab0201";
            this.Text = "Lab02-01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label Number2;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Eliminate;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.TextBox txtAnswer;
    }
}

