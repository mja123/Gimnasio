﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter.Utils
{
    static class MaxCountOfChars
    {
        public static bool isAllow(string data, int maxCountOfChars)
        {
            //Valida si el string ingresado supera una cierta cantidad de caracteres.
            if (data.Length < maxCountOfChars)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}
