﻿using System;

namespace _1
{
    public class Add : Operation
    {
        public override int Action()
        {
            return Left.Action() + Right.Action();
        }

        public override void PrintOperation()
        {
            Console.Write('+');
        }
    }
}
