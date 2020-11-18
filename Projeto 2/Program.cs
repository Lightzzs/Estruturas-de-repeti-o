using System;

namespace Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string senha;
            do{
                Console.WriteLine("Digite seu login de usúario");
                usuario = Console.ReadLine();


                Console.WriteLine("Digite sua senha de login");
                senha = Console.ReadLine();

                if(usuario == senha){
                    Console.WriteLine("sua senha é o nome de usuario são os mesmos");
                }

            }while(usuario == senha );
                 Console.WriteLine("Login Concluido Com Sucesso");
        }
    }
}   
    
        
    

