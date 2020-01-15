using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks
{
    class Block
    {
        private int width;
        private int length;
        private int height;

        public Block(int[] block)
        {
            width = block[0];
            length = block[1];
            height = block[2];
        }

        public int GetWidth() {return width;}
        public int GetLength() { return length; }
        public int GetHeight() { return height; }
        public int GetVolume() { return width * length * height; }
        public int GetSurfaceArea() { return 2 * (width*length + length*height
                + width*height); }
    }
}
