 namespace Cadastro {
    public class Produto{
    
        private int Id;
        public Produto(string nome, string descricao) {
            Nome = nome;
            Descricao = descricao;
        }
    
        public string Nome { get; set; }
        public string Descricao { get; set; }

    

        public void ImprimeDadosDoProduto(){  
            Console.WriteLine($"Produto: ID {Id} - {Nome}");
            Console.WriteLine($"Descrição: '{Descricao}'");
        }

        public void SetId(int id){
            Id = id;
        }

        public int GetId(){
            return Id;
        }
    }
 }