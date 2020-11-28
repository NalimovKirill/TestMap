using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Countries
{
    public class CountryData : MonoBehaviour
    {
        private  static List<Country> countries = new List<Country>();
    
        private void Awake()
        {
            countries.Add(new Country
            {
                Name = "Russia", 
                population = 123123,
                square = 23423,
                vvp = 23423,
                CountryType = CountryType.Russia
            });
            countries.Add(new Country
            {
                Name = "USA", 
                population = 123123,
                square = 24,
                vvp = 789,
                CountryType = CountryType.USA
            });
            countries.Add(new Country
            {
                Name = "China", 
                population = 7686,
                square = 8908,
                vvp = 78,
                CountryType = CountryType.China
            });
        }

        public static Country GetCountryByEnum(CountryType i)
        {
            
            foreach (var country in countries)
            {    
            
                if (country.CountryType == i)
                {
                    return country;
                }
            }
            return null;
        }
    }
}
