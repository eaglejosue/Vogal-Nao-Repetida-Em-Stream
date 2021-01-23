using System;

namespace VogalNaoRepetidaEmStream
{
    public interface IStream
    {
        char getNext();
        bool hasNext();
    }

    public class PrimeiroCaracterNaoRepetido : IStream
    {
        public String stream;

        private int indexOf = 0;

        public PrimeiroCaracterNaoRepetido(String stream)
        {
            this.stream = stream;
        }

        //Retorna próximo caracter do stream
        public char getNext()
        {
            return this.stream[indexOf++];
        }

        //Valida se existem mais caracteres
        public Boolean hasNext()
        {
            return (this.stream.Length > indexOf);
        }
    }

    public class FindVogal
    {
        public char firstChar(IStream input)
        {
            char c;
            int index = 0;
            int found;
            char[] chars = new char[((PrimeiroCaracterNaoRepetido)(input)).stream.Length];
            short[] qtdRepetidos = new short[((PrimeiroCaracterNaoRepetido)(input)).stream.Length];

            while (input.hasNext())
            {
                c = input.getNext();
                found = returnIndex(c, chars);

                if (found >= 0)
                    qtdRepetidos[found]++;
                else
                {
                    chars[index] = c;
                    qtdRepetidos[index]++;
                    index++;
                }
            }

            //Seleciona o primeiro caracter não repetido
            int firstCharIndex = firstIndex(qtdRepetidos);

            //Valida se encontrou
            if (firstCharIndex < 0)
                throw new Exception("Não existe char repetido.");

            return chars[firstCharIndex];
        }

        /// <summary>
        /// Retorna o índice do primeiro caracter que se existe apenas uma vez
        /// </summary>
        /// <param name="qtdRepetidos"></param>
        /// <returns></returns>
        private static int firstIndex(short[] qtdRepetidos)
        {
            for (int i = 0; i < qtdRepetidos.Length; i++)
            {
                if (qtdRepetidos[i] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Pesquisa do caracter
        /// </summary>
        /// <param name="c"></param>
        /// <param name="chars"></param>
        /// <returns></returns>
        private static int returnIndex(char c, char[] chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if (c == chars[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
