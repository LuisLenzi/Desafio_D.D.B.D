namespace Desafio___D.D.B.D
{
        partial class Janela_Login
        {

            private System.ComponentModel.IContainer components = null;
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
            this.Texto_Login = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Texto_Usuario = new System.Windows.Forms.Label();
            this.Texto_Senha = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.TextBox();
            this.Texto_Conectando = new System.Windows.Forms.Label();
            this.Conectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Servidor = new System.Windows.Forms.TextBox();
            this.InstructionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Executar = new System.Windows.Forms.Button();
            this.Instruction_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Texto_Login
            // 
            this.Texto_Login.AutoSize = true;
            this.Texto_Login.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Login.Location = new System.Drawing.Point(203, 80);
            this.Texto_Login.Name = "Texto_Login";
            this.Texto_Login.Size = new System.Drawing.Size(68, 25);
            this.Texto_Login.TabIndex = 1;
            this.Texto_Login.Text = "Login";
            this.Texto_Login.Click += new System.EventHandler(this.Texto_Login_Click);
            // 
            // Usuario
            // 
            this.Usuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.Black;
            this.Usuario.Location = new System.Drawing.Point(109, 218);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(250, 21);
            this.Usuario.TabIndex = 2;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            // 
            // Texto_Usuario
            // 
            this.Texto_Usuario.AutoSize = true;
            this.Texto_Usuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Usuario.Location = new System.Drawing.Point(105, 196);
            this.Texto_Usuario.Name = "Texto_Usuario";
            this.Texto_Usuario.Size = new System.Drawing.Size(58, 19);
            this.Texto_Usuario.TabIndex = 3;
            this.Texto_Usuario.Text = "Usuário";
            // 
            // Texto_Senha
            // 
            this.Texto_Senha.AutoSize = true;
            this.Texto_Senha.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Senha.Location = new System.Drawing.Point(105, 253);
            this.Texto_Senha.Name = "Texto_Senha";
            this.Texto_Senha.Size = new System.Drawing.Size(53, 19);
            this.Texto_Senha.TabIndex = 5;
            this.Texto_Senha.Text = "Senha";
            this.Texto_Senha.Click += new System.EventHandler(this.Texto_Senha_Click);
            // 
            // Senha
            // 
            this.Senha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.ForeColor = System.Drawing.Color.Black;
            this.Senha.Location = new System.Drawing.Point(109, 275);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(250, 21);
            this.Senha.TabIndex = 4;
            this.Senha.UseSystemPasswordChar = true;
            this.Senha.TextChanged += new System.EventHandler(this.Senha_TextChanged);
            // 
            // Texto_Conectando
            // 
            this.Texto_Conectando.AutoSize = true;
            this.Texto_Conectando.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Conectando.Location = new System.Drawing.Point(145, 105);
            this.Texto_Conectando.Name = "Texto_Conectando";
            this.Texto_Conectando.Size = new System.Drawing.Size(178, 19);
            this.Texto_Conectando.TabIndex = 6;
            this.Texto_Conectando.Text = "Conectando ao Sistema";
            this.Texto_Conectando.Click += new System.EventHandler(this.Texto_Conectando_Click);
            // 
            // Conectar
            // 
            this.Conectar.AccessibleDescription = "Clique para Conectar";
            this.Conectar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Conectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Conectar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conectar.Location = new System.Drawing.Point(259, 325);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(100, 25);
            this.Conectar.TabIndex = 7;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = false;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Servidor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Servidor
            // 
            this.Servidor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servidor.ForeColor = System.Drawing.Color.Black;
            this.Servidor.Location = new System.Drawing.Point(109, 161);
            this.Servidor.Name = "Servidor";
            this.Servidor.Size = new System.Drawing.Size(250, 21);
            this.Servidor.TabIndex = 1;
            this.Servidor.TextChanged += new System.EventHandler(this.Servidor_TextChanged);
            // 
            // InstructionBox
            // 
            this.InstructionBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.InstructionBox.Location = new System.Drawing.Point(474, 162);
            this.InstructionBox.Multiline = true;
            this.InstructionBox.Name = "InstructionBox";
            this.InstructionBox.Size = new System.Drawing.Size(246, 135);
            this.InstructionBox.TabIndex = 12;
            this.InstructionBox.TextChanged += new System.EventHandler(this.InstructionBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Comandos [SQL]";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Executar
            // 
            this.Executar.AccessibleDescription = "Clique para Conectar";
            this.Executar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Executar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Executar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Executar.Location = new System.Drawing.Point(620, 325);
            this.Executar.Name = "Executar";
            this.Executar.Size = new System.Drawing.Size(100, 25);
            this.Executar.TabIndex = 14;
            this.Executar.Text = "Executar";
            this.Executar.UseVisualStyleBackColor = false;
            this.Executar.Click += new System.EventHandler(this.Executar_Click);
            // 
            // Instruction_Text
            // 
            this.Instruction_Text.AutoSize = true;
            this.Instruction_Text.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instruction_Text.Location = new System.Drawing.Point(469, 115);
            this.Instruction_Text.Name = "Instruction_Text";
            this.Instruction_Text.Size = new System.Drawing.Size(119, 25);
            this.Instruction_Text.TabIndex = 15;
            this.Instruction_Text.Text = "Instruções";
            // 
            // Janela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.Instruction_Text);
            this.Controls.Add(this.Executar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InstructionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Servidor);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.Texto_Senha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Texto_Usuario);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Texto_Login);
            this.Controls.Add(this.Texto_Conectando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Janela_Login";
            this.Text = "Conectando ao Sistema";
            this.Load += new System.EventHandler(this.Janela_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.Label Texto_Login;
            private System.Windows.Forms.TextBox Usuario;
            private System.Windows.Forms.Label Texto_Usuario;
            private System.Windows.Forms.Label Texto_Senha;
            private System.Windows.Forms.TextBox Senha;
            private System.Windows.Forms.Label Texto_Conectando;
            private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Servidor;
        private System.Windows.Forms.TextBox InstructionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Executar;
        private System.Windows.Forms.Label Instruction_Text;
    }
    }

