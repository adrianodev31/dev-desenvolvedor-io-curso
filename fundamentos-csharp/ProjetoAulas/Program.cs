//FUNÇÕES====================================================================================
/*
        string nomeCompleto(){
            string primeiroNome = "Adriano";
            string segundoNome = "Sales";
            return primeiroNome + " " + segundoNome;
        }

        Console.WriteLine(nomeCompleto());

    //================ outro exemplo=============================

        var soma = somaValores();

        int somaValores(){
            return 8 + 2;
        }
        Console.WriteLine(soma);

    //========posso usar void para não retornar nada==============

        void nomeInteiro(){
            var nome = "Adriano Sales";
            Console.WriteLine(nome);
        }
        nomeInteiro();

    //========RECEBENDO PARÂMETROS================================
        int SomaValores(int a, int b){
            return a + b;
        }        
        Console.WriteLine("Função com parâmetros = " + SomaValores(10, 15));

        //====

        string retornaNomeTodo(string nome, int idade){
            return "Meu nome é " + nome + " e eu tenho " + idade + " anos."; 
        }
        var frase = retornaNomeTodo("Adriano", 31);
        Console.WriteLine(frase);
*/

//ESTRUTURA DE DADOS=========================================================================

//=========ARRAY LIST===================
        /*
        using System.Collections;

        var arrayList = new ArrayList();
        arrayList.Add(1);   // 0
        arrayList.Add("Adriano"); // 1
        arrayList.Add(true); // 2

        Console.WriteLine(arrayList[1]);

        foreach(var item in arrayList){
            Console.WriteLine(item);
        }
        */
//=========ARRAYS TIPADOS===============
    /*
        var arrayTipadoNumero = new int[3] {1,2,3};
        arrayTipadoNumero[1] = 50;
        foreach(var item in arrayTipadoNumero){
            Console.WriteLine(item);
        }

        Array.Resize(ref arrayTipadoNumero, 100);   //Aumentando o tamanho do Array de 3 para 100
    */
//=========LISTA GENÉRICA=================
    /*
        var Lista1= new List<string>();
        Lista1.Add("Adriano");
        Lista1.Add("Cinthia");
        Lista1.Add("Angelina");

        foreach(var item in Lista1){
            Console.WriteLine(item);
        }

        //OU===

        var Lista2= new List<string>(){
            "Caio",
            "Luiz",
            "Souza",
        };

        foreach(var item in Lista2){
            Console.WriteLine(item);
        }

    */

//=========DICIONÁRIO====================
    /*
        var dicionario1 = new Dictionary<int, string>();
        dicionario1.Add(205, "Item 205, 205 é KEY e não Indice de Array!!");
        dicionario1.Add(102, "item 102 Beeeh");
        dicionario1.Add(2, "Adriano Sales");

        foreach(var item in dicionario1){
            Console.WriteLine(item.Key);
        }

        //Passando o nome com dicionario, repare que [2] é a CHAVE e não o indice!
        var nome1 = dicionario1[2];
        Console.WriteLine(nome1);
    */
//========QUEUE(FILA)====================
    /*    
        var Fila1 = new Queue<string>();
        Fila1.Enqueue("Testando 1");
        Fila1.Enqueue("Testando 2");
        Fila1.Enqueue("Adriano");

        var frase2 = Fila1.Dequeue();   //Use peek se n quiser o proximo nos outros, e sim só o primeiro
        var frase3 = Fila1.Dequeue();
        var frase4 = Fila1.Dequeue();

        Console.WriteLine(frase2);
        Console.WriteLine(frase3);
        Console.WriteLine(frase4);

        //Faz tipo um foreach, mas ele vai excluindo o ultimo item!
    */

//========STACK(PILHA)===================
    /*
        var stack = new Stack<string>();
        stack.Push("Adriano");
        stack.Push("Sales");
        
        foreach(var item in stack){
            Console.WriteLine(item);
        };

        //primeiro vai resultar em sales, dps adriano
    */




        