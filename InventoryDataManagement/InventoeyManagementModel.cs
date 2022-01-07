using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataManagement
{
    public class InventoeyManagementModel
    {
        public List<Rice> Rice;
        public List<Pulses> Pulses;
        public List<Wheat> Wheat;
    }
    public class Rice
    {
        public String name;
        public int weight;
        public int price;
    }
    public class Pulses
    {
        public String name;
        public int weight;
        public int price;
    }
    public class Wheat
    {
        public String name;
        public int weight;
        public int price;
    }
}
