using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Nodes;

namespace ClassLibrary
{
    public class UserResultStorage
    {
        private static string path = "userResults.json";
        public static void Append(User user)
        {
            var usersResults = GetUserResults();
            usersResults.Add(user);
            Save(usersResults);
        }


        public static List<User> GetUserResults()
        {
            if (!FileProvider.Exists(path))
            {
                return new List<User>();
            }
            var value = FileProvider.GetValue(path);
            var userResults = JsonConvert.DeserializeObject<List<User>>(value);
            return userResults;

        }

        public static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace(path, jsonData);
        }


    }
}


