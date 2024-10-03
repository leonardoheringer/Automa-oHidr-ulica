using System;
		double b1, b2, b3;
		Console.WriteLine("Boia 1 está ligada?(0 desligada, 1 ligada)");
		if(!Double.TryParse(Console.ReadLine(), out b1)){
			Console.WriteLine("Valor Inválido");
			return;
	}
			Console.WriteLine("Boia 2 está ligada?(0 desligada, 1 ligada)");
		if(!Double.TryParse(Console.ReadLine(), out b2)){
			Console.WriteLine("Valor Inválido");
			return;
	}
			Console.WriteLine("Boia 3 está ligada?(0 desligada, 1 ligada)");
		if(!Double.TryParse(Console.ReadLine(), out b3)){
			Console.WriteLine("Valor Inválido");
			return;
	}
	if (b1 == 0 && b2 == 0 && b3 == 0){

		Console.WriteLine("Ligar Regitro!");
	}
	if (b1 == 0 && b2 == 0 && b3 == 1){

		Console.WriteLine("Ligar Regitro!");
	}
    if (b1 == 0 && b2 == 1 && b3 == 0){

		Console.WriteLine("Erro Sensor!");
        Console.WriteLine("\nSolicitar Técnico!");
	}
  
    if (b1 == 0 && b2 == 1 && b3 == 1){

		Console.WriteLine("Erro Sensor!");
        Console.WriteLine("\nSolicitar Técnico!");
	}
    if (b1 == 1 && b2 == 0 && b3 == 0){

		Console.WriteLine("Ligar Regitro!");
        Console.WriteLine("\nLigar Bomba!");
	}
    if (b1 == 1 && b2 == 0 && b3 == 1){

		Console.WriteLine("Ligar Regitro!");
	}
    if (b1 == 1 && b2 == 1 && b3 == 0){

		Console.WriteLine("Ligar Bomba!");
	}
      if (b1 == 1 && b2 == 1 && b3 == 1){

		Console.WriteLine("Manter bomba desligada!");
        Console.WriteLine("\nManter registro copasa desligado!");
	}