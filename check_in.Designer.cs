namespace Assignment_3
{
    partial class check_in
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_room_type = new System.Windows.Forms.TextBox();
            this.combobox_room_no = new System.Windows.Forms.ComboBox();
            this.cmb_package = new System.Windows.Forms.ComboBox();
            this.phone_number = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.person = new System.Windows.Forms.TextBox();
            this.number_of_days = new System.Windows.Forms.TextBox();
            this.room_rate = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.check_in_date = new System.Windows.Forms.DateTimePicker();
            this.check_out_date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.lable12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.refresh = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.back = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(386, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Check In ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmb_room_type);
            this.panel1.Controls.Add(this.combobox_room_no);
            this.panel1.Controls.Add(this.cmb_package);
            this.panel1.Controls.Add(this.phone_number);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.check);
            this.panel1.Controls.Add(this.person);
            this.panel1.Controls.Add(this.number_of_days);
            this.panel1.Controls.Add(this.room_rate);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.check_in_date);
            this.panel1.Controls.Add(this.check_out_date);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lable12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Location = new System.Drawing.Point(21, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 512);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmb_room_type
            // 
            this.cmb_room_type.Enabled = false;
            this.cmb_room_type.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_room_type.Location = new System.Drawing.Point(225, 264);
            this.cmb_room_type.Name = "cmb_room_type";
            this.cmb_room_type.Size = new System.Drawing.Size(234, 30);
            this.cmb_room_type.TabIndex = 38;
            // 
            // combobox_room_no
            // 
            this.combobox_room_no.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_room_no.FormattingEnabled = true;
            this.combobox_room_no.Location = new System.Drawing.Point(225, 223);
            this.combobox_room_no.Name = "combobox_room_no";
            this.combobox_room_no.Size = new System.Drawing.Size(234, 32);
            this.combobox_room_no.Sorted = true;
            this.combobox_room_no.TabIndex = 37;
            this.combobox_room_no.SelectedIndexChanged += new System.EventHandler(this.combobox_room_no_SelectedIndexChanged);
            this.combobox_room_no.SelectedValueChanged += new System.EventHandler(this.combobox_room_no_SelectedValueChanged);
            // 
            // cmb_package
            // 
            this.cmb_package.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_package.FormattingEnabled = true;
            this.cmb_package.Location = new System.Drawing.Point(225, 417);
            this.cmb_package.Name = "cmb_package";
            this.cmb_package.Size = new System.Drawing.Size(234, 32);
            this.cmb_package.TabIndex = 36;
            // 
            // phone_number
            // 
            this.phone_number.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_number.Location = new System.Drawing.Point(224, 184);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(234, 30);
            this.phone_number.TabIndex = 35;
            this.phone_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_number_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(37, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 26);
            this.label10.TabIndex = 34;
            this.label10.Text = "Phone Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Guest ID :";
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.WhiteSmoke;
            this.check.FlatAppearance.BorderSize = 0;
            this.check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.Image = global::Assignment_3.Properties.Resources.ok_24;
            this.check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.check.Location = new System.Drawing.Point(725, 466);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(172, 33);
            this.check.TabIndex = 29;
            this.check.Text = "Check In";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // person
            // 
            this.person.Enabled = false;
            this.person.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person.Location = new System.Drawing.Point(225, 339);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(234, 30);
            this.person.TabIndex = 26;
            // 
            // number_of_days
            // 
            this.number_of_days.Enabled = false;
            this.number_of_days.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_of_days.Location = new System.Drawing.Point(224, 375);
            this.number_of_days.Name = "number_of_days";
            this.number_of_days.Size = new System.Drawing.Size(234, 30);
            this.number_of_days.TabIndex = 25;
            // 
            // room_rate
            // 
            this.room_rate.Enabled = false;
            this.room_rate.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_rate.Location = new System.Drawing.Point(224, 302);
            this.room_rate.Name = "room_rate";
            this.room_rate.Size = new System.Drawing.Size(234, 30);
            this.room_rate.TabIndex = 24;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(224, 146);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(234, 30);
            this.name.TabIndex = 21;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(224, 108);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(234, 30);
            this.id.TabIndex = 20;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // check_in_date
            // 
            this.check_in_date.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_in_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.check_in_date.Location = new System.Drawing.Point(725, 109);
            this.check_in_date.Name = "check_in_date";
            this.check_in_date.Size = new System.Drawing.Size(168, 27);
            this.check_in_date.TabIndex = 18;
            // 
            // check_out_date
            // 
            this.check_out_date.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_out_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.check_out_date.Location = new System.Drawing.Point(725, 156);
            this.check_out_date.Name = "check_out_date";
            this.check_out_date.Size = new System.Drawing.Size(168, 27);
            this.check_out_date.TabIndex = 17;
            this.check_out_date.ValueChanged += new System.EventHandler(this.check_out_date_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(554, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 26);
            this.label11.TabIndex = 16;
            this.label11.Text = "Check In Date :";
            // 
            // lable12
            // 
            this.lable12.AutoSize = true;
            this.lable12.BackColor = System.Drawing.Color.Transparent;
            this.lable12.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable12.ForeColor = System.Drawing.Color.White;
            this.lable12.Location = new System.Drawing.Point(537, 156);
            this.lable12.Name = "lable12";
            this.lable12.Size = new System.Drawing.Size(170, 26);
            this.lable12.TabIndex = 15;
            this.lable12.Text = "Check Out Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(70, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 26);
            this.label9.TabIndex = 14;
            this.label9.Text = "Room Type :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(105, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Package :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(57, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "No of Person :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "No of Days :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(78, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Room Rate :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(96, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Room no :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Guest Name :";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.refresh,
            this.back});
            this.shapeContainer2.Size = new System.Drawing.Size(945, 512);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // refresh
            // 
            this.refresh.BackgroundImage = global::Assignment_3.Properties.Resources.refresh;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.Location = new System.Drawing.Point(892, 7);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(40, 35);
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
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
            // check_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Assignment_3.Properties.Resources.mara_conan_design_O_6dZUyxezo_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "check_in";
            this.Size = new System.Drawing.Size(989, 551);
            this.Load += new System.EventHandler(this.check_in_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.check_in_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.OvalShape back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox person;
        private System.Windows.Forms.TextBox number_of_days;
        private System.Windows.Forms.TextBox room_rate;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.DateTimePicker check_in_date;
        private System.Windows.Forms.DateTimePicker check_out_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lable12;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_package;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.ComboBox combobox_room_no;
        private System.Windows.Forms.TextBox cmb_room_type;
        private Microsoft.VisualBasic.PowerPacks.OvalShape refresh;

    }
}
