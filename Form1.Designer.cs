namespace consultarcep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblcep = new System.Windows.Forms.Label();
            this.tbcep = new System.Windows.Forms.TextBox();
            this.tbendereco = new System.Windows.Forms.TextBox();
            this.lblrua = new System.Windows.Forms.Label();
            this.tbbairro = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.tbcidade = new System.Windows.Forms.TextBox();
            this.lblcidade = new System.Windows.Forms.Label();
            this.tbuf = new System.Windows.Forms.TextBox();
            this.lbluf = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLixeira = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcep.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcep.Location = new System.Drawing.Point(6, 19);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(120, 25);
            this.lblcep.TabIndex = 0;
            this.lblcep.Text = "Digite o CEP:";
            // 
            // tbcep
            // 
            this.tbcep.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbcep.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbcep.Location = new System.Drawing.Point(132, 16);
            this.tbcep.Name = "tbcep";
            this.tbcep.Size = new System.Drawing.Size(188, 32);
            this.tbcep.TabIndex = 1;
            this.tbcep.TextChanged += new System.EventHandler(this.tbcep_TextChanged);
            // 
            // tbendereco
            // 
            this.tbendereco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbendereco.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbendereco.Location = new System.Drawing.Point(132, 86);
            this.tbendereco.Name = "tbendereco";
            this.tbendereco.ReadOnly = true;
            this.tbendereco.Size = new System.Drawing.Size(307, 32);
            this.tbendereco.TabIndex = 3;
            // 
            // lblrua
            // 
            this.lblrua.AutoSize = true;
            this.lblrua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblrua.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblrua.Location = new System.Drawing.Point(31, 89);
            this.lblrua.Name = "lblrua";
            this.lblrua.Size = new System.Drawing.Size(95, 25);
            this.lblrua.TabIndex = 2;
            this.lblrua.Text = "Endereço:";
            // 
            // tbbairro
            // 
            this.tbbairro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbbairro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbbairro.Location = new System.Drawing.Point(132, 124);
            this.tbbairro.Name = "tbbairro";
            this.tbbairro.ReadOnly = true;
            this.tbbairro.Size = new System.Drawing.Size(307, 32);
            this.tbbairro.TabIndex = 5;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbairro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblbairro.Location = new System.Drawing.Point(59, 127);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(67, 25);
            this.lblbairro.TabIndex = 4;
            this.lblbairro.Text = "Bairro:";
            // 
            // tbcidade
            // 
            this.tbcidade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbcidade.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbcidade.Location = new System.Drawing.Point(132, 162);
            this.tbcidade.Name = "tbcidade";
            this.tbcidade.ReadOnly = true;
            this.tbcidade.Size = new System.Drawing.Size(307, 32);
            this.tbcidade.TabIndex = 7;
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcidade.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcidade.Location = new System.Drawing.Point(51, 165);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(75, 25);
            this.lblcidade.TabIndex = 6;
            this.lblcidade.Text = "Cidade:";
            // 
            // tbuf
            // 
            this.tbuf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbuf.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbuf.Location = new System.Drawing.Point(132, 200);
            this.tbuf.Name = "tbuf";
            this.tbuf.ReadOnly = true;
            this.tbuf.Size = new System.Drawing.Size(51, 32);
            this.tbuf.TabIndex = 9;
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbluf.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbluf.Location = new System.Drawing.Point(88, 203);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(38, 25);
            this.lbluf.TabIndex = 8;
            this.lbluf.Text = "UF:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(326, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 32);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLixeira
            // 
            this.btnLixeira.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLixeira.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLixeira.Image = global::BuscarEndereco.Properties.Resources.trash_delete_recycle_bin_icon_176991;
            this.btnLixeira.Location = new System.Drawing.Point(397, 200);
            this.btnLixeira.Name = "btnLixeira";
            this.btnLixeira.Size = new System.Drawing.Size(42, 44);
            this.btnLixeira.TabIndex = 11;
            this.btnLixeira.UseVisualStyleBackColor = false;
            this.btnLixeira.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.btnLixeira;
            this.ClientSize = new System.Drawing.Size(467, 257);
            this.Controls.Add(this.btnLixeira);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbuf);
            this.Controls.Add(this.lbluf);
            this.Controls.Add(this.tbcidade);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.tbbairro);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.tbendereco);
            this.Controls.Add(this.lblrua);
            this.Controls.Add(this.tbcep);
            this.Controls.Add(this.lblcep);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SBE - Sistema Buscar Endereço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblcep;
        private TextBox tbcep;
        private TextBox tbendereco;
        private Label lblrua;
        private TextBox tbbairro;
        private Label lblbairro;
        private TextBox tbcidade;
        private Label lblcidade;
        private TextBox tbuf;
        private Label lbluf;
        private Button btnBuscar;
        private Button btnLixeira;
    }
}