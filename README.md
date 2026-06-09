# 🌐 IP-Info-Viewer

Утилита для получения, просмотра и анализа информации об IP-адресах. Проект содержит модули, реализованные на языках **C#** и **C++**.

---

## ✨ Особенности (Features)
* 🔍 Получение локального и внешнего IP-адреса устройства.
* 🛡 Валидация IPv4 и IPv6 адресов.
* 📊 (В разработке) Получение информации о провайдере (ISP) и геолокации через API.

---

## 🛠 Использование кода (Code Examples)

### 🔷 Модуль на C#
Пример кода для проверки корректности IP-адреса:

```csharp
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string ipAddressInput = "192.168.1.1";
        
        if (IPAddress.TryParse(ipAddressInput, out IPAddress address))
        {
            Console.WriteLine(\$"[ОК] IP-адрес {address} корректен.");
        }
        else
        {
            Console.WriteLine("[Ошибка] Неверный формат IP-адреса.");
        }
    }
}
```

### 🧱 Модуль на C++
Пример структуры для работы с IP-адресом в консоли:

```cpp
#include <iostream>
#include <string>

int main() 
{
    std::string ipAddress = "127.0.0.1";
    
    std::cout << "[Инфо] Анализ IP-адреса: " << ipAddress << std::endl;
    // Здесь будет логика обработки сокетов или вызова API
    
    return 0;
}
```

---

## ⚙ Требования (Requirements)
* **C#:** Runtime/SDK `.NET 6.0` или более новая версия.
* **C++:** Компилятор с поддержкой стандарта `C++17` (MSVC / GCC / Clang).

---

## 🚀 Как запустить (How to run)
1. Склонируйте этот репозиторий к себе на ПК.
2. Откройте интересующий проект (C# или C++) в вашей IDE (Visual Studio, Rider, VS Code).
3. Скомпилируйте и запустите проект.
