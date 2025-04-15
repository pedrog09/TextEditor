
namespace TextEditor
{
    public class Program()
    {
        public static void Main(string[] args)
        {

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que voce deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break; 
                case 2: Criar(); break;
                default: Menu(); break;
            }
            }

            static void Criar()
            {
                
            }
            static void Abrir()
            {
                Console.WriteLine("1");
            }
    }

}
