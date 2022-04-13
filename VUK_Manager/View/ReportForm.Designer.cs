
namespace VUK_Manager.View
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.percentTextBox = new System.Windows.Forms.TextBox();
            this.dividingPanel = new System.Windows.Forms.Panel();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fullPriceLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.bottomListBox = new System.Windows.Forms.ListBox();
            this.topListBox = new System.Windows.Forms.ListBox();
            this.reportToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportTextBox);
            this.panel1.Controls.Add(this.percentTextBox);
            this.panel1.Controls.Add(this.dividingPanel);
            this.panel1.Controls.Add(this.customerTextBox);
            this.panel1.Controls.Add(this.printButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 450);
            this.panel1.TabIndex = 1;
            // 
            // reportTextBox
            // 
            this.reportTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportTextBox.Location = new System.Drawing.Point(0, 0);
            this.reportTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.ReadOnly = true;
            this.reportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reportTextBox.Size = new System.Drawing.Size(389, 359);
            this.reportTextBox.TabIndex = 1;
            // 
            // percentTextBox
            // 
            this.percentTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.percentTextBox.Location = new System.Drawing.Point(0, 359);
            this.percentTextBox.Name = "percentTextBox";
            this.percentTextBox.Size = new System.Drawing.Size(389, 22);
            this.percentTextBox.TabIndex = 37;
            this.percentTextBox.Text = "Процент накрутки";
            this.percentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.percentTextBox.Click += new System.EventHandler(this.percentTextBox_Click);
            this.percentTextBox.TextChanged += new System.EventHandler(this.percentTextBox_TextChanged);
            // 
            // dividingPanel
            // 
            this.dividingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dividingPanel.Location = new System.Drawing.Point(0, 381);
            this.dividingPanel.Name = "dividingPanel";
            this.dividingPanel.Size = new System.Drawing.Size(389, 10);
            this.dividingPanel.TabIndex = 36;
            // 
            // customerTextBox
            // 
            this.customerTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customerTextBox.Location = new System.Drawing.Point(0, 391);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(389, 22);
            this.customerTextBox.TabIndex = 35;
            this.customerTextBox.Text = "Наименование заказчика";
            this.customerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerTextBox.Click += new System.EventHandler(this.customerTextBox_Click);
            // 
            // printButton
            // 
            this.printButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.printButton.Location = new System.Drawing.Point(0, 413);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(389, 37);
            this.printButton.TabIndex = 35;
            this.printButton.Text = "Печать";
            this.reportToolTip.SetToolTip(this.printButton, "Отправка отчета на печать");
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fullPriceLabel);
            this.panel2.Controls.Add(this.acceptButton);
            this.panel2.Controls.Add(this.bottomListBox);
            this.panel2.Controls.Add(this.topListBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(389, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 450);
            this.panel2.TabIndex = 2;
            // 
            // fullPriceLabel
            // 
            this.fullPriceLabel.AutoSize = true;
            this.fullPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullPriceLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.fullPriceLabel.Location = new System.Drawing.Point(7, 366);
            this.fullPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullPriceLabel.Name = "fullPriceLabel";
            this.fullPriceLabel.Size = new System.Drawing.Size(68, 20);
            this.fullPriceLabel.TabIndex = 34;
            this.fullPriceLabel.Text = "LABEL";
            // 
            // acceptButton
            // 
            this.acceptButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.acceptButton.Location = new System.Drawing.Point(0, 413);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(411, 37);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Подтвердить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // bottomListBox
            // 
            this.bottomListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottomListBox.FormattingEnabled = true;
            this.bottomListBox.ItemHeight = 16;
            this.bottomListBox.Location = new System.Drawing.Point(0, 164);
            this.bottomListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottomListBox.Name = "bottomListBox";
            this.bottomListBox.Size = new System.Drawing.Size(411, 164);
            this.bottomListBox.TabIndex = 1;
            this.reportToolTip.SetToolTip(this.bottomListBox, "Стоимость донышек");
            // 
            // topListBox
            // 
            this.topListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.topListBox.FormattingEnabled = true;
            this.topListBox.ItemHeight = 16;
            this.topListBox.Location = new System.Drawing.Point(0, 0);
            this.topListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topListBox.Name = "topListBox";
            this.topListBox.Size = new System.Drawing.Size(411, 164);
            this.topListBox.TabIndex = 0;
            this.reportToolTip.SetToolTip(this.topListBox, "Стоимость крышек");
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox reportTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.ListBox bottomListBox;
        private System.Windows.Forms.ListBox topListBox;
        private System.Windows.Forms.Label fullPriceLabel;
        private System.Windows.Forms.ToolTip reportToolTip;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Panel dividingPanel;
        private System.Windows.Forms.TextBox percentTextBox;
    }
}