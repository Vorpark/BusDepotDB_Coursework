namespace BusDepotUI.Main_Forms
{
    partial class DispatchCatalog
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.acceptChanges = new System.Windows.Forms.Button();
            this.labelRouteNameOfCurrentRoute = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 12);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(191, 33);
            this.comboBox.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label.Location = new System.Drawing.Point(236, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(103, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Маршрут:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 387);
            this.dataGridView1.TabIndex = 2;
            // 
            // acceptChanges
            // 
            this.acceptChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.acceptChanges.Location = new System.Drawing.Point(626, 453);
            this.acceptChanges.Name = "acceptChanges";
            this.acceptChanges.Size = new System.Drawing.Size(162, 51);
            this.acceptChanges.TabIndex = 3;
            this.acceptChanges.Text = "Принять изменения";
            this.acceptChanges.UseVisualStyleBackColor = true;
            this.acceptChanges.Click += new System.EventHandler(this.AcceptChanges);
            // 
            // label2
            // 
            this.labelRouteNameOfCurrentRoute.AutoSize = true;
            this.labelRouteNameOfCurrentRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelRouteNameOfCurrentRoute.Location = new System.Drawing.Point(345, 15);
            this.labelRouteNameOfCurrentRoute.Name = "label2";
            this.labelRouteNameOfCurrentRoute.Size = new System.Drawing.Size(0, 25);
            this.labelRouteNameOfCurrentRoute.TabIndex = 4;
            // 
            // DispatchCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.labelRouteNameOfCurrentRoute);
            this.Controls.Add(this.acceptChanges);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.comboBox);
            this.Name = "DispatchCatalog";
            this.Text = "DispatchCatalog";
            this.Load += new System.EventHandler(this.DispatchCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button acceptChanges;
        private System.Windows.Forms.Label labelRouteNameOfCurrentRoute;
    }
}