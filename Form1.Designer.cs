namespace Laba_5_CG
{
    partial class Window
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
            this.pB_Canv = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Canv)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_Canv
            // 
            this.pB_Canv.BackColor = System.Drawing.Color.White;
            this.pB_Canv.Location = new System.Drawing.Point(0, 0);
            this.pB_Canv.Name = "pB_Canv";
            this.pB_Canv.Size = new System.Drawing.Size(801, 450);
            this.pB_Canv.TabIndex = 0;
            this.pB_Canv.TabStop = false;
            this.pB_Canv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pB_Canv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pB_Canv_MouseMove);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pB_Canv);
            this.Name = "Window";
            this.Text = "Laba_5";
            ((System.ComponentModel.ISupportInitialize)(this.pB_Canv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_Canv;
    }
}

