using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bate_Papo_Online
{
    public static class Utils
    {
        public static bool ValidaTextoConfig(TextBox txtUsuario, TextBox txtPortaUsuario)
            => (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtPortaUsuario.Text));

        public static void Mensagem(string mensagem, int opcao) 
        {
            switch (opcao)
            {
                case 1:
                    MessageBox.Show(mensagem, "..::Erro::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show(mensagem, "..::Aviso::..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 3:
                    MessageBox.Show(mensagem, "..::Bate Papo::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }
    }
}
