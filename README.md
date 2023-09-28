Passos realizados

1 - Instalação do FluentValidation.AspNetCore
2 - Criação da classe que receberá a validação
3 - Criação da pasta Validators ( onde ficarão as classes com as validações )
4 - Criação da classe CreateUserValidator que herdará AbstractValidator
5 - As validações irão dentro do construtor da classe
6 - Em Program adicionar using FluentValidation;
7 - Em Program, antes de builder.Services.AddControllers() incluir builder.Services.AddValidatorsFromAssemblyContaining<CreateUserValidator>()

A partir deste ponto já possível validar o objeto

Deixei no UserController as 3 possíveis formas de fazer a validação com comentários