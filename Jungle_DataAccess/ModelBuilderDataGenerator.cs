using Jungle_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess
{
    public static class ModelBuilderDataGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {
            #region Travel
            builder.Entity<Travel>().HasData(new Travel() { Id = 1, Name = "France", Description = "Voyage en france", Price = 1200.99, DepartureDate = DateTime.Now.AddDays(21), Duration = 3200, Destination_Id = 1, Guide_Id = 1, TravelRecommendation_Id = 1 });
            builder.Entity<Travel>().HasData(new Travel() { Id = 2, Name = "Égypte", Description = "Voyage en égypte", Price = 1528.99, DepartureDate = DateTime.Now.AddDays(9), Duration = 3200, Destination_Id = 1, Guide_Id = 1, TravelRecommendation_Id = 1 });
            builder.Entity<Travel>().HasData(new Travel() { Id = 3, Name = "Afrique", Description = "Voyage en Afrique", Price = 999.99, DepartureDate = DateTime.Now.AddDays(14), Duration = 3200, Destination_Id = 1, Guide_Id = 1, TravelRecommendation_Id = 1 });
            #endregion

            #region Destination
            builder.Entity<Destination>().HasData(new Destination() { Id = 1, Country_Id = 1, Name = "Tour Effiel", Region = "Paris" });
            #endregion

            #region Guide
            builder.Entity<Guide>().HasData(new Guide() { Id = 1,Speciality = "Avec les parisien",FirstName = "Jean",LastName = "Pierre"});
            #endregion

            #region TravelRecommendation
            builder.Entity<TravelRecommendation>().HasData(new TravelRecommendation(){Id = 1,DangerLevel = "5",Type = "Social",Description = "Les parisien peuvent être impatient"});
            #endregion
            #region Country
            builder.Entity<Country>().HasData(new Country() { Id = 1, Name = "France" });
            #endregion
        }
    }
}
