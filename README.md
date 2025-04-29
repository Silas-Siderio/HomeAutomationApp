# 🏠 HomeAutomationApp

Automação Residencial Inteligente com .NET MAUI, MQTT e IA local (ML.NET)

## 🚀 Funcionalidades
- Interface em .NET MAUI responsiva e moderna (tema escuro/claro automático)
- Controle de dispositivos IoT via protocolo MQTT (ex: ESP32)
- Armazenamento local com SQLite
- Inteligência Artificial embarcada (ML.NET) para prever eventos como presença, acionamento de luzes, etc.
- Pipeline de build automático com GitHub Actions
- Pronto para gerar instalador (.exe ou .msix)

## 📷 Captura de Tela (simulada)
![App Example](./Assets/app_preview.png)

## ⚙️ Tecnologias Utilizadas
- .NET MAUI (.NET 8)
- MQTTnet
- SQLite-net-pcl
- ML.NET
- GitHub Actions
- ESP32/ESP8266 (firmware Arduino opcional)

## 🧠 IA Inteligente no App
Utiliza ML.NET para prever:
- Movimento no ambiente
- Ação recomendada (ligar/desligar dispositivos)
- Com base em temperatura, umidade, hora do dia

## 🌐 Como Executar
```bash
git clone https://github.com/seuusuario/HomeAutomationApp.git
cd HomeAutomationApp
abra com Visual Studio 2022+ e publique via botão 'Publish'
```

## 🏗️ GitHub Actions
Cada push na branch `main` dispara um pipeline automático:
```yaml
.github/workflows/dotnet-maui.yml
```

## 🎨 Tema Escuro/Claro Automático
.NET MAUI já detecta o sistema operacional. Adicione no App.xaml:
```xml
<Application.Resources>
    <ResourceDictionary>
        <Style TargetType="ContentPage" ApplyToDerivedTypes="True">
            <Setter Property="BackgroundColor" Value="{AppThemeBinding Light=White, Dark=Black}" />
            <Setter Property="TextColor" Value="{AppThemeBinding Light=Black, Dark=White}" />
        </Style>
    </ResourceDictionary>
</Application.Resources>
```

## 🖥️ Publicação
- Clique direito no projeto → Publish → Folder → Gera .exe
- Ou crie .msix com Windows Packaging Project

---

## ❤️ Contribuição
PRs, estrelas e feedbacks são bem-vindos!

---

## 🧑‍💻 Autor
Silas Siderio | GitHub: [Silas-Siderio](https://github.com/Silas-Siderio)
