﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace _3._6.ChainOfResposability
{
    public class RequestE : RequestMessage
    {

        public override async Task InvokeAsync(Context context)
        {
            context.Msg += "E";
            Console.WriteLine("Processando E ...");
            Thread.Sleep(2000);
            await Next(context);

            Console.WriteLine("Terminando E ...");
            Thread.Sleep(2000);
        }
    }
}
