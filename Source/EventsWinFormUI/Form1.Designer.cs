
namespace EventsWinFormUI
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
            this.errorMessage = new System.Windows.Forms.Label();
            this.recordTransactionsButton = new System.Windows.Forms.Button();
            this.savingsTransactionsLabel = new System.Windows.Forms.Label();
            this.checkingTransactionsLabel = new System.Windows.Forms.Label();
            this.savingsTransactions = new System.Windows.Forms.ListBox();
            this.checkingTransactions = new System.Windows.Forms.ListBox();
            this.savingsBalanceValue = new System.Windows.Forms.Label();
            this.savingsBalanceLabel = new System.Windows.Forms.Label();
            this.checkingBalanceValue = new System.Windows.Forms.Label();
            this.checkingBalanceLabel = new System.Windows.Forms.Label();
            this.customerText = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(443, 65);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(237, 13);
            this.errorMessage.TabIndex = 25;
            this.errorMessage.Text = "You had an overdraft protection transfer of $0.00";
            this.errorMessage.Visible = false;
            this.errorMessage.Click += new System.EventHandler(this.errorMessage_Click);
            // 
            // recordTransactionsButton
            // 
            this.recordTransactionsButton.Location = new System.Drawing.Point(115, 370);
            this.recordTransactionsButton.Name = "recordTransactionsButton";
            this.recordTransactionsButton.Size = new System.Drawing.Size(198, 100);
            this.recordTransactionsButton.TabIndex = 24;
            this.recordTransactionsButton.Text = "Record Transactions";
            this.recordTransactionsButton.UseVisualStyleBackColor = true;
            this.recordTransactionsButton.Click += new System.EventHandler(this.recordTransactionsButton_Click);
            // 
            // savingsTransactionsLabel
            // 
            this.savingsTransactionsLabel.AutoSize = true;
            this.savingsTransactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsTransactionsLabel.Location = new System.Drawing.Point(782, 123);
            this.savingsTransactionsLabel.Name = "savingsTransactionsLabel";
            this.savingsTransactionsLabel.Size = new System.Drawing.Size(262, 29);
            this.savingsTransactionsLabel.TabIndex = 23;
            this.savingsTransactionsLabel.Text = "Savings Transactions";
            // 
            // checkingTransactionsLabel
            // 
            this.checkingTransactionsLabel.AutoSize = true;
            this.checkingTransactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingTransactionsLabel.Location = new System.Drawing.Point(443, 123);
            this.checkingTransactionsLabel.Name = "checkingTransactionsLabel";
            this.checkingTransactionsLabel.Size = new System.Drawing.Size(279, 29);
            this.checkingTransactionsLabel.TabIndex = 22;
            this.checkingTransactionsLabel.Text = "Checking Transactions";
            // 
            // savingsTransactions
            // 
            this.savingsTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsTransactions.FormattingEnabled = true;
            this.savingsTransactions.ItemHeight = 20;
            this.savingsTransactions.Location = new System.Drawing.Point(788, 159);
            this.savingsTransactions.Name = "savingsTransactions";
            this.savingsTransactions.Size = new System.Drawing.Size(312, 344);
            this.savingsTransactions.TabIndex = 21;
            // 
            // checkingTransactions
            // 
            this.checkingTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingTransactions.FormattingEnabled = true;
            this.checkingTransactions.ItemHeight = 20;
            this.checkingTransactions.Location = new System.Drawing.Point(449, 159);
            this.checkingTransactions.Name = "checkingTransactions";
            this.checkingTransactions.Size = new System.Drawing.Size(312, 344);
            this.checkingTransactions.TabIndex = 20;
            // 
            // savingsBalanceValue
            // 
            this.savingsBalanceValue.AutoSize = true;
            this.savingsBalanceValue.Location = new System.Drawing.Point(299, 300);
            this.savingsBalanceValue.Name = "savingsBalanceValue";
            this.savingsBalanceValue.Size = new System.Drawing.Size(34, 13);
            this.savingsBalanceValue.TabIndex = 19;
            this.savingsBalanceValue.Text = "$0.00";
            // 
            // savingsBalanceLabel
            // 
            this.savingsBalanceLabel.AutoSize = true;
            this.savingsBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsBalanceLabel.Location = new System.Drawing.Point(70, 300);
            this.savingsBalanceLabel.Name = "savingsBalanceLabel";
            this.savingsBalanceLabel.Size = new System.Drawing.Size(206, 29);
            this.savingsBalanceLabel.TabIndex = 18;
            this.savingsBalanceLabel.Text = "Savings Balance";
            // 
            // checkingBalanceValue
            // 
            this.checkingBalanceValue.AutoSize = true;
            this.checkingBalanceValue.Location = new System.Drawing.Point(299, 227);
            this.checkingBalanceValue.Name = "checkingBalanceValue";
            this.checkingBalanceValue.Size = new System.Drawing.Size(34, 13);
            this.checkingBalanceValue.TabIndex = 17;
            this.checkingBalanceValue.Text = "$0.00";
            // 
            // checkingBalanceLabel
            // 
            this.checkingBalanceLabel.AutoSize = true;
            this.checkingBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingBalanceLabel.Location = new System.Drawing.Point(70, 227);
            this.checkingBalanceLabel.Name = "checkingBalanceLabel";
            this.checkingBalanceLabel.Size = new System.Drawing.Size(223, 29);
            this.checkingBalanceLabel.TabIndex = 16;
            this.checkingBalanceLabel.Text = "Checking Balance";
            // 
            // customerText
            // 
            this.customerText.AutoSize = true;
            this.customerText.Location = new System.Drawing.Point(299, 159);
            this.customerText.Name = "customerText";
            this.customerText.Size = new System.Drawing.Size(43, 13);
            this.customerText.TabIndex = 15;
            this.customerText.Text = "<none>";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(70, 159);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(125, 29);
            this.customerLabel.TabIndex = 14;
            this.customerLabel.Text = "Customer";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(47, 51);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(263, 42);
            this.headerLabel.TabIndex = 13;
            this.headerLabel.Text = "Banking Demo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 555);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.recordTransactionsButton);
            this.Controls.Add(this.savingsTransactionsLabel);
            this.Controls.Add(this.checkingTransactionsLabel);
            this.Controls.Add(this.savingsTransactions);
            this.Controls.Add(this.checkingTransactions);
            this.Controls.Add(this.savingsBalanceValue);
            this.Controls.Add(this.savingsBalanceLabel);
            this.Controls.Add(this.checkingBalanceValue);
            this.Controls.Add(this.checkingBalanceLabel);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Button recordTransactionsButton;
        private System.Windows.Forms.Label savingsTransactionsLabel;
        private System.Windows.Forms.Label checkingTransactionsLabel;
        private System.Windows.Forms.ListBox savingsTransactions;
        private System.Windows.Forms.ListBox checkingTransactions;
        private System.Windows.Forms.Label savingsBalanceValue;
        private System.Windows.Forms.Label savingsBalanceLabel;
        private System.Windows.Forms.Label checkingBalanceValue;
        private System.Windows.Forms.Label checkingBalanceLabel;
        private System.Windows.Forms.Label customerText;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label headerLabel;
    }
}

