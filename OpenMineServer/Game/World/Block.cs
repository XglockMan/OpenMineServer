namespace OpenMineServer.Game.World
{
    public class Block
    {

        private Material _material;
        private Location _location;

        public Block(Location location)
        {
            _material = Material.Strone;
            _location = location;
        }



    }
}