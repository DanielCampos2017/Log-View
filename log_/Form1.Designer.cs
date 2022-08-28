namespace log_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colunaDataHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnArquivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMensagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListar = new System.Windows.Forms.Button();
            this.textBoxDataInicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDataFim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDiretorio = new System.Windows.Forms.TextBox();
            this.labelQTD = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDiretorio = new System.Windows.Forms.RadioButton();
            this.radioButtonData = new System.Windows.Forms.RadioButton();
            this.radioButtonNull = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(420, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(624, 418);
            this.textBox1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaDataHora,
            this.columnUsuario,
            this.columnArquivo,
            this.columnMensagem});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(410, 418);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // colunaDataHora
            // 
            this.colunaDataHora.Text = "Data e Hora";
            this.colunaDataHora.Width = 130;
            // 
            // columnUsuario
            // 
            this.columnUsuario.Text = "Usuario";
            this.columnUsuario.Width = 120;
            // 
            // columnArquivo
            // 
            this.columnArquivo.Text = "Arquivo";
            this.columnArquivo.Width = 450;
            // 
            // columnMensagem
            // 
            this.columnMensagem.Text = ".";
            this.columnMensagem.Width = 0;
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(950, 531);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(94, 28);
            this.btnListar.TabIndex = 22;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // textBoxDataInicio
            // 
            this.textBoxDataInicio.Location = new System.Drawing.Point(6, 36);
            this.textBoxDataInicio.Name = "textBoxDataInicio";
            this.textBoxDataInicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataInicio.TabIndex = 25;
            this.textBoxDataInicio.Text = "24/08/2022";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Entre";
            // 
            // textBoxDataFim
            // 
            this.textBoxDataFim.Location = new System.Drawing.Point(150, 36);
            this.textBoxDataFim.Name = "textBoxDataFim";
            this.textBoxDataFim.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataFim.TabIndex = 27;
            this.textBoxDataFim.Text = "25/08/2022";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Diretorio";
            // 
            // textBoxDiretorio
            // 
            this.textBoxDiretorio.Location = new System.Drawing.Point(6, 77);
            this.textBoxDiretorio.Name = "textBoxDiretorio";
            this.textBoxDiretorio.Size = new System.Drawing.Size(396, 20);
            this.textBoxDiretorio.TabIndex = 29;
            // 
            // labelQTD
            // 
            this.labelQTD.AutoSize = true;
            this.labelQTD.Location = new System.Drawing.Point(1, 433);
            this.labelQTD.Name = "labelQTD";
            this.labelQTD.Size = new System.Drawing.Size(147, 13);
            this.labelQTD.TabIndex = 30;
            this.labelQTD.Text = "Total Eventos encontrados: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDiretorio);
            this.groupBox1.Controls.Add(this.textBoxDataFim);
            this.groupBox1.Controls.Add(this.textBoxDiretorio);
            this.groupBox1.Controls.Add(this.radioButtonData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxDataInicio);
            this.groupBox1.Controls.Add(this.radioButtonNull);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 454);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 105);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // radioButtonDiretorio
            // 
            this.radioButtonDiretorio.AutoSize = true;
            this.radioButtonDiretorio.Location = new System.Drawing.Point(109, 15);
            this.radioButtonDiretorio.Name = "radioButtonDiretorio";
            this.radioButtonDiretorio.Size = new System.Drawing.Size(64, 17);
            this.radioButtonDiretorio.TabIndex = 34;
            this.radioButtonDiretorio.Text = "Diretorio";
            this.radioButtonDiretorio.UseVisualStyleBackColor = true;
            // 
            // radioButtonData
            // 
            this.radioButtonData.AutoSize = true;
            this.radioButtonData.Checked = true;
            this.radioButtonData.Location = new System.Drawing.Point(55, 15);
            this.radioButtonData.Name = "radioButtonData";
            this.radioButtonData.Size = new System.Drawing.Size(48, 17);
            this.radioButtonData.TabIndex = 33;
            this.radioButtonData.TabStop = true;
            this.radioButtonData.Text = "Data";
            this.radioButtonData.UseVisualStyleBackColor = true;
            // 
            // radioButtonNull
            // 
            this.radioButtonNull.AutoSize = true;
            this.radioButtonNull.Location = new System.Drawing.Point(6, 15);
            this.radioButtonNull.Name = "radioButtonNull";
            this.radioButtonNull.Size = new System.Drawing.Size(43, 17);
            this.radioButtonNull.TabIndex = 35;
            this.radioButtonNull.Text = "Null";
            this.radioButtonNull.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelQTD);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos..";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colunaDataHora;
        private System.Windows.Forms.ColumnHeader columnMensagem;
        private System.Windows.Forms.ColumnHeader columnArquivo;
        private System.Windows.Forms.ColumnHeader columnUsuario;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox textBoxDataInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDataFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDiretorio;
        private System.Windows.Forms.Label labelQTD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDiretorio;
        private System.Windows.Forms.RadioButton radioButtonData;
        private System.Windows.Forms.RadioButton radioButtonNull;
    }
}

