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
            this.автобусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.модельАвтобусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.автобуснаяПарковкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.автобусыВПToolStripMenuItem.Click += new System.EventHandler(this.BusInDepotTrackToolStripMenuItem_Click);
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
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автобусToolStripMenuItem,
            this.водительToolStripMenuItem,
            this.маршрутToolStripMenuItem,
            this.модельАвтобусаToolStripMenuItem,
            this.автобуснаяПарковкаToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.редактированиеToolStripMenuItem.Text = "Редактор";
            // 
            // автобусToolStripMenuItem
            // 
            this.автобусToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.автобусToolStripMenuItem.Name = "автобусToolStripMenuItem";
            this.автобусToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.автобусToolStripMenuItem.Text = "Автобус";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.BusAddToolStripMenuItem_Click);
            // 
            // водительToolStripMenuItem
            // 
            this.водительToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1});
            this.водительToolStripMenuItem.Name = "водительToolStripMenuItem";
            this.водительToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.водительToolStripMenuItem.Text = "Водитель";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.DriverAddToolStripMenuItem1_Click);
            // 
            // маршрутToolStripMenuItem
            // 
            this.маршрутToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2});
            this.маршрутToolStripMenuItem.Name = "маршрутToolStripMenuItem";
            this.маршрутToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.маршрутToolStripMenuItem.Text = "Маршрут";
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.RouteAddToolStripMenuItem2_Click);
            // 
            // модельАвтобусаToolStripMenuItem
            // 
            this.модельАвтобусаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem3});
            this.модельАвтобусаToolStripMenuItem.Name = "модельАвтобусаToolStripMenuItem";
            this.модельАвтобусаToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.модельАвтобусаToolStripMenuItem.Text = "Модель автобуса";
            // 
            // добавитьToolStripMenuItem3
            // 
            this.добавитьToolStripMenuItem3.Name = "добавитьToolStripMenuItem3";
            this.добавитьToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem3.Text = "Добавить";
            this.добавитьToolStripMenuItem3.Click += new System.EventHandler(this.BusModelAddToolStripMenuItem3_Click);
            // 
            // автобуснаяПарковкаToolStripMenuItem
            // 
            this.автобуснаяПарковкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem4});
            this.автобуснаяПарковкаToolStripMenuItem.Name = "автобуснаяПарковкаToolStripMenuItem";
            this.автобуснаяПарковкаToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.автобуснаяПарковкаToolStripMenuItem.Text = "Автобусная парковка";
            // 
            // добавитьToolStripMenuItem4
            // 
            this.добавитьToolStripMenuItem4.Name = "добавитьToolStripMenuItem4";
            this.добавитьToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem4.Text = "Добавить";
            this.добавитьToolStripMenuItem4.Click += new System.EventHandler(this.BusDepotAddToolStripMenuItem4_Click);
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
            this.полноеОтслеживаниеToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.полноеОтслеживаниеToolStripMenuItem.Text = "Полное отслеживание";
            // 
            // BusesTrackToolStripMenuItem
            // 
            this.BusesTrackToolStripMenuItem.Name = "BusesTrackToolStripMenuItem";
            this.BusesTrackToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.BusesTrackToolStripMenuItem.Text = "Автобусы";
            this.BusesTrackToolStripMenuItem.Click += new System.EventHandler(this.BusesTrackToolStripMenuItem_Click);
            // 
            // DriversTrackToolStripMenuItem
            // 
            this.DriversTrackToolStripMenuItem.Name = "DriversTrackToolStripMenuItem";
            this.DriversTrackToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.DriversTrackToolStripMenuItem.Text = "Водители";
            this.DriversTrackToolStripMenuItem.Click += new System.EventHandler(this.DriversTrackToolStripMenuItem_Click);
            // 
            // CoursesTrackToolStripMenuItem
            // 
            this.CoursesTrackToolStripMenuItem.Name = "CoursesTrackToolStripMenuItem";
            this.CoursesTrackToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.CoursesTrackToolStripMenuItem.Text = "Маршруты";
            this.CoursesTrackToolStripMenuItem.Click += new System.EventHandler(this.RoutesTrackToolStripMenuItem_Click);
            // 
            // BusModelsTrackToolStripMenuItem
            // 
            this.BusModelsTrackToolStripMenuItem.Name = "BusModelsTrackToolStripMenuItem";
            this.BusModelsTrackToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.BusModelsTrackToolStripMenuItem.Text = "Модели автобусов";
            this.BusModelsTrackToolStripMenuItem.Click += new System.EventHandler(this.BusModelsTrackToolStripMenuItem_Click);
            // 
            // BusDepotsTrackToolStripMenuItem
            // 
            this.BusDepotsTrackToolStripMenuItem.Name = "BusDepotsTrackToolStripMenuItem";
            this.BusDepotsTrackToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.BusDepotsTrackToolStripMenuItem.Text = "Автобусные парковки";
            this.BusDepotsTrackToolStripMenuItem.Click += new System.EventHandler(this.BusDepotsTrackToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem автобусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem водительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem маршрутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem модельАвтобусаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem автобуснаяПарковкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem BusesTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DriversTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CoursesTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BusModelsTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BusDepotsTrackToolStripMenuItem;
    }
}

