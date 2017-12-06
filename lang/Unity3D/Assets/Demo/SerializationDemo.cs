using System;
using HelloAvro.DTO;
using Newtonsoft.Json;

namespace HelloAvro
{
    /// <summary>
    /// This class demonstrates how to perform just serialization and deserialization in Avro. 
    /// No RPC/IPC related demonstration here.
    /// </summary>
    class SerializationDemo
    {
        public void Run()
        {
            UnityEngine.Debug.Log("Running the Avro serialization demo ...");

            var employee = Helper.CreateEmployee();

            // Serialization
            var bytes = SerializerAvro.Serialize(employee);
            UnityEngine.Debug.Log("Serialized object to " + bytes.Length + " bytes");
            UnityEngine.Debug.Log("Bytes are: " + BitConverter.ToString(bytes));

            // Deserialization
            UnityEngine.Debug.Log("Deserializing bytes back into object ... " + Environment.NewLine);
            var regenerated = SerializerAvro.Deserialize<EmployeeDTO>(bytes);

            // Verification : We compare original object with the object regenerated
            // after passing through a serialize=>deserialize round trip. 
            // We compare the Json equivalent of this object to keep it simple and lazy
            // and don't feel like implementing a proper 'Equals' method
            // FYI, Json usage here has NOTHING to do with Avro serialization 
            var origJson = JsonConvert.SerializeObject(employee);
            var regenJson = JsonConvert.SerializeObject(regenerated);

            if (origJson.Equals(regenJson))
                UnityEngine.Debug.Log("Success. Object through the serialize=>deserialize round trip are identical.");
            else

                UnityEngine.Debug.Log("FAILED! We lost data during the serialize=>deserialize round trip");

            //UnityEngine.Debug.Log(Environment.NewLine + "Press any key to exit ...");
            //Console.ReadLine();
            UnityEngine.Debug.Log(Helper.HorizontalLine);
        }
    }
}
