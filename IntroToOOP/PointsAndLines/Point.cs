namespace PoinstAndLines
{
	class Point
	{
		private int x;
		private int y;

		public int X { get; set; }
		public int Y
		{
			get
			{
				return y;
			}
			set
			{
				y = value;
			}
		}

		public Point()
		{

		}

		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}
}
