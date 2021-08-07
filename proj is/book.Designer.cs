namespace proj_is
{
    partial class book
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cobox_des = new System.Windows.Forms.ComboBox();
            this.cobox_origin = new System.Windows.Forms.ComboBox();
            this.payment = new System.Windows.Forms.Label();
            this.pick_up_hr = new System.Windows.Forms.Label();
            this.book_bttn = new System.Windows.Forms.Button();
            this.cash = new System.Windows.Forms.RadioButton();
            this.credit = new System.Windows.Forms.RadioButton();
            this.pay_by = new System.Windows.Forms.Label();
            this.seats_number_numeric = new System.Windows.Forms.NumericUpDown();
            this.bus_id_txt = new System.Windows.Forms.TextBox();
            this.total_cost = new System.Windows.Forms.Label();
            this.Origin = new System.Windows.Forms.Label();
            this.seats_num = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.bus_id = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.credit_sign1 = new proj_is.credit_sign();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seats_number_numeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 13, 12, 57, 35, 0);
            // 
            // cobox_des
            // 
            this.cobox_des.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobox_des.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cobox_des.FormattingEnabled = true;
            this.cobox_des.Location = new System.Drawing.Point(292, 142);
            this.cobox_des.Name = "cobox_des";
            this.cobox_des.Size = new System.Drawing.Size(205, 26);
            this.cobox_des.TabIndex = 3;
            // 
            // cobox_origin
            // 
            this.cobox_origin.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobox_origin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cobox_origin.FormattingEnabled = true;
            this.cobox_origin.Location = new System.Drawing.Point(292, 104);
            this.cobox_origin.Name = "cobox_origin";
            this.cobox_origin.Size = new System.Drawing.Size(205, 26);
            this.cobox_origin.TabIndex = 2;
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(139, 368);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(0, 24);
            this.payment.TabIndex = 19;
            // 
            // pick_up_hr
            // 
            this.pick_up_hr.AutoSize = true;
            this.pick_up_hr.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_up_hr.Location = new System.Drawing.Point(139, 190);
            this.pick_up_hr.Name = "pick_up_hr";
            this.pick_up_hr.Size = new System.Drawing.Size(126, 19);
            this.pick_up_hr.TabIndex = 17;
            this.pick_up_hr.Text = "Pick Up Time:";
            // 
            // book_bttn
            // 
            this.book_bttn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.book_bttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book_bttn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.book_bttn.FlatAppearance.BorderSize = 0;
            this.book_bttn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.book_bttn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.book_bttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_bttn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.book_bttn.Location = new System.Drawing.Point(504, 349);
            this.book_bttn.Name = "book_bttn";
            this.book_bttn.Size = new System.Drawing.Size(98, 43);
            this.book_bttn.TabIndex = 8;
            this.book_bttn.Text = "Book";
            this.book_bttn.UseVisualStyleBackColor = false;
            this.book_bttn.Click += new System.EventHandler(this.book_bttn_Click);
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Checked = true;
            this.cash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cash.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.Location = new System.Drawing.Point(292, 272);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(63, 23);
            this.cash.TabIndex = 7;
            this.cash.TabStop = true;
            this.cash.Text = "Cash";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.CheckedChanged += new System.EventHandler(this.cash_CheckedChanged_1);
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.credit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.Location = new System.Drawing.Point(415, 272);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(81, 23);
            this.credit.TabIndex = 14;
            this.credit.Text = "Credit";
            this.credit.UseVisualStyleBackColor = true;
            this.credit.CheckedChanged += new System.EventHandler(this.credit_CheckedChanged_1);
            // 
            // pay_by
            // 
            this.pay_by.AutoSize = true;
            this.pay_by.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_by.Location = new System.Drawing.Point(193, 272);
            this.pay_by.Name = "pay_by";
            this.pay_by.Size = new System.Drawing.Size(72, 19);
            this.pay_by.TabIndex = 13;
            this.pay_by.Text = "Pay By:";
            // 
            // seats_number_numeric
            // 
            this.seats_number_numeric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seats_number_numeric.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seats_number_numeric.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.seats_number_numeric.Location = new System.Drawing.Point(292, 232);
            this.seats_number_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seats_number_numeric.Name = "seats_number_numeric";
            this.seats_number_numeric.Size = new System.Drawing.Size(205, 26);
            this.seats_number_numeric.TabIndex = 6;
            this.seats_number_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seats_number_numeric.ValueChanged += new System.EventHandler(this.seats_number_numeric_ValueChanged);
            // 
            // bus_id_txt
            // 
            this.bus_id_txt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bus_id_txt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bus_id_txt.Location = new System.Drawing.Point(292, 66);
            this.bus_id_txt.Name = "bus_id_txt";
            this.bus_id_txt.Size = new System.Drawing.Size(205, 26);
            this.bus_id_txt.TabIndex = 1;
            this.bus_id_txt.Leave += new System.EventHandler(this.bus_id_txt_Leave);
            // 
            // total_cost
            // 
            this.total_cost.AutoSize = true;
            this.total_cost.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_cost.Location = new System.Drawing.Point(6, 368);
            this.total_cost.Name = "total_cost";
            this.total_cost.Size = new System.Drawing.Size(125, 24);
            this.total_cost.TabIndex = 5;
            this.total_cost.Text = "Total Cost:";
            // 
            // Origin
            // 
            this.Origin.AutoSize = true;
            this.Origin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Origin.Location = new System.Drawing.Point(112, 107);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(153, 19);
            this.Origin.TabIndex = 4;
            this.Origin.Text = "Origin Location:";
            // 
            // seats_num
            // 
            this.seats_num.AutoSize = true;
            this.seats_num.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seats_num.Location = new System.Drawing.Point(112, 232);
            this.seats_num.Name = "seats_num";
            this.seats_num.Size = new System.Drawing.Size(153, 19);
            this.seats_num.TabIndex = 3;
            this.seats_num.Text = "Number of Seats:";
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.Location = new System.Drawing.Point(67, 149);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(198, 19);
            this.destination.TabIndex = 1;
            this.destination.Text = "Destination Location:";
            // 
            // bus_id
            // 
            this.bus_id.AutoSize = true;
            this.bus_id.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bus_id.Location = new System.Drawing.Point(193, 66);
            this.bus_id.Name = "bus_id";
            this.bus_id.Size = new System.Drawing.Size(72, 19);
            this.bus_id.TabIndex = 0;
            this.bus_id.Text = "Bus ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cobox_des);
            this.groupBox1.Controls.Add(this.cobox_origin);
            this.groupBox1.Controls.Add(this.payment);
            this.groupBox1.Controls.Add(this.pick_up_hr);
            this.groupBox1.Controls.Add(this.book_bttn);
            this.groupBox1.Controls.Add(this.cash);
            this.groupBox1.Controls.Add(this.credit);
            this.groupBox1.Controls.Add(this.pay_by);
            this.groupBox1.Controls.Add(this.seats_number_numeric);
            this.groupBox1.Controls.Add(this.bus_id_txt);
            this.groupBox1.Controls.Add(this.total_cost);
            this.groupBox1.Controls.Add(this.Origin);
            this.groupBox1.Controls.Add(this.seats_num);
            this.groupBox1.Controls.Add(this.destination);
            this.groupBox1.Controls.Add(this.bus_id);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(35, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(608, 407);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservation";
            // 
            // credit_sign1
            // 
            this.credit_sign1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("credit_sign1.BackgroundImage")));
            this.credit_sign1.Location = new System.Drawing.Point(-28, 3);
            this.credit_sign1.Name = "credit_sign1";
            this.credit_sign1.Size = new System.Drawing.Size(485, 240);
            this.credit_sign1.TabIndex = 6;
            this.credit_sign1.Load += new System.EventHandler(this.credit_sign1_Load);
            // 
            // book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.credit_sign1);
            this.Controls.Add(this.groupBox1);
            this.Name = "book";
            this.Size = new System.Drawing.Size(678, 459);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seats_number_numeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private credit_sign credit_sign1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cobox_des;
        private System.Windows.Forms.ComboBox cobox_origin;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Label pick_up_hr;
        private System.Windows.Forms.Button book_bttn;
        private System.Windows.Forms.RadioButton cash;
        private System.Windows.Forms.RadioButton credit;
        private System.Windows.Forms.Label pay_by;
        private System.Windows.Forms.NumericUpDown seats_number_numeric;
        private System.Windows.Forms.TextBox bus_id_txt;
        private System.Windows.Forms.Label total_cost;
        private System.Windows.Forms.Label Origin;
        private System.Windows.Forms.Label seats_num;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label bus_id;


    }
}
