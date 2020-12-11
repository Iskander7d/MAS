namespace MAS
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
            this.atm_queue = new System.Windows.Forms.DataGridView();
            this.atm_usage = new System.Windows.Forms.DataGridView();
            this.atm_result = new System.Windows.Forms.DataGridView();
            this.service_queue = new System.Windows.Forms.DataGridView();
            this.service_usage = new System.Windows.Forms.DataGridView();
            this.service_result = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.simulationBtn = new System.Windows.Forms.Button();
            this.name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.atm_queue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atm_usage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atm_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_queue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_usage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_result)).BeginInit();
            this.SuspendLayout();
            // 
            // atm_queue
            // 
            this.atm_queue.BackgroundColor = System.Drawing.Color.White;
            this.atm_queue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atm_queue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name1,
            this.time1});
            this.atm_queue.Location = new System.Drawing.Point(12, 86);
            this.atm_queue.Name = "atm_queue";
            this.atm_queue.Size = new System.Drawing.Size(185, 182);
            this.atm_queue.TabIndex = 0;
            // 
            // atm_usage
            // 
            this.atm_usage.BackgroundColor = System.Drawing.Color.White;
            this.atm_usage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atm_usage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name2,
            this.time2});
            this.atm_usage.Location = new System.Drawing.Point(264, 86);
            this.atm_usage.Name = "atm_usage";
            this.atm_usage.Size = new System.Drawing.Size(185, 182);
            this.atm_usage.TabIndex = 1;
            // 
            // atm_result
            // 
            this.atm_result.BackgroundColor = System.Drawing.Color.White;
            this.atm_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atm_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name3});
            this.atm_result.Location = new System.Drawing.Point(518, 86);
            this.atm_result.Name = "atm_result";
            this.atm_result.Size = new System.Drawing.Size(185, 182);
            this.atm_result.TabIndex = 2;
            // 
            // service_queue
            // 
            this.service_queue.BackgroundColor = System.Drawing.Color.White;
            this.service_queue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.service_queue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name4,
            this.time4});
            this.service_queue.Location = new System.Drawing.Point(12, 287);
            this.service_queue.Name = "service_queue";
            this.service_queue.Size = new System.Drawing.Size(185, 182);
            this.service_queue.TabIndex = 3;
            // 
            // service_usage
            // 
            this.service_usage.BackgroundColor = System.Drawing.Color.White;
            this.service_usage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.service_usage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name5,
            this.time5});
            this.service_usage.Location = new System.Drawing.Point(264, 287);
            this.service_usage.Name = "service_usage";
            this.service_usage.Size = new System.Drawing.Size(185, 182);
            this.service_usage.TabIndex = 4;
            // 
            // service_result
            // 
            this.service_result.BackgroundColor = System.Drawing.Color.White;
            this.service_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.service_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name6});
            this.service_result.Location = new System.Drawing.Point(518, 287);
            this.service_result.Name = "service_result";
            this.service_result.ReadOnly = true;
            this.service_result.Size = new System.Drawing.Size(185, 182);
            this.service_result.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ATM queue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ATM usage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ATM result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sevice queue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Service usage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Service result";
            // 
            // simulationBtn
            // 
            this.simulationBtn.Location = new System.Drawing.Point(12, 12);
            this.simulationBtn.Name = "simulationBtn";
            this.simulationBtn.Size = new System.Drawing.Size(102, 43);
            this.simulationBtn.TabIndex = 12;
            this.simulationBtn.Text = "Start Simulation";
            this.simulationBtn.UseVisualStyleBackColor = true;
            this.simulationBtn.Click += new System.EventHandler(this.simulationBtn_Click);
            // 
            // name2
            // 
            this.name2.HeaderText = "Name";
            this.name2.Name = "name2";
            this.name2.Width = 90;
            // 
            // time2
            // 
            this.time2.HeaderText = "Time";
            this.time2.Name = "time2";
            this.time2.Width = 50;
            // 
            // name1
            // 
            this.name1.HeaderText = "Name";
            this.name1.Name = "name1";
            this.name1.Width = 90;
            // 
            // time1
            // 
            this.time1.HeaderText = "Time";
            this.time1.Name = "time1";
            this.time1.Width = 50;
            // 
            // name4
            // 
            this.name4.HeaderText = "Name";
            this.name4.Name = "name4";
            this.name4.Width = 90;
            // 
            // time4
            // 
            this.time4.HeaderText = "Time";
            this.time4.Name = "time4";
            this.time4.Width = 50;
            // 
            // name5
            // 
            this.name5.HeaderText = "Name";
            this.name5.Name = "name5";
            this.name5.Width = 90;
            // 
            // time5
            // 
            this.time5.HeaderText = "Time";
            this.time5.Name = "time5";
            this.time5.Width = 50;
            // 
            // name3
            // 
            this.name3.HeaderText = "Name";
            this.name3.Name = "name3";
            this.name3.Width = 140;
            // 
            // name6
            // 
            this.name6.HeaderText = "Name";
            this.name6.Name = "name6";
            this.name6.ReadOnly = true;
            this.name6.Width = 140;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(716, 481);
            this.Controls.Add(this.simulationBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.service_result);
            this.Controls.Add(this.service_usage);
            this.Controls.Add(this.service_queue);
            this.Controls.Add(this.atm_result);
            this.Controls.Add(this.atm_usage);
            this.Controls.Add(this.atm_queue);
            this.Name = "Form1";
            this.Text = "Multi Agent System";
            ((System.ComponentModel.ISupportInitialize)(this.atm_queue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atm_usage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atm_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_queue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_usage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView atm_queue;
        private System.Windows.Forms.DataGridView atm_usage;
        private System.Windows.Forms.DataGridView atm_result;
        private System.Windows.Forms.DataGridView service_queue;
        private System.Windows.Forms.DataGridView service_usage;
        private System.Windows.Forms.DataGridView service_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button simulationBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn time1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn time2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name4;
        private System.Windows.Forms.DataGridViewTextBoxColumn time4;
        private System.Windows.Forms.DataGridViewTextBoxColumn name5;
        private System.Windows.Forms.DataGridViewTextBoxColumn time5;
        private System.Windows.Forms.DataGridViewTextBoxColumn name3;
        private System.Windows.Forms.DataGridViewTextBoxColumn name6;
    }
}

