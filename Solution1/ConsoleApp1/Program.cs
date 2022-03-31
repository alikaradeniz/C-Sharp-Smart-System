Console.WriteLine("Lütfen Isı Değerini Giriniz");
int isi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen Işık Değerini Giriniz");
int isik = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen Nem Değerini Giriniz");
int nem = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sistem Çalışıyorsa 1'e Basınız Çalışmıyorsa 0'a Basınız");
int sistemkontrol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Arıza Yok ise 1'e Basınız var ise 0'a Basınız");
int arizakontrol = Convert.ToInt32(Console.ReadLine());

bool sistem = false;
bool ariza = false;

if (sistemkontrol == 1)
{
    sistem = true;
}
else if(sistemkontrol == 0)

{
    sistem = false;
}
if (arizakontrol == 1)
{
    ariza = true;
}
else if (arizakontrol == 0)

{
    ariza = false;
}

if (isi <= 20 && isi >= 15 && isik <= 15 && isik >= 10 && nem <= 12 && nem >= 5)
{
    Console.WriteLine("Sistem de Arıza yok ve ÇALIŞIYOR");
}

else if (isi <= 20 && isi >= 15 && isik <= 15 && isik >= 10 && nem<5 && sistem==true && ariza==false)
{
    Console.WriteLine("ARIZA");
    Console.Beep(2000,2000);
}
else if (isi <= 20 && isi >= 15 && isik <= 15 && isik >= 10 && nem<5 && sistem==true && ariza==true)
{
    nem = 8;
    Console.WriteLine("Nem Arttırıldı");
}
else if (isi < 15 && isik <= 15 && isik >= 10 && nem<5 && sistem==true && ariza==true)
{
    isi = 17;
    Console.WriteLine("Isı Arttırıldı");
}
else if (isi < 15 && isik <= 15 && isik >= 10 && nem<5 && sistem==true && ariza==false)
{
    Console.WriteLine("ARIZA");
    Console.Beep(2000,2000);
}
else if (isi > 20 && isik <= 15 && isik >= 10 && nem<5 && sistem==true && ariza==false)
{
    Console.WriteLine("ARIZA");
    Console.Beep(2000,2000);
}
else if (isi > 20 && isik <= 15 && isik >= 10 && nem<5 && sistem==true && ariza==true)
{
    isi = 16;
    Console.WriteLine("Isı Azaltıldı");
}
else if (isi <= 20 && isi >= 15 && isik <= 9 && isik >= 0 && nem<=12 && nem>=5 && sistem==true)
{
    isik = 12;
    Console.WriteLine("Işık Arttırıldı");
}
else if (isi <= 20 && isi >= 15 && isik <= 9 && isik >= 0 && nem<=12 && nem>=5 && sistem==false)
{
    Console.WriteLine("ARIZA");
    Console.Beep(2000,2000);
}














    
    
