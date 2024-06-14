namespace Console1
{
	internal class Program{
		static void Main(string[] args){
			Usuario usuario = new Usuario();

			usuario.nome = "CR7";
			usuario.login = "root";
			usuario.senha = "qwe123";

			string login;
			string senha;

			do
			{
				Console.WriteLine("Digite seu login: ");
				login = Console.ReadLine();

				Console.WriteLine("Digite sua Senha: ");
				senha = Console.ReadLine();

				bool logado = usuario.Logar(login, senha);

				if (!logado)
				{
					Console.WriteLine("Login ou senha incorretos, insira novamente!");
				}

			} while (!usuario.Logar(login, senha));

			





			//---------------------------------
			//Console.WriteLine("Hello, " +usuario.nome);

			//Console.WriteLine( usuario.Logar("root", "qwe123")  );

			//string result = Console.ReadLine();
			//Método para ler do teclado
			//Console.WriteLine("O usuário digitou: " + result);
		}
	}
}