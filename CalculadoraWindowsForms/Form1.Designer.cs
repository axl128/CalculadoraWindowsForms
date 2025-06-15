
    namespace CalculadoraWindowsForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Button[] botones;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.botones = new System.Windows.Forms.Button[17];
            this.SuspendLayout();

            // TextBox
            this.txtPantalla.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtPantalla.Location = new System.Drawing.Point(10, 10);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPantalla.Size = new System.Drawing.Size(260, 43);

            // Botones
            string[] textos = { "7", "8", "9", "/",
                                "4", "5", "6", "*",
                                "1", "2", "3", "-",
                                "0", ".", "=", "+",
                                "C" };

            for (int i = 0; i < textos.Length; i++)
            {
                botones[i] = new System.Windows.Forms.Button();
                botones[i].Font = new System.Drawing.Font("Segoe UI", 14F);
                botones[i].Size = new System.Drawing.Size(60, 40);
                botones[i].Text = textos[i];
                botones[i].Tag = textos[i];
                int row = i / 4;
                int col = i % 4;
                if (i == 16) // C (Clear) botón centrado
                {
                    botones[i].Location = new System.Drawing.Point(10, 230);
                    botones[i].Size = new System.Drawing.Size(260, 40);
                    botones[i].Click += new System.EventHandler(this.btnLimpiar_Click);
                }
                else
                {
                    botones[i].Location = new System.Drawing.Point(10 + col * 65, 60 + row * 45);
                    if (textos[i] == "+" || textos[i] == "-" || textos[i] == "*" || textos[i] == "/")
                        botones[i].Click += new System.EventHandler(this.btnOperador_Click);
                    else if (textos[i] == "=")
                        botones[i].Click += new System.EventHandler(this.btnIgual_Click);
                    else
                        botones[i].Click += new System.EventHandler(this.btnNumero_Click);
                }
                this.Controls.Add(botones[i]);
            }

            // Formulario
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.txtPantalla);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

