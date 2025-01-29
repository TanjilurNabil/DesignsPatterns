using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singletone
{
    public sealed class DateTimeProvider
    {
        private static readonly DateTimeProvider instance = new DateTimeProvider();
        private DateTimeProvider()
        {
                
        }
        public static DateTimeProvider Instance
        {
            get
            {
                return instance;
            }
        }
        public string GetCurrentDateTime()
        {
            return DateTime.Now.ToString();
        }
    }
}
