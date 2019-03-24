Шаповалова Дарья
Тема: "Приемное отделение санатория"
Требования: Python 3.6, Django 2.1.3, PostgreSQL, OS Linux
Скачайте архив и распакуйте его
Откройте терминал. Пропишите следующие команды:
sudo apt-get install postgresql postgresql-contrib // установка базы данных и настройка
sudo -u postgres psql
CREATE DATABASE sanatorium;
CREATE USER admin WITH PASSWORD 'admin123';
GRAN ALL PRIVILEGES ON DATABASE sanatorium TO admin;
\q
sudo apt install python3.6 // установка python
cd course_project
python3 -m venv venv // установка виртуальной среды
source venv/bin/activate
python3 -m pip install --upgrade pip 
pip install -r requirements.txt // установка django и других требований
python manage.py migrate // настройка базы данных
python manage.py runserver // запуск сервера
Переходите по ссылке 127.0.0.1/home