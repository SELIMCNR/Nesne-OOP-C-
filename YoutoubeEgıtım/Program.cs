using System;
using System.Globalization;

namespace YoutoubeEgıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // değer ve referans tipler
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1);

            // Arrays (diziler) //referans tiplere örnek
            int[] sayilar1 = new[] { 1, 2, 3 };
            int[] sayilar2 = new[] { 10, 20, 30 }; // new yeni adres oluşturuyor.


            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine(sayilar1[0]);
            //class ve metod
            CreditManager creditManager = new CreditManager(); // bellekte new ile referans oluştu
            creditManager.Calculate();
            creditManager.Save();
            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Ankara";


            CustomerManager customerManager = new CustomerManager(customer);  //Örnek oluşturmak , instance oluşturmak,instance creation
            //Encapsulation
            customerManager.Save();
            customerManager.Delete();

            // ınheritance miras alma
            Company company = new Company();
            company.TaxNumber = "10000";
            company.CompanyName = "Arçelik";
            company.Id = 100;


            CustomerManager customerManager2 = new CustomerManager(new Person());

            Person person = new Person();
            person.FirstName = "";
            person.NationalIdenty = "";

            Customer c1 = new Customer();
            Customer c2 = new Person();
            Customer c3 = new Company();
            
            Console.ReadLine();


        }
    }
    //Classlar 
    class CreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Hesaplandı");
        }

        public void Save()
        {
            Console.WriteLine("Kredi verildi");
        }


    }
    // Solıd Yazılım geliştirme prensipleri
    class Customer
    {
        public Customer()
        {
            Console.WriteLine("müşteri nesnesi başlatıldı");
        }

        public int Id { get; set; }

    
        public string City { get; set; }

    }
    class Person : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdenty { get; set; }
    }
    class Company : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }

    //Katmanlı Mimari
    class CustomerManager
    {
        private Customer _customer;
        public CustomerManager(Customer customer)   //constructor yapıcı metot
        {
            _customer = customer;
        }

        public void Save()
        {
            Console.WriteLine("Müsteri kaydedildi: " + _customer.City);
        }

        public void Delete()
        {
            Console.WriteLine("Müşteri silindi: " + _customer.City);
        }
    }
}


