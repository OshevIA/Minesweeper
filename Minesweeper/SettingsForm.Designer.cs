namespace Minesweeper
{
    partial class SettingsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flagColorButton = new System.Windows.Forms.Button();
            this.mineColorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.columnsUpDown = new System.Windows.Forms.NumericUpDown();
            this.probabilityTrackBar = new System.Windows.Forms.TrackBar();
            this.rowsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.unrevealedColorButton = new System.Windows.Forms.Button();
            this.revealedColorButton = new System.Windows.Forms.Button();
            this.mineImageButton = new System.Windows.Forms.Button();
            this.flagImageButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Столбец";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveSettingsButton.AutoSize = true;
            this.saveSettingsButton.Location = new System.Drawing.Point(259, 305);
            this.saveSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(173, 32);
            this.saveSettingsButton.TabIndex = 2;
            this.saveSettingsButton.Text = "Сохранить";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Строки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.saveSettingsButton, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.flagColorButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.mineColorButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.columnsUpDown, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.probabilityTrackBar, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.rowsUpDown, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.unrevealedColorButton, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.revealedColorButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.mineImageButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flagImageButton, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 343);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flagColorButton
            // 
            this.flagColorButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flagColorButton.Location = new System.Drawing.Point(252, 116);
            this.flagColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.flagColorButton.Name = "flagColorButton";
            this.flagColorButton.Size = new System.Drawing.Size(160, 28);
            this.flagColorButton.TabIndex = 3;
            this.flagColorButton.Text = "Установить цвет";
            this.flagColorButton.UseVisualStyleBackColor = true;
            this.flagColorButton.Click += new System.EventHandler(this.flagColorButton_Click);
            // 
            // mineColorButton
            // 
            this.mineColorButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mineColorButton.Location = new System.Drawing.Point(252, 69);
            this.mineColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.mineColorButton.Name = "mineColorButton";
            this.mineColorButton.Size = new System.Drawing.Size(160, 28);
            this.mineColorButton.TabIndex = 14;
            this.mineColorButton.Text = "Установить цвет";
            this.mineColorButton.UseVisualStyleBackColor = true;
            this.mineColorButton.Click += new System.EventHandler(this.mineColorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 64);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вероятность бомбы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // columnsUpDown
            // 
            this.columnsUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.columnsUpDown.Location = new System.Drawing.Point(252, 34);
            this.columnsUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.columnsUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.columnsUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.columnsUpDown.Name = "columnsUpDown";
            this.columnsUpDown.Size = new System.Drawing.Size(160, 22);
            this.columnsUpDown.TabIndex = 5;
            this.columnsUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // probabilityTrackBar
            // 
            this.probabilityTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.probabilityTrackBar.LargeChange = 10;
            this.probabilityTrackBar.Location = new System.Drawing.Point(252, 240);
            this.probabilityTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.probabilityTrackBar.Name = "probabilityTrackBar";
            this.probabilityTrackBar.Size = new System.Drawing.Size(187, 56);
            this.probabilityTrackBar.TabIndex = 6;
            this.probabilityTrackBar.Value = 7;
            // 
            // rowsUpDown
            // 
            this.rowsUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rowsUpDown.Location = new System.Drawing.Point(252, 4);
            this.rowsUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.rowsUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.rowsUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.rowsUpDown.Name = "rowsUpDown";
            this.rowsUpDown.Size = new System.Drawing.Size(160, 22);
            this.rowsUpDown.TabIndex = 4;
            this.rowsUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "Неоткрытое поле";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 47);
            this.label5.TabIndex = 8;
            this.label5.Text = "Бомба";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 47);
            this.label6.TabIndex = 9;
            this.label6.Text = "Флаг";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(4, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "Открытое поле без бомбы";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unrevealedColorButton
            // 
            this.unrevealedColorButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.unrevealedColorButton.Location = new System.Drawing.Point(252, 199);
            this.unrevealedColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.unrevealedColorButton.Name = "unrevealedColorButton";
            this.unrevealedColorButton.Size = new System.Drawing.Size(160, 28);
            this.unrevealedColorButton.TabIndex = 19;
            this.unrevealedColorButton.Text = "Установить цвет";
            this.unrevealedColorButton.UseVisualStyleBackColor = true;
            this.unrevealedColorButton.Click += new System.EventHandler(this.unrevealedColorButton_Click);
            // 
            // revealedColorButton
            // 
            this.revealedColorButton.Location = new System.Drawing.Point(252, 158);
            this.revealedColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.revealedColorButton.Name = "revealedColorButton";
            this.revealedColorButton.Size = new System.Drawing.Size(160, 28);
            this.revealedColorButton.TabIndex = 20;
            this.revealedColorButton.Text = "Установить цвет";
            this.revealedColorButton.UseVisualStyleBackColor = true;
            this.revealedColorButton.Click += new System.EventHandler(this.revealedColorButton_Click);
            // 
            // mineImageButton
            // 
            this.mineImageButton.AutoSize = true;
            this.mineImageButton.BackgroundImage = global::Minesweeper.Properties.Resources.ImageIcon;
            this.mineImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mineImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mineImageButton.Location = new System.Drawing.Point(199, 64);
            this.mineImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.mineImageButton.Name = "mineImageButton";
            this.mineImageButton.Size = new System.Drawing.Size(45, 39);
            this.mineImageButton.TabIndex = 21;
            this.mineImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mineImageButton.UseVisualStyleBackColor = true;
            this.mineImageButton.Click += new System.EventHandler(this.mineImageButton_Click);
            // 
            // flagImageButton
            // 
            this.flagImageButton.AutoSize = true;
            this.flagImageButton.BackgroundImage = global::Minesweeper.Properties.Resources.ImageIcon;
            this.flagImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flagImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flagImageButton.Location = new System.Drawing.Point(199, 111);
            this.flagImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.flagImageButton.Name = "flagImageButton";
            this.flagImageButton.Size = new System.Drawing.Size(45, 39);
            this.flagImageButton.TabIndex = 22;
            this.flagImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.flagImageButton.UseVisualStyleBackColor = true;
            this.flagImageButton.Click += new System.EventHandler(this.flagImageButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 343);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ustawienia";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown rowsUpDown;
        private System.Windows.Forms.NumericUpDown columnsUpDown;
        private System.Windows.Forms.TrackBar probabilityTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button revealedColorButton;
        private System.Windows.Forms.Button unrevealedColorButton;
        private System.Windows.Forms.Button flagColorButton;
        private System.Windows.Forms.Button mineColorButton;
        private System.Windows.Forms.Button mineImageButton;
        private System.Windows.Forms.Button flagImageButton;
    }
}