# task-list-app-maui
App .NET MAUI multiplataforma usando arquitetura de desenvolvimento MVVM realizando operações CRUD com o EF Core InMemory.

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra como criar um App .NET MAUI multiplataforma usando arquitetura de desenvolvimento MVVM implementada com .NET Community Toolkit, realizando operações CRUD com o EF Core InMemory.

Inicie o emulador Android através do CLI acessando a pasta de instalação do Android SDK, algo como "...\Android\android-sdk\emulator", execute o comando para ver uma lista de nomes AVDs:

```
.\emulator -list-avds
```

Em seguida execute o emulador informando um AVD através do comando:

```
.\emulator -avd Android_Emulator_33 -netdelay none -netspeed full
```

No terminal do VS Code execute o comando para carregar o app no emulador:

```
dotnet build -t:Run -f:net8.0-android
```

<div align="center">
    <img src="https://github.com/jfs-dev/task-list-app-maui/assets/54154628/51f4be8f-9cf0-4dda-8da0-e5f0307f7091"</img>
</div>

<div align="center">
    <img src="https://github.com/jfs-dev/task-list-app-maui/assets/54154628/5d7a804f-29e7-4a0d-a093-84dcc67f652b"</img>
</div>

<div align="center">
    <img src="https://github.com/jfs-dev/task-list-app-maui/assets/54154628/44fe95df-15e6-4ffe-86a5-af750944afc5"</img>
</div>

<div align="center">
    <img src="https://github.com/jfs-dev/task-list-app-maui/assets/54154628/f9b012c8-f519-468a-b506-aa5859a9c075"</img>
</div>

<div align="center">
    <img src="https://github.com/jfs-dev/task-list-app-maui/assets/54154628/244f90be-4abc-4339-bd08-205a1bf92883"</img>
</div>

## Referências
https://learn.microsoft.com/en-us/dotnet/maui/

https://github.com/CommunityToolkit/dotnet/

https://github.com/CommunityToolkit/Maui/

https://developer.android.com/studio/run/emulator-commandline?hl=pt-br/

https://www.svgrepo.com/

## Licença
GPL-3.0 license
