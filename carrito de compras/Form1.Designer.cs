namespace carrito_de_compras
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Bttnguardar = new Button();
            label1 = new Label();
            Txtproducto = new TextBox();
            SuspendLayout();
            // 
            // Bttnguardar
            // 
            Bttnguardar.Location = new Point(346, 205);
            Bttnguardar.Name = "Bttnguardar";
            Bttnguardar.Size = new Size(94, 29);
            Bttnguardar.TabIndex = 0;
            Bttnguardar.Text = "Guardar";
            Bttnguardar.UseVisualStyleBackColor = true;
            Bttnguardar.Click += Bttnguardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 166);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Txtproducto
            // 
            Txtproducto.Location = new Point(331, 129);
            Txtproducto.Name = "Txtproducto";
            Txtproducto.Size = new Size(125, 27);
            Txtproducto.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Txtproducto);
            Controls.Add(label1);
            Controls.Add(Bttnguardar);
            Name = "Form1";
            Text = "Carrito de compras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bttnguardar;
        private Label label1;
        private TextBox Txtproducto;
    }
}
