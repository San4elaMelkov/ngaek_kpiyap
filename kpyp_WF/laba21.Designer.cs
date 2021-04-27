
namespace kpyp_WF
{
    partial class laba21
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
            this.check = new System.Windows.Forms.Button();
            this.input_date = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(221, 192);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 0;
            this.check.Text = "Проверить";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // input_date
            // 
            this.input_date.Location = new System.Drawing.Point(221, 138);
            this.input_date.Name = "input_date";
            this.input_date.Size = new System.Drawing.Size(100, 20);
            this.input_date.TabIndex = 1;
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(332, 201);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 13);
            this.answer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите номер дня недели";
            // 
            // laba21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.input_date);
            this.Controls.Add(this.check);
            this.Name = "laba21";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "laba21";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox input_date;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label label1;
    }
}