using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace vCard
{
    public class RandomUserDeserializer
    {
        public VCard Deserialize(string json)
        {
            var data = JObject.Parse(json)["results"][0];
            return new VCard
            {
                Id = (string)data["login"]["uuid"],
                Firstname = (string)data["name"]["first"],
                Surname = (string)data["name"]["last"],
                Email = (string)data["email"],
                Phone = (string)data["phone"],
                Country = (string)data["location"]["country"],
                City = (string)data["location"]["city"]
            };
        }
    }

}
