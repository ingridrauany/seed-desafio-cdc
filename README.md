## Desafio CDC
Setup
Ferramentas necessárias:

- Git
- .NET 6+
- Tool do entity framework (dotnet ef)

### Criando uma nova migration
Para criar uma nova migration você deverá executar o comando abaixo: 
```
dotnet ef --startup-project DesafioCDC/DesafioCDC migrations add InitialMigration
```

### Atualizando a base de dados
Os arquivos de migrations estão na pasta _Migrations_
Para executar as migrations via linha de comando é necessário informar onde o DbContext está sendo registrado. Para isto, use a opção --startup-project da tool do __donet ef__ 
```
dotnet ef --startup-project DesafioCDC/DesafioCDC database update
```
