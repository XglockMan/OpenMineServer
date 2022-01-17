using System;

namespace OpenMineServer.Game.World
{
    public class Location
    {
        private int _x;
        private int _y;
        private int _z;
        private Chunk _chunk;
        private World _world;

        public Location(World world, Chunk chunk, int x, int y, int z)
        {
            _chunk = chunk;
            _world = world;
            _x = x;
            _z = z;
            _y = y;
        }

        public void Move(MoveDirection direction, int count)
        {
            switch (direction)
            {
                case MoveDirection.X:
                    _x += count;
                    break;
                case MoveDirection.Y:
                    _y += count;
                    break;
                case MoveDirection.Z:
                    _z += count;
                    break;
                default:
                    throw new Exception();
            }
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }

        public int GetZ()
        {
            return _z;
        }

    }

    public enum MoveDirection
    {
        X, Y, Z
    }
}