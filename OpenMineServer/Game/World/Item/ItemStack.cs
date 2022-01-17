using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMineServer.Game.World.Item
{
    internal class ItemStack
    {

        private int _maxStackSize = 128;

        private int _count;
        Material _material;
        private ItemMeta _meta;

        public ItemStack()
        {
            _count = 1;
            _material = Material.Stone;
            _meta = new ItemMeta();
        }

        public ItemStack(Material material) : this()
        {
            _material = material;
        }

        public ItemStack(Material material, int count, ItemMeta meta)
        {
            _material = material;
            _count = count;
            _meta = meta;
        }

        public void SetCount(int count)
        {
            if (count <= _maxStackSize)
            {
                _count = count;
            }
        }

        public int GetCount()
        {
            return _count;
        }
    }
}