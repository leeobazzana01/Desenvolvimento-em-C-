# Desenvolvimento em C#
Esse repositório contém os conteúdos anotados durante Semana de Seminários para o **Desenvolvimento em C#**.

## Configurações Iniciais
Configurando ambiente para codificação em C# no Linux.

### 1. Instalando as Dependências
1. Instalar o VS Code na máquina 
2. Instalar o .NET SDK
```bashrc
sudo apt update
sudo apt install dotnet-sdk-8.0
dotnet --version
```
3. Extensões do VS Code 
```bashrc
C# (by Microsoft)
C# Dev Kit 
.NET install tool for Extension
Nuget Package Manager
REST Client
```

### 2. Criando um projeto
```bashrc
dotnet new console -o nomeprojetoCssharp
cd nomeprojetoCssharp
```
    
### 3. Rodando projeto
```bashrc
dotnet run 

Esse comanod irá rodar o clássico **Hello World!**
```

### 4. Compilar e Rodar
```bashrc
dotnet build
dotnet run
```
