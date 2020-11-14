
namespace DITema4_Ejercicio1_Mouse_Tester
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(59, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 115);
            this.button1.TabIndex = 0;
            this.button1.Text = "Izquierda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.coordenadasBotones);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(342, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 115);
            this.button2.TabIndex = 1;
            this.button2.Text = "Derecha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.coordenadasBotones);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 418);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Segurito);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Prueba);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cklickraton);
            this.MouseLeave += new System.EventHandler(this.AbandonarForm);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.coordenadas);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.previewTecla);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

