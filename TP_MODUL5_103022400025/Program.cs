using TP_MODUL5_103022400025;

Console.WriteLine("Masukkan nama Anda: ");

// Minta input
string nama = Console.ReadLine();

// Buat objek dari kelas HaloGeneric
HaloGeneric halo = new HaloGeneric();

// Panggil metode SapaUser
halo.SapaUser(nama);

Console.WriteLine("Masukkan NIM:");

// Masukkan NIM
string nim = Console.ReadLine();

// Membuat objek DataGeneric dengan tipe data string
DataGeneric<string> dataNIM = new DataGeneric<string>(nim);

// Menampilkan data NIM yang tersimpan
dataNIM.printData();
