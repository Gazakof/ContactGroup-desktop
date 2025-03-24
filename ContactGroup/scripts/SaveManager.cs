using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ContactGroup
{
    public static class SaveManager
    {
        private const string filePath = "Data.bin";

        public static void Save(List<Group> data)
        {
            FileStream fs = File.Create(filePath);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, data);

            fs.Close();
        }

        public static List<Group> Open()
        {
            List<Group> data = new List<Group>()
            {
                new Group ("Friends"),
                new Group ("Work"),
                new Group ("Family")
            };

            if (File.Exists(filePath))
            {
                FileStream fs = null;
                try
                {
                    fs = File.OpenRead(filePath);
                    BinaryFormatter bf = new BinaryFormatter();
                    data = (List<Group>)bf.Deserialize(fs);
                } 
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }

            return data;
        }
    }
}
