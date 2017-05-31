﻿using StackExchange.Redis;

namespace ESMonApp.Common
{
    public class RedisService
    {
        private static readonly IDatabase RedisDatabase;

        static RedisService()
        {
            RedisDatabase = ConnectionMultiplexer.Connect("121.40.49.97").GetDatabase();
        }

        public static IDatabase GetRedisDatabase() => RedisDatabase;
    }
}
