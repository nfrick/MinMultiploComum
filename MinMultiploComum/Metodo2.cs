using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMultiploComum {
    public static class Metodo2 {
        /// <summary>
        /// Calcula o MMC de um IEnumerable de ints, não necessariamente contíguo ou em ordem
        /// </summary>
        /// <param name="numeros"></param>
        /// <returns>integer</returns>
        public static int MMCdeEnumerable(IEnumerable<int> numeros) {
            return numeros.Aggregate(numeros.Min(), (current, numero) => MMC(current, numero));
        }

        public static int MMCdeRange(int de, int ate) {
            return MMCdeEnumerable(Enumerable.Range(de, ate - de + 1));
        }

        /// <summary>
        /// MDC pelo Algoritmo de Euclides
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int MDC(int a, int b) {
            return b == 0 ? a : MDC(b, a % b);
        }

        /// <summary>
        /// MMC de dois números usando o MDC de Euclides
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>integer</returns>
        public static int MMC(int a, int b) {
            return a / MDC(a, b) * b;
        }
    }
}
