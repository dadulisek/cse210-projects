// I added level system which tells player how many points they need to reach next level. It also shows them what level they are.

using System;

class Program
{
    static void Main(string[] args)
    {

        GoalManager gm1 = new GoalManager();

        gm1.Start();
    }
}