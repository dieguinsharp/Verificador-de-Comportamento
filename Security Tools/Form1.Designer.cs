namespace Security_Tools
{
    partial class frmTools
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTools));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRegeditCURRENT = new System.Windows.Forms.Button();
            this.BtnAbrirStartUp = new System.Windows.Forms.Button();
            this.BtnAbrirPrefetch = new System.Windows.Forms.Button();
            this.BtnAbrirTemp = new System.Windows.Forms.Button();
            this.BtnSoluçãoProblemas = new System.Windows.Forms.Button();
            this.BtnStartMsconfig = new System.Windows.Forms.Button();
            this.BtnClearStartUp = new System.Windows.Forms.Button();
            this.btnClearPrefetch = new System.Windows.Forms.Button();
            this.btnClearTEmp = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegeditLOCALMACHINE = new System.Windows.Forms.Button();
            this.grpboxferramentas = new System.Windows.Forms.GroupBox();
            this.btnStartUp = new System.Windows.Forms.Button();
            this.btnTEMP = new System.Windows.Forms.Button();
            this.listStartUp = new System.Windows.Forms.ListBox();
            this.GrpChecarArquivos = new System.Windows.Forms.GroupBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.PictureIcone = new System.Windows.Forms.PictureBox();
            this.grpResultadoVerificação = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.listBoxVerificação = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNomeUSer = new System.Windows.Forms.Label();
            this.lblmaquina = new System.Windows.Forms.Label();
            this.lblNomeUsurio = new System.Windows.Forms.Label();
            this.lblNomeMaquina = new System.Windows.Forms.Label();
            this.grpBoxComportamento = new System.Windows.Forms.GroupBox();
            this.listTEMP = new System.Windows.Forms.ListBox();
            this.btnPrefetch = new System.Windows.Forms.Button();
            this.listPrefetch = new System.Windows.Forms.ListBox();
            this.GroupBox1.SuspendLayout();
            this.grpboxferramentas.SuspendLayout();
            this.GrpChecarArquivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcone)).BeginInit();
            this.grpResultadoVerificação.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpBoxComportamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Interval = 25;
            // 
            // btnRegeditCURRENT
            // 
            this.btnRegeditCURRENT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegeditCURRENT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegeditCURRENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegeditCURRENT.ForeColor = System.Drawing.Color.Black;
            this.btnRegeditCURRENT.Location = new System.Drawing.Point(5, 65);
            this.btnRegeditCURRENT.Name = "btnRegeditCURRENT";
            this.btnRegeditCURRENT.Size = new System.Drawing.Size(236, 35);
            this.btnRegeditCURRENT.TabIndex = 18;
            this.btnRegeditCURRENT.Text = "Regedit - HKEY_CURRENT_USER";
            this.btnRegeditCURRENT.UseVisualStyleBackColor = false;
            this.btnRegeditCURRENT.Click += new System.EventHandler(this.btnRegeditCURRENT_Click);
            // 
            // BtnAbrirStartUp
            // 
            this.BtnAbrirStartUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAbrirStartUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbrirStartUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirStartUp.ForeColor = System.Drawing.Color.Black;
            this.BtnAbrirStartUp.Location = new System.Drawing.Point(300, 131);
            this.BtnAbrirStartUp.Name = "BtnAbrirStartUp";
            this.BtnAbrirStartUp.Size = new System.Drawing.Size(130, 23);
            this.BtnAbrirStartUp.TabIndex = 20;
            this.BtnAbrirStartUp.Text = "Abrir Pasta STARTUP";
            this.BtnAbrirStartUp.UseVisualStyleBackColor = false;
            this.BtnAbrirStartUp.Click += new System.EventHandler(this.BtnAbrirStartUp_Click);
            // 
            // BtnAbrirPrefetch
            // 
            this.BtnAbrirPrefetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAbrirPrefetch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbrirPrefetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirPrefetch.ForeColor = System.Drawing.Color.Black;
            this.BtnAbrirPrefetch.Location = new System.Drawing.Point(145, 131);
            this.BtnAbrirPrefetch.Name = "BtnAbrirPrefetch";
            this.BtnAbrirPrefetch.Size = new System.Drawing.Size(149, 23);
            this.BtnAbrirPrefetch.TabIndex = 19;
            this.BtnAbrirPrefetch.Text = "Abrir Pasta PREFETCH";
            this.BtnAbrirPrefetch.UseVisualStyleBackColor = false;
            this.BtnAbrirPrefetch.Click += new System.EventHandler(this.BtnAbrirPrefetch_Click);
            // 
            // BtnAbrirTemp
            // 
            this.BtnAbrirTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAbrirTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbrirTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirTemp.ForeColor = System.Drawing.Color.Black;
            this.BtnAbrirTemp.Location = new System.Drawing.Point(6, 131);
            this.BtnAbrirTemp.Name = "BtnAbrirTemp";
            this.BtnAbrirTemp.Size = new System.Drawing.Size(133, 23);
            this.BtnAbrirTemp.TabIndex = 18;
            this.BtnAbrirTemp.Text = "Abrir Pasta TEMP";
            this.BtnAbrirTemp.UseVisualStyleBackColor = false;
            this.BtnAbrirTemp.Click += new System.EventHandler(this.BtnAbrirTemp_Click);
            // 
            // BtnSoluçãoProblemas
            // 
            this.BtnSoluçãoProblemas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSoluçãoProblemas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSoluçãoProblemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSoluçãoProblemas.ForeColor = System.Drawing.Color.Black;
            this.BtnSoluçãoProblemas.Location = new System.Drawing.Point(6, 160);
            this.BtnSoluçãoProblemas.Name = "BtnSoluçãoProblemas";
            this.BtnSoluçãoProblemas.Size = new System.Drawing.Size(424, 31);
            this.BtnSoluçãoProblemas.TabIndex = 17;
            this.BtnSoluçãoProblemas.Text = "Problemas ao executar as funções?";
            this.BtnSoluçãoProblemas.UseVisualStyleBackColor = false;
            this.BtnSoluçãoProblemas.Click += new System.EventHandler(this.BtnSoluçãoProblemas_Click);
            // 
            // BtnStartMsconfig
            // 
            this.BtnStartMsconfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnStartMsconfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStartMsconfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStartMsconfig.ForeColor = System.Drawing.Color.Black;
            this.BtnStartMsconfig.Location = new System.Drawing.Point(6, 104);
            this.BtnStartMsconfig.Name = "BtnStartMsconfig";
            this.BtnStartMsconfig.Size = new System.Drawing.Size(168, 23);
            this.BtnStartMsconfig.TabIndex = 16;
            this.BtnStartMsconfig.Text = "Checar MsConfig";
            this.BtnStartMsconfig.UseVisualStyleBackColor = false;
            this.BtnStartMsconfig.Click += new System.EventHandler(this.BtnStartMsconfig_Click);
            // 
            // BtnClearStartUp
            // 
            this.BtnClearStartUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClearStartUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearStartUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearStartUp.ForeColor = System.Drawing.Color.Black;
            this.BtnClearStartUp.Location = new System.Drawing.Point(6, 77);
            this.BtnClearStartUp.Name = "BtnClearStartUp";
            this.BtnClearStartUp.Size = new System.Drawing.Size(168, 23);
            this.BtnClearStartUp.TabIndex = 15;
            this.BtnClearStartUp.Text = "Apagar StartUp";
            this.BtnClearStartUp.UseVisualStyleBackColor = false;
            this.BtnClearStartUp.Click += new System.EventHandler(this.BtnClearStartUp_Click);
            // 
            // btnClearPrefetch
            // 
            this.btnClearPrefetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearPrefetch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearPrefetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPrefetch.ForeColor = System.Drawing.Color.Black;
            this.btnClearPrefetch.Location = new System.Drawing.Point(6, 48);
            this.btnClearPrefetch.Name = "btnClearPrefetch";
            this.btnClearPrefetch.Size = new System.Drawing.Size(168, 23);
            this.btnClearPrefetch.TabIndex = 14;
            this.btnClearPrefetch.Text = "Apagar Prefetch";
            this.btnClearPrefetch.UseVisualStyleBackColor = false;
            this.btnClearPrefetch.Click += new System.EventHandler(this.btnClearPrefetch_Click);
            // 
            // btnClearTEmp
            // 
            this.btnClearTEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearTEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearTEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTEmp.ForeColor = System.Drawing.Color.Black;
            this.btnClearTEmp.Location = new System.Drawing.Point(6, 19);
            this.btnClearTEmp.Name = "btnClearTEmp";
            this.btnClearTEmp.Size = new System.Drawing.Size(168, 23);
            this.btnClearTEmp.TabIndex = 13;
            this.btnClearTEmp.Text = "Apagar TEMPs";
            this.btnClearTEmp.UseVisualStyleBackColor = false;
            this.btnClearTEmp.Click += new System.EventHandler(this.btnClearTEmp_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnRegeditCURRENT);
            this.GroupBox1.Controls.Add(this.btnRegeditLOCALMACHINE);
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(181, 17);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(248, 108);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Métodos Avançados:";
            // 
            // btnRegeditLOCALMACHINE
            // 
            this.btnRegeditLOCALMACHINE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegeditLOCALMACHINE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegeditLOCALMACHINE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegeditLOCALMACHINE.ForeColor = System.Drawing.Color.Black;
            this.btnRegeditLOCALMACHINE.Location = new System.Drawing.Point(5, 21);
            this.btnRegeditLOCALMACHINE.Name = "btnRegeditLOCALMACHINE";
            this.btnRegeditLOCALMACHINE.Size = new System.Drawing.Size(236, 35);
            this.btnRegeditLOCALMACHINE.TabIndex = 17;
            this.btnRegeditLOCALMACHINE.Text = "Regedit - HKEY_LOCAL_MACHINE";
            this.btnRegeditLOCALMACHINE.UseVisualStyleBackColor = false;
            this.btnRegeditLOCALMACHINE.Click += new System.EventHandler(this.btnRegeditLOCALMACHINE_Click);
            // 
            // grpboxferramentas
            // 
            this.grpboxferramentas.BackColor = System.Drawing.Color.Transparent;
            this.grpboxferramentas.Controls.Add(this.BtnAbrirStartUp);
            this.grpboxferramentas.Controls.Add(this.BtnAbrirPrefetch);
            this.grpboxferramentas.Controls.Add(this.BtnAbrirTemp);
            this.grpboxferramentas.Controls.Add(this.BtnSoluçãoProblemas);
            this.grpboxferramentas.Controls.Add(this.BtnStartMsconfig);
            this.grpboxferramentas.Controls.Add(this.BtnClearStartUp);
            this.grpboxferramentas.Controls.Add(this.btnClearPrefetch);
            this.grpboxferramentas.Controls.Add(this.btnClearTEmp);
            this.grpboxferramentas.Controls.Add(this.GroupBox1);
            this.grpboxferramentas.ForeColor = System.Drawing.Color.Black;
            this.grpboxferramentas.Location = new System.Drawing.Point(389, 371);
            this.grpboxferramentas.Name = "grpboxferramentas";
            this.grpboxferramentas.Size = new System.Drawing.Size(437, 197);
            this.grpboxferramentas.TabIndex = 5;
            this.grpboxferramentas.TabStop = false;
            this.grpboxferramentas.Text = "Ferramentas/Limpeza de Malware > Trojan";
            // 
            // btnStartUp
            // 
            this.btnStartUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartUp.ForeColor = System.Drawing.Color.Black;
            this.btnStartUp.Location = new System.Drawing.Point(300, 328);
            this.btnStartUp.Name = "btnStartUp";
            this.btnStartUp.Size = new System.Drawing.Size(129, 28);
            this.btnStartUp.TabIndex = 17;
            this.btnStartUp.Text = "STARTUP";
            this.btnStartUp.UseVisualStyleBackColor = false;
            this.btnStartUp.Click += new System.EventHandler(this.btnStartUp_Click);
            // 
            // btnTEMP
            // 
            this.btnTEMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTEMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTEMP.ForeColor = System.Drawing.Color.Black;
            this.btnTEMP.Location = new System.Drawing.Point(145, 328);
            this.btnTEMP.Name = "btnTEMP";
            this.btnTEMP.Size = new System.Drawing.Size(149, 28);
            this.btnTEMP.TabIndex = 16;
            this.btnTEMP.Text = "TEMP";
            this.btnTEMP.UseVisualStyleBackColor = false;
            this.btnTEMP.Click += new System.EventHandler(this.btnTEMP_Click);
            // 
            // listStartUp
            // 
            this.listStartUp.BackColor = System.Drawing.Color.Silver;
            this.listStartUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listStartUp.ForeColor = System.Drawing.Color.Blue;
            this.listStartUp.FormattingEnabled = true;
            this.listStartUp.HorizontalScrollbar = true;
            this.listStartUp.Location = new System.Drawing.Point(8, 227);
            this.listStartUp.Name = "listStartUp";
            this.listStartUp.ScrollAlwaysVisible = true;
            this.listStartUp.Size = new System.Drawing.Size(422, 95);
            this.listStartUp.TabIndex = 15;
            // 
            // GrpChecarArquivos
            // 
            this.GrpChecarArquivos.BackColor = System.Drawing.Color.Transparent;
            this.GrpChecarArquivos.Controls.Add(this.btnProcurar);
            this.GrpChecarArquivos.Controls.Add(this.PictureIcone);
            this.GrpChecarArquivos.Controls.Add(this.grpResultadoVerificação);
            this.GrpChecarArquivos.Controls.Add(this.groupBox2);
            this.GrpChecarArquivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrpChecarArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpChecarArquivos.ForeColor = System.Drawing.Color.Black;
            this.GrpChecarArquivos.Location = new System.Drawing.Point(3, 3);
            this.GrpChecarArquivos.Name = "GrpChecarArquivos";
            this.GrpChecarArquivos.Size = new System.Drawing.Size(380, 565);
            this.GrpChecarArquivos.TabIndex = 3;
            this.GrpChecarArquivos.TabStop = false;
            this.GrpChecarArquivos.Text = "Checar Arquivos";
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Location = new System.Drawing.Point(44, 19);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(330, 33);
            this.btnProcurar.TabIndex = 9;
            this.btnProcurar.Text = "Procurar Arquivo";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // PictureIcone
            // 
            this.PictureIcone.BackColor = System.Drawing.Color.Black;
            this.PictureIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureIcone.Location = new System.Drawing.Point(6, 19);
            this.PictureIcone.Name = "PictureIcone";
            this.PictureIcone.Size = new System.Drawing.Size(32, 33);
            this.PictureIcone.TabIndex = 8;
            this.PictureIcone.TabStop = false;
            // 
            // grpResultadoVerificação
            // 
            this.grpResultadoVerificação.Controls.Add(this.Label1);
            this.grpResultadoVerificação.Controls.Add(this.listBoxVerificação);
            this.grpResultadoVerificação.ForeColor = System.Drawing.Color.Black;
            this.grpResultadoVerificação.Location = new System.Drawing.Point(6, 94);
            this.grpResultadoVerificação.Name = "grpResultadoVerificação";
            this.grpResultadoVerificação.Size = new System.Drawing.Size(368, 465);
            this.grpResultadoVerificação.TabIndex = 5;
            this.grpResultadoVerificação.TabStop = false;
            this.grpResultadoVerificação.Text = "Resultado Verificação:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.ForeColor = System.Drawing.Color.Blue;
            this.Label1.Location = new System.Drawing.Point(157, 134);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 13);
            this.Label1.TabIndex = 10;
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxVerificação
            // 
            this.listBoxVerificação.BackColor = System.Drawing.Color.Silver;
            this.listBoxVerificação.ForeColor = System.Drawing.Color.Blue;
            this.listBoxVerificação.FormattingEnabled = true;
            this.listBoxVerificação.Location = new System.Drawing.Point(6, 15);
            this.listBoxVerificação.Name = "listBoxVerificação";
            this.listBoxVerificação.Size = new System.Drawing.Size(356, 446);
            this.listBoxVerificação.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNomeUSer);
            this.groupBox2.Controls.Add(this.lblmaquina);
            this.groupBox2.Controls.Add(this.lblNomeUsurio);
            this.groupBox2.Controls.Add(this.lblNomeMaquina);
            this.groupBox2.Location = new System.Drawing.Point(6, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 32);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // lblNomeUSer
            // 
            this.lblNomeUSer.AutoSize = true;
            this.lblNomeUSer.Location = new System.Drawing.Point(100, 12);
            this.lblNomeUSer.Name = "lblNomeUSer";
            this.lblNomeUSer.Size = new System.Drawing.Size(0, 13);
            this.lblNomeUSer.TabIndex = 12;
            // 
            // lblmaquina
            // 
            this.lblmaquina.AutoSize = true;
            this.lblmaquina.Location = new System.Drawing.Point(290, 12);
            this.lblmaquina.Name = "lblmaquina";
            this.lblmaquina.Size = new System.Drawing.Size(0, 13);
            this.lblmaquina.TabIndex = 14;
            this.lblmaquina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeUsurio
            // 
            this.lblNomeUsurio.AutoSize = true;
            this.lblNomeUsurio.ForeColor = System.Drawing.Color.Black;
            this.lblNomeUsurio.Location = new System.Drawing.Point(4, 12);
            this.lblNomeUsurio.Name = "lblNomeUsurio";
            this.lblNomeUsurio.Size = new System.Drawing.Size(90, 13);
            this.lblNomeUsurio.TabIndex = 10;
            this.lblNomeUsurio.Text = "Nome Usuário:";
            // 
            // lblNomeMaquina
            // 
            this.lblNomeMaquina.AutoSize = true;
            this.lblNomeMaquina.ForeColor = System.Drawing.Color.Black;
            this.lblNomeMaquina.Location = new System.Drawing.Point(189, 12);
            this.lblNomeMaquina.Name = "lblNomeMaquina";
            this.lblNomeMaquina.Size = new System.Drawing.Size(95, 13);
            this.lblNomeMaquina.TabIndex = 13;
            this.lblNomeMaquina.Text = "Nome Máquina:";
            // 
            // grpBoxComportamento
            // 
            this.grpBoxComportamento.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxComportamento.Controls.Add(this.btnStartUp);
            this.grpBoxComportamento.Controls.Add(this.btnTEMP);
            this.grpBoxComportamento.Controls.Add(this.listStartUp);
            this.grpBoxComportamento.Controls.Add(this.listTEMP);
            this.grpBoxComportamento.Controls.Add(this.btnPrefetch);
            this.grpBoxComportamento.Controls.Add(this.listPrefetch);
            this.grpBoxComportamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxComportamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxComportamento.ForeColor = System.Drawing.Color.Black;
            this.grpBoxComportamento.Location = new System.Drawing.Point(389, 3);
            this.grpBoxComportamento.Name = "grpBoxComportamento";
            this.grpBoxComportamento.Size = new System.Drawing.Size(437, 362);
            this.grpBoxComportamento.TabIndex = 4;
            this.grpBoxComportamento.TabStop = false;
            this.grpBoxComportamento.Text = "Verificar Comportamentos em Pastas Temporárias:";
            // 
            // listTEMP
            // 
            this.listTEMP.BackColor = System.Drawing.Color.Silver;
            this.listTEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTEMP.ForeColor = System.Drawing.Color.Blue;
            this.listTEMP.FormattingEnabled = true;
            this.listTEMP.HorizontalScrollbar = true;
            this.listTEMP.Location = new System.Drawing.Point(6, 120);
            this.listTEMP.Name = "listTEMP";
            this.listTEMP.ScrollAlwaysVisible = true;
            this.listTEMP.Size = new System.Drawing.Size(423, 95);
            this.listTEMP.TabIndex = 14;
            // 
            // btnPrefetch
            // 
            this.btnPrefetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrefetch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrefetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrefetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrefetch.ForeColor = System.Drawing.Color.Black;
            this.btnPrefetch.Location = new System.Drawing.Point(5, 328);
            this.btnPrefetch.Name = "btnPrefetch";
            this.btnPrefetch.Size = new System.Drawing.Size(134, 28);
            this.btnPrefetch.TabIndex = 13;
            this.btnPrefetch.Text = "PREFETCH";
            this.btnPrefetch.UseVisualStyleBackColor = false;
            this.btnPrefetch.Click += new System.EventHandler(this.btnPrefetch_Click);
            // 
            // listPrefetch
            // 
            this.listPrefetch.BackColor = System.Drawing.Color.Silver;
            this.listPrefetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPrefetch.ForeColor = System.Drawing.Color.Blue;
            this.listPrefetch.FormattingEnabled = true;
            this.listPrefetch.HorizontalScrollbar = true;
            this.listPrefetch.Location = new System.Drawing.Point(6, 19);
            this.listPrefetch.Name = "listPrefetch";
            this.listPrefetch.ScrollAlwaysVisible = true;
            this.listPrefetch.Size = new System.Drawing.Size(423, 95);
            this.listPrefetch.TabIndex = 1;
            // 
            // frmTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(834, 576);
            this.Controls.Add(this.grpboxferramentas);
            this.Controls.Add(this.GrpChecarArquivos);
            this.Controls.Add(this.grpBoxComportamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.grpboxferramentas.ResumeLayout(false);
            this.GrpChecarArquivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcone)).EndInit();
            this.grpResultadoVerificação.ResumeLayout(false);
            this.grpResultadoVerificação.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBoxComportamento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Button btnRegeditCURRENT;
        internal System.Windows.Forms.Button BtnAbrirStartUp;
        internal System.Windows.Forms.Button BtnAbrirPrefetch;
        internal System.Windows.Forms.Button BtnAbrirTemp;
        internal System.Windows.Forms.Button BtnSoluçãoProblemas;
        internal System.Windows.Forms.Button BtnStartMsconfig;
        internal System.Windows.Forms.Button BtnClearStartUp;
        internal System.Windows.Forms.Button btnClearPrefetch;
        internal System.Windows.Forms.Button btnClearTEmp;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnRegeditLOCALMACHINE;
        internal System.Windows.Forms.GroupBox grpboxferramentas;
        internal System.Windows.Forms.Button btnStartUp;
        internal System.Windows.Forms.Button btnTEMP;
        internal System.Windows.Forms.ListBox listStartUp;
        internal System.Windows.Forms.GroupBox GrpChecarArquivos;
        internal System.Windows.Forms.Label lblmaquina;
        internal System.Windows.Forms.Label lblNomeMaquina;
        internal System.Windows.Forms.Label lblNomeUSer;
        internal System.Windows.Forms.Label lblNomeUsurio;
        internal System.Windows.Forms.Button btnProcurar;
        internal System.Windows.Forms.PictureBox PictureIcone;
        internal System.Windows.Forms.GroupBox grpResultadoVerificação;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox listBoxVerificação;
        internal System.Windows.Forms.GroupBox grpBoxComportamento;
        internal System.Windows.Forms.ListBox listTEMP;
        internal System.Windows.Forms.Button btnPrefetch;
        internal System.Windows.Forms.ListBox listPrefetch;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

