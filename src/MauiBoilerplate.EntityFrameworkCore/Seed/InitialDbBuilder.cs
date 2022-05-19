using MauiBoilerplate.Core.Entities;
using System;

namespace MauiBoilerplate.EntityFrameworkCore.Seed
{
    internal class InitialDbBuilder
    {
        private MauiBoilerplateDbContext context;

        public InitialDbBuilder(MauiBoilerplateDbContext context)
        {
            this.context = context;
        }

        internal void Create()
        {
            this.context.Add(new Song()
            {
                MusicTitle="阴天快乐",
                Artist="陈奕迅",
                Album="米.闪",
                Duration=new TimeSpan(0, 3, 25),
                ReleaseDate=new DateTime(2014, 1, 1)

            });
        }
    }
}