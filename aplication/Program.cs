using System;

namespace aplication
{
    class Program
    {
        static SerieRepository repository = new SerieRepository();
        static void Main(string[] args)
        {
            string resp = GetUserOption();

			while (resp.ToUpper() != "X")
			{
				switch (resp)
				{
					case "1":
						ListSeries();
						break;
					case "2":
						InsertSerie();
						break;
					case "3":
						UpdateSerie();
						break;
					case "4":
						ExcludeSerie();
						break;
					case "5":
						ShowSerie();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				resp = GetUserOption();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static void ExcludeSerie()
		{
			Console.Write("Digite o id da série: ");
			int id = int.Parse(Console.ReadLine());

			repository.Remove(id);
		}

        private static void ShowSerie()
		{
			Console.Write("Digite o id da série: ");
			int id = int.Parse(Console.ReadLine());

			var serie = repository.ReturnById(id);

			Console.WriteLine(serie);
		}

        private static void UpdateSerie()
		{
			Console.Write("Digite o id da série: ");
			int id = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Gender)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			Gender gender = Enum.Parse<Gender>(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string title = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int year = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string description = Console.ReadLine();

			Serie updateSerie = new Serie(gender, title, description, year, id);

			repository.Update(id, updateSerie);
		}
        private static void ListSeries()
		{
			Console.WriteLine("Listar séries");

			var list = repository.List();

			if (list.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in list)
			{
                var excluded = serie.ExcludeReturn();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.IdReturn(), serie.TitleReturn(), (excluded? "*Excluído*" : ""));
			}
		}

        private static void InsertSerie()
		{
			Console.WriteLine("Inserir nova série");

			foreach (int i in Enum.GetValues(typeof(Gender)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			Gender gender = Enum.Parse<Gender>(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string title = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int year = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string description = Console.ReadLine();

			Serie newSerie = new Serie(gender, title, description, year, id: repository.Next());

			repository.Insert(newSerie); 
		}

        private static string GetUserOption()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Séries a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string resp = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return resp;
		}
    }
}

