public class Cliente
{
    private string _nome;
    private string _cpf;

    public string Nome
    {
        get
        {
            return _nome;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O nome é obrigatório."
                );
            }

            _nome = value;
        }
    }

    public string CPF
    {
        get
        {
            return _cpf;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O CPF é obrigatório."
                );
            }

            _cpf = value;
        }
    }

    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
    }
}
