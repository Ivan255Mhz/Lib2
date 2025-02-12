using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Formatting = Newtonsoft.Json.Formatting;

namespace Lib.Class
{
    public static class JsonSaveLoadData
    {



        public static void SaveDataUser(string FilePath, List<User> User)
        {
            string json = JsonConvert.SerializeObject(User, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            File.WriteAllText(FilePath, json);
        }

        public static List<User> LoadDataUser(string FilePath)
        {
            if (!File.Exists(FilePath))
            {
                MessageBox.Show("Файл загрузки не найден","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return new List<User>();
            }

            string json = File.ReadAllText(FilePath);

            List<User> deserializedUsers = JsonConvert.DeserializeObject<List<User>>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });


            return deserializedUsers ?? new List<User>();



        }

        public static void SaveDataBook(string FilePath, List<Book> data)
        {
            
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(FilePath, json);
            

        }

        public static List<Book> LoadDataBook(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Book>>(json);
            }
            return new List<Book>();
        }

    }
}
