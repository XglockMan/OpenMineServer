namespace OpenMineServer.Game.World
{
    public class Block
    {
        private Material _material;
        private Location _location;

        public Block(Location location)
        {
            _material = Material.Stone;
            _location = location;
        }

        public Material Material => _material;
        public Location Location => _location;
    }
}