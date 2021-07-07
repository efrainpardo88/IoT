using Api.REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Api.REST.Services
{
    public class Drones
    {

        private List<Dron> list = JsonConvert.DeserializeObject<List<Dron>>("[{\"id\":1,\"latitud\":14.63571,\"longitud\":121.60617,\"state_id\":3},{\"id\":2,\"latitud\":0.5471811,\"longitud\":-76.1319953,\"state_id\":5},{\"id\":3,\"latitud\":-7.604976,\"longitud\":112.775101,\"state_id\":1},{\"id\":4,\"latitud\":-23.3516191,\"longitud\":43.6854936,\"state_id\":5},{\"id\":5,\"latitud\":38.7908786,\"longitud\":-9.1194989,\"state_id\":4},{\"id\":6,\"latitud\":5.5050681,\"longitud\":-54.0793451,\"state_id\":1},{\"id\":7,\"latitud\":8.8443024,\"longitud\":-79.8548823,\"state_id\":5},{\"id\":8,\"latitud\":11.9313228,\"longitud\":7.413802,\"state_id\":5},{\"id\":9,\"latitud\":54.76778,\"longitud\":42.27111,\"state_id\":3},{\"id\":10,\"latitud\":14.6066438,\"longitud\":104.705431,\"state_id\":2},{\"id\":11,\"latitud\":-6.2836822,\"longitud\":106.590819,\"state_id\":4},{\"id\":12,\"latitud\":51.9034509,\"longitud\":16.955476,\"state_id\":2},{\"id\":13,\"latitud\":25.90348,\"longitud\":116.070449,\"state_id\":5},{\"id\":14,\"latitud\":14.6423905,\"longitud\":120.9575622,\"state_id\":4},{\"id\":15,\"latitud\":19.4520843,\"longitud\":103.1855702,\"state_id\":1},{\"id\":16,\"latitud\":9.258006,\"longitud\":123.281809,\"state_id\":1},{\"id\":17,\"latitud\":11.2666664,\"longitud\":123.7333298,\"state_id\":3},{\"id\":18,\"latitud\":48.3554343,\"longitud\":32.6517581,\"state_id\":2},{\"id\":19,\"latitud\":39.3240601,\"longitud\":-77.3485436,\"state_id\":4},{\"id\":20,\"latitud\":33.7654607,\"longitud\":-84.38709,\"state_id\":1}]");

        public List<Dron> GetAllDrones()
        {
            return list;
        }

        public Dron MoveDronToStoreProducts()
        {
            return list.FirstOrDefault(item => item.id == 1);
        }
    }
}
