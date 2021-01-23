# Vogal não repetida em Stream

Algoritimo em c# onde dada uma stream, encontra o primeiro caracter Vogal, após uma consoante e que não se repita no resto da stream.

## Sobre o Projeto
Dada uma stream, encontre o primeiro caractere Vogal, após uma consoante, onde a mesma é antecessora a uma vogal e que não se repita no resto da stream. O termino da leitura da stream deve ser garantido através do método hasNext(), ou seja, retorna falso para o termino da leitura da stream. Voce tera acesso a leitura da stream através dos métodos de interface fornecidos ao termino do enunciado.

Premissas:

Uma chamada para hasNext() ir retornar se a stream ainda contem caracteres para processar.

Uma chamada para getNext() ir retornar o proximo caractere a ser processado na stream.

Não será possível reiniciar o fluxo da leitura da stream.

Não poderá ser utilizado nenhum framework .Net, apenas código nativo.

Exemplo:

Input:  aAbBABacafe

Output: e

No exemplo, ‘e’ é o primeiro caractere Vogal da stream que não se repete após a primeira

Consoante ‘f’o qual tem uma vogal ‘a’ como antecessora.

Segue o exemplo da interface:

public interface IStream {
    bool hasNext();
    char getNext();
}

## Resolução
Foi criada a Inteface IStream confome o enunciado e uma implementação Stream. Esta interface recebe uma String como parametro na sua construção que será usada no algoritimo para busca da primeira vogal não repetida. Todo o algoritimo para encontrar o caracter esta contido dentro da classe EncontraPrimeiraVogalNaoRepetida.

Dentro do pacote de testes encontra-se na classe VogalNaoRepetidaEmStreamTeste a qual testa alguns cenários, incluindo se foram ou não passado valores nulos, testa os métodos hasNext() e getNext() e obviamente casos em que deve e não deve ser encontra a vogal não repetida

* Os únicos framework .NET utilizados foram utilizados somente para os testes!
