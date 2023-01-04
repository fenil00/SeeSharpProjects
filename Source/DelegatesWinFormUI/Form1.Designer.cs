
namespace DelegatesWinFormUI
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
            this.MessageBoxDemoButton = new System.Windows.Forms.Button();
            this.TextBoxDemoButton = new System.Windows.Forms.Button();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageBoxDemoButton
            // 
            this.MessageBoxDemoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBoxDemoButton.Location = new System.Drawing.Point(231, 329);
            this.MessageBoxDemoButton.Name = "MessageBoxDemoButton";
            this.MessageBoxDemoButton.Size = new System.Drawing.Size(198, 80);
            this.MessageBoxDemoButton.TabIndex = 0;
            this.MessageBoxDemoButton.Text = "MessageBox Demo";
            this.MessageBoxDemoButton.UseVisualStyleBackColor = true;
            this.MessageBoxDemoButton.Click += new System.EventHandler(this.MessageBoxDemoButton_Click);
            // 
            // TextBoxDemoButton
            // 
            this.TextBoxDemoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDemoButton.Location = new System.Drawing.Point(451, 329);
            this.TextBoxDemoButton.Name = "TextBoxDemoButton";
            this.TextBoxDemoButton.Size = new System.Drawing.Size(198, 80);
            this.TextBoxDemoButton.TabIndex = 1;
            this.TextBoxDemoButton.Text = "TextBox Demo";
            this.TextBoxDemoButton.UseVisualStyleBackColor = true;
            this.TextBoxDemoButton.Click += new System.EventHandler(this.TextBoxDemoButton_Click);
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubtotal.Location = new System.Drawing.Point(451, 168);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.Size = new System.Drawing.Size(161, 29);
            this.textBoxSubtotal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(451, 255);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(161, 29);
            this.textBoxTotal.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxSubtotal);
            this.Controls.Add(this.TextBoxDemoButton);
            this.Controls.Add(this.MessageBoxDemoButton);
            this.Name = "Form1";
            this.Text = "Delegates Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MessageBoxDemoButton;
        private System.Windows.Forms.Button TextBoxDemoButton;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTotal;
    }
}

