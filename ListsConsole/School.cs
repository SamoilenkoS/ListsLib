using System;
using System.Collections.Generic;
using System.Text;

namespace ListsConsole
{
    public class School
    {
        private static School _instance;

        private School() { }

        public static School Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new School();
                }

                return _instance;
            }
        }
    }
}
