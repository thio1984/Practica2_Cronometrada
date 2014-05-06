namespace Pratica2
{
    partial class Form1
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
            this.timelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusleftlabel = new System.Windows.Forms.Label();
            this.plusrigthlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.NumericUpDown();
            this.diferencia = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minusrigthlabel = new System.Windows.Forms.Label();
            this.minusleftlabel = new System.Windows.Forms.Label();
            this.cociente = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dividerigthlabel = new System.Windows.Forms.Label();
            this.divideleftlabel = new System.Windows.Forms.Label();
            this.producto = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timesrigthlabel = new System.Windows.Forms.Label();
            this.timesleftlabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.suma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cociente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto)).BeginInit();
            this.SuspendLayout();
            // 
            // timelabel
            // 
            this.timelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.Location = new System.Drawing.Point(272, 9);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(200, 30);
            this.timelabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiempo Restante";
            // 
            // plusleftlabel
            // 
            this.plusleftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusleftlabel.Location = new System.Drawing.Point(50, 75);
            this.plusleftlabel.Name = "plusleftlabel";
            this.plusleftlabel.Size = new System.Drawing.Size(60, 50);
            this.plusleftlabel.TabIndex = 2;
            this.plusleftlabel.Text = "?";
            this.plusleftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusrigthlabel
            // 
            this.plusrigthlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusrigthlabel.Location = new System.Drawing.Point(182, 75);
            this.plusrigthlabel.Name = "plusrigthlabel";
            this.plusrigthlabel.Size = new System.Drawing.Size(60, 50);
            this.plusrigthlabel.TabIndex = 3;
            this.plusrigthlabel.Text = "?";
            this.plusrigthlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suma
            // 
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(372, 84);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(100, 35);
            this.suma.TabIndex = 2;
            this.suma.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // diferencia
            // 
            this.diferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diferencia.Location = new System.Drawing.Point(372, 134);
            this.diferencia.Name = "diferencia";
            this.diferencia.Size = new System.Drawing.Size(100, 35);
            this.diferencia.TabIndex = 3;
            this.diferencia.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusrigthlabel
            // 
            this.minusrigthlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusrigthlabel.Location = new System.Drawing.Point(182, 125);
            this.minusrigthlabel.Name = "minusrigthlabel";
            this.minusrigthlabel.Size = new System.Drawing.Size(60, 50);
            this.minusrigthlabel.TabIndex = 8;
            this.minusrigthlabel.Text = "?";
            this.minusrigthlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusleftlabel
            // 
            this.minusleftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusleftlabel.Location = new System.Drawing.Point(50, 125);
            this.minusleftlabel.Name = "minusleftlabel";
            this.minusleftlabel.Size = new System.Drawing.Size(60, 50);
            this.minusleftlabel.TabIndex = 7;
            this.minusleftlabel.Text = "?";
            this.minusleftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cociente
            // 
            this.cociente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cociente.Location = new System.Drawing.Point(372, 234);
            this.cociente.Name = "cociente";
            this.cociente.Size = new System.Drawing.Size(100, 35);
            this.cociente.TabIndex = 5;
            this.cociente.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 20;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 19;
            this.label9.Text = "/";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividerigthlabel
            // 
            this.dividerigthlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerigthlabel.Location = new System.Drawing.Point(182, 225);
            this.dividerigthlabel.Name = "dividerigthlabel";
            this.dividerigthlabel.Size = new System.Drawing.Size(60, 50);
            this.dividerigthlabel.TabIndex = 18;
            this.dividerigthlabel.Text = "?";
            this.dividerigthlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideleftlabel
            // 
            this.divideleftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideleftlabel.Location = new System.Drawing.Point(50, 225);
            this.divideleftlabel.Name = "divideleftlabel";
            this.divideleftlabel.Size = new System.Drawing.Size(60, 50);
            this.divideleftlabel.TabIndex = 17;
            this.divideleftlabel.Text = "?";
            this.divideleftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // producto
            // 
            this.producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producto.Location = new System.Drawing.Point(372, 184);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(100, 35);
            this.producto.TabIndex = 4;
            this.producto.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(248, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 15;
            this.label12.Text = "=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(116, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 14;
            this.label13.Text = "*";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesrigthlabel
            // 
            this.timesrigthlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesrigthlabel.Location = new System.Drawing.Point(182, 175);
            this.timesrigthlabel.Name = "timesrigthlabel";
            this.timesrigthlabel.Size = new System.Drawing.Size(60, 50);
            this.timesrigthlabel.TabIndex = 13;
            this.timesrigthlabel.Text = "?";
            this.timesrigthlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesleftlabel
            // 
            this.timesleftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesleftlabel.Location = new System.Drawing.Point(50, 175);
            this.timesleftlabel.Name = "timesleftlabel";
            this.timesleftlabel.Size = new System.Drawing.Size(60, 50);
            this.timesleftlabel.TabIndex = 12;
            this.timesleftlabel.Text = "?";
            this.timesleftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(154, 315);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(154, 34);
            this.startButton.TabIndex = 22;
            this.startButton.Text = "Iniciar la Prueba";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cociente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dividerigthlabel);
            this.Controls.Add(this.divideleftlabel);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.timesrigthlabel);
            this.Controls.Add(this.timesleftlabel);
            this.Controls.Add(this.diferencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minusrigthlabel);
            this.Controls.Add(this.minusleftlabel);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plusrigthlabel);
            this.Controls.Add(this.plusleftlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba matemática.";
            ((System.ComponentModel.ISupportInitialize)(this.suma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cociente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusleftlabel;
        private System.Windows.Forms.Label plusrigthlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown suma;
        private System.Windows.Forms.NumericUpDown diferencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minusrigthlabel;
        private System.Windows.Forms.Label minusleftlabel;
        private System.Windows.Forms.NumericUpDown cociente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dividerigthlabel;
        private System.Windows.Forms.Label divideleftlabel;
        private System.Windows.Forms.NumericUpDown producto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label timesrigthlabel;
        private System.Windows.Forms.Label timesleftlabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

