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

        public int area(){
            return base_ * altura_;
        }
        public int perimetro(){
            return 2*base_ + 2*altura_;
        }
    }

    public class Triangulo
    {
        private int baseT;
        private int alturaT;

        public int BaseT { get => baseT; set => baseT = value; }
        public int AlturaT { get => alturaT; set => alturaT = value; }

        public Triangulo(){
            BaseT = 0;
            AlturaT = 0;
        }

        public Triangulo(int baseT, int alturaT){
            this.baseT = baseT;
            this.alturaT = alturaT;
        }

        public int area(){
            return baseT * alturaT / 2;
        }

    }
}