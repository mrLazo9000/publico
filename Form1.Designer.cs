namespace TesteIONIC
{
    partial class frmTesteIONIC
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
            txtPalavraChave = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTextoSimples = new TextBox();
            label3 = new Label();
            txtTextoCriptografado = new TextBox();
            txtTextoDescriptografado = new TextBox();
            label4 = new Label();
            btnCriptografar = new Button();
            btnDescriptografar = new Button();
            SuspendLayout();
            // 
            // txtPalavraChave
            // 
            txtPalavraChave.Location = new Point(150, 9);
            txtPalavraChave.Name = "txtPalavraChave";
            txtPalavraChave.Size = new Size(264, 23);
            txtPalavraChave.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Palavra Chave:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Texto Simples:";
            // 
            // txtTextoSimples
            // 
            txtTextoSimples.Location = new Point(150, 40);
            txtTextoSimples.Name = "txtTextoSimples";
            txtTextoSimples.Size = new Size(264, 23);
            txtTextoSimples.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 4;
            label3.Text = "Texto Criptografado:";
            // 
            // txtTextoCriptografado
            // 
            txtTextoCriptografado.Location = new Point(150, 71);
            txtTextoCriptografado.Name = "txtTextoCriptografado";
            txtTextoCriptografado.Size = new Size(264, 23);
            txtTextoCriptografado.TabIndex = 5;
            // 
            // txtTextoDescriptografado
            // 
            txtTextoDescriptografado.Location = new Point(150, 100);
            txtTextoDescriptografado.Name = "txtTextoDescriptografado";
            txtTextoDescriptografado.Size = new Size(264, 23);
            txtTextoDescriptografado.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 103);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 6;
            label4.Text = "Texto Descriptografado:";
            // 
            // btnCriptografar
            // 
            btnCriptografar.Location = new Point(478, 70);
            btnCriptografar.Name = "btnCriptografar";
            btnCriptografar.Size = new Size(166, 23);
            btnCriptografar.TabIndex = 8;
            btnCriptografar.Text = "&Criptografar";
            btnCriptografar.UseVisualStyleBackColor = true;
            btnCriptografar.Click += btnCriptografar_Click;
            // 
            // btnDescriptografar
            // 
            btnDescriptografar.Location = new Point(478, 99);
            btnDescriptografar.Name = "btnDescriptografar";
            btnDescriptografar.Size = new Size(166, 23);
            btnDescriptografar.TabIndex = 9;
            btnDescriptografar.Text = "&Descriptografar";
            btnDescriptografar.UseVisualStyleBackColor = true;
            btnDescriptografar.Click += btnDescriptografar_Click;
            // 
            // frmTesteIONIC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 149);
            Controls.Add(btnDescriptografar);
            Controls.Add(btnCriptografar);
            Controls.Add(txtTextoDescriptografado);
            Controls.Add(label4);
            Controls.Add(txtTextoCriptografado);
            Controls.Add(label3);
            Controls.Add(txtTextoSimples);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPalavraChave);
            MaximizeBox = false;
            Name = "frmTesteIONIC";
            Text = " Teste IONIC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPalavraChave;
        private Label label1;
        private Label label2;
        private TextBox txtTextoSimples;
        private Label label3;
        private TextBox txtTextoCriptografado;
        private TextBox txtTextoDescriptografado;
        private Label label4;
        private Button btnCriptografar;
        private Button btnDescriptografar;
    }
}