
namespace MegaSolutionEquation
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
            this.MatrixText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочитатьИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимВводаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимВыводаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Solution = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.TextBox();
            this.Triangular = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatrixText
            // 
            this.MatrixText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.MatrixText.Location = new System.Drawing.Point(0, 27);
            this.MatrixText.Name = "MatrixText";
            this.MatrixText.Size = new System.Drawing.Size(225, 225);
            this.MatrixText.TabIndex = 0;
            this.MatrixText.Text = "";
            this.MatrixText.TextChanged += new System.EventHandler(this.MatrixText_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прочитатьИзФайлаToolStripMenuItem,
            this.режимВводаToolStripMenuItem,
            this.режимВыводаToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // прочитатьИзФайлаToolStripMenuItem
            // 
            this.прочитатьИзФайлаToolStripMenuItem.Name = "прочитатьИзФайлаToolStripMenuItem";
            this.прочитатьИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.прочитатьИзФайлаToolStripMenuItem.Text = "Прочитать из файла";
            this.прочитатьИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.прочитатьИзФайлаToolStripMenuItem_Click);
            // 
            // режимВводаToolStripMenuItem
            // 
            this.режимВводаToolStripMenuItem.Name = "режимВводаToolStripMenuItem";
            this.режимВводаToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.режимВводаToolStripMenuItem.Text = "Режим ввода";
            // 
            // режимВыводаToolStripMenuItem
            // 
            this.режимВыводаToolStripMenuItem.Name = "режимВыводаToolStripMenuItem";
            this.режимВыводаToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.режимВыводаToolStripMenuItem.Text = "Режим вывода";
            // 
            // Solution
            // 
            this.Solution.Location = new System.Drawing.Point(231, 27);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(234, 33);
            this.Solution.TabIndex = 2;
            this.Solution.Text = "Решить";
            this.Solution.UseVisualStyleBackColor = true;
            this.Solution.Click += new System.EventHandler(this.Solution_Click);
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Answer.Location = new System.Drawing.Point(231, 66);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(234, 26);
            this.Answer.TabIndex = 3;
            // 
            // Triangular
            // 
            this.Triangular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Triangular.Location = new System.Drawing.Point(471, 27);
            this.Triangular.Name = "Triangular";
            this.Triangular.Size = new System.Drawing.Size(225, 225);
            this.Triangular.TabIndex = 4;
            this.Triangular.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 268);
            this.Controls.Add(this.Triangular);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Solution);
            this.Controls.Add(this.MatrixText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MatSLA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MatrixText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Solution;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочитатьИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимВводаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимВыводаToolStripMenuItem;
        private System.Windows.Forms.RichTextBox Triangular;
    }
}

