# EmprestimoAPI
 # Sou a Alexandre Gaspar, Desenvolvedor .NET, e estava procurando um desafio para poder fazer e melhorar os meus skills e encontrei esse.
 Para dar solução eu decidi uma estrutura de WEB API, baseada em serviços e injeção de dependência, também separei os serviços da persistência de dados, embora tenha usado armazenamento em memória.
Abaixo poderá ler o problema e verificar se a API funciona conforme.
# Empréstimos

Seu desafio será implementar um serviço que determine quais modalidades de empréstimo uma pessoa tem acesso.

## Exemplo

As modalidades de empréstimo que serão analisadas são:

- **Empréstimo pessoal**: Taxa de juros de 4%.
- **Empréstimo consignado**: Taxa de juros de 2%.
- **Empréstimo com garantia**: Taxa de juros de 3%.

As modalidades de empréstimo disponíveis para uma pessoa são baseadas em algumas variáveis específicas, são elas:

- **Idade**
- **Salário**
- **Localização**

Seu serviço recebe uma chamada para determinar quais modalidades de empréstimo uma pessoa tem acesso.

**[POST]** `{{host}}/customer-loans`

```json
{
  "age": 26,
  "cpf": "275.484.389-23",
  "name": "Vuxaywua Zukiagou",
  "income": 7000.00,
  "location": "SP"
}
```

Seu serviço deve retornar uma resposta contendo o nome do cliente e uma lista de empréstimos aos quais ele tem acesso,
com os respectivos tipos e taxas de juros.

```
HTTP/1.1 200 Ok
```

```json
{
  "customer": "Vuxaywua Zukiagou",
  "loans": [
    {
      "type": "PERSONAL",
      "interest_rate": 4
    },
    {
      "type": "GUARANTEED",
      "interest_rate": 3
    },
    {
      "type": "CONSIGNMENT",
      "interest_rate": 2
    }
  ]
}
```

## Requisitos

- Conceder o empréstimo pessoal se o salário do cliente for igual ou inferior a R$ 3000.
- Conceder o empréstimo pessoal se o salário do cliente estiver entre R$ 3000 e R$ 5000, se o cliente tiver menos de 30
  anos e residir em São Paulo (SP).
- Conceder o empréstimo consignado se o salário do cliente for igual ou superior a R$ 5000.
- Conceder o empréstimo com garantia se o salário do cliente for igual ou inferior a R$ 3000.
- Conceder o empréstimo com garantia se o salário do cliente estiver entre R$ 3000 e R$ 5000, se o cliente tiver
  menos de 30 anos e residir em São Paulo (SP).


