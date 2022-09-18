using System;
using System.Collections;

namespace ToDo{

    public class CardList{

        private string baslik;
        private string ıcerik;
        private string atananKisi;
        private string buyukluk;

        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => ıcerik; set => ıcerik = value; }
        public string AtananKisi { get => atananKisi; set => atananKisi = value; }
        public string Buyukluk { get => buyukluk; set => buyukluk = value; }

        public CardList(string baslik, string icerik, string atananKisi, string buyukluk)
        {
            this.Baslik = baslik;
            this.Icerik = icerik;
            this.AtananKisi = atananKisi;
            this.Buyukluk = buyukluk;
        }
    }
}