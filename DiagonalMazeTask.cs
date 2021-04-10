using System;

namespace Mazes
{
    //Рассматривая примеры лабиринтов можно заметить, что если мы возьмем целую часть от деления большей
    //величины из высоты лабиринта(без границ) и его ширины(без границ) на меньшую, то мы  получим кол-во
    //клеток, на которое надо сместиться вправо/вниз, а затем необходимо сместиться на одну клетку
    //вниз/вправо.
    //Повторять до тех пор, пока робот не выполнит задачу
    public static class DiagonalMazeTask
    {
        public static void MoveRightAndDown(Robot robot, int width, int height)
        {
            int a = (width - 2) / (height - 2); //получение целой части от деления ширины на высоту с вычитом границ
            Move(robot, a, Direction.Right, Direction.Down);
        }

        public static void MoveDownAndRight(Robot robot, int width, int height)
        {
            int a = (height - 2) / (width - 2); //получение целой части от деления высоты на ширину с вычитом границ
            Move(robot, a, Direction.Down, Direction.Right);
        }

        public static void MoveOut(Robot robot, int width, int height)
        {
            //Переменная, отвечающая за смещение на кол-во клеток, полученное делением
            while (robot.Finished == false)
            {
                if (width > height) MoveRightAndDown(robot, width, height);
                else MoveDownAndRight(robot, width, height);
            }
        }
        //метод, отвечающий за смещение робота
        public static void Move(Robot robot, int a, Direction firstDirection, Direction secondDirection)
        {
            if (!robot.Finished)
                for (var i = 0; i < a; i++)
                    robot.MoveTo(firstDirection);

            //смещение на кол-во клеток, полученное делением, если робот не закончил выполнение своей задачи
            if (!robot.Finished)
                robot.MoveTo(secondDirection); //смещение на 1 клетку, если робот не закончил выполнение своей задачи
        }
    }
}

