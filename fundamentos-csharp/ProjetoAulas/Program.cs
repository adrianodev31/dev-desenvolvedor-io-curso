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

        var arrayTipadoNumero = new int[3] {1,2,3};
        arrayTipadoNumero[1] = 50;
        foreach(var item in arrayTipadoNumero){
            Console.WriteLine(item);
        }

        Array.Resize(ref arrayTipadoNumero, 100);   //Aumentando o tamanho do Array de 3 para 100
        