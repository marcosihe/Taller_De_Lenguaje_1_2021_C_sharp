namespace FormasGeometricas
{
    public class Rectangulo
    {
        private int base_;
        private int altura_;

        public int Base { get => base_; set => base_ = value; }
        public int Altura { get => altura_; set => altura_ = value; }

        public Rectangulo(){
            Base = 0;
            Altura = 0;
        }

        public Rectangulo(int base_, int altura_){
            this.base_ = base_;
            this.altura_ = altura_;
        }

        public int area(int x, int y){
            return x + y;
        }
        public int perimetro(int x, int y){
            return 2*x + 2*y;
        }
    }
}