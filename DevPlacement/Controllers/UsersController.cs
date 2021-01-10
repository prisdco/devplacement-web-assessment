using DevPlacement.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace DevPlacement.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        private readonly Random _random = new Random();
        private DataContext context = new DataContext();
        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        [HttpGet]
        [Route("GetUsers")]
        public HttpResponseMessage GetUsers()
        {
            int num = RandomNumber(1, 4);
            
            err err = new err();

            try
            {

                var resp = context.Users.Select(y => new {

                    userID = y.userID,
                    gender = y.gender,
                    name = new
                    {

                        first = y.bioname.first,
                        last = y.bioname.last
                    }
                    ,
                    location = new
                    {
                        street = new
                        {
                            number = y.location.street.number,
                            name = y.location.street.name
                        },
                        city = y.location.city,
                        state = y.location.state,
                        country = y.location.country,
                        postcode = y.location.postcode,
                        cordinates = new
                        {
                            latitude = y.location.coordinates.latitude,
                            longitude = y.location.coordinates.longitude
                        },
                        timezone = new
                        {
                            offset = y.location.timezone.offset,
                            description = y.location.timezone.description
                        }
                    },
                    email = y.email,
                    login = new
                    {
                        uuid = y.login.uuid,
                        username = y.login.username,
                        password = y.login.password,
                        salt = y.login.salt,
                        md5 = y.login.md5,
                        sha1 = y.login.sha1,
                        sha256 = y.login.sha256
                    },
                    dob = new
                    {
                        date = (DateTime?)y.dob.date ?? DateTime.Now,
                        age = y.dob.age
                    },
                    registered = new
                    {
                        date = (DateTime?)y.registered.date ?? DateTime.Now,
                        age = y.registered.age
                    },
                    phone = y.phone,
                    cell = y.cell,
                    pic = new
                    {
                        large = y.picture.large,
                        medium = y.picture.medium,
                        thumbnail = y.picture.thumbnail
                    }

                }).Where(x => x.userID == num).FirstOrDefault();
                if (resp == null)
                {
                    err.status = "Failed";
                    err.message = "Null";
                    string data = JsonConvert.SerializeObject(err);
                    HttpResponseMessage msg = new HttpResponseMessage();
                    msg.StatusCode = HttpStatusCode.BadRequest;
                    msg.Content = new StringContent(data, Encoding.UTF8, "application/json");
                    return msg;
                }
                else
                {
                    
                    //assessment.WaterRate = resp.WaterRate;
                    string data = JsonConvert.SerializeObject(resp);
                    HttpResponseMessage msg = new HttpResponseMessage();
                    msg.StatusCode = HttpStatusCode.OK;
                    msg.Content = new StringContent(data, Encoding.UTF8, "application/json");
                    return msg;

                }

            }
            catch (Exception ex)
            {
                err.status = "Failed";
                err.message = ex.Message;
                string data = JsonConvert.SerializeObject(err);
                HttpResponseMessage msg = new HttpResponseMessage();
                msg.StatusCode = HttpStatusCode.NotFound;
                msg.Content = new StringContent(data, Encoding.UTF8, "application/json");
                return msg;
            }

        }
    }
}