using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_object_demo
{
    public class StubLogger : ILogger
    {
        private static StubLogger _stubLogger;
        private static object _lock = new object();
        private StubLogger()
        {
        }

        public static StubLogger GetLogger()
        {
            lock (_lock)
            {
                if(_stubLogger == null)
                {
                    _stubLogger = new StubLogger();
                }
            }

            return _stubLogger;
        }

        public void Log()
        {
        }
    }
}
