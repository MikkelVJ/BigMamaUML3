using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace BigMamaUML3
{
    class MenuItemNumberExist : Exception
    {
        public MenuItemNumberExist() : base()
        {

        }

        public MenuItemNumberExist(string message) : base()
        {
            Console.WriteLine(message);

        }
    }
}
