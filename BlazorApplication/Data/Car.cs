using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApplication.Data
{
    public enum EnumKind
    {
        Diesel,
        [Display(Name = "Development progress")]
        Petrol,
        Petrol_LPG,
    }
    public enum EnumState
    {
        [Display(Name = "State")]
        New,
        Used,
    }
    public class Car
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Year of production is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime YearOfProduction { get; set; }
        [Range(10000, 99999999, ErrorMessage = "Price can not be less than 10000")]
        public decimal Price { get; set; }
        public string Img { get; set; }
        [StringLength(20, ErrorMessage = "Model can not be longer than 20 chars")]
        public string Model { get; set; }
        public EnumKind TypeOfFuel { get; set; }
        public EnumState State { get; set; }
        [Range(100, 999999999, ErrorMessage = "Milage can not be less than 10000")]
        public int Mileage { get; set; }
        public Car()
        {

        }
        public Car(int id, string name, DateTime yearOfProduction, decimal price, string img, string model, EnumKind typeOfFuel,
        EnumState state, int mileage)
        {
            this.Id = id;
            this.Name = name;
            this.YearOfProduction = yearOfProduction;
            this.Img = img;
            this.Model = model;
            this.TypeOfFuel = typeOfFuel;
            this.State = state;
            this.Mileage = mileage;
        }
    }
    //public class CarModel
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

}
