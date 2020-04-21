using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

/* Create for Diego "Distek"
Facebook: /MWStek
Git: /dieguinsharp */

namespace Security_Tools {
    public partial class frmTools :Form {
        public frmTools() {
            InitializeComponent();
            
        }
        seguranca acoes = new seguranca();
        private void Form1_Load(object sender,EventArgs e) {
            if(!File.Exists("verificacao.txt")) {
                if(MessageBox.Show("Projeto criado por Diego 'Distek', deseja conhece-lo?","Distek",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK) {
                    Process.Start("https://www.facebook.com/MWStek");
                }
                StreamWriter verificar = new StreamWriter("verificacao.txt");
                verificar.Write("true");
                verificar.Close();                
            }            
            lblNomeUSer.ForeColor = Color.Blue;
            lblNomeUSer.Text = Environment.UserName;
            lblmaquina.ForeColor = Color.Blue;
            lblmaquina.Text = Environment.MachineName;            
        }

        private void btnProcurar_Click(object sender,EventArgs e) {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "OfficeFiles|*.exe;*.txt;*.jpg";
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            open.Title = "Selecione o arquivo para inserir";
            if(open.ShowDialog() == DialogResult.OK) {
                if(open.FileName != null) {
                    if(File.Exists(open.FileName)) {
                        PictureIcone.Image = System.Drawing.Icon.ExtractAssociatedIcon(open.FileName).ToBitmap();
                        listBoxVerificação.Items.Clear();
                        string caminho = open.FileName;
                        List<string> list = new List<string>();

                        list = seguranca.lstbox(caminho);

                        list.ForEach(delegate (string infos) {
                            listBoxVerificação.Items.Add(infos);
                        });
                    } else {
                        MessageBox.Show("Arquivo não existe!","Security",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                } else {
                    MessageBox.Show("Diretório foi removido ou é inválido.","Security",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private FileSystemWatcher watcherTEMP2 = new FileSystemWatcher(); // MonitorarTEMP
        private FileSystemWatcher watcherTEMP = new FileSystemWatcher(); // MonitorarTEMP
        private FileSystemWatcher watcherSTARTUP = new FileSystemWatcher(); // MonitorarSTARTUP
        private FileSystemWatcher watcherPREFETCH = new FileSystemWatcher(); // MonitorarPREFETCH
        public void ComportamentoTEMP2() {
            CheckForIllegalCrossThreadCalls = false;
            watcherTEMP2.Created += AlteradoTEMP2;
            watcherTEMP2.Changed += AlteradoTEMP2;
            watcherTEMP2.Deleted += AlteradoTEMP2;
            watcherTEMP2.Renamed += RenomeadoTEMP2;
            watcherTEMP2.Path = @"C:/Users/" + lblNomeUSer.Text + "/AppData/Local/Temp";
            watcherTEMP2.Filter = "*.*";
            watcherTEMP2.IncludeSubdirectories = true;
            watcherTEMP2.EnableRaisingEvents = true;
            MessageBox.Show("Monitoramento Iniciado na pasta TEMP2","Security",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void ComportamentoTEMP() {
            CheckForIllegalCrossThreadCalls = false;
            watcherTEMP.Created += AlteradoTEMP;
            watcherTEMP.Changed += AlteradoTEMP;
            watcherTEMP.Deleted += AlteradoTEMP;
            watcherTEMP.Renamed += RenomeadoTEMP;
            watcherTEMP.Path = (@"C:\Windows\Temp");
            watcherTEMP.Filter = "*.*";
            watcherTEMP.IncludeSubdirectories = true;
            watcherTEMP.EnableRaisingEvents = true;
            MessageBox.Show("Monitoramento Iniciado na pasta Temp","Security",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void ComportamentoStartUP() {
            CheckForIllegalCrossThreadCalls = false;
            watcherSTARTUP.Created += AlteradoSTARTUP;
            watcherSTARTUP.Changed += AlteradoSTARTUP;
            watcherSTARTUP.Deleted += AlteradoSTARTUP;
            watcherSTARTUP.Renamed += RenomeadoSTARTUP;
            watcherSTARTUP.Path = (@"C:\Users\" + lblNomeUSer.Text + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup");
            watcherSTARTUP.Filter = "*.*";
            watcherSTARTUP.IncludeSubdirectories = true;
            watcherSTARTUP.EnableRaisingEvents = true;
            MessageBox.Show("Monitoramento Iniciado na pasta StartUp","Security",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void ComportamentoPrefetch() {
            CheckForIllegalCrossThreadCalls = false;
            watcherPREFETCH.Created += AlteradoPREFETCH;
            watcherPREFETCH.Changed += AlteradoPREFETCH;
            watcherPREFETCH.Deleted += AlteradoPREFETCH;
            watcherPREFETCH.Renamed += RenomeadoPREFETCH;
            watcherPREFETCH.Path = (@"C:\Windows\Prefetch");
            watcherPREFETCH.Filter = "*.*";
            watcherPREFETCH.IncludeSubdirectories = true;
            watcherPREFETCH.EnableRaisingEvents = true;
            MessageBox.Show("Monitoramento Iniciado na pasta Prefetch","Security",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void RenomeadoTEMP2(object source,RenamedEventArgs e) {
            listTEMP.Items.Add(string.Format("Arquivo: {0} renomeado para: {1}",e.OldFullPath,e.FullPath));
        }
        private void RenomeadoTEMP(object source,RenamedEventArgs e) {
            listTEMP.Items.Add(string.Format("Arquivo: {0} renomeado para: {1}",e.OldFullPath,e.FullPath));
        }
        private void RenomeadoPREFETCH(object source,RenamedEventArgs e) {
            listPrefetch.Items.Add(string.Format("Arquivo: {0} renomeado para: {1}",e.OldFullPath,e.FullPath));
        }
        private void RenomeadoSTARTUP(object source,RenamedEventArgs e) {
            listStartUp.Items.Add(string.Format("Arquivo: {0} renomeado para: {1}",e.OldFullPath,e.FullPath));
        }
        private void AlteradoTEMP2(object source,FileSystemEventArgs e) {
            switch(e.ChangeType) {
                case WatcherChangeTypes.Created: {
                        listTEMP.Items.Add("Arquivo: " + e.FullPath + " Criado!");
                        break;
                    }
                case WatcherChangeTypes.Changed: {
                        listTEMP.Items.Add("Arquivo: " + e.FullPath + " Alterado!");
                        break;
                    }
                case WatcherChangeTypes.Deleted: {
                        listTEMP.Items.Add("Arquivo: " + e.FullPath + " Deletado!");
                        break;
                    }
            }
        }
        private void AlteradoTEMP(object source,FileSystemEventArgs e) {
            switch(e.ChangeType) {
                case WatcherChangeTypes.Created: {
                        listTEMP.Items.Add("Arquivo: " + e.FullPath + " Criado!");
                        break;
                }
                case WatcherChangeTypes.Changed: {
                        listTEMP.Items.Add("Arquivo: " + e.FullPath + " Alterado!");
                        break;
                }
                case WatcherChangeTypes.Deleted: {
                        listTEMP.Items.Add("Arquivo: " + e.FullPath + " Deletado!");
                        break;
                }
            }
        }
        private void AlteradoPREFETCH(object source,FileSystemEventArgs e) {
            switch(e.ChangeType) {
                case WatcherChangeTypes.Created: {
                        listPrefetch.Items.Add("Arquivo: " + e.FullPath + " Criado!");
                        break;
                }
                case WatcherChangeTypes.Changed: {
                        listPrefetch.Items.Add("Arquivo: " + e.FullPath + " Alterado!");
                        break;
                }
                case WatcherChangeTypes.Deleted: {
                        listPrefetch.Items.Add("Arquivo: " + e.FullPath + " Deletado!");
                        break;
                }
            }
        }
        private void AlteradoSTARTUP(object source,FileSystemEventArgs e) {
            switch(e.ChangeType) {
                case WatcherChangeTypes.Created: {
                        listStartUp.Items.Add("Arquivo: " + e.FullPath + " Criado!");
                        break;
                }
                case WatcherChangeTypes.Changed: {
                        listStartUp.Items.Add("Arquivo: " + e.FullPath + " Alterado!");
                        break;
                }
                case WatcherChangeTypes.Deleted: {
                        listStartUp.Items.Add("Arquivo: " + e.FullPath + " Deletado!");
                        break;
                }
            }
        }
        private void btnPrefetch_Click(object sender,EventArgs e) {
            ComportamentoPrefetch();
        }
        private void btnStartUp_Click(object sender,EventArgs e) {
            ComportamentoStartUP();
        }
        private void btnTEMP_Click(object sender,EventArgs e) {
            ComportamentoTEMP();
            ComportamentoTEMP2();
        }
        private void BtnClearStartUp_Click(object sender,EventArgs e) {
            acoes.clearPasta(@"C:/Users/" + lblNomeUSer.Text + "/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Startup");
        }
        private void btnClearPrefetch_Click(object sender,EventArgs e) {
            acoes.clearPasta("C:/Windows/Prefetch");
        }
        private void btnClearTEmp_Click(object sender,EventArgs e) {
            acoes.clearPasta("C:/Windows/Temp");
            acoes.clearPasta(@"C:/Users/"+ lblNomeUSer.Text +"/AppData/Local/Temp");
        }
        private void BtnAbrirStartUp_Click(object sender,EventArgs e) {
            System.Diagnostics.Process.Start("C:/Users/" + lblNomeUSer.Text + "/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Startup");
        }
        private void BtnAbrirPrefetch_Click(object sender,EventArgs e) {
            System.Diagnostics.Process.Start("C:/Windows/Prefetch");
        }
        private void BtnAbrirTemp_Click(object sender,EventArgs e) {
            System.Diagnostics.Process.Start("C:/Windows/Temp");
            System.Diagnostics.Process.Start(@"C:/Users/" + lblNomeUSer.Text + "/AppData/Local/Temp");
        }
        private void btnRegeditLOCALMACHINE_Click(object sender,EventArgs e) {
            RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run",false);
            acoes.clearRegistro(regKey);
        }
        private void btnRegeditCURRENT_Click(object sender,EventArgs e) {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run",false);
            acoes.clearRegistro(regKey);
        }
        private void BtnStartMsconfig_Click(object sender,EventArgs e) {
            try{
                System.Diagnostics.Process.Start("C:/Windows/System32/msconfig.exe");
            } catch(Exception) {
                MessageBox.Show("Algo de errado aconteceu, tente abrir o msconfig manualmente.","Security",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public class seguranca {
            String[] files = new String[9999];
            public static List<string> lstbox(string caminho) {
                FileVersionInfo arquivo = FileVersionInfo.GetVersionInfo(caminho);
                List<string> list = new List<string>();
                list.Add(caminho);
                list.Add("Data da criação : " + File.GetCreationTime(caminho));
                list.Add("Último acesso : " + File.GetLastAccessTime(caminho));
                list.Add("Última alteração : " + File.GetLastWriteTime(caminho));
                list.Add("Nome da Empresa : " + arquivo.CompanyName);
                list.Add("Versão : " + arquivo.FileVersion);
                list.Add("Descrição : " + arquivo.FileDescription);
                list.Add("Nome Interno : " + arquivo.InternalName);
                list.Add("Construção Especial : " + arquivo.SpecialBuild);
                list.Add("Parte privada do Produto : " + arquivo.ProductPrivatePart);
                list.Add("Comentários : " + arquivo.Comments);
                list.Add("Parte da Construção : " + arquivo.FileBuildPart);
                list.Add("Arquivo de Parte Principal : " + arquivo.FileMajorPart);
                list.Add("Arquivo de Parte Menor : " + arquivo.FileMinorPart);
                list.Add("Nome do Arquivo : " + arquivo.FileName);
                list.Add("Parte privada do Arquivo : " + arquivo.FilePrivatePart);
                list.Add("Versão do Arquivo : " + arquivo.FileVersion);
                list.Add("Codigo Hash : " + (arquivo.GetHashCode()).ToString()); ;
                list.Add("Construção: " + arquivo.IsDebug);
                list.Add("Remendo : " + arquivo.IsPatched);
                list.Add("Pré Lançamento : " + arquivo.IsPreRelease);
                list.Add("Construção Privada : " + arquivo.IsPrivateBuild);
                list.Add("Construção Especial : " + arquivo.IsSpecialBuild);
                list.Add("Linguagem : " + arquivo.Language);
                list.Add("CopyHigth : " + arquivo.LegalCopyright);
                list.Add("Marcas Registradas : " + arquivo.LegalTrademarks);
                list.Add("Nome Original : " + arquivo.OriginalFilename);
                list.Add("Construção Privada : " + arquivo.PrivateBuild);
                list.Add("Peça de Contrução do Produto : " + arquivo.ProductBuildPart);
                list.Add("Parte Principal do Produto : " + arquivo.ProductMajorPart);
                list.Add("Versão do Produto : " + arquivo.ProductVersion);
                list.Add("Nome do Produto : " + arquivo.ProductName);

                return list;
            }
            public void clearRegistro(RegistryKey regKey) {
                if(regKey == null) {
                    MessageBox.Show("Aconteceu um erro inesperado ou o Registro já foi apagado, tente novamente!","DisTek",MessageBoxButtons.OK,MessageBoxIcon.Error);
                } else {
                    try {
                        Registry.CurrentUser.DeleteSubKeyTree(@"Software\Microsoft\Windows\CurrentVersion\Run");
                    } catch (Exception e) {
                        MessageBox.Show("Erro inesperado, tente novamente. Mais informações:" + e,"Distek",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    } finally {
                        MessageBox.Show("Foram removidos todos os arquivos possiveis.","Distek",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }                
                }
            }

            public void clearPasta(string caminho) {
                files = Directory.GetFiles(caminho,"*.*");
                bool erro = false, erro2 = false, f3 = false;
                for(int cont = 0; cont < files.Length; cont++) {
                    try {
                        File.Delete(files[cont]);
                    } catch(UnauthorizedAccessException) {
                        if (erro == false) {
                            MessageBox.Show("O arquivo "+ files[cont] +" não pode ser removido por que está aberto em algum processo nesse momento. Iremos continuar.","Distek",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            erro = true;
                        } else if (files[cont] == "*.exe") {
                            MessageBox.Show("O arquivo " + files[cont] + " não pode ser removido por que está aberto em algum processo.");
                        }                     
                    } catch(Exception) {
                        if(erro2 == false) {
                            MessageBox.Show("Erro inesperado ao tentar remover " + files[cont] + ". Iremos continuar.","Distek",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            erro2 = true;
                        }
                    } finally {
                        if (f3 == false) {
                            MessageBox.Show("Removemos tudo que foi possivel :)","Distek",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            f3 = true;
                        }                       
                    }
                }
            }
        }

        private void BtnSoluçãoProblemas_Click(object sender,EventArgs e) {
            frmAjuda frm2 = new frmAjuda();
            frm2.Show();
        }
    }
}
