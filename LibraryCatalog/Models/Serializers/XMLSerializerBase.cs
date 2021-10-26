using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace LibraryCatalog.Models.Serializers
{
    public abstract class XMLSerializerBase<T>
    {
        protected string _filename;
        public virtual object Data { get; set; }
        public XMLSerializerBase()
        {
            _filename = Directory.GetCurrentDirectory().Replace("bin\\Debug\\net5.0-windows", "Data\\XML\\");
            UpdateFile();
            if(Data==null)
            {
                GetData();
            }
        }
        public XMLSerializerBase(object data)
        {
            _filename = Directory.GetCurrentDirectory().Replace("bin\\Debug\\net5.0-windows", "Data\\XML\\");
            UpdateFile();
            Data = data;
            Save();
        }
        //protected abstract void InitDefaults();
        public virtual void GetData()
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            if (File.Exists(_filename))
            {
                using (Stream reader = new FileStream(_filename, FileMode.Open))
                {
                    try
                    {
                        Data = (T)ser.Deserialize(reader);
                    }
                    catch (Exception e)
                    {
                        //MessageBox.Show($"AspectsMapSerializer :GetData => {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        public virtual void Save()
        {
            try
            {
                var xmlWriterSettings = new XmlWriterSettings() { Indent = true, Encoding = Encoding.Unicode, NewLineHandling = NewLineHandling.Entitize };
                XmlSerializer ser = new XmlSerializer(typeof(T));
                using (XmlWriter writer = XmlWriter.Create(_filename, xmlWriterSettings))
                {
                    ser.Serialize(writer, Data);
                    writer.Close();
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show($"AspectsMapSerializer: Save => {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
        protected abstract void UpdateFile();      

    }
}
