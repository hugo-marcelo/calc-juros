# calc-juros

## 💼 Sobre o projeto

API1 desenvolvida com uma funcionalidade:
- Endpoint /taxaJuros: Retornar a taxa de juros fixa no código.

API2 desenvolvida e integrada à API1 com três funcionalidades:
- Endpoint /showmethecode: Retornar a URL do repositório da aplicação no GitHub.

- Endpoint /calculajuros: Retornar o resultado de juros compostos aplicados ao valor inicial, em decimal, e a quantidade de meses informado, considerando a taxa retornada da API1.

## ⚙️ Tecnologias

- [ASP.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- [Docker](https://www.docker.com/)
- [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- [XUnit.net](https://github.com/xunit/xunit)

## 💻 Executando o projeto

**Clone o projeto e acesse a pasta**

```bash
$ git clone https://github.com/hugo-marcelo/calc-juros && cd calc-juros
```

**Execute os comandos abaixo**

```bash
docker-compose build
docker-compose up -d
```
   
**URL de acesso às APIs**

```bash
API1: http://localhost:4020/
API2: http://localhost:5020/
```

Made by Hugo Marcelo 👋 [Veja meu linkedin](https://www.linkedin.com/in/hugo-marcelo-dev/)
