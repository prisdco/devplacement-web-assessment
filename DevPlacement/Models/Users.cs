using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevPlacement.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class BioName
    {
        [Key]
        public int nameID { get; set; }
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public int userID { get; set; }

        public users users { get; set; }
    }

    public class Street
    {
        [Key]
        public int streetID { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public int locID { get; set; }

        public Location Location { get; set; }
    }

    public class Coordinates
    {
        [Key]
        public int corID { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public int locID { get; set; }

        public Location Location { get; set; }
    }

    public class Timezone
    {
        [Key]
        public int tzID { get; set; }
        public string offset { get; set; }
        public string description { get; set; }
        public int locID { get; set; }
        public Location Location { get; set; }
    }

    public class Location
    {
        [Key]
        public int locID { get; set; }
        public Street street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public int postcode { get; set; }
        public int userID { get; set; }
        public Coordinates coordinates { get; set; }
        public Timezone timezone { get; set; }

        public users users { get; set; }
    }

    public class Login
    {
        [Key]
        public int lgID { get; set; }
        public string uuid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }
        public int userID { get; set; }

        public users users { get; set; }
    }

    public class Dob
    {
        [Key]
        public int dobID { get; set; }
        public DateTime date { get; set; }
        public int age { get; set; }
        public int userID { get; set; }

        public users users { get; set; }
    }

    public class Registered
    {
        [Key]
        public int regID { get; set; }
        public DateTime date { get; set; }
        public int age { get; set; }
        public int userID { get; set; }

        public users users { get; set; }
    }

    public class Id
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string value { get; set; }

        public users users { get; set; }
    }

    public class Picture
    {
        [Key]
        public int picID { get; set; }
        public string large { get; set; }
        public string medium { get; set; }
        public string thumbnail { get; set; }
        public int userID { get; set; }

        public users users { get; set; }
    }

    public class users
    {
        [Key]
        public int userID { get; set; }
        public string gender { get; set; }
        public virtual BioName bioname { get; set; }
        public Location location { get; set; }
        public string email { get; set; }
        public Login login { get; set; }
        public Dob dob { get; set; }
        public Registered registered { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public Id id { get; set; }
        public Picture picture { get; set; }
        public string nat { get; set; }
    }

    public class Info
    {
        public string seed { get; set; }
        public int results { get; set; }
        public int page { get; set; }
        public string version { get; set; }
    }

    public class err
    { 
        public string status { get; set; }
        public string message { get; set; }
    }
}