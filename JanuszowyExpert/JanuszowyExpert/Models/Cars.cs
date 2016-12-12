using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuszowyExpert.Models
{
    public class Cars
    {


        public string Country;
        public string Mark;
        public string Model;
        public string Series;
        public string Body;
        public string FuelType;
        public int YearOfproduction;
        public int Miliage;
        public int EngineCapacity;
        public int Power;
        public string LocationPhotos;
        public bool Status;

        private Cars(string country, string mark, string model, string series, string body, string fueltype, int yearofproduction, int miliage, int enginecapacity, int power, string locationphotos, bool status)
        {
            this.Country = country;
            this.Mark = mark;
            this.Model = model;
            this.Series = series;
            this.Body = body;
            this.FuelType = fueltype;
            this.YearOfproduction = yearofproduction;
            this.Miliage = miliage;
            this.EngineCapacity = enginecapacity;
            this.Power = power;
            this.LocationPhotos = locationphotos;
            this.Status = status;

        }

        public static void AddCarsToList(List<Cars> ListOfCars)
        {

            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A4", "B6", "Sedan", "Benzyna", 2003, 268000, 2200, 174, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A4", "B6", "Sedan", "Benzyna", 2003, 111000, 2200, 174, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A3", "B6", "Hatchback", "Benzyna", 2003, 111000, 2800, 250, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A3", "B6", "Hatchback", "Benzyna", 2003, 175000, 2800, 250, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A3", "B6", "Hatchback", "Benzyna", 2005, 175000, 2800, 250, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A3", "B6", "Hatchback", "Benzyna", 2005, 145000, 2800, 250, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A3", "B6", "Hatchback", "Diesel", 2003, 102000, 1900, 250, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A4", "B6", "Kombi", "Benzyna", 2003, 111000, 2800, 250, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A4", "B6", "Kombi", "Benzyna", 2003, 185000, 2800, 250, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A4", "B6", "Sedan", "Diesel", 2003, 268000, 1900, 145, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A4", "B6", "Kombi", "Diesel", 2003, 146000, 1900, 145, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A4", "B6", "Kombi", "Diesel", 2005, 179000, 4200, 220, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A4", "B8", "Sedan", "Benzyna", 2009, 173000, 2500, 250, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A4", "B8", "Kombi", "Diesel", 2012, 200000, 3500, 220, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A6", "C7", "Sedan", "Benzyna", 2012, 120000, 1800, 177, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A6", "C5", "Kombi", "Diesel", 2009, 125000, 2000, 179, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q3", "I", "SUV", "Diesel", 2011, 156000, 2000, 170, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q3", "I", "SUV", "Diesel", 2015, 74000, 2000, 170, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q5", "I", "SUV", "Benzyna", 2012, 114000, 2000, 225, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q5", "I", "SUV", "Benzyna", 2013, 114000, 3000, 272, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q5", "I", "SUV", "Diesel", 2014, 98000, 3000, 245, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q7", "I", "SUV", "Benzyna", 2005, 287000, 6000, 500, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q7", "II", "SUV", "Diesel", 2015, 125000, 3000, 272, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "X5", "E70", "SUV", "Benzyna", 2003, 140000, 3000, 272, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "X5", "E70", "SUV", "Benzyna", 2003, 185600, 3000, 272, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "X5", "E70", "SUV", "Benzyna", 2006, 156000, 3000, 272, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "X5", "E70", "SUV", "Benzyna", 2006, 128000, 3000, 272, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "X6", "E71", "SUV", "Benzyna", 2008, 120000, 5000, 408, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "X5", "E70", "SUV", "Diesel", 2006, 128000, 3000, 272, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "X6", "E71", "SUV", "Diesel", 2008, 120000, 5000, 408, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "X5", "E70", "SUV", "Diesel", 2011, 185000, 2400, 200, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "X6", "E71", "SUV", "Diesel", 2011, 162000, 5000, 300, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "X5", "E70", "SUV", "Diesel", 2011, 128000, 2400, 200, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "X6", "E71", "SUV", "Diesel", 2011, 120000, 5000, 300, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "F10", "Seria 5", "Sedan", "Benzyna", 2012, 187000, 2300, 204, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "F10", "Seria 5", "Sedan", "Benzyna", 2014, 140000, 2300, 204, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "F10", "Seria 5", "Kombi", "Benzyna", 2013, 78000, 2300, 204, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E36", "Seria 3", "Kombi", "Benzyna", 1993, 203000, 2000, 170, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E36", "Seria 3", "Coupe", "Benzyna", 1996, 189000, 2500, 192, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E46", "Seria 3", "Kombi", "Benzyna", 2002, 189000, 2300, 170, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E46", "Seria 3", "Sedan", "Benzyna", 2005, 152000, 2500, 193, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E46", "Seria 3", "Kombi", "Diesel", 2002, 125000, 3000, 210, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E46", "Seria 3", "Sedan", "Diesel", 2003, 125000, 2100, 140, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E36", "Seria 3", "Kombi", "Benzyna", 1993, 203000, 2000, 170, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E36", "Seria 3", "Coupe", "Benzyna", 1996, 189000, 2500, 192, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E36", "Seria 3", "Coupe", "Benzyna", 1996, 189000, 2500, 192, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E36", "Seria 3", "Coupe", "Benzyna", 1996, 125000, 2500, 192, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E36", "Seria 3", "Coupe", "Benzyna", 1996, 125000, 3000, 220, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E36", "Seria 3", "Coupe", "Benzyna", 1996, 189000, 3000, 220, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E46", "Seria 3", "Kombi", "Benzyna", 2002, 189000, 2300, 170, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E46", "Seria 3", "Kombi", "Benzyna", 2002, 145000, 2300, 170, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E46", "Seria 3", "Kombi", "Benzyna", 2002, 189000, 3000, 220, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E46", "Seria 3", "Sedan", "Benzyna", 2005, 152000, 2500, 193, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Seicento", "Hobby", "Hatchback", "Benzyna", 1999, 244000, 900, 38, "Fiat Seicento 900.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Seicento", "Hobby", "Hatchback", "Benzyna", 1999, 74000, 900, 38, "Fiat Seicento 900.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Seicento", "Active", "Hatchback", "Benzyna", 2005, 189000, 1100, 54, "Fiat Seicento 1100.JPG", true));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Panda", "II", "Hatchback", "Benzyna", 2005, 150000, 1200, 60, "Fiat Panda II.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Punto", "II typ 188", "Hatchback", "Diesel", 2008, 165000, 1900, 80, "Fiat Punto II.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA H", "Classic III", "Hatchback", "Benzyna", 2001, 100000, 1400, 90, "Opel Astra H Hatchback.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA H", "Classic III", "Hatchback", "Benzyna", 2004, 188000, 1400, 90, "Opel Astra H Hatchback.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA H", "Classic III", "Kombi", "Diesel", 2007, 168000, 1700, 110, "Opel Astra H Kombi.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA J", "IV", "Sedan", "Diesel", 2007, 138000, 1600, 136, "Opel Astra J Sedan.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA J", "IV", "Hatchback", "Diesel", 2007, 138000, 1600, 136, "Opel Astra J Sedan.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA J", "IV", "Kombi", "Benzyna", 2007, 188000, 2400, 236, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA K", "V", "Hatchback", "Diesel", 2015, 72000, 1600, 136, "Opel Astra K Hatchback.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA K", "V", "Hatchback", "Benzyna", 2016, 56000, 1600, 200, "Opel Astra K Hatchback.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA J", "IV", "Sedan", "Benzyna", 2007, 138000, 1600, 136, "Opel Astra J Sedan.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W210", "E200", "Sedan", "Benzyna", 1995, 456000, 2000, 136, "Mercedes W210 E200.JPG", true));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W210", "E200", "Sedan", "Benzyna", 1995, 125000, 2000, 136, "Mercedes W210 E200.JPG", true));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W210", "E300", "Sedan", "Benzyna", 1995, 456000, 3000, 136, "Mercedes W210 E200.JPG", true));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W210", "E300", "Sedan", "Benzyna", 1995, 125000, 3000, 136, "Mercedes W210 E200.JPG", true));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W220", "S600", "Sedan", "Benzyna", 2002, 264000, 5800, 367, "Mercedes W220 S600.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W220", "S600", "Sedan", "Diesel", 2002, 135000, 4600, 287, "Mercedes W220 S600.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W220", "S600", "Sedan", "Diesel", 2002, 135000, 2400, 287, "Mercedes W220 S600.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W220", "S600", "Sedan", "Diesel", 2003, 175000, 2400, 287, "Mercedes W220 S600.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W220", "S600", "Sedan", "Benzyna", 2002, 264000, 5800, 367, "Mercedes W220 S600.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W220", "S600", "Sedan", "Diesel", 2002, 135000, 4600, 287, "Mercedes W220 S600.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q3", "I", "SUV", "Diesel", 2011, 156000, 2900, 170, "Audi Q3 2011.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q3", "I", "SUV", "Diesel", 2011, 156000, 2000, 170, "Audi Q3 2011.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q5", "I", "SUV", "Benzyna", 2012, 114000, 2000, 225, "Audi Q5 2012.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q5", "I", "SUV", "Benzyna", 2013, 106000, 3000, 272, "Audi Q5 2012.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q5", "I", "SUV", "Diesel", 2014, 98000, 3000, 245, "Audi Q5 2012.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q7", "I", "SUV", "Benzyna", 2005, 186000, 6000, 500, "Audi Q7 2005.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q7", "II", "SUV", "Diesel", 2015, 125000, 3000, 272, "Audi Q7 2005.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "Q7", "II", "SUV", "Diesel", 2015, 205000, 3000, 272, "Audi Q7 2005.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "X5", "E70", "SUV", "Benzyna", 2007, 156000, 3000, 272, "BMW X5 2006.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "X6", "E71", "SUV", "Benzyna", 2008, 120000, 5000, 408, "BMW X6 2008.jpg", true));
            ListOfCars.Add(new Cars("Pozostałe", "CITROEN", "Xsara", "Picasso", "Minivan", "Benzyna", 1998, 268000, 1800, 115, "Citroen Xsara Picasso.jpg", true));
            ListOfCars.Add(new Cars("Pozostałe", "CITROEN", "Xsara", "Picasso", "Minivan", "Diesel", 1999, 140000, 1600, 92, "Citroen Xsara Picasso.jpg", true));
            ListOfCars.Add(new Cars("Pozostałe", "DAEWOO", "Nubira", "I", "Kombi", "Benzyna", 1999, 224000, 1600, 106, "Daewoo Nubira I Kombi.jpg", true));
            ListOfCars.Add(new Cars("Pozostałe", "DAEWOO", "Nubira", "II", "Sedan", "Benzyna", 2002, 184000, 2000, 133, "Daewoo Nubira II Sedan.jpg", true));
            ListOfCars.Add(new Cars("Pozostałe", "DAEWOO", "Nubira", "I", "Kombi", "Benzyna", 1999, 145000, 1600, 106, "Daewoo Nubira I Kombi.jpg", true));
            ListOfCars.Add(new Cars("Pozostałe", "DAEWOO", "Nubira", "II", "Sedan", "Benzyna", 2002, 136000, 2000, 133, "Daewoo Nubira II Sedan.jpg", true));
            ListOfCars.Add(new Cars("Pozostałe", "SAAB", "9-5", "YS3E", "Sedan", "Benzyna", 1998, 354000, 2000, 150, "Saab 9-5 Sedan.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "Giulietta", "Progression", "Hatchback", "Diesel", 2011, 156000, 1600, 105, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "Giulietta", "Progression", "Hatchback", "Diesel", 2010, 156000, 1600, 105, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "Giulietta", "Progression", "Hatchback", "Diesel", 2010, 156000, 2600, 205, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "Giulietta", "Distinctive", "Hatchback", "Benzyna", 2011, 134000, 1750, 240, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "Giulietta", "Quadrifoglio Verde", "Hatchback", "Benzyna", 2015, 78600, 1400, 170, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "MiTo", "Progression", "Hatchback", "Diesel", 2008, 167000, 1300, 95, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "MiTo", "Progression", "Hatchback", "Diesel", 2008, 167000, 3300, 295, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "MiTo", "Distinctive", "Hatchback", "Benzyna", 2012, 124000, 1400, 105, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "MiTo", "Impression", "Hatchback", "Benzyna", 2014, 800000, 1400, 170, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "159", "Progression", "Hatchback", "Diesel", 2008, 167000, 1300, 95, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "159", "Distinctive", "Hatchback", "Benzyna", 2012, 124000, 1400, 105, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "156", "I", "Sedan", "Benzyna", 1997, 189600, 2000, 155, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "156", "I", "Sedan", "Diesel", 2001, 168000, 2400, 150, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "156", "I", "Sedan", "Benzyna", 1997, 122000, 2000, 155, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "156", "I", "Sedan", "Diesel", 2001, 133000, 2400, 150, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "156", "I", "Sedan", "Benzyna", 1997, 189600, 2600, 155, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "156", "I", "Sedan", "Diesel", 2001, 168000, 2700, 150, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "156", "I", "Sedan", "Benzyna", 1997, 122000, 2600, 155, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "156", "I", "Sedan", "Diesel", 2001, 133000, 2700, 150, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "156", "I", "Kombi", "Benzyna", 2004, 155000, 2500, 190, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "ALFA ROMEO", "156", "I", "Sedan", "Diesel", 2006, 135000, 2600, 140, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Panda", "II", "Hatchback", "Benzyna", 2005, 150000, 1200, 60, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Punto", "II typ 188", "Hatchback", "Benzyna", 2003, 88000, 1800, 104, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Punto", "II typ 188", "Hatchback", "Diesel", 1998, 198000, 1900, 80, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Punto", "Grande", "Hatchback", "Diesel", 2010, 102000, 1900, 80, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Punto", "Grande", "Hatchback", "Diesel", 2010, 172000, 1900, 100, "test.jpg", true));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Punto", "Grande", "Hatchback", "Diesel", 2008, 145000, 1900, 80, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA H", "Classic III", "Hatchback", "Benzyna", 2004, 178000, 1400, 90, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA H", "Classic III", "Kombi", "Diesel", 2007, 178000, 1700, 110, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA J", "IV", "Sedan", "Diesel", 2007, 178000, 1600, 136, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA J", "IV", "Sedan", "Diesel", 20010, 178000, 2700, 196, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA K", "V", "Hatchback", "Diesel", 2015, 72000, 1600, 136, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA K", "V", "Hatchback", "Diesel", 2015, 72000, 2600, 236, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA K", "V", "Hatchback", "Benzyna", 2016, 56000, 1600, 200, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W210", "E200", "Sedan", "Benzyna", 1995, 456000, 2000, 136, "test.jpg", true));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W220", "S600", "Sedan", "Benzyna", 2002, 264000, 5800, 367, "test.jpg", true));
            ListOfCars.Add(new Cars("Pozostałe", "SAAB", "9-5", "YS3E", "Sedan", "Benzyna", 1998, 354000, 2000, 150, "test.jpg", true));
            ListOfCars.Add(new Cars("Pozostałe", "SAAB", "9-5", "YS3E", "Sedan", "Benzyna", 1998, 125000, 2800, 200, "test.jpg", true));
            ListOfCars.Add(new Cars("Pozostałe", "SAAB", "9-5", "YS3E", "Kombi", "Benzyna", 1998, 354000, 2000, 150, "test.jpg", true));
            ListOfCars.Add(new Cars("Pozostałe", "SAAB", "9-5", "YS3E", "Kombi", "Benzyna", 1998, 125000, 2800, 200, "test.jpg", true));
        }

        public Cars()
        {

        }




    }




}
