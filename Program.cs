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

    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            List<DateTime> dateTimes = new List<DateTime>();
            inputDates = dateTimes;
        }

        public void AddNewData(T Data)
        {
            storedData.Add(Data);
            inputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for(int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data" + i + "Isi : " + storedData[i].ToString() + "Waktu Disimpan" + i);
            }
        }
    }
}