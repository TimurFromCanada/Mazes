namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveRight(Robot robot, int width, int height)
		{
			if (width > 2)
				for (var i = 0; i < width - 3; i++)
					robot.MoveTo(Direction.Right);
		}

		public static void MoveDown(Robot robot, int width, int height)
		{
			if (height > 2)
				for (var i = 0; i < height - 3; i++)
					robot.MoveTo(Direction.Down);
		}

		public static void MoveOut(Robot robot, int width, int height)
		{
			MoveRight(robot, width, height);
			MoveDown(robot, width, height);
		}
	}
}