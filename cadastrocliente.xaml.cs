using System.Windows;

namespace RegistrationForm
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearFields(object sender, RoutedEventArgs e)
        {
            NomeCompleto.Clear();
            Email.Clear();
            Senha.Clear();
            DataNascimento.Clear();
            CPF.Clear();
            Genero.Clear();
            Telefone.Clear();
            Sms.Clear();
            Endereco.Clear();
            NumeroMEI.Clear();
        }
    }
}
