using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
  10.06.2020 - first
*/

namespace Mkey
{
    public static class TextExtension
    {
        public static void SetText(Text text, string textString)
        {
            if (text) text.text = textString;
        }
    }
}