namespace Project_ef.views
{
    partial class fliterTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fliterTask));
            fliter = new Button();
            dataGridView1 = new DataGridView();
            statusFilterComboBox = new ComboBox();
            priorityFilterComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            back_op = new Button();
            sort_des = new Button();
            sort_op = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // fliter
            // 
            fliter.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fliter.ForeColor = Color.IndianRed;
            fliter.Location = new Point(48, 131);
            fliter.Name = "fliter";
            fliter.Size = new Size(274, 36);
            fliter.TabIndex = 0;
            fliter.Text = "Fliter";
            fliter.UseVisualStyleBackColor = true;
            fliter.Click += fliter_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 279);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // statusFilterComboBox
            // 
            statusFilterComboBox.FormattingEnabled = true;
            statusFilterComboBox.Location = new Point(101, 84);
            statusFilterComboBox.Name = "statusFilterComboBox";
            statusFilterComboBox.Size = new Size(221, 28);
            statusFilterComboBox.TabIndex = 3;
            // 
            // priorityFilterComboBox
            // 
            priorityFilterComboBox.FormattingEnabled = true;
            priorityFilterComboBox.Location = new Point(467, 79);
            priorityFilterComboBox.Name = "priorityFilterComboBox";
            priorityFilterComboBox.Size = new Size(245, 28);
            priorityFilterComboBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(22, 83);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 7;
            label2.Text = "status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(384, 79);
            label3.Name = "label3";
            label3.Size = new Size(77, 27);
            label3.TabIndex = 8;
            label3.Text = "priority";
            // 
            // back_op
            // 
            back_op.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back_op.ForeColor = Color.Gray;
            back_op.Location = new Point(438, 131);
            back_op.Name = "back_op";
            back_op.Size = new Size(274, 36);
            back_op.TabIndex = 10;
            back_op.Text = "Back";
            back_op.UseVisualStyleBackColor = true;
            back_op.Click += back_op_Click;
            // 
            // sort_des
            // 
            sort_des.BackColor = Color.Cornsilk;
            sort_des.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sort_des.Location = new Point(467, 26);
            sort_des.Name = "sort_des";
            sort_des.Size = new Size(245, 35);
            sort_des.TabIndex = 60;
            sort_des.Text = "Sort Descending";
            sort_des.UseVisualStyleBackColor = false;
            sort_des.Click += sort_des_Click;
            // 
            // sort_op
            // 
            sort_op.BackColor = Color.OldLace;
            sort_op.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sort_op.Location = new Point(101, 26);
            sort_op.Name = "sort_op";
            sort_op.Size = new Size(221, 35);
            sort_op.TabIndex = 59;
            sort_op.Text = " sort ascending";
            sort_op.UseVisualStyleBackColor = false;
            sort_op.Click += sort_op_Click;
            // 
            // fliterTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(sort_des);
            Controls.Add(sort_op);
            Controls.Add(back_op);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(priorityFilterComboBox);
            Controls.Add(statusFilterComboBox);
            Controls.Add(dataGridView1);
            Controls.Add(fliter);
            Name = "fliterTask";
            Text = "fliterTask";
            Load += fliterTask_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button fliter;
        private DataGridView dataGridView1;
        private ComboBox statusFilterComboBox;
        private ComboBox priorityFilterComboBox;
        private Label label2;
        private Label label3;
        private Button back_op;
        private Button sort_des;
        private Button sort_op;
    }
}