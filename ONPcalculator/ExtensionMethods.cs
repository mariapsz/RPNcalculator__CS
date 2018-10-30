using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ONPcalculator {
    public static class ExtensionMethods {
        public static void RemoveLast(this ArrayList al) {
            if (al.Count > 0)
                al.RemoveAt(al.Count - 1);
        }

        public static string Last(this ArrayList al) {
            if (al.Count > 0) {
                return (string)al[al.Count - 1];
            }
            return null;
        }

        public static string RemoveLastChar(this String s) {
            if (s.Length > 0)
                return s.Remove(s.Length - 1);
            return null;
        }

        public static string LastChar(this String s) {
            if (s.Length > 0)
                return Convert.ToString(s[s.Length - 1]);
            else return null;
        }
    }  
}
