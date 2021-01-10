using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DevPlacement.Models
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<users> user = new List<users>
            {
                new users { gender = "Male", phone = "08037002523", email = "prisdco@gmail.com", cell = "0904512333", nat = "NG" },

                new users { gender = "Male", phone = "08035712523", email = "bola@gmail.com", cell = "09012597733", nat = "NG" },

                new users { gender = "Female", phone = "08052112523", email = "titi@gmail.com", cell = "09027200733", nat = "NG" },

                new users { gender = "Female", phone = "08099112523", email = "olamide@gmail.com", cell = "09021067833", nat = "NG" }
            };

            user.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            List<Location> loc = new List<Location>
            {
                new Location { locID = 1, city = "Abuja", country = "Nigeria", postcode = 900001, state = "FCT Abuja",  userID = 1 },
                new Location { locID = 2, city = "Ibadan", country = "Nigeria", postcode = 32001, state = "Oyo", userID = 2 },
                new Location { locID = 3, city = "Osun", country = "Nigeria", postcode = 902101, state = "Osogbo", userID = 3 },
                new Location { locID = 4, city = "Lagos", country = "Nigeria", postcode = 310201, state = "Lagos", userID = 4 }
            };
            loc.ForEach(s => context.Locations.Add(s));
            context.SaveChanges();

            List<BioName> bioname = new List<BioName>
            {
                new BioName { nameID = 1, first = "Oluwafemi", last = "Ölajire", title = "Mr", userID = 1 },
                new BioName { nameID = 2, first = "Bolarinwa", last = "Ayodeji", title = "Mr", userID = 2 },
                new BioName { nameID = 3, first = "Titi", last = "Asegun", title = "Mr", userID = 3 },
                new BioName { nameID = 4, first = "Olamide", last = "Olatunji", title = "Mr", userID = 4 }
            };
            bioname.ForEach(s => context.BioNames.Add(s));
            context.SaveChanges();
            List<Street> street = new List<Street>
            {
                new Street { streetID = 1, name = "Aco estate", number = 100, locID = 1 },
                new Street { streetID = 2, name = "Adrain street", number = 200, locID = 2 },
                new Street { streetID = 3, name = "Ring road", number = 300, locID = 3 },
                new Street { streetID = 4, name = "Ikeja", number = 400, locID = 4 }
            };
            street.ForEach(s => context.Streets.Add(s));
            context.SaveChanges();

            List<Login> login = new List<Login>
            {
                new Login { lgID = 1, md5 = "7e1e4d80edc6b63cc54db6f1d9f5abeb", password = "aubrey", salt = "BYDKgkRe", sha1 = "f47d2093bf36846cbfa216f5b421a9e29a0cd57b", sha256 = "560248c718971f69c654411c23d54c2c3b3ac40c3c12861243741634fd9df309", username = "Oluwafemi", uuid = "b0e6b21c-7d79-412b-913a-5edff66db77a", userID = 1 },
                new Login { lgID = 2, md5 = "7e1e4d80edc6b63cc54db6f1d9f5abab", password = "aubrey", salt = "BYDKgkRe", sha1 = "f47d2093bf36846cbfa216f5b421a9e29a0cd57c", sha256 = "560248c718971f69c654411c23d54c2c3b3ac40c3c12861243741634fd9df319", username = "Bolarinwa", uuid = "b0e6b21c-7d79-412b-913a-5edff66db78a", userID = 2 },
                new Login { lgID = 3, md5 = "7e1e4d80edc6b63cc54db6f1d9f5abbb", password = "aubrey", salt = "BYDKgkRe", sha1 = "f47d2093bf36846cbfa216f5b421a9e29a0cd57c", sha256 = "560248c718971f69c654411c23d54c2c3b3ac40c3c12861243741634fd9df329", username = "Titi", uuid = "b0e6b21c-7d79-412b-913a-5edff66db79a", userID = 3 },
                new Login { lgID = 4, md5 = "7e1e4d80edc6b63cc54db6f1d9f5abcb", password = "aubrey", salt = "BYDKgkRe", sha1 = "f47d2093bf36846cbfa216f5b421a9e29a0cd57c", sha256 = "560248c718971f69c654411c23d54c2c3b3ac40c3c12861243741634fd9df339", username = "Olamide", uuid = "b0e6b21c-7d79-412b-913a-5edff66db71a", userID = 4 }
            };
            login.ForEach(s => context.Logins.Add(s));
            context.SaveChanges();

            List<Dob> dob = new List<Dob>
            {
                new Dob { dobID = 1, age = 28, date = DateTime.Now, userID = 1 },
                new Dob { dobID = 2, age = 31, date = DateTime.Now, userID = 2 },
                new Dob { dobID = 3, age = 21, date = DateTime.Now, userID = 3 },
                new Dob { dobID = 4, age = 20, date = DateTime.Now, userID = 4 }
            };
            dob.ForEach(s => context.Dobs.Add(s));
            context.SaveChanges();

            List<Timezone> tz = new List<Timezone>
            {
                new Timezone { tzID = 1, description = "Avans, dens", offset = "+9:10", locID = 1 },
                new Timezone { tzID = 2, description = "Obasanjo, star", offset = "+9:11", locID = 2 },
                new Timezone { tzID = 3, description = "Evans, vye", offset = "+9:12", locID = 3 },
                new Timezone { tzID = 4, description = "Mario, dress", offset = "+9:13", locID = 4 }
            };
            tz.ForEach(s => context.Timezones.Add(s));
            context.SaveChanges();

            List<Coordinates> cord = new List<Coordinates>
            {
                new Coordinates { corID = 1, latitude = "-58.9001", longitude = "-121.9118", locID = 1 },
                new Coordinates { corID = 2, latitude = "-66.1111", longitude = "-138.8777", locID = 2 },
                new Coordinates { corID = 3, latitude = "-21.9021", longitude = "-182.2100", locID = 3 },
                new Coordinates { corID = 4, latitude = "-68.9101", longitude = "-121.9191", locID = 4 }
            };
            cord.ForEach(s => context.Coordinates.Add(s));
            context.SaveChanges();

            List<Picture> pic = new List<Picture>
            {
                new Picture { picID = 1, large = "https://randomuser.me/api/portraits/men/96.jpg", medium = "https://randomuser.me/api/portraits/med/men/96.jpg", thumbnail = "https://randomuser.me/api/portraits/thumb/men/96.jpg", userID = 1 },
                new Picture { picID = 2, large = "https://randomuser.me/api/portraits/men/96.jpg", medium = "https://randomuser.me/api/portraits/med/men/96.jpg", thumbnail = "https://randomuser.me/api/portraits/thumb/men/96.jpg", userID = 2 },
                new Picture { picID = 3, large = "https://randomuser.me/api/portraits/men/96.jpg", medium = "https://randomuser.me/api/portraits/med/men/96.jpg", thumbnail = "https://randomuser.me/api/portraits/thumb/men/96.jpg", userID = 3 },
                new Picture { picID = 4, large = "https://randomuser.me/api/portraits/men/96.jpg", medium = "https://randomuser.me/api/portraits/med/men/96.jpg", thumbnail = "https://randomuser.me/api/portraits/thumb/men/96.jpg", userID = 4 }
            };
            pic.ForEach(s => context.Pictures.Add(s));
            context.SaveChanges();

            List<Registered> reg = new List<Registered>
            {
                new Registered { regID = 1, age = 28, date = DateTime.Now, userID = 1 },
                new Registered { regID = 2, age = 31, date = DateTime.Now, userID = 2 },
                new Registered { regID = 3, age = 21, date = DateTime.Now, userID = 3 },
                new Registered { regID = 4, age = 20, date = DateTime.Now, userID = 4 }
            };
            reg.ForEach(s => context.Registereds.Add(s));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}