using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static Produk produk = new Produk();
        static List<Produk> daftarProduk = new List<Produk>();//membuat collection list
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            
            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();//menabah menu Tambah produk
                        break;

                    case 2:
                        HapusProduk();//menabah menu Hapus produk
                        break;

                    case 3:
                        TampilProduk();//menabah menu Tampil Produk
                        break;

                    case 4: // keluar dari program //menabah menu Keluar Program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()//menambah meni Tampil menu
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi...");//menampilkan Tulisan Ppilih Menu Aplikasi
            Console.WriteLine();
            Console.WriteLine("1. Tambah Produk");//menampilkan Tulisan Tambah Produk
            Console.WriteLine("2. Hapus Produk");//menampilkan Tulisan Hapus Produk
            Console.WriteLine("3. Tampilkan Produk");//menampilkan Tulisan Taampilkan Produk
            Console.WriteLine("4. Keluar");//menampilkan Tulisan Keluar
            // TODO: tuliskan logika Anda di sini ...
        }

        static void TambahProduk()//Menambah menu Tambah Produk
        {
            Console.Clear();//untuk mengkosongkan layar
            produk = new Produk();
            Console.WriteLine("Tambah Data Produk");//menampilkan Tulisan Tambah Data Produk
            Console.WriteLine();
            Console.Write("Kode Produk\t: ");//menampilkan Tulisan Kode Produk
            produk.kode_Produk = Console.ReadLine();
            Console.Write("Nama Produk\t: ");//menampilkan Tulisan Nama Produk
            produk.nama_Produk = Console.ReadLine();
            Console.Write("Harga Beli\t: ");
            produk.harga_Beli = Convert.ToInt32(Console.ReadLine());
            Console.Write("Harga Jual\t: ");
            produk.harga_Jual = Convert.ToInt32(Console.ReadLine());
            // TODO: tuliskan logika Anda di sini ...
            daftarProduk.Add(produk);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()//Menambah menu Hapus Produk
        {
            Console.Clear();// untuk mengkosongkan layar
            Console.WriteLine("Hapus Data Produk");//menampilkan Tulisan Hapus Data Produk
            Console.Write("Kode Produk : ");//menampilkan Tulisan Kode Produk
            string kode = Console.ReadLine();
            var itemRemove = daftarProduk.SingleOrDefault(r => r.kode_Produk == kode);//untuk menghapus daftar porduk

            if (itemRemove == null)
            {
                Console.WriteLine();
                Console.WriteLine("Kode Produk Tidak DItemukan...");//menampilkan Tulisan Produk Tidak DI temukan
            }
            else
            {
                daftarProduk.Remove(itemRemove);//menghapus daftar produk
                Console.WriteLine();
                Console.WriteLine("Data Produk Berhasil Dihapus...");//menampilkan Tulisan Produk Berhasil Di hapus
            }

            // TODO: tuliskan logika Anda di sini ...

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");//menampilkan TulisanTekan Enter untuk Kembali
            Console.ReadKey();
        }

        static void TampilProduk()//MEnambah Menu Tampil Produk
        {
            Console.Clear();
            Console.WriteLine("Data Produk");//menampilkan Tulisan Data Produk
            int i = 1;
            foreach (Produk prod in daftarProduk) //Untuk Mengambil Data dari daftar produk
            {
                
                Console.WriteLine("{0}.\t{1}, {2}, {3}, {4}",i, prod.kode_Produk, prod.nama_Produk, prod.harga_Beli, prod.harga_Jual);
                i++; ////menampilkan Tulisan Data Produk
                
            }
                // TODO: tuliskan logika Anda di sini ...

            Console.WriteLine("\nTekan enter untuk kembali ke menu");//menampilkan Tulisan Tekan enter untuk kembali ke menu
            Console.ReadKey();
        }
    }
}
