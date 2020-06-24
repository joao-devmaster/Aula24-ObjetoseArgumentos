namespace Aula24ObjetoseArgumentos
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float preco { get; set; }

        public Produto(){

        }

        public Produto(int _Codigo, string _Nome,float _Preco){

            this.Codigo = _Codigo;
            this.Nome = _Nome;
            this.preco = _Preco;
        }


        
    }
}