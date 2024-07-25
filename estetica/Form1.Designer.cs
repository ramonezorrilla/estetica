namespace estetica
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
            components = new System.ComponentModel.Container();
            btnhabilitar = new Button();
            btnbloquear = new Button();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            lblnombre = new Label();
            lblapellido = new Label();
            menuStrip1 = new MenuStrip();
            insertarToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            consultaToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnhabilitar
            // 
            btnhabilitar.Location = new Point(153, 299);
            btnhabilitar.Name = "btnhabilitar";
            btnhabilitar.Size = new Size(75, 23);
            btnhabilitar.TabIndex = 0;
            btnhabilitar.Text = "HABILITAR";
            btnhabilitar.UseVisualStyleBackColor = true;
            btnhabilitar.Click += btnhabilitar_Click;
            // 
            // btnbloquear
            // 
            btnbloquear.Location = new Point(278, 299);
            btnbloquear.Name = "btnbloquear";
            btnbloquear.Size = new Size(75, 23);
            btnbloquear.TabIndex = 1;
            btnbloquear.Text = "BLOQUEAR";
            btnbloquear.UseVisualStyleBackColor = true;
            btnbloquear.Click += btnbloquear_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(244, 138);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 2;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(244, 184);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(100, 23);
            txtapellido.TabIndex = 3;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(182, 146);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(56, 15);
            lblnombre.TabIndex = 4;
            lblnombre.Text = "NOMBRE";
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(178, 192);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(60, 15);
            lblapellido.TabIndex = 5;
            lblapellido.Text = "APELLIDO";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { insertarToolStripMenuItem, consultaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(441, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // insertarToolStripMenuItem
            // 
            insertarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productoToolStripMenuItem });
            insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            insertarToolStripMenuItem.Size = new Size(58, 20);
            insertarToolStripMenuItem.Text = "Insertar";
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(180, 22);
            productoToolStripMenuItem.Text = "producto";
            productoToolStripMenuItem.Click += productoToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productoToolStripMenuItem1 });
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(64, 20);
            consultaToolStripMenuItem.Text = "consulta";
            // 
            // productoToolStripMenuItem1
            // 
            productoToolStripMenuItem1.Name = "productoToolStripMenuItem1";
            productoToolStripMenuItem1.Size = new Size(180, 22);
            productoToolStripMenuItem1.Text = "producto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(lblapellido);
            Controls.Add(lblnombre);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(btnbloquear);
            Controls.Add(btnhabilitar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnhabilitar;
        private Button btnbloquear;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private Label lblnombre;
        private Label lblapellido;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem insertarToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem1;
    }
}
