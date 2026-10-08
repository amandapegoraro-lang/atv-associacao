public class Veiculo
{
    private string _modelo;
    private string _placa;

    public string Modelo
    {
        get
        {
            return _modelo;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O modelo é obrigatório."
                );
            }

            _modelo = value;
        }
    }

    public string Placa
    {
        get
        {
            return _placa;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "A placa é obrigatória."
                );
            }

            _placa = value;
        }
    }

    public Veiculo(string modelo, string placa)
    {
        Modelo = modelo;
        Placa = placa;
    }
}
