namespace BusDepotUI
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отслеживаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автобусыВПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автобусыВПутиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формаМодератораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полноеОтслеживаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отслеживаниеToolStripMenuItem,
            this.формаМодератораToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отслеживаниеToolStripMenuItem
            // 
            this.отслеживаниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автобусыВПToolStripMenuItem,
            this.автобусыВПутиToolStripMenuItem});
            this.отслеживаниеToolStripMenuItem.Name = "отслеживаниеToolStripMenuItem";
            this.отслеживаниеToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.отслеживаниеToolStripMenuItem.Text = "Отслеживание";
            // 
            // автобусыВПToolStripMenuItem
            // 
            this.автобусыВПToolStripMenuItem.Name = "автобусыВПToolStripMenuItem";
            this.автобусыВПToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.автобусыВПToolStripMenuItem.Text = "Парк автобусов";
            this.автобусыВПToolStripMenuItem.Click += new System.EventHandler(this.BusDepotTrackToolStripMenuItem_Click);
            // 
            // автобусыВПутиToolStripMenuItem
            // 
            this.автобусыВПутиToolStripMenuItem.Name = "автобусыВПутиToolStripMenuItem";
            this.автобусыВПутиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.автобусыВПутиToolStripMenuItem.Text = "Автобусы в пути";
            this.автобусыВПутиToolStripMenuItem.Click += new System.EventHandler(this.BusOnWayTrackToolStripMenuItem_Click);
            // 
            // формаМодератораToolStripMenuItem
            // 
            this.формаМодератораToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеToolStripMenuItem,
            this.полноеОтслеживаниеToolStripMenuItem});
            this.формаМодератораToolStripMenuItem.Name = "формаМодератораToolStripMenuItem";
            this.формаМодератораToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.формаМодератораToolStripMenuItem.Text = "Форма модератора";
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // полноеОтслеживаниеToolStripMenuItem
            // 
            this.полноеОтслеживаниеToolStripMenuItem.Name = "полноеОтслеживаниеToolStripMenuItem";
            this.полноеОтслеживаниеToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.полноеОтслеживаниеToolStripMenuItem.Text = "Полное отслеживание";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "BusDepot";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отслеживаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автобусыВПToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автобусыВПутиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формаМодератораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полноеОтслеживаниеToolStripMenuItem;
    }
}

