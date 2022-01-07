using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace InventoryDataManagement
{
    public class ReadInventoryData
    {
        public InventoeyManagementModel Read(String Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    String json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoeyManagementModel>(json);
                }
                catch (Exception e)
                {
                    Console.WriteLine("problem in getting data {0}", e);
                    return null;
                }
            }
        }
    }
}
