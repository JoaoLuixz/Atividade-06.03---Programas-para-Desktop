namespace Atividade_06._03
{
    public partial class Salario : Form
    {
        public Salario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Funcionario salario = new Funcionario();
            salario.Cpf = txtCPF.Text;
            salario.Nome = txtNome.Text;
            salario.ValorHora = float.Parse(txtValorHora.Text);
            salario.HorasTrabalhadas = float.Parse(txtHorasTrabalhadas.Text);

            salario.CalcSalario();

            txtSalario.Text = salario.ValorSalario.ToString();
        }
    }
}