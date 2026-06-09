<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>IP Info Viewer</title>
    <style>
        body {
            font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, sans-serif;
            margin: 0;
            padding: 20px;
            background-color: #f6f8fa;
        }

        .language-buttons {
            display: flex;
            gap: 10px;
            margin-bottom: 20px;
        }

        .lang-btn {
            padding: 6px 12px;
            border: none;
            border-radius: 6px;
            cursor: pointer;
            font-size: 14px;
            font-weight: 600;
            transition: all 0.3s ease;
        }

        .lang-btn.active {
            background-color: #1f6feb;
            color: white;
        }

        .lang-btn.inactive {
            background-color: #d1d5da;
            color: #24292f;
        }

        .lang-btn:hover {
            opacity: 0.8;
        }

        .content {
            background: white;
            padding: 20px;
            border-radius: 8px;
            border: 1px solid #d0d7de;
        }

        h2 {
            margin-top: 0;
            color: #24292f;
        }

        ul {
            line-height: 1.8;
            color: #424242;
        }
    </style>
</head>
<body>

    <div class="language-buttons">
        <button class="lang-btn active" onclick="changeLanguage('ru')">
            🇷🇺 Russian (RU)
        </button>
        <button class="lang-btn inactive" onclick="changeLanguage('en')">
            🇬🇧 English (EN)
        </button>
    </div>

    <div class="content">
        <!-- РУССКИЙ ТЕКСТ -->
        <div id="ru-content">
            <h2>⚡ Возможности</h2>
            <ul>
                <li>Показывает локальный IP адрес (IPv4 и IPv6)</li>
                <li>Отображает имя компьютера в сети</li>
                <li>Получает публичный (глобальный) IP адрес</li>
                <li>Показывает геолокацию по IP</li>
                <li>Красивый интерфейс с иконками</li>
            </ul>

            <h2>🚀 Установка</h2>
            <p><code>git clone https://github.com/username/IP-Info-Viewer.git</code></p>
        </div>

        <!-- АНГЛИЙСКИЙ ТЕКСТ -->
        <div id="en-content" style="display: none;">
            <h2>⚡ Features</h2>
            <ul>
                <li>Displays local IP address (IPv4 and IPv6)</li>
                <li>Shows computer name on the network</li>
                <li>Gets public (global) IP address</li>
                <li>Shows geolocation by IP</li>
                <li>Beautiful interface with icons</li>
            </ul>

            <h2>🚀 Installation</h2>
            <p><code>git clone https://github.com/username/IP-Info-Viewer.git</code></p>
        </div>
    </div>

    <script>
        function changeLanguage(lang) {
            // Получаем элементы контента
            const ruContent = document.getElementById('ru-content');
            const enContent = document.getElementById('en-content');
            
            // Получаем кнопки
            const ruBtn = document.querySelectorAll('.lang-btn')[0];
            const enBtn = document.querySelectorAll('.lang-btn')[1];

            if (lang === 'ru') {
                ruContent.style.display = 'block';
                enContent.style.display = 'none';
                ruBtn.classList.add('active');
                ruBtn.classList.remove('inactive');
                enBtn.classList.remove('active');
                enBtn.classList.add('inactive');
            } else {
                ruContent.style.display = 'none';
                enContent.style.display = 'block';
                ruBtn.classList.remove('active');
                ruBtn.classList.add('inactive');
                enBtn.classList.add('active');
                enBtn.classList.remove('inactive');
            }
        }
    </script>

</body>
</html>
