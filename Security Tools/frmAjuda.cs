using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Tools {
    public partial class frmAjuda :Form {
        public frmAjuda() {
            InitializeComponent();
        }

        private void btnVerificarDados_Click(object sender,EventArgs e) {
            txtSolução.Text = "Problemas ao verificar um arquivo pode ser bem comum. Exemplos:" + Environment.NewLine + " O Arquivo pode estar criptografado, nesse caso, opte pelo 'virustotal.com'." + Environment.NewLine + " Pode está acontecendo um conflito entre Arquivo e sua máquina, impossibilitando a análise. " + Environment.NewLine + " O Arquivo não é de extensão .exe. " + Environment.NewLine + " O arquivo está sendo executado no momento. " + Environment.NewLine + " O Checking File não está sendo executado como administrador";
        }
        frmTools frm = new frmTools();
        private void btnMonitorarPastasTemp_Click(object sender,EventArgs e) {
            txtSolução.Text = @"Ao ocorrer erro durante o monitoramento das pastas, opte em: " + Environment.NewLine + " Verificar se o Checking File esta sendo executado como administrador. " + Environment.NewLine + " Essa função funcionará somente se as pastas não estiverem protegidas pelo Windows. " + Environment.NewLine + " Você também pode acessa-las manualmente para monitorar usando os seguintes diretórios:" + Environment.NewLine + @"  Pasta TEMP > C:\Windows\Temp " + Environment.NewLine + @" Pasta StartUp > C:\Users\" + frm.lblNomeUSer.Text + " / AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Startup" + Environment.NewLine + " Pasta Prefetch > C:/Windows/Prefetch";
        }

        private void BtnApagarPastasTemp_Click(object sender,EventArgs e) {
            txtSolução.Text = @"Ao tentar apagar as pastas temporárias, optem em verificar se o Widnows está protegendo-as. " + Environment.NewLine + " Se o erro persistir, fça manualmente a sua limpeza usando os diretórios: " + Environment.NewLine + @" Pasta TEMP > C:\Windows\Temp, " + Environment.NewLine + @" Pasta StartUp > C:\Users\" + frm.lblNomeUSer.Text + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup, " + Environment.NewLine + @" Pasta Prefetch > C:\Windows\Prefetch";
        }

        private void btnMetodosAvançados_Click(object sender,EventArgs e) {
            txtSolução.Text = @"Métodos avançados requer permissões de administrador para serem executados em sua máquina, por favor, verifique se o Checking File está sendo executado como Administrador. " + Environment.NewLine + " Caso o erro persistir, faça a limpeza manualmente, Aperte a tecla Windows + R e escreva 'Regedit' no campo de pesquisa, dê um enter e siga os diretórios abaixo. " + Environment.NewLine + @" Regedit - HKEY_LOCAL_MACHINE > Software\Microsoft\Windows\CurrentVersion\Run, " + Environment.NewLine + @" Regedit - HKEY_CURRENT_USER > Software\Microsoft\Windows\CurrentVersion\Run, " + Environment.NewLine + @" Método CMD / Monitorar tráfego de dados > Windows + R > Escrev 'CMD' > Coloque o comando 'netstat -t' e dê um enter.";
        }
    }
}
