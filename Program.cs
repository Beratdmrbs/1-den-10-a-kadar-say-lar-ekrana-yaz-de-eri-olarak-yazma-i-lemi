for (int i = 1; i <= 10; i++)
{
    string yazı = "";

    switch (i)
    {
        case 1:
            yazı = "BİR";
            break;
        case 2:
            yazı = "İKİ";
            break;
        case 3:
            yazı = "ÜÇ";
            break;
        case 4:
            yazı = "DÖRT";
            break;
        case 5:
            yazı = "BEŞ";
            break;
        case 6:
            yazı = "ALTı";
            break;
        case 7:
            yazı = "YEDİ";
            break;
        case 8:
            yazı = "SEKİZ";
            break;
        case 9:
            yazı = "DOKUZ";
            break;
        case 10:
            yazı = "ON";
            break;
        default:
            yazı = "Geçersiz sayı";
            break;
    }

    Console.WriteLine(yazı);
}