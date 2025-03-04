namespace Project_ef
{
    partial class index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            update_op = new Button();
            delete_Op = new Button();
            button1 = new Button();
            add_Op = new Button();
            dataGridView1 = new DataGridView();
            search = new Button();
            textBox1 = new TextBox();
            categ = new ComboBox();
            status = new ComboBox();
            date = new DateTimePicker();
            desc = new TextBox();
            title = new TextBox();
            priority = new ComboBox();
            fliter = new Button();
            logout_op = new Button();
            email = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // update_op
            // 
            update_op.BackColor = Color.LightSalmon;
            update_op.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_op.ForeColor = SystemColors.Control;
            update_op.Location = new Point(953, 343);
            update_op.Name = "update_op";
            update_op.Size = new Size(103, 38);
            update_op.TabIndex = 35;
            update_op.Text = "update";
            update_op.UseVisualStyleBackColor = false;
            update_op.Click += update_op_Click;
            // 
            // delete_Op
            // 
            delete_Op.BackColor = Color.IndianRed;
            delete_Op.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_Op.ForeColor = SystemColors.ButtonFace;
            delete_Op.Location = new Point(839, 343);
            delete_Op.Name = "delete_Op";
            delete_Op.Padding = new Padding(3);
            delete_Op.Size = new Size(112, 38);
            delete_Op.TabIndex = 34;
            delete_Op.Text = "delete";
            delete_Op.UseVisualStyleBackColor = false;
            delete_Op.Click += delete_Op_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(509, 32);
            button1.Name = "button1";
            button1.Size = new Size(156, 33);
            button1.TabIndex = 33;
            button1.Text = "clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // add_Op
            // 
            add_Op.BackColor = Color.YellowGreen;
            add_Op.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_Op.ForeColor = SystemColors.ButtonFace;
            add_Op.Location = new Point(713, 343);
            add_Op.Name = "add_Op";
            add_Op.Size = new Size(120, 38);
            add_Op.TabIndex = 24;
            add_Op.Text = "add";
            add_Op.UseVisualStyleBackColor = false;
            add_Op.Click += add_Op_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(654, 521);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // search
            // 
            search.BackColor = SystemColors.ControlLight;
            search.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search.ForeColor = SystemColors.ActiveCaption;
            search.Location = new Point(324, 32);
            search.Name = "search";
            search.Size = new Size(169, 33);
            search.TabIndex = 20;
            search.Text = "search";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 19;
            // 
            // categ
            // 
            categ.FormattingEnabled = true;
            categ.Location = new Point(781, 273);
            categ.Name = "categ";
            categ.Size = new Size(250, 28);
            categ.TabIndex = 47;
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Low", "Medium", "High" });
            status.Location = new Point(781, 225);
            status.Name = "status";
            status.Size = new Size(250, 28);
            status.TabIndex = 45;
            // 
            // date
            // 
            date.Location = new Point(781, 141);
            date.Name = "date";
            date.Size = new Size(250, 27);
            date.TabIndex = 43;
            // 
            // desc
            // 
            desc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            desc.Location = new Point(781, 95);
            desc.Name = "desc";
            desc.Size = new Size(250, 30);
            desc.TabIndex = 42;
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            title.Location = new Point(781, 50);
            title.Name = "title";
            title.Size = new Size(250, 30);
            title.TabIndex = 36;
            // 
            // priority
            // 
            priority.FormattingEnabled = true;
            priority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            priority.Location = new Point(779, 182);
            priority.Name = "priority";
            priority.Size = new Size(250, 28);
            priority.TabIndex = 48;
            // 
            // fliter
            // 
            fliter.BackColor = SystemColors.AppWorkspace;
            fliter.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fliter.Location = new Point(713, 398);
            fliter.Name = "fliter";
            fliter.Size = new Size(334, 29);
            fliter.TabIndex = 49;
            fliter.Text = "Fliter ";
            fliter.UseVisualStyleBackColor = false;
            fliter.Click += fliter_Click;
            // 
            // logout_op
            // 
            logout_op.BackColor = Color.Goldenrod;
            logout_op.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_op.Location = new Point(713, 501);
            logout_op.Name = "logout_op";
            logout_op.Size = new Size(334, 35);
            logout_op.TabIndex = 51;
            logout_op.Text = "Logout";
            logout_op.UseVisualStyleBackColor = false;
            logout_op.Click += logout_op_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.Green;
            email.Location = new Point(703, 54);
            email.Name = "email";
            email.Size = new Size(51, 24);
            email.TabIndex = 52;
            email.Text = "Title";
            email.Click += email_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(677, 95);
            label1.Name = "label1";
            label1.Size = new Size(98, 24);
            label1.TabIndex = 53;
            label1.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(693, 141);
            label2.Name = "label2";
            label2.Size = new Size(76, 24);
            label2.TabIndex = 54;
            label2.Text = "DueDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(703, 186);
            label3.Name = "label3";
            label3.Size = new Size(65, 24);
            label3.TabIndex = 55;
            label3.Text = "Priority";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(703, 225);
            label4.Name = "label4";
            label4.Size = new Size(59, 24);
            label4.TabIndex = 56;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkOliveGreen;
            label5.Location = new Point(693, 277);
            label5.Name = "label5";
            label5.Size = new Size(80, 24);
            label5.TabIndex = 57;
            label5.Text = "Category";
            // 
            // button2
            // 
            button2.BackColor = Color.YellowGreen;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(713, 445);
            button2.Name = "button2";
            button2.Size = new Size(334, 35);
            button2.TabIndex = 59;
            button2.Text = "reporting";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1059, 614);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(email);
            Controls.Add(logout_op);
            Controls.Add(fliter);
            Controls.Add(priority);
            Controls.Add(categ);
            Controls.Add(status);
            Controls.Add(date);
            Controls.Add(desc);
            Controls.Add(title);
            Controls.Add(update_op);
            Controls.Add(delete_Op);
            Controls.Add(button1);
            Controls.Add(add_Op);
            Controls.Add(dataGridView1);
            Controls.Add(search);
            Controls.Add(textBox1);
            Name = "index";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button update_op;
        private Button delete_Op;
        private Button button1;
        private Button add_Op;
        private DataGridView dataGridView1;
        private Button search;
        private TextBox textBox1;
        private ComboBox categ;
        private ComboBox status;
        private DateTimePicker date;
        private TextBox desc;
        private TextBox title;
        private ComboBox priority;
        private Button fliter;
        private Button button3;
        private Button logout_op;
        private Label email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        //private Button sort_by_date;
        // private Button logout_op;
    }
}
