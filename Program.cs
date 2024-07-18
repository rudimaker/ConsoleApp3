using System.Transactions;

Console.WriteLine("LUTFEN ASSAGIDAKI BILGILERI GIRINIZ :");

Console.WriteLine("TC KIMLIK NO :");
string tc = Console.ReadLine();

Console.WriteLine("ADINIZ :");
string ad = Console.ReadLine();

Console.WriteLine("SOYADINIZ :");
string soyad = Console.ReadLine();

Console.WriteLine("TELEFON NUMARANIZ :");
string tel = Console.ReadLine();

Console.WriteLine("YASINIZ :");
int yas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("URUN 1 FIYATI :");
double urun1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("URUN 2 FIYATI :");
double urun2 = Convert.ToDouble(Console.ReadLine());

double toplam = urun1 + urun2;

Console.WriteLine($"{tc} TC NUMARALI {ad} {soyad} KISISI SISTEME KAYDEDILMISTIR  ");
Console.WriteLine($"{tel} NUMARALI TELEFONA BİLDİRİM GÖNDERİLMİŞTİR ");
Console.WriteLine($"TOPLAM ALISVERIS TUTARI :{toplam} KAZANILAN PATIKE PUAN : {toplam * 0.1}  ");

