int[] sayilar=new int[6];
int[] kasasayilar=new int[6];
int tahmin =0;
Console.WriteLine("6 adet sayı giriniz");
Random rnd=new Random();
for (int i = 0; i < 6; i++)
{
    kasasayilar[i]=rnd.Next(i,60);
    Console.WriteLine("{0}. sayı giriniz :",(i+1));
    sayilar[i]=int.Parse(Console.ReadLine()!);
   
   

}
foreach (var sayi in sayilar)
{
    foreach (var kasasayi in kasasayilar)
    {
        tahmin= sayi==kasasayi? tahmin++ :tahmin;       
    }
     
}
Console.WriteLine("{0} adet doğru tahminde bulundunuz!",tahmin);
Console.WriteLine(" Random sayilar {0} ");
for (int i = 0; i < kasasayilar.Length; i++)
{
    Console.WriteLine("{0}",kasasayilar[i]);
}



