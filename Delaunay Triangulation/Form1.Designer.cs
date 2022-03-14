namespace Delaunay_Triangulation
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.gennods = new System.Windows.Forms.Button();
            this.Joindots = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(846, 605);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // gennods
            // 
            this.gennods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gennods.Location = new System.Drawing.Point(894, 285);
            this.gennods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gennods.Name = "gennods";
            this.gennods.Size = new System.Drawing.Size(182, 50);
            this.gennods.TabIndex = 1;
            this.gennods.Text = "Генерация точек";
            this.gennods.UseVisualStyleBackColor = true;
            this.gennods.Click += new System.EventHandler(this.gennods_Click);
            // 
            // Joindots
            // 
            this.Joindots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Joindots.Location = new System.Drawing.Point(894, 432);
            this.Joindots.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Joindots.Name = "Joindots";
            this.Joindots.Size = new System.Drawing.Size(181, 66);
            this.Joindots.TabIndex = 2;
            this.Joindots.Text = "Соединить точки";
            this.Joindots.UseVisualStyleBackColor = true;
            this.Joindots.Click += new System.EventHandler(this.Joindots_Click);
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(929, 57);
            this.Count.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(147, 22);
            this.Count.TabIndex = 3;
            this.Count.Text = "4";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(904, 120);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Окружности";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(892, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "N= ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Joindots);
            this.Controls.Add(this.gennods);
            this.Controls.Add(this.picture);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button gennods;
        private System.Windows.Forms.Button Joindots;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
    }
}

