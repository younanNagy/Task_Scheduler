namespace WindowsFormsApplication1
{
    partial class WinForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_lable = new System.Windows.Forms.Label();
            this.Arrival_label = new System.Windows.Forms.Label();
            this.priority_label = new System.Windows.Forms.Label();
            this.Duration_label = new System.Windows.Forms.Label();
            this.RR_label = new System.Windows.Forms.Label();
            this.Nametx = new System.Windows.Forms.TextBox();
            this.arrivaltx = new System.Windows.Forms.TextBox();
            this.prioritytx = new System.Windows.Forms.TextBox();
            this.dutx = new System.Windows.Forms.TextBox();
            this.RRBtx = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.GNtt_chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.insert_task_but = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clear_data_but = new System.Windows.Forms.Button();
            this.Run_but = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Gntt_chart_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNtt_chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(34, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Size = new System.Drawing.Size(526, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name_lable
            // 
            this.Name_lable.BackColor = System.Drawing.Color.Silver;
            this.Name_lable.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lable.ForeColor = System.Drawing.Color.Crimson;
            this.Name_lable.Location = new System.Drawing.Point(20, 82);
            this.Name_lable.Name = "Name_lable";
            this.Name_lable.Size = new System.Drawing.Size(84, 44);
            this.Name_lable.TabIndex = 1;
            this.Name_lable.Text = "Name";
            this.Name_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Arrival_label
            // 
            this.Arrival_label.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrival_label.ForeColor = System.Drawing.Color.Crimson;
            this.Arrival_label.Location = new System.Drawing.Point(110, 82);
            this.Arrival_label.Name = "Arrival_label";
            this.Arrival_label.Size = new System.Drawing.Size(109, 44);
            this.Arrival_label.TabIndex = 2;
            this.Arrival_label.Text = "Arrival";
            this.Arrival_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priority_label
            // 
            this.priority_label.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priority_label.ForeColor = System.Drawing.Color.Crimson;
            this.priority_label.Location = new System.Drawing.Point(210, 82);
            this.priority_label.Name = "priority_label";
            this.priority_label.Size = new System.Drawing.Size(112, 44);
            this.priority_label.TabIndex = 3;
            this.priority_label.Text = "Priority";
            this.priority_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Duration_label
            // 
            this.Duration_label.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_label.ForeColor = System.Drawing.Color.Crimson;
            this.Duration_label.Location = new System.Drawing.Point(323, 82);
            this.Duration_label.Name = "Duration_label";
            this.Duration_label.Size = new System.Drawing.Size(122, 44);
            this.Duration_label.TabIndex = 4;
            this.Duration_label.Text = "Duration";
            this.Duration_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RR_label
            // 
            this.RR_label.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RR_label.ForeColor = System.Drawing.Color.Crimson;
            this.RR_label.Location = new System.Drawing.Point(443, 86);
            this.RR_label.Name = "RR_label";
            this.RR_label.Size = new System.Drawing.Size(117, 37);
            this.RR_label.TabIndex = 5;
            this.RR_label.Text = "Quantum";
            this.RR_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nametx
            // 
            this.Nametx.BackColor = System.Drawing.Color.Silver;
            this.Nametx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nametx.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Nametx.Location = new System.Drawing.Point(17, 129);
            this.Nametx.Name = "Nametx";
            this.Nametx.Size = new System.Drawing.Size(84, 20);
            this.Nametx.TabIndex = 6;
            // 
            // arrivaltx
            // 
            this.arrivaltx.BackColor = System.Drawing.Color.Silver;
            this.arrivaltx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrivaltx.Location = new System.Drawing.Point(120, 129);
            this.arrivaltx.Name = "arrivaltx";
            this.arrivaltx.Size = new System.Drawing.Size(83, 20);
            this.arrivaltx.TabIndex = 7;
            // 
            // prioritytx
            // 
            this.prioritytx.BackColor = System.Drawing.Color.Silver;
            this.prioritytx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prioritytx.Location = new System.Drawing.Point(227, 129);
            this.prioritytx.Name = "prioritytx";
            this.prioritytx.Size = new System.Drawing.Size(90, 20);
            this.prioritytx.TabIndex = 8;
            // 
            // dutx
            // 
            this.dutx.BackColor = System.Drawing.Color.Silver;
            this.dutx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dutx.Location = new System.Drawing.Point(341, 129);
            this.dutx.Name = "dutx";
            this.dutx.Size = new System.Drawing.Size(90, 20);
            this.dutx.TabIndex = 9;
            // 
            // RRBtx
            // 
            this.RRBtx.BackColor = System.Drawing.Color.Silver;
            this.RRBtx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RRBtx.Location = new System.Drawing.Point(456, 129);
            this.RRBtx.Name = "RRBtx";
            this.RRBtx.Size = new System.Drawing.Size(90, 20);
            this.RRBtx.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Crimson;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-48, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(825, 75);
            this.label7.TabIndex = 17;
            this.label7.Text = "Scheduler";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GNtt_chart1
            // 
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.GNtt_chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.GNtt_chart1.Legends.Add(legend2);
            this.GNtt_chart1.Location = new System.Drawing.Point(-32, -7);
            this.GNtt_chart1.Name = "GNtt_chart1";
            this.GNtt_chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series2.Color = System.Drawing.Color.Crimson;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Name = "Tasks";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValuesPerPoint = 2;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.GNtt_chart1.Series.Add(series2);
            this.GNtt_chart1.Size = new System.Drawing.Size(851, 466);
            this.GNtt_chart1.TabIndex = 20;
            this.GNtt_chart1.Text = "chart1";
            this.GNtt_chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            this.GNtt_chart1.Click += new System.EventHandler(this.GNtt_chart1_Click);
            // 
            // insert_task_but
            // 
            this.insert_task_but.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_task_but.ForeColor = System.Drawing.Color.Crimson;
            this.insert_task_but.Location = new System.Drawing.Point(566, 161);
            this.insert_task_but.Name = "insert_task_but";
            this.insert_task_but.Size = new System.Drawing.Size(121, 43);
            this.insert_task_but.TabIndex = 11;
            this.insert_task_but.Text = "Insert Task";
            this.insert_task_but.UseVisualStyleBackColor = true;
            this.insert_task_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Crimson;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FCFS",
            "SJF(Preemptive)",
            "SJF(Non Preemptive)",
            "Priority(Preemptive)",
            "Priority(Non Preemptive)",
            "Round Robin"});
            this.comboBox1.Location = new System.Drawing.Point(566, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clear_data_but
            // 
            this.clear_data_but.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_data_but.ForeColor = System.Drawing.Color.Crimson;
            this.clear_data_but.Location = new System.Drawing.Point(566, 259);
            this.clear_data_but.Name = "clear_data_but";
            this.clear_data_but.Size = new System.Drawing.Size(121, 43);
            this.clear_data_but.TabIndex = 13;
            this.clear_data_but.Text = "Clear Data";
            this.clear_data_but.UseVisualStyleBackColor = true;
            this.clear_data_but.Click += new System.EventHandler(this.button2_Click);
            // 
            // Run_but
            // 
            this.Run_but.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run_but.ForeColor = System.Drawing.Color.Crimson;
            this.Run_but.Location = new System.Drawing.Point(566, 210);
            this.Run_but.Name = "Run_but";
            this.Run_but.Size = new System.Drawing.Size(121, 43);
            this.Run_but.TabIndex = 14;
            this.Run_but.Text = "Run";
            this.Run_but.UseVisualStyleBackColor = true;
            this.Run_but.Click += new System.EventHandler(this.Run_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Crimson;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(566, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mode";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gntt_chart_but
            // 
            this.Gntt_chart_but.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gntt_chart_but.ForeColor = System.Drawing.Color.Crimson;
            this.Gntt_chart_but.Location = new System.Drawing.Point(566, 308);
            this.Gntt_chart_but.Name = "Gntt_chart_but";
            this.Gntt_chart_but.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Gntt_chart_but.Size = new System.Drawing.Size(121, 43);
            this.Gntt_chart_but.TabIndex = 19;
            this.Gntt_chart_but.Text = "Gantt Chart";
            this.Gntt_chart_but.UseMnemonic = false;
            this.Gntt_chart_but.UseVisualStyleBackColor = true;
            this.Gntt_chart_but.Click += new System.EventHandler(this.Gntt_chart_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(569, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 43);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ave Waiting Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(700, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gntt_chart_but);
            this.Controls.Add(this.GNtt_chart1);
            this.Controls.Add(this.clear_data_but);
            this.Controls.Add(this.Run_but);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.insert_task_but);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RRBtx);
            this.Controls.Add(this.dutx);
            this.Controls.Add(this.prioritytx);
            this.Controls.Add(this.arrivaltx);
            this.Controls.Add(this.Nametx);
            this.Controls.Add(this.RR_label);
            this.Controls.Add(this.Duration_label);
            this.Controls.Add(this.priority_label);
            this.Controls.Add(this.Arrival_label);
            this.Controls.Add(this.Name_lable);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WinForm";
            this.Text = "Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNtt_chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Name_lable;
        private System.Windows.Forms.Label Arrival_label;
        private System.Windows.Forms.Label priority_label;
        private System.Windows.Forms.Label Duration_label;
        private System.Windows.Forms.Label RR_label;
        private System.Windows.Forms.TextBox Nametx;
        private System.Windows.Forms.TextBox arrivaltx;
        private System.Windows.Forms.TextBox prioritytx;
        private System.Windows.Forms.TextBox dutx;
        private System.Windows.Forms.TextBox RRBtx;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart GNtt_chart1;
        private System.Windows.Forms.Button insert_task_but;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button clear_data_but;
        private System.Windows.Forms.Button Run_but;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Gntt_chart_but;
        private System.Windows.Forms.Label label1;
    }
}

