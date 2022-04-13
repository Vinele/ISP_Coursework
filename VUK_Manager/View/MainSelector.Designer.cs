namespace VUK_Manager.View
{
    partial class MainSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSelector));
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.lengthBox = new System.Windows.Forms.ComboBox();
            this.widthBox = new System.Windows.Forms.ComboBox();
            this.wrongValueLabel = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.MaskedTextBox();
            this.dimensionsLabel = new System.Windows.Forms.Label();
            this.topConfigBox = new System.Windows.Forms.ComboBox();
            this.bottomConfigBox = new System.Windows.Forms.ComboBox();
            this.weightBox = new System.Windows.Forms.ComboBox();
            this.weighLabel = new System.Windows.Forms.Label();
            this.densityBox = new System.Windows.Forms.ComboBox();
            this.densityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.clothPriceBox = new System.Windows.Forms.MaskedTextBox();
            this.threadLabel = new System.Windows.Forms.Label();
            this.threadBox = new System.Windows.Forms.ComboBox();
            this.workLabel = new System.Windows.Forms.Label();
            this.workBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.bottomLabel = new System.Windows.Forms.Label();
            this.fullPriceLabel = new System.Windows.Forms.Label();
            this.slingLenghtBox = new System.Windows.Forms.MaskedTextBox();
            this.slingLeghtLabel = new System.Windows.Forms.Label();
            this.twoSlingsCheckBox = new System.Windows.Forms.CheckBox();
            this.constantsEditButton = new System.Windows.Forms.Button();
            this.densityTopLabel = new System.Windows.Forms.Label();
            this.densityTopBox = new System.Windows.Forms.ComboBox();
            this.densityBottomLabel = new System.Windows.Forms.Label();
            this.densityBottomBox = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.versionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(16, 64);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(17, 17);
            this.lengthLabel.TabIndex = 3;
            this.lengthLabel.Text = "A";
            this.mainToolTip.SetToolTip(this.lengthLabel, "Длина");
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(16, 97);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(17, 17);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "B";
            this.mainToolTip.SetToolTip(this.widthLabel, "Ширина");
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(16, 130);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(18, 17);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "H";
            this.mainToolTip.SetToolTip(this.heightLabel, "Высота");
            // 
            // lengthBox
            // 
            this.lengthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lengthBox.FormattingEnabled = true;
            this.lengthBox.Items.AddRange(new object[] {
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.lengthBox.Location = new System.Drawing.Point(44, 60);
            this.lengthBox.Margin = new System.Windows.Forms.Padding(4);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(160, 24);
            this.lengthBox.TabIndex = 6;
            this.lengthBox.SelectedIndexChanged += new System.EventHandler(this.lengthBox_SelectedIndexChanged);
            // 
            // widthBox
            // 
            this.widthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.widthBox.FormattingEnabled = true;
            this.widthBox.Items.AddRange(new object[] {
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.widthBox.Location = new System.Drawing.Point(44, 94);
            this.widthBox.Margin = new System.Windows.Forms.Padding(4);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(160, 24);
            this.widthBox.TabIndex = 7;
            this.widthBox.SelectedIndexChanged += new System.EventHandler(this.widthBox_SelectedIndexChanged);
            // 
            // wrongValueLabel
            // 
            this.wrongValueLabel.AutoSize = true;
            this.wrongValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongValueLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.wrongValueLabel.Location = new System.Drawing.Point(40, 155);
            this.wrongValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wrongValueLabel.Name = "wrongValueLabel";
            this.wrongValueLabel.Size = new System.Drawing.Size(68, 20);
            this.wrongValueLabel.TabIndex = 9;
            this.wrongValueLabel.Text = "CHECK";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(44, 129);
            this.heightBox.Margin = new System.Windows.Forms.Padding(4);
            this.heightBox.Mask = "000";
            this.heightBox.Name = "heightBox";
            this.heightBox.PromptChar = '´';
            this.heightBox.Size = new System.Drawing.Size(160, 22);
            this.heightBox.TabIndex = 10;
            this.heightBox.Click += new System.EventHandler(this.heightBox_Click);
            this.heightBox.Leave += new System.EventHandler(this.heightBox_Leave);
            // 
            // dimensionsLabel
            // 
            this.dimensionsLabel.AutoSize = true;
            this.dimensionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dimensionsLabel.Location = new System.Drawing.Point(40, 23);
            this.dimensionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dimensionsLabel.Name = "dimensionsLabel";
            this.dimensionsLabel.Size = new System.Drawing.Size(72, 18);
            this.dimensionsLabel.TabIndex = 11;
            this.dimensionsLabel.Text = "Размеры";
            this.mainToolTip.SetToolTip(this.dimensionsLabel, "См");
            // 
            // topConfigBox
            // 
            this.topConfigBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.topConfigBox.FormattingEnabled = true;
            this.topConfigBox.Items.AddRange(new object[] {
            "Открытый Верх",
            "Загрузочный Клапан",
            "Верхняя Сборка (юбка)",
            "Верхняя Крышка (лацкан)"});
            this.topConfigBox.Location = new System.Drawing.Point(441, 62);
            this.topConfigBox.Margin = new System.Windows.Forms.Padding(4);
            this.topConfigBox.Name = "topConfigBox";
            this.topConfigBox.Size = new System.Drawing.Size(455, 24);
            this.topConfigBox.TabIndex = 12;
            this.topConfigBox.SelectedIndexChanged += new System.EventHandler(this.topConfigBox_SelectedIndexChanged);
            // 
            // bottomConfigBox
            // 
            this.bottomConfigBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bottomConfigBox.FormattingEnabled = true;
            this.bottomConfigBox.Items.AddRange(new object[] {
            "Цельное Дно",
            "Разгрузочный Клапан"});
            this.bottomConfigBox.Location = new System.Drawing.Point(440, 127);
            this.bottomConfigBox.Margin = new System.Windows.Forms.Padding(4);
            this.bottomConfigBox.Name = "bottomConfigBox";
            this.bottomConfigBox.Size = new System.Drawing.Size(455, 24);
            this.bottomConfigBox.TabIndex = 13;
            this.bottomConfigBox.SelectedIndexChanged += new System.EventHandler(this.bottomConfigBox_SelectedIndexChanged);
            // 
            // weightBox
            // 
            this.weightBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightBox.FormattingEnabled = true;
            this.weightBox.Items.AddRange(new object[] {
            "1",
            "1 - 1.5",
            "1.5 - 1.8",
            "1.8  - 2.0"});
            this.weightBox.Location = new System.Drawing.Point(44, 254);
            this.weightBox.Margin = new System.Windows.Forms.Padding(4);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(160, 24);
            this.weightBox.TabIndex = 17;
            this.weightBox.SelectedIndexChanged += new System.EventHandler(this.weightBox_SelectedIndexChanged);
            // 
            // weighLabel
            // 
            this.weighLabel.AutoSize = true;
            this.weighLabel.Location = new System.Drawing.Point(40, 233);
            this.weighLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weighLabel.Name = "weighLabel";
            this.weighLabel.Size = new System.Drawing.Size(101, 17);
            this.weighLabel.TabIndex = 18;
            this.weighLabel.Text = "Насыпной вес";
            this.mainToolTip.SetToolTip(this.weighLabel, "Тонна");
            // 
            // densityBox
            // 
            this.densityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.densityBox.FormattingEnabled = true;
            this.densityBox.Items.AddRange(new object[] {
            "140",
            "160",
            "180",
            "200"});
            this.densityBox.Location = new System.Drawing.Point(252, 60);
            this.densityBox.Margin = new System.Windows.Forms.Padding(4);
            this.densityBox.Name = "densityBox";
            this.densityBox.Size = new System.Drawing.Size(160, 24);
            this.densityBox.TabIndex = 20;
            this.densityBox.SelectedIndexChanged += new System.EventHandler(this.densityBox_SelectedIndexChanged);
            // 
            // densityLabel
            // 
            this.densityLabel.AutoSize = true;
            this.densityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.densityLabel.Location = new System.Drawing.Point(248, 38);
            this.densityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.Size = new System.Drawing.Size(127, 18);
            this.densityLabel.TabIndex = 21;
            this.densityLabel.Text = "Плотность ткани";
            this.mainToolTip.SetToolTip(this.densityLabel, "гр/м²");
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(248, 233);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(86, 18);
            this.priceLabel.TabIndex = 22;
            this.priceLabel.Text = "Цена ткани";
            this.mainToolTip.SetToolTip(this.priceLabel, "Рубли, с НДС");
            // 
            // clothPriceBox
            // 
            this.clothPriceBox.Location = new System.Drawing.Point(252, 255);
            this.clothPriceBox.Margin = new System.Windows.Forms.Padding(4);
            this.clothPriceBox.Mask = "000";
            this.clothPriceBox.Name = "clothPriceBox";
            this.clothPriceBox.PromptChar = '´';
            this.clothPriceBox.Size = new System.Drawing.Size(160, 22);
            this.clothPriceBox.TabIndex = 23;
            this.clothPriceBox.Click += new System.EventHandler(this.priceBox_Click);
            // 
            // threadLabel
            // 
            this.threadLabel.AutoSize = true;
            this.threadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threadLabel.Location = new System.Drawing.Point(436, 176);
            this.threadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.threadLabel.Name = "threadLabel";
            this.threadLabel.Size = new System.Drawing.Size(42, 18);
            this.threadLabel.TabIndex = 24;
            this.threadLabel.Text = "Нить";
            this.mainToolTip.SetToolTip(this.threadLabel, "Кг");
            // 
            // threadBox
            // 
            this.threadBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.threadBox.FormattingEnabled = true;
            this.threadBox.Items.AddRange(new object[] {
            "0,03",
            "0,05"});
            this.threadBox.Location = new System.Drawing.Point(440, 198);
            this.threadBox.Margin = new System.Windows.Forms.Padding(4);
            this.threadBox.Name = "threadBox";
            this.threadBox.Size = new System.Drawing.Size(160, 24);
            this.threadBox.TabIndex = 25;
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workLabel.Location = new System.Drawing.Point(40, 176);
            this.workLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(88, 18);
            this.workLabel.TabIndex = 26;
            this.workLabel.Text = "Цена работ";
            this.mainToolTip.SetToolTip(this.workLabel, "Рубли, без НДС");
            // 
            // workBox
            // 
            this.workBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workBox.FormattingEnabled = true;
            this.workBox.Items.AddRange(new object[] {
            "60",
            "70",
            "80",
            "90"});
            this.workBox.Location = new System.Drawing.Point(44, 198);
            this.workBox.Margin = new System.Windows.Forms.Padding(4);
            this.workBox.Name = "workBox";
            this.workBox.Size = new System.Drawing.Size(160, 24);
            this.workBox.TabIndex = 27;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(796, 250);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 28);
            this.calculateButton.TabIndex = 28;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topLabel.Location = new System.Drawing.Point(437, 38);
            this.topLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(41, 18);
            this.topLabel.TabIndex = 29;
            this.topLabel.Text = "Верх";
            // 
            // bottomLabel
            // 
            this.bottomLabel.AutoSize = true;
            this.bottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bottomLabel.Location = new System.Drawing.Point(437, 105);
            this.bottomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(35, 18);
            this.bottomLabel.TabIndex = 30;
            this.bottomLabel.Text = "Низ";
            // 
            // fullPriceLabel
            // 
            this.fullPriceLabel.AutoSize = true;
            this.fullPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullPriceLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.fullPriceLabel.Location = new System.Drawing.Point(608, 198);
            this.fullPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullPriceLabel.Name = "fullPriceLabel";
            this.fullPriceLabel.Size = new System.Drawing.Size(64, 20);
            this.fullPriceLabel.TabIndex = 33;
            this.fullPriceLabel.Text = "PRICE";
            // 
            // slingLenghtBox
            // 
            this.slingLenghtBox.Location = new System.Drawing.Point(440, 255);
            this.slingLenghtBox.Margin = new System.Windows.Forms.Padding(4);
            this.slingLenghtBox.Mask = "0.00";
            this.slingLenghtBox.Name = "slingLenghtBox";
            this.slingLenghtBox.PromptChar = '´';
            this.slingLenghtBox.Size = new System.Drawing.Size(160, 22);
            this.slingLenghtBox.TabIndex = 34;
            this.slingLenghtBox.Click += new System.EventHandler(this.slingLenghtBox_Click);
            // 
            // slingLeghtLabel
            // 
            this.slingLeghtLabel.AutoSize = true;
            this.slingLeghtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slingLeghtLabel.Location = new System.Drawing.Point(437, 233);
            this.slingLeghtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slingLeghtLabel.Name = "slingLeghtLabel";
            this.slingLeghtLabel.Size = new System.Drawing.Size(108, 18);
            this.slingLeghtLabel.TabIndex = 35;
            this.slingLeghtLabel.Text = "Длина стропы";
            this.mainToolTip.SetToolTip(this.slingLeghtLabel, "Метры");
            // 
            // twoSlingsCheckBox
            // 
            this.twoSlingsCheckBox.AutoSize = true;
            this.twoSlingsCheckBox.Location = new System.Drawing.Point(607, 257);
            this.twoSlingsCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.twoSlingsCheckBox.Name = "twoSlingsCheckBox";
            this.twoSlingsCheckBox.Size = new System.Drawing.Size(109, 21);
            this.twoSlingsCheckBox.TabIndex = 36;
            this.twoSlingsCheckBox.Text = "2х стропник";
            this.twoSlingsCheckBox.UseVisualStyleBackColor = true;
            this.twoSlingsCheckBox.CheckedChanged += new System.EventHandler(this.twoSlingsCheckBox_CheckedChanged);
            // 
            // constantsEditButton
            // 
            this.constantsEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.constantsEditButton.Location = new System.Drawing.Point(863, 14);
            this.constantsEditButton.Margin = new System.Windows.Forms.Padding(4);
            this.constantsEditButton.Name = "constantsEditButton";
            this.constantsEditButton.Size = new System.Drawing.Size(32, 28);
            this.constantsEditButton.TabIndex = 37;
            this.constantsEditButton.Text = "⚙";
            this.mainToolTip.SetToolTip(this.constantsEditButton, "Редактирование констант");
            this.constantsEditButton.UseVisualStyleBackColor = true;
            this.constantsEditButton.Click += new System.EventHandler(this.constantsEditButton_Click);
            // 
            // densityTopLabel
            // 
            this.densityTopLabel.AutoSize = true;
            this.densityTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.densityTopLabel.Location = new System.Drawing.Point(248, 176);
            this.densityTopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.densityTopLabel.Name = "densityTopLabel";
            this.densityTopLabel.Size = new System.Drawing.Size(142, 18);
            this.densityTopLabel.TabIndex = 41;
            this.densityTopLabel.Text = "Плотность крышки";
            this.mainToolTip.SetToolTip(this.densityTopLabel, "гр/м²");
            // 
            // densityTopBox
            // 
            this.densityTopBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.densityTopBox.FormattingEnabled = true;
            this.densityTopBox.Items.AddRange(new object[] {
            "140",
            "160",
            "180",
            "200"});
            this.densityTopBox.Location = new System.Drawing.Point(252, 198);
            this.densityTopBox.Margin = new System.Windows.Forms.Padding(4);
            this.densityTopBox.Name = "densityTopBox";
            this.densityTopBox.Size = new System.Drawing.Size(160, 24);
            this.densityTopBox.TabIndex = 40;
            // 
            // densityBottomLabel
            // 
            this.densityBottomLabel.AutoSize = true;
            this.densityBottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.densityBottomLabel.Location = new System.Drawing.Point(248, 105);
            this.densityBottomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.densityBottomLabel.Name = "densityBottomLabel";
            this.densityBottomLabel.Size = new System.Drawing.Size(113, 18);
            this.densityBottomLabel.TabIndex = 43;
            this.densityBottomLabel.Text = "Плотность дна";
            this.mainToolTip.SetToolTip(this.densityBottomLabel, "гр/м²");
            // 
            // densityBottomBox
            // 
            this.densityBottomBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.densityBottomBox.FormattingEnabled = true;
            this.densityBottomBox.Items.AddRange(new object[] {
            "140",
            "160",
            "180",
            "200"});
            this.densityBottomBox.Location = new System.Drawing.Point(252, 127);
            this.densityBottomBox.Margin = new System.Windows.Forms.Padding(4);
            this.densityBottomBox.Name = "densityBottomBox";
            this.densityBottomBox.Size = new System.Drawing.Size(160, 24);
            this.densityBottomBox.TabIndex = 42;
            // 
            // refreshButton
            // 
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.Location = new System.Drawing.Point(756, 250);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(32, 28);
            this.refreshButton.TabIndex = 44;
            this.refreshButton.Text = "⭯";
            this.mainToolTip.SetToolTip(this.refreshButton, "Сбрасывает выбранный ранее рукав и все расчеты");
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionLabel.ForeColor = System.Drawing.Color.Gray;
            this.versionLabel.Location = new System.Drawing.Point(806, 19);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(53, 18);
            this.versionLabel.TabIndex = 45;
            this.versionLabel.Text = "V 1.0.0";
            // 
            // MainSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 289);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.densityBottomLabel);
            this.Controls.Add(this.densityBottomBox);
            this.Controls.Add(this.densityTopLabel);
            this.Controls.Add(this.densityTopBox);
            this.Controls.Add(this.constantsEditButton);
            this.Controls.Add(this.twoSlingsCheckBox);
            this.Controls.Add(this.slingLeghtLabel);
            this.Controls.Add(this.slingLenghtBox);
            this.Controls.Add(this.fullPriceLabel);
            this.Controls.Add(this.bottomLabel);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.workBox);
            this.Controls.Add(this.workLabel);
            this.Controls.Add(this.threadBox);
            this.Controls.Add(this.threadLabel);
            this.Controls.Add(this.clothPriceBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.densityLabel);
            this.Controls.Add(this.densityBox);
            this.Controls.Add(this.weighLabel);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.bottomConfigBox);
            this.Controls.Add(this.topConfigBox);
            this.Controls.Add(this.dimensionsLabel);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.wrongValueLabel);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(927, 336);
            this.MinimumSize = new System.Drawing.Size(927, 336);
            this.Name = "MainSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Волжская Упаковочная Компания";
            this.Load += new System.EventHandler(this.MainSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.ComboBox lengthBox;
        private System.Windows.Forms.ComboBox widthBox;
        private System.Windows.Forms.Label wrongValueLabel;
        private System.Windows.Forms.MaskedTextBox heightBox;
        private System.Windows.Forms.Label dimensionsLabel;
        private System.Windows.Forms.ComboBox topConfigBox;
        private System.Windows.Forms.ComboBox bottomConfigBox;
        private System.Windows.Forms.ComboBox weightBox;
        private System.Windows.Forms.Label weighLabel;
        private System.Windows.Forms.ComboBox densityBox;
        private System.Windows.Forms.Label densityLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.MaskedTextBox clothPriceBox;
        private System.Windows.Forms.Label threadLabel;
        private System.Windows.Forms.ComboBox threadBox;
        private System.Windows.Forms.Label workLabel;
        private System.Windows.Forms.ComboBox workBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label bottomLabel;
        private System.Windows.Forms.Label fullPriceLabel;
        private System.Windows.Forms.MaskedTextBox slingLenghtBox;
        private System.Windows.Forms.Label slingLeghtLabel;
        private System.Windows.Forms.CheckBox twoSlingsCheckBox;
        private System.Windows.Forms.Button constantsEditButton;
        private System.Windows.Forms.Label densityTopLabel;
        private System.Windows.Forms.ComboBox densityTopBox;
        private System.Windows.Forms.Label densityBottomLabel;
        private System.Windows.Forms.ComboBox densityBottomBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Label versionLabel;
    }
}