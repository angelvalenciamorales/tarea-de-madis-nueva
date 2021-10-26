
namespace Madis_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNegar = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.txtConjuncion = new System.Windows.Forms.TextBox();
            this.txtConjuncion2 = new System.Windows.Forms.TextBox();
            this.btnConjunto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.txtDis2 = new System.Windows.Forms.TextBox();
            this.lblResultado3 = new System.Windows.Forms.Label();
            this.btnDisyuncion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCondi = new System.Windows.Forms.TextBox();
            this.txtCondi2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado5 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBicon = new System.Windows.Forms.TextBox();
            this.txtBicon2 = new System.Windows.Forms.TextBox();
            this.btnBicondicion = new System.Windows.Forms.Button();
            this.lblResult6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(76, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "P = Negar ";
            // 
            // txtNegar
            // 
            this.txtNegar.Location = new System.Drawing.Point(227, 75);
            this.txtNegar.Name = "txtNegar";
            this.txtNegar.Size = new System.Drawing.Size(65, 31);
            this.txtNegar.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(329, 81);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 2;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerificar.Location = new System.Drawing.Point(622, 69);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(155, 42);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "negar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(35, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "P = Conguncion  ";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(426, 184);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(0, 25);
            this.lblResult2.TabIndex = 6;
            // 
            // txtConjuncion
            // 
            this.txtConjuncion.Location = new System.Drawing.Point(227, 177);
            this.txtConjuncion.Name = "txtConjuncion";
            this.txtConjuncion.Size = new System.Drawing.Size(65, 31);
            this.txtConjuncion.TabIndex = 7;
            // 
            // txtConjuncion2
            // 
            this.txtConjuncion2.Location = new System.Drawing.Point(324, 177);
            this.txtConjuncion2.Name = "txtConjuncion2";
            this.txtConjuncion2.Size = new System.Drawing.Size(64, 31);
            this.txtConjuncion2.TabIndex = 8;
            this.txtConjuncion2.TextChanged += new System.EventHandler(this.txtConjuncion2_TextChanged);
            // 
            // btnConjunto
            // 
            this.btnConjunto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConjunto.FlatAppearance.BorderSize = 0;
            this.btnConjunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnConjunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConjunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConjunto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConjunto.Location = new System.Drawing.Point(622, 172);
            this.btnConjunto.Name = "btnConjunto";
            this.btnConjunto.Size = new System.Drawing.Size(155, 42);
            this.btnConjunto.TabIndex = 9;
            this.btnConjunto.Text = "Conjuncion";
            this.btnConjunto.UseVisualStyleBackColor = false;
            this.btnConjunto.Click += new System.EventHandler(this.btnConjunto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(35, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "P = Disyuncion";
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(227, 283);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(65, 31);
            this.txtDis.TabIndex = 11;
            // 
            // txtDis2
            // 
            this.txtDis2.Location = new System.Drawing.Point(324, 280);
            this.txtDis2.Name = "txtDis2";
            this.txtDis2.Size = new System.Drawing.Size(65, 31);
            this.txtDis2.TabIndex = 12;
            // 
            // lblResultado3
            // 
            this.lblResultado3.AutoSize = true;
            this.lblResultado3.Location = new System.Drawing.Point(453, 289);
            this.lblResultado3.Name = "lblResultado3";
            this.lblResultado3.Size = new System.Drawing.Size(0, 25);
            this.lblResultado3.TabIndex = 13;
            // 
            // btnDisyuncion
            // 
            this.btnDisyuncion.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDisyuncion.FlatAppearance.BorderSize = 0;
            this.btnDisyuncion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDisyuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisyuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisyuncion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDisyuncion.Location = new System.Drawing.Point(622, 272);
            this.btnDisyuncion.Name = "btnDisyuncion";
            this.btnDisyuncion.Size = new System.Drawing.Size(155, 42);
            this.btnDisyuncion.TabIndex = 14;
            this.btnDisyuncion.Text = "Disyuncion ";
            this.btnDisyuncion.UseVisualStyleBackColor = false;
            this.btnDisyuncion.Click += new System.EventHandler(this.btnDisyuncion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(34, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Condicional";
            // 
            // txtCondi
            // 
            this.txtCondi.Location = new System.Drawing.Point(227, 368);
            this.txtCondi.Name = "txtCondi";
            this.txtCondi.Size = new System.Drawing.Size(65, 31);
            this.txtCondi.TabIndex = 16;
            // 
            // txtCondi2
            // 
            this.txtCondi2.Location = new System.Drawing.Point(324, 368);
            this.txtCondi2.Name = "txtCondi2";
            this.txtCondi2.Size = new System.Drawing.Size(65, 31);
            this.txtCondi2.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(622, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Condicional";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado5
            // 
            this.lblResultado5.AutoSize = true;
            this.lblResultado5.Location = new System.Drawing.Point(453, 374);
            this.lblResultado5.Name = "lblResultado5";
            this.lblResultado5.Size = new System.Drawing.Size(0, 25);
            this.lblResultado5.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(34, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Bicondicional";
            // 
            // txtBicon
            // 
            this.txtBicon.Location = new System.Drawing.Point(227, 433);
            this.txtBicon.Name = "txtBicon";
            this.txtBicon.Size = new System.Drawing.Size(65, 31);
            this.txtBicon.TabIndex = 21;
            // 
            // txtBicon2
            // 
            this.txtBicon2.Location = new System.Drawing.Point(324, 433);
            this.txtBicon2.Name = "txtBicon2";
            this.txtBicon2.Size = new System.Drawing.Size(65, 31);
            this.txtBicon2.TabIndex = 22;
            // 
            // btnBicondicion
            // 
            this.btnBicondicion.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBicondicion.FlatAppearance.BorderSize = 0;
            this.btnBicondicion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBicondicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBicondicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBicondicion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBicondicion.Location = new System.Drawing.Point(622, 428);
            this.btnBicondicion.Name = "btnBicondicion";
            this.btnBicondicion.Size = new System.Drawing.Size(155, 42);
            this.btnBicondicion.TabIndex = 23;
            this.btnBicondicion.Text = "Bicondicional";
            this.btnBicondicion.UseVisualStyleBackColor = false;
            this.btnBicondicion.Click += new System.EventHandler(this.btnBicondicion_Click);
            // 
            // lblResult6
            // 
            this.lblResult6.AutoSize = true;
            this.lblResult6.Location = new System.Drawing.Point(453, 439);
            this.lblResult6.Name = "lblResult6";
            this.lblResult6.Size = new System.Drawing.Size(0, 25);
            this.lblResult6.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1035, 513);
            this.Controls.Add(this.lblResult6);
            this.Controls.Add(this.btnBicondicion);
            this.Controls.Add(this.txtBicon2);
            this.Controls.Add(this.txtBicon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblResultado5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCondi2);
            this.Controls.Add(this.txtCondi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDisyuncion);
            this.Controls.Add(this.lblResultado3);
            this.Controls.Add(this.txtDis2);
            this.Controls.Add(this.txtDis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnConjunto);
            this.Controls.Add(this.txtConjuncion2);
            this.Controls.Add(this.txtConjuncion);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNegar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNegar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.TextBox txtConjuncion;
        private System.Windows.Forms.TextBox txtConjuncion2;
        private System.Windows.Forms.Button btnConjunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.TextBox txtDis2;
        private System.Windows.Forms.Label lblResultado3;
        private System.Windows.Forms.Button btnDisyuncion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCondi;
        private System.Windows.Forms.TextBox txtCondi2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultado5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBicon;
        private System.Windows.Forms.TextBox txtBicon2;
        private System.Windows.Forms.Button btnBicondicion;
        private System.Windows.Forms.Label lblResult6;
    }
}

