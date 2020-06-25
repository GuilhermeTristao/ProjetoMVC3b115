using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using projeto_mvc_b09.BLL;
using projeto_mvc_b09.DTO;

namespace projeto_mvc_b09.UI
{
    public partial class frmCliente : System.Web.UI.Page
    {
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Pessoa obj = new Pessoa();

            obj.Nome = txtNomeB09.Text;
            obj.Cpf = txtCpfB09.Text;
            obj.NomeMae = txtNomeMaeB09.Text;

            tblClienteBLL bllCliente = new tblClienteBLL();
            if (bllCliente.Autenticar(obj.Nome, obj.Cpf, obj.NomeMae))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Beneficiário Localizado no Banco de dados. Processo em Análise";
            }
            else
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
            }
        }
    }
}
