# Шпаргалка по .NET CLI 10

## Создание проектов и решений

| Команда | Описание |
|---------|----------|
| `dotnet new sln -n MySolution` | Создание нового решения |
| `dotnet new console -n MyProject` | Создание консольного приложения |
| `dotnet new classlib -n MyLib` | Создание библиотеки классов |
| `dotnet new --list` | Показать все доступные шаблоны |

## Управление решениями (sln)

| Команда | Описание |
|---------|----------|
| `dotnet sln add MyProject.csproj` | Добавить проект в решение |
| `dotnet sln add project1/ project2/` | Добавить несколько проектов |
| `dotnet sln remove MyProject.csproj` | Удалить проект из решения |
| `dotnet sln list` | Показать все проекты в решении |

## Сборка и выполнение

| Команда | Описание |
|---------|----------|
| `dotnet restore` | Восстановить зависимости (автоматически при build) |
| `dotnet build` | Скомпилировать проект |
| `dotnet build -c Release` | Сборка в конфигурации Release |
| `dotnet clean` | Очистить выходные файлы (bin/, obj/) |
| `dotnet run` | Собрать и запустить проект |
| `dotnet run --project MyProject/` | Запуск конкретного проекта |
| `dotnet run -- arg1 arg2` | Запуск с аргументами командной строки |

## Управление зависимостями

| Команда | Описание |
|---------|----------|
| `dotnet add reference ../OtherProject.csproj` | Добавить ссылку на проект |
| `dotnet add package Newtonsoft.Json` | Добавить NuGet пакет |
| `dotnet add package Newtonsoft.Json -v 13.0.1` | Добавить конкретную версию пакета |
| `dotnet remove package Newtonsoft.Json` | Удалить пакет |
| `dotnet remove reference ../OtherProject.csproj` | Удалить ссылку на проект |
| `dotnet list package` | Показать установленные пакеты |
| `dotnet list reference` | Показать ссылки на проекты |

## Публикация

| Команда | Описание |
|---------|----------|
| `dotnet publish -c Release` | Публикация проекта |
| `dotnet publish -c Release -r win-x64` | Публикация для Windows x64 |
| `dotnet publish -c Release -r linux-x64` | Публикация для Linux x64 |
| `dotnet publish -c Release --self-contained` | Автономное развертывание |
| `dotnet publish -c Release --no-self-contained` | Зависимое от среды выполнения |

## Глобальные инструменты

| Команда | Описание |
|---------|----------|
| `dotnet tool install -g dotnet-ef` | Установить EF Core CLI глобально |
| `dotnet tool install --local dotnet-ef` | Установить EF Core локально для проекта |
| `dotnet tool list -g` | Показать глобальные инструменты |
| `dotnet tool update -g dotnet-ef` | Обновить глобальный инструмент |
| `dotnet tool uninstall -g dotnet-ef` | Удалить глобальный инструмент |

## Полезные флаги

| Флаг | Описание | Пример |
|------|----------|--------|
| `-c` или `--configuration` | Конфигурация сборки | `-c Release` |
| `-f` или `--framework` | Целевая версия .NET | `-f net8.0` |
| `-o` или `--output` | Выходная директория | `-o ./publish` |
| `-v` или `--verbosity` | Уровень детализации | `-v detailed` |
| `-r` или `--runtime` | Целевая среда выполнения | `-r linux-x64` |
| `--no-restore` | Не выполнять restore | `build --no-restore` |
| `--no-build` | Не выполнять build | `test --no-build` |

## Работа с проектами

| Команда | Описание |
|---------|----------|
| `dotnet add` | Добавить элемент (пакет, ссылку) |
| `dotnet remove` | Удалить элемент |
| `dotnet list` | Показать информацию о проекте |
| `dotnet nuget` | Работа с NuGet пакетами |
| `dotnet pack` | Создание NuGet пакета |
| `dotnet format` | Форматирование кода |
| `dotnet workload` | Управление рабочими нагрузками |

## Генерация документации

| Команда | Описание |
|---------|----------|
| `dotnet build /p:GenerateDocumentationFile=true` | Генерация XML документации |
| `dotnet doc` | Генерация документации API |

## Полезные команды

| Команда | Описание |
|---------|----------|
| `dotnet --info` | Показать информацию о .NET SDK |
| `dotnet --version` | Показать версию .NET SDK |
| `dotnet --list-sdks` | Показать установленные SDK |
| `dotnet --list-runtimes` | Показать установленные среды выполнения |

## Быстрые подсказки

1. **Tab-автодополнение** работает для шаблонов проектов
2. Команды можно выполнять из любой папки внутри проекта
3. Для получения справки используйте `--help`: `dotnet build --help`
4. Большинство команд поддерживают сокращенные формы флагов
5. Конфигурации хранятся в `.csproj` и `.sln` файлах

---

*Дополнительная информация: https://learn.microsoft.com/dotnet/core/tools/*