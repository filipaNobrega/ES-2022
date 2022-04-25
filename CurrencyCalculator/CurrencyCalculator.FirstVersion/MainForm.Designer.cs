namespace CurrencyCalculator.FirstVersion
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.EuroTextBox = new System.Windows.Forms.TextBox();
            this.EuroLabel = new System.Windows.Forms.Label();
            this.DollarTextBox = new System.Windows.Forms.TextBox();
            this.DollarLabel = new System.Windows.Forms.Label();
            this.EuroErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DollarErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PoundTextBox = new System.Windows.Forms.TextBox();
            this.PoundLabel = new System.Windows.Forms.Label();
            this.PoundErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EuroErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollarErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoundErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EuroTextBox
            // 
            this.EuroTextBox.Location = new System.Drawing.Point(42, 47);
            this.EuroTextBox.Name = "EuroTextBox";
            this.EuroTextBox.Size = new System.Drawing.Size(400, 22);
            this.EuroTextBox.TabIndex = 0;
            this.EuroTextBox.TextChanged += new System.EventHandler(this.OnEuroTextBoxChanged);
            // 
            // EuroLabel
            // 
            this.EuroLabel.AutoSize = true;
            this.EuroLabel.Location = new System.Drawing.Point(39, 23);
            this.EuroLabel.Name = "EuroLabel";
            this.EuroLabel.Size = new System.Drawing.Size(60, 17);
            this.EuroLabel.TabIndex = 1;
            this.EuroLabel.Text = "Euro (€)";
            // 
            // DollarTextBox
            // 
            this.DollarTextBox.Location = new System.Drawing.Point(42, 117);
            this.DollarTextBox.Name = "DollarTextBox";
            this.DollarTextBox.Size = new System.Drawing.Size(400, 22);
            this.DollarTextBox.TabIndex = 2;
            this.DollarTextBox.TextChanged += new System.EventHandler(this.OnDollarTextBoxChanged);
            // 
            // DollarLabel
            // 
            this.DollarLabel.AutoSize = true;
            this.DollarLabel.Location = new System.Drawing.Point(39, 97);
            this.DollarLabel.Name = "DollarLabel";
            this.DollarLabel.Size = new System.Drawing.Size(67, 17);
            this.DollarLabel.TabIndex = 3;
            this.DollarLabel.Text = "Dollar ($)";
            // 
            // EuroErrorProvider
            // 
            this.EuroErrorProvider.ContainerControl = this;
            // 
            // DollarErrorProvider
            // 
            this.DollarErrorProvider.ContainerControl = this;
            // 
            // PoundTextBox
            // 
            this.PoundTextBox.Location = new System.Drawing.Point(42, 183);
            this.PoundTextBox.Name = "PoundTextBox";
            this.PoundTextBox.Size = new System.Drawing.Size(400, 22);
            this.PoundTextBox.TabIndex = 4;
            this.PoundTextBox.TextChanged += new System.EventHandler(this.OnPoundTextBoxChanged);
            // 
            // PoundLabel
            // 
            this.PoundLabel.AutoSize = true;
            this.PoundLabel.Location = new System.Drawing.Point(39, 159);
            this.PoundLabel.Name = "PoundLabel";
            this.PoundLabel.Size = new System.Drawing.Size(71, 17);
            this.PoundLabel.TabIndex = 5;
            this.PoundLabel.Text = "Pound (£)";
            // 
            // PoundErrorProvider
            // 
            this.PoundErrorProvider.ContainerControl = this;
            // 
            // CurrencyCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 260);
            this.Controls.Add(this.PoundLabel);
            this.Controls.Add(this.PoundTextBox);
            this.Controls.Add(this.DollarLabel);
            this.Controls.Add(this.DollarTextBox);
            this.Controls.Add(this.EuroLabel);
            this.Controls.Add(this.EuroTextBox);
            this.MinimumSize = new System.Drawing.Size(503, 239);
            this.Name = "CurrencyCalculatorForm";
            this.Text = "Currency Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.EuroErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollarErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoundErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EuroTextBox;
        private System.Windows.Forms.Label EuroLabel;
        private System.Windows.Forms.TextBox DollarTextBox;
        private System.Windows.Forms.Label DollarLabel;
        private System.Windows.Forms.ErrorProvider EuroErrorProvider;
        private System.Windows.Forms.ErrorProvider DollarErrorProvider;
        private System.Windows.Forms.Label PoundLabel;
        private System.Windows.Forms.TextBox PoundTextBox;
        private System.Windows.Forms.ErrorProvider PoundErrorProvider;
    }
}