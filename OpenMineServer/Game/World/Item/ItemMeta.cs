using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMineServer.Game.World.Item
{
    public class ItemMeta
    {

        private string _title;
        private IList<string> _description;
        private string _name;

        public ItemMeta()
        {
            _title = "";
            _name = "";
            _description = new List<string>();
        }

        public ItemMeta(string name, string title, IList<string> description)
        {
            _name = name;
            _title = title;
            _description = description;
        }
    }
}
