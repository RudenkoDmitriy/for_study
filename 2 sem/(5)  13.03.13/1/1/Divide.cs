﻿using System;

namespace _1
{
    public class Divide : Operation
    {
        public override int Action()
        {
            return Left.Action() / Right.Action();
        }

        public override void PrintOperation()
        {
            Console.Write('/');
        }
    }
}
