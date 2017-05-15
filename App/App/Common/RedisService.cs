using StackExchange.Redis;

namespace ESMonApp.Common
{
    public class RedisService
    {
        private static readonly IDatabase RedisDatabase;

        static RedisService()
        {
            RedisDatabase = ConnectionMultiplexer.Connect("localhost").GetDatabase();
        }

        public static IDatabase GetRedisDatabase() => RedisDatabase;
    }
}
