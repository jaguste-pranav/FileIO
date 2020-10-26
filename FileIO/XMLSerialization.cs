using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
namespace FileIODemo
{
    class XMLSerialization
    {
        public void SerializeXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"C:\Users\Gharat\source\repos\Sample\sample2.txt", FileMode.Create);
            OrderForm orderForm = new OrderForm();
            DateTime dt = new DateTime(2020, 10, 26);
            orderForm.OrderDate = dt;
            ser.Serialize(fileStream, orderForm);
        }
        public void DeserializeXml()
        {
            XmlSerializer deserialiser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"C:\Users\Gharat\source\repos\Sample\sample2.txt", FileMode.Create);
            object obj = deserialiser.Deserialize(fileStream);
        }
    }
    public class OrderForm
    {
        public DateTime OrderDate;
    }
}