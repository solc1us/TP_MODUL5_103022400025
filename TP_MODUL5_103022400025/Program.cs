using TP_MODUL5_103022400025;

Console.WriteLine("Masukkan nama Anda: ");

// Minta input
string nama = Console.ReadLine();

// Buat objek dari kelas HaloGeneric
HaloGeneric halo = new HaloGeneric();

// Panggil metode SapaUser
halo.SapaUser(nama);