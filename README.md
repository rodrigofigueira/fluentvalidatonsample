# Passos realizados

- Instalação do FluentValidation.AspNetCore
- Criação da classe que receberá a validação
- Criação da pasta Validators ( onde ficarão as classes com as validações )
- Criação da classe CreateUserValidator que herdará AbstractValidator
- As validações irão dentro do construtor da classe
- Em Program adicionar using FluentValidation;
- Em Program, antes de builder.Services.AddControllers() incluir builder.Services.AddValidatorsFromAssemblyContaining<CreateUserValidator>()

A partir deste ponto já possível validar o objeto

Deixei no UserController as 3 possíveis formas de fazer a validação com comentários