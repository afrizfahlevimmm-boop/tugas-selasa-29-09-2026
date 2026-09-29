using System;

class Program
{
    static void Main()
    {
        int buku1 = 100;
        int buku2 = 200;
        int buku3 = 300;
        int pulpen = 500;
        int jumlahPulpen = 2;
        int totalBelanja = buku1 + buku2 + buku3 + (pulpen * jumlahPulpen);
        double diskon = 20;
        double jumlahDiskon = totalBelanja * diskon / 100;
        double totalBayar = totalBelanja - jumlahDiskon;


        if (totalBelanja < 700)
        {
            diskon = 0;
        }
        else if (totalBelanja < 1000)
        {
            diskon = 10;
        }
        else if (totalBelanja < 1500)
        {
            diskon = 20;
        }


        Console.WriteLine(" struk pembelajaan");
        Console.WriteLine("Total belanja : " + totalBelanja);
        Console.WriteLine("Diskon        : " + diskon + "%");
        Console.WriteLine("Potongan      : " + jumlahDiskon);
        Console.WriteLine("Total bayar   : " + totalBayar);


        Console.WriteLine(" Hasil TKA");

        Console.Write("Masukkan nilai TKA Matematika : ");
        double mtk = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan nilai TKA Bahasa Inggris : ");
        double inggris = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan nilai TKA Mata Pelajaran Pilihan : ");
        double pilihan = Convert.ToInt32(Console.ReadLine());

        double totalTKA = mtk + inggris + pilihan;

        Console.WriteLine("Total nilai TKA: " + totalTKA);

        if (totalTKA >= 280)
        {
            Console.WriteLine("Hasil: MEMENUHI syarat TKA minimal 280.");
        }
        else
        {
            Console.WriteLine("Hasil: BELUM memenuhi syarat TKA minimal 280.");
        }

        Console.WriteLine(" Hasil UTBK");

        double utbkMinimal = 600 - (0.30 * totalTKA);

        Console.WriteLine("Total nilai TKA       : " + totalTKA);
        Console.WriteLine("UTBK minimal          : " + utbkMinimal);

        Console.Write("Masukkan nilai UTBK kamu: ");
        double nilaiUTBK = Convert.ToInt32(Console.ReadLine());

        double nilaiAkhir = nilaiUTBK + (0.30 * totalTKA);

        Console.WriteLine("Nilai akhir simulasi  : " + nilaiAkhir);

        if (nilaiAkhir >= 600)
        {
            Console.WriteLine("Hasil: MEMENUHI target 600.");
        }
        else
        {
            double kekurangan = 600 - nilaiAkhir;

            Console.WriteLine("Hasil: BELUM memenuhi target 600.");
            Console.WriteLine("Kekurangan nilai       : " + kekurangan);
        }
    }
}
