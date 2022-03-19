namespace Modul4_1302204025
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<double>(13, 02, 20));
        }
    }

    class Penjumlahan
    {
        public static double JumlahTigaAngka<T>(T hasilSatu,T hasilDua,T hasilTiga)
        {
            dynamic jumlah1 = hasilSatu;
            dynamic jumlah2 = hasilDua;
            dynamic jumlah3 = hasilTiga;

            return jumlah1 + jumlah2 + jumlah3;
        }
    }
}