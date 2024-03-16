namespace Assignment_3
{
    partial class Room
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.room_type = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.person = new System.Windows.Forms.TextBox();
            this.room_rate = new System.Windows.Forms.TextBox();
            this.room_no = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.refresh_btn = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.back = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.room_type);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.person);
            this.panel1.Controls.Add(this.room_rate);
            this.panel1.Controls.Add(this.room_no);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Location = new System.Drawing.Point(21, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 512);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(714, 189);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(181, 34);
            this.search.TabIndex = 7;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.White;
            this.edit.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.Black;
            this.edit.Location = new System.Drawing.Point(714, 148);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(181, 34);
            this.edit.TabIndex = 6;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // room_type
            // 
            this.room_type.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_type.FormattingEnabled = true;
            this.room_type.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Quad"});
            this.room_type.Location = new System.Drawing.Point(433, 133);
            this.room_type.Name = "room_type";
            this.room_type.Size = new System.Drawing.Size(216, 24);
            this.room_type.TabIndex = 2;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Black;
            this.delete.Location = new System.Drawing.Point(494, 260);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(181, 34);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Location = new System.Drawing.Point(262, 260);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(181, 34);
            this.update.TabIndex = 8;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Visible = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // person
            // 
            this.person.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person.Location = new System.Drawing.Point(433, 201);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(216, 23);
            this.person.TabIndex = 4;
            // 
            // room_rate
            // 
            this.room_rate.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_rate.Location = new System.Drawing.Point(433, 167);
            this.room_rate.Name = "room_rate";
            this.room_rate.Size = new System.Drawing.Size(216, 23);
            this.room_rate.TabIndex = 3;
            // 
            // room_no
            // 
            this.room_no.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_no.Location = new System.Drawing.Point(433, 99);
            this.room_no.Name = "room_no";
            this.room_no.Size = new System.Drawing.Size(216, 23);
            this.room_no.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(268, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 26);
            this.label6.TabIndex = 46;
            this.label6.Text = "No of Person :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(290, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 26);
            this.label5.TabIndex = 45;
            this.label5.Text = "Room Rate :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(282, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 26);
            this.label4.TabIndex = 44;
            this.label4.Text = "Room Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(301, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 43;
            this.label3.Text = "Room No :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(246, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(438, 177);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.White;
            this.save.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(714, 107);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(181, 34);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(373, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 34);
            this.label1.TabIndex = 30;
            this.label1.Text = "Room Information";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.refresh_btn,
            this.back});
            this.shapeContainer2.Size = new System.Drawing.Size(945, 512);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Black;
            this.refresh_btn.BackgroundImage = global::Assignment_3.Properties.Resources.refresh_2_24;
            this.refresh_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refresh_btn.FillColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(883, 7);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(42, 39);
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = global::Assignment_3.Properties.Resources.download__2_;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Location = new System.Drawing.Point(12, 8);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 35);
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_3.Properties.Resources.david_sjunnesson_JaC8Yf6fYGk_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Room";
            this.Size = new System.Drawing.Size(989, 551);
            this.Load += new System.EventHandler(this.Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox person;
        private System.Windows.Forms.TextBox room_rate;
        private System.Windows.Forms.TextBox room_no;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox room_type;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button search;
        private Microsoft.VisualBasic.PowerPacks.OvalShape refresh_btn;
    }
}
