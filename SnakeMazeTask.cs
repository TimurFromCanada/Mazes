namespace Mazes
{
    public static class SnakeMazeTask
    {
        public static void MoveRightAndDown(Robot robot, int width)
        {
            for (var i = 0; i < width - 3; i++)
                robot.MoveTo(Direction.Right);

            for (var i = 0; i < 2; i++)
                robot.MoveTo(Direction.Down);
        }

        public static void MoveLeftAndDown(Robot robot, int width)
        {
            for (var i = 0; i < width - 3; i++)
                robot.MoveTo(Direction.Left);

            for (var i = 0; i < 2; i++)
                robot.MoveTo(Direction.Down);
        }

        public static void MoveLeft(Robot robot, int width)
        {
            for (var i = 0; i < width - 3; i++)
                robot.MoveTo(Direction.Left);
        }

        public static void MoveOut(Robot robot, int width, int height)
        {
            for (var i = 0; i < height / 2 - 1; i++)
            {
                if (i % 2 == 0)
                    MoveRightAndDown(robot, width);

                if (i % 2 != 0)
                    MoveLeftAndDown(robot, width);
            }
            MoveLeft(robot, width);
        }
    }
}