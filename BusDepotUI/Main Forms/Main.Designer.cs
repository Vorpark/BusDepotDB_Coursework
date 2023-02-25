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
            this.формаМодератораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полноеОтслеживаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BusesTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DriversTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CoursesTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BusModelsTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BusDepotsTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.автобусыВПToolStripMenuItem});
            this.отслеживаниеToolStripMenuItem.Name = "отслеживаниеToolStripMenuItem";
            this.отслеживаниеToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.отслеживаниеToolStripMenuItem.Text = "Отслеживание";
            // 
            // автобусыВПToolStripMenuItem
            // 
            this.автобусыВПToolStripMenuItem.Name = "автобусыВПToolStripMenuItem";
            this.автобусыВПToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.автобусыВПToolStripMenuItem.Text = "Местоположение автобусов";
            this.автобусыВПToolStripMenuItem.Click += new System.EventHandler(this.BusesTrackToolStripMenuItem_Click);
            // 
            // формаМодератораToolStripMenuItem
            // 
            this.формаМодератораToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.полноеОтслеживаниеToolStripMenuItem});
            this.формаМодератораToolStripMenuItem.Name = "формаМодератораToolStripMenuItem";
            this.формаМодератораToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.формаМодератораToolStripMenuItem.Text = "Форма модератора";
            // 
            // полноеОтслеживаниеToolStripMenuItem
            // 
            this.полноеОтслеживаниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BusesTrackToolStripMenuItem,
            this.DriversTrackToolStripMenuItem,
            this.CoursesTrackToolStripMenuItem,
            this.BusModelsTrackToolStripMenuItem,
            this.BusDepotsTrackToolStripMenuItem});
            this.полноеОтслеживаниеToolStripMenuItem.Name = "полноеОтслеживаниеToolStripMenuItem";
            this.полноеОтслеживаниеToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.полноеОтслеживаниеToolStripMenuItem.Text = "Отслеживание и редактирование";
            // 
            // BusesTrackToolStripMenuItem
            // 
            this.BusesTrackToolStripMenuItem.Name = "BusesTrackToolStripMenuItem";
            this.BusesTrackToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.BusesTrackToolStripMenuItem.Text = "Автобусы";
            this.BusesTrackToolStripMenuItem.Click += new System.EventHandler(this.BusesEditToolStripMenuItem_Click);
            // 
            // DriversTrackToolStripMenuItem
            // 
            this.DriversTrackToolStripMenuItem.Name = "DriversTrackToolStripMenuItem";
            this.DriversTrackToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.DriversTrackToolStripMenuItem.Text = "Водители";
            this.DriversTrackToolStripMenuItem.Click += new System.EventHandler(this.DriversEditToolStripMenuItem_Click);
            // 
            // CoursesTrackToolStripMenuItem
            // 
            this.CoursesTrackToolStripMenuItem.Name = "CoursesTrackToolStripMenuItem";
            this.CoursesTrackToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.CoursesTrackToolStripMenuItem.Text = "Маршруты";
            this.CoursesTrackToolStripMenuItem.Click += new System.EventHandler(this.RoutesEditToolStripMenuItem_Click);
            // 
            // BusModelsTrackToolStripMenuItem
            // 
            this.BusModelsTrackToolStripMenuItem.Name = "BusModelsTrackToolStripMenuItem";
            this.BusModelsTrackToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.BusModelsTrackToolStripMenuItem.Text = "Модели автобусов";
            this.BusModelsTrackToolStripMenuItem.Click += new System.EventHandler(this.BusModelsEditToolStripMenuItem_Click);
            // 
            // BusDepotsTrackToolStripMenuItem
            // 
            this.BusDepotsTrackToolStripMenuItem.Name = "BusDepotsTrackToolStripMenuItem";
            this.BusDepotsTrackToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.BusDepotsTrackToolStripMenuItem.Text = "Автобусные парковки";
            this.BusDepotsTrackToolStripMenuItem.Click += new System.EventHandler(this.BusDepotsEditToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem формаМодератораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полноеОтслеживаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BusesTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DriversTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CoursesTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BusModelsTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BusDepotsTrackToolStripMenuItem;
    }
}

