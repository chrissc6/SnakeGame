﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Input
    {
        private static Hashtable keytable = new Hashtable();

        public static bool KeyPressed(Keys key)
        {
            if(keytable[key] == null)
            {
                return false;
            }
            return (bool)keytable[key];
        }

        public static void ChangeState(Keys key, bool state)
        {
            keytable[key] = state;
        }
    }
}
