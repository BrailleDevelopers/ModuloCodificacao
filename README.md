# ModuloCodificacao

Este código é parte do desenvolvimento de um projeto de TCC nomeado como "Módulo de codificação para uma impressora Braille".

A linguagem utilizada é C# e o framework .NET, neste projeto poderá ser encontrado tanto a interface quanto a lógica relativa à codificação, o processo de codificação se baseia (resumindo de forma simplista) em uma conversão matricial de cada caractere braille em seus correspondentes binários por linha, seguido pela conversão para decimal, este processo é realizado três vezes para cada frase, visto que cada caractere possui 3 linhas e 2 colunas de pontos.

A lógica envolve mais do que uma simples atribuição com base no Dictionary, é necessário compreender as normas vigentes relativas ao Braille, logo, talvez no momento em que você estiver lendo isso a lógica já esteja desatualizada, é verdade tambem que por ser uma quantidade significativamente grande de normas não foram todas que puderam ser englobadas nesse código, entretanto estão incluídas algumas das mais relevantes, como formatos numéricos e caracteres maiúsculos individuais.
