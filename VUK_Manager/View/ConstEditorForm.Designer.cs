
namespace VUK_Manager.View
{
    partial class ConstEditorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstEditorForm));
            this.acceptButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.vatLabel = new System.Windows.Forms.Label();
            this.bagLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.webbingLabel = new System.Windows.Forms.Label();
            this.pricePerMeterLabel = new System.Windows.Forms.Label();
            this.constToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.threadPriceLabel = new System.Windows.Forms.Label();
            this.threadPriceBox = new System.Windows.Forms.MaskedTextBox();
            this.webbingTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fileTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bagTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pricePerMeterTextBox = new System.Windows.Forms.MaskedTextBox();
            this.vatTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(215, 147);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(111, 29);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Применить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.statusLabel.Location = new System.Drawing.Point(12, 103);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLabel.Size = new System.Drawing.Size(197, 73);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "STATUS";
            // 
            // vatLabel
            // 
            this.vatLabel.AutoSize = true;
            this.vatLabel.Location = new System.Drawing.Point(223, 10);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(38, 17);
            this.vatLabel.TabIndex = 3;
            this.vatLabel.Text = "НДС";
            this.constToolTip.SetToolTip(this.vatLabel, "Проценты");
            // 
            // bagLabel
            // 
            this.bagLabel.AutoSize = true;
            this.bagLabel.Location = new System.Drawing.Point(8, 57);
            this.bagLabel.Name = "bagLabel";
            this.bagLabel.Size = new System.Drawing.Size(53, 17);
            this.bagLabel.TabIndex = 5;
            this.bagLabel.Text = "Мешок";
            this.constToolTip.SetToolTip(this.bagLabel, "Рубли");
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(223, 56);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(45, 17);
            this.fileLabel.TabIndex = 9;
            this.fileLabel.Text = "Файл";
            this.constToolTip.SetToolTip(this.fileLabel, "Рубли");
            // 
            // webbingLabel
            // 
            this.webbingLabel.AutoSize = true;
            this.webbingLabel.Location = new System.Drawing.Point(115, 56);
            this.webbingLabel.Name = "webbingLabel";
            this.webbingLabel.Size = new System.Drawing.Size(56, 17);
            this.webbingLabel.TabIndex = 7;
            this.webbingLabel.Text = "Тесьма";
            this.constToolTip.SetToolTip(this.webbingLabel, "Цена за метр");
            // 
            // pricePerMeterLabel
            // 
            this.pricePerMeterLabel.AutoSize = true;
            this.pricePerMeterLabel.Location = new System.Drawing.Point(115, 10);
            this.pricePerMeterLabel.Name = "pricePerMeterLabel";
            this.pricePerMeterLabel.Size = new System.Drawing.Size(56, 17);
            this.pricePerMeterLabel.TabIndex = 11;
            this.pricePerMeterLabel.Text = "Стропа";
            this.constToolTip.SetToolTip(this.pricePerMeterLabel, "Цена за метр");
            // 
            // threadPriceLabel
            // 
            this.threadPriceLabel.AutoSize = true;
            this.threadPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threadPriceLabel.Location = new System.Drawing.Point(8, 8);
            this.threadPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.threadPriceLabel.Name = "threadPriceLabel";
            this.threadPriceLabel.Size = new System.Drawing.Size(78, 18);
            this.threadPriceLabel.TabIndex = 33;
            this.threadPriceLabel.Text = "Цена нити";
            this.constToolTip.SetToolTip(this.threadPriceLabel, "Рубли");
            // 
            // threadPriceBox
            // 
            this.threadPriceBox.Location = new System.Drawing.Point(12, 30);
            this.threadPriceBox.Margin = new System.Windows.Forms.Padding(4);
            this.threadPriceBox.Name = "threadPriceBox";
            this.threadPriceBox.PromptChar = '´';
            this.threadPriceBox.Size = new System.Drawing.Size(100, 22);
            this.threadPriceBox.TabIndex = 34;
            this.threadPriceBox.TextChanged += new System.EventHandler(this.threadPriceBox_TextChanged);
            // 
            // webbingTextBox
            // 
            this.webbingTextBox.Location = new System.Drawing.Point(118, 77);
            this.webbingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.webbingTextBox.Name = "webbingTextBox";
            this.webbingTextBox.PromptChar = '´';
            this.webbingTextBox.Size = new System.Drawing.Size(100, 22);
            this.webbingTextBox.TabIndex = 39;
            this.webbingTextBox.TextChanged += new System.EventHandler(this.webbingTextBox_TextChanged);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(226, 77);
            this.fileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.PromptChar = '´';
            this.fileTextBox.Size = new System.Drawing.Size(100, 22);
            this.fileTextBox.TabIndex = 40;
            this.fileTextBox.TextChanged += new System.EventHandler(this.fileTextBox_TextChanged);
            // 
            // bagTextBox
            // 
            this.bagTextBox.Location = new System.Drawing.Point(11, 77);
            this.bagTextBox.Name = "bagTextBox";
            this.bagTextBox.Size = new System.Drawing.Size(100, 22);
            this.bagTextBox.TabIndex = 41;
            this.bagTextBox.TextChanged += new System.EventHandler(this.bagTextBox_TextChanged);
            // 
            // pricePerMeterTextBox
            // 
            this.pricePerMeterTextBox.Location = new System.Drawing.Point(118, 30);
            this.pricePerMeterTextBox.Name = "pricePerMeterTextBox";
            this.pricePerMeterTextBox.Size = new System.Drawing.Size(100, 22);
            this.pricePerMeterTextBox.TabIndex = 42;
            this.pricePerMeterTextBox.TextChanged += new System.EventHandler(this.pricePerMeterTextBox_TextChanged);
            // 
            // vatTextBox
            // 
            this.vatTextBox.Location = new System.Drawing.Point(226, 30);
            this.vatTextBox.Name = "vatTextBox";
            this.vatTextBox.Size = new System.Drawing.Size(100, 22);
            this.vatTextBox.TabIndex = 43;
            this.vatTextBox.TextChanged += new System.EventHandler(this.vatTextBox_TextChanged);
            // 
            // ConstEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 186);
            this.Controls.Add(this.vatTextBox);
            this.Controls.Add(this.pricePerMeterTextBox);
            this.Controls.Add(this.bagTextBox);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.webbingTextBox);
            this.Controls.Add(this.threadPriceBox);
            this.Controls.Add(this.threadPriceLabel);
            this.Controls.Add(this.pricePerMeterLabel);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.webbingLabel);
            this.Controls.Add(this.bagLabel);
            this.Controls.Add(this.vatLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.acceptButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(353, 233);
            this.MinimumSize = new System.Drawing.Size(353, 233);
            this.Name = "ConstEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.ConstEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.Label bagLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label webbingLabel;
        private System.Windows.Forms.ToolTip constToolTip;
        private System.Windows.Forms.Label pricePerMeterLabel;
        private System.Windows.Forms.MaskedTextBox threadPriceBox;
        private System.Windows.Forms.Label threadPriceLabel;
        private System.Windows.Forms.MaskedTextBox webbingTextBox;
        private System.Windows.Forms.MaskedTextBox fileTextBox;
        private System.Windows.Forms.MaskedTextBox bagTextBox;
        private System.Windows.Forms.MaskedTextBox pricePerMeterTextBox;
        private System.Windows.Forms.MaskedTextBox vatTextBox;
    }
}