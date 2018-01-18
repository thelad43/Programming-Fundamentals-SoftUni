namespace _06.Rectangle_Position
{
    public class Rectangle
    {
        private int left;
        private int top;
        private int width;
        private int height;
        private int right;
        private int bottom;

        public Rectangle(int left, int top, int width, int height, int right, int bottom)
        {
            this.Left = left;
            this.Top = top;
            this.Width = width;
            this.Height = height;
            this.Right = right;
            this.Bottom = bottom;
        }

        public int Top
        {
            get
            {
                return this.top;
            }
            private set
            {
                this.top = value;
            }
        }

        public int Left
        {
            get
            {
                return this.left;
            }
            private set
            {
                this.left = value;
            }
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.height = value;
            }
        }

        public int Right
        {
            get
            {
                return this.right;
            }
            private set
            {
                this.right = value;
            }
        }

        public int Bottom
        {
            get
            {
                return this.bottom;
            }
            private set
            {
                this.bottom = value;
            }
        }
    }
}