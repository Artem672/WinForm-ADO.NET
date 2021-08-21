using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EventPlanner
{
    class SaveFile
    {
        public void SerializeJson(List<Event> events, string folderPath)
        {
            var json = JsonConvert.SerializeObject(events, Formatting.Indented);
            var fileName = DateTime.Now.Year.ToString() + '_' + DateTime.Now.Month.ToString() + '_' + DateTime.Now.Day.ToString() + ".json";
            var fullPath = folderPath + '/' + fileName;
            File.Create(fullPath).Close();
            File.WriteAllText(fullPath, json);
        }
        public void SerializeXML(List<Event> events, string folderPath)
        {
            var xml = new XmlSerializer(typeof(List<Event>));
            var fileName = DateTime.Now.Year.ToString() + '_' + DateTime.Now.Month.ToString() + '_' + DateTime.Now.Day.ToString() + ".xml";
            var fullPath = folderPath + '/' + fileName;
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
            using (var fs = new FileStream(fullPath, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, events);
            }
        }
        public List<Event> DeserializeJson(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Event>>(json);
        }
        public List<Event> DeserializeXML(string filePath)
        {
            var xml = new XmlSerializer(typeof(List<Event>));
            using (var fs = new FileStream(filePath,FileMode.OpenOrCreate))
            {
                return (List<Event>)xml.Deserialize(fs);
            }
        }
    }
}
