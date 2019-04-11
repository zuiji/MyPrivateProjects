using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCreatingClass
{
    class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            Location = loc;
            Make = make;
            Model = model;


        }
        // The following statements declare private member variables
        private string _location;
        private string _make;
        private string _model;

        public string Location
        {
            get {return _location;}
            set {_location = value;}
        }

        public string Make
        {
            get {return _make;}
            set {_make = value;}
        }

        public string Model
        {
            get {return _model;}
            set {_model = value;}
        }

        // The following statements declare public methods
        public void MakeCappuccino()
        {
            // Method logic goes here
            Console.WriteLine("Cappuccino is made.");
        }


        //// Adding Constructor
        
        //public int Age {get; set;}
        //public DrinksMachine()
        //{
        //    Age = 0;
        //}









        // private member variables
        //private int age;
        //private string make;


        // public properties
        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }
        //    set
        //    {
        //        age = value;
        //    }
        //}
        //public string Make
        //{
        //    get
        //    {
        //        return make;
        //    }
        //    set
        //    {
        //        make = value;
        //    }
        //}

        //// auto-implemented property
        //public string Model { get; set; }

        //// Constructors
        //public DrinksMachine(int age)
        //{
        //    this.Age = age;
        //}
        //public DrinksMachine(string make, string model)
        //{
        //    this.Make = make;
        //    this.Model = model;
        //}
        //public DrinksMachine(int age, string make, string model)
        //{
        //    this.Age = age;
        //    this.Make = make;
        //    this.Model = model;
        //}










        //// Auto-implemented properties 
        //public double TotalPurchases { get; set; }
        //public string Name { get; set; }
        //public int CustomerID { get; set; }
    }
}
