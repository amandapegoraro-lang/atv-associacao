Cliente cliente1 = new Cliente(
    "Maria Silva",
    "111.111.111-11"
);

Cliente cliente2 = new Cliente(
    "João Souza",
    "222.222.222-22"
);

Veiculo veiculo1 = new Veiculo(
    "Onix",
    "ABC-1234"
);

Veiculo veiculo2 = new Veiculo(
    "Corolla",
    "DEF-5678"
);

Locacao locacao1 = new Locacao(
    cliente1,
    veiculo1,
    new DateOnly(2026, 10, 8),
    15,
    150m
);

Locacao locacao2 = new Locacao(
    cliente2,
    veiculo2,
    new DateOnly(2026, 10, 8),
    7,
    150m
);

locacao1.ExibirResumo();
Console.WriteLine();
locacao2.ExibirResumo();

