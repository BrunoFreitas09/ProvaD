using System;
using System.Windows.Forms;

namespace ProvaD
{
    public partial class Form1 : Form
    {
        double total = 0;
        double id =  1;
        

        public Form1()
        {
            InitializeComponent();
            lblID.Text = id.ToString();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Adicionando a nova linha ao DataGridView
            dgvLista.Rows.Add(txtProduto.Text, txtQtd.Text, txtUnitario.Text);

            // Acessando a última linha adicionada (a nova linha) 
            DataGridViewRow lastRow = dgvLista.Rows[dgvLista.Rows.Count - 1];

            // Tentando converter o valor da célula para double
            if (double.TryParse(lastRow.Cells[2].Value?.ToString(), out double val))
            {
                // Convertendo a quantidade do texto para double
                if (double.TryParse(txtQtd.Text, out double quantidade))
                {
                    // Calculando o valor total
                    total += quantidade * val;
                    lblTotalVenda.Text = total.ToString("F2"); // Exibindo o total formatado como número decimal
                }
                else
                {
                    MessageBox.Show("A quantidade inserida não é um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O valor unitário inserido não é um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Obtendo o valor da célula "Unitário" da linha atual
                if (double.TryParse(dgvLista.CurrentRow.Cells[2].Value?.ToString(), out double valorUnitario) &&
                    double.TryParse(dgvLista.CurrentRow.Cells[1].Value?.ToString(), out double quantidade))
                {
                    // Remover a linha selecionada
                    dgvLista.Rows.RemoveAt(dgvLista.CurrentCell.RowIndex);

                    // Atualizar o total
                    total -= valorUnitario * quantidade;
                    lblTotalVenda.Text = total.ToString("F2"); // Exibindo o total formatado como número decimal
                }
                else
                {
                    MessageBox.Show("Não foi possível obter os valores para a remoção.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarQtd_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow != null)
            {
                if (double.TryParse(txtAlterarQtd.Text, out double novaQuantidade) &&
                    double.TryParse(dgvLista.CurrentRow.Cells[2].Value?.ToString(), out double valorUnitario))


                {
                    //pegando a quantidade antiga do DataGridView
                    double.TryParse(dgvLista.CurrentRow.Cells[1].Value?.ToString(), out double QtdAntiga);

                    // Atualizando a quantidade na célula
                    dgvLista.CurrentRow.Cells[1].Value = novaQuantidade;

                    // Recalcular o total
                    // Primeiro, removemos o valor antigo
                    //if (double.TryParse(dgvLista.CurrentRow.Cells[1].Value?.ToString(), out double quantidadeAntiga))
                    //{
                     //   total -= quantidadeAntiga * valorUnitario;
                    //}

                    // Atualizamos o total com o novo valor
                    total += (novaQuantidade  - QtdAntiga)  * valorUnitario ;
                    lblTotalVenda.Text = total.ToString("F2"); // Exibindo o total formatado como número decimal

                    MessageBox.Show("Quantidade atualizada com sucesso!", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("A quantidade inserida não é um número válido ou há um problema com o valor unitário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada para atualizar a quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            id++;
            lblID.Text = id.ToString();
            total = 0 ;
            lblTotalVenda.Text = total.ToString("F2"); 
            // Limpando os campos após o click
            txtProduto.Clear();
            txtQtd.Clear();
            txtUnitario.Clear();
            txtAlterarQtd.Clear();
            //limpando o DataGridView
            dgvLista.Rows.Clear();
            dgvLista.DataSource = null; //Remover a datasource
            dgvLista.Rows.Clear();    //Remover as linhas
            dgvLista.Refresh();    //Para a grid se actualizar
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpando os campos após o click
            txtProduto.Clear();
            txtQtd.Clear();
            txtUnitario.Clear();
            txtAlterarQtd.Clear();
            //limpando o DataGridView
            dgvLista.Rows.Clear();
            dgvLista.DataSource = null; //Remover a datasource
            dgvLista.Rows.Clear();    //Remover as linhas
            dgvLista.Refresh();    //Para a grid se actualizar
        }
    }
}
