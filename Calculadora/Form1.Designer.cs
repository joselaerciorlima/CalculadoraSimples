namespace Calculadora
{
   partial class Form1
   {
      /// <summary>
      /// Variável de designer necessária.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpar os recursos que estão sendo usados.
      /// </summary>
      /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código gerado pelo Windows Form Designer

      /// <summary>
      /// Método necessário para suporte ao Designer - não modifique 
      /// o conteúdo deste método com o editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.txtDisplay = new System.Windows.Forms.TextBox();
         this.btnSete = new System.Windows.Forms.Button();
         this.btnOito = new System.Windows.Forms.Button();
         this.btnNove = new System.Windows.Forms.Button();
         this.btnQuatro = new System.Windows.Forms.Button();
         this.btnCinco = new System.Windows.Forms.Button();
         this.btnSeis = new System.Windows.Forms.Button();
         this.btnUm = new System.Windows.Forms.Button();
         this.btnDois = new System.Windows.Forms.Button();
         this.btnTres = new System.Windows.Forms.Button();
         this.btnZero = new System.Windows.Forms.Button();
         this.btnVirgula = new System.Windows.Forms.Button();
         this.btnSubtrair = new System.Windows.Forms.Button();
         this.btnSomar = new System.Windows.Forms.Button();
         this.btnNegativo = new System.Windows.Forms.Button();
         this.btnResultado = new System.Windows.Forms.Button();
         this.btnDividir = new System.Windows.Forms.Button();
         this.btnApagar = new System.Windows.Forms.Button();
         this.btnMultiplicar = new System.Windows.Forms.Button();
         this.btnLimpar = new System.Windows.Forms.Button();
         this.lblValor = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // txtDisplay
         // 
         this.txtDisplay.BackColor = System.Drawing.Color.LightGray;
         this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtDisplay.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDisplay.Location = new System.Drawing.Point(12, 16);
         this.txtDisplay.MaxLength = 12;
         this.txtDisplay.Name = "txtDisplay";
         this.txtDisplay.ReadOnly = true;
         this.txtDisplay.Size = new System.Drawing.Size(352, 56);
         this.txtDisplay.TabIndex = 1;
         this.txtDisplay.Text = "0";
         this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // btnSete
         // 
         this.btnSete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
         this.btnSete.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSete.FlatAppearance.BorderSize = 0;
         this.btnSete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
         this.btnSete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSete.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSete.Location = new System.Drawing.Point(13, 165);
         this.btnSete.Name = "btnSete";
         this.btnSete.Size = new System.Drawing.Size(85, 61);
         this.btnSete.TabIndex = 0;
         this.btnSete.Text = "7";
         this.btnSete.UseVisualStyleBackColor = false;
         this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
         // 
         // btnOito
         // 
         this.btnOito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
         this.btnOito.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnOito.FlatAppearance.BorderSize = 0;
         this.btnOito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
         this.btnOito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnOito.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnOito.Location = new System.Drawing.Point(102, 165);
         this.btnOito.Name = "btnOito";
         this.btnOito.Size = new System.Drawing.Size(85, 61);
         this.btnOito.TabIndex = 0;
         this.btnOito.Text = "8";
         this.btnOito.UseVisualStyleBackColor = false;
         this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
         // 
         // btnNove
         // 
         this.btnNove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
         this.btnNove.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnNove.FlatAppearance.BorderSize = 0;
         this.btnNove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
         this.btnNove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnNove.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnNove.Location = new System.Drawing.Point(191, 165);
         this.btnNove.Name = "btnNove";
         this.btnNove.Size = new System.Drawing.Size(85, 61);
         this.btnNove.TabIndex = 0;
         this.btnNove.Text = "9";
         this.btnNove.UseVisualStyleBackColor = false;
         this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
         // 
         // btnQuatro
         // 
         this.btnQuatro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
         this.btnQuatro.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnQuatro.FlatAppearance.BorderSize = 0;
         this.btnQuatro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
         this.btnQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnQuatro.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnQuatro.Location = new System.Drawing.Point(13, 230);
         this.btnQuatro.Name = "btnQuatro";
         this.btnQuatro.Size = new System.Drawing.Size(85, 61);
         this.btnQuatro.TabIndex = 0;
         this.btnQuatro.Text = "4";
         this.btnQuatro.UseVisualStyleBackColor = false;
         this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
         // 
         // btnCinco
         // 
         this.btnCinco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
         this.btnCinco.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnCinco.FlatAppearance.BorderSize = 0;
         this.btnCinco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
         this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnCinco.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCinco.Location = new System.Drawing.Point(102, 230);
         this.btnCinco.Name = "btnCinco";
         this.btnCinco.Size = new System.Drawing.Size(85, 61);
         this.btnCinco.TabIndex = 0;
         this.btnCinco.Text = "5";
         this.btnCinco.UseVisualStyleBackColor = false;
         this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
         // 
         // btnSeis
         // 
         this.btnSeis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
         this.btnSeis.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSeis.FlatAppearance.BorderSize = 0;
         this.btnSeis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
         this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSeis.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSeis.Location = new System.Drawing.Point(191, 230);
         this.btnSeis.Name = "btnSeis";
         this.btnSeis.Size = new System.Drawing.Size(85, 61);
         this.btnSeis.TabIndex = 0;
         this.btnSeis.Text = "6";
         this.btnSeis.UseVisualStyleBackColor = false;
         this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
         // 
         // btnUm
         // 
         this.btnUm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
         this.btnUm.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnUm.FlatAppearance.BorderSize = 0;
         this.btnUm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
         this.btnUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnUm.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnUm.Location = new System.Drawing.Point(13, 295);
         this.btnUm.Name = "btnUm";
         this.btnUm.Size = new System.Drawing.Size(85, 61);
         this.btnUm.TabIndex = 0;
         this.btnUm.Text = "1";
         this.btnUm.UseVisualStyleBackColor = false;
         this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
         // 
         // btnDois
         // 
         this.btnDois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
         this.btnDois.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnDois.FlatAppearance.BorderSize = 0;
         this.btnDois.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
         this.btnDois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnDois.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDois.Location = new System.Drawing.Point(102, 295);
         this.btnDois.Name = "btnDois";
         this.btnDois.Size = new System.Drawing.Size(85, 61);
         this.btnDois.TabIndex = 0;
         this.btnDois.Text = "2";
         this.btnDois.UseVisualStyleBackColor = false;
         this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
         // 
         // btnTres
         // 
         this.btnTres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
         this.btnTres.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnTres.FlatAppearance.BorderSize = 0;
         this.btnTres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
         this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnTres.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnTres.Location = new System.Drawing.Point(191, 295);
         this.btnTres.Name = "btnTres";
         this.btnTres.Size = new System.Drawing.Size(85, 61);
         this.btnTres.TabIndex = 0;
         this.btnTres.Text = "3";
         this.btnTres.UseVisualStyleBackColor = false;
         this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
         // 
         // btnZero
         // 
         this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
         this.btnZero.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnZero.FlatAppearance.BorderSize = 0;
         this.btnZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
         this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnZero.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnZero.Location = new System.Drawing.Point(102, 360);
         this.btnZero.Name = "btnZero";
         this.btnZero.Size = new System.Drawing.Size(85, 61);
         this.btnZero.TabIndex = 0;
         this.btnZero.Text = "0";
         this.btnZero.UseVisualStyleBackColor = false;
         this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
         // 
         // btnVirgula
         // 
         this.btnVirgula.BackColor = System.Drawing.Color.Silver;
         this.btnVirgula.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnVirgula.FlatAppearance.BorderSize = 0;
         this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnVirgula.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnVirgula.Location = new System.Drawing.Point(191, 360);
         this.btnVirgula.Name = "btnVirgula";
         this.btnVirgula.Size = new System.Drawing.Size(85, 61);
         this.btnVirgula.TabIndex = 0;
         this.btnVirgula.Text = ",";
         this.btnVirgula.UseVisualStyleBackColor = false;
         this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
         // 
         // btnSubtrair
         // 
         this.btnSubtrair.BackColor = System.Drawing.Color.Silver;
         this.btnSubtrair.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSubtrair.FlatAppearance.BorderSize = 0;
         this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSubtrair.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSubtrair.Location = new System.Drawing.Point(280, 165);
         this.btnSubtrair.Name = "btnSubtrair";
         this.btnSubtrair.Size = new System.Drawing.Size(85, 61);
         this.btnSubtrair.TabIndex = 0;
         this.btnSubtrair.Text = "-";
         this.btnSubtrair.UseVisualStyleBackColor = false;
         this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
         // 
         // btnSomar
         // 
         this.btnSomar.BackColor = System.Drawing.Color.Silver;
         this.btnSomar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSomar.FlatAppearance.BorderSize = 0;
         this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSomar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSomar.Location = new System.Drawing.Point(280, 230);
         this.btnSomar.Name = "btnSomar";
         this.btnSomar.Size = new System.Drawing.Size(85, 61);
         this.btnSomar.TabIndex = 0;
         this.btnSomar.Text = "+";
         this.btnSomar.UseVisualStyleBackColor = false;
         this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
         // 
         // btnNegativo
         // 
         this.btnNegativo.BackColor = System.Drawing.Color.Silver;
         this.btnNegativo.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnNegativo.FlatAppearance.BorderSize = 0;
         this.btnNegativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnNegativo.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnNegativo.Location = new System.Drawing.Point(13, 360);
         this.btnNegativo.Name = "btnNegativo";
         this.btnNegativo.Size = new System.Drawing.Size(85, 61);
         this.btnNegativo.TabIndex = 0;
         this.btnNegativo.Text = "+";
         this.btnNegativo.UseVisualStyleBackColor = false;
         this.btnNegativo.Click += new System.EventHandler(this.btnNegativo_Click);
         // 
         // btnResultado
         // 
         this.btnResultado.BackColor = System.Drawing.Color.Silver;
         this.btnResultado.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnResultado.FlatAppearance.BorderSize = 0;
         this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnResultado.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnResultado.Location = new System.Drawing.Point(280, 295);
         this.btnResultado.Name = "btnResultado";
         this.btnResultado.Size = new System.Drawing.Size(85, 126);
         this.btnResultado.TabIndex = 0;
         this.btnResultado.Text = "=";
         this.btnResultado.UseVisualStyleBackColor = false;
         this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
         // 
         // btnDividir
         // 
         this.btnDividir.BackColor = System.Drawing.Color.Silver;
         this.btnDividir.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnDividir.FlatAppearance.BorderSize = 0;
         this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnDividir.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDividir.Location = new System.Drawing.Point(191, 100);
         this.btnDividir.Name = "btnDividir";
         this.btnDividir.Size = new System.Drawing.Size(85, 61);
         this.btnDividir.TabIndex = 0;
         this.btnDividir.Text = "/";
         this.btnDividir.UseVisualStyleBackColor = false;
         this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
         // 
         // btnApagar
         // 
         this.btnApagar.BackColor = System.Drawing.Color.Silver;
         this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnApagar.FlatAppearance.BorderSize = 0;
         this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnApagar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnApagar.Location = new System.Drawing.Point(102, 100);
         this.btnApagar.Name = "btnApagar";
         this.btnApagar.Size = new System.Drawing.Size(85, 61);
         this.btnApagar.TabIndex = 0;
         this.btnApagar.Text = "←";
         this.btnApagar.UseVisualStyleBackColor = false;
         this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
         // 
         // btnMultiplicar
         // 
         this.btnMultiplicar.BackColor = System.Drawing.Color.Silver;
         this.btnMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnMultiplicar.FlatAppearance.BorderSize = 0;
         this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnMultiplicar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnMultiplicar.Location = new System.Drawing.Point(280, 100);
         this.btnMultiplicar.Name = "btnMultiplicar";
         this.btnMultiplicar.Size = new System.Drawing.Size(85, 61);
         this.btnMultiplicar.TabIndex = 0;
         this.btnMultiplicar.Text = "x";
         this.btnMultiplicar.UseVisualStyleBackColor = false;
         this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
         // 
         // btnLimpar
         // 
         this.btnLimpar.BackColor = System.Drawing.Color.Silver;
         this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnLimpar.FlatAppearance.BorderSize = 0;
         this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnLimpar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLimpar.Location = new System.Drawing.Point(13, 100);
         this.btnLimpar.Name = "btnLimpar";
         this.btnLimpar.Size = new System.Drawing.Size(85, 61);
         this.btnLimpar.TabIndex = 0;
         this.btnLimpar.Text = "C";
         this.btnLimpar.UseVisualStyleBackColor = false;
         this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
         // 
         // lblValor
         // 
         this.lblValor.AutoSize = true;
         this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblValor.ForeColor = System.Drawing.Color.Gray;
         this.lblValor.Location = new System.Drawing.Point(12, 16);
         this.lblValor.Name = "lblValor";
         this.lblValor.Size = new System.Drawing.Size(18, 20);
         this.lblValor.TabIndex = 20;
         this.lblValor.Text = "0";
         this.lblValor.Visible = false;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightGray;
         this.ClientSize = new System.Drawing.Size(376, 430);
         this.Controls.Add(this.lblValor);
         this.Controls.Add(this.txtDisplay);
         this.Controls.Add(this.btnResultado);
         this.Controls.Add(this.btnSomar);
         this.Controls.Add(this.btnVirgula);
         this.Controls.Add(this.btnMultiplicar);
         this.Controls.Add(this.btnSeis);
         this.Controls.Add(this.btnZero);
         this.Controls.Add(this.btnCinco);
         this.Controls.Add(this.btnNegativo);
         this.Controls.Add(this.btnApagar);
         this.Controls.Add(this.btnLimpar);
         this.Controls.Add(this.btnQuatro);
         this.Controls.Add(this.btnSubtrair);
         this.Controls.Add(this.btnDividir);
         this.Controls.Add(this.btnTres);
         this.Controls.Add(this.btnNove);
         this.Controls.Add(this.btnDois);
         this.Controls.Add(this.btnOito);
         this.Controls.Add(this.btnUm);
         this.Controls.Add(this.btnSete);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Calculadora";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtDisplay;
      private System.Windows.Forms.Button btnSete;
      private System.Windows.Forms.Button btnOito;
      private System.Windows.Forms.Button btnNove;
      private System.Windows.Forms.Button btnQuatro;
      private System.Windows.Forms.Button btnCinco;
      private System.Windows.Forms.Button btnSeis;
      private System.Windows.Forms.Button btnUm;
      private System.Windows.Forms.Button btnDois;
      private System.Windows.Forms.Button btnTres;
      private System.Windows.Forms.Button btnZero;
      private System.Windows.Forms.Button btnVirgula;
      private System.Windows.Forms.Button btnSubtrair;
      private System.Windows.Forms.Button btnSomar;
      private System.Windows.Forms.Button btnNegativo;
      private System.Windows.Forms.Button btnResultado;
      private System.Windows.Forms.Button btnDividir;
      private System.Windows.Forms.Button btnApagar;
      private System.Windows.Forms.Button btnMultiplicar;
      private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblValor;
    }
}

