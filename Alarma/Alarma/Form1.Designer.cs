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
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Futura XBlk BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblhora.Location = new System.Drawing.Point(3, 7);
            this.lblhora.Margin = new System.Windows.Forms.Padding(0);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(103, 57);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "HH";
            // 
            // nudHora
            // 
            this.nudHora.BackColor = System.Drawing.SystemColors.HotTrack;
            this.nudHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHora.Location = new System.Drawing.Point(67, 112);
            this.nudHora.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHora.Name = "nudHora";
            this.nudHora.Size = new System.Drawing.Size(51, 29);
            this.nudHora.TabIndex = 2;
            this.nudHora.Tag = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(94, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alarma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Min";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudMin
            // 
            this.nudMin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.nudMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMin.Location = new System.Drawing.Point(133, 112);
            this.nudMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(45, 29);
            this.nudMin.TabIndex = 4;
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Font = new System.Drawing.Font("Futura XBlk BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblmin.Location = new System.Drawing.Point(84, 7);
            this.lblmin.Margin = new System.Windows.Forms.Padding(0);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(119, 57);
            this.lblmin.TabIndex = 6;
            this.lblmin.Text = "MM";
            this.lblmin.TextChanged += new System.EventHandler(this.lblmin_TextChanged);
            // 
            // lblseg
            // 
            this.lblseg.AutoSize = true;
            this.lblseg.Font = new System.Drawing.Font("Futura XBlk BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseg.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblseg.Location = new System.Drawing.Point(166, 7);
            this.lblseg.Margin = new System.Windows.Forms.Padding(0);
            this.lblseg.Name = "lblseg";
            this.lblseg.Size = new System.Drawing.Size(83, 57);
            this.lblseg.TabIndex = 7;
            this.lblseg.Text = "SS";
            // 
            // btnParar
            // 
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnParar.Location = new System.Drawing.Point(65, 147);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(113, 21);
            this.btnParar.TabIndex = 8;
            this.btnParar.Text = "Parar Alarma";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(65, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "FIJAR POSICION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "aLARMA";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(250, 220);
            this.ControlBox = false;
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
            this.MaximumSize = new System.Drawing.Size(250, 300);
            this.MinimumSize = new System.Drawing.Size(250, 220);
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.Text = "Alarma";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
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
    }
}

