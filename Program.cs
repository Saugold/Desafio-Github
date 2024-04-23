using Godot_Dio;

Heroi heroi1 = new Heroi("Julio", 20000);
Console.WriteLine($"O Herói de nome {heroi1.GetNome()}está no nível de **{heroi1.CalcularNivel(heroi1.GetXp())}**");
