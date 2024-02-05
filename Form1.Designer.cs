
namespace _11_Delegates_In_Action
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
            this.getIngedient = new System.Windows.Forms.Button();
            this.useSuzannesButton = new System.Windows.Forms.Button();
            this.useAmysButton = new System.Windows.Forms.Button();
            this.amountIngredient = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amountIngredient)).BeginInit();
            this.SuspendLayout();
            // 
            // getIngedient
            // 
            this.getIngedient.Location = new System.Drawing.Point(22, 14);
            this.getIngedient.Name = "getIngedient";
            this.getIngedient.Size = new System.Drawing.Size(192, 35);
            this.getIngedient.TabIndex = 0;
            this.getIngedient.Text = "Get the ingredient";
            this.getIngedient.UseVisualStyleBackColor = true;
            this.getIngedient.Click += new System.EventHandler(this.getIngedient_Click);
            // 
            // useSuzannesButton
            // 
            this.useSuzannesButton.Location = new System.Drawing.Point(22, 78);
            this.useSuzannesButton.Name = "useSuzannesButton";
            this.useSuzannesButton.Size = new System.Drawing.Size(295, 38);
            this.useSuzannesButton.TabIndex = 1;
            this.useSuzannesButton.Text = "Use Suzanne\'s delegate";
            this.useSuzannesButton.UseVisualStyleBackColor = true;
            this.useSuzannesButton.Click += new System.EventHandler(this.useSuzannesButton_Click);
            // 
            // useAmysButton
            // 
            this.useAmysButton.Location = new System.Drawing.Point(22, 134);
            this.useAmysButton.Name = "useAmysButton";
            this.useAmysButton.Size = new System.Drawing.Size(295, 38);
            this.useAmysButton.TabIndex = 2;
            this.useAmysButton.Text = "Use Amy\'s delegate";
            this.useAmysButton.UseVisualStyleBackColor = true;
            this.useAmysButton.Click += new System.EventHandler(this.useAmysButton_Click);
            // 
            // amountIngredient
            // 
            this.amountIngredient.Location = new System.Drawing.Point(259, 23);
            this.amountIngredient.Name = "amountIngredient";
            this.amountIngredient.Size = new System.Drawing.Size(58, 20);
            this.amountIngredient.TabIndex = 3;
            this.amountIngredient.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 208);
            this.Controls.Add(this.amountIngredient);
            this.Controls.Add(this.useAmysButton);
            this.Controls.Add(this.useSuzannesButton);
            this.Controls.Add(this.getIngedient);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.amountIngredient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getIngedient;
        private System.Windows.Forms.Button useSuzannesButton;
        private System.Windows.Forms.Button useAmysButton;
        private System.Windows.Forms.NumericUpDown amountIngredient;
    }
}

