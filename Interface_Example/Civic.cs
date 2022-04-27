namespace Interface_Example{

    public class Civic : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengine()
        {
            return Renk.Beyaz;  
        }
    }
}