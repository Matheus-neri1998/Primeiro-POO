
namespace Primeiro_POO
{
    public class Personagem

        /* Sintaxe de atributos a definir:
        -public = Assinatura
        -Tipo de atributo, que pode ser string, int, float, etc.
        -Nome da variável. Ex: int idade */
    {  
        public string nome;

        public int idade;

        public string armadura;

        public string iA = "Jarvis";

        public int life = 100;

        public int Atacar1(){
            return 100;
        }
        public int Atacar2(){
            return 20;
        }
        public int Defender(int ataque){

        this.life = this.life - ataque;

        return this.life = this.life - ataque;
        }

        

        
        


    }
}