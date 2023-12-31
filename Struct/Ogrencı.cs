﻿namespace Struct
{
    public struct Ogrencı
    {
        public Ogrencı(int numara, string adi, string soyadi, bool cinsiyet = true)
        {
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; } //Property - Özellik
    
        //bir daha fazla veri türünü birleştirmek için struct kullanırız
        public string Adi { get;set; }

        public string Soyadi { get; set; }

        public bool Cinsiyet { get; set; }

        //method ezmek
        public override string ToString()
        {
            return $"{Numara,-5}" + $"{Adi,-10}" + $"{Soyadi,-10}" + string.Format("{0,5}", Cinsiyet == true ? "Bay" : "Bayan");
        }


    }
    
}
