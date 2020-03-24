using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Text;
using static LTOKiosk.Class.LTOVehicles;

namespace LTOKiosk.Class
{
    
    public class LTOVehicles : INotifyPropertyChanged
    {
        public Rootobject _rootObject;

        public string id { get; set; }
        public string plate_number { get; set; }
        public string mv_file_number { get; set; }
        public string engine_number { get; set; }
        public string chassis_number { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string cec { get; set; }
        public string coc { get; set; }

       

        public LTOVehicles(string json)
        {
         
            JObject o = JObject.Parse(json);
            JToken value;
            if (o.TryGetValue("vehicle", out value))
            {
                System.Diagnostics.Debug.WriteLine(value);
            }
            if (o.TryGetValue("message", out value))
            {
                System.Diagnostics.Debug.WriteLine(value);
            }
            if (o.TryGetValue("status", out value))
            {
                System.Diagnostics.Debug.WriteLine(value);
            }

            plate_number = (string)o.SelectToken("vehicle[0].plate_number");
            mv_file_number = (string)o.SelectToken("vehicle[0].mv_file_number");
            engine_number = (string)o.SelectToken("vehicle[0].engine_number");
            chassis_number = (string)o.SelectToken("vehicle[0].chassis_number");

            name = (string)o.SelectToken("vehicle[0].owner.name");
            address = (string)o.SelectToken("vehicle[0].owner.address");
            gender = (string)o.SelectToken("vehicle[0].owner.gender");

            cec = (string)o.SelectToken("vehicle[0].cec");
            coc = (string)o.SelectToken("vehicle[0].coc");
        }

        public class Rootobject
        {
            public static Vehicle v;
            public static Owner o;

            public Vehicle[] vehicle { get; set; }
            public string message { get; set; }
            public int status { get; set; }
            
            public Rootobject(string json)
            {
                JObject _o = JObject.Parse(json);

                JsonSerializer vehicleSerializer = new JsonSerializer();
               // v = (Vehicle)vehicleSerializer.Deserialize(new JTokenReader(_o), typeof(Vehicle));


                JsonSerializer ownerSerializer = new JsonSerializer();
                Owner product = new Owner();
                //Serializing to Object
                v = JObject.Parse(json).SelectToken("$.vehicle[?(@.owner)]").ToObject<Vehicle>();

               
            }

            public static Vehicle GetVehicle() {
                return v;
            }

            public static Owner GetOwner()
            {
                return o;
            }


        }

        public class Vehicle
        {
            public string plate_number { get; set; }
            public string mv_file_number { get; set; }
            public string engine_number { get; set; }
            public string chassis_number { get; set; }
            public Owner owner { get; set; }
            public int cec { get; set; }
            public int coc { get; set; }
        }

        public class Owner
        {
            public string name { get; set; }
            public string address { get; set; }
            public string gender { get; set; }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

  



