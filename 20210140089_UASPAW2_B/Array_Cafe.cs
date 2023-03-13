using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace UAS_PAW_CAFE
{
    /// <summary>
    /// Membuat Public Class
    /// </summary>
    /// <remarks> Class Array Cafe </remarks>
    public class Array_Cafe
    {
        /// <summary>
        /// Membuat Method KasirCafe
        /// <code>
        /// public void KasirCafe()
        /// {
        /// }
        /// </code>
        /// </summary>

        public void KasirCafe()
        {
            /// <summary>
            /// Script Menampilkan Menu Makanan
            /// <code>
            ///  Console.WriteLine("")
            /// </code>
            /// <remarks>  Console.Write("\n"); /n digunakan untuk merapikan baris </remarks>
            /// </summary>

            Console.WriteLine("======================================");
                Console.WriteLine("  Selamat Datang Di Jorengezzz Cafe   ");
                Console.WriteLine("          Jl.Wirobrajan KM 5          ");
                Console.WriteLine("======================================");
                Console.Write("\n");
                Console.WriteLine("   Silahkan Pilih Menu Makanan   ");
                Console.Write("\n");
                //Menampilkan Menu Makanan
                Console.WriteLine("==========MENU MAKANAN==========");
                Console.Write("\n");
                Console.WriteLine("  1. Spageti          : Rp. 20000");
                Console.WriteLine("  2. Pudding Roti     : Rp. 15000");
                Console.WriteLine("  3. Nasi Goreng      : Rp. 15000");
                Console.WriteLine("  4. Rice Bowl        : Rp. 20000");
                Console.Write("\n");
                //Menampilkan Menu Minuman
                Console.WriteLine("==========MENU MINUMAN==========");
                Console.Write("\n");
                Console.WriteLine("  1. Americano        : Rp. 15000");
                Console.WriteLine("  2. Mocha Latte      : Rp. 15000");
                Console.WriteLine("  3. Cappuchino       : Rp. 15000");
                Console.WriteLine("  4. Caramel Latte    : Rp. 15000");
                Console.WriteLine("  5. Vanilla Latte    : Rp. 17000");

                Console.Write("\n");
            /// <summary> Looping dengan menginput jumlah barang menggunakan kondisi do while </summary>
            /// <param><c> do </c></param> berarti bahwa operasi perhitungan akan dilakukan 
            /// <param><c> while </c></param> ketika (while) tepat
            int jumlah;
                //Looping dengan menginput jumlah barang menggunakan kondisi do while
                do
                {
                    Console.Write("\nMasukkan Jumlah Barang:  ");
                    jumlah = int.Parse(Console.ReadLine());
                } while (jumlah <= 0 || jumlah > 100);

            ///<summary>
            ///Mendeklarasikan atau mendefiniskan variabel data
            ///<example> <code>
            ///string[] 
            ///int bayar, kembalian;
            ///<remarks> Code string dan int  digunakan untuk mendeklarasikan tipe data </remarks>
            ///</code></example>
            ///</summary>
            string[] nama = new string[jumlah];
                int[] harga = new int[jumlah];
                int total = 0;
                int bayar, kembalian;

            ///<summary>Menampilkan nama pelanggan</summary>
            Console.WriteLine("===========================");
                Console.Write("Masukkan Nama Pelanggan : ");
            ///<summary> Mendeklarasikan variabel data string</summary>
            ///<param> <code>  Console.ReadLine </code> digunakan untuk input data langsung </param>
            string program1 = Console.ReadLine();

            ///<summary> Looping menggunakan kombinasi array</summary>
            ///<param>
            ///<c> i </c> adalah objek perumpamaan
            ///</param>
            ///<param> <c>for</c> ditujukan  untuk mengidentifikasi operasi perhitungan </param>
            for (int i = 0; i < jumlah; i++)
                {
                    do
                    {
                    ///<summary> Menampilkan input nama barang</summary>
                    Console.WriteLine("=================================");
                    ///<summary> memasukkan data</summary>
                    ///<example> Console.Write("Masukkan Nama Barang Ke-" + (i + 1) + ": ");  </example>
                    Console.Write("Masukkan Nama Barang Ke-" + (i + 1) + ": ");
                        nama[i] = Console.ReadLine();
                    }
                    ///<summary> User harus menginput nama barang diatas 0 karakter sampai dengan 20 karakter </summary>
                    /// <param> <c>nama</c> Untuk inpit nama pelanggan</param>
                while (nama[i].Length <= 0 || nama[i].Length > 50);

                    do
                    {
                    ///<summary>Menampilkan input harga data</summary>
                    Console.Write("Masukkan Harga Barang Ke-" + (i + 1) + ": ");
                        harga[i] = int.Parse(Console.ReadLine());
                    } ///<summary>User harus menginput harga barang min 5000 sampai 1000000 </summary>
                    ///<param><c>harga</c> untuk input harga makanan</param>
                while (harga[i] <= 4000 || harga[i] >= 1000000);

                }
            ///<summary> Menampilkan barang yang sudah dipilih</summary>
            Console.Clear();
                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine("Daftar Barang Yang Dipilih");
                Console.WriteLine("==========================");
            ///<summary> for digunkan untuk menentukan apa saja yang ditampilkan</summary>
            ///<code> Console.WriteLine((i + 1) + "." + nama[i] + " " + harga[i]); </code>
            ///<seealso cref="operator++"/>
            for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine((i + 1) + "." + nama[i] + " " + harga[i]);
                }
            ///<summary> foreach digunakan untuk menentukan total</summary>
                foreach (int i in harga)
                {
                    total += i;
                }

            ///<summary> Menampilkan total harga</summary>
            Console.WriteLine("=========================");
                Console.WriteLine("Total Harga  : Rp" + total);

                do
                {
                    Console.Write("Masukkan Tunai: Rp");
                    bayar = int.Parse(Console.ReadLine());

                ///<summary> operasi  kembalian uang dari uang yang dibayarkan dikurangi uang total </summary>
                kembalian = bayar - total;

                ///<summary> Kondisi jika input uang yang dibayarkan kurang </summary>
                ///<code> if (bayar < total) </code>
                ///<remarks> if digunakan ketika uang kurang</remarks>
                if (bayar < total)
                    {
                        Console.WriteLine("Maaf Uang Tidak Cukup !");
                    }
                ///<summary> Kondisi dimana input uang yang diberikan lebih dan menambahkan uang kembalian </summary>
                /// ///<remarks> else digunakan ketika uang cukup dan sisa</remarks>
                else
                {
                        Console.WriteLine("Uang kembalian anda : Rp." + kembalian);
                    }

                } while (bayar < total);
                Console.Write("\n");
                Console.Write("Nama Pelanggan: {0}", program1.ToString());
                Console.Write("\n");
            ///<summary>Meanmpilkan tanggal dan waktu transaksi</summary>
            ///<param><code>DateTime.Today.ToString("yyyy-MM-dd")); </code> format tanggal
            ///</param>
            Console.WriteLine("Tanggal Transaksi:" + DateTime.Today.ToString("yyyy-MM-dd"));
                Console.WriteLine("Jam Transaksi: " + DateTime.Now.ToString("HH:mm:ss"));
                Console.WriteLine("========================================");
                Console.WriteLine("Nama Kasir  : Moh Firdaus MNI");
                Console.WriteLine("Terima Kasih");
                Console.WriteLine("========================================");

            ///<summary> Mencetak nota dengan menggunakan streamwritter </summary>
            ///<param>
            ///<code>  using (StreamWriter sw = new StreamWriter(@"C:\Nota\sample2.txt")) </code> menentukan lokasi file
            ///</param>
            using (StreamWriter sw = new StreamWriter(@"C:\Nota\sample2.txt"))
                {
                    sw.WriteLine("==========================================");
                    sw.WriteLine("============= NOTA PEMBAYARAN ============");
                    sw.WriteLine("==========================================");
                    sw.WriteLine("         Nama Barang Yang Dibeli          ");
                    for (int i = 0; i < jumlah; i++)
                    {
                        sw.WriteLine((i + 1) + ". " + nama[i] + " " + harga[i]);
                    }
                    sw.WriteLine("+==========================================+");
                    sw.WriteLine("Total Harga       : Rp" + total);
                    sw.WriteLine("Tunai             : Rp" + bayar);
                    sw.WriteLine("Kembalian         : Rp" + kembalian);
                    sw.WriteLine("\n");
                ///<summary>Menampilkan nama pelanggan</summary>
                sw.WriteLine("Nama Pelanggan: {0}", program1.ToString());
                ///<summary>enampilkan tanggal dan waktu transaksi</summary>
                sw.WriteLine("Tanggal Transaksi" + DateTime.Today.ToString("yyyy-MM-dd"));
                    sw.WriteLine("Jam Transaksi: " + DateTime.Now.ToString("HH:mm:ss"));
                    sw.WriteLine("========================================");
                    sw.WriteLine("Nama Kasir  : Moh Firdaus MNI");
                    sw.WriteLine("Terima Kasih");
                    sw.WriteLine("========================================");
                    Console.WriteLine("\n");
                    Console.WriteLine("Nota Telah Dicetak");
                }
                Console.WriteLine();
                Console.Write("Tekan ENTER untuk Keluar...");
                Console.ReadLine();
            
        }
        static void Main(string[] args)
        {
            ///<summary> Memanggil kelas KasirCafe di file lain</summary>
            Array_Cafe KasirB = new Array_Cafe();
            KasirB.KasirCafe();
        }
    }
}