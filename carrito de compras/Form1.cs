namespace carrito_de_compras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            txtNombre = new TextBox();
            txtColor = new TextBox();
            txtTamaño = new TextBox();
            txtPrecio = new TextBox();
            txtProductos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(821, 40);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(117, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(117, 96);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(125, 27);
            txtColor.TabIndex = 2;
            // 
            // txtTamaño
            // 
            txtTamaño.Location = new Point(117, 145);
            txtTamaño.Name = "txtTamaño";
            txtTamaño.Size = new Size(125, 27);
            txtTamaño.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(377, 36);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 5;
            // 
            // txtProductos
            // 
            txtProductos.Location = new Point(657, 119);
            txtProductos.Multiline = true;
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(396, 222);
            txtProductos.TabIndex = 6;
            txtProductos.TextChanged += txtProductos_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 8;
            label2.Text = "Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 152);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 9;
            label3.Text = "Tamaño";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 38);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "Precio";
            // 
            // Form1
            // 
            ClientSize = new Size(1293, 353);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProductos);
            Controls.Add(txtPrecio);
            Controls.Add(txtTamaño);
            Controls.Add(txtColor);
            Controls.Add(txtNombre);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Producto _producto = new Producto(
            txtNombre.Text,
            txtColor.Text,
            txtTamaño.Text,
            double.Parse(txtPrecio.Text));

            //_producto.Nombre = txtNombre.Text;
            //_producto.Color = txtColor.Text;
            //_producto.Precio = int.Parse(txtPrecio.Text);
            //_producto.Tamaño = txtTamaño.Text;

            txtProductos.Text = _producto.mostrar();
        }

        private Button button1;
        private TextBox txtNombre;
        private TextBox txtColor;
        private TextBox txtTamaño;
        private TextBox txtPrecio;
        private TextBox txtProductos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        private void txtProductos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
