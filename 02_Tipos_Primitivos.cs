using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp
{
    public static class Tipos_Primitivos
    {
        public static void ImprimirTipos() 
        {
            // Tipo inteiro de 8 bits com sinal
            sbyte SByte = -128; // Valores variam de -128 a 127
            Console.WriteLine($"sbyte: {SByte}");

            // Tipo inteiro de 8 bits sem sinal
            byte variavelByte = 255; // Valores variam de 0 255
            Console.WriteLine($"sbyte: {variavelByte}");

            // Tipo interio 16 bits com sinal 
            short variavelShort = -32768; // Valores variam de -32768 á 32768
            Console.WriteLine($"short: {variavelShort}");

            // Tipo inteiro 16 bits sem sinal 
            ushort variavelUShort = 65535; // Valores de 0 a 65535
            Console.WriteLine($"ushort: {variavelUShort}");

            // Tipo inteiro de 32 bits com sinal 
            int variavelInt = -2147483648; // Valores variam de -2147483648 a 2147483647
            Console.WriteLine($"int: {variavelInt}");

            // Tipo inteiro de 32 bits sem sinal
            uint variavelUInt = 4294967295; // Valores variam de 0 a 4294967295
            Console.WriteLine($"uint: {variavelUInt}");

            // Tipo inteiro de 64 bits com sinal
            long variavelLong = -9223372036854775808; // Valores variam de -9223372036854775808 a 9223372036854775807
            Console.WriteLine($"long: {variavelLong}");

            // Tipo inteiro de 64 bits sem sinal 
            ulong variavelULong = 18446744073709551615; // valores variam de de 0 a 18446744073709551615
            Console.WriteLine($"ulong: {variavelULong}");

            // Tipo de ponto flutuante de 32 bits
            float variavelFloat = 3.14f;
            Console.WriteLine($"float: {variavelFloat}");

            // Tipo de ponto fluante de 64 bits 
            double variavelDouble = 3.141592653589793;
            Console.WriteLine($"double: {variavelDouble}");

            // Tipo decimal de 128 bits, usado para valores monetários e financeiros
            decimal variavelDecimal = 79228162514264337593543950335M;
            Console.WriteLine($"decimal: {variavelDecimal}");

            // Tipo de caractere Unicode de 16 bits
            char variavelChar = 'A';
            Console.WriteLine($"char: {variavelChar}");

            // Tipo booleano que pode ser verdadeiro ou falso
            bool variavelBool = true;
            Console.WriteLine($"bool: {variavelBool}");

            // Tipo de valor nulo 
            object variavelObject = null;
            Console.WriteLine($"object: {variavelObject}");

            // Tipo string, sequencia de caracteres Unicode
            string variavelString = "Olá, Mundo!";
            Console.WriteLine($"string: {variavelString}");
        }
    }
}
