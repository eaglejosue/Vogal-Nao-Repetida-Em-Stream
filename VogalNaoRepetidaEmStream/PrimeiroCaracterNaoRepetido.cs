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
        public string _stream;
        private int indexOf = 0;

        public PrimeiroCaracterNaoRepetido(string stream)
        {
            _stream = stream.ToLower();
        }

        //Retorna próximo caracter do stream
        public char getNext()
        {
            return _stream[indexOf++];
        }

        //Valida se existem mais caracteres
        public bool hasNext()
        {
            return _stream.Length > indexOf;
        }
    }

    public class EncontraPrimeiraVogalNaoRepetida
    {   
        public char Encontra(IStream input)
        {
            var index = 0;
            var charsDoInput = new char[((PrimeiroCaracterNaoRepetido)input)._stream.Length];
            var shortDeQtdRepetidos = new short[((PrimeiroCaracterNaoRepetido)input)._stream.Length];

            while (input.hasNext())
            {
                var caracter = input.getNext();
                if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
                {
                    var indexDoCharAtual = ReturnIndex(caracter, charsDoInput);
                    if (indexDoCharAtual >= 0) shortDeQtdRepetidos[indexDoCharAtual]++;
                    else
                    {
                        charsDoInput[index] = caracter;
                        shortDeQtdRepetidos[index]++;
                        index++;
                    }
                }
            }

            //Seleciona o primeiro caracter não repetido
            int firstCharIndex = FirstIndex(shortDeQtdRepetidos);

            //Valida se encontrou
            if (firstCharIndex < 0) throw new Exception("Não existe char repetido.");

            return charsDoInput[firstCharIndex];
        }

        /// <summary>Retorna o índice do primeiro caracter que existe apenas uma vez</summary>
        /// <param name="qtdRepetidos"></param>
        private static int FirstIndex(short[] qtdRepetidos)
        {
            for (int i = 0; i < qtdRepetidos.Length; i++)
                if (qtdRepetidos[i] == 1) return i;
            
            return -1;
        }

        /// <summary>Pesquisa do caracter</summary>
        /// <param name="c"></param>
        /// <param name="chars"></param>
        private static int ReturnIndex(char c, char[] chars)
        {
            for (int i = 0; i < chars.Length; i++)
                if (c == chars[i]) return i;

            return -1;
        }
    }
}
