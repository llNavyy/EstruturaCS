using System;
using System.Collections.Generic; //Biblioteca que permite utilizar as estruturas, coleções.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaCS
{
    internal class Program
    {
        //Struct <- Somente esse será criado na classe "Program"
        //Struct é como uma classe limitada,geralmente usado onde arrays não são suficientes.

        struct Carro
        {
            public string Marca;
            public string Modelo;
            public string Cor;
            public string Placa;

            public Carro(string marca, string modelo, string cor, string placa)  //Construtor da Struct
            {
                Marca = marca;
                Modelo = modelo;
                Cor = cor;
                Placa = placa;
            }
            
            public void ExibirDados()
            /*Método para exibir as informações de todo carro criado
           
             
             */
            
            {
                Console.WriteLine("Marca: " + Marca);
                Console.WriteLine("Modelo: {0}", Modelo);
                Console.WriteLine($"Cor: {Cor} \r\n Placa:{Placa}");
            }

        }

        

        static void Main(string[] args)
        {

            /*  carro.Marca = "Honda";
              carro.Modelo = "Fit";
              carro.Placa = "LPM4P98";
              carro.Cor = "vermelha";*/

            // Carro carro2 = new Carro("Ford", "Ka", "Azul", "BGT8496");


            //carro2.ExibirDados();






            //Array <- Matrizes (Vetores unidimensionais e multidimensionais)
            //Queue <- Filas
           /* Queue<string> fila = new Queue<string>(); // Criando fila com nome de "fila"
            fila.Enqueue("José");  //Armazenando as "pessoas" na fila
            fila.Enqueue("Bruna");
            fila.Enqueue("Gui");

            //Números de elementos na fila
            int Npessoas = fila.Count; //Armazenará o número de pessoas na fila em uma variável
            Console.WriteLine(Npessoas);
                //OU
            Console.WriteLine(fila.Count);
                //OU (Exibe utilizando template string
            Console.WriteLine($"O número de pessoas é: {fila.Count}");

            Console.WriteLine($"O próximo da fila é:  {fila.Peek()}"); //Retorna o primeiro elemento da fila, sem removê-lo.
            Console.WriteLine($"O número de pessoas é: {fila.Count}");
            // fila.toList(); <- transforma uma queue em uma lista
            //fila.toLast(); retorna o ultimo elemento
            Console.WriteLine($"Cliente {fila.Dequeue()}, será atendido no guichê 4"); //Método pega o primeiro elemento e o retira da fila
            Console.WriteLine($"O próximo da fila é:  {fila.Peek()}");

            fila.Enqueue("Júlio");
            Console.WriteLine("O cliente Júlio entrou na fila");
            Console.WriteLine(fila.Count());

            */
            //Stack <- Pilhas

            //=>>>**O PRIMEIRO QUE ENTRA É O ÚLTIMO QUE SAI. O ÚLTIMO QUE ENTRA É O PRIMEIRO QUE SAI**<<==//
            Stack<int> pilha = new Stack<int>(); //Como que se cria uma pilha chamada "pilha"
            pilha.Push(12);
            pilha.Push(13);
            pilha.Push(14);
            pilha.Push(15);// Adiciona elemento na pilha

            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Removemos o primeiro elemento da pilha: {pilha.Pop()}");
            Console.WriteLine($"PRÓXIMO elemento da pilha: {pilha.Pop()}");//Remove e retorna o elemento SUPERIOR da stack(pilha). Neste caso retornará int 15.





            //List <- Listas

            /*
            List <Carro> carros = new List<Carro>();
            carros.Add(new Carro("Ford", "Ka", "Azul", "BGT8496"));
            carros.Add(new Carro("VW", "Fusca", "Azul", "TYE4567"));
            carros.Add(new Carro("Kia", "Soul", "Amarelo", "KYT5897"));

            foreach (Carro carro in carros)
            {
                carro.ExibirDados();
                Console.WriteLine();
            }
            /*   List<object> list = new List<object>();
               list.Add(carros);//Você pode adicionar qualquer coisa nessa lista

            
            var teste = carros.Contains(new Carro("Ford", "Ka", "Azul", "BGT8496")) ? //<- Operação ternária
                   "Tem sim, mano!" : "Tem não sangue!"; //o método contains retorna verdadeiro ou falso se o argumento (objeto passado) contêm na lista.
            // Nesse caso, retornará strings.
           







            Console.WriteLine(teste);

            */
            Console.ReadKey();
        }
    }
}
