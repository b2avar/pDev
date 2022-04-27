namespace Interface_Example{

    public class Corolla : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengine()
        {
            return Renk.Gri;
        }
    }
}