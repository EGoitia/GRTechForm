using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GRTechnology1._0.Clases
{
    public static class CodigoBarras
    {
        public static string CodigoBarrasStr(string codigo)
        {
            string inicio = "NNnNnnNnnnn";    // caracter de inicio (Ñ), 104
            string final = "NNnnnNNNnNnNN";   // caracter de finalización (Ó), 106
            string datos = "";
            string codigo_bar = "";
            string bar = "";
            int num = 0;

            int n_check = 104; // empieza con el bit de inicio

            for (int i = 0; i < codigo.Length; i++)
            {
                int car = (int)codigo[i]; // Asc()
                bar = "";
                num = 0;
                CadenaCodigo(car, ref bar, ref num);
                datos += bar;
                n_check += num * (i + 1);
            }

            int aa = n_check % 103;
            if (aa < 95)
                aa += 32;
            else
                aa += 105;

            bar = "";
            num = 0;
            CadenaCodigo(aa, ref bar, ref num);
            string check = bar;

            return inicio + datos + check + final;
        }
        
        static void CadenaCodigo(int letra, ref string barra, ref int numero)
        {
            switch (letra)
            {
                // *****numeros*******
                case 48: barra = "NnnNNNnNNnn"; numero = 16; break; // 0
                case 49: barra = "NnnNNNnnNNn"; numero = 17; break; // 1
                case 50: barra = "NNnnNNNnnNn"; numero = 18; break; // 2
                case 51: barra = "NNnnNnNNNnn"; numero = 19; break; // 3
                case 52: barra = "NNnnNnnNNNn"; numero = 20; break; // 4
                case 53: barra = "NNnNNNnnNnn"; numero = 21; break; // 5
                case 54: barra = "NNnnNNNnNnn"; numero = 22; break; // 6
                case 55: barra = "NNNnNNnNNNn"; numero = 23; break; // 7
                case 56: barra = "NNNnNnnNNnn"; numero = 24; break; // 8
                case 57: barra = "NNNnnNnNNnn"; numero = 25; break; // 9

                // *****mayusculas*******
                case 65: barra = "NnNnnnNNnnn"; numero = 33; break; // A
                case 66: barra = "NnnnNnNNnnn"; numero = 34; break;
                case 67: barra = "NnnnNnnnNNn"; numero = 35; break;
                case 68: barra = "NnNNnnnNnnn"; numero = 36; break;
                case 69: barra = "NnnnNNnNnnn"; numero = 37; break;
                case 70: barra = "NnnnNNnnnNn"; numero = 38; break;
                case 71: barra = "NNnNnnnNnnn"; numero = 39; break;
                case 72: barra = "NNnnnNnNnnn"; numero = 40; break;
                case 73: barra = "NNnnnNnnnNn"; numero = 41; break;
                case 74: barra = "NnNNnNNNnnn"; numero = 42; break;
                case 75: barra = "NnNNnnnNNNn"; numero = 43; break;
                case 76: barra = "NnnnNNnNNNn"; numero = 44; break;
                case 77: barra = "NnNNNnNNnnn"; numero = 45; break;
                case 78: barra = "NnNNNnnnNNn"; numero = 46; break;
                case 79: barra = "NnnnNNNnNNn"; numero = 47; break;
                case 80: barra = "NNNnNNNnNNn"; numero = 48; break;
                case 81: barra = "NNnNnnnNNNn"; numero = 49; break;
                case 82: barra = "NNnnnNnNNNn"; numero = 50; break;
                case 83: barra = "NNnNNNnNnnn"; numero = 51; break;
                case 84: barra = "NNnNNNnnnNn"; numero = 52; break;
                case 85: barra = "NNnNNNnNNNn"; numero = 53; break;
                case 86: barra = "NNNnNnNNnnn"; numero = 54; break;
                case 87: barra = "NNNnNnnnNNn"; numero = 55; break;
                case 88: barra = "NNNnnnNnNNn"; numero = 56; break;
                case 89: barra = "NNNnNNnNnnn"; numero = 57; break;
                case 90: barra = "NNNnNNnnnNn"; numero = 58; break;

                // *****minusculas*******
                case 97: barra = "NnnNnNNnnnn"; numero = 65; break; // a
                case 98: barra = "NnnNnnnnNNn"; numero = 66; break;
                case 99: barra = "NnnnnNnNNnn"; numero = 67; break;
                case 100: barra = "NnnnnNnnNNn"; numero = 68; break;
                case 101: barra = "NnNNnnNnnnn"; numero = 69; break;
                case 102: barra = "NnNNnnnnNnn"; numero = 70; break;
                case 103: barra = "NnnNNnNnnnn"; numero = 71; break;
                case 104: barra = "NnnNNnnnnNn"; numero = 72; break;
                case 105: barra = "NnnnnNNnNnn"; numero = 73; break;
                case 106: barra = "NnnnnNNnnNn"; numero = 74; break;
                case 107: barra = "NNnnnnNnnNn"; numero = 75; break;
                case 108: barra = "NNnnNnNnnnn"; numero = 76; break;
                case 109: barra = "NNNNnNNNnNn"; numero = 77; break;
                case 110: barra = "NNnnnnNnNnn"; numero = 78; break;
                case 111: barra = "NnnnNNNNnNn"; numero = 79; break;
                case 112: barra = "NnNnnNNNNnn"; numero = 80; break;
                case 113: barra = "NnnNnNNNNnn"; numero = 81; break;
                case 114: barra = "NnnNnnNNNNn"; numero = 82; break;
                case 115: barra = "NnNNNNnnNnn"; numero = 83; break;
                case 116: barra = "NnnNNNNnNnn"; numero = 84; break;
                case 117: barra = "NnnNNNNnnNn"; numero = 85; break;
                case 118: barra = "NNNNnNnnNnn"; numero = 86; break;
                case 119: barra = "NNNNnnNnNnn"; numero = 87; break;
                case 120: barra = "NNNNnnNnnNn"; numero = 88; break;
                case 121: barra = "NNnNNnNNNNn"; numero = 89; break;
                case 122: barra = "NNnNNNNnNNn"; numero = 90; break;

                // *****simbolos*******
                case 32: barra = "NNnNNnnNNnn"; numero = 0; break; // espacio
                case 33: barra = "NNnnNNnNNnn"; numero = 1; break;
                case 34: barra = "NNnnNNnnNNn"; numero = 2; break;
                case 35: barra = "NnnNnnNNnnn"; numero = 3; break;
                case 36: barra = "NnnNnnnNNnn"; numero = 4; break;
                case 37: barra = "NnnnNnnNNnn"; numero = 5; break;
                case 38: barra = "NnnNNnnNnnn"; numero = 6; break;
                case 39: barra = "NnnNNnnnNnn"; numero = 7; break;
                case 40: barra = "NnnnNNnnNnn"; numero = 8; break;
                case 41: barra = "NNnnNnnNnnn"; numero = 9; break;
                case 42: barra = "NNnnNnnnNnn"; numero = 10; break;
                case 43: barra = "NNnnnNnnNnn"; numero = 11; break;
                case 44: barra = "NnNNnnNNNnn"; numero = 12; break;
                case 45: barra = "NnnNNnNNNnn"; numero = 13; break;
                case 46: barra = "NnnNNnnNNNn"; numero = 14; break;
                case 47: barra = "NnNNNnnNNnn"; numero = 15; break;
                case 58: barra = "NNNnnNnnNNn"; numero = 26; break;
                case 59: barra = "NNNnNNnnNnn"; numero = 27; break;
                case 60: barra = "NNNnnNNnNnn"; numero = 28; break;
                case 61: barra = "NNNnnNNnnNn"; numero = 29; break;
                case 62: barra = "NNnNNnNNnnn"; numero = 30; break;
                case 63: barra = "NNnNNnnnNNn"; numero = 31; break;
                case 64: barra = "NNnnnNNnNNn"; numero = 32; break;
                case 91: barra = "NNNnnnNNnNn"; numero = 59; break;
                case 92: barra = "NNNnNNNNnNn"; numero = 60; break;
                case 93: barra = "NNnnNnnnnNn"; numero = 61; break;
                case 94: barra = "NNNNnnnNnNn"; numero = 62; break;
                case 95: barra = "NnNnnNNnnnn"; numero = 63; break;
                case 96: barra = "NnNnnnnNNnn"; numero = 64; break;
                case 123: barra = "NNNNnNNnNNn"; numero = 91; break;
                case 124: barra = "NnNnNNNNnnn"; numero = 92; break;
                case 125: barra = "NnNnnnNNNNn"; numero = 93; break;
                case 126: barra = "NnnnNnNNNNn"; numero = 94; break;

                // caracteres especiales
                case 200:
                case 201:
                case 202:
                case 203:
                case 204:
                case 205:
                case 206:
                case 207:
                case 208:
                case 209:
                case 210:
                case 211:
                    barra = "NNnNnnnnNnn"; numero = 95; break;

                default: barra = ""; numero = -1; break; // por si no encuentra coincidencia
            }
        }

    }
}
