
namespace COMPort___Monitor
{
    partial class COMPort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COMPort));
            this.textBox = new System.Windows.Forms.TextBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.port_cb = new System.Windows.Forms.ComboBox();
            this.parity_cb = new System.Windows.Forms.ComboBox();
            this.baudrate_cb = new System.Windows.Forms.ComboBox();
            this.stopbits_cb = new System.Windows.Forms.ComboBox();
            this.databits_cb = new System.Windows.Forms.ComboBox();
            this.min_btn = new System.Windows.Forms.Button();
            this.exitprogram_btn = new System.Windows.Forms.Button();
            this.save_file_btn = new System.Windows.Forms.Button();
            this.save_db_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 164);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(656, 248);
            this.textBox.TabIndex = 0;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.Transparent;
            this.clear_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(459, 133);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(71, 25);
            this.clear_btn.TabIndex = 22;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.Transparent;
            this.stop_btn.FlatAppearance.BorderSize = 0;
            this.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_btn.Location = new System.Drawing.Point(597, 133);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(70, 25);
            this.stop_btn.TabIndex = 21;
            this.stop_btn.Text = "STOP";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.Transparent;
            this.start_btn.FlatAppearance.BorderSize = 0;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.Color.Black;
            this.start_btn.Location = new System.Drawing.Point(522, 133);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(79, 25);
            this.start_btn.TabIndex = 20;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.port_cb);
            this.panel1.Controls.Add(this.parity_cb);
            this.panel1.Controls.Add(this.baudrate_cb);
            this.panel1.Controls.Add(this.stopbits_cb);
            this.panel1.Controls.Add(this.databits_cb);
            this.panel1.Location = new System.Drawing.Point(1, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 72);
            this.panel1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(561, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Stop bits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(428, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data bits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(306, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Parity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(160, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Baud rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Port nr:";
            // 
            // port_cb
            // 
            this.port_cb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.port_cb.FormattingEnabled = true;
            this.port_cb.Location = new System.Drawing.Point(10, 36);
            this.port_cb.Name = "port_cb";
            this.port_cb.Size = new System.Drawing.Size(121, 21);
            this.port_cb.TabIndex = 19;
            // 
            // parity_cb
            // 
            this.parity_cb.FormattingEnabled = true;
            this.parity_cb.Location = new System.Drawing.Point(277, 36);
            this.parity_cb.Name = "parity_cb";
            this.parity_cb.Size = new System.Drawing.Size(121, 21);
            this.parity_cb.TabIndex = 18;
            // 
            // baudrate_cb
            // 
            this.baudrate_cb.FormattingEnabled = true;
            this.baudrate_cb.Location = new System.Drawing.Point(144, 36);
            this.baudrate_cb.Name = "baudrate_cb";
            this.baudrate_cb.Size = new System.Drawing.Size(121, 21);
            this.baudrate_cb.TabIndex = 17;
            // 
            // stopbits_cb
            // 
            this.stopbits_cb.FormattingEnabled = true;
            this.stopbits_cb.Location = new System.Drawing.Point(545, 36);
            this.stopbits_cb.Name = "stopbits_cb";
            this.stopbits_cb.Size = new System.Drawing.Size(121, 21);
            this.stopbits_cb.TabIndex = 16;
            // 
            // databits_cb
            // 
            this.databits_cb.FormattingEnabled = true;
            this.databits_cb.Location = new System.Drawing.Point(411, 36);
            this.databits_cb.Name = "databits_cb";
            this.databits_cb.Size = new System.Drawing.Size(121, 21);
            this.databits_cb.TabIndex = 15;
            // 
            // min_btn
            // 
            this.min_btn.BackColor = System.Drawing.Color.Transparent;
            this.min_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("min_btn.BackgroundImage")));
            this.min_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.min_btn.FlatAppearance.BorderSize = 0;
            this.min_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_btn.Location = new System.Drawing.Point(611, 11);
            this.min_btn.Name = "min_btn";
            this.min_btn.Size = new System.Drawing.Size(25, 25);
            this.min_btn.TabIndex = 24;
            this.min_btn.UseVisualStyleBackColor = false;
            this.min_btn.Click += new System.EventHandler(this.min_btn_Click);
            // 
            // exitprogram_btn
            // 
            this.exitprogram_btn.BackColor = System.Drawing.Color.Transparent;
            this.exitprogram_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitprogram_btn.BackgroundImage")));
            this.exitprogram_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitprogram_btn.FlatAppearance.BorderSize = 0;
            this.exitprogram_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitprogram_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitprogram_btn.Location = new System.Drawing.Point(642, 13);
            this.exitprogram_btn.Name = "exitprogram_btn";
            this.exitprogram_btn.Size = new System.Drawing.Size(25, 25);
            this.exitprogram_btn.TabIndex = 27;
            this.exitprogram_btn.UseVisualStyleBackColor = false;
            this.exitprogram_btn.Click += new System.EventHandler(this.exitprogram_btn_Click);
            // 
            // save_file_btn
            // 
            this.save_file_btn.BackColor = System.Drawing.Color.Transparent;
            this.save_file_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.save_file_btn.FlatAppearance.BorderSize = 0;
            this.save_file_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_file_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_file_btn.Location = new System.Drawing.Point(13, 133);
            this.save_file_btn.Name = "save_file_btn";
            this.save_file_btn.Size = new System.Drawing.Size(119, 25);
            this.save_file_btn.TabIndex = 28;
            this.save_file_btn.Text = "Save As File";
            this.save_file_btn.UseVisualStyleBackColor = false;
            this.save_file_btn.Click += new System.EventHandler(this.save_file_btn_Click);
            // 
            // save_db_btn
            // 
            this.save_db_btn.BackColor = System.Drawing.Color.Transparent;
            this.save_db_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.save_db_btn.FlatAppearance.BorderSize = 0;
            this.save_db_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_db_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_db_btn.Location = new System.Drawing.Point(138, 133);
            this.save_db_btn.Name = "save_db_btn";
            this.save_db_btn.Size = new System.Drawing.Size(116, 25);
            this.save_db_btn.TabIndex = 29;
            this.save_db_btn.Text = "Save To DB";
            this.save_db_btn.UseVisualStyleBackColor = false;
            this.save_db_btn.Click += new System.EventHandler(this.save_db_btn_Click);
            // 
            // COMPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(184)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(680, 422);
            this.Controls.Add(this.save_db_btn);
            this.Controls.Add(this.save_file_btn);
            this.Controls.Add(this.exitprogram_btn);
            this.Controls.Add(this.min_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "COMPort";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button start_btn;
        #region Windows Form Designer generated code

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox port_cb;
        private System.Windows.Forms.ComboBox parity_cb;
        private System.Windows.Forms.ComboBox baudrate_cb;
        private System.Windows.Forms.ComboBox stopbits_cb;
        private System.Windows.Forms.ComboBox databits_cb;
        private System.Windows.Forms.Button min_btn;
        private System.Windows.Forms.Button exitprogram_btn;
        private System.Windows.Forms.Button save_file_btn;
        private System.Windows.Forms.Button save_db_btn;
    }
}

