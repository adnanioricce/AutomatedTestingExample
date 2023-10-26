# Exemplo de Testes Automatizados

Esta solução é apenas um exemplo de vários tipos de testes automatizados (Testes Unitários, Testes de Integração, Testes de Aceitação, Testes de Desempenho) usando o NUnit e o Playwright (para os testes de aceitação), juntamente com um serviço Worker que executa um trabalho Quartz.NET a cada duas horas.

## Pré-Requisitos

Antes de começar, certifique-se de ter os seguintes pré-requisitos instalados no seu sistema:

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Playwright.NET](https://playwright.dev/dotnet/docs/intro)
- [Quartz.NET](https://www.quartz-scheduler.net/)
- Framework de teste NUnit (geralmente incluído na maioria dos projetos .NET)

## Compilando a Solução

Para compilar a solução, siga estas etapas:

1. Clone este repositório para a sua máquina local:

   ```bash
   git clone https://github.com/adnanioricce/AutomatedTesting.git
   ```

2. Navegue até a pasta raiz da solução.

3. Abra um terminal ou prompt de comando.

4. Execute o seguinte comando para compilar a solução:

   ```bash
   dotnet build
   ```

## Executando Testes Unitários, Testes de Integração e Testes de Desempenho

Para executar os diferentes tipos de testes, utilize os seguintes comandos:

- **Testes Unitários**: O NUnit é comumente usado para executar testes unitários em projetos .NET.

   ```bash
   dotnet test SeuProjetoDeTestesUnitarios
   ```

- **Testes de Integração**: Você também pode executar testes de integração usando o NUnit. Certifique-se de que seu projeto de testes de integração esteja configurado adequadamente.

   ```bash
   dotnet test SeuProjetoDeTestesDeIntegracao
   ```

- **Testes de Desempenho**: Se você tiver testes de desempenho em sua solução, utilize o seguinte comando para executá-los:

   ```bash
   dotnet run -c Release --project SeuProjetoDeTestesDeDesempenho
   ```

## Executando Testes de Aceitação

O projeto de Testes de Aceitação utiliza o Playwright.NET para automação de interface de usuário. Certifique-se de ter o Playwright.NET configurado para o seu projeto.

Para executar os Testes de Aceitação:

1. Navegue até a pasta do projeto de Testes de Aceitação.

2. Abra um terminal ou prompt de comando.

3. Execute o seguinte comando:

   ```bash
   dotnet test
   ```

## Executando o Serviço Worker

O serviço Worker é construído usando o Quartz.NET e é projetado para executar cada projeto a cada 2 horas. Siga estas etapas para executar o serviço Worker:

1. Navegue até a pasta do projeto de Serviço Worker.

2. Abra um terminal ou prompt de comando.

3. Execute o seguinte comando:

   ```bash
   dotnet run
   ```

O serviço Worker agendará e executará os vários projetos nos intervalos especificados.