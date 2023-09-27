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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelActiveBusesCount = new System.Windows.Forms.Label();
            this.labelAllDriversCount = new System.Windows.Forms.Label();
            this.labelAllBusesCount = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(387, 24);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Актуальная статистика:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Общее кол-во автобусов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кол-во задействованных автобусов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Кол-во водителей:";
            // 
            // labelActiveBusesCount
            // 
            this.labelActiveBusesCount.AutoSize = true;
            this.labelActiveBusesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelActiveBusesCount.Location = new System.Drawing.Point(304, 116);
            this.labelActiveBusesCount.Name = "labelActiveBusesCount";
            this.labelActiveBusesCount.Size = new System.Drawing.Size(18, 20);
            this.labelActiveBusesCount.TabIndex = 5;
            this.labelActiveBusesCount.Text = "0";
            // 
            // labelAllDriversCount
            // 
            this.labelAllDriversCount.AutoSize = true;
            this.labelAllDriversCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAllDriversCount.Location = new System.Drawing.Point(304, 139);
            this.labelAllDriversCount.Name = "labelAllDriversCount";
            this.labelAllDriversCount.Size = new System.Drawing.Size(18, 20);
            this.labelAllDriversCount.TabIndex = 6;
            this.labelAllDriversCount.Text = "0";
            // 
            // labelAllBusesCount
            // 
            this.labelAllBusesCount.AutoSize = true;
            this.labelAllBusesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAllBusesCount.Location = new System.Drawing.Point(304, 93);
            this.labelAllBusesCount.Name = "labelAllBusesCount";
            this.labelAllBusesCount.Size = new System.Drawing.Size(18, 20);
            this.labelAllBusesCount.TabIndex = 7;
            this.labelAllBusesCount.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 291);
            this.Controls.Add(this.labelAllBusesCount);
            this.Controls.Add(this.labelAllDriversCount);
            this.Controls.Add(this.labelActiveBusesCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(403, 330);
            this.MinimumSize = new System.Drawing.Size(403, 330);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusDepot";
            this.VisibleChanged += new System.EventHandler(this.Main_VisibleChanged);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelActiveBusesCount;
        private System.Windows.Forms.Label labelAllDriversCount;
        private System.Windows.Forms.Label labelAllBusesCount;
    }
}

