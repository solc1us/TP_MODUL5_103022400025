using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL5_103022400025
{
    internal class DataGeneric<T>
    {
        private T data;

        // Konstruktor untuk menginisialisasi data
        public DataGeneric(T data)
        {
            this.data = data;
        }

        // Method untuk menampilkan data yang tersimpan
        public void printData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }

    }
}
