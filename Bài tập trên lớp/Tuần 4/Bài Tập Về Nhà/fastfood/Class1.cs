using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_BAI1
{
    class Ban
    {
        private DataTable data = new DataTable();
        private string name;
        public DataTable Data { get => data; set => data = value; }
        public string Name { get => name; set => name = value; }

        public Ban()
        {
            data.Columns.Add("FoodName");
            data.Columns.Add("Quantity", typeof(int));
            data.PrimaryKey = new DataColumn[] { data.Columns["FoodName"] };

        }

        public void Add(string mon)
        {
            DataRow temp = data.Rows.Find(mon);
            if (temp != null) temp["Quantity"] = (int)temp["Quantity"] + 1;
            else
            {
                temp = data.NewRow();
                temp["Quantity"] = 1;
                temp["FoodName"] = mon;
                data.Rows.Add(temp);
            }
        }

        public void Remove(string mon)
        {
            DataRow temp = data.Rows.Find(mon);
            if (temp != null) data.Rows.Remove(temp);
        }
    }

    class BanList
    {
        List<Ban> list = new List<Ban>();
        public int Count { get => list.Count; }

        public Ban this[string ban]
        {
            get
            {
                foreach (Ban x in list)
                {
                    if (String.Compare(x.Name, ban) == 0) return x;
                }
                return Add(ban);
            }

            set
            {
                if (value == null)
                {
                    foreach (Ban x in list.ToList<Ban>())
                    {
                        if (String.Compare(x.Name, ban) == 0)
                        {
                            list.Remove(x);
                        }
                    }
                }
            }
        }


        public bool Find(string name)
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name)) return false;
                foreach (Ban x in list)
            {
                if (String.Compare(x.Name, name) == 0) return true;
            }
            return false;
        }

        private Ban Add(string name)
        {
            Ban x = new Ban();
            x.Name = name;
            list.Add(x);
            return x;
        }

    }
}
