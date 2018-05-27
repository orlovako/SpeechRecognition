namespace SpeechRecognition
{
    partial class SpeechRecognitionForm
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
            this.lbWorkspace = new System.Windows.Forms.ListBox();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.lbColor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWorkspace
            // 
            this.lbWorkspace.FormattingEnabled = true;
            this.lbWorkspace.ItemHeight = 16;
            this.lbWorkspace.Location = new System.Drawing.Point(50, 49);
            this.lbWorkspace.Name = "lbWorkspace";
            this.lbWorkspace.Size = new System.Drawing.Size(365, 196);
            this.lbWorkspace.TabIndex = 0;
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(444, 162);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(100, 30);
            this.btnEnable.TabIndex = 1;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(444, 216);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(100, 29);
            this.btnDisable.TabIndex = 2;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(441, 49);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(92, 17);
            this.lbColor.TabIndex = 3;
            this.lbColor.Text = "Change color";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(444, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SpeechRecognitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 297);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.lbWorkspace);
            this.Name = "SpeechRecognitionForm";
            this.Text = "SpeechRecognition";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWorkspace;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

