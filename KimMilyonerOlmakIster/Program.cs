using System;

     class Program
{
       static void Main(string[] args)
    {
          int correctAnswers = 0; // Doğru cevap sayısını tutmak için değişken

        Console.WriteLine("Kim Milyoner Olmak İster Yarışmasına Hoş Geldin:)\n");
        Console.WriteLine("3 sorudan en az 2 tanesini doğru cevaplarsan büyük ödülü kazanacaksın!");

        // 1. Soru
        Console.WriteLine("1) 'Hola' kelimesi 'Merhaba' anlamına gelir. Bu kelime hangi dile aittir?");
        Console.WriteLine("a) Fransızca");
        Console.WriteLine("b) İspanyolca");
        Console.Write("Cevabınız (a/b): ");
        string answer1 = Console.ReadLine().ToLower(); // Büyük veya küçük harf hassasiyeti olmayacak ve büyük de küçük de yazılsa fark etmeyecek

          if (answer1 == "b")
        {
            Console.WriteLine("Doğru cevap. Tebrikler!");
            correctAnswers++;
        }
          else
        {
            Console.WriteLine("Yanlış cevap! Doğru cevap: b) İspanya");
        }

        // 2. Soru
        Console.WriteLine("\n2) Atatürk, Türkiye Cumhuriyeti’ni hangi yılda kurmuştur?");
        Console.WriteLine("a) 1923");
        Console.WriteLine("b) 1938");
        Console.Write("Cevabınız (a/b): ");
        string answer2 = Console.ReadLine().ToLower();

          if (answer2 == "a")
        {
            Console.WriteLine("Doğru cevap. İyi ilerliyorsun!");
            correctAnswers++;
        }
          else
        {
            Console.WriteLine("Yanlış cevap! Doğru cevap: a) 1923");
        }

        // Eğer ilk iki sorudan en az biri doğruysa 3. soruyu soracak, aksi takdirde son soruyu sormayacak
           if (correctAnswers >= 1)
        {
            Console.WriteLine("\n3) Hangisi bir programlama dilidir?");
            Console.WriteLine("a) HTML");
            Console.WriteLine("b) Python");
            Console.Write("Cevabınız (a/b): ");
            string answer3 = Console.ReadLine().ToLower();

            if (answer3 == "b")
            {
                Console.WriteLine("Doğru cevap. Bu son soruydu ve başardın!");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine("Yanlış cevap! Doğru cevap: b) Python");
            }
        }
            else
           {
            Console.WriteLine("\nİlk iki soruyu yanlış cevapladığın için yarışma sona erdi, yine de iyi ilerledin.");
           }

        // Ödülü kazanıp kazanmadığını gösterecek
        Console.WriteLine("\nDoğru cevap sayınız: " + correctAnswers);

        if (correctAnswers >= 2) //doğru sayısı eğer 2 veya 2'den fazlaysa yarışmayı kazanacak
        {
            Console.WriteLine("TEBRİKLER! Büyük ödülü kazandın!");
        }
        else
        {
            Console.WriteLine("Üzgünüm, maalesef büyük ödülü kazanamadın.");
        }
    }
}
