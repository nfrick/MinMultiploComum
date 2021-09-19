using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MinMultiploComum {
    class Program {
        static void Main()
        {
            var sw = new Stopwatch();

            // Método 1 - Usando função que calcula o MMC de números em uma faixa
            // Este método é mais rápido mas menos flexível
            sw.Start();
            var mmc1 = Metodo1.MMCdeRange(2, 20);
            sw.Stop();
            Console.WriteLine($"MMC 1 = {mmc1} em {sw.ElapsedTicks} ticks\n");

            // Método 2 - Usando função que calcula o MMC de uma coleção de números,
            // não necessariamente contiguos ou em ordem
            // Este método é mais lento porém mais flexível
            var numeros = Enumerable.Range(2, 19);
            sw.Reset();
            sw.Start();
            var mmc2 = Metodo2.MMCdeRange(2,20);
            sw.Stop();
            Console.WriteLine($"MMC 2 = {mmc2} em {sw.ElapsedTicks} ticks\n");

            Console.WriteLine("Provando que o MMC está correto:");
            foreach (var numero in numeros) {
                Console.WriteLine($"{mmc2} / {numero} = {mmc2 / numero} resto {mmc2 % numero}");
            }
        }
    }
}
