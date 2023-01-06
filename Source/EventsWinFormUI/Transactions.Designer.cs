
namespace EventsWinFormUI
{
    partial class Transactions
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
            this.makePurchaseButton = new System.Windows.Forms.Button();
            this.amountValue = new System.Windows.Forms.NumericUpDown();
            this.amountLabel = new System.Windows.Forms.Label();
            this.customerText = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountValue)).BeginInit();
            this.SuspendLayout();
            // 
            // makePurchaseButton
            // 
            this.makePurchaseButton.Location = new System.Drawing.Point(91, 242);
            this.makePurchaseButton.Name = "makePurchaseButton";
            this.makePurchaseButton.Size = new System.Drawing.Size(249, 81);
            this.makePurchaseButton.TabIndex = 14;
            this.makePurchaseButton.Text = "Make Purchase";
            this.makePurchaseButton.UseVisualStyleBackColor = true;
            this.makePurchaseButton.Click += new System.EventHandler(this.makePurchaseButton_Click);
            // 
            // amountValue
            // 
            this.amountValue.Location = new System.Drawing.Point(209, 162);
            this.amountValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amountValue.Name = "amountValue";
            this.amountValue.Size = new System.Drawing.Size(179, 20);
            this.amountValue.TabIndex = 13;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(55, 164);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(100, 29);
            this.amountLabel.TabIndex = 12;
            this.amountLabel.Text = "Amount";
            // 
            // customerText
            // 
            this.customerText.AutoSize = true;
            this.customerText.Location = new System.Drawing.Point(203, 103);
            this.customerText.Name = "customerText";
            this.customerText.Size = new System.Drawing.Size(43, 13);
            this.customerText.TabIndex = 11;
            this.customerText.Text = "<none>";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(55, 103);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(125, 29);
            this.customerLabel.TabIndex = 10;
            this.customerLabel.Text = "Customer";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(33, 32);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(360, 42);
            this.headerLabel.TabIndex = 9;
            this.headerLabel.Text = "Credit Card Machine";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(88, 333);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(237, 13);
            this.errorMessage.TabIndex = 26;
            this.errorMessage.Text = "You had an overdraft protection transfer of $0.00";
            this.errorMessage.Visible = false;
            this.errorMessage.Click += new System.EventHandler(this.errorMessage_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 355);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.makePurchaseButton);
            this.Controls.Add(this.amountValue);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Transactions_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.amountValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makePurchaseButton;
        private System.Windows.Forms.NumericUpDown amountValue;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label customerText;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label errorMessage;
    }
}