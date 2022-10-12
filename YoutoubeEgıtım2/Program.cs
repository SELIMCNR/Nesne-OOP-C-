using System;

namespace YoutoubeEgıtım2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager =new CustomerManager( new Customer(),new MilitaryCrediManager());
            customerManager.GiveCredit();

            Console.ReadLine();
        }



    }

    //Classlar 
    class CreditManager
    {
        public void Calculate(int creditType)
        {
            //sonar gube
            if (creditType == 1 )  //esnaf
            {

            }
            if(creditType == 2)   //ogretmen
            {

            }







            Console.WriteLine("Hesaplandı");
        }

        public virtual void Save()
        {
            Console.WriteLine("Kredi verildi");
        }


    }

    interface ICreditManager
    {
        void Calculate();
        void Save(); // method imzası
    }

    abstract class BaseCreditManager : ICreditManager //Ortak operasyonları tutar
    {
        //tamamlanmamış 
        public abstract void Calculate(); //şuan bu imza şeklinde bırakıldı
       
        //ve tamamlanmış kodları abstract class tutar
        public void Save()
        {
            Console.WriteLine("Kaydedildi");
        }
    }

    class TeacherCreditManager : BaseCreditManager,ICreditManager
    {
        public override void Calculate()
        {
            //Hesaplamalar
            Console.WriteLine("Öğretmen kredisi hesaplandı");
        }

    }
    class MilitaryCrediManager : BaseCreditManager,ICreditManager
    {
        public override void Calculate() //abstract classın üzerine yaz
        {
            Console.WriteLine("Asker kredisis hesaplandı");
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
        private ICreditManager _creditManager;
      

        public CustomerManager(Customer customer, ICreditManager creditManager)   //constructor yapıcı metot
        {
            _customer = customer;
            _creditManager = creditManager;
        }

        public void Save()
        {
            Console.WriteLine("Müsteri kaydedildi: ");
        }

        public void Delete()
        {
            Console.WriteLine("Müşteri silindi: " );
        }
        public void GiveCredit()
        {
             _creditManager.Calculate();
            Console.WriteLine("Kredi verildi");
        }
    }
}
