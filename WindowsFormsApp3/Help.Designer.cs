
namespace WindowsFormsApp3
{
    partial class Help
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxDrawEllipse = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDeleteFigure = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMoveFigure = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список команд";
            // 
            // richTextBoxDrawEllipse
            // 
            this.richTextBoxDrawEllipse.BackColor = System.Drawing.Color.Black;
            this.richTextBoxDrawEllipse.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.richTextBoxDrawEllipse.Location = new System.Drawing.Point(12, 34);
            this.richTextBoxDrawEllipse.Name = "richTextBoxDrawEllipse";
            this.richTextBoxDrawEllipse.ReadOnly = true;
            this.richTextBoxDrawEllipse.Size = new System.Drawing.Size(298, 119);
            this.richTextBoxDrawEllipse.TabIndex = 1;
            this.richTextBoxDrawEllipse.Text = "";
            this.richTextBoxDrawEllipse.TextChanged += new System.EventHandler(this.richTextBoxDrawEllipse_TextChanged);
            // 
            // richTextBoxDeleteFigure
            // 
            this.richTextBoxDeleteFigure.BackColor = System.Drawing.Color.Black;
            this.richTextBoxDeleteFigure.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.richTextBoxDeleteFigure.Location = new System.Drawing.Point(326, 34);
            this.richTextBoxDeleteFigure.Name = "richTextBoxDeleteFigure";
            this.richTextBoxDeleteFigure.ReadOnly = true;
            this.richTextBoxDeleteFigure.Size = new System.Drawing.Size(298, 119);
            this.richTextBoxDeleteFigure.TabIndex = 2;
            this.richTextBoxDeleteFigure.Text = "";
            // 
            // richTextBoxMoveFigure
            // 
            this.richTextBoxMoveFigure.BackColor = System.Drawing.Color.Black;
            this.richTextBoxMoveFigure.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.richTextBoxMoveFigure.Location = new System.Drawing.Point(172, 168);
            this.richTextBoxMoveFigure.Name = "richTextBoxMoveFigure";
            this.richTextBoxMoveFigure.ReadOnly = true;
            this.richTextBoxMoveFigure.Size = new System.Drawing.Size(298, 119);
            this.richTextBoxMoveFigure.TabIndex = 3;
            this.richTextBoxMoveFigure.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(203, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "в вводимых командах пробелы недопустимы.";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(636, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxMoveFigure);
            this.Controls.Add(this.richTextBoxDeleteFigure);
            this.Controls.Add(this.richTextBoxDrawEllipse);
            this.Controls.Add(this.label1);
            this.Name = "Help";
            this.Text = "Command List";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDrawEllipse;
        private System.Windows.Forms.RichTextBox richTextBoxDeleteFigure;
        private System.Windows.Forms.RichTextBox richTextBoxMoveFigure;
        private System.Windows.Forms.Label label2;
    }
}