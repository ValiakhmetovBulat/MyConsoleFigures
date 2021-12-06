
namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxConsoleInput = new System.Windows.Forms.TextBox();
            this.comboBoxFigureList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBoxCommandHistory = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAutoFilling = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxConsoleInput
            // 
            this.textBoxConsoleInput.BackColor = System.Drawing.Color.Black;
            this.textBoxConsoleInput.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxConsoleInput.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxConsoleInput.Location = new System.Drawing.Point(12, 27);
            this.textBoxConsoleInput.Name = "textBoxConsoleInput";
            this.textBoxConsoleInput.Size = new System.Drawing.Size(606, 23);
            this.textBoxConsoleInput.TabIndex = 0;
            this.textBoxConsoleInput.TextChanged += new System.EventHandler(this.textBoxConsoleInput_TextChanged);
            this.textBoxConsoleInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxConsoleInput_KeyDown);
            // 
            // comboBoxFigureList
            // 
            this.comboBoxFigureList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFigureList.FormattingEnabled = true;
            this.comboBoxFigureList.Location = new System.Drawing.Point(658, 29);
            this.comboBoxFigureList.Name = "comboBoxFigureList";
            this.comboBoxFigureList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFigureList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(655, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список фигур";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(767, 378);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(624, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 38);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // richTextBoxCommandHistory
            // 
            this.richTextBoxCommandHistory.Location = new System.Drawing.Point(264, 56);
            this.richTextBoxCommandHistory.Name = "richTextBoxCommandHistory";
            this.richTextBoxCommandHistory.Size = new System.Drawing.Size(385, 143);
            this.richTextBoxCommandHistory.TabIndex = 5;
            this.richTextBoxCommandHistory.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "F9 - помощь";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBoxAutoFilling
            // 
            this.textBoxAutoFilling.BackColor = System.Drawing.Color.Black;
            this.textBoxAutoFilling.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAutoFilling.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxAutoFilling.Location = new System.Drawing.Point(12, 49);
            this.textBoxAutoFilling.Name = "textBoxAutoFilling";
            this.textBoxAutoFilling.ReadOnly = true;
            this.textBoxAutoFilling.Size = new System.Drawing.Size(606, 23);
            this.textBoxAutoFilling.TabIndex = 8;
            this.textBoxAutoFilling.Click += new System.EventHandler(this.textBoxAutoFilling_Click);
            this.textBoxAutoFilling.TextChanged += new System.EventHandler(this.textBoxAutoFilling_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(791, 446);
            this.Controls.Add(this.textBoxAutoFilling);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxCommandHistory);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFigureList);
            this.Controls.Add(this.textBoxConsoleInput);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Name = "Form1";
            this.Text = "Drawing Console";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConsoleInput;
        private System.Windows.Forms.ComboBox comboBoxFigureList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBoxCommandHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAutoFilling;
    }
}

