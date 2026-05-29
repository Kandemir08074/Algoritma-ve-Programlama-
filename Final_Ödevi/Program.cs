namespace Final_Ödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Kategoriler = new List<string>();
            List<int> Tutarlar = new List<int>();
            List<int> Gün_Numaraları = new List<int>();
            List<string> İsimler = new List<string>();
            Console.WriteLine("Kampüs Harcama Uygulamasına Hoşgeldiniz Yapmak İstediğiniz İşlemi Seçiniz");
            Console.WriteLine("-------------------------------------------------------------------------");
            Thread.Sleep(500);
            int seçim = 0;
            int p = 0;
            int enb = 0;
            while (true)
            {
                Console.WriteLine("Yeni Harcama Ekleme: 1");
                Thread.Sleep(500);
                Console.WriteLine("Tüm Harcamaları Listele: 2");
                Thread.Sleep(500);
                Console.WriteLine("Kategoriye Göre Listele: 3");
                Thread.Sleep(500);
                Console.WriteLine("Toplam Harcamayı Hesapla: 4");
                Thread.Sleep(500);
                Console.WriteLine("Ortalama Harcamayı Bul: 5");
                Thread.Sleep(500);
                Console.WriteLine("En Yüksek Harcamayı Bul: 6");
                Thread.Sleep(500);
                Console.WriteLine("Kategori Bazlı Toplam Harcamayı Bul: 7");
                Thread.Sleep(500);
                Console.WriteLine("Gün Bazlı Toplam Harcamayı Bul: 8");
                Thread.Sleep(500);
                Console.WriteLine("Tutarları Büyükten Küçüğe Sırala: 9");
                Thread.Sleep(500);
                Console.WriteLine("Binary veya Linear Arama İçin: 10");
                Thread.Sleep(500);
                Console.WriteLine("Toplam Kayıt Sayısını Görmek İçin: 11");
                Thread.Sleep(500);
                Console.WriteLine("Çıkmak İçin: 12");
                try
                {
                    Console.Write("Seçiminiz: ");
                    seçim = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException m)
                {
                    Console.WriteLine("Geçerli Bir Giriş Yapınız!!!!");
                    continue;
                }
                Console.WriteLine(" ");
                if (seçim > 7)
                {
                    Console.WriteLine("Geçerli Bir İşlem Giriniz!!!! ");
                    continue;
                }
                if (seçim == 1)
                {
                    Yeni_Harcama(Tutarlar, Gün_Numaraları, Kategoriler, İsimler);
                }
                if (seçim == 2)
                {
                    Harcamaları_Listeleme(Tutarlar, Gün_Numaraları, Kategoriler, İsimler);
                    Console.WriteLine(" ");
                }
                if (seçim == 3)
                {
                    Kategorili_Listeleme(Tutarlar, Gün_Numaraları, Kategoriler, İsimler);
                }
                if (seçim == 4)
                {
                    Console.WriteLine($"Toplam Tutar: {Toplam_Harcama(Tutarlar)} TL");
                    Console.WriteLine(" ");
                }
                if (seçim == 5)
                {
                    Console.WriteLine($"Ortalama Tutar: {Ortalama_Harcama(Tutarlar)} TL");
                    Console.WriteLine(" ");
                }
                if (seçim == 6)
                {
                    Console.WriteLine($"En Yüksek Tutar: {En_Yüksek_Harcama(Tutarlar, p, enb)}");
                    Console.WriteLine(" ");
                }
                if (seçim == 7)
                {
                    Kategoriye_Göre_Toplama(Tutarlar, Kategoriler);
                    Console.WriteLine(" ");
                }
                if (seçim == 8)
                {
                    Güne_Göre_Toplama(Gün_Numaraları, Tutarlar);
                    Console.WriteLine(" ");
                }
                if (seçim == 9)
                {
                    Tutarları_Sıralama(Tutarlar);
                    Console.WriteLine(" ");
                }
                if (seçim == 10)
                {
                    Console.Write("Nasıl Arrtmak İstersiniz: L/B ");
                    char arat = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine(" ");
                    if (arat == 'L')
                    {
                        Linear_Arama(İsimler);
                    }
                    else if (arat == 'B')
                    {
                        Binary_Arama(İsimler);
                    }
                    Console.WriteLine(" ");
                    
                }
                if (seçim == 11)
                {
                    Console.WriteLine($"Toplam Kayıt Sayısı: {İsimler.Count}");
                    Console.WriteLine(" ");
                   
                }
                if (seçim == 12)
                {
                    Console.WriteLine("Uygulamadan Çıkılıyor...");
                    Thread.Sleep(1000);
                    break;
                }   
            }
        static void Yeni_Harcama(List<int> Tutar, List<int> Gsayısı, List<string> Kategori, List<string> Isim)
        {
            Console.Write("Harcama Adını Giriniz: ");
            string ad = Console.ReadLine();
            Isim.Add(ad);
            Console.WriteLine(" ");
            Console.Write("Kategoriyi Giriniz: ");
            string kategori = Console.ReadLine();
            Kategori.Add(kategori);
            Console.WriteLine(" ");
            Console.Write("Tutarı Giriniz: ");
            while (true)
            {
                string tutar = Console.ReadLine();
                bool dogru_mu = int.TryParse(tutar, out int ytutar);
                if (dogru_mu)
                {
                    Tutar.Add(ytutar);
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersi Tutar Tekrar Deneyiniz!!!!");
                    continue;
                }
            }
            Console.WriteLine(" ");
            Console.Write("Gün Numarasını Giriniz: ");
            while (true)
            {
                string gün = Console.ReadLine();
                bool dogru_mu = int.TryParse(gün, out int ygün);
                if (dogru_mu)
                {
                    Gsayısı.Add(ygün);
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersi Gün Numarası Tekrar Deneyiniz!!!!");
                    continue;
                }
                Console.WriteLine(" ");
            }
            for (int i = 0; i < Tutar.Count; i++)
            {

                File.AppendAllText("C:\\Users\\Mert\\OneDrive\\Desktop\\Algoritma_Final_Ödevi\\harcamalr.csv", $"{Kategori[i]}: {Isim[i]} , {Tutar[i]} TL , Gün: {Gsayısı[i]}\n");
            }
        }
        static void Harcamaları_Listeleme(List<int> Tutar, List<int> Gsayısı, List<string> Kategori, List<string> Isim)
        {
            string oku = File.ReadAllText("C:\\Users\\Mert\\OneDrive\\Desktop\\Algoritma_Final_Ödevi\\harcamalr.csv");
            Console.WriteLine(oku);
        }
        static void Kategorili_Listeleme(List<int> Tutar, List<int> Gsayısı, List<string> Kategori, List<string> Isim)
        {
            Console.Write("Listeletmek İsteğiniz Kategoriyi Yazın: ");
            string k = Console.ReadLine();
            Console.WriteLine("Arattığınız Kategoride: ");
            bool var_mı = false;
            for (int i = 0; i < Kategori.Count; i++)
            {
                if (Kategori[i] == k)
                {
                    Console.WriteLine($"{Isim[i]} , {Tutar[i]} TL , {Gsayısı[i]}");
                    Console.WriteLine("");
                    var_mı = true;
                }
            }
            if (var_mı = false)
            {
                Console.WriteLine("Aradığını Kategori Bulunmuyor!!!!");
                Console.WriteLine(" ");
            }
        }
        static int Toplam_Harcama(List<int> Tutar)
        {
            int toplam = 0;
            for (int i = 0; i < Tutar.Count; i++)
            {
                toplam += Tutar[i];
            }
            return toplam;
        }
        static int Ortalama_Harcama(List<int> Tutar)
        {
            int top = 0;
            for (int i = 0; i < Tutar.Count; i++)
            {
                top += Tutar[i];
            }
            double ort = top / Tutar.Count;
            return (int)ort;
        }
        static int En_Yüksek_Harcama(List<int> Tutar, int a, int enb)
        {
            if (enb < Tutar[a])
            {
                enb = Tutar[a];
            }
            if (a == Tutar.Count - 1)
            {
                return enb;
            }
            return En_Yüksek_Harcama(Tutar, ++a, enb);
        }
        static void Kategoriye_Göre_Toplama(List<int> Tutar, List<string> Kategori)
        {
            Dictionary<string, int> bir = new Dictionary<string, int>();
            for (int i = 0; i < Kategori.Count; i++)
            {
                if (bir.ContainsKey(Kategori[i]))
                {
                    bir[Kategori[i]] += Tutar[i];
                }
                else
                {
                    bir.Add(Kategori[i], Tutar[i]);
                }
            }
            foreach (var yıldız in bir)
            {
                Console.Write($"{yıldız.Key}: ");
                int y = yıldız.Value / 10;
                for (int i = 0; i < y; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine($"({yıldız.Value} TL)");
            }
        }
        static void Güne_Göre_Toplama(List<int> Gün, List<int> Tutar)
        {
            Dictionary<int, int> bir = new Dictionary<int, int>();
            for (int i = 0; i < Gün.Count; i++)
            {
                if (bir.ContainsKey(Gün[i]))
                {
                    bir[Gün[i]] += Tutar[i];
                }
                else
                {
                    bir.Add(Gün[i], Tutar[i]);
                }
            }
            foreach (var yıldız in bir)
            {
                Console.Write($"{yıldız.Key}: ");
                int y = yıldız.Value / 10;
                for (int i = 0; i < y; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine($"({yıldız.Value} TL)");
            }
        }
        static void Tutarları_Sıralama(List<int> Tutar)
        {
            for (int i = 0; i < Tutar.Count; i++)
            {
                for (int j = 0; j < Tutar.Count - 1; j++)
                {
                    if (Tutar[j] < Tutar[j + 1])
                    {
                        int o_an = Tutar[j + 1];
                        Tutar[j + 1] = Tutar[j];
                        Tutar[j] = o_an;
                    }
                }
            }
        }
        static void Binary_Arama(List<string> Ad)
        {
            Console.Write("Aramak İstediğiniz Addaki Ürünü Giriniz: ");
            string aranan = Console.ReadLine();
            int sol = 0;
            int sağ = Ad.Count - 1;
            int sayaç = 0;
            while (sol <= sağ)
            {
                int orta = (sol + sağ) / 2;
                if (Ad[orta] == aranan)
                {
                    Console.WriteLine($"Aradığınız Addaki Ürün {orta}. Sırada Bulunuyor.");
                    Console.WriteLine($"Arama {sayaç} adımda Bulundu.");
                    return;
                    sayaç++;
                }
                else if (string.Compare(Ad[orta], aranan) < 0)
                {
                    sol = orta + 1;
                    sayaç++;
                }
                else
                {
                    sağ = orta - 1;
                    sayaç++;
                }
            }
            Console.WriteLine("Aradığınız Adda Bir Ürün Bulunmuyor!!!!");
        }
        static void Linear_Arama(List<string> Ad)
        {
            Console.Write("Aramak İstediğiniz Addaki Ürünü Giriniz: ");
            string aranan = Console.ReadLine();
            int sayaç = 0;
            for (int i = 0; i < Ad.Count; i++)
            {
                if (Ad[i] == aranan)
                {
                    Console.WriteLine($"Aradığınız Addaki Ürün {i}. Sırada Bulunuyor.");
                    Console.WriteLine($"Arama {sayaç} adımda Bulundu.");
                    return;
                }
                sayaç++;
            }
            Console.WriteLine("Aradığınız Adda Bir Ürün Bulunmuyor!!!!");
        }
    }
}
