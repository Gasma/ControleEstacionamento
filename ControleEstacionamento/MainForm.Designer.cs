namespace ControleEstacionamento
{
    partial class MainForm
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
            this.listaEntrada = new System.Windows.Forms.ListBox();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpEntrada = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.txtHoraSaida = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.txtHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.grpEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaEntrada
            // 
            this.listaEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaEntrada.FormattingEnabled = true;
            this.listaEntrada.ItemHeight = 25;
            this.listaEntrada.Location = new System.Drawing.Point(42, 285);
            this.listaEntrada.Name = "listaEntrada";
            this.listaEntrada.Size = new System.Drawing.Size(951, 329);
            this.listaEntrada.TabIndex = 1;
            this.listaEntrada.UseWaitCursor = true;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.AutoSize = false;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1043, 70);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "menuStrip1";
            this.menuPrincipal.UseWaitCursor = true;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 100);
            this.toolStripMenuItem1.Text = "Nova Entrada";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 100);
            this.toolStripMenuItem2.Text = "Relatórios";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(120, 100);
            this.toolStripMenuItem3.Text = "Configurações";
            // 
            // grpEntrada
            // 
            this.grpEntrada.Controls.Add(this.lblValor);
            this.grpEntrada.Controls.Add(this.txtValor);
            this.grpEntrada.Controls.Add(this.lblPlaca);
            this.grpEntrada.Controls.Add(this.txtPlaca);
            this.grpEntrada.Controls.Add(this.lblModelo);
            this.grpEntrada.Controls.Add(this.txtModelo);
            this.grpEntrada.Controls.Add(this.lblHoraSaida);
            this.grpEntrada.Controls.Add(this.txtHoraSaida);
            this.grpEntrada.Controls.Add(this.lblHoraEntrada);
            this.grpEntrada.Controls.Add(this.txtHoraEntrada);
            this.grpEntrada.Controls.Add(this.txtDataEntrada);
            this.grpEntrada.Controls.Add(this.lblDataEntrada);
            this.grpEntrada.Location = new System.Drawing.Point(42, 73);
            this.grpEntrada.Name = "grpEntrada";
            this.grpEntrada.Size = new System.Drawing.Size(950, 196);
            this.grpEntrada.TabIndex = 3;
            this.grpEntrada.TabStop = false;
            this.grpEntrada.Text = "Entrada";
            this.grpEntrada.UseWaitCursor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(112, 120);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(105, 25);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor Total:";
            this.lblValor.UseWaitCursor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(112, 148);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(128, 33);
            this.txtValor.TabIndex = 4;
            this.txtValor.UseWaitCursor = true;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(112, 39);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(61, 25);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa:";
            this.lblPlaca.UseWaitCursor = true;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(112, 67);
            this.txtPlaca.Mask = "000000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(61, 33);
            this.txtPlaca.TabIndex = 2;
            this.txtPlaca.UseWaitCursor = true;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(6, 39);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(81, 25);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            this.lblModelo.UseWaitCursor = true;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(6, 67);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 33);
            this.txtModelo.TabIndex = 3;
            this.txtModelo.UseWaitCursor = true;
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Location = new System.Drawing.Point(305, 39);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(108, 25);
            this.lblHoraSaida.TabIndex = 1;
            this.lblHoraSaida.Text = "Hora Saida:";
            this.lblHoraSaida.UseWaitCursor = true;
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.Location = new System.Drawing.Point(305, 67);
            this.txtHoraSaida.Mask = "90:00";
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.Size = new System.Drawing.Size(55, 33);
            this.txtHoraSaida.TabIndex = 2;
            this.txtHoraSaida.UseWaitCursor = true;
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(179, 39);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(127, 25);
            this.lblHoraEntrada.TabIndex = 1;
            this.lblHoraEntrada.Text = "Hora Entrada:";
            this.lblHoraEntrada.UseWaitCursor = true;
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Location = new System.Drawing.Point(179, 67);
            this.txtHoraEntrada.Mask = "90:00";
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(55, 33);
            this.txtHoraEntrada.TabIndex = 2;
            this.txtHoraEntrada.UseWaitCursor = true;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(6, 148);
            this.txtDataEntrada.Mask = "00/00/0000";
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(97, 33);
            this.txtDataEntrada.TabIndex = 2;
            this.txtDataEntrada.UseWaitCursor = true;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(6, 120);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(55, 25);
            this.lblDataEntrada.TabIndex = 1;
            this.lblDataEntrada.Text = "Data:";
            this.lblDataEntrada.UseWaitCursor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1043, 637);
            this.Controls.Add(this.grpEntrada);
            this.Controls.Add(this.listaEntrada);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Controle Estacionamento";
            this.UseWaitCursor = true;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.grpEntrada.ResumeLayout(false);
            this.grpEntrada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listaEntrada;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.GroupBox grpEntrada;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.MaskedTextBox txtDataEntrada;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.MaskedTextBox txtHoraSaida;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.MaskedTextBox txtHoraEntrada;
    }
}

