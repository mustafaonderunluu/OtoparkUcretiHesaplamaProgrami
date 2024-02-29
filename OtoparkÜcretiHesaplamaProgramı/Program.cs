// See https://aka.ms/new-console-template for more information

double odenecektutar = 0;
int saatbilgisi,aractipi = 0;
Console.WriteLine("Araç Tipleri  Taksi:1, Minibüs :2 ,Ticari =3 ");
Console.Write("Lütfen Araç Tipini Giriniz : ");
aractipi = Convert.ToInt32(Console.ReadLine());
Console.Write("Kalınan Süreyi Giriniz : ");
saatbilgisi = Convert.ToInt32(Console.ReadLine());
if (saatbilgisi > 1)
{
    for (int i = 1; i <= saatbilgisi; i++)
    {
        if (i == 1)
        {

            if (aractipi == 1) { odenecektutar = i * 5; }
            else if (aractipi == 2) { odenecektutar = i * 6; }
            else if (aractipi == 3) { odenecektutar = i * 6.5; }
            else { odenecektutar -= 1; }
            if (aractipi == 1) { odenecektutar += saatbilgisi * 5 * 1.20; }
            else if (aractipi == 2) { odenecektutar += saatbilgisi * 6 * 1.215; }
            else if (aractipi == 3) { odenecektutar += saatbilgisi * 6.5 * 1.25; }




        }


    }



}
else {

    if (aractipi == 1) { odenecektutar = saatbilgisi * 5; }
    else if (aractipi == 2) { odenecektutar = saatbilgisi * 6; }
    else if (aractipi == 3) { odenecektutar = saatbilgisi * 6.5; }
    
        
    


}
Console.WriteLine("Ödenecek Tutar : {0} TL ", odenecektutar);

// Bu program, kullanıcının araç tipine ve kalınan süreye göre ücret hesaplar. 
// Kalınan süre 1 saatten fazlaysa, her saatten sonra belirli bir artış uygulanır.
// Taksi için saat başı ücret 5 TL, minibüs için 6 TL, ticari araçlar için 6.5 TL'dir.
// Saat başı ücretlerine ek olarak, geçen her saat için farklı bir artış oranı uygulanır.
