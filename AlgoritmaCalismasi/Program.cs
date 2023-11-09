using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AlgoritmaCalismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //string veri = "PamukkaleÜniversitesiEğitimFakültesiDergisi(PAUEFD),eğitimveöğretmenyetiştirmeileilgiliakademik,evrenselbilimölçütlerineuygunnicelvenitelçalışmaları1996’danbuyanayayımlayanveyıldaüçkez(Ocak,MayısveEylül)çevrimiçibasılan,uluslararasıhakemlibiraçıkerişimdergisidir.PAUEFDerkenduyurukoşuluylayıldabirözelsayıçıkarabilir.Dikkat:Dergimizinyenişablonları(Türkçeveİngilizce)yayımlanmıştır.Lütfengönderimleriniziçinbuşablonlarıdikkatealınız.Ocak2024sayısındanitibarenyenişabloniledevamedilecektirAyrıntılıbilgiiçintıklayınız.PamukkaleÜniversitesiEğitimFakültesiDergisimakaleleriTÜRKÇEveİNGİLİZCEdillerindeyayımlar.YazarlardançalışmalarınıhakemdeğerlendirmesüreciiçinTÜRKÇEtammetinolarakgöndermeleribeklenir.Yayımlanmaküzerekabuledilençalışmalar,hemTÜRKÇEhemdeİNGİLİZCEtammetinolarakdergiyegönderilir.Çalışmalarındilniteliğindenyazar(lar)sorumluolduğuiçinyazarlardilerlersedildüzeltmehizmetisunanbazıkurumlardanyardımalabilirler.Dilsorunlarıiçerençalışmalaryazarlaragerigönderilir.YayınDiliHakkındaDuyurueğerliYazarlarımız,PamukkaleÜniversitesiEğitimFakültesiDergisi’ninyayındilipolitikası2022Eylülayıitibariylegüncellenmiştir.GüncellenenyayındilipolitikasınındetaylarınaaşağıdayeralannotlardanveYazımKurallarısayfasındanulaşabilirsiniz.DergimizeçalışmagönderirkenözellikleAmaçveKapsamsayfasındabelirtilenönceliğealınanvekapsamdışıtutulançalışmalarınözelliklerinedikkatedilmesiönemlidir(2022yılıretoranı=%64,2023yılıocakayıretoranı>%85).1-DergimizegönderilençalışmalarınhakemdeğerlendirmesürecininTürkçetammetniüzerindeyapılmasınakararverilmiştir.Dolayısıylasizdeğerliyazarlarımızdan,hakemdeğerlendirmesüreciiçinçalışmanızınsadeceTürkçetammetninigöndermeniziricaediyoruz.Yabancıdilöğretimikonusundayapılançalışmalarhakemdeğerlendirmesüreciiçinİngilizcetammetinolarakgönderilebilir.değerlendirmesürecisonrasındayayınakabuledildiktensonrasizdençalışmanızınhemTürkçehemdeİngilizcetammetnitalepedilecektir.2-TRDizinDergiDeğerlendirmeKriterleri’nde2020yılıiçinyapmışolduğudeğişikliküzerineSosyalbilimlerdâhilolmaküzeretümbilimdallarındayapılanmakaleleriçin“EtikKurulOnayı”talepedilmektedir.DolayısıyladergimizegönderilentümçalışmalardanEtikKurulOnayımutlakaalınmışolmalıdır.Etikkurulonayıolmayançalışmalardeğerlendirmesürecinedahiledilmeyecektir.3-PAUEFD,makalelerindergininanasayfasındayeralanmakaleyazımşablonlarınauygunolarakyazılmasınıönemsemektedir.Yazarlarımızındergimizemakalegönderirkenilgilişablonlarıdikkatealmalarınıönemlericaederiz.Makalegönderimlerinde,kişilerinkimlikleriniortayaçıkararakdeğerlendirmesürecinezararverebilecekkişiyeaitisim,kurumvebenzeribilgilerdosyadansilinerekdosyasistemeyüklenmelidirMakalelerDergiParksistemineyüklenirkenmakaleüstverileriningirişibüyükönemtaşımaktadır.BukapsamdaçalışmalarıngerekTürkçegerekseİngilizcekısmındakiözetveanahtarkelimelerileilgilibölümlerinvekaynakçanınenbaştaeksiksizolaraksistemegirilmesigerekmektedir.";

            ////string[,] simetriMatris = new string[veri.Length, 2];

            ////for (int i = 0; i < veri.Length; i++)
            ////{
            ////    for (int j = 0; j < veri.Length; j++)
            ////    {
            ////        if (i == j)
            ////        {
            ////            simetriMatris[i, j] = veri[i].ToString();
            ////        }
            ////        else if (i > j)
            ////        {
            ////            simetriMatris[i, j] = i + j;
            ////        }
            ////        else if (j > i)
            ////        {
            ////            simetriMatris[i, j] = j + i;
            ////        }
            ////    }
            ////}
            //string metin = veri;

            //Dictionary<char, int> harfSayilari = new Dictionary<char, int>();

            //foreach (char karakter in metin)
            //{
            //    if (harfSayilari.ContainsKey(karakter))
            //    {
            //        harfSayilari[karakter]++;
            //    }
            //    else
            //    {
            //        harfSayilari[karakter] = 1;
            //    }
            //}

            //foreach (var kvp in harfSayilari)
            //{
            //    Console.WriteLine($"{kvp.Key}: {kvp.Value} kez");
            //}

            string metin = "PamukkaleÜniversitesiEğitimFakültesiDergisi(PAUEFD),eğitimveöğretmenyetiştirmeileilgiliakademik,evrenselbilimölçütlerineuygunnicelvenitelçalışmaları1996’danbuyanayayımlayanveyıldaüçkez(Ocak,MayısveEylül)çevrimiçibasılan,uluslararasıhakemlibiraçıkerişimdergisidir.PAUEFDerkenduyurukoşuluylayıldabirözelsayıçıkarabilir.Dikkat:Dergimizinyenişablonları(Türkçeveİngilizce)yayımlanmıştır.Lütfengönderimleriniziçinbuşablonlarıdikkatealınız.Ocak2024sayısındanitibarenyenişabloniledevamedilecektirAyrıntılıbilgiiçintıklayınız.PamukkaleÜniversitesiEğitimFakültesiDergisimakaleleriTÜRKÇEveİNGİLİZCEdillerindeyayımlar.YazarlardançalışmalarınıhakemdeğerlendirmesüreciiçinTÜRKÇEtammetinolarakgöndermeleribeklenir.Yayımlanmaküzerekabuledilençalışmalar,hemTÜRKÇEhemdeİNGİLİZCEtammetinolarakdergiyegönderilir.Çalışmalarındilniteliğindenyazar(lar)sorumluolduğuiçinyazarlardilerlersedildüzeltmehizmetisunanbazıkurumlardanyardımalabilirler.Dilsorunlarıiçerençalışmalaryazarlaragerigönderilir.YayınDiliHakkındaDuyurueğerliYazarlarımız,PamukkaleÜniversitesiEğitimFakültesiDergisi’ninyayındilipolitikası2022Eylülayıitibariylegüncellenmiştir.GüncellenenyayındilipolitikasınındetaylarınaaşağıdayeralannotlardanveYazımKurallarısayfasındanulaşabilirsiniz.DergimizeçalışmagönderirkenözellikleAmaçveKapsamsayfasındabelirtilenönceliğealınanvekapsamdışıtutulançalışmalarınözelliklerinedikkatedilmesiönemlidir(2022yılıretoranı=%64,2023yılıocakayıretoranı>%85).1-DergimizegönderilençalışmalarınhakemdeğerlendirmesürecininTürkçetammetniüzerindeyapılmasınakararverilmiştir.Dolayısıylasizdeğerliyazarlarımızdan,hakemdeğerlendirmesüreciiçinçalışmanızınsadeceTürkçetammetninigöndermeniziricaediyoruz.Yabancıdilöğretimikonusundayapılançalışmalarhakemdeğerlendirmesüreciiçinİngilizcetammetinolarakgönderilebilir.değerlendirmesürecisonrasındayayınakabuledildiktensonrasizdençalışmanızınhemTürkçehemdeİngilizcetammetnitalepedilecektir.2-TRDizinDergiDeğerlendirmeKriterleri’nde2020yılıiçinyapmışolduğudeğişikliküzerineSosyalbilimlerdâhilolmaküzeretümbilimdallarındayapılanmakaleleriçin“EtikKurulOnayı”talepedilmektedir.DolayısıyladergimizegönderilentümçalışmalardanEtikKurulOnayımutlakaalınmışolmalıdır.Etikkurulonayıolmayançalışmalardeğerlendirmesürecinedahiledilmeyecektir.3-PAUEFD,makalelerindergininanasayfasındayeralanmakaleyazımşablonlarınauygunolarakyazılmasınıönemsemektedir.Yazarlarımızındergimizemakalegönderirkenilgilişablonlarıdikkatealmalarınıönemlericaederiz.Makalegönderimlerinde,kişilerinkimlikleriniortayaçıkararakdeğerlendirmesürecinezararverebilecekkişiyeaitisim,kurumvebenzeribilgilerdosyadansilinerekdosyasistemeyüklenmelidirMakalelerDergiParksistemineyüklenirkenmakaleüstverileriningirişibüyükönemtaşımaktadır.BukapsamdaçalışmalarıngerekTürkçegerekseİngilizcekısmındakiözetveanahtarkelimelerileilgilibölümlerinvekaynakçanınenbaştaeksiksizolaraksistemegirilmesigerekmektedir.";

            // Büyük harfleri küçük harfe dönüştür ve sadece harf karakterlerini tut
            metin = metin.ToLower();
            metin = Regex.Replace(metin, "[^a-z]", "");

            Dictionary<string, int> kumeSayilari = new Dictionary<string, int>();

            for (int uzunluk = 2; uzunluk <= metin.Length; uzunluk++)
            {
                for (int i = 0; i <= metin.Length - uzunluk; i++)
                {
                    string harfKume = metin.Substring(i, uzunluk);
                    if (kumeSayilari.ContainsKey(harfKume))
                    {
                        kumeSayilari[harfKume]++;
                    }
                    else
                    {
                        kumeSayilari[harfKume] = 1;
                    }
                }
            }

            int deger = 0;
            string sonucs = "";
            int sayac = 0;
            // Sonuçları yazdır
            foreach (var kvp in kumeSayilari)
            {
                if (kvp.Value >= 2)
                {
                    int sonuc = kvp.Key.Length * kvp.Value;
                    if (sonuc > deger)
                    {
                        if (deger > 50)
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }
                        deger = kvp.Key.Length * kvp.Value;
                        sonucs = kvp.Key +" :" + kvp.Value + " Total :" + deger.ToString();
                        sayac++;
                    }
                    else
                    {
                        sayac++;
                    }
                    if (86440 == sayac)
                    {
                        Console.WriteLine(sonucs);
                    }
                    //Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
                else
                {
                    sayac++;
                }

            }
        }
    }
}
