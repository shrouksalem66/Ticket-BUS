namespace proj_is
{
    partial class update
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cc_txt = new System.Windows.Forms.RadioButton();
            this.cash_txt = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cobox_des = new System.Windows.Forms.ComboBox();
            this.cobox_origin = new System.Windows.Forms.ComboBox();
            this.ticket_id = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.payment = new System.Windows.Forms.Label();
            this.pick_up_date_txt_e = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pick_up_time_txt_e = new System.Windows.Forms.DateTimePicker();
            this.seats_num_txt_e = new System.Windows.Forms.NumericUpDown();
            this.bus_id_txt_e = new System.Windows.Forms.TextBox();
            this.bus_id_e = new System.Windows.Forms.Label();
            this.seats_num_e = new System.Windows.Forms.Label();
            this.destination_e = new System.Windows.Forms.Label();
            this.pick_up_date_e = new System.Windows.Forms.Label();
            this.origin_e = new System.Windows.Forms.Label();
            this.total_cost_e = new System.Windows.Forms.Label();
            this.edit_bttn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seats_num_txt_e)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cc_txt);
            this.groupBox1.Controls.Add(this.cash_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cobox_des);
            this.groupBox1.Controls.Add(this.cobox_origin);
            this.groupBox1.Controls.Add(this.ticket_id);
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.payment);
            this.groupBox1.Controls.Add(this.pick_up_date_txt_e);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pick_up_time_txt_e);
            this.groupBox1.Controls.Add(this.seats_num_txt_e);
            this.groupBox1.Controls.Add(this.bus_id_txt_e);
            this.groupBox1.Controls.Add(this.bus_id_e);
            this.groupBox1.Controls.Add(this.seats_num_e);
            this.groupBox1.Controls.Add(this.destination_e);
            this.groupBox1.Controls.Add(this.pick_up_date_e);
            this.groupBox1.Controls.Add(this.origin_e);
            this.groupBox1.Controls.Add(this.total_cost_e);
            this.groupBox1.Controls.Add(this.edit_bttn);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(48, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 364);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cc_txt
            // 
            this.cc_txt.AutoSize = true;
            this.cc_txt.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cc_txt.Location = new System.Drawing.Point(343, 286);
            this.cc_txt.Name = "cc_txt";
            this.cc_txt.Size = new System.Drawing.Size(75, 22);
            this.cc_txt.TabIndex = 37;
            this.cc_txt.TabStop = true;
            this.cc_txt.Text = "Credit";
            this.cc_txt.UseVisualStyleBackColor = true;
            this.cc_txt.CheckedChanged += new System.EventHandler(this.cc_txt_CheckedChanged);
            // 
            // cash_txt
            // 
            this.cash_txt.AutoSize = true;
            this.cash_txt.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_txt.Location = new System.Drawing.Point(206, 288);
            this.cash_txt.Name = "cash_txt";
            this.cash_txt.Size = new System.Drawing.Size(65, 22);
            this.cash_txt.TabIndex = 36;
            this.cash_txt.TabStop = true;
            this.cash_txt.Text = "Cash";
            this.cash_txt.UseVisualStyleBackColor = true;
            this.cash_txt.CheckedChanged += new System.EventHandler(this.cash_txt_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Number Of Seats:";
            // 
            // cobox_des
            // 
            this.cobox_des.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobox_des.FormattingEnabled = true;
            this.cobox_des.Location = new System.Drawing.Point(206, 112);
            this.cobox_des.Name = "cobox_des";
            this.cobox_des.Size = new System.Drawing.Size(207, 26);
            this.cobox_des.TabIndex = 3;
            // 
            // cobox_origin
            // 
            this.cobox_origin.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobox_origin.FormattingEnabled = true;
            this.cobox_origin.Location = new System.Drawing.Point(206, 74);
            this.cobox_origin.Name = "cobox_origin";
            this.cobox_origin.Size = new System.Drawing.Size(207, 26);
            this.cobox_origin.TabIndex = 2;
            // 
            // ticket_id
            // 
            this.ticket_id.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ticket_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ticket_id.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_id.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ticket_id.Location = new System.Drawing.Point(-14, 58);
            this.ticket_id.Name = "ticket_id";
            this.ticket_id.Size = new System.Drawing.Size(100, 13);
            this.ticket_id.TabIndex = 34;
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(247, 316);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(92, 42);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.payment.Location = new System.Drawing.Point(134, 348);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(0, 24);
            this.payment.TabIndex = 32;
            // 
            // pick_up_date_txt_e
            // 
            this.pick_up_date_txt_e.CalendarFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_up_date_txt_e.CustomFormat = "dd-MM-yyyy";
            this.pick_up_date_txt_e.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_up_date_txt_e.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_up_date_txt_e.Location = new System.Drawing.Point(206, 196);
            this.pick_up_date_txt_e.Name = "pick_up_date_txt_e";
            this.pick_up_date_txt_e.Size = new System.Drawing.Size(207, 20);
            this.pick_up_date_txt_e.TabIndex = 5;
            this.pick_up_date_txt_e.Value = new System.DateTime(2019, 12, 11, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(32, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Pick Up Date:";
            // 
            // pick_up_time_txt_e
            // 
            this.pick_up_time_txt_e.CalendarFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_up_time_txt_e.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_up_time_txt_e.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pick_up_time_txt_e.Location = new System.Drawing.Point(206, 155);
            this.pick_up_time_txt_e.Name = "pick_up_time_txt_e";
            this.pick_up_time_txt_e.ShowUpDown = true;
            this.pick_up_time_txt_e.Size = new System.Drawing.Size(207, 20);
            this.pick_up_time_txt_e.TabIndex = 4;
            // 
            // seats_num_txt_e
            // 
            this.seats_num_txt_e.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seats_num_txt_e.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.seats_num_txt_e.Location = new System.Drawing.Point(206, 243);
            this.seats_num_txt_e.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seats_num_txt_e.Name = "seats_num_txt_e";
            this.seats_num_txt_e.Size = new System.Drawing.Size(207, 26);
            this.seats_num_txt_e.TabIndex = 6;
            this.seats_num_txt_e.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seats_num_txt_e.ValueChanged += new System.EventHandler(this.seats_num_txt_e_ValueChanged);
            // 
            // bus_id_txt_e
            // 
            this.bus_id_txt_e.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bus_id_txt_e.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bus_id_txt_e.Location = new System.Drawing.Point(206, 26);
            this.bus_id_txt_e.Name = "bus_id_txt_e";
            this.bus_id_txt_e.Size = new System.Drawing.Size(207, 26);
            this.bus_id_txt_e.TabIndex = 1;
            // 
            // bus_id_e
            // 
            this.bus_id_e.AutoSize = true;
            this.bus_id_e.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bus_id_e.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bus_id_e.Location = new System.Drawing.Point(87, 33);
            this.bus_id_e.Name = "bus_id_e";
            this.bus_id_e.Size = new System.Drawing.Size(72, 19);
            this.bus_id_e.TabIndex = 24;
            this.bus_id_e.Text = "Bus ID:";
            // 
            // seats_num_e
            // 
            this.seats_num_e.AutoSize = true;
            this.seats_num_e.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seats_num_e.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.seats_num_e.Location = new System.Drawing.Point(5, 243);
            this.seats_num_e.Name = "seats_num_e";
            this.seats_num_e.Size = new System.Drawing.Size(153, 19);
            this.seats_num_e.TabIndex = 23;
            this.seats_num_e.Text = "Number Of Seats:";
            // 
            // destination_e
            // 
            this.destination_e.AutoSize = true;
            this.destination_e.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination_e.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.destination_e.Location = new System.Drawing.Point(42, 112);
            this.destination_e.Name = "destination_e";
            this.destination_e.Size = new System.Drawing.Size(117, 19);
            this.destination_e.TabIndex = 22;
            this.destination_e.Text = "Destination:";
            // 
            // pick_up_date_e
            // 
            this.pick_up_date_e.AutoSize = true;
            this.pick_up_date_e.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_up_date_e.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pick_up_date_e.Location = new System.Drawing.Point(32, 155);
            this.pick_up_date_e.Name = "pick_up_date_e";
            this.pick_up_date_e.Size = new System.Drawing.Size(126, 19);
            this.pick_up_date_e.TabIndex = 21;
            this.pick_up_date_e.Text = "Pick Up Time:";
            // 
            // origin_e
            // 
            this.origin_e.AutoSize = true;
            this.origin_e.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origin_e.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.origin_e.Location = new System.Drawing.Point(86, 74);
            this.origin_e.Name = "origin_e";
            this.origin_e.Size = new System.Drawing.Size(72, 19);
            this.origin_e.TabIndex = 20;
            this.origin_e.Text = "Origin:";
            // 
            // total_cost_e
            // 
            this.total_cost_e.AutoSize = true;
            this.total_cost_e.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_cost_e.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.total_cost_e.Location = new System.Drawing.Point(9, 324);
            this.total_cost_e.Name = "total_cost_e";
            this.total_cost_e.Size = new System.Drawing.Size(125, 24);
            this.total_cost_e.TabIndex = 19;
            this.total_cost_e.Text = "Total Cost:";
            // 
            // edit_bttn
            // 
            this.edit_bttn.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_bttn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.edit_bttn.Location = new System.Drawing.Point(362, 316);
            this.edit_bttn.Name = "edit_bttn";
            this.edit_bttn.Size = new System.Drawing.Size(98, 42);
            this.edit_bttn.TabIndex = 7;
            this.edit_bttn.Text = "Confirm";
            this.edit_bttn.UseVisualStyleBackColor = true;
            this.edit_bttn.Click += new System.EventHandler(this.edit_bttn_Click);
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.groupBox1);
            this.Name = "update";
            this.Size = new System.Drawing.Size(678, 387);
            this.Load += new System.EventHandler(this.update_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seats_num_txt_e)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cc_txt;
        private System.Windows.Forms.RadioButton cash_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobox_des;
        private System.Windows.Forms.ComboBox cobox_origin;
        private System.Windows.Forms.TextBox ticket_id;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.DateTimePicker pick_up_date_txt_e;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker pick_up_time_txt_e;
        private System.Windows.Forms.NumericUpDown seats_num_txt_e;
        private System.Windows.Forms.TextBox bus_id_txt_e;
        private System.Windows.Forms.Label bus_id_e;
        private System.Windows.Forms.Label seats_num_e;
        private System.Windows.Forms.Label destination_e;
        private System.Windows.Forms.Label pick_up_date_e;
        private System.Windows.Forms.Label origin_e;
        private System.Windows.Forms.Label total_cost_e;
        private System.Windows.Forms.Button edit_bttn;
    }
}
