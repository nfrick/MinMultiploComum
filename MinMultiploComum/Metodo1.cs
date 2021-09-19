using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMultiploComum {
    public static class Metodo1 {
        /// <summary>
        /// Calcula o MMC dos números em um IEnumerable
        /// </summary>
        /// <param name="numeros"></param>
        /// <returns>int</returns>
        public static int MMCdeEnumerable(IEnumerable<int> numeros) {
            var mmc = numeros.Min();
            foreach (var num in numeros) {
                var soma = mmc;
                while (soma % num != 0) {
                    soma += mmc;
                }
                mmc = soma;
            }
            return mmc;
        }

        /// <summary>
        /// Calcula o MMC dos números em uma faixa
        /// </summary>
        /// <param name="de"></param>
        /// <param name="ate"></param>
        /// <returns>integer</returns>
        public static int MMCdeRange(int de, int ate) {
            var mmc = de;
            for (var i = de; i <= ate; i++) {
                var soma = mmc;
                while (soma % i != 0) {
                    soma += mmc;
                }
                mmc = soma;
            }
            return mmc;
        }
    }
}
