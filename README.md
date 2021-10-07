# GFTTeste
Repositorio criado para avaliação GFT

Questão 1

A avaliação consiste em criar um projeto do Tipo ConsoleApplication e categorizar os Trades de um determinado Banco.

Novas Categorias poderiam ser solicitadas e o projeto requer que consigamos realizar esta operação sem impactar as categorias ja existentes e que seja fácil adicionar ou remover novas categorias.

Neste caso, optei por utilizar o padrão de projeto Strategy para separar as regras de negocio de cada categoria, isso me dará flexibilidade para alterações futuras das regras de negócio nas categorias existente, ou caso seja necessário adicionar e remover categorias sem maiores impactos.
    
Questão 2 

Deve-se criar uma classe chamada PEP, que implementará a interface ICategory que conterá a regra específica desta nova categoria, adicionar PEP como primeiro item na lista de Categoria na classe Category, além disso criar nova propriedade IsPoliticallyExposed na Interface ITrade e na sua implementação que servirá para criar a regra de negócio em PEP.
