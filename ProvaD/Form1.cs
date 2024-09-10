using System;
using System.Windows.Forms;

namespace ProvaD
{
    public partial class Form1 : Form
    {
        double ID = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double total = 0;
            double quantidade = 0;
            double valor = 0;

            // Adicionando a nova linha ao DataGridView
            dgvLista.Rows.Add(txtProduto.Text, txtQtd.Text, txtUnitario.Text);

            // Acessando a última linha adicionada (a nova linha) 
            DataGridViewRow lastRow = dgvLista.Rows[dgvLista.Rows.Count - 1];

            // Tentando converter o valor da célula para double
            if (double.TryParse(lastRow.Cells[2].Value?.ToString(), out valor))
            {
                // Atualizando o valor da célula se necessário
                lastRow.Cells[2].Value = valor;

                // Convertendo a quantidade do texto para double
                double.TryParse(txtQtd.Text, out quantidade);

                // Calculando o valor total
                total = quantidade * valor;
                lblTotalVenda.Text = total.ToString("F2"); // Exibindo o total formatado como número decimal
            }
            else
            {
                // Se a conversão falhar, você pode tratar o erro ou mostrar uma mensagem
                MessageBox.Show("O valor inserido não é um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Limpando os campos após o click
            txtProduto.Clear();
            txtQtd.Clear();
            txtUnitario.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow != null)
            {
                dgvLista.Rows.RemoveAt(dgvLista.CurrentCell.RowIndex);
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarQtd_Click(object sender, EventArgs e)
        {
            if (txtAlterarQtd.Text != "")
            {
                // Atualizando o valor da célula de quantidade
                if (dgvLista.CurrentRow != null)
                {
                    dgvLista.CurrentRow.Cells[1].Value = txtAlterarQtd.Text;
                    MessageBox.Show("Quantidade atualizada com sucesso!", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //arrumar para fazer com que após o valor no grid ser atualizado atualize o valor da compra total tbm
                    lblTotalVenda
                }
                else
                {
                    MessageBox.Show("Nenhuma linha selecionada para atualizar a quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica para manipular eventos de clique em células, se necessário
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
