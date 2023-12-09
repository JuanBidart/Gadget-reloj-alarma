namespace Alarma
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblhora = new System.Windows.Forms.Label();
            this.nudHora = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblseg = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pbxAlarma = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlarma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblhora.Location = new System.Drawing.Point(5, 22);
            this.lblhora.Margin = new System.Windows.Forms.Padding(0);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(116, 69);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "HH";
            // 
            // nudHora
            // 
            this.nudHora.BackColor = System.Drawing.SystemColors.ControlText;
            this.nudHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHora.ForeColor = System.Drawing.Color.SeaGreen;
            this.nudHora.Location = new System.Drawing.Point(87, 154);
            this.nudHora.Margin = new System.Windows.Forms.Padding(4);
            this.nudHora.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHora.Name = "nudHora";
            this.nudHora.Size = new System.Drawing.Size(68, 34);
            this.nudHora.TabIndex = 2;
            this.nudHora.Tag = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(101, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(119, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alarma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(189, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Min";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudMin
            // 
            this.nudMin.BackColor = System.Drawing.SystemColors.ControlText;
            this.nudMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMin.ForeColor = System.Drawing.Color.SeaGreen;
            this.nudMin.Location = new System.Drawing.Point(175, 154);
            this.nudMin.Margin = new System.Windows.Forms.Padding(4);
            this.nudMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(60, 34);
            this.nudMin.TabIndex = 4;
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblmin.Location = new System.Drawing.Point(105, 22);
            this.lblmin.Margin = new System.Windows.Forms.Padding(0);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(130, 69);
            this.lblmin.TabIndex = 6;
            this.lblmin.Text = "MM";
            this.lblmin.TextChanged += new System.EventHandler(this.lblmin_TextChanged);
            // 
            // lblseg
            // 
            this.lblseg.AutoSize = true;
            this.lblseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseg.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblseg.Location = new System.Drawing.Point(219, 22);
            this.lblseg.Margin = new System.Windows.Forms.Padding(0);
            this.lblseg.Name = "lblseg";
            this.lblseg.Size = new System.Drawing.Size(110, 69);
            this.lblseg.TabIndex = 7;
            this.lblseg.Text = "SS";
            // 
            // btnParar
            // 
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnParar.Location = new System.Drawing.Point(86, 196);
            this.btnParar.Margin = new System.Windows.Forms.Padding(4);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(151, 26);
            this.btnParar.TabIndex = 8;
            this.btnParar.Text = "Parar Alarma";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(87, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "FIJAR POSICION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ALARMA";
            this.notifyIcon1.Visible = true;
            // 
            // pbxAlarma
            // 
            this.pbxAlarma.Location = new System.Drawing.Point(243, 128);
            this.pbxAlarma.Margin = new System.Windows.Forms.Padding(4);
            this.pbxAlarma.Name = "pbxAlarma";
            this.pbxAlarma.Size = new System.Drawing.Size(77, 60);
            this.pbxAlarma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAlarma.TabIndex = 10;
            this.pbxAlarma.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(28, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(115, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Minutos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(218, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Segundos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MintCream;
            this.label7.Location = new System.Drawing.Point(307, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "x";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseLeave += new System.EventHandler(this.label7_MouseLeave);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label7_MouseMove);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(12, 112);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 147);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(1, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Opacidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(333, 271);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxAlarma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.lblseg);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudHora);
            this.Controls.Add(this.lblhora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(333, 369);
            this.MinimumSize = new System.Drawing.Size(333, 271);
            this.Name = "Form1";
            this.Text = "Alarma";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlarma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.NumericUpDown nudHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblseg;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pbxAlarma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label8;
    }
}

