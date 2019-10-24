using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace Zork.Common
{
    [JsonConverter(typeof(RoomConverter))]
    public class Room : IEquatable<Room>
    {
       [JsonProperty(Order = 1)]
       public string Name { get; private set; }

       [JsonProperty(Order = 2)]
       public string Description { get; private set; }

        [JsonProperty(PropertyName = "Neighbors", Order = 3)]
        private Dictionary<Directions, string> NeighborsNames { get; set; }

        [JsonIgnore]
        public IReadOnlyDictionary<Directions, Room> Neighbors { get; private set; }

        public static bool operator == (Room lhs, Room rhs)
        {
            if(ReferenceEquals(lhs, rhs))
            {
                return true;
            }

            if (lhs is null || rhs is null)
            {
                return false;
            }

            return lhs.Name == rhs.Name;
        }

        public Room() :
            this(string.Empty, string.Empty, new Dictionary<Directions, string>())
        {
        }

        public Room(string name, string description, Dictionary<Directions, string> neighborNames)
        {
            Name = name;
            Description = description;
            NeighborsNames = neighborNames;
            Neighbors = new Dictionary<Directions, Room>();
        }

        public class RoomConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(Room));
​
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                dynamic jsonObject = JObject.Load(reader);
​
            string name = jsonObject["Name"];
                string description = jsonObject["Description"];
                Dictionary<Directions, string> neighborNames = jsonObject["Neighbors"].ToObject<Dictionary<Directions, string>>();
​
            return new Room(name, description, neighborNames);
            }
​
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                Room room = (Room)value;
                JToken neighborNames = JToken.FromObject(room.Neighbors.ToDictionary(pair => pair.Key, pair => pair.Value.Name), serializer);
​
            JObject roomObject = new JObject
            {
                { nameof(Room.Name), room.Name },
                { nameof(Room.Description), room.Description },
                { nameof(Room.Neighbors), neighborNames }
            };
​
            roomObject.WriteTo(writer);
            }
        }


        public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);

        public override bool Equals(object obj) => obj is Room room ? this == room : false;

        public bool Equals(Room other) => this == other;

        public override string ToString() => Name;

        public override int GetHashCode() => Name.GetHashCode();

        public void UpdateNeighbors(World world) => Neighbors = (from entry in NeighborsNames
                                                                 let room = world.RoomsByName.GetValueOrDefault(entry.Value)
                                                                 where room != null
                                                                 select (Direction: entry.Key, Room: room)).ToDictionary(pair => pair.Direction, pair => pair.Room);
    }
}
